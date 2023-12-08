using HR.Infrastructure.SearchEngine.Models;
using ObjectType = HR.CrossCutting.Enum.ObjectType;

namespace HR.Infrastructure.Services;
public interface ISearchService : IServiceMarker
{
	Task BuildIndex(List<Guid> objectsId, string key, ObjectType objectType);
	void BuildIndex(BuildIndexRequest request);
	SearchResponse Search(SearchRequest request);

	List<Guid> GetResourcesId(IList<FilterItem> filterItems);
	//List<Guid> GetAdaptationsId(IList<FilterItem> filterItems);
	//List<Guid> GetAttendancesId(IList<FilterItem> filterItems);	
	//List<Guid> GetProjectsId(IList<FilterItem> filterItems);
	//List<Guid> GetTasksId(IList<FilterItem> filterItems);
	//List<Guid> GetTrainingsId(IList<FilterItem> filterItems);
	//List<Guid> GetQuestionnairesId(IList<FilterItem> filterItems);
	//List<Guid> GetMeetingsId(IList<FilterItem> filterItems);
	//List<Guid> GetCareerDevelopmentDaysId(IList<FilterItem> filterItems);
	//List<Guid> GetAchievementsId(IList<FilterItem> filterItems);
	//List<Guid> GetCareerDevelopmentDaysIdLike(IList<FilterItem> filterItems);
	//List<Guid> GetMentoringsId(IList<FilterItem> filterItems);
	//List<Guid> GetExitInterviewsId(IList<FilterItem> filterItems);
	//List<Guid> GetDismissalRequestId(IList<FilterItem> filterItems);
	//List<Guid> GetPersonnelReservesId(IList<FilterItem> filterItems);
	//List<Guid> GetIndividualDevelopmentPlansId(IList<FilterItem> filterItems);
	//List<Guid> GetShareResourceId(IList<FilterItem> filterItems);
	//List<Guid> GetCandidateId(IList<FilterItem> filterItems);
	//List<Guid> GetPositionResponsesId(IList<FilterItem> filterItems);
	//List<Guid> GetKeyResourcesId(IList<FilterItem> filterItems);
	//List<Guid> GetKeymentorshipsId(IList<FilterItem> filterItems);
	//List<Guid> GetGratitudesId(IList<FilterItem> filterItems);
	//List<Guid> GetSecretSantasId(IList<FilterItem> filterItems);

	Task RemoveInIndex(List<Guid> objectsId, string key, ObjectType objectType);
}
