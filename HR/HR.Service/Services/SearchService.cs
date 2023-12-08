using HR.CrossCutting.Constants;
using HR.CrossCutting.Enum;
using HR.CrossCutting.Extentions;
using HR.Infrastructure.DataAccess;
using HR.Infrastructure.SearchEngine.Api;
using HR.Infrastructure.SearchEngine.Models;
using HR.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ObjectType = HR.CrossCutting.Enum.ObjectType;

namespace HR.Service.Services;
public class SearchService : ISearchService
{
	private readonly HrContext _context;
	private readonly IServiceProvider _serviceProvider;

	public SearchService(HrContext context, IServiceProvider serviceProvider)
	{
		_context = context;
		_serviceProvider = serviceProvider;
	}

	public async Task BuildIndex(List<Guid> objectsId, string key, ObjectType objectType)
	{
		//из-за вот этой проблемы: https://stackoverflow.com/questions/7804201/sql-server-query-processor-ran-out-of-internal-resources
		foreach (var objectsIdChunk in objectsId.Chunk(size: 10000))
		{
			var request = await GetBuildIndexRequest(objectsIdChunk.ToList(), key, objectType);
			BuildIndex(request);
		}
	}

	private async Task<BuildIndexRequest> GetBuildIndexRequest(List<Guid> objectsId, string key, ObjectType objectType)
	{
		Dictionary<Guid, List<KeyValue>> objectKeyValue;
		if (objectType == ObjectType.Resource)
		{
			objectKeyValue = await GenerateResourceKeyValueByObject(objectsId);
		}
		#region
		//else if (type == typeof(ProjectService))
		//{
		//	objectKeyValue = GenerateProjectKeyValueByObject(objectsId);
		//}
		//else if (type == typeof(TaskService))
		//{
		//	objectKeyValue = GenerateTaskKeyValueByObject(objectsId);
		//}
		//else if (type == typeof(TrainingService))
		//{
		//	objectKeyValue = GenerateTrainingKeyValueByObject(objectsId);
		//}
		//else if (type == typeof(CareerDevelopmentDayService))
		//{
		//	objectKeyValue = GenerateCareerDevelopmentDayKeyValueByObject(objectsId);
		//}
		//else if (type == typeof(AchievementService))
		//{
		//	if (key.Equals(SearchConst.CddLikeIndex))
		//	{
		//		return GetBuildIndexRequestForCddLike(
		//			GenerateCareerDevelopmentDayKeyValueByObjectLike(objectsId));
		//	}
		//	else
		//	{
		//		objectKeyValue = GenerateAchievementKeyValueByObject(objectsId);
		//	}
		//}
		//else if (type == typeof(QuestionnaireService))
		//{
		//	objectKeyValue = GenerateFormKeyValueByObject(objectsId);
		//}
		//else if (type == typeof(MeetingService))
		//{
		//	objectKeyValue = GenerateMeetingKeyValueByObject(objectsId);
		//}
		//else if (type == typeof(AdaptationService))
		//{
		//	objectKeyValue = GenerateAdaptationKeyValueByObject(objectsId);
		//}
		//else if (type == typeof(AttendanceService))
		//{
		//	objectKeyValue = GenerateAttendanceKeyValueByObject(objectsId);
		//}
		//else if (type == typeof(MentoringService))
		//{
		//	objectKeyValue = GenerateMentoringKeyValueByObject(objectsId);
		//}
		//else if (type == typeof(ExitInterviewService))
		//{
		//	objectKeyValue = GenerateExitInterviewKeyValueByObject(objectsId);
		//}
		//else if (type == typeof(DismissalRequestService))
		//{
		//	objectKeyValue = GenerateDismissalRequestKeyValueByObject(objectsId);
		//}
		//else if (type == typeof(PersonnelReserveService))
		//{
		//	objectKeyValue = GeneratePersonnelReserveKeyValueByObject(objectsId);
		//}
		//else if (type == typeof(PositionResponseService))
		//{
		//	objectKeyValue = GeneratePositionResponseKeyValueByObject(objectsId);
		//}
		//else if (type == typeof(KeyResourceService))
		//{
		//	objectKeyValue = GenerateKeyResourceKeyValueByObject(objectsId);
		//}
		//else if (type == typeof(ShareResourceService))
		//{
		//	objectKeyValue = GenerateShareResourceKeyValueByObject(objectsId);
		//}
		//else if (type == typeof(CandidateService))
		//{
		//	objectKeyValue = GenerateCandidateKeyValueByObject(objectsId);
		//}
		//else if (type == typeof(MentorshipService))
		//{
		//	objectKeyValue = GenereateMentorshipKeyValueByObject(objectsId);
		//}
		//else if (type == typeof(GratitudeService))
		//{
		//	objectKeyValue = GenereateGratitudeKeyValueByObject(objectsId);
		//}
		//else if (type == typeof(IndividualDevelopmentPlanService))
		//{
		//	objectKeyValue = GenerateIndividualDevelopmentPlanValueByObject(objectsId);
		//}
		//else if (type == typeof(SecretSantaService))
		//{
		//	objectKeyValue = GenerateSecretSantaKeyValueByObject(objectsId);
		//}
		#endregion
		else
		{
			throw new Exception();
		}

		var listCustomFieldValue = await _context.CustomFieldValues
			.Include(item => item.CustomFieldValueLanguages)
			.Where(item => objectsId.Contains(item.ObjectId))
			.ToListAsync();

		var listCustomField = await _context.CustomFields.ToListAsync();

		var request = new BuildIndexRequest(key);

		foreach (var objectId in objectsId)
		{
			if (!objectKeyValue.ContainsKey(objectId))
			{
				continue;
			}

			var indexObject = new IndexObject()
			{
				Id = objectId.ToFormatString()
			};
			request.IndexObjects.Add(indexObject);
			var objKeyValue = objectKeyValue[objectId];
			if (objKeyValue != null)
			{
				indexObject.KeyValues.AddRange(objKeyValue);
			}

			foreach (var customFieldValue in listCustomFieldValue.Where(item => item.ObjectId == objectId))
			{
				var cf = listCustomField.FirstOrDefault(item => item.FieldKey == customFieldValue.FieldKey);


				if (cf == null)
					continue;
				foreach (var value in customFieldValue.GetViewValue(cf))
				{
					KeyValueType keyValueType;
					switch (cf.Type)
					{
						case CustomFieldType.Text:
						case CustomFieldType.DecimalWithPostfix:
						case CustomFieldType.Textarea:
							keyValueType = KeyValueType.Text;
							break;

						case CustomFieldType.ComboBox:
						case CustomFieldType.ComboBoxVirtualization:
						case CustomFieldType.EnumComboBox:
						case CustomFieldType.Multiselect:
						case CustomFieldType.MultiselectVirtualization:
						case CustomFieldType.Tags:
						case CustomFieldType.MultiuserPicker:
							keyValueType = KeyValueType.Guid;
							break;

						case CustomFieldType.TagsWithLevel:
							keyValueType = KeyValueType.Guid;
							//для поиска по метке с любым уровнем
							indexObject.KeyValues.Add(new KeyValue(customFieldValue.FieldKey,
								GetKeyOfTagWithLevel(value), keyValueType));
							//для поиска по метке с определенным уровнем добавляется после блока switch
							break;
						case CustomFieldType.Bool:
						case CustomFieldType.Int:
						case CustomFieldType.Decimal:
						case CustomFieldType.CheckBox:
							keyValueType = KeyValueType.String;
							break;
						case CustomFieldType.Date:
							keyValueType = KeyValueType.Date;
							break;

						case CustomFieldType.Color:
							keyValueType = KeyValueType.Other;
							break;
						default:
							throw new ArgumentOutOfRangeException();
					}

					indexObject.KeyValues.Add(new KeyValue(customFieldValue.FieldKey, value,
						keyValueType));
				}
			}
		}

		return request;
	}

	private BuildIndexRequest GetBuildIndexRequestForCddLike(Dictionary<Guid, List<KeyValue>> objectKeyValue)
	{
		var request = new BuildIndexRequest(SearchConst.CddLikeIndex);
		foreach (var dictItem in objectKeyValue)
		{
			var indexObject = new IndexObject
			{
				Id = dictItem.Key.ToFormatString()
			};
			request.IndexObjects.Add(indexObject);
			indexObject.KeyValues.AddRange(dictItem.Value);
		}

		return request;
	}

	private static string GetKeyOfTagWithLevel(string tagWithlevel)
	{
		return tagWithlevel.Split(UtilityConst.SplitterBetweenTagAndLevel).First();
	}

	private async Task<Dictionary<Guid, List<KeyValue>>> GenerateResourceKeyValueByObject(List<Guid> objectsId)
	{
		var objectKeyValue = new Dictionary<Guid, List<KeyValue>>();

		var resources = await _context.Resources
			//.Include(item => item.Translations)
			//	.Include(item => item.CustomFieldValues)
				//.Include(item => item.Position)
				//.ThenInclude(p => p.Translations)
				//.Include(item => item.Status)
				//.ThenInclude(s => s.Translations)
				//.Include(item => item.ResourceManager)
				//.ThenInclude(rm => rm.Translations)
				//.Include(item => item.PermissionsForObject)
				//.ThenInclude(po => po.ObjectResource)
				//.ThenInclude(or => or.Translations)
				//.Include(item => item.ResourceColors)
				.Where(item => objectsId.Contains(item.Id))
				.ToListAsync();

		var resourceNameKey = FieldKeyConst.CFLike;
		foreach (var resource in resources)
		{
			var keyValues = new List<KeyValue>
			{
				new KeyValue(FieldKeyConst.CFEmail, resource.Email!, KeyValueType.Text),
				new KeyValue(FieldKeyConst.CFObjectName, resource.Id.ToString(), KeyValueType.Guid),
				new KeyValue(FieldKeyConst.CFIsActive, resource.IsActive.ToString(), KeyValueType.Guid),
				new KeyValue(FieldKeyConst.CFRate, resource.Rate.ToFormatString(), KeyValueType.Guid),
				new KeyValue(FieldKeyConst.CFIsExternal, resource.IsExternal.ToString(), KeyValueType.Guid),
				new KeyValue(FieldKeyConst.CFStatus, resource.StatusId.ToString()!, KeyValueType.Guid),
				new KeyValue(FieldKeyConst.CFPosition, resource.PositionId.ToString()!, KeyValueType.Guid),
				new KeyValue(FieldKeyConst.CFUnit, resource.DepartmentId.ToString()!, KeyValueType.Guid),
				new KeyValue(FieldKeyConst.CFUnit, resource.UpperUnitId.ToString()!, KeyValueType.Guid),
				new KeyValue(FieldKeyConst.CFResourceManager, resource.ResourceManagerId.ToString()!,
					KeyValueType.Guid),
				new KeyValue(FieldKeyConst.CFTeamlead, resource.PermissionsForObject
						.FirstOrDefault(item => item.RoleType == SystemRoleType.Lead
												&& item.ObjectType == ObjectType.Resource)?.ResourceId.ToString()!,
					KeyValueType.Guid),
				new KeyValue(FieldKeyConst.CFIsExpertCDD, resource.IsExpertCareerDevelopmentDay != null ?
								resource.IsExpertCareerDevelopmentDay.ToString()! : false.ToString(), KeyValueType.Text),
				new KeyValue(FieldKeyConst.CFIsKDRCompleted, resource.IsKDRCompleted.ToString()!, KeyValueType.Text),
			};
			if (resource.DateOfTermination.HasValue)
			{
				keyValues.Add(new KeyValue(FieldKeyConst.CFDateOfTermination,
					resource.DateOfTermination?.ToString()!, KeyValueType.Date));
			}

			foreach (var language in resource.Translations)
			{
				keyValues.Add(new KeyValue(resourceNameKey, language.Text!, KeyValueType.Text));
			}

			foreach (var permission in resource.PermissionsForObject
						 .Where(item => item.RoleType == SystemRoleType.Mentor
										&& item.ObjectType == ObjectType.Resource).ToList())
			{
				keyValues.Add(new KeyValue(FieldKeyConst.CFMentors, permission.ResourceId.ToString(), KeyValueType.Guid));
			}

			objectKeyValue.Add(resource.Id, keyValues);
		}

		return objectKeyValue;
	}

	//private Dictionary<Guid, List<KeyValue>> GenerateTaskKeyValueByObject(List<Guid> objectsId)
	//{
	//	var objectKeyValue = new Dictionary<Guid, List<KeyValue>>();
	//	var srvcTask = _serviceProvider.GetRequiredService<ITaskService>();
	//	var tasks = srvcTask.Find(
	//		_dataAccessFactory.GetBuilderSpecificationFactory().GetBuilderSpecification<IBuilderTask>()
	//			.ByIdIn(objectsId).Build(),
	//		_dataAccessFactory.GetFetchFactory().GetFetch<IFetchTaskIgnoreFilter>());

	//	var taskNameKey = FieldKeyConst.CFLike;
	//	foreach (var task in tasks)
	//	{
	//		var keyValues = new List<KeyValue>
	//		{
	//			new KeyValue(taskNameKey, task.Name, KeyValueType.Text),
	//			new KeyValue(FieldKeyConst.CFObjectName, task.Id.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFIsActive, task.IsActive.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFDateCreated, task.DateCreated.ToString(), KeyValueType.Date),
	//			new KeyValue(FieldKeyConst.CFCreator, task.CreatorUserId.ToFormatString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFIsExternal, task.IsExternal.ToString(), KeyValueType.Guid),
	//		};


	//		objectKeyValue.Add(task.Id, keyValues);
	//	}

	//	return objectKeyValue;
	//}

	//private Dictionary<Guid, List<KeyValue>> GenerateProjectKeyValueByObject(List<Guid> objectsId)
	//{
	//	var objectKeyValue = new Dictionary<Guid, List<KeyValue>>();

	//	var srvcProject = _serviceProvider.GetRequiredService<IProjectService>();
	//	var projects = srvcProject.Find(
	//		_dataAccessFactory.GetBuilderSpecificationFactory().GetBuilderSpecification<IBuilderProject>()
	//			.ByIdIn(objectsId).Build(),
	//		_dataAccessFactory.GetFetchFactory().GetFetch<IFetchProjectIgnoreFilter>());

	//	var projectNameKey = FieldKeyConst.CFLike;
	//	foreach (var project in projects)
	//	{
	//		var keyValues = new List<KeyValue>
	//		{
	//			new KeyValue(projectNameKey, project.Name, KeyValueType.Text),
	//			new KeyValue(FieldKeyConst.CFObjectName, project.Id.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFIsActive, project.IsActive.ToString(), KeyValueType.Guid),

	//			new KeyValue(FieldKeyConst.CFIsExternal, project.IsExternal.ToString(), KeyValueType.Guid),
	//		};
	//		keyValues.AddRange(project.ProjectLanguages.Select(language =>
	//			new KeyValue(projectNameKey, language.Name, KeyValueType.Text)));
	//		objectKeyValue.Add(project.Id, keyValues);
	//	}

	//	return objectKeyValue;
	//}

	//private Dictionary<Guid, List<KeyValue>> GenerateTrainingKeyValueByObject(List<Guid> objectsId)
	//{
	//	var objectKeyValue = new Dictionary<Guid, List<KeyValue>>();
	//	var srvcTrainingGroup = _serviceProvider.GetRequiredService<ITrainingService>();
	//	var trainingGroups = srvcTrainingGroup.Find(
	//		_dataAccessFactory.GetBuilderSpecificationFactory().GetBuilderSpecification<IBuilderTraining>()
	//			.ByIdIn(objectsId).Build(),
	//		_dataAccessFactory.GetFetchFactory()
	//			.GetFetch<IFetchTrainingForSearch>());

	//	var trainingGroupNameKey = FieldKeyConst.CFObjectName;
	//	foreach (var trainingGroup in trainingGroups)
	//	{
	//		var keyValues = new List<KeyValue>
	//		{
	//			new KeyValue(trainingGroupNameKey, trainingGroup.Name, KeyValueType.Text),
	//			new KeyValue(FieldKeyConst.CFObjectName, trainingGroup.Id.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFLike, trainingGroup.Name, KeyValueType.Text),
	//			new KeyValue(FieldKeyConst.CFDateFrom, trainingGroup.DateFrom.ToString(), KeyValueType.Date),
	//			new KeyValue(FieldKeyConst.CFDateTo, trainingGroup.DateTo.ToString(), KeyValueType.Date),
	//			//new KeyValue(FieldKeyConst.CFCost, trainingGroup.Cost?.ToFormatString(), KeyValueType.Guid),
	//			//new KeyValue(FieldKeyConst.CFCurrency, trainingGroup.CurrencyId?.ToFormatString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFKindOfTraining, trainingGroup.KindId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFDirectionTraining, trainingGroup.DirectionId.ToFormatString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFOrganization, trainingGroup.OrganizationId?.ToFormatString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFInternalTrainer, trainingGroup.InternalTrainerId?.ToFormatString(), KeyValueType.Guid)
	//		};

	//		foreach (var trainee in trainingGroup.Trainees)
	//		{
	//			keyValues.Add(new KeyValue(FieldKeyConst.CFUnit, trainee.Resource.DepartmentId.ToString(), KeyValueType.Guid));
	//		}

	//		objectKeyValue.Add(trainingGroup.Id, keyValues);
	//	}

	//	return objectKeyValue;
	//}

	//private Dictionary<Guid, List<KeyValue>> GenereateGratitudeKeyValueByObject(List<Guid> objectsId)
	//{
	//	var objectKeyValue = new Dictionary<Guid, List<KeyValue>>();
	//	var srvcGratitude = _serviceProvider.GetRequiredService<IGratitudeService>();
	//	var gratitudes = srvcGratitude.Find(
	//		_dataAccessFactory.GetBuilderSpecificationFactory()
	//			.GetBuilderSpecification<IBuilderGratitude>()
	//			.ByIdIn(objectsId).Build(),
	//		_dataAccessFactory.GetFetchFactory()
	//			.GetFetch<IFetchGratitudeWithFull>());

	//	foreach (var gratitude in gratitudes)
	//	{
	//		var keyValues = new List<KeyValue>
	//		{
	//			new (FieldKeyConst.CFDate, gratitude.Date.GetDateFormattingDot(), KeyValueType.Date),
	//			new (FieldKeyConst.CFFromResource, gratitude.ResourceFromId.ToString(), KeyValueType.Guid),
	//			new (FieldKeyConst.CFToResource, gratitude.ResourceToId.ToString(), KeyValueType.Guid),
	//			new (FieldKeyConst.CFFromResourceUnit, gratitude.ResourceFrom.DepartmentId.ToString(), KeyValueType.Guid),
	//			new (FieldKeyConst.CFToResourceUnit, gratitude.ResourceTo.DepartmentId.ToString(), KeyValueType.Guid)
	//		};

	//		foreach (var language in gratitude.ResourceTo.Translations)
	//		{
	//			keyValues.Add(new KeyValue(FieldKeyConst.CFLike, language.Text, KeyValueType.Text));
	//		}

	//		objectKeyValue.Add(gratitude.Id, keyValues);
	//	}

	//	return objectKeyValue;
	//}

	//private Dictionary<Guid, List<KeyValue>> GenerateIndividualDevelopmentPlanValueByObject(List<Guid> objectsId)
	//{
	//	var objectKeyValue = new Dictionary<Guid, List<KeyValue>>();
	//	var srvcIdp = _serviceProvider.GetRequiredService<IIndividualDevelopmentPlanService>();
	//	var idps = srvcIdp.Find(
	//		_dataAccessFactory.GetBuilderSpecificationFactory()
	//			.GetBuilderSpecification<IBuilderIndividualDevelopmentPlan>().ByIdIn(objectsId).Build(),
	//		_dataAccessFactory.GetFetchFactory().GetFetch<IFetchIndividualDevelopmentPlanWithFull>());

	//	foreach (var idp in idps)
	//	{
	//		var keyValues = new List<KeyValue>
	//		{
	//			new (FieldKeyConst.CFDate, idp.CreationDate.GetDateFormattingDot(), KeyValueType.Date),
	//			new (FieldKeyConst.CFResource, idp.ResourceId.ToString(), KeyValueType.Guid),
	//			new (FieldKeyConst.CFUnit, idp.Resource.DepartmentId.ToString(), KeyValueType.Guid),
	//		};

	//		foreach (var language in idp.Resource.Translations)
	//		{
	//			keyValues.Add(new KeyValue(FieldKeyConst.CFLike, language.Text, KeyValueType.Text));
	//		}

	//		objectKeyValue.Add(idp.Id, keyValues);
	//	}

	//	return objectKeyValue;
	//}


	//private Dictionary<Guid, List<KeyValue>> GenereateMentorshipKeyValueByObject(List<Guid> objectsId)
	//{
	//	var objectKeyValue = new Dictionary<Guid, List<KeyValue>>();
	//	var srvcmentorship = _serviceProvider.GetRequiredService<IMentorshipService>();
	//	var mentorships = srvcmentorship.Find(
	//		_dataAccessFactory.GetBuilderSpecificationFactory().GetBuilderSpecification<IBuilderMentorship>()
	//			.ByIdIn(objectsId).Build(),
	//		_dataAccessFactory.GetFetchFactory().GetFetch<IFetchMentorship>());

	//	foreach (var mentorship in mentorships)
	//	{
	//		var keyValues = new List<KeyValue>
	//		{
	//			new KeyValue(FieldKeyConst.CFStartDate, mentorship.StartDate.GetDateFormattingDot(), KeyValueType.Date),
	//			new KeyValue(FieldKeyConst.CFEndDate, mentorship.EndDate.GetDateFormattingDot(), KeyValueType.Date),
	//			new KeyValue(FieldKeyConst.CFUnit, mentorship.DepartmentId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFHierarchyLevel, mentorship.HierarchyLevelId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFKeyCompetence, mentorship.KeyCompetenceId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFSubCompetence, mentorship.SubCompetenceId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFHr, mentorship.ResourceHRId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFTypeMentorship, mentorship.TypeMentorshipId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFWorkflowState, mentorship.StateId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFResource, mentorship.Student.Id.ToString(), KeyValueType.Guid),
	//		};

	//		foreach (var mentor in mentorship.PermissionsForObject.Where(item => item.RoleType == SystemRoleType.Mentor))
	//			keyValues.Add(new KeyValue(FieldKeyConst.CFMentors, mentor.ResourceId.ToString(), KeyValueType.Guid));

	//		var lead = mentorship.PermissionsForObject.FirstOrDefault(item => item.RoleType == SystemRoleType.Lead);
	//		if (lead != null)
	//			keyValues.Add(new KeyValue(FieldKeyConst.CFTeamlead, lead.ResourceId.ToString(), KeyValueType.Guid));

	//		foreach (var language in mentorship.Student.Translations)
	//		{
	//			keyValues.Add(new KeyValue(FieldKeyConst.CFResource, language.Text, KeyValueType.Text));
	//			keyValues.Add(new KeyValue(FieldKeyConst.CFLike, language.Text, KeyValueType.Text));
	//		}

	//		objectKeyValue.Add(mentorship.Id, keyValues);
	//	}

	//	return objectKeyValue;
	//}

	//private Dictionary<Guid, List<KeyValue>> GenerateCareerDevelopmentDayKeyValueByObject(List<Guid> objectsId)
	//{
	//	var objectKeyValue = new Dictionary<Guid, List<KeyValue>>();
	//	var srvcCdd = _serviceProvider.GetRequiredService<ICareerDevelopmentDayService>();
	//	var cdds = srvcCdd.Find(
	//		_dataAccessFactory.GetBuilderSpecificationFactory()
	//			.GetBuilderSpecification<IBuilderCareerDevelopmentDay>()
	//			.ByIdIn(objectsId).Build(),
	//		_dataAccessFactory.GetFetchFactory().GetFetch<IFetchCareerDevelopmentDayWithoutAchievement>());

	//	foreach (var cdd in cdds)
	//	{
	//		var keyValues = new List<KeyValue>
	//		{
	//			new KeyValue(FieldKeyConst.CFObjectName, cdd.ResourceId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFLike, cdd.Resource.Name, KeyValueType.Text),
	//			new KeyValue(FieldKeyConst.CFLike, cdd.Date.ToString("dd'/'MM'/'yyyy") + " " + cdd.Resource.Name,
	//				KeyValueType.Text),
	//			new KeyValue(FieldKeyConst.CFObjectName, cdd.Id.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFResource, cdd.ResourceId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFDate, cdd.Date.ToString(), KeyValueType.Date),
	//			new KeyValue(FieldKeyConst.CFWorkflowState, cdd.StateId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFObjectName, cdd.CreatorUserId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFUnit, cdd.Resource.DepartmentId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFIsPostponed, cdd.IsPostponed.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFIsActive, cdd.Resource.IsActive.ToString(), KeyValueType.Text),
	//		};


	//		objectKeyValue.Add(cdd.Id, keyValues);
	//	}

	//	return objectKeyValue;
	//}

	//private Dictionary<Guid, List<KeyValue>> GenerateAchievementKeyValueByObject(List<Guid> objectsId)
	//{
	//	var objectKeyValue = new Dictionary<Guid, List<KeyValue>>();
	//	var achievements = _srvcAchievement.Find(
	//		_dataAccessFactory.GetBuilderSpecificationFactory()
	//			.GetBuilderSpecification<IBuilderAchievement>()
	//			.ByIdIn(objectsId).Build());

	//	foreach (var achievement in achievements)
	//	{
	//		var keyValues = new List<KeyValue>
	//		{
	//			new KeyValue(FieldKeyConst.CFObjectName, achievement.Id.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFObjectName, achievement.CareerDevelopmentDayId.ToString(),
	//				KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFAchievementSmallName, achievement.Id.ToFormatString(),
	//				KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFWorkflowState, achievement.StateId.ToString(), KeyValueType.Guid)
	//			//new KeyValue(
	//			//    FieldKeys.FieldIsCompensationContract]
	//			//        .ToFormatString(), achievement.Description, KeyValueType.Text),
	//		};


	//		objectKeyValue.Add(achievement.Id, keyValues);
	//	}

	//	return objectKeyValue;
	//}

	//private Dictionary<Guid, List<KeyValue>> GenerateCareerDevelopmentDayKeyValueByObjectLike(List<Guid> objectsId)
	//{
	//	var objectKeyValue = new Dictionary<Guid, List<KeyValue>>();
	//	var achievements = _srvcAchievement.Find(
	//		_dataAccessFactory.GetBuilderSpecificationFactory()
	//			.GetBuilderSpecification<IBuilderAchievement>()
	//			.ByIdIn(objectsId).Build());

	//	foreach (var achievement in achievements)
	//	{
	//		var descriptionText =
	//			achievement.Description == null ? string.Empty : ExcelUtil.HtmlToPlainText(achievement.Description);
	//		var keyValues = new List<KeyValue>
	//		{
	//			new KeyValue(FieldKeyConst.CFLike, achievement.SmallName, KeyValueType.Text),
	//			new KeyValue(FieldKeyConst.CFLike, descriptionText, KeyValueType.Text)
	//		};

	//		var cddId = achievement.CareerDevelopmentDayId;
	//		//если у ДКР несколько целей, то будет несколько добавлений по одному ключу
	//		if (objectKeyValue.ContainsKey(cddId))
	//		{
	//			objectKeyValue[cddId].AddRange(keyValues);
	//		}
	//		else
	//		{
	//			objectKeyValue.Add(achievement.CareerDevelopmentDayId, keyValues);
	//		}
	//	}

	//	return objectKeyValue;
	//}

	//private Dictionary<Guid, List<KeyValue>> GenerateFormKeyValueByObject(List<Guid> objectsId)
	//{
	//	var srvcForm = _serviceProvider.GetRequiredService<IQuestionnaireService>();
	//	var forms = srvcForm.Find(
	//		_dataAccessFactory.GetBuilderSpecificationFactory().GetBuilderSpecification<IBuilderForm>()
	//			.ByIdIn(objectsId).Build(),
	//		_dataAccessFactory.GetFetchFactory()
	//			.GetFetch<IFetchFormWithStateAndFormRefWithResource>());

	//	var objectKeyValue = new Dictionary<Guid, List<KeyValue>>();
	//	foreach (var form in forms)
	//	{
	//		objectKeyValue.Add(form.Id, new List<KeyValue>
	//		{
	//			new KeyValue(FieldKeyConst.CFWorkflowState, form.StateId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFDateOfTermination, form.Date.ToString(), KeyValueType.Date),
	//			new KeyValue(FieldKeyConst.CFDuedate, form.Date.ToString(), KeyValueType.Date),
	//			new KeyValue(FieldKeyConst.CFObjectType, form.FormType.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFToResource, form.ToResourceId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFLinkInJira, form.Link, KeyValueType.Text),
	//			new KeyValue(FieldKeyConst.CFDateCreated, form.Date.ToString(), KeyValueType.Date)
	//		});
	//		foreach (var language in form.ResourceTo.Translations)
	//		{
	//			objectKeyValue[form.Id].Add(new KeyValue(FieldKeyConst.CFLike, language.Text, KeyValueType.Text));
	//		}
	//	}

	//	return objectKeyValue;
	//}

	//private Dictionary<Guid, List<KeyValue>> GenerateMeetingKeyValueByObject(List<Guid> objectsId)
	//{
	//	var srvcMeeting = _serviceProvider.GetRequiredService<IMeetingService>();
	//	var meetings = srvcMeeting.Find(
	//		_dataAccessFactory.GetBuilderSpecificationFactory().GetBuilderSpecification<IBuilderMeeting>()
	//			.ByIdIn(objectsId).Build(),
	//		_dataAccessFactory.GetFetchFactory().GetFetch<IFetchMeetingWithResourceTo>());

	//	var objectKeyValue = new Dictionary<Guid, List<KeyValue>>();

	//	foreach (var meeting in meetings)
	//	{
	//		var keyValues = new List<KeyValue>
	//		{
	//			new KeyValue(FieldKeyConst.CFCreator, meeting.CreatorId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFDate, meeting.Date.ToString(), KeyValueType.Date),
	//			new KeyValue(FieldKeyConst.CFToResource, meeting.ToResourceId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFUnit, meeting.ResourceTo?.DepartmentId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFResourceManager, meeting.ResourceManagerId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFParticipatingHR, meeting.HrId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFObjectType, meeting.Type.ToString(), KeyValueType.Text),
	//			new KeyValue(FieldKeyConst.CFWorkflowState, meeting.StateId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFOwner, meeting.PermissionsForObject
	//				.First(p => p.RoleType == SystemRoleType.Owner).ResourceId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFLike, ObjectTypeUtil.GetMeetingTypeName(meeting.Type),
	//				KeyValueType.Text)
	//		};
	//		meeting.ParticipatingEmployeesId?.ForEach(peId =>
	//		{
	//			keyValues.Add(new KeyValue(FieldKeyConst.CFParticipatingEmployees, peId.ToString(), KeyValueType.Guid));
	//		});
	//		if (meeting.ResourceTo != null)
	//			foreach (var language in meeting.ResourceTo.Translations)
	//			{
	//				keyValues.Add(new KeyValue(FieldKeyConst.CFToResource, language.Text, KeyValueType.Text));
	//				keyValues.Add(new KeyValue(FieldKeyConst.CFLike, language.Text, KeyValueType.Text));
	//			}

	//		objectKeyValue.Add(meeting.Id, keyValues);
	//	}

	//	return objectKeyValue;
	//}

	//private Dictionary<Guid, List<KeyValue>> GenerateExitInterviewKeyValueByObject(List<Guid> objectsId)
	//{
	//	var srvcExitInterview = _serviceProvider.GetRequiredService<IExitInterviewService>();
	//	var exitInterviews = srvcExitInterview.Find(
	//		_dataAccessFactory.GetBuilderSpecificationFactory().GetBuilderSpecification<IBuilderExitInterview>()
	//			.ByIdIn(objectsId).Build(),
	//		_dataAccessFactory.GetFetchFactory().GetFetch<IFetchExitInterviewWithFullList>());

	//	var objectKeyValue = new Dictionary<Guid, List<KeyValue>>();

	//	foreach (var exitInterview in exitInterviews)
	//	{
	//		var dateFrom = exitInterview.Resource.DateOfEmployment;
	//		var dateTo = exitInterview.Resource.DateOfTermination.HasValue ? exitInterview.Resource.DateOfTermination.Value : DateTime.Today;
	//		var rangeInt = (((dateTo.Year - dateFrom.Year) * 12) + dateTo.Month - dateFrom.Month).ToString();


	//		var keyValues = new List<KeyValue>
	//		{
	//			new KeyValue(FieldKeyConst.CFHr, exitInterview.HRId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFResource, exitInterview.ResourceId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFDateOfTermination, exitInterview.Resource.DateOfTermination?.ToString(), KeyValueType.Date),
	//			new KeyValue(FieldKeyConst.CFUnit, exitInterview.Resource.DepartmentId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFReasonForTerminationDictionary, exitInterview.CustomFieldValues
	//				.Where(item => item.FieldKey == FieldKeyConst.CFReasonForTerminationDictionary).ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFWorkflowState, exitInterview.StateId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFNewPosition, exitInterview.CustomFieldValues
	//				.Where(item => item.FieldKey == FieldKeyConst.CFNewPosition).ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFKeyCompetence, exitInterview.CustomFieldValues
	//				.Where(item => item.FieldKey == FieldKeyConst.CFKeyCompetence).ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFSubCompetence, exitInterview.CustomFieldValues
	//				.Where(item => item.FieldKey == FieldKeyConst.CFSubCompetence).ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFHierarchyLevel, exitInterview.CustomFieldValues
	//				.Where(item => item.FieldKey == FieldKeyConst.CFHierarchyLevel).ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFExperienceRange, rangeInt, KeyValueType.Int)
	//		};

	//		foreach (var language in exitInterview.Resource.Translations)
	//		{
	//			keyValues.Add(new KeyValue(FieldKeyConst.CFLike, language.Text, KeyValueType.Text));
	//		}

	//		objectKeyValue.Add(exitInterview.Id, keyValues);
	//	}

	//	return objectKeyValue;
	//}


	//private Dictionary<Guid, List<KeyValue>> GenerateDismissalRequestKeyValueByObject(List<Guid> objectsId)
	//{
	//	var srvcDismissalRequest = _serviceProvider.GetRequiredService<IDismissalRequestService>();
	//	var dismissalRequests = srvcDismissalRequest.Find(
	//		_dataAccessFactory.GetBuilderSpecificationFactory().GetBuilderSpecification<IBuilderDismissalRequest>()
	//			.ByIdIn(objectsId).Build(),
	//		_dataAccessFactory.GetFetchFactory().GetFetch<IFetchDismissalRequestWithFullList>());

	//	var objectKeyValue = new Dictionary<Guid, List<KeyValue>>();

	//	foreach (var dismissalRequest in dismissalRequests)
	//	{
	//		var keyValues = new List<KeyValue>
	//		{
	//			new (FieldKeyConst.CFResource, dismissalRequest.ResourceId.ToString(), KeyValueType.Guid),
	//			new (FieldKeyConst.CFDateOfDismissal, dismissalRequest.DateOfDismissal.ToString(), KeyValueType.Date),
	//			new (FieldKeyConst.CFUnit, dismissalRequest.Resource.DepartmentId.ToString(), KeyValueType.Guid),
	//			new (FieldKeyConst.CFReasonForTerminationDictionary, dismissalRequest.CustomFieldValues
	//				.Where(item => item.FieldKey == FieldKeyConst.CFReasonForTerminationDictionary).ToString(), KeyValueType.Guid),
	//			new (FieldKeyConst.CFWorkflowState, dismissalRequest.StateId.ToString(), KeyValueType.Guid),
	//			new (FieldKeyConst.CFKeyCompetence, dismissalRequest.CustomFieldValues
	//				.Where(item => item.FieldKey == FieldKeyConst.CFKeyCompetence).ToString(), KeyValueType.Guid),
	//			new (FieldKeyConst.CFGroundsForDismissal, dismissalRequest.GroundsForDismissalId.ToString(), KeyValueType.Guid),
	//			new (FieldKeyConst.CFReasonForDismissal, dismissalRequest.ReasonForDismissalId.ToString(), KeyValueType.Guid)
	//		};

	//		foreach (var language in dismissalRequest.Resource.Translations)
	//		{
	//			keyValues.Add(new KeyValue(FieldKeyConst.CFLike, language.Text, KeyValueType.Text));
	//		}

	//		objectKeyValue.Add(dismissalRequest.Id, keyValues);
	//	}

	//	return objectKeyValue;
	//}
	//private Dictionary<Guid, List<KeyValue>> GenerateShareResourceKeyValueByObject(List<Guid> objectIds)
	//{
	//	var srvcShareResource = _serviceProvider.GetRequiredService<IShareResourceService>();

	//	var shareResources = srvcShareResource.Find(_dataAccessFactory.GetBuilderSpecificationFactory()
	//			.GetBuilderSpecification<IShareResourceBuilder>()
	//			.ByIdIn(objectIds).Build(),
	//		_dataAccessFactory.GetFetchFactory().GetFetch<IFetchShareResourceWithFullList>());

	//	var objectKeyValue = new Dictionary<Guid, List<KeyValue>>();

	//	foreach (var shareResource in shareResources)
	//	{
	//		var keyValues = new List<KeyValue>
	//		{
	//			new (FieldKeyConst.CFStartDate, shareResource.StartDate?.ToString(), KeyValueType.Date),
	//			new (FieldKeyConst.CFWorkflowState, shareResource.StateId.ToString(), KeyValueType.Guid),
	//			new (FieldKeyConst.CFEndDate, shareResource.EndDate?.ToString(), KeyValueType.Date),
	//			new (FieldKeyConst.CFUnit, shareResource.DepartmentId.ToString(), KeyValueType.Guid),
	//			new (FieldKeyConst.CFKeyCompetence, shareResource.KeyCompetenceId.ToString(),KeyValueType.Guid),
	//			new (FieldKeyConst.CFSubCompetence, shareResource.SubCompetenceId.ToString(),KeyValueType.Guid),
	//			new (FieldKeyConst.CFHierarchyLevel, shareResource.HierarchyLevelId.ToString(),KeyValueType.Guid),
	//			new (FieldKeyConst.CFCreator, shareResource.CreatorId.ToString(),KeyValueType.Guid)
	//		};

	//		objectKeyValue.Add(shareResource.Id, keyValues);
	//	}
	//	return objectKeyValue;
	//}

	//private Dictionary<Guid, List<KeyValue>> GenerateCandidateKeyValueByObject(List<Guid> objectIds)
	//{
	//	var srvcCandidate = _serviceProvider.GetRequiredService<ICandidateService>();

	//	var candidates = srvcCandidate.Find(
	//		_dataAccessFactory.GetBuilderSpecificationFactory()
	//			.GetBuilderSpecification<IBuilderCandidate>()
	//			.ByIdIn(objectIds).Build(),
	//		_dataAccessFactory.GetFetchFactory()
	//			.GetFetch<IFetchCandidateWithFullList>());

	//	var objectKeyValue = new Dictionary<Guid, List<KeyValue>>();

	//	foreach (var candidate in candidates)
	//	{
	//		var keyValues = new List<KeyValue>
	//		{
	//			new (FieldKeyConst.CFResource, candidate.Resource.Id.ToString(), KeyValueType.Guid),
	//			new (FieldKeyConst.CFStartDate, candidate.StartDate?.ToString(), KeyValueType.Date),
	//			new (FieldKeyConst.CFWorkflowState, candidate.StateId.ToString(), KeyValueType.Guid),
	//			new (FieldKeyConst.CFEndDate, candidate.EndDate?.ToString(), KeyValueType.Date),
	//			new (FieldKeyConst.CFPosition, candidate.Resource.PositionId.ToString(), KeyValueType.Guid),
	//			new (FieldKeyConst.CFKeyCompetence, candidate.Resource.CustomFieldValues.First(p => p.FieldKey == FieldKeyConst.CFKeyCompetence)?.Text,KeyValueType.Guid),
	//			new (FieldKeyConst.CFSubCompetence, candidate.Resource.CustomFieldValues.First(p => p.FieldKey == FieldKeyConst.CFSubCompetence)?.Text,KeyValueType.Guid),
	//			new (FieldKeyConst.CFHierarchyLevel, candidate.Resource.CustomFieldValues.First(p => p.FieldKey == FieldKeyConst.CFHierarchyLevel)?.Text,KeyValueType.Guid),
	//			new (FieldKeyConst.CFCreator,candidate.CreatorId.ToString(), KeyValueType.Guid)
	//		};

	//		foreach (var language in candidate.Resource.Translations)
	//		{
	//			keyValues.Add(new KeyValue(FieldKeyConst.CFObjectName, language.Text, KeyValueType.Text));
	//		}

	//		objectKeyValue.Add(candidate.Id, keyValues);
	//	}

	//	return objectKeyValue;
	//}

	//private Dictionary<Guid, List<KeyValue>> GenerateAdaptationKeyValueByObject(List<Guid> objectsId)
	//{
	//	var srvcAdaptation = _serviceProvider.GetRequiredService<IAdaptationService>();
	//	var adaptations = srvcAdaptation.Find(
	//		_dataAccessFactory.GetBuilderSpecificationFactory().GetBuilderSpecification<IBuilderAdaptation>()
	//			.ByIdIn(objectsId).Build(),
	//		_dataAccessFactory.GetFetchFactory().GetFetch<IFetchAdaptationWithResourceTo>());

	//	var objectKeyValue = new Dictionary<Guid, List<KeyValue>>();

	//	foreach (var adaptation in adaptations)
	//	{
	//		var keyValues = new List<KeyValue>
	//		{
	//			new KeyValue(FieldKeyConst.CFDateFrom, adaptation.StartDate.ToString(), KeyValueType.Date),
	//			new KeyValue(FieldKeyConst.CFDateTo, adaptation.FinishDate.ToString(), KeyValueType.Date),
	//			new KeyValue(FieldKeyConst.CFDateOfEmployment, adaptation.ResourceTo.DateOfEmployment.ToString(),
	//				KeyValueType.Date),
	//			new KeyValue(FieldKeyConst.CFToResource, adaptation.ToResourceId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFHr, adaptation.RecruiterId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFWorkflowState, adaptation.StateId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFUnit, adaptation.DepartmentId.ToString(), KeyValueType.Guid)
	//		};
	//		foreach (var language in adaptation.ResourceTo.Translations)
	//		{
	//			keyValues.Add(new KeyValue(FieldKeyConst.CFLike, language.Text, KeyValueType.Text));
	//		}

	//		objectKeyValue.Add(adaptation.Id, keyValues);
	//	}

	//	return objectKeyValue;
	//}

	//private Dictionary<Guid, List<KeyValue>> GenerateAttendanceKeyValueByObject(List<Guid> objectsId)
	//{
	//	var srvcAttendance = _serviceProvider.GetRequiredService<IAttendanceService>();
	//	var attendances = srvcAttendance.Find(
	//		_dataAccessFactory.GetBuilderSpecificationFactory()
	//		.GetBuilderSpecification<IBuilderAttendance>()
	//		.ByIdIn(objectsId).Build(),
	//		_dataAccessFactory.GetFetchFactory().GetFetch<IFetchAttendanceWithResource>());

	//	var objectKeyValue = new Dictionary<Guid, List<KeyValue>>();

	//	foreach (var attendance in attendances)
	//	{
	//		var keyValues = new List<KeyValue>
	//		{
	//			new KeyValue(FieldKeyConst.CFObjectName, attendance.Id.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFDate, attendance.Date.ToString(), KeyValueType.Date),
	//			new KeyValue(FieldKeyConst.CFResource, attendance.ResourceId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFAttendanceStatus, attendance.StateId.ToString(), KeyValueType.Guid)
	//		};
	//		if (attendance.Resource.DepartmentId.HasValue)
	//		{
	//			keyValues.Add(new KeyValue(FieldKeyConst.CFUnit, attendance.Resource.DepartmentId.Value.ToString(),
	//				KeyValueType.Guid));
	//		}

	//		foreach (var language in attendance.Resource.Translations)
	//		{
	//			keyValues.Add(new KeyValue(FieldKeyConst.CFLike, language.Text, KeyValueType.Text));
	//		}

	//		objectKeyValue.Add(attendance.Id, keyValues);
	//	}

	//	return objectKeyValue;
	//}

	//private Dictionary<Guid, List<KeyValue>> GenerateMentoringKeyValueByObject(List<Guid> objectsId)
	//{
	//	var srvcMentoring = _serviceProvider.GetRequiredService<IMentoringService>();
	//	var mentorings = srvcMentoring.Find(
	//		_dataAccessFactory.GetBuilderSpecificationFactory().GetBuilderSpecification<IBuilderMentoring>()
	//			.ByIdIn(objectsId).Build(),
	//		_dataAccessFactory.GetFetchFactory().GetFetch<IFetchMentoringWithMentee>());

	//	var objectKeyValue = new Dictionary<Guid, List<KeyValue>>();

	//	foreach (var mentoring in mentorings)
	//	{
	//		var keyValues = new List<KeyValue>
	//		{
	//			new KeyValue(FieldKeyConst.CFDateFrom, mentoring.DateFrom.ToString(), KeyValueType.Date),
	//			new KeyValue(FieldKeyConst.CFDateTo, mentoring.DateTo.ToString(), KeyValueType.Date),
	//			new KeyValue(FieldKeyConst.CFToResource, mentoring.MenteeId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFHr, mentoring.HRId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFObjectType, mentoring.Type.ToString(), KeyValueType.Text),
	//			new KeyValue(FieldKeyConst.CFWorkflowState, mentoring.StateId.ToString(), KeyValueType.Guid)
	//		};

	//		foreach (var mentor in mentoring.PermissionsForObject.Where(item => item.RoleType == SystemRoleType.Mentor))
	//		{
	//			keyValues.Add(new KeyValue(FieldKeyConst.CFMentors, mentor.ResourceId.ToString(), KeyValueType.Guid));
	//		}
	//		var lead = mentoring.PermissionsForObject.FirstOrDefault(item => item.RoleType == SystemRoleType.Lead);
	//		if (lead != null)
	//		{
	//			keyValues.Add(new KeyValue(FieldKeyConst.CFTeamlead, lead.ResourceId.ToString(), KeyValueType.Guid));
	//		}

	//		foreach (var language in mentoring.Mentee.Translations)
	//		{
	//			keyValues.Add(new KeyValue(FieldKeyConst.CFToResource, language.Text, KeyValueType.Text));
	//			keyValues.Add(new KeyValue(FieldKeyConst.CFLike, language.Text, KeyValueType.Text));
	//		}

	//		objectKeyValue.Add(mentoring.Id, keyValues);
	//	}

	//	return objectKeyValue;
	//}

	//private Dictionary<Guid, List<KeyValue>> GeneratePersonnelReserveKeyValueByObject(List<Guid> objectsId)
	//{
	//	var srvcPersonnelReserve = _serviceProvider.GetRequiredService<IPersonnelReserveService>();
	//	var personnelReserves = srvcPersonnelReserve.Find(
	//		_dataAccessFactory.GetBuilderSpecificationFactory().GetBuilderSpecification<IBuilderPersonnelReserve>()
	//			.ByIdIn(objectsId).Build(),
	//		_dataAccessFactory.GetFetchFactory().GetFetch<IFetchPersonnelReserveWithFull>());

	//	var objectKeyValue = new Dictionary<Guid, List<KeyValue>>();

	//	foreach (var personnelReserve in personnelReserves)
	//	{
	//		var keyValues = new List<KeyValue>
	//		{
	//			new KeyValue(FieldKeyConst.CFDate, personnelReserve.Date.ToString(), KeyValueType.Date),
	//			new KeyValue(FieldKeyConst.CFPersonnelReservePosition, personnelReserve.PersonnelReservePositionId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFUnit, personnelReserve.DepartmentId?.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFWorkflowState, personnelReserve.StateId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFLike, personnelReserve.PersonnelReservePosition.Name, KeyValueType.Text),
	//			new KeyValue(FieldKeyConst.CFLike, personnelReserve.Department.Text, KeyValueType.Text)
	//		};

	//		foreach (var language in personnelReserve.Department.Translations)
	//		{
	//			keyValues.Add(new KeyValue(FieldKeyConst.CFLike, language.Text, KeyValueType.Text));
	//		}

	//		objectKeyValue.Add(personnelReserve.Id, keyValues);
	//	}

	//	return objectKeyValue;
	//}

	//private Dictionary<Guid, List<KeyValue>> GeneratePositionResponseKeyValueByObject(List<Guid> objectsId)
	//{
	//	var srvcPositionResponse = _serviceProvider.GetRequiredService<IPositionResponseService>();
	//	var positionResponses = srvcPositionResponse.Find(
	//		_dataAccessFactory.GetBuilderSpecificationFactory().GetBuilderSpecification<IBuilderPositionResponse>()
	//			.ByIdIn(objectsId).Build(),
	//		_dataAccessFactory.GetFetchFactory().GetFetch<IFetchPositionResponseWithResourceTranslations>());

	//	var objectKeyValue = new Dictionary<Guid, List<KeyValue>>();

	//	foreach (var positionResponse in positionResponses)
	//	{
	//		var keyValues = new List<KeyValue>
	//		{
	//			new KeyValue(FieldKeyConst.CFResource, positionResponse.ResourceId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFWorkflowState, positionResponse.StateId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFDate, positionResponse.Date.GetDateFormattingDot(),KeyValueType.Date),
	//			new KeyValue(FieldKeyConst.CFUnit, positionResponse.Resource.DepartmentId.ToString(), KeyValueType.Guid)
	//		};

	//		objectKeyValue.Add(positionResponse.Id, keyValues);
	//	}

	//	return objectKeyValue;
	//}

	//private Dictionary<Guid, List<KeyValue>> GenerateKeyResourceKeyValueByObject(List<Guid> objectsId)
	//{
	//	var srvcKeyResource = _serviceProvider.GetRequiredService<IKeyResourceService>();
	//	var keyResources = srvcKeyResource.Find(
	//		_dataAccessFactory.GetBuilderSpecificationFactory().GetBuilderSpecification<IBuilderKeyResource>()
	//			.ByIdIn(objectsId).Build(),
	//		_dataAccessFactory.GetFetchFactory().GetFetch<IFetchKeyResourceWithResourceTranslations>());

	//	var objectKeyValue = new Dictionary<Guid, List<KeyValue>>();

	//	foreach (var keyResource in keyResources)
	//	{
	//		var keyValues = new List<KeyValue>
	//		{
	//			new KeyValue(FieldKeyConst.CFDate, keyResource.Date.ToString(), KeyValueType.Date),
	//			new KeyValue(FieldKeyConst.CFUnit, keyResource.DepartmentId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFResource, keyResource.KeyResourceId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFResourceSuccessor, keyResource.ResourceSuccessorId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFWorkflowState, keyResource.StateId.ToString(), KeyValueType.Guid),
	//			new KeyValue(FieldKeyConst.CFRiskOfLeaving, keyResource.RiskOfLeavingId.ToString(), KeyValueType.Guid),
	//		};

	//		foreach (var language in keyResource.Resource.Translations)
	//		{
	//			keyValues.Add(new KeyValue(FieldKeyConst.CFLike, language.Text, KeyValueType.Text));
	//		}

	//		objectKeyValue.Add(keyResource.Id, keyValues);
	//	}

	//	return objectKeyValue;
	//}

	//private Dictionary<Guid, List<KeyValue>> GenerateSecretSantaKeyValueByObject(List<Guid> objectsId)
	//{
	//	var srvcSecretSanta = _serviceProvider.GetRequiredService<ISecretSantaService>();
	//	var secretSantas = srvcSecretSanta.Find(
	//		_dataAccessFactory.GetBuilderSpecificationFactory().GetBuilderSpecification<IBuilderSecretSanta>()
	//			.ByIdIn(objectsId).Build(),
	//		_dataAccessFactory.GetFetchFactory().GetFetch<IFetchSecretSantaWithFull>());

	//	var objectKeyValue = new Dictionary<Guid, List<KeyValue>>();

	//	foreach (var secretSanta in secretSantas)
	//	{
	//		var keyValues = new List<KeyValue>
	//		{
	//			new (FieldKeyConst.CFDateCreated, secretSanta.Date.ToString(), KeyValueType.Date),
	//			new (FieldKeyConst.CFResource, secretSanta.ResourceId.ToString(), KeyValueType.Guid),
	//			new (FieldKeyConst.CFSecretSanta, secretSanta.ResourceSantaId.ToString(), KeyValueType.Guid),
	//		};
	//		keyValues.AddRange(secretSanta.Resource.Translations
	//			.Select(language => new KeyValue(FieldKeyConst.CFLike, language.Text, KeyValueType.Text)));

	//		if (secretSanta.ResourceSanta != null)
	//		{
	//			keyValues.AddRange(secretSanta.ResourceSanta.Translations
	//				.Select(language => new KeyValue(FieldKeyConst.CFLike, language.Text, KeyValueType.Text)));
	//		}

	//		objectKeyValue.Add(secretSanta.Id, keyValues);
	//	}

	//	return objectKeyValue;
	//}

	public void BuildIndex(BuildIndexRequest request)
	{
		using (var searchEngine = _serviceProvider.GetRequiredService<ISearchEngine>())
		{
			searchEngine.BuildIndex(request);
		}
	}

	public SearchResponse Search(SearchRequest request)
	{
		using (var searchEngine = _serviceProvider.GetRequiredService<ISearchEngine>())
		{
			return searchEngine.Search(request);
		}
	}


	public List<Guid> GetResourcesId(IList<FilterItem> filterItems)
	{
		var results = new List<Guid>();

		if (!GetObjectsId(filterItems, SearchConst.ResourceIndex, ref results))
			return new List<Guid>();

		////цвет
		//if (!ResourcesIdByColor(filterItems, ref results))
		//	return new List<Guid>();

		////избранные
		//if (!ResourcesIdByFavorite(filterItems, ref results))
		//	return new List<Guid>();

		////Спец алгоритм
		//if (!ResourcesIdBySpecialAlgorithm(filterItems, ref results))
		//	return new List<Guid>();

		return results;
	}

	#region Resources

	//private bool ResourcesIdBySpecialAlgorithm(IList<FilterItem> filterItems, ref List<Guid> results)
	//{
	//	List<Guid> availability = new List<Guid>();
	//	bool isAvailability = false;
	//	foreach (var filterItem in filterItems.Where(item => item.TabType == TabType.Quick &&
	//														 item.CustomFieldId == FieldKeyConst.CFAvailability))
	//	{
	//		isAvailability = true;
	//		var filterValue = filterItem.FilterValue;
	//		var filter = Enum.Parse<AvailabilityFilter>(filterValue.StringValue.FirstOrDefault());
	//		var srvcBookingCellService =
	//			new BookingCellService(_unitOfWorkFactory, _dataAccessFactory, _context, _userUtil);
	//		switch (filter)
	//		{
	//			case AvailabilityFilter.Today:
	//				{
	//					availability = srvcBookingCellService
	//						.GetFreeResources(
	//							_specificationFactory.GetBuilderSpecification<IBuilderBookingCell>().Today().Build(),
	//							1, BusinessСonst.DayDeltaTime, DateTime.Today).ToList();
	//					break;
	//				}
	//			case AvailabilityFilter.Week:
	//				{
	//					var dateFrom = DateTime.Today;
	//					var dateTo = dateFrom.LastDayOfWeek();

	//					availability = srvcBookingCellService
	//						.GetFreeResources(_specificationFactory.GetBuilderSpecification<IBuilderBookingCell>()
	//							.BeetweenDates(dateFrom, dateTo)
	//							.Build(), dateFrom.BusinessDaysUntil(dateTo), BusinessСonst.WeekDeltaTime, dateTo)
	//						.ToList();
	//					break;
	//				}
	//			case AvailabilityFilter.Month:
	//				{
	//					var dateFrom = DateTime.Today;
	//					var dateTo = dateFrom.LastDayOfMonth(); //DateTime.Today.AddDays(30);

	//					availability = srvcBookingCellService
	//						.GetFreeResources(_specificationFactory.GetBuilderSpecification<IBuilderBookingCell>()
	//							.BeetweenDates(dateFrom, dateTo)
	//							.Build(), dateFrom.BusinessDaysUntil(dateTo), BusinessСonst.MonthDeltaTime, dateTo)
	//						.ToList();
	//					break;
	//				}
	//			case AvailabilityFilter.Period:
	//				{
	//					if (filterValue.DateFrom == null || filterValue.DateTo == null)
	//						throw new Exception("err::288 что-то пошло не так");


	//					if (filterValue.DateFrom.Value > filterValue.DateTo.Value)
	//					{
	//						return false;
	//					}

	//					var dateFrom = filterValue.DateFrom.Value;
	//					var dateTo = filterValue.DateTo.Value;
	//					var specBookingCell = _specificationFactory.GetBuilderSpecification<IBuilderBookingCell>()
	//						.BeetweenDates(dateFrom, dateTo).Build();
	//					var timeTolerance = filterValue.TimeTolerance ?? 0;
	//					if (filterValue.IsForeachDay)
	//					{
	//						availability = srvcBookingCellService.GetFreeResourcesForeachDay(specBookingCell,
	//							dateFrom.BusinessDaysUntil(dateTo), timeTolerance, dateTo).ToList();
	//					}
	//					else
	//					{
	//						availability = srvcBookingCellService.GetFreeResources(specBookingCell,
	//							dateFrom.BusinessDaysUntil(dateTo), timeTolerance, dateTo).ToList();
	//					}

	//					break;
	//				}
	//			case AvailabilityFilter.All:
	//				{
	//					var srvcResource = _serviceProvider.GetRequiredService<IResourceService>();
	//					availability = srvcResource.Find().Select(item => item.Id).ToList();
	//					break;
	//				}
	//			default:
	//				throw new ArgumentOutOfRangeException();
	//		}
	//	}

	//	if (isAvailability)
	//	{
	//		if (availability.Count == 0)
	//			return false;
	//		results = results.Count > 0 ? results.Intersect(availability).ToList() : availability;
	//	}

	//	return true;
	//}

	//private bool ResourcesIdByFavorite(IEnumerable<FilterItem> filterItems, ref List<Guid> results)
	//{
	//	var userId = _userUtil.GetCurrentUser(_context).Id;
	//	var favorites = new List<Guid>();
	//	bool isFavorit = false;
	//	foreach (var filterItem in filterItems.Where(item => item.TabType == TabType.Quick &&
	//														 item.CustomFieldId == FieldKeyConst.CFFavorite))
	//	{
	//		isFavorit = true;
	//		switch (filterItem.FilterType)
	//		{
	//			case FilterEnumType.Equals:
	//				{
	//					var spec = _specificationFactory.GetBuilderSpecification<IBuilderFavorite>()
	//						.GetAllFavorites(FavoriteType.Resource, userId).Build();
	//					if (spec == null)
	//						break;

	//					var srvcFavorite = _serviceProvider.GetRequiredService<IFavoriteService>();

	//					favorites = srvcFavorite.Find(spec).Select(item => item.ObjectId).ToList();
	//					break;
	//				}
	//			case FilterEnumType.Between:
	//				break;
	//			case FilterEnumType.Like:
	//				break;
	//			case FilterEnumType.In:
	//				break;
	//			case FilterEnumType.InWithLevels:
	//				break;
	//			case FilterEnumType.InColor:
	//				break;
	//			default:
	//				throw new ArgumentOutOfRangeException();
	//		}
	//	}

	//	if (isFavorit)
	//	{
	//		if (favorites.Count == 0)
	//			return false;
	//		results = results.Count > 0 ? results.Intersect(favorites).ToList() : favorites;
	//	}

	//	return true;
	//}

	//private bool ResourcesIdByColor(IList<FilterItem> filterItems, ref List<Guid> results)
	//{
	//	var userId = _userUtil.GetCurrentUser(_context.HttpContext).Id;

	//	List<Guid> colors = new List<Guid>();
	//	bool isColors = false;
	//	foreach (var filterItem in filterItems.Where(item => item.FilterType == FilterEnumType.InColor))
	//	{
	//		isColors = true;
	//		var filterValues = filterItem.FilterValue.StringValue;
	//		if (filterValues.Contains(SystemConfig.DefaultColor))
	//		{
	//			var srvcResource = _serviceProvider.GetRequiredService<IResourceService>();
	//			colors = srvcResource.Find(
	//				_specificationFactory.GetBuilderSpecification<IBuilderResource>().IsColorNull().Build(),
	//				_fetchFactory.GetFetch<IFetchResourceWithFilterOnlyColor>()).Select(item => item.Id).ToList();
	//		}

	//		var spec = _specificationFactory.GetBuilderSpecification<IBuilderObjectColor>()
	//			.ByUserId(userId)
	//			.And()
	//			.ByObjectType(ObjectType.Resource)
	//			.And()
	//			.ByHexColorIn(filterItem.FilterValue.StringValue).Build();
	//		if (spec == null && colors.Count == 0)
	//		{
	//			{
	//				return false;
	//			}
	//		}

	//		var srvcResourceColor =
	//			new ObjectColorService(_unitOfWorkFactory, _dataAccessFactory, _context, _userUtil);
	//		var resourcesWithUserColor = srvcResourceColor.Find(spec).Select(item => item.ObjectId).ToList();
	//		colors = colors.Union(resourcesWithUserColor).ToList();
	//	}

	//	if (isColors)
	//	{
	//		if (colors.Count == 0)
	//		{
	//			return false;
	//		}

	//		results = results.Count > 0 ? results.Intersect(colors).ToList() : colors;
	//	}

	//	return true;
	//}

	#endregion

	//public List<Guid> GetProjectsId(IList<FilterItem> filterItems)
	//{
	//	var results = new List<Guid>();

	//	if (!GetObjectsId(filterItems, SearchConst.ProjectIndex, ref results))
	//		return new List<Guid>();

	//	//цвет
	//	if (!ProjectsIdByColor(filterItems, ref results))
	//		return new List<Guid>();

	//	//избранные
	//	if (!ProjectsIdByFavorite(filterItems, ref results))
	//		return new List<Guid>();

	//	return results;
	//}


	#region Projects

	//private bool ProjectsIdByFavorite(IEnumerable<FilterItem> filterItems, ref List<Guid> results)
	//{
	//	var userId = _userUtil.GetCurrentUser(_context.HttpContext).Id;
	//	var favorites = new List<Guid>();
	//	bool isFavorit = false;
	//	foreach (var filterItem in filterItems.Where(item => item.TabType == TabType.Quick &&
	//														 item.CustomFieldId == FieldKeyConst.CFFavorite))
	//	{
	//		isFavorit = true;
	//		switch (filterItem.FilterType)
	//		{
	//			case FilterEnumType.Equals:
	//				{
	//					var spec = _specificationFactory.GetBuilderSpecification<IBuilderFavorite>()
	//						.GetAllFavorites(FavoriteType.Project, userId).Build();
	//					if (spec == null)
	//						break;

	//					var srvcFavorite = _serviceProvider.GetRequiredService<IFavoriteService>();

	//					favorites = srvcFavorite.Find(spec).Select(item => item.ObjectId).ToList();
	//					break;
	//				}
	//			case FilterEnumType.Between:
	//				break;
	//			case FilterEnumType.Like:
	//				break;
	//			case FilterEnumType.In:
	//				break;
	//			case FilterEnumType.InWithLevels:
	//				break;
	//			case FilterEnumType.InColor:
	//				break;
	//			default:
	//				throw new ArgumentOutOfRangeException();
	//		}
	//	}

	//	if (isFavorit)
	//	{
	//		if (favorites.Count == 0)
	//			return false;
	//		results = results.Count > 0 ? results.Intersect(favorites).ToList() : favorites;
	//	}

	//	return true;
	//}

	//private bool ProjectsIdByColor(IList<FilterItem> filterItems, ref List<Guid> results)
	//{
	//	var userId = _userUtil.GetCurrentUser(_context.HttpContext).Id;

	//	var colors = new List<Guid>();
	//	var isColors = false;
	//	foreach (var filterItem in filterItems.Where(item => item.FilterType == FilterEnumType.InColor))
	//	{
	//		isColors = true;
	//		var filterValues = filterItem.FilterValue.StringValue;
	//		if (filterValues.Contains(SystemConfig.DefaultColor))
	//		{
	//			var srvcProject = _serviceProvider.GetRequiredService<IProjectService>();
	//			colors = srvcProject.GetProjectsId(
	//				_specificationFactory.GetBuilderSpecification<IBuilderProject>().IsColorNull().Build(),
	//				_fetchFactory.GetFetch<IFetchProjectWithFilterOnlyColor>()).ToList();
	//		}

	//		var spec = _specificationFactory.GetBuilderSpecification<IBuilderObjectColor>()
	//			.ByUserId(userId)
	//			.And()
	//			.ByObjectType(ObjectType.Project)
	//			.And()
	//			.ByHexColorIn(filterItem.FilterValue.StringValue).Build();
	//		if (spec == null && colors.Count == 0)
	//		{
	//			{
	//				return false;
	//			}
	//		}

	//		var srvcProjectColor =
	//			new ObjectColorService(_unitOfWorkFactory, _dataAccessFactory, _context, _userUtil);
	//		var projectsWithUserColor = srvcProjectColor.Find(spec).Select(item => item.ObjectId).ToList();
	//		colors = colors.Union(projectsWithUserColor).ToList();
	//	}

	//	if (isColors)
	//	{
	//		if (colors.Count == 0)
	//		{
	//			return false;
	//		}

	//		results = results.Count > 0 ? results.Intersect(colors).ToList() : colors;
	//	}

	//	return true;
	//}

	#endregion


	//public List<Guid> GetTasksId(IList<FilterItem> filterItems)
	//{
	//	//return _taskSearch.GetTasksId(filterItems);


	//	string KEY_INDEX = SearchConst.TaskIndex;

	//	SearchRequest sr = new SearchRequest(KEY_INDEX);
	//	var filters = new List<Filter>();
	//	List<Guid> results = new List<Guid>();

	//	bool isDefaultFilter = false;
	//	bool isUsedNaN = false;
	//	foreach (var filterItem in filterItems.Where(item => item.TabType != TabType.Color &&
	//														 !(item.TabType == TabType.Quick &&
	//														   item.CustomFieldId == FieldKeyConst.CFFavorite) &&
	//														 !(item.TabType == TabType.Quick &&
	//														   item.CustomFieldId == FieldKeyConst.CFAvailability)
	//			 ))
	//	{
	//		isDefaultFilter = true;
	//		if (filterItem.FilterValue.StringValue != null &&
	//			filterItem.FilterValue.StringValue.Contains(UtilityConst.EmptyTaskId))
	//		{
	//			isUsedNaN = true;
	//			//continue;
	//		}

	//		filters.Add(CreateFilter(filterItem));
	//	}

	//	if (isDefaultFilter)
	//	{
	//		if (filters.Count <= 0 && !isUsedNaN)
	//			return new List<Guid>();

	//		sr.Filters = filters;
	//		var response = Search(sr);
	//		results = response.ObjectsId.ToList();


	//		if (results.Count <= 0 && !isUsedNaN)
	//			return new List<Guid>();
	//	}

	//	//цвет
	//	if (!TasksIdByColor(filterItems, ref results) && !isUsedNaN)
	//		return new List<Guid>();

	//	//избранные
	//	if (!TasksIdByFavorite(filterItems, ref results) && !isUsedNaN)
	//		return new List<Guid>();

	//	if (isUsedNaN)
	//	{
	//		results.Add(Guid.Parse(UtilityConst.EmptyTaskId));
	//	}

	//	return results;


	//	//return null;
	//}


	#region Tasks

	//private bool TasksIdByFavorite(IEnumerable<FilterItem> filterItems, ref List<Guid> results)
	//{
	//	var userId = _userUtil.GetCurrentUser(_context.HttpContext).Id;
	//	var favorites = new List<Guid>();
	//	bool isFavorit = false;
	//	foreach (var filterItem in filterItems.Where(item => item.TabType == TabType.Quick &&
	//														 item.CustomFieldId == FieldKeyConst.CFFavorite))
	//	{
	//		isFavorit = true;
	//		switch (filterItem.FilterType)
	//		{
	//			case FilterEnumType.Equals:
	//				{
	//					var spec = _specificationFactory.GetBuilderSpecification<IBuilderFavorite>()
	//						.GetAllFavorites(FavoriteType.Task, userId).Build();
	//					if (spec == null)
	//						break;

	//					var srvcFavorite = _serviceProvider.GetRequiredService<IFavoriteService>();

	//					favorites = srvcFavorite.Find(spec).Select(item => item.ObjectId).ToList();
	//					break;
	//				}
	//			case FilterEnumType.Between:
	//				break;
	//			case FilterEnumType.Like:
	//				break;
	//			case FilterEnumType.In:
	//				break;
	//			case FilterEnumType.InWithLevels:
	//				break;
	//			case FilterEnumType.InColor:
	//				break;
	//			default:
	//				throw new ArgumentOutOfRangeException();
	//		}
	//	}

	//	if (isFavorit)
	//	{
	//		if (favorites.Count == 0)
	//			return false;
	//		results = results.Count > 0 ? results.Intersect(favorites).ToList() : favorites;
	//	}

	//	return true;
	//}

	//private bool TasksIdByColor(IList<FilterItem> filterItems, ref List<Guid> results)
	//{
	//	var userId = _userUtil.GetCurrentUser(_context.HttpContext).Id;

	//	var colors = new List<Guid>();
	//	var isColors = false;
	//	foreach (var filterItem in filterItems.Where(item => item.FilterType == FilterEnumType.InColor))
	//	{
	//		isColors = true;
	//		var filterValues = filterItem.FilterValue.StringValue;
	//		if (filterValues.Contains(SystemConfig.DefaultColor))
	//		{
	//			var srvcTask = _serviceProvider.GetRequiredService<ITaskService>();
	//			colors = srvcTask.GetTasksId(
	//				_specificationFactory.GetBuilderSpecification<IBuilderTask>().IsColorNull().Build(),
	//				_fetchFactory.GetFetch<IFetchTaskWithFilterOnlyColor>()).ToList();
	//		}

	//		var spec = _specificationFactory.GetBuilderSpecification<IBuilderObjectColor>()
	//			.ByUserId(userId)
	//			.And()
	//			.ByObjectType(ObjectType.Task)
	//			.And()
	//			.ByHexColorIn(filterItem.FilterValue.StringValue).Build();
	//		if (spec == null && colors.Count == 0)
	//		{
	//			{
	//				return false;
	//			}
	//		}

	//		var srvcTaskColor =
	//			new ObjectColorService(_unitOfWorkFactory, _dataAccessFactory, _context, _userUtil);
	//		var tasksWithUserColor = srvcTaskColor.Find(spec).Select(item => item.ObjectId).ToList();
	//		colors = colors.Union(tasksWithUserColor).ToList();
	//	}

	//	if (isColors)
	//	{
	//		if (colors.Count == 0)
	//		{
	//			return false;
	//		}

	//		results = results.Count > 0 ? results.Intersect(colors).ToList() : colors;
	//	}

	//	return true;
	//}

	#endregion

	//#region Trainings

	//public List<Guid> GetTrainingsId(IList<FilterItem> filterItems)
	//{
	//	string KEY_INDEX = SearchConst.TrainingIndex;

	//	SearchRequest sr = new SearchRequest(KEY_INDEX);
	//	var filters = new List<Filter>();
	//	List<Guid> results = new List<Guid>();

	//	bool isDefaultFilter = false;
	//	foreach (var filterItem in filterItems.Where(item => item.TabType != TabType.Color &&
	//														 !(item.TabType == TabType.Quick &&
	//														   item.CustomFieldId == FieldKeyConst.CFFavorite) &&
	//														 !(item.TabType == TabType.Quick &&
	//														   item.CustomFieldId == FieldKeyConst.CFAvailability)
	//			 ))
	//	{
	//		isDefaultFilter = true;
	//		filters.Add(CreateFilter(filterItem));
	//	}

	//	if (isDefaultFilter)
	//	{
	//		if (filters.Count <= 0)
	//			return new List<Guid>();

	//		sr.Filters = filters;
	//		var response = Search(sr);
	//		results = response.ObjectsId.ToList();

	//		if (results.Count <= 0)
	//			return new List<Guid>();
	//	}

	//	return results;
	//}

	//#endregion

	//#region Questionnaires

	//public List<Guid> GetQuestionnairesId(IList<FilterItem> filterItems)
	//{
	//	string KEY_INDEX = SearchConst.FormIndex;

	//	SearchRequest sr = new SearchRequest(KEY_INDEX);
	//	var filters = new List<Filter>();
	//	List<Guid> results = new List<Guid>();

	//	bool isDefaultFilter = false;
	//	foreach (var filterItem in filterItems.Where(item => item.TabType != TabType.Color &&
	//														 !(item.TabType == TabType.Quick &&
	//														   item.CustomFieldId == FieldKeyConst.CFFavorite) &&
	//														 !(item.TabType == TabType.Quick &&
	//														   item.CustomFieldId == FieldKeyConst.CFAvailability)
	//			 ))
	//	{
	//		isDefaultFilter = true;
	//		filters.Add(CreateFilter(filterItem));
	//	}

	//	if (isDefaultFilter)
	//	{
	//		if (filters.Count <= 0)
	//			return new List<Guid>();

	//		sr.Filters = filters;
	//		var response = Search(sr);
	//		results = response.ObjectsId.ToList();

	//		if (results.Count <= 0)
	//			return new List<Guid>();
	//	}

	//	return results;
	//}

	//#endregion

	//#region Meeting

	//public List<Guid> GetMeetingsId(IList<FilterItem> filterItems)
	//{
	//	var results = new List<Guid>();

	//	if (!GetObjectsId(filterItems, SearchConst.MeetingIndex, ref results))
	//		return new List<Guid>();

	//	return results;
	//}

	//#endregion

	//#region CareerDevelopmentDay

	//public List<Guid> GetCareerDevelopmentDaysId(IList<FilterItem> filterItems)
	//{
	//	string KEY_INDEX = SearchConst.CddIndex;

	//	SearchRequest sr = new SearchRequest(KEY_INDEX);
	//	var filters = new List<Filter>();
	//	List<Guid> results = new List<Guid>();

	//	bool isDefaultFilter = false;
	//	foreach (var filterItem in filterItems)
	//	{
	//		isDefaultFilter = true;
	//		filters.Add(CreateFilter(filterItem));
	//	}

	//	if (isDefaultFilter)
	//	{
	//		if (filters.Count <= 0)
	//			return new List<Guid>();

	//		sr.Filters = filters;
	//		var response = Search(sr);
	//		results = response.ObjectsId.ToList();

	//		if (results.Count <= 0)
	//			return new List<Guid>();
	//	}

	//	return results;
	//}

	//public List<Guid> GetAchievementsId(IList<FilterItem> filterItems)
	//{
	//	string KEY_INDEX = SearchConst.AchievementIndex;

	//	SearchRequest sr = new SearchRequest(KEY_INDEX);
	//	var filters = new List<Filter>();
	//	List<Guid> results = new List<Guid>();

	//	bool isDefaultFilter = false;
	//	foreach (var filterItem in filterItems)
	//	{
	//		isDefaultFilter = true;
	//		filters.Add(CreateFilter(filterItem));
	//	}

	//	if (isDefaultFilter)
	//	{
	//		if (filters.Count <= 0)
	//			return new List<Guid>();

	//		sr.Filters = filters;
	//		var response = Search(sr);
	//		results = response.ObjectsId.ToList();

	//		if (results.Count <= 0)
	//			return new List<Guid>();
	//	}

	//	return results;
	//}

	//public List<Guid> GetCareerDevelopmentDaysIdLike(IList<FilterItem> filterItems)
	//{
	//	string KEY_INDEX = SearchConst.CddLikeIndex;

	//	SearchRequest sr = new SearchRequest(KEY_INDEX);
	//	var filters = new List<Filter>();
	//	List<Guid> results = new List<Guid>();

	//	bool isDefaultFilter = false;
	//	foreach (var filterItem in filterItems)
	//	{
	//		isDefaultFilter = true;
	//		filters.Add(CreateFilter(filterItem));
	//	}

	//	if (isDefaultFilter)
	//	{
	//		if (filters.Count <= 0)
	//			return new List<Guid>();

	//		sr.Filters = filters;
	//		var response = Search(sr);
	//		results = response.ObjectsId.ToList();

	//		if (results.Count <= 0)
	//			return new List<Guid>();
	//	}

	//	return results;
	//}

	//#endregion

	//#region Adaptations

	//public List<Guid> GetAdaptationsId(IList<FilterItem> filterItems)
	//{
	//	var results = new List<Guid>();

	//	if (!GetObjectsId(filterItems, SearchConst.AdaptationIndex, ref results))
	//		return new List<Guid>();

	//	return results;
	//}

	//#endregion

	//#region Attendances

	//public List<Guid> GetAttendancesId(IList<FilterItem> filterItems)
	//{
	//	var results = new List<Guid>();

	//	if (!GetObjectsId(filterItems, SearchConst.AttendanceIndex, ref results))
	//		return new List<Guid>();

	//	return results;
	//}

	//#endregion

	//#region Mentoring

	//public List<Guid> GetMentoringsId(IList<FilterItem> filterItems)
	//{
	//	var results = new List<Guid>();

	//	if (!GetObjectsId(filterItems, SearchConst.MentoringIndex, ref results))
	//		return new List<Guid>();

	//	return results;
	//}

	//#endregion

	//#region ExitInterview
	//public List<Guid> GetExitInterviewsId(IList<FilterItem> filterItems)
	//{
	//	var results = new List<Guid>();

	//	if (!GetObjectsId(filterItems, SearchConst.ExitInterviewIndex, ref results))
	//		return new List<Guid>();

	//	return results;
	//}
	//#endregion

	//#region DismissalRequest
	//public List<Guid> GetDismissalRequestId(IList<FilterItem> filterItems)
	//{
	//	var results = new List<Guid>();

	//	if (!GetObjectsId(filterItems, SearchConst.DismissaRequestlIndex, ref results))
	//		return new List<Guid>();

	//	return results;
	//}
	//#endregion

	//#region Share Resource

	//public List<Guid> GetIndividualDevelopmentPlansId(IList<FilterItem> filterItems)
	//{
	//	var results = new List<Guid>();

	//	if (!GetObjectsId(filterItems, SearchConst.IndividualDevelopmentPlanIndex, ref results))
	//		return new List<Guid>();

	//	return results;
	//}

	//public List<Guid> GetShareResourceId(IList<FilterItem> filterItems)
	//{
	//	var results = new List<Guid>();

	//	if (!GetObjectsId(filterItems, SearchConst.ShareResourceIndex, ref results))
	//		return new List<Guid>();

	//	return results;
	//}
	//#endregion

	//#region Mentorship
	//public List<Guid> GetKeymentorshipsId(IList<FilterItem> filterItems)
	//{
	//	var mentorshipIds = new List<Guid>();

	//	if (!GetObjectsId(filterItems, SearchConst.MentorshipIndex, ref mentorshipIds))
	//		return new List<Guid>();

	//	return mentorshipIds;
	//}
	//#endregion

	//#region Gratitude
	//public List<Guid> GetGratitudesId(IList<FilterItem> filterItems)
	//{
	//	var gratitudeIds = new List<Guid>();

	//	if (!GetObjectsId(filterItems, SearchConst.GratitudeIndex, ref gratitudeIds))
	//		return new List<Guid>();

	//	return gratitudeIds;
	//}
	//#endregion

	//#region Candidate
	//public List<Guid> GetCandidateId(IList<FilterItem> filterItems)
	//{
	//	var results = new List<Guid>();

	//	if (!GetObjectsId(filterItems, SearchConst.CandidateIndex, ref results))
	//		return new List<Guid>();

	//	return results;
	//}
	//#endregion

	//#region PersonnelReserve

	//public List<Guid> GetPersonnelReservesId(IList<FilterItem> filterItems)
	//{
	//	var results = new List<Guid>();

	//	if (!GetObjectsId(filterItems, SearchConst.PersonnelReserveIndex, ref results))
	//		return new List<Guid>();

	//	return results;
	//}

	//public List<Guid> GetPositionResponsesId(IList<FilterItem> filterItems)
	//{
	//	var results = new List<Guid>();

	//	if (!GetObjectsId(filterItems, SearchConst.PositionResponseIndex, ref results))
	//		return new List<Guid>();

	//	return results;
	//}

	//#endregion

	//#region KeyResource

	//public List<Guid> GetKeyResourcesId(IList<FilterItem> filterItems)
	//{
	//	var results = new List<Guid>();

	//	if (!GetObjectsId(filterItems, SearchConst.KeyResourceIndex, ref results))
	//		return new List<Guid>();

	//	return results;
	//}

	//#endregion

	//#region SecretSanta

	//public List<Guid> GetSecretSantasId(IList<FilterItem> filterItems)
	//{
	//	var results = new List<Guid>();

	//	if (!GetObjectsId(filterItems, SearchConst.SecretSantaIndex, ref results))
	//		return new List<Guid>();

	//	return results;
	//}

	//#endregion

	private bool GetObjectsId(IList<FilterItem> filterItems, string keyIndex, ref List<Guid> results)
	{
		string KEY_INDEX = keyIndex;
		SearchRequest sr = new SearchRequest(KEY_INDEX);
		var filters = new List<Filter>();

		bool isDefaultFilter = false;
		foreach (var filterItem in filterItems.Where(item => item.FilterType != FilterEnumType.InColor &&
															 !(item.TabType == TabType.Quick &&
															   item.CustomFieldId == FieldKeyConst.CFFavorite) &&
															 !(item.TabType == TabType.Quick &&
															   item.CustomFieldId == FieldKeyConst.CFAvailability)
				 ))
		{
			isDefaultFilter = true;
			filters.Add(CreateFilter(filterItem));
		}

		if (isDefaultFilter)
		{
			if (filters.Count <= 0)
				return false;

			sr.Filters = filters;
			var response = Search(sr);
			results = response.ObjectsId.ToList();

			if (results.Count <= 0)
				return false;
		}

		return true;
	}

	private static Filter CreateFilter(FilterItem filterItem)
	{
		var filter = new Filter
		{
			Key = filterItem.CustomFieldId.ToString(),
			Values = filterItem.FilterValue.StringValue
		};

		switch (filterItem.FilterType)
		{
			case FilterEnumType.Between:
				filter.FilterMode = FilterMode.Between;
				filter.Values = new List<string>();
				filter.Values.Add(filterItem.FilterValue.DateFrom != null
					? filterItem.FilterValue.DateFrom.Value.Date.ToString()
					: DateTime.MinValue.Date.ToString());

				filter.Values.Add(filterItem.FilterValue.DateTo != null
					? filterItem.FilterValue.DateTo.Value.Date.ToString()
					: DateTime.MaxValue.Date.ToString());
				break;
			case FilterEnumType.BetweenForInt:
				filter.FilterMode = FilterMode.BetweenForInt;

				filter.Values = new List<string>();
				filter.Values.Add(filterItem.FilterValue.RangeIntFrom != null
					? filterItem.FilterValue.RangeIntFrom.ToString()
					: int.MinValue.ToString());

				filter.Values.Add(filterItem.FilterValue.RangeIntTo != null
					? filterItem.FilterValue.RangeIntTo.ToString()
					: int.MaxValue.ToString());
				break;
			case FilterEnumType.Like:
				filter.FilterMode = FilterMode.Like;
				break;
			case FilterEnumType.In:
				filter.FilterMode = FilterMode.In;
				break;
			case FilterEnumType.InColor:
				filter.FilterMode = FilterMode.In;
				break;
			case FilterEnumType.Equals:
				filter.FilterMode = FilterMode.Equals;
				break;
			case FilterEnumType.InWithLevels:
				filter.FilterMode = FilterMode.In;
				filter.Values = new List<string>();
				foreach (var tagWithLevels in filterItem.FilterValue.TagWithLevels)
				{
					//для поиска по метке с любым уровнем
					if (tagWithLevels.Value.Count == 0)
					{
						filter.Values.Add(tagWithLevels.Key);
					}
					else
					{
						//для поиска по метке с определенным уровнем
						filter.Values.AddRange(
							tagWithLevels.Value.Select(level => string.Concat(tagWithLevels.Key, UtilityConst.SplitterBetweenTagAndLevel, level)));
					}
				}

				break;
			default:
				throw new ArgumentOutOfRangeException();
		}

		return filter;
	}

	public async Task RemoveInIndex(List<Guid> objectsId, string key, ObjectType objectType)
	{
		var request = await GetBuildIndexRequest(objectsId, key, objectType);
		using (var searchEngine = _serviceProvider.GetRequiredService<ISearchEngine>())
		{
			searchEngine.RemoveIndex(request);
		}
	}

}
