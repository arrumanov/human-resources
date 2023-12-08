using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Core;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.Search;
using Lucene.Net.Store;
using Lucene.Net.Util;
using HR.Infrastructure.SearchEngine.Api;
using HR.Infrastructure.SearchEngine.Models;
using Directory = Lucene.Net.Store.Directory;

namespace HR.Infrastructure.SearchEngine.Impl;
public class SearchEngine : ISearchEngine
{
	private const LuceneVersion MATCH_LUCENE_VERSION = LuceneVersion.LUCENE_48;
	private readonly string defaultPath;

	private const int SNIPPET_LENGTH = int.MaxValue;
	private const string KEY_ID = "object_id";

	private readonly Analyzer analyzer;

	private IndexWriter writer;
	private SearcherManager searchManager;
	//private readonly QueryParser queryParser;

	public SearchEngine(string basePath)
	{
		analyzer = SetupAnalyzer();

		defaultPath = basePath + "\\lucene_index";
		//queryParser = SetupQueryParser(analyzer);
	}


	private void Initialization(string folderName)
	{
		var configt = new IndexWriterConfig(MATCH_LUCENE_VERSION, analyzer)
		{
			WriteLockTimeout = 5000
		};
		writer = new IndexWriter(GetDirectory(folderName), configt);
		searchManager = new SearcherManager(writer, true, null);
	}

	private Directory GetDirectory(string folderName)
	{
		//return new RAMDirectory();
		return FSDirectory.Open(defaultPath + "\\" + folderName);
	}

	private static Analyzer SetupAnalyzer()
	{
		//https://stackoverflow.com/questions/5483903/comparison-of-lucene-analyzers
		return new KeywordAnalyzer();
	}

	#region Index

	public void BuildIndex(BuildIndexRequest request)
	{
		Initialization(request.KeyIndex);
		var indexObjects = request.IndexObjects;
		if (indexObjects == null)
		{
			throw new ArgumentNullException();
		}
		var keyValueType = new KeyValue("object_key", "object_key" + "_" + request.KeyIndex, KeyValueType.Other);
		foreach (var indexObject in indexObjects)
		{
			indexObject.KeyValues.Add(new KeyValue(KEY_ID, indexObject.Id, KeyValueType.Guid));
			indexObject.KeyValues.Add(keyValueType);
			writer.UpdateDocument(new Term(KEY_ID, indexObject.Id), BuildDocument(indexObject));
		}
		writer.Flush(true, true);
		writer.Commit();

	}

	private static Document BuildDocument(IndexObject obj)
	{
		var doc = new Document();
		foreach (var item in obj.KeyValues)
		{
			Field field;
			if (item.Value == null)
			{
				field = new StringField(item.Key, string.Empty, Field.Store.NO);
			}
			else
			{
				switch (item.Type)
				{

					case KeyValueType.Text:
						field = new TextField(item.Key, item.Value.ToLower(), Field.Store.YES);
						break;
					case KeyValueType.Guid:
						field = new StringField(item.Key, item.Value.ToLower(), Field.Store.YES);
						break;

					case KeyValueType.String:
						field = new StringField(item.Key, item.Value.ToLower(), Field.Store.YES);
						break;
					case KeyValueType.Other:
						field = new StringField(item.Key, item.Value.ToLower(), Field.Store.YES);
						break;
					case KeyValueType.Date:
						field = new StringField(item.Key, DateTools.DateToString(DateTime.Parse(item.Value), DateTools.Resolution.DAY), Field.Store.YES);
						break;
					case KeyValueType.Int:
						field = new Int32Field(item.Key, int.Parse(item.Value), Field.Store.YES);

						break;
					default:
						throw new ArgumentOutOfRangeException();
				}


			}

			doc.Add(field);
		}

		;
		return doc;
	}

	public void RemoveIndexAll()
	{
		writer.DeleteAll();
		writer.Commit();
	}

	public void RemoveIndex(BuildIndexRequest request)
	{
		Initialization(request.KeyIndex);
		var indexObjects = request.IndexObjects;
		if (indexObjects == null)
		{
			throw new ArgumentNullException();
		}
		var keyValueType = new KeyValue("object_key", "object_key" + "_" + request.KeyIndex, KeyValueType.Other);
		foreach (var indexObject in indexObjects)
		{
			indexObject.KeyValues.Add(new KeyValue(KEY_ID, indexObject.Id, KeyValueType.Guid));
			indexObject.KeyValues.Add(keyValueType);
			writer.DeleteDocuments(new Term(KEY_ID, indexObject.Id));
		}
		writer.Flush(true, true);
		writer.Commit();
	}
	#endregion

	public SearchResponse Search(SearchRequest request)
	{
		Initialization(request.KeyIndex);
		Query query = BuildQuery(request);
		searchManager.MaybeRefreshBlocking();
		IndexSearcher searcher = searchManager.Acquire();
		try
		{
			TopDocs topdDocs = searcher.Search(query, SNIPPET_LENGTH);
			return CompileResults(searcher, topdDocs);
		}
		finally
		{
			searchManager.Release(searcher);
			searcher = null;
		}
	}

	private SearchResponse CompileResults(IndexSearcher searcher, TopDocs topdDocs)
	{
		var searchResults = new SearchResponse() { TotalCount = topdDocs.TotalHits };
		foreach (var result in topdDocs.ScoreDocs)
		{
			var document = searcher.Doc(result.Doc);
			var value = document.GetField(KEY_ID);
			if (value == null)
				continue;
			var searchResult = Guid.Parse(document.GetField(KEY_ID)?.GetStringValue());
			searchResults.ObjectsId.Add(searchResult);
		}

		return searchResults;
	}


	private Query BuildQuery(SearchRequest request)
	{
		if (request.Filters == null)
		{
			throw new NullReferenceException();
		}
		var mainQuery = new BooleanQuery();
		foreach (var filter in request.Filters)
		{
			var innerOrQuery = new BooleanQuery();
			if (filter.FilterMode == FilterMode.Between)
			{
				var upperDate = DateTools.DateToString(DateTime.Parse(filter.Values[0]), DateTools.Resolution.DAY);
				var lowerDate = DateTools.DateToString(DateTime.Parse(filter.Values[1]), DateTools.Resolution.DAY);

				var lowerRange = new TermRangeQuery(filter.Key, new BytesRef(upperDate), new BytesRef(lowerDate), true, true);
				//var upperRange = new TermRangeQuery(filter.Key, , null, true, true);
				innerOrQuery.Add(new BooleanClause(lowerRange, Occur.MUST));
				//innerOrQuery.Add(new BooleanClause(upperRange, Occur.MUST));
			}
			else if (filter.FilterMode == FilterMode.BetweenForInt)
			{
				var rangeQuery = NumericRangeQuery.NewInt32Range(filter.Key,
					int.Parse(filter.Values[0]) == 0 ? null : int.Parse(filter.Values[0]),
					int.Parse(filter.Values[1]) == 0 ? null : int.Parse(filter.Values[1]),
					true, true);
				innerOrQuery.Add(new BooleanClause(rangeQuery, Occur.MUST));
			}
			else
			{
				foreach (var value in filter.Values)
				{
					var term = new Term(filter.Key, value.ToLower());
					if (filter.FilterMode == FilterMode.Like)
					{

						innerOrQuery.Add(new WildcardQuery(new Term(filter.Key, "*" + value.ToLower() + "*")), Occur.SHOULD);
						//var pq = parser.CreateMinShouldMatchQuery(filter.Key, value.ToLower(), 0.5f);

						//return new FuzzyQuery(term, 1, 0);

						//innerOrQuery.Add(pq, Occur.SHOULD);
						//.Select(item => new TermQuery(new Term(filter.Key, item.ToLower())))
					}
					else
					{
						//or
						innerOrQuery.Add(new TermQuery(term), Occur.SHOULD);

					}

				}

			}
			//and
			mainQuery.Add(innerOrQuery, Occur.MUST);
		}

		return mainQuery;
	}

	public void Dispose()
	{
		searchManager?.Dispose();
		analyzer?.Dispose();
		writer?.Dispose();
	}
}
