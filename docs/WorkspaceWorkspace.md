# TogglAPI.NetStandard.Model.WorkspaceWorkspace
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Admin** | **bool?** | Current user is workspace admin | [optional] 
**ApiToken** | **string** | deprecated | [optional] 
**At** | **string** | Timestamp of last workspace change | [optional] 
**BusinessWs** | **bool?** | Workspace on Premium subscription | [optional] 
**CsvUpload** | [**ModelsCsvUpload**](ModelsCsvUpload.md) | CSV upload data | [optional] 
**DefaultCurrency** | **string** | Default currency, premium feature, optional, only for existing WS, will be &#39;USD&#39; initially | [optional] 
**DefaultHourlyRate** | **decimal?** | The default hourly rate, premium feature, optional, only for existing WS, will be 0.0 initially | [optional] 
**HideStartEndTimes** | **bool?** |  | [optional] 
**IcalEnabled** | **bool?** | Calendar integration enabled | [optional] 
**IcalUrl** | **string** | URL of calendar | [optional] 
**Id** | **int?** | Identifier of the workspace | [optional] 
**LastModified** | **string** | Last modification of data in the workspace | [optional] 
**LogoUrl** | **string** | URL of workspace logo | [optional] 
**MaxDataRetentionDays** | **int?** | How far back free workspaces can access data. | [optional] 
**Name** | **string** | Name of the workspace | [optional] 
**OnlyAdminsMayCreateProjects** | **bool?** | Only admins will be able to create projects, optional, only for existing WS, will be false initially | [optional] 
**OnlyAdminsMayCreateTags** | **bool?** | Only admins will be able to create tags, optional, only for existing WS, will be false initially | [optional] 
**OnlyAdminsSeeBillableRates** | **bool?** | Whether only admins will be able to see billable rates, premium feature, optional, only for existing WS. Will be false initially | [optional] 
**OnlyAdminsSeeTeamDashboard** | **bool?** | Only admins will be able to see the team dashboard, optional, only for existing WS, will be false initially | [optional] 
**OrganizationId** | **int?** | Identifier of the organization | [optional] 
**Permissions** | **string** | Permissions list | [optional] 
**Premium** | **bool?** | Workspace on Starter subscription | [optional] 
**Profile** | **int?** | deprecated | [optional] 
**ProjectsBillableByDefault** | **bool?** | New projects billable by default | [optional] 
**ProjectsPrivateByDefault** | **bool?** | Workspace setting for default project visbility. | [optional] 
**RateLastUpdated** | **string** | Timestamp of last workspace rate update | [optional] 
**ReportsCollapse** | **bool?** | Whether reports should be collapsed by default, optional, only for existing WS, will be true initially | [optional] 
**Role** | **string** | Role of the current user in the workspace | [optional] 
**Rounding** | **int?** | Default rounding, premium feature, optional, only for existing WS. 0 - nearest, 1 - round up, -1 - round down | [optional] 
**RoundingMinutes** | **int?** | Default rounding in minutes, premium feature, optional, only for existing WS | [optional] 
**ServerDeletedAt** | **DateTime?** | Timestamp of deletion | [optional] 
**Subscription** | [**ModelsSubscription**](ModelsSubscription.md) | deprecated | [optional] 
**SuspendedAt** | **DateTime?** | Timestamp of suspension | [optional] 
**TeConstraints** | [**ModelsTimeEntryConstraints**](ModelsTimeEntryConstraints.md) | Time entry constraints setting | [optional] 
**WorkingHoursInMinutes** | **int?** | Working hours in minutes | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

