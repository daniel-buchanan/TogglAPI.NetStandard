# TogglAPI.NetStandard.Model.TotalsReportPost
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Billable** | **bool?** | Whether the time entry is set as billable, optional, premium feature. | [optional] 
**ClientIds** | **List&lt;int?&gt;** | Client IDs, optional, filtering attribute. To filter records with no clients, use [null]. | [optional] 
**Description** | **string** | Description, optional, filtering attribute. | [optional] 
**EndDate** | **string** | End date, example time.DateOnly. Should be greater than Start date. | [optional] 
**Granularity** | **string** | Totals granularity, optional, overrides resolution values. Possible values: day, week and month. | [optional] 
**GroupIds** | **List&lt;int?&gt;** | Group IDs, optional, filtering attribute. | [optional] 
**Grouped** | **bool?** | Whether time entries should be grouped, optional, default false. | [optional] 
**MaxDurationSeconds** | **int?** | Max duration seconds, optional, filtering attribute. Time Audit only, should be greater than MinDurationSeconds. | [optional] 
**MinDurationSeconds** | **int?** | Min duration seconds, optional, filtering attribute. Time Audit only, should be less than MaxDurationSeconds. | [optional] 
**PostedFields** | **List&lt;string&gt;** |  | [optional] 
**ProjectIds** | **List&lt;int?&gt;** | Project IDs, optional, filtering attribute. To filter records with no projects, use [null]. | [optional] 
**Resolution** | **string** | Graph resolution, optional. Allow clients to explicitly request a resolution. | [optional] 
**Rounding** | **int?** | Whether time should be rounded, optional, default from workspace settings. | [optional] 
**RoundingMinutes** | **int?** | Rounding minutes value, optional, default from workspace settings. Should be 0, 1, 5, 6, 10, 12, 15, 30, 60 or 240. | [optional] 
**StartTime** | **string** |  | [optional] 
**StartDate** | **string** | Start date, example time.DateOnly. Should be less than End date. | [optional] 
**TagIds** | **List&lt;int?&gt;** | Tag IDs, optional, filtering attribute. To filter records with no tags, use [null]. | [optional] 
**TaskIds** | **List&lt;int?&gt;** | Task IDs, optional, filtering attribute. To filter records with no tasks, use [null]. | [optional] 
**TimeEntryIds** | **List&lt;int?&gt;** | Time entry IDs, optional. | [optional] 
**UserIds** | **List&lt;int?&gt;** | User IDs, optional, filtering attribute. | [optional] 
**WithInlineRates** | **bool?** | Whether results should be returned in line, optional, default false. | [optional] 
**WithGraph** | **bool?** | Whether Graph information should be loaded, optional,  default false. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

