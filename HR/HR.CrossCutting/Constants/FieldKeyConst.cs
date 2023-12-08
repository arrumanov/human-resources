using HR.CrossCutting.Attributes;
using HR.CrossCutting.Enum;
using System.Reflection;

namespace HR.CrossCutting.Constants;
public static class FieldKeyConst
{
	#region Resource

	public const string None = "None";

	public const string CFPersonnelNumber = "CFPersonnelNumber";
	public const string CFTypeOfEmployment = "CFTypeOfEmployment";
	public const string CFUnit = "CFUnit";
	public const string CFUnitOther = "CFUnitOther";
	public const string CFIsStudent = "CFIsStudent";
	public const string CFIsYongSpecialist = "CFIsYongSpecialist";
	public const string CFHierarchyLevel = "CFHierarchyLevel";
	public const string CFKeyCompetence = "CFKeyCompetence";
	public const string CFSubCompetence = "CFSubCompetence";
	public const string CFResource = "CFResource";
	public const string CFResources = "CFResources";
	public const string CFContractType = "CFContractType";
	public const string CFNationality = "CFNationality";
	public const string CFCityOfWork = "CFCityOfWork";
	public const string CFDateOfBirth = "CFDateOfBirth";
	public const string CFGender = "CFGender";
	public const string CFPosition = "CFPosition";
	public const string CFStatus = "CFStatus";
	public const string CFIsDisabled = "CFIsDisabled";
	public const string CFResourceManager = "CFResourceManager";
	public const string CFParticipatingEmployees = "CFParticipatingEmployees";
	public const string CFMentors = "CFMentors";
	public const string CFDateOfEmployment = "CFDateOfEmployment";
	public const string CFDateOfEmploymentInLastDepartment = "CFDateOfEmploymentInLastDepartment";
	public const string CFStageDeegreeManager = "CFStageDeegreeManager";
	public const string CFEmail = "CFEmail";
	public const string CFAreaDevelopmentsManager = "CFAreaDevelopmentsManager";
	public const string CFIsExpertCDD = "CFIsExpertCDD";
	public const string CFIsKDRCompleted = "CFIsKDRCompleted";
	public const string CFTypeMentorship = "CFTypeMentorship";
	public const string CFGradeMentorship = "CFGradeMentorship";

	public const string CFDevelopmentActions = "CFDevelopmentActions";
	public const string CFCompetenceAndSkill = "CFCompetenceAndSkill";
	public const string CFDatePlanIdp = "CFDatePlanIdp";
	public const string CFDateIdp = "CFDateIdp";
	public const string CFDevelopmentTask = "CFDevelopmentTask";
	public const string CFCommentIdp = "CFCommentIdp";

	public const string CFFromResourceUnit = "CFFromResourceUnit";
	public const string CFToResourceUnit = "CFToResourceUnit";

	public const string CFDateFactEndIdp = "CFDateFactEndIdp";
	//public const string CFUpperUnit = "CFUpperUnit";

	#endregion

	#region ExitInterview

	public const string CFReasonForTermination = "CFReasonForTermination";
	public const string CFNewAssignment = "CFNewAssigment";
	public const string CFNewPosition = "CFNewPosition";
	public const string CFExperience = "CFExperience";
	public const string CFReasonForTerminationDictionary = "CFReasonForTerminationDictionary";
	public const string CFExperienceRange = "CFExperienceRange";
	public const string CFReasonForDismissialSupervisor = "CFReasonForDismissialSupervisor";
	public const string CFReasonForDismissialResource = "CFReasonForDismissialResource";
	public const string CFDiscussedWithSupervisor = "CFDiscussedWithSupervisor";
	public const string CFVacanciesInCompany = "CFVacanciesInCompany";
	public const string CFResultOfExitInterview = "CFResultOfExitInterview";
	public const string CFInterviewer = "CFInterviewer";
	public const string CFExitItnerviewSummary1 = "CFExitItnerviewSummary1";
	public const string CFExitInterviewSummary2 = "CFExitInterviewSummary2";
	public const string CFExitInterviewSummary3 = "CFExitInterviewSummary3";
	public const string CFExitInterviewSummary4 = "CFExitInterviewSummary4";
	public const string CFExitInterviewSummary5 = "CFExitInterviewSummary5";
	public const string CFExitInterviewSummary6 = "CFExitInterviewSummary6";
	public const string CFExitInterviewSummary7 = "CFExitInterviewSummary7";
	public const string CFExitInterviewSummary8 = "CFExitInterviewSummary8";
	public const string CFExitInterviewSummary9 = "CFExitInterviewSummary9";
	public const string CFExitInterviewSummary10 = "CFExitInterviewSummary10";
	public const string CFExitInterviewSummary = "CFExitInterviewSummary";
	#endregion

	#region Project

	//project
	public const string CFCategory = "CFCategory";
	public const string CFType = "CFType";
	public const string CFState = "CFState";
	public const string CFManager = "CFManager";
	public const string CFJiraKey = "CFJiraKey";

	#endregion

	#region CDD

	//cdd
	public const string CFEmployeeInvolved = "CFEmployeeInvolved";
	public const string CFTechnicalExpertise = "CFTechnicalExpertise";
	public const string CFAchievementSmallName = "CFAchievementSmallName";
	public const string CFParticipantsOfQuestionnaire = "CFParticipantsOfQuestionnaire";
	public const string CFParticipantsOfQuestionnaireAdditional = "CFParticipantsOfQuestionnaireAdditional";
	public const string CFParticipantsOfQuestionnaireRMAdditional = "CFParticipantsOfQuestionnaireRMAdditional";
	public const string CFParticipantsOfQuestionnaireRM = "CFParticipantsOfQuestionnaireRM";
	public const string CFParticipantsOfQuestionnaireLead = "CFParticipantsOfQuestionnaireLead";
	public const string CFIsPostponed = "CFIsPostponed";
	public const string CFTypeOfCDD = "CFTypeOfCDD";
	public const string CFReasonForTransfer = "CFReasonForTransfer";
	public const string CFCddTransferDate = "CFCddTransferDate";
	#endregion

	//PositionResponse
	public const string CFWhatInterested = "CFWhatInterested";
	public const string CFWhatJustified = "CFWhatJustified";
	public const string CFWhatDevelop = "CFWhatDevelop";
	public const string CFWhatReadyFor = "CFWhatReadyFor";
	public const string CFWhatExperience = "CFWhatExperience";
	public const string CFWhatReplacement = "CFWhatReplacement";

	public const string CFRiskOfLeaving = "CFRiskOfLeaving";
	public const string CFResourceSuccessor = "CFResourceSuccessor";
	public const string CFKeySkills = "CFKeySkills";
	public const string CFKeySkillsAgreed = "CFKeySkillsAgreed";
	public const string CFWhatInterestedManager = "CFWhatInterestedManager";
	public const string CFWhatIsAttrectedManager = "CFWhatIsAttrectedManager";
	public const string CFResponseType = "CFResponseType";

	//Outcame CDD
	public const string CFParticipantsOutcameGrade = "CFParticipantsOutcameGrade";
	public const string CFExpertCddOutcameGrade = "CFExpertCddOutcameGrade";
	public const string CFExpertRatingOutcame = "CFExpertRatingOutcame";
	public const string CFHierarchyLevelOutcame = "CFHierarchyLevelOutcame";

	//Training
	public const string CFKindOfTraining = "CFKindOfTraining";
	public const string CFTypeOfTraining = "CFTypeOfTraining";
	public const string CFDirectionTraining = "CFDirectionTraining";
	public const string CFOrganization = "CFOrganization";
	public const string CFExternalTrainer = "CFExternalTrainer";
	public const string CFInternalTrainer = "CFInternalTrainer";
	public const string CFCurrency = "CFCurrency";
	public const string CFCostInCurrency = "CFCostInCurrency";

	#region DismissalRequest
	public const string CFDateOfDismissal = "CFDateOfDismissal";
	public const string CFGroundsForDismissal = "CFGroundsForDismissal";
	public const string CFReasonForDismissal = "CFReasonForDismissal";
	public const string CFStackOfDismissal = "CFStackOfDismissal";
	public const string CFIsOnline = "CFIsOnline";
	#endregion
	//ShareResource
	public const string CFStartDate = "CFStartDate";
	public const string CFEndDate = "CFEndDate";
	public const string CFFTE = "CFFTE";

	//это поле не использовать (использовать CFTeamlead)
	public const string CFTechLead = "CFTechLead";

	public const string CFLike = "CFLike";

	public const string CFSecretSanta = "CFSecretSanta";

	#region Common

	//Common
	public const string CFCreator = "CFCreator";
	public const string CFIsActive = "CFIsActive";
	public const string CFIsExternal = "CFIsExternal";
	public const string CFObjectColor = "CFObjectColor";
	public const string CFDateCreated = "CFDateCreated";
	public const string CFObjectName = "CFObjectName";
	public const string CFRate = "CFRate";
	public const string CFDateOfTermination = "CFDateOfTermination";
	public const string CFFavorite = "CFFavorite";
	public const string CFUpload = "CFUpload";
	public const string CFUploadDoc = "CFUploadDoc";
	public const string CFUploadHR = "CFUploadHR";
	public const string CFDateFrom = "CFDateFrom";
	public const string CFDateTo = "CFDateTo";
	public const string CFCost = "CFCost";
	public const string CFIsCompensationContract = "CFIsCompensationContract";
	public const string CFDescription = "CFDescription";
	public const string CFDate = "CFDate";
	public const string CFWorkflowStatus = "CFWorkflowStatus";
	public const string CFWorkflowState = "CFWorkflowState";
	public const string CFWorkflowAction = "CFWorkflowAction";
	public const string CFAvailability = "CFAvailability";
	public const string CFDuedate = "CFDuedate";
	public const string CFDateUpdated = "CFDateUpdated";
	public const string CFToResource = "CFToResource";
	public const string CFFromResource = "CFFromResource";
	public const string CFObjectType = "CFObjectType";
	public const string CFTeamlead = "CFTeamlead";
	public const string CFParticipatingHR = "CFParticipatingHR";
	public const string CFResultDescription = "CFResultDescription";
	public const string CFPrivateDescription = "CFPrivateDescription";
	public const string CFHr = "CFHr";
	public const string CFMentor = "CFMentor";
	public const string CFOwner = "CFOwner";
	public const string CFIntegerNumber = "CFIntegerNumber";
	public const string CFRole = "CFRole";
	public const string CFDirectionType = "CFDirectionType";

	public const string CFAttendanceStatus = "CFAttendanceStatus";
	public const string CFRecipientsOfMailing = "CFRecipientsOfMailing";

	public const string CFComment = "CFComment";
	public const string CFCommentDoc = "CFCommentDoc";
	public const string CFCommentHR = "CFCommentHR";

	public const string CFQuestionnaireObjectId = "CFQuestionnaireObjectId";

	public const string CFPersonnelReservePosition = "CFPersonnelReservePosition";
	public const string CFPersonnelReserve = "CFPersonnelReserve";

	#endregion

	#region Информация об опыте

	//Информация об опыте
	public const string CFResourceLabels = "CFResourceLabels";
	public const string CFProjectLabels = "CFProjectLabels";
	public const string CFTaskLabels = "CFTaskLabels";
	public const string CFProductDomain = "CFProductDomain";
	public const string CFProduct = "CFProduct";
	public const string CFFramework = "CFFramework";
	public const string CFProgrammingLanguage = "CFProgrammingLanguage";
	public const string CFLibrary = "CFLibrary";
	public const string CFNotation = "CFNotation";
	public const string CFDesignPattern = "CFDesignPattern";
	public const string CFCompletedTraining = "CFCompletedTraining";
	public const string CFTools = "CFTools";
	public const string CFSoftwareTesting = "CFSoftwareTesting";
	public const string CFEnglishLevel = "CFEnglishLevel";
	public const string CFLinkInJira = "CFLinkInJira";
	public const string CFCareerDevelopmentDay = "CFCareerDevelopmentDay";

	#endregion

	#region Анкетирование

	#region АНКЕТА ДЛЯ ДКР (навыки и комментарии)

	#region Lead Анкета

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFTeamLeadPlaningTask = "CFTeamLeadPlaningTask";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFTeamLeadTaskDetalization = "CFTeamLeadTaskDetalization";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFTeamLeadTaskExecutionMonitoring = "CFTeamLeadTaskExecutionMonitoring";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFTeamLeadMeetings = "CFTeamLeadMeetings";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFTeamLeadMentoringAdaptation = "CFTeamLeadMentoringAdaptation";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFTeamLeadKnowledgeSharing = "CFTeamLeadKnowledgeSharing";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFTeamLeadGoalSetting = "CFTeamLeadGoalSetting";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFTeamLeadTechnologyDiscussion = "CFTeamLeadTechnologyDiscussion";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFTeamLeadResultOfWork = "CFTeamLeadResultOfWork";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFTeamLeadResponsibility = "CFTeamLeadResponsibility";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFTeamLeadCommunicationWithTeam = "CFTeamLeadCommunicationWithTeam";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFTeamLeadAuthority = "CFTeamLeadAuthority";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFTeamLeadAdditional = "CFTeamLeadAdditional";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSelfLeadFunctionsOfLead = "CFSelfLeadFunctionsOfLead";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSelfLeadTaskExecutionMonitoring = "CFSelfLeadTaskExecutionMonitoring";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSelfLeadMeetings = "CFSelfLeadMeetings";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSelfLeadMentoringAdaptation = "CFSelfLeadMentoringAdaptation";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSelfLeadKnowledgeSharing = "CFSelfLeadKnowledgeSharing";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSelfLeadWasInterviews = "CFSelfLeadWasInterviews";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSelfLeadGoalSetting = "CFSelfLeadGoalSetting";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSelfLeadParticipationInTasks = "CFSelfLeadParticipationInTasks";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSelfLeadTechnologyDiscussion = "CFSelfLeadTechnologyDiscussion";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSelfLeadInterested = "CFSelfLeadInterested";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSelfLeadResultOfWork = "CFSelfLeadResultOfWork";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSelfLeadResponsibility = "CFSelfLeadResponsibility";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSelfLeadCommunicationWithTeam = "CFSelfLeadCommunicationWithTeam";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSelfLeadCompanyLoyality = "CFSelfLeadCompanyLoyality";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSelfLeadTasksInterested = "CFSelfLeadTasksInterested";

	#endregion

	#region навыки

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFMentoringSkill = "CFMentoringSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFMentoringSkillPm = "CFMentoringSkillPm";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFExpertKnowledgeSkill = "CFExpertKnowledgeSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFLoyaltyToCompanySkill = "CFLoyaltyToCompanySkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFLoyaltyToCompanySkillPm = "CFLoyaltyToCompanySkillPm";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFTeamPlayerSkill = "CFTeamPlayerSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFTeamPlayerSkillPm = "CFTeamPlayerSkillPm";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSelfIndependenceSkill = "CFSelfIndependenceSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFInitiativeSkill = "CFInitiativeSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFInitiativeSkillPm = "CFInitiativeSkillPm";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSelfEducationSkill = "CFSelfEducationSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSelfEducationSkillPm = "CFSelfEducationSkillPm";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFPresentationSkill = "CFPresentationSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFStressToleranceSkill = "CFStressToleranceSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFStressToleranceSkillPm = "CFStressToleranceSkillPm";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFRequirementsManagementSkill = "CFRequirementsManagementSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFWorkingWithDocumentationSkill = "CFWorkingWithDocumentationSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFProductKnowledgeSkill = "CFProductKnowledgeSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFUnderstandingResponsibilitiesSkill = "CFUnderstandingResponsibilitiesSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFAccuracyOfEstimatesSkill = "CFAccuracyOfEstimatesSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFAccuracyOfEstimatesSkillBa = "CFAccuracyOfEstimatesSkillBa";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFAccuracyOfEstimatesSkillQa = "CFAccuracyOfEstimatesSkillQa";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFCommunicationSkill = "CFCommunicationSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFWorkWithToolsSkill = "CFWorkWithToolsSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFPreSalesActivitySkill = "CFPreSalesActivitySkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFProjectInitiationSkill = "CFProjectInitiationSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFProjectPlanningSkill = "CFProjectPlanningSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFManagingProjectSkill = "CFManagingProjectSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFProjectClosingSkill = "CFProjectClosingSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFMethodologySkill = "CFMethodologySkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFWorkingWithRequirementsSkill = "CFWorkingWithRequirementsSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFTestCaseSkill = "CFTestCaseSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBugReportSkill = "CFBugReportSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFTestingWebSkill = "CFTestingWebSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFTestingMobileSkill = "CFTestingMobileSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFTestingApiSkill = "CFTestingApiSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFTestAutomationSkill = "CFTestAutomationSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFTestingDesktopSkill = "CFTestingDesktopSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFCodeReviewSkill = "CFCodeReviewSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFCodeQualitySkill = "CFCodeQualitySkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFRefactoringSkill = "CFRefactoringSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFDesignExperienceSkill = "CFDesignExperienceSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFCiCdSkill = "CFCiCdSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSUPLoyaltyToCompanySkill = "CFSUPLoyaltyToCompanySkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSUPTeamPlayerSkill = "CFSUPTeamPlayerSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSUPSelfIndependenceSkill = "CFSUPSelfIndependenceSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSUPSelfEducationSkill = "CFSUPSelfEducationSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSUPClientOrientedSkill = "CFSUPClientOrientedSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSUPWorkWithClientSkill = "CFSUPWorkWithClientSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSUPWorkWithAccompanyingSoftwareSkill = "CFSUPWorkWithAccompanyingSoftwareSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSUPFundamentalsOfSoftwareDevelopmentSkill = "CFSUPFundamentalsOfSoftwareDevelopmentSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSUPSubjectAreaSkill = "CFSUPSubjectAreaSkill";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQualityOfInteraction = "CFQualityOfInteraction";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFTimingInteraction = "CFTimingInteraction";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFResultOFInteraction = "CFResultOFInteraction";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFisInteractionComfortable = "CFisInteractionComfortable";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFProgrammingLanguageForTesting = "CFProgrammingLanguageForTesting";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFReportsLogingTools = "CFReportsLogingTools";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFFrameworkArchitecture = "CFFrameworkArchitecture";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFWorkWithTestDocumentation = "CFWorkWithTestDocumentation";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFToolsForTesting = "CFToolsForTesting";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFCICD = "CFCICD";

	#region Soft анкета

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation1 = "CFSoftAutomation1";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation2 = "CFSoftAutomation2";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation3 = "CFSoftAutomation3";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation4 = "CFSoftAutomation4";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation5 = "CFSoftAutomation5";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation6 = "CFSoftAutomation6";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation8 = "CFSoftAutomation8";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation9 = "CFSoftAutomation9";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation10 = "CFSoftAutomation10";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation11 = "CFSoftAutomation11";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation12 = "CFSoftAutomation12";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation13 = "CFSoftAutomation13";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation14 = "CFSoftAutomation14";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation15 = "CFSoftAutomation15";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation16 = "CFSoftAutomation16";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation17 = "CFSoftAutomation17";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation18 = "CFSoftAutomation18";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation19 = "CFSoftAutomation19";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation20 = "CFSoftAutomation20";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation21 = "CFSoftAutomation21";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation22 = "CFSoftAutomation22";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation23 = "CFSoftAutomation23";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation24 = "CFSoftAutomation24";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation25 = "CFSoftAutomation25";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation26 = "CFSoftAutomation26";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation27 = "CFSoftAutomation27";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation28 = "CFSoftAutomation28";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation29 = "CFSoftAutomation29";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation30 = "CFSoftAutomation30";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation31 = "CFSoftAutomation31";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation32 = "CFSoftAutomation32";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation33 = "CFSoftAutomation33";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation34 = "CFSoftAutomation34";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation35 = "CFSoftAutomation35";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation36 = "CFSoftAutomation36";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation37 = "CFSoftAutomation37";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation38 = "CFSoftAutomation38";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation39 = "CFSoftAutomation39";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation40 = "CFSoftAutomation40";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation41 = "CFSoftAutomation41";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation42 = "CFSoftAutomation42";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation43 = "CFSoftAutomation43";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation44 = "CFSoftAutomation44";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation45 = "CFSoftAutomation45";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation46 = "CFSoftAutomation46";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation47 = "CFSoftAutomation47";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation48 = "CFSoftAutomation48";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation49 = "CFSoftAutomation49";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation50 = "CFSoftAutomation50";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation51 = "CFSoftAutomation51";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation52 = "CFSoftAutomation52";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation53 = "CFSoftAutomation53";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation54 = "CFSoftAutomation54";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation55 = "CFSoftAutomation55";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation56 = "CFSoftAutomation56";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation57 = "CFSoftAutomation57";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation58 = "CFSoftAutomation58";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation59 = "CFSoftAutomation59";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation60 = "CFSoftAutomation60";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation61 = "CFSoftAutomation61";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation62 = "CFSoftAutomation62";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation63 = "CFSoftAutomation63";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation64 = "CFSoftAutomation64";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation65 = "CFSoftAutomation65";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation66 = "CFSoftAutomation66";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation67 = "CFSoftAutomation67";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation68 = "CFSoftAutomation68";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation69 = "CFSoftAutomation69";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation70 = "CFSoftAutomation70";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation71 = "CFSoftAutomation71";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation72 = "CFSoftAutomation72";



	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation1Self = "CFSoftAutomation1Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation2Self = "CFSoftAutomation2Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation3Self = "CFSoftAutomation3Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation4Self = "CFSoftAutomation4Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation5Self = "CFSoftAutomation5Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation6Self = "CFSoftAutomation6Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation8Self = "CFSoftAutomation8Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation9Self = "CFSoftAutomation9Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation10Self = "CFSoftAutomation10Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation11Self = "CFSoftAutomation11Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation12Self = "CFSoftAutomation12Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation13Self = "CFSoftAutomation13Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation14Self = "CFSoftAutomation14Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation15Self = "CFSoftAutomation15Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation16Self = "CFSoftAutomation16Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation17Self = "CFSoftAutomation17Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation18Self = "CFSoftAutomation18Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation19Self = "CFSoftAutomation19Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation20Self = "CFSoftAutomation20Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation21Self = "CFSoftAutomation21Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation22Self = "CFSoftAutomation22Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation23Self = "CFSoftAutomation23Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation24Self = "CFSoftAutomation24Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation25Self = "CFSoftAutomation25Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation26Self = "CFSoftAutomation26Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation27Self = "CFSoftAutomation27Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation28Self = "CFSoftAutomation28Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation29Self = "CFSoftAutomation29Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation30Self = "CFSoftAutomation30Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation31Self = "CFSoftAutomation31Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation32Self = "CFSoftAutomation32Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation33Self = "CFSoftAutomation33Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation34Self = "CFSoftAutomation34Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation35Self = "CFSoftAutomation35Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation36Self = "CFSoftAutomation36Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation37Self = "CFSoftAutomation37Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation38Self = "CFSoftAutomation38Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation39Self = "CFSoftAutomation39Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation40Self = "CFSoftAutomation40Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation41Self = "CFSoftAutomation41Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation42Self = "CFSoftAutomation42Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation43Self = "CFSoftAutomation43Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation44Self = "CFSoftAutomation44Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation45Self = "CFSoftAutomation45Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation46Self = "CFSoftAutomation46Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation47Self = "CFSoftAutomation47Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation48Self = "CFSoftAutomation48Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation49Self = "CFSoftAutomation49Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation50Self = "CFSoftAutomation50Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation51Self = "CFSoftAutomation51Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation52Self = "CFSoftAutomation52Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation53Self = "CFSoftAutomation53Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation54Self = "CFSoftAutomation54Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation55Self = "CFSoftAutomation55Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation56Self = "CFSoftAutomation56Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation57Self = "CFSoftAutomation57Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation58Self = "CFSoftAutomation58Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation59Self = "CFSoftAutomation59Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation60Self = "CFSoftAutomation60Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation61Self = "CFSoftAutomation61Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation62Self = "CFSoftAutomation62Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation63Self = "CFSoftAutomation63Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSoftAutomation64Self = "CFSoftAutomation64Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSoftAutomation65Self = "CFSoftAutomation65Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSoftAutomation66Self = "CFSoftAutomation66Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation67Self = "CFSoftAutomation67Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation68Self = "CFSoftAutomation68Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation69Self = "CFSoftAutomation69Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation70Self = "CFSoftAutomation70Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation71Self = "CFSoftAutomation71Self";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSoftAutomation72Self = "CFSoftAutomation72Self";


	//comment
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSoftAutomationComment73 = "CFSoftAutomationComment73";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSoftAutomationComment63 = "CFSoftAutomationComment63";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSoftAutomationComment54 = "CFSoftAutomationComment54";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSoftAutomationComment41 = "CFSoftAutomationComment41";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSoftAutomationComment33 = "CFSoftAutomationComment33";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSoftAutomationComment23 = "CFSoftAutomationComment23";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSoftAutomationComment19 = "CFSoftAutomationComment19";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSoftAutomationComment7 = "CFSoftAutomationComment7";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSoftAutomationComment7Self = "CFSoftAutomationComment7Self";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSoftAutomationComment19Self = "CFSoftAutomationComment19Self";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSoftAutomationComment23Self = "CFSoftAutomationComment23Self";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSoftAutomationComment33Self = "CFSoftAutomationComment33Self";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSoftAutomationComment41Self = "CFSoftAutomationComment41Self";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSoftAutomationComment54Self = "CFSoftAutomationComment54Self";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSoftAutomationComment63Self = "CFSoftAutomationComment63Self";

	#endregion


	//Оценка ресурсного менеджера
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFImplementationStrategyOfCompany1 = "CFImplementationStrategyOfCompany1";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFImplementationStrategyOfCompany2 = "CFImplementationStrategyOfCompany2";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFImplementationStrategyOfCompany3 = "CFImplementationStrategyOfCompany3";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFImplementationStrategyOfCompany4 = "CFImplementationStrategyOfCompany4";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFImplementationStrategyOfCompany5 = "CFImplementationStrategyOfCompany5";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFImplementationStrategyOfCompany6 = "CFImplementationStrategyOfCompany6";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFImplementationStrategyOfCompany7 = "CFImplementationStrategyOfCompany7";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFMotivationAndEducationOfEmployee1 = "CFMotivationAndEducationOfEmployee1";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFMotivationAndEducationOfEmployee2 = "CFMotivationAndEducationOfEmployee2";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFMotivationAndEducationOfEmployee3 = "CFMotivationAndEducationOfEmployee3";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFMotivationAndEducationOfEmployee4 = "CFMotivationAndEducationOfEmployee4";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFMotivationAndEducationOfEmployee5 = "CFMotivationAndEducationOfEmployee5";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFMotivationAndEducationOfEmployee6 = "CFMotivationAndEducationOfEmployee6";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFMotivationAndEducationOfEmployee7 = "CFMotivationAndEducationOfEmployee7";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFMotivationAndEducationOfEmployee8 = "CFMotivationAndEducationOfEmployee8";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFMotivationAndEducationOfEmployee9 = "CFMotivationAndEducationOfEmployee9";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFTeamPlayer1 = "CFTeamPlayer1";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFTeamPlayer2 = "CFTeamPlayer2";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFTeamPlayer3 = "CFTeamPlayer3";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFTeamPlayer4 = "CFTeamPlayer4";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFTeamPlayer5 = "CFTeamPlayer5";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFTeamPlayer6 = "CFTeamPlayer6";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFLoyalityToCompany1 = "CFLoyalityToCompany1";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFLoyalityToCompany2 = "CFLoyalityToCompany2";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFLoyalityToCompany3 = "CFLoyalityToCompany3";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFPresentationAndCommunicationSkills1 = "CFPresentationAndCommunicationSkills1";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFPresentationAndCommunicationSkills2 = "CFPresentationAndCommunicationSkills2";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFPresentationAndCommunicationSkills3 = "CFPresentationAndCommunicationSkills3";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFPresentationAndCommunicationSkills4 = "CFPresentationAndCommunicationSkills4";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFPresentationAndCommunicationSkills5 = "CFPresentationAndCommunicationSkills5";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFExpertKnowledge1 = "CFExpertKnowledge1";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFExpertKnowledge2 = "CFExpertKnowledge2";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFExpertKnowledge3 = "CFExpertKnowledge3";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFExpertKnowledge4 = "CFExpertKnowledge4";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFExpertKnowledge5 = "CFExpertKnowledge5";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFExpertKnowledge6 = "CFExpertKnowledge6";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFReadyToChanges1 = "CFReadyToChanges1";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFReadyToChanges2 = "CFReadyToChanges2";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFReadyToChanges3 = "CFReadyToChanges3";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFReadyToChanges4 = "CFReadyToChanges4";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFReadyToChanges5 = "CFReadyToChanges5";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFReadyToChanges6 = "CFReadyToChanges6";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFReadyToChanges7 = "CFReadyToChanges7";

	//оценка RM SELF
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFImplementationStrategyOfCompanySelf1 = "CFImplementationStrategyOfCompanySelf1";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFImplementationStrategyOfCompanySelf2 = "CFImplementationStrategyOfCompanySelf2";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFImplementationStrategyOfCompanySelf3 = "CFImplementationStrategyOfCompanySelf3";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFImplementationStrategyOfCompanySelf4 = "CFImplementationStrategyOfCompanySelf4";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFImplementationStrategyOfCompanySelf5 = "CFImplementationStrategyOfCompanySelf5";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFImplementationStrategyOfCompanySelf6 = "CFImplementationStrategyOfCompanySelf6";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFImplementationStrategyOfCompanySelf7 = "CFImplementationStrategyOfCompanySelf7";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFMotivationAndEducationOfEmployeeSelf1 = "CFMotivationAndEducationOfEmployeeSelf1";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFMotivationAndEducationOfEmployeeSelf2 = "CFMotivationAndEducationOfEmployeeSelf2";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFMotivationAndEducationOfEmployeeSelf3 = "CFMotivationAndEducationOfEmployeeSelf3";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFMotivationAndEducationOfEmployeeSelf4 = "CFMotivationAndEducationOfEmployeeSelf4";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFMotivationAndEducationOfEmployeeSelf5 = "CFMotivationAndEducationOfEmployeeSelf5";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFMotivationAndEducationOfEmployeeSelf6 = "CFMotivationAndEducationOfEmployeeSelf6";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFMotivationAndEducationOfEmployeeSelf7 = "CFMotivationAndEducationOfEmployeeSelf7";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFMotivationAndEducationOfEmployeeSelf8 = "CFMotivationAndEducationOfEmployeeSelf8";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFMotivationAndEducationOfEmployeeSelf9 = "CFMotivationAndEducationOfEmployeeSelf9";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFTeamPlayerSelf1 = "CFTeamPlayerSelf1";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFTeamPlayerSelf2 = "CFTeamPlayerSelf2";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFTeamPlayerSelf3 = "CFTeamPlayerSelf3";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFTeamPlayerSelf4 = "CFTeamPlayerSelf4";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFTeamPlayerSelf5 = "CFTeamPlayerSelf5";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFTeamPlayerSelf6 = "CFTeamPlayerSelf6";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFLoyalityToCompanySelf1 = "CFLoyalityToCompanySelf1";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFLoyalityToCompanySelf2 = "CFLoyalityToCompanySelf2";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFLoyalityToCompanySelf3 = "CFLoyalityToCompanySelf3";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFPresentationAndCommunicationSkillsSelf1 = "CFPresentationAndCommunicationSkillsSelf1";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFPresentationAndCommunicationSkillsSelf2 = "CFPresentationAndCommunicationSkillsSelf2";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFPresentationAndCommunicationSkillsSelf3 = "CFPresentationAndCommunicationSkillsSelf3";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFPresentationAndCommunicationSkillsSelf4 = "CFPresentationAndCommunicationSkillsSelf4";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFPresentationAndCommunicationSkillsSelf5 = "CFPresentationAndCommunicationSkillsSelf5";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFExpertKnowledgeSelf1 = "CFExpertKnowledgeSelf1";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFExpertKnowledgeSelf2 = "CFExpertKnowledgeSelf2";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFExpertKnowledgeSelf3 = "CFExpertKnowledgeSelf3";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFExpertKnowledgeSelf4 = "CFExpertKnowledgeSelf4";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFExpertKnowledgeSelf5 = "CFExpertKnowledgeSelf5";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFExpertKnowledgeSelf6 = "CFExpertKnowledgeSelf6";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFReadyToChangesSelf1 = "CFReadyToChangesSelf1";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFReadyToChangesSelf2 = "CFReadyToChangesSelf2";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFReadyToChangesSelf3 = "CFReadyToChangesSelf3";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFReadyToChangesSelf4 = "CFReadyToChangesSelf4";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFReadyToChangesSelf5 = "CFReadyToChangesSelf5";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFReadyToChangesSelf6 = "CFReadyToChangesSelf6";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFReadyToChangesSelf7 = "CFReadyToChangesSelf7";


	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFDeadlinesRM = "CFDeadlinesRM";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFResultRM = "CFResultRM";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFComfortableRM = "CFComfortableRM";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFStrategyRealization = "CFStrategyRealization";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFEmployeeMotivation = "CFEmployeeMotivation";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFTeamPlayer = "CFTeamPlayer";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFLoyalityToCompany = "CFLoyalityToCompany";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFPresentationAndCommunicationSkills = "CFPresentationAndCommunicationSkills";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFExpertize = "CFExpertize";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFReadyForChanges = "CFReadyForChanges";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFImplementationStrategyOfCompanyComment = "CFImplementationStrategyOfCompanyComment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFMotivationAndEducationOfEmployeeComment = "CFMotivationAndEducationOfEmployeeComment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFTeamPlayerComment = "CFTeamPlayerComment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFLoyalityToCompanyComment = "CFLoyalityToCompanyComment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFPresentationAndCommunicationSkillsComment = "CFPresentationAndCommunicationSkillsComment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFExpertKnowledgeComment = "CFExpertKnowledgeComment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFReadyToChangesComment = "CFReadyToChangesComment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFDeadlinesRMComment = "CFDeadlinesRMComment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFResultRMComment = "CFResultRMComment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFComfortableRMComment = "CFComfortableRMComment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFStrategyRealizationComment = "CFStrategyRealizationComment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFEmployeeMotivationComment = "CFEmployeeMotivationComment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFExpertizeComment = "CFExpertizeComment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFReadyForChangesComment = "CFReadyForChangesComment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFTeamPlayerColleguesComment = "CFTeamPlayerColleguesComment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFLoyalityToCompanyColleguesComment = "CFLoyalityToCompanyColleguesComment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFPresentationAndCommunicationSkillsColleguesComment = "CFPresentationAndCommunicationSkillsColleguesComment";


	#endregion

	#region комментарии к навыкам

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFMentoringSkillComment = "CFMentoringSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFExpertKnowledgeSkillComment = "CFExpertKnowledgeSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFLoyaltyToCompanySkillComment = "CFLoyaltyToCompanySkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFTeamPlayerSkillComment = "CFTeamPlayerSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFSelfIndependenceSkillComment = "CFSelfIndependenceSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFInitiativeSkillComment = "CFInitiativeSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFSelfEducationSkillComment = "CFSelfEducationSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFPresentationSkillComment = "CFPresentationSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFStressToleranceSkillComment = "CFStressToleranceSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFRequirementsManagementSkillComment = "CFRequirementsManagementSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFWorkingWithDocumentationSkillComment = "CFWorkingWithDocumentationSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFProductKnowledgeSkillComment = "CFProductKnowledgeSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFUnderstandingResponsibilitiesSkillComment = "CFUnderstandingResponsibilitiesSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFAccuracyOfEstimatesSkillComment = "CFAccuracyOfEstimatesSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFCommunicationSkillComment = "CFCommunicationSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFWorkWithToolsSkillComment = "CFWorkWithToolsSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFPreSalesActivitySkillComment = "CFPreSalesActivitySkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFProjectInitiationSkillComment = "CFProjectInitiationSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFProjectPlanningSkillComment = "CFProjectPlanningSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFManagingProjectSkillComment = "CFManagingProjectSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFProjectClosingSkillComment = "CFProjectClosingSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFMethodologySkillComment = "CFMethodologySkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFWorkingWithRequirementsSkillComment = "CFWorkingWithRequirementsSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFTestCaseSkillComment = "CFTestCaseSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFBugReportSkillComment = "CFBugReportSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFTestingWebSkillComment = "CFTestingWebSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFTestingMobileSkillComment = "CFTestingMobileSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFTestingApiSkillComment = "CFTestingApiSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFTestAutomationSkillComment = "CFTestAutomationSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFTestingDesktopSkillComment = "CFTestingDesktopSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFCodeReviewSkillComment = "CFCodeReviewSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFCodeQualitySkillComment = "CFCodeQualitySkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFRefactoringSkillComment = "CFRefactoringSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFDesignExperienceSkillComment = "CFDesignExperienceSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFCiCdSkillComment = "CFCiCdSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFSUPLoyaltyToCompanySkillComment = "CFSUPLoyaltyToCompanySkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFSUPTeamPlayerSkillComment = "CFSUPTeamPlayerSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFSUPSelfIndependenceSkillComment = "CFSUPSelfIndependenceSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFSUPSelfEducationSkillComment = "CFSUPSelfEducationSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFSUPClientOrientedSkillComment = "CFSUPClientOrientedSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFSUPWorkWithClientSkillComment = "CFSUPWorkWithClientSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFSUPWorkWithAccompanyingSoftwareSkillComment = "CFSUPWorkWithAccompanyingSoftwareSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFSUPFundamentalsOfSoftwareDevelopmentSkillComment = "CFSUPFundamentalsOfSoftwareDevelopmentSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFSUPSubjectAreaSkillComment = "CFSUPSubjectAreaSkillComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFProgrammingLanguageForTestingComment = "CFProgrammingLanguageForTestingComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFReportsLogingToolsComment = "CFReportsLogingToolsComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFFrameworkArchitectureComment = "CFFrameworkArchitectureComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFWorkWithTestDocumentationComment = "CFWorkWithTestDocumentationComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFToolsForTestingComment = "CFToolsForTestingComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.SkillComment })]
	public const string CFCICDComment = "CFCICDComment";


	#endregion

	#endregion

	#region АНКЕТА ДЛЯ АДАПТАЦИИ

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFAdaptationImpression = "CFAdaptationImpression";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFJobImpression = "CFJobImpression";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFProjectUnderstanding = "CFProjectUnderstanding";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFAdaptationMentoring = "CFAdaptationMentoring";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFAdaptationMentoringTeaching = "CFAdaptationMentoringTeaching";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFAdaptationMentorFeedback = "CFAdaptationMentorFeedback";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFAdaptationResourceManager = "CFAdaptationResourceManager";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFTeamCommunication = "CFTeamCommunication";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFAdaptationPartOfTeam = "CFAdaptationPartOfTeam";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFTeamInformalCommunication = "CFTeamInformalCommunication";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFCorporateCulture = "CFCorporateCulture";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFCompanyProcesses = "CFCompanyProcesses";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFWorkLoad = "CFWorkLoad";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation, CustomFieldAffiliationType.Mentoring })]
	public const string CFWorkPlace = "CFWorkPlace";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFWorkPlaceWishes = "CFWorkPlaceWishes";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFAdaptationGrade = "CFAdaptationGrade";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFAdaptationResult = "CFAdaptationResult";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFContinueCareer = "CFContinueCareer";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFFutureCareerGrowth = "CFFutureCareerGrowth";

	#endregion


	#region АНКЕТА АДАПТАЦИЯ РМ

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFRoleInDepartment = "CFRoleInDepartment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFRoleInDepartmentComment = "CFRoleInDepartmentComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFAdaptationRmQ2 = "CFAdaptationRmQ2";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFAdaptationRmQ3 = "CFAdaptationRmQ3";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFAdaptationRmQ4 = "CFAdaptationRmQ4";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFAdaptationRmQ5 = "CFAdaptationRmQ5";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFAdaptationRmQ6 = "CFAdaptationRmQ6";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFAdaptationRmQ7 = "CFAdaptationRmQ7";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFAdaptationRmQ8 = "CFAdaptationRmQ8";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFAdaptationRmQ9 = "CFAdaptationRmQ9";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFAdaptationRmQ10 = "CFAdaptationRmQ10";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFAdaptationRmQ11 = "CFAdaptationRmQ11";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Adaptation })]
	public const string CFAdaptationRmQ12 = "CFAdaptationRmQ12";

	#endregion

	#region АНКЕТА ДЛЯ МЕНТОРСТВА

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSatisfactionLevelMentoring = "CFSatisfactionLevelMentoring";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSatisfactionLevelResultOfMentoring = "CFSatisfactionLevelResultOfMentoring";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSatisfactionLevelCompletingTasks = "CFSatisfactionLevelCompletingTasks";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSatisfactionLevelAdequacyOfQuestions = "CFSatisfactionLevelAdequacyOfQuestions";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSatisfactionLevelMentee = "CFSatisfactionLevelMentee";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSatisfactionLevelMentor = "CFSatisfactionLevelMentor";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSatisfactionLevelMatchingTasks = "CFSatisfactionLevelMatchingTasks";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSatisfactionLevelResult = "CFSatisfactionLevelResult";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFEevaluationCriteria = "CFEevaluationCriteria";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFHelpingMentor = "CFHelpingMentor";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFMentorHaveTimeToDo = "CFMentorHaveTimeToDo";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFParticipationInProcess = "CFParticipationInProcess";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFCommunicationWithMentee = "CFCommunicationWithMentee";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFFeedbackFromMentor = "CFFeedbackFromMentor";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFSatisfactionLevelMenteeComment = "CFSatisfactionLevelMenteeComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFGoodQualitiesOfMentee = "CFGoodQualitiesOfMentee";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFIntroductionToTrainingPlan = "CFIntroductionToTrainingPlan";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFAdditionalMaterials = "CFAdditionalMaterials";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFMentoringCosts = "CFMentoringCosts";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFRateOfMasteringMaterial = "CFRateOfMasteringMaterial";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFClarityOfMentorResponse = "CFClarityOfMentorResponse";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFProblemsEncounteredMentee = "CFProblemsEncounteredMentee";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFToImproveMentee = "CFToImproveMentee";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFQuestionsRaised = "CFQuestionsRaised";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFImprove = "CFImprove";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFReducingNumberOfQuestions = "CFReducingNumberOfQuestions";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFAdditionalMentor = "CFAdditionalMentor";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFIsInterestingToTeach = "CFIsInterestingToTeach";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFDifficultiesAtWork = "CFDifficultiesAtWork";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFRemove = "CFRemove";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFAdd = "CFAdd";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFSatisfactionLevelMentorComment = "CFSatisfactionLevelMentorComment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFGoodQualitiesOfMentor = "CFGoodQualitiesOfMentor";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFToImproveMentor = "CFToImproveMentor";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFSettingTasks = "CFSettingTasks";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFSelfEmploymentMentee = "CFSelfEmploymentMentee";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFMeetingWithMentor = "CFMeetingWithMentor";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFWhatWorks = "CFWhatWorks";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFTrackingHours = "CFTrackingHours";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFIsTrainingInteresting = "CFIsTrainingInteresting";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFWhatWantToLearn = "CFWhatWantToLearn";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFFeedbackFromMentee = "CFFeedbackFromMentee";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Mentoring })]
	public const string CFProcessDeviations = "CFProcessDeviations";

	#endregion

	#region BA - NEW
	//BA SOFT TEAM
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_1 = "CFBASOFTTEAM_1";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_2 = "CFBASOFTTEAM_2";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_3 = "CFBASOFTTEAM_3";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_4 = "CFBASOFTTEAM_4";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_5 = "CFBASOFTTEAM_5";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFBASOFTTEAM_Comment6 = "CFBASOFTTEAM_Comment6";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_7 = "CFBASOFTTEAM_7";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_8 = "CFBASOFTTEAM_8";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_9 = "CFBASOFTTEAM_9";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_10 = "CFBASOFTTEAM_10";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_11 = "CFBASOFTTEAM_11";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_12 = "CFBASOFTTEAM_12";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_13 = "CFBASOFTTEAM_13";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_14 = "CFBASOFTTEAM_14";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_15 = "CFBASOFTTEAM_15";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_16 = "CFBASOFTTEAM_16";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFBASOFTTEAM_Comment17 = "CFBASOFTTEAM_Comment17";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_18 = "CFBASOFTTEAM_18";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_19 = "CFBASOFTTEAM_19";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_20 = "CFBASOFTTEAM_20";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFBASOFTTEAM_Comment21 = "CFBASOFTTEAM_Comment21";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_22 = "CFBASOFTTEAM_22";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_23 = "CFBASOFTTEAM_23";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_24 = "CFBASOFTTEAM_24";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_25 = "CFBASOFTTEAM_25";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_26 = "CFBASOFTTEAM_26";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_27 = "CFBASOFTTEAM_27";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_28 = "CFBASOFTTEAM_28";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_29 = "CFBASOFTTEAM_29";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFBASOFTTEAM_Comment30 = "CFBASOFTTEAM_Comment30";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_31 = "CFBASOFTTEAM_31";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_32 = "CFBASOFTTEAM_32";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_33 = "CFBASOFTTEAM_33";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_34 = "CFBASOFTTEAM_34";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_35 = "CFBASOFTTEAM_35";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_36 = "CFBASOFTTEAM_36";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFBASOFTTEAM_Comment37 = "CFBASOFTTEAM_Comment37";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_38 = "CFBASOFTTEAM_38";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_39 = "CFBASOFTTEAM_39";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_40 = "CFBASOFTTEAM_40";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_41 = "CFBASOFTTEAM_41";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_42 = "CFBASOFTTEAM_42";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_43 = "CFBASOFTTEAM_43";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_44 = "CFBASOFTTEAM_44";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_45 = "CFBASOFTTEAM_45";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_46 = "CFBASOFTTEAM_46";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFBASOFTTEAM_Comment47 = "CFBASOFTTEAM_Comment47";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_48 = "CFBASOFTTEAM_48";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_49 = "CFBASOFTTEAM_49";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_50 = "CFBASOFTTEAM_50";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_51 = "CFBASOFTTEAM_51";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_52 = "CFBASOFTTEAM_52";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_53 = "CFBASOFTTEAM_53";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_54 = "CFBASOFTTEAM_54";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_55 = "CFBASOFTTEAM_55";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFBASOFTTEAM_Comment56 = "CFBASOFTTEAM_Comment56";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_57 = "CFBASOFTTEAM_57";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_58 = "CFBASOFTTEAM_58";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_59 = "CFBASOFTTEAM_59";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_60 = "CFBASOFTTEAM_60";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_61 = "CFBASOFTTEAM_61";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_62 = "CFBASOFTTEAM_62";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_63 = "CFBASOFTTEAM_63";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_64 = "CFBASOFTTEAM_64";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTTEAM_65 = "CFBASOFTTEAM_65";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFBASOFTTEAM_Comment66 = "CFBASOFTTEAM_Comment66";

	//BA SOFT SELF
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_1 = "CFBASOFTSELF_1";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_2 = "CFBASOFTSELF_2";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_3 = "CFBASOFTSELF_3";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_4 = "CFBASOFTSELF_4";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_5 = "CFBASOFTSELF_5";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFBASOFTSELF_Comment6 = "CFBASOFTSELF_Comment6";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_7 = "CFBASOFTSELF_7";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_8 = "CFBASOFTSELF_8";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_9 = "CFBASOFTSELF_9";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_10 = "CFBASOFTSELF_10";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_11 = "CFBASOFTSELF_11";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_12 = "CFBASOFTSELF_12";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_13 = "CFBASOFTSELF_13";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_14 = "CFBASOFTSELF_14";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_15 = "CFBASOFTSELF_15";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_16 = "CFBASOFTSELF_16";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFBASOFTSELF_Comment17 = "CFBASOFTSELF_Comment17";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_18 = "CFBASOFTSELF_18";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_19 = "CFBASOFTSELF_19";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_20 = "CFBASOFTSELF_20";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFBASOFTSELF_Comment21 = "CFBASOFTSELF_Comment21";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_22 = "CFBASOFTSELF_22";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_23 = "CFBASOFTSELF_23";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_24 = "CFBASOFTSELF_24";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_25 = "CFBASOFTSELF_25";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_26 = "CFBASOFTSELF_26";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_27 = "CFBASOFTSELF_27";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_28 = "CFBASOFTSELF_28";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_29 = "CFBASOFTSELF_29";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFBASOFTSELF_Comment30 = "CFBASOFTSELF_Comment30";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_31 = "CFBASOFTSELF_31";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_32 = "CFBASOFTSELF_32";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_33 = "CFBASOFTSELF_33";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_34 = "CFBASOFTSELF_34";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_35 = "CFBASOFTSELF_35";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_36 = "CFBASOFTSELF_36";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFBASOFTSELF_Comment37 = "CFBASOFTSELF_Comment37";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_38 = "CFBASOFTSELF_38";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_39 = "CFBASOFTSELF_39";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_40 = "CFBASOFTSELF_40";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_41 = "CFBASOFTSELF_41";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_42 = "CFBASOFTSELF_42";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_43 = "CFBASOFTSELF_43";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_44 = "CFBASOFTSELF_44";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_45 = "CFBASOFTSELF_45";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_46 = "CFBASOFTSELF_46";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFBASOFTSELF_Comment47 = "CFBASOFTSELF_Comment47";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_48 = "CFBASOFTSELF_48";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_49 = "CFBASOFTSELF_49";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_50 = "CFBASOFTSELF_50";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_51 = "CFBASOFTSELF_51";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_52 = "CFBASOFTSELF_52";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_53 = "CFBASOFTSELF_53";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_54 = "CFBASOFTSELF_54";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFBASOFTSELF_55 = "CFBASOFTSELF_55";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFBASOFTSELF_Comment56 = "CFBASOFTSELF_Comment56";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFBASOFTSELF_CommentLoyalty57 = "CFBASOFTSELF_CommentLoyalty57";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFBASOFTSELF_CommentLoyalty58 = "CFBASOFTSELF_CommentLoyalty58";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFBASOFTSELF_CommentLoyalty59 = "CFBASOFTSELF_CommentLoyalty59";


	#endregion

	#region SE - NEW
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_1 = "CFSESOFTTEAM_1";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_2 = "CFSESOFTTEAM_2";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_3 = "CFSESOFTTEAM_3";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_4 = "CFSESOFTTEAM_4";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_5 = "CFSESOFTTEAM_5";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSESOFTTEAM_Comment6 = "CFSESOFTTEAM_Comment6";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_7 = "CFSESOFTTEAM_7";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_8 = "CFSESOFTTEAM_8";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_9 = "CFSESOFTTEAM_9";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_10 = "CFSESOFTTEAM_10";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_11 = "CFSESOFTTEAM_11";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_12 = "CFSESOFTTEAM_12";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_13 = "CFSESOFTTEAM_13";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_14 = "CFSESOFTTEAM_14";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_15 = "CFSESOFTTEAM_15";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_16 = "CFSESOFTTEAM_16";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSESOFTTEAM_Comment17 = "CFSESOFTTEAM_Comment17";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_18 = "CFSESOFTTEAM_18";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_19 = "CFSESOFTTEAM_19";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_20 = "CFSESOFTTEAM_20";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSESOFTTEAM_Comment21 = "CFSESOFTTEAM_Comment21";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_22 = "CFSESOFTTEAM_22";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_23 = "CFSESOFTTEAM_23";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_24 = "CFSESOFTTEAM_24";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_25 = "CFSESOFTTEAM_25";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_26 = "CFSESOFTTEAM_26";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_27 = "CFSESOFTTEAM_27";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_28 = "CFSESOFTTEAM_28";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_29 = "CFSESOFTTEAM_29";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSESOFTTEAM_Comment30 = "CFSESOFTTEAM_Comment30";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_31 = "CFSESOFTTEAM_31";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_32 = "CFSESOFTTEAM_32";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_33 = "CFSESOFTTEAM_33";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_34 = "CFSESOFTTEAM_34";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_35 = "CFSESOFTTEAM_35";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_36 = "CFSESOFTTEAM_36";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSESOFTTEAM_Comment37 = "CFSESOFTTEAM_Comment37";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_38 = "CFSESOFTTEAM_38";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_39 = "CFSESOFTTEAM_39";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_40 = "CFSESOFTTEAM_40";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_41 = "CFSESOFTTEAM_41";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_42 = "CFSESOFTTEAM_42";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_43 = "CFSESOFTTEAM_43";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_44 = "CFSESOFTTEAM_44";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_45 = "CFSESOFTTEAM_45";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_46 = "CFSESOFTTEAM_46";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSESOFTTEAM_Comment47 = "CFSESOFTTEAM_Comment47";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_48 = "CFSESOFTTEAM_48";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_49 = "CFSESOFTTEAM_49";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_50 = "CFSESOFTTEAM_50";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_51 = "CFSESOFTTEAM_51";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_52 = "CFSESOFTTEAM_52";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_53 = "CFSESOFTTEAM_53";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_54 = "CFSESOFTTEAM_54";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_55 = "CFSESOFTTEAM_55";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSESOFTTEAM_Comment56 = "CFSESOFTTEAM_Comment56";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_57 = "CFSESOFTTEAM_57";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_58 = "CFSESOFTTEAM_58";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_59 = "CFSESOFTTEAM_59";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_60 = "CFSESOFTTEAM_60";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_61 = "CFSESOFTTEAM_61";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_62 = "CFSESOFTTEAM_62";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_63 = "CFSESOFTTEAM_63";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_64 = "CFSESOFTTEAM_64";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTTEAM_65 = "CFSESOFTTEAM_65";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSESOFTTEAM_Comment66 = "CFSESOFTTEAM_Comment66";

	//SE SOFT SELF
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_1 = "CFSESOFTSELF_1";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_2 = "CFSESOFTSELF_2";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_3 = "CFSESOFTSELF_3";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_4 = "CFSESOFTSELF_4";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_5 = "CFSESOFTSELF_5";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSESOFTSELF_Comment6 = "CFSESOFTSELF_Comment6";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_7 = "CFSESOFTSELF_7";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_8 = "CFSESOFTSELF_8";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_9 = "CFSESOFTSELF_9";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_10 = "CFSESOFTSELF_10";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_11 = "CFSESOFTSELF_11";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_12 = "CFSESOFTSELF_12";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_13 = "CFSESOFTSELF_13";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_14 = "CFSESOFTSELF_14";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_15 = "CFSESOFTSELF_15";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_16 = "CFSESOFTSELF_16";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSESOFTSELF_Comment17 = "CFSESOFTSELF_Comment17";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_18 = "CFSESOFTSELF_18";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_19 = "CFSESOFTSELF_19";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_20 = "CFSESOFTSELF_20";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSESOFTSELF_Comment21 = "CFSESOFTSELF_Comment21";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_22 = "CFSESOFTSELF_22";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_23 = "CFSESOFTSELF_23";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_24 = "CFSESOFTSELF_24";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_25 = "CFSESOFTSELF_25";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_26 = "CFSESOFTSELF_26";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_27 = "CFSESOFTSELF_27";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_28 = "CFSESOFTSELF_28";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_29 = "CFSESOFTSELF_29";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSESOFTSELF_Comment30 = "CFSESOFTSELF_Comment30";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_31 = "CFSESOFTSELF_31";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_32 = "CFSESOFTSELF_32";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_33 = "CFSESOFTSELF_33";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_34 = "CFSESOFTSELF_34";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_35 = "CFSESOFTSELF_35";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_36 = "CFSESOFTSELF_36";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSESOFTSELF_Comment37 = "CFSESOFTSELF_Comment37";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_38 = "CFSESOFTSELF_38";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_39 = "CFSESOFTSELF_39";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_40 = "CFSESOFTSELF_40";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_41 = "CFSESOFTSELF_41";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_42 = "CFSESOFTSELF_42";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_43 = "CFSESOFTSELF_43";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_44 = "CFSESOFTSELF_44";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_45 = "CFSESOFTSELF_45";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_46 = "CFSESOFTSELF_46";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSESOFTSELF_Comment47 = "CFSESOFTSELF_Comment47";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_48 = "CFSESOFTSELF_48";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_49 = "CFSESOFTSELF_49";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_50 = "CFSESOFTSELF_50";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_51 = "CFSESOFTSELF_51";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_52 = "CFSESOFTSELF_52";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_53 = "CFSESOFTSELF_53";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_54 = "CFSESOFTSELF_54";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFSESOFTSELF_55 = "CFSESOFTSELF_55";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSESOFTSELF_Comment56 = "CFSESOFTSELF_Comment56";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSESOFTSELF_CommentLoyalty57 = "CFSESOFTSELF_CommentLoyalty57";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSESOFTSELF_CommentLoyalty58 = "CFSESOFTSELF_CommentLoyalty58";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFSESOFTSELF_CommentLoyalty59 = "CFSESOFTSELF_CommentLoyalty59";

	#endregion

	#region QA - NEW
	//SOFT Team
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_1 = "CFQASOFTTEAM_1";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_2 = "CFQASOFTTEAM_2";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_3 = "CFQASOFTTEAM_3";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_4 = "CFQASOFTTEAM_4";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_5 = "CFQASOFTTEAM_5";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQASOFTTEAM_Comment6 = "CFQASOFTTEAM_Comment6";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_7 = "CFQASOFTTEAM_7";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_8 = "CFQASOFTTEAM_8";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_9 = "CFQASOFTTEAM_9";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_10 = "CFQASOFTTEAM_10";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_11 = "CFQASOFTTEAM_11";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_12 = "CFQASOFTTEAM_12";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_13 = "CFQASOFTTEAM_13";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQASOFTTEAM_Comment14 = "CFQASOFTTEAM_Comment14";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_15 = "CFQASOFTTEAM_15";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_16 = "CFQASOFTTEAM_16";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_17 = "CFQASOFTTEAM_17";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQASOFTTEAM_Comment18 = "CFQASOFTTEAM_Comment18";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_19 = "CFQASOFTTEAM_19";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_20 = "CFQASOFTTEAM_20";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_21 = "CFQASOFTTEAM_21";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_22 = "CFQASOFTTEAM_22";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_23 = "CFQASOFTTEAM_23";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_24 = "CFQASOFTTEAM_24";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_25 = "CFQASOFTTEAM_25";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_26 = "CFQASOFTTEAM_26";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQASOFTTEAM_Comment27 = "CFQASOFTTEAM_Comment27";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_28 = "CFQASOFTTEAM_28";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_29 = "CFQASOFTTEAM_29";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_30 = "CFQASOFTTEAM_30";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_31 = "CFQASOFTTEAM_31";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_32 = "CFQASOFTTEAM_32";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_33 = "CFQASOFTTEAM_33";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQASOFTTEAM_Comment34 = "CFQASOFTTEAM_Comment34";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_35 = "CFQASOFTTEAM_35";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_36 = "CFQASOFTTEAM_36";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_37 = "CFQASOFTTEAM_37";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_38 = "CFQASOFTTEAM_38";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_39 = "CFQASOFTTEAM_39";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_40 = "CFQASOFTTEAM_40";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_41 = "CFQASOFTTEAM_41";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_42 = "CFQASOFTTEAM_42";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_43 = "CFQASOFTTEAM_43";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQASOFTTEAM_Comment44 = "CFQASOFTTEAM_Comment44";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_45 = "CFQASOFTTEAM_45";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_46 = "CFQASOFTTEAM_46";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_47 = "CFQASOFTTEAM_47";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_48 = "CFQASOFTTEAM_48";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_49 = "CFQASOFTTEAM_49";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_50 = "CFQASOFTTEAM_50";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_51 = "CFQASOFTTEAM_51";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQASOFTTEAM_Comment52 = "CFQASOFTTEAM_Comment52";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_53 = "CFQASOFTTEAM_53";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_54 = "CFQASOFTTEAM_54";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_55 = "CFQASOFTTEAM_55";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_56 = "CFQASOFTTEAM_56";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_57 = "CFQASOFTTEAM_57";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_58 = "CFQASOFTTEAM_58";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_59 = "CFQASOFTTEAM_59";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_60 = "CFQASOFTTEAM_60";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTTEAM_61 = "CFQASOFTTEAM_61";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQASOFTTEAM_Comment62 = "CFQASOFTTEAM_Comment62";


	//HARD TEAM
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDTEAM_1INFOBOOL = "CFQAHARDTEAM_1INFOBOOL";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDTEAM_1INFOBOOLComment = "CFQAHARDTEAM_1INFOBOOLComment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_2 = "CFQAHARDTEAM_2";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_3 = "CFQAHARDTEAM_3";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_4 = "CFQAHARDTEAM_4";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_5 = "CFQAHARDTEAM_5";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_6 = "CFQAHARDTEAM_6";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_7 = "CFQAHARDTEAM_7";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDTEAM_7Comment = "CFQAHARDTEAM_7Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_8 = "CFQAHARDTEAM_8";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_9 = "CFQAHARDTEAM_9";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDTEAM_9Comment = "CFQAHARDTEAM_9Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_10 = "CFQAHARDTEAM_10";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDTEAM_10Comment = "CFQAHARDTEAM_10Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_11 = "CFQAHARDTEAM_11";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDTEAM_11Comment = "CFQAHARDTEAM_11Comment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDTEAM_12INFOBOOL = "CFQAHARDTEAM_12INFOBOOL";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDTEAM_12INFOBOOLComment = "CFQAHARDTEAM_12INFOBOOLComment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_13 = "CFQAHARDTEAM_13";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_14 = "CFQAHARDTEAM_14";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDTEAM_14Comment = "CFQAHARDTEAM_14Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_15 = "CFQAHARDTEAM_15";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_16 = "CFQAHARDTEAM_16";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_17 = "CFQAHARDTEAM_17";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDTEAM_17Comment = "CFQAHARDTEAM_17Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_18 = "CFQAHARDTEAM_18";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDTEAM_18Comment = "CFQAHARDTEAM_18Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_19 = "CFQAHARDTEAM_19";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDTEAM_19Comment = "CFQAHARDTEAM_19Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_20 = "CFQAHARDTEAM_20";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_21 = "CFQAHARDTEAM_21";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDTEAM_21Comment = "CFQAHARDTEAM_21Comment";


	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDTEAM_22INFOBOOL = "CFQAHARDTEAM_22INFOBOOL";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDTEAM_22INFOBOOLComment = "CFQAHARDTEAM_22INFOBOOLComment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_23 = "CFQAHARDTEAM_23";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_24 = "CFQAHARDTEAM_24";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_25 = "CFQAHARDTEAM_25";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_26 = "CFQAHARDTEAM_26";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_27 = "CFQAHARDTEAM_27";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_28 = "CFQAHARDTEAM_28";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_29 = "CFQAHARDTEAM_29";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDTEAM_29Comment = "CFQAHARDTEAM_29Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_30 = "CFQAHARDTEAM_30";


	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDTEAM_31INFOBOOL = "CFQAHARDTEAM_31INFOBOOL";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDTEAM_31INFOBOOLComment = "CFQAHARDTEAM_31INFOBOOLComment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_32 = "CFQAHARDTEAM_32";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_33 = "CFQAHARDTEAM_33";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_34 = "CFQAHARDTEAM_34";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_35 = "CFQAHARDTEAM_35";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_36 = "CFQAHARDTEAM_36";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_37 = "CFQAHARDTEAM_37";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_38 = "CFQAHARDTEAM_38";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_39 = "CFQAHARDTEAM_39";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDTEAM_39Comment = "CFQAHARDTEAM_39Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_40 = "CFQAHARDTEAM_40";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDTEAM_40Comment = "CFQAHARDTEAM_40Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_41 = "CFQAHARDTEAM_41";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDTEAM_41Comment = "CFQAHARDTEAM_41Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_42 = "CFQAHARDTEAM_42";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_43 = "CFQAHARDTEAM_43";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDTEAM_43Comment = "CFQAHARDTEAM_43Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_44 = "CFQAHARDTEAM_44";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_45 = "CFQAHARDTEAM_45";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_46 = "CFQAHARDTEAM_46";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDTEAM_46Comment = "CFQAHARDTEAM_46Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_47 = "CFQAHARDTEAM_47";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_48 = "CFQAHARDTEAM_48";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_49 = "CFQAHARDTEAM_49";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_50 = "CFQAHARDTEAM_50";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDTEAM_50Comment = "CFQAHARDTEAM_50Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDTEAM_51 = "CFQAHARDTEAM_51";


	//SELF Soft
	#region QaSoft - Self
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_1 = "CFQASOFTSELF_1";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_2 = "CFQASOFTSELF_2";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_3 = "CFQASOFTSELF_3";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_4 = "CFQASOFTSELF_4";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_5 = "CFQASOFTSELF_5";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQASOFTSELF_Comment6 = "CFQASOFTSELF_Comment6";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_7 = "CFQASOFTSELF_7";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_8 = "CFQASOFTSELF_8";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_9 = "CFQASOFTSELF_9";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_10 = "CFQASOFTSELF_10";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_11 = "CFQASOFTSELF_11";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_12 = "CFQASOFTSELF_12";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_13 = "CFQASOFTSELF_13";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQASOFTSELF_Comment14 = "CFQASOFTSELF_Comment14";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_15 = "CFQASOFTSELF_15";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_16 = "CFQASOFTSELF_16";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_17 = "CFQASOFTSELF_17";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQASOFTSELF_Comment18 = "CFQASOFTSELF_Comment18";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_19 = "CFQASOFTSELF_19";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_20 = "CFQASOFTSELF_20";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_21 = "CFQASOFTSELF_21";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_22 = "CFQASOFTSELF_22";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_23 = "CFQASOFTSELF_23";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_24 = "CFQASOFTSELF_24";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_25 = "CFQASOFTSELF_25";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_26 = "CFQASOFTSELF_26";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQASOFTSELF_Comment27 = "CFQASOFTSELF_Comment27";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_28 = "CFQASOFTSELF_28";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_29 = "CFQASOFTSELF_29";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_30 = "CFQASOFTSELF_30";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_31 = "CFQASOFTSELF_31";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_32 = "CFQASOFTSELF_32";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_33 = "CFQASOFTSELF_33";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQASOFTSELF_Comment34 = "CFQASOFTSELF_Comment34";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_35 = "CFQASOFTSELF_35";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_36 = "CFQASOFTSELF_36";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_37 = "CFQASOFTSELF_37";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_38 = "CFQASOFTSELF_38";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_39 = "CFQASOFTSELF_39";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_40 = "CFQASOFTSELF_40";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_41 = "CFQASOFTSELF_41";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_42 = "CFQASOFTSELF_42";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_43 = "CFQASOFTSELF_43";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQASOFTSELF_Comment44 = "CFQASOFTSELF_Comment44";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_45 = "CFQASOFTSELF_45";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_46 = "CFQASOFTSELF_46";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_47 = "CFQASOFTSELF_47";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_48 = "CFQASOFTSELF_48";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_49 = "CFQASOFTSELF_49";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_50 = "CFQASOFTSELF_50";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQASOFTSELF_51 = "CFQASOFTSELF_51";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQASOFTSELF_Comment52 = "CFQASOFTSELF_Comment52";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQASOFTSELF_CommentLoyalty53 = "CFQASOFTSELF_CommentLoyalty53";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQASOFTSELF_CommentLoyalty54 = "CFQASOFTSELF_CommentLoyalty54";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQASOFTSELF_CommentLoyalty55 = "CFQASOFTSELF_CommentLoyalty55";
	#endregion

	//SELF hard
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_1INFOBOOL = "CFQAHARDSELF_1INFOBOOL";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_1INFOBOOLComment = "CFQAHARDSELF_1INFOBOOLComment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_2 = "CFQAHARDSELF_2";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_3 = "CFQAHARDSELF_3";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_4 = "CFQAHARDSELF_4";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_5 = "CFQAHARDSELF_5";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_6 = "CFQAHARDSELF_6";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_6Comment = "CFQAHARDSELF_6Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_7 = "CFQAHARDSELF_7";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_7Comment = "CFQAHARDSELF_7Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_8 = "CFQAHARDSELF_8";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_9 = "CFQAHARDSELF_9";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_9Comment = "CFQAHARDSELF_9Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_10 = "CFQAHARDSELF_10";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_10Comment = "CFQAHARDSELF_10Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_11 = "CFQAHARDSELF_11";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_11Comment = "CFQAHARDSELF_11Comment";

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_12INFOBOOL = "CFQAHARDSELF_12INFOBOOL";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_12INFOBOOLComment = "CFQAHARDSELF_12INFOBOOLComment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_13 = "CFQAHARDSELF_13";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_14 = "CFQAHARDSELF_14";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_14Comment = "CFQAHARDSELF_14Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_15 = "CFQAHARDSELF_15";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_16 = "CFQAHARDSELF_16";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_17 = "CFQAHARDSELF_17";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_17Comment = "CFQAHARDSELF_17Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_18 = "CFQAHARDSELF_18";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_18Comment = "CFQAHARDSELF_18Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_19 = "CFQAHARDSELF_19";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_19Comment = "CFQAHARDSELF_19Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_20 = "CFQAHARDSELF_20";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_21 = "CFQAHARDSELF_21";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_21Comment = "CFQAHARDSELF_21Comment";


	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_22INFOBOOL = "CFQAHARDSELF_22INFOBOOL";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_22INFOBOOLComment = "CFQAHARDSELF_22INFOBOOLComment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_23 = "CFQAHARDSELF_23";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_24 = "CFQAHARDSELF_24";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_25 = "CFQAHARDSELF_25";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_26 = "CFQAHARDSELF_26";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_27 = "CFQAHARDSELF_27";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_28 = "CFQAHARDSELF_28";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_29 = "CFQAHARDSELF_29";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_29Comment = "CFQAHARDSELF_29Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_30 = "CFQAHARDSELF_30";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_30Comment = "CFQAHARDSELF_30Comment";


	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_31INFOBOOL = "CFQAHARDSELF_31INFOBOOL";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_31INFOBOOLComment = "CFQAHARDSELF_31INFOBOOLComment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_32 = "CFQAHARDSELF_32";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_33 = "CFQAHARDSELF_33";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_34 = "CFQAHARDSELF_34";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_35 = "CFQAHARDSELF_35";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_36 = "CFQAHARDSELF_36";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_37 = "CFQAHARDSELF_37";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_38 = "CFQAHARDSELF_38";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_39 = "CFQAHARDSELF_39";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_39Comment = "CFQAHARDSELF_39Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_40 = "CFQAHARDSELF_40";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_40Comment = "CFQAHARDSELF_40Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_41 = "CFQAHARDSELF_41";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_41Comment = "CFQAHARDSELF_41Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_42 = "CFQAHARDSELF_42";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_43 = "CFQAHARDSELF_43";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_44 = "CFQAHARDSELF_44";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_45 = "CFQAHARDSELF_45";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_46 = "CFQAHARDSELF_46";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_46Comment = "CFQAHARDSELF_46Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_47 = "CFQAHARDSELF_47";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_48 = "CFQAHARDSELF_48";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_49 = "CFQAHARDSELF_49";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_50 = "CFQAHARDSELF_50";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAHARDSELF_50Comment = "CFQAHARDSELF_50Comment";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAHARDSELF_51 = "CFQAHARDSELF_51";
	#endregion

	#region QA AUTO - NEW
	//SOFT Team
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_1 = "CFQAAUTOSOFTTEAM_1";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_2 = "CFQAAUTOSOFTTEAM_2";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_3 = "CFQAAUTOSOFTTEAM_3";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_4 = "CFQAAUTOSOFTTEAM_4";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_5 = "CFQAAUTOSOFTTEAM_5";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAAUTOSOFTTEAM_Comment6 = "CFQAAUTOSOFTTEAM_Comment6";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_7 = "CFQAAUTOSOFTTEAM_7";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_8 = "CFQAAUTOSOFTTEAM_8";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_9 = "CFQAAUTOSOFTTEAM_9";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_10 = "CFQAAUTOSOFTTEAM_10";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_11 = "CFQAAUTOSOFTTEAM_11";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_12 = "CFQAAUTOSOFTTEAM_12";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_13 = "CFQAAUTOSOFTTEAM_13";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAAUTOSOFTTEAM_Comment14 = "CFQAAUTOSOFTTEAM_Comment14";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_15 = "CFQAAUTOSOFTTEAM_15";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_16 = "CFQAAUTOSOFTTEAM_16";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_17 = "CFQAAUTOSOFTTEAM_17";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAAUTOSOFTTEAM_Comment18 = "CFQAAUTOSOFTTEAM_Comment18";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_19 = "CFQAAUTOSOFTTEAM_19";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_20 = "CFQAAUTOSOFTTEAM_20";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_21 = "CFQAAUTOSOFTTEAM_21";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_22 = "CFQAAUTOSOFTTEAM_22";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_23 = "CFQAAUTOSOFTTEAM_23";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_24 = "CFQAAUTOSOFTTEAM_24";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_25 = "CFQAAUTOSOFTTEAM_25";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_26 = "CFQAAUTOSOFTTEAM_26";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAAUTOSOFTTEAM_Comment27 = "CFQAAUTOSOFTTEAM_Comment27";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_28 = "CFQAAUTOSOFTTEAM_28";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_29 = "CFQAAUTOSOFTTEAM_29";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_30 = "CFQAAUTOSOFTTEAM_30";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_31 = "CFQAAUTOSOFTTEAM_31";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_32 = "CFQAAUTOSOFTTEAM_32";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_33 = "CFQAAUTOSOFTTEAM_33";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAAUTOSOFTTEAM_Comment34 = "CFQAAUTOSOFTTEAM_Comment34";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_35 = "CFQAAUTOSOFTTEAM_35";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_36 = "CFQAAUTOSOFTTEAM_36";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_37 = "CFQAAUTOSOFTTEAM_37";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_38 = "CFQAAUTOSOFTTEAM_38";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_39 = "CFQAAUTOSOFTTEAM_39";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_40 = "CFQAAUTOSOFTTEAM_40";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_41 = "CFQAAUTOSOFTTEAM_41";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_42 = "CFQAAUTOSOFTTEAM_42";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_43 = "CFQAAUTOSOFTTEAM_43";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAAUTOSOFTTEAM_Comment44 = "CFQAAUTOSOFTTEAM_Comment44";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_45 = "CFQAAUTOSOFTTEAM_45";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_46 = "CFQAAUTOSOFTTEAM_46";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_47 = "CFQAAUTOSOFTTEAM_47";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_48 = "CFQAAUTOSOFTTEAM_48";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_49 = "CFQAAUTOSOFTTEAM_49";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_50 = "CFQAAUTOSOFTTEAM_50";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_51 = "CFQAAUTOSOFTTEAM_51";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAAUTOSOFTTEAM_Comment52 = "CFQAAUTOSOFTTEAM_Comment52";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_53 = "CFQAAUTOSOFTTEAM_53";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_54 = "CFQAAUTOSOFTTEAM_54";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_55 = "CFQAAUTOSOFTTEAM_55";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_56 = "CFQAAUTOSOFTTEAM_56";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_57 = "CFQAAUTOSOFTTEAM_57";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_58 = "CFQAAUTOSOFTTEAM_58";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_59 = "CFQAAUTOSOFTTEAM_59";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_60 = "CFQAAUTOSOFTTEAM_60";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTTEAM_61 = "CFQAAUTOSOFTTEAM_61";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAAUTOSOFTTEAM_Comment62 = "CFQAAUTOSOFTTEAM_Comment62";



	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_1 = "CFQAAUTOSOFTSELF_1";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_2 = "CFQAAUTOSOFTSELF_2";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_3 = "CFQAAUTOSOFTSELF_3";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_4 = "CFQAAUTOSOFTSELF_4";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_5 = "CFQAAUTOSOFTSELF_5";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAAUTOSOFTSELF_Comment6 = "CFQAAUTOSOFTSELF_Comment6";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_7 = "CFQAAUTOSOFTSELF_7";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_8 = "CFQAAUTOSOFTSELF_8";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_9 = "CFQAAUTOSOFTSELF_9";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_10 = "CFQAAUTOSOFTSELF_10";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_11 = "CFQAAUTOSOFTSELF_11";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_12 = "CFQAAUTOSOFTSELF_12";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_13 = "CFQAAUTOSOFTSELF_13";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAAUTOSOFTSELF_Comment14 = "CFQAAUTOSOFTSELF_Comment14";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_15 = "CFQAAUTOSOFTSELF_15";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_16 = "CFQAAUTOSOFTSELF_16";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_17 = "CFQAAUTOSOFTSELF_17";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAAUTOSOFTSELF_Comment18 = "CFQAAUTOSOFTSELF_Comment18";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_19 = "CFQAAUTOSOFTSELF_19";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_20 = "CFQAAUTOSOFTSELF_20";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_21 = "CFQAAUTOSOFTSELF_21";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_22 = "CFQAAUTOSOFTSELF_22";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_23 = "CFQAAUTOSOFTSELF_23";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_24 = "CFQAAUTOSOFTSELF_24";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_25 = "CFQAAUTOSOFTSELF_25";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_26 = "CFQAAUTOSOFTSELF_26";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAAUTOSOFTSELF_Comment27 = "CFQAAUTOSOFTSELF_Comment27";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_28 = "CFQAAUTOSOFTSELF_28";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_29 = "CFQAAUTOSOFTSELF_29";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_30 = "CFQAAUTOSOFTSELF_30";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_31 = "CFQAAUTOSOFTSELF_31";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_32 = "CFQAAUTOSOFTSELF_32";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_33 = "CFQAAUTOSOFTSELF_33";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAAUTOSOFTSELF_Comment34 = "CFQAAUTOSOFTSELF_Comment34";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_35 = "CFQAAUTOSOFTSELF_35";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_36 = "CFQAAUTOSOFTSELF_36";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_37 = "CFQAAUTOSOFTSELF_37";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_38 = "CFQAAUTOSOFTSELF_38";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_39 = "CFQAAUTOSOFTSELF_39";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_40 = "CFQAAUTOSOFTSELF_40";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_41 = "CFQAAUTOSOFTSELF_41";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_42 = "CFQAAUTOSOFTSELF_42";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_43 = "CFQAAUTOSOFTSELF_43";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAAUTOSOFTSELF_Comment44 = "CFQAAUTOSOFTSELF_Comment44";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_45 = "CFQAAUTOSOFTSELF_45";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_46 = "CFQAAUTOSOFTSELF_46";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_47 = "CFQAAUTOSOFTSELF_47";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_48 = "CFQAAUTOSOFTSELF_48";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_49 = "CFQAAUTOSOFTSELF_49";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_50 = "CFQAAUTOSOFTSELF_50";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFQAAUTOSOFTSELF_51 = "CFQAAUTOSOFTSELF_51";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAAUTOSOFTSELF_Comment52 = "CFQAAUTOSOFTSELF_Comment52";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAAUTOSOFTSELF_CommentLoyalty53 = "CFQAAUTOSOFTSELF_CommentLoyalty53";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAAUTOSOFTSELF_CommentLoyalty54 = "CFQAAUTOSOFTSELF_CommentLoyalty54";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.Questionnaire })]
	public const string CFQAAUTOSOFTSELF_CommentLoyalty55 = "CFQAAUTOSOFTSELF_CommentLoyalty55";
	#endregion

	#region CDD - Feedback

	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.CddFeedback, CustomFieldAffiliationType.DictionaryValue })]
	public const string CFCddFeedbackCddType = "CFCddFeedbackCddType";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.CddFeedback })]
	public const string CFCddFeedbackUsefulnessOfAchievements = "CFCddFeedbackUsefulnessOfAchievements";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.CddFeedback })]
	public const string CFCddFeedbackUsefulnessOfMeeting = "CFCddFeedbackUsefulnessOfMeeting";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.CddFeedback })]
	public const string CFCddFeedbackProcessOfEvaluation = "CFCddFeedbackProcessOfEvaluation";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.CddFeedback })]
	public const string CFCddFeedbackWhatCanBeImproved = "CFCddFeedbackWhatCanBeImproved";
	[CustomFieldAffiliation(new[] { CustomFieldAffiliationType.CddFeedback })]
	public const string CFCddFeedbackCompetenceMatrix = "CFCddFeedbackCompetenceMatrix";

	#endregion

	#endregion
	/// <summary>
	/// Get list of concrete FieldKeyConst by attribute
	/// </summary>
	/// <param name="affiliationType"></param>
	/// <returns></returns>
	public static List<string> GetFieldKeyConstList(CustomFieldAffiliationType affiliationType)
	{
		var listFieldKeyConst = new List<string>();
		var fields = typeof(FieldKeyConst).GetFields();

		foreach (var field in fields)
		{
			var attr = field.GetCustomAttribute<CustomFieldAffiliationAttribute>();
			if (attr != null && attr.CustomFieldAffiliationTypes.Contains(affiliationType))
			{
				listFieldKeyConst.Add(field.Name);
			}
		}

		return listFieldKeyConst;
	}
}
