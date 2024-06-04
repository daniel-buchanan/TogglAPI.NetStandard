# TogglAPI.NetStandard.Model.WorkspacePayload
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Admins** | **List&lt;int?&gt;** | List of admins, optional | [optional] 
**DefaultCurrency** | **string** | Default currency, premium feature, optional, only for existing WS, will be &#39;USD&#39; initially | [optional] 
**DefaultHourlyRate** | **decimal?** | The default hourly rate, premium feature, optional, only for existing WS, will be 0.0 initially | [optional] 
**InitialPricingPlan** | **int?** | The subscription plan for the workspace, deprecated | [optional] 
**Name** | **string** | Workspace name | [optional] 
**OnlyAdminsMayCreateProjects** | **bool?** | Only admins will be able to create projects, optional, only for existing WS, will be false initially | [optional] 
**OnlyAdminsMayCreateTags** | **bool?** | Only admins will be able to create tags, optional, only for existing WS, will be false initially | [optional] 
**OnlyAdminsSeeBillableRates** | **bool?** | Whether only admins will be able to see billable rates, premium feature, optional, only for existing WS. Will be false initially | [optional] 
**OnlyAdminsSeeTeamDashboard** | **bool?** | Only admins will be able to see the team dashboard, optional, only for existing WS, will be false initially | [optional] 
**ProjectsBillableByDefault** | **bool?** | Whether projects will be set as billable by default, premium feature, optional, only for existing WS. Will be true initially | [optional] 
**ProjectsPrivateByDefault** | **bool?** | Whether projects will be set to private by default, optional. Will be true initially. | [optional] 
**RateChangeMode** | **string** | The rate change mode, premium feature, optional, only for existing WS. Can be \&quot;start-today\&quot;, \&quot;override-current\&quot;, \&quot;override-all\&quot; | [optional] 
**ReportsCollapse** | **bool?** | Whether reports should be collapsed by default, optional, only for existing WS, will be true initially | [optional] 
**Rounding** | **int?** | Default rounding, premium feature, optional, only for existing WS | [optional] 
**RoundingMinutes** | **int?** | Default rounding in minutes, premium feature, optional, only for existing WS | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

