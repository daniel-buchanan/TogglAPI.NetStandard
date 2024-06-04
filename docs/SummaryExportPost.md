# TogglAPI.NetStandard.Model.SummaryExportPost
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Audit** | [**SummaryAudit**](SummaryAudit.md) |  | [optional] 
**Billable** | **bool?** | Whether the time entry is set as billable, optional, premium feature. | [optional] 
**ClientIds** | **List&lt;int?&gt;** | Client IDs, optional, filtering attribute. To filter records with no clients, use [null]. | [optional] 
**Collapse** | **bool?** | Whether collapse others, optional, default false. | [optional] 
**Description** | **string** | Description, optional, filtering attribute. | [optional] 
**DistinguishRates** | **bool?** | DistinguishRates will create new subgroups for each rate, optional, default false. | [optional] 
**DurationFormat** | **string** | Duration format, optional, default \&quot;classic\&quot;. Can be \&quot;classic\&quot;, \&quot;decimal\&quot; or \&quot;improved\&quot;. | [optional] 
**EndDate** | **string** | End date, example time.DateOnly. Should be greater than Start date. | [optional] 
**GroupIds** | **List&lt;int?&gt;** | Group IDs, optional, filtering attribute. | [optional] 
**Grouping** | **string** | Grouping option, optional. | [optional] 
**HideAmounts** | **bool?** | Whether amounts should be hidden, optional, default false. | [optional] 
**HideRates** | **bool?** | Whether rates should be hidden, optional, default false. | [optional] 
**IncludeTimeEntryIds** | **bool?** | Whether time entry IDs should be included in the results, optional, default false. Not applicable for export. | [optional] 
**MaxDurationSeconds** | **int?** | Max duration seconds, optional, filtering attribute. Time Audit only, should be greater than MinDurationSeconds. | [optional] 
**MinDurationSeconds** | **int?** | Min duration seconds, optional, filtering attribute. Time Audit only, should be less than MaxDurationSeconds. | [optional] 
**OrderBy** | **string** | Order by option, optional, default title. Can be title or duration. | [optional] 
**OrderDir** | **string** | Order direction, optional. Can be ASC or DESC. | [optional] 
**PostedFields** | **List&lt;string&gt;** |  | [optional] 
**ProjectIds** | **List&lt;int?&gt;** | Project IDs, optional, filtering attribute. To filter records with no projects, use [null]. | [optional] 
**Rounding** | **int?** | Whether time should be rounded, optional, default from workspace settings. | [optional] 
**RoundingMinutes** | **int?** | Rounding minutes value, optional, default from workspace settings. Should be 0, 1, 5, 6, 10, 12, 15, 30, 60 or 240. | [optional] 
**StartTime** | **string** |  | [optional] 
**StartDate** | **string** | Start date, example time.DateOnly. Should be less than End date. | [optional] 
**SubGrouping** | **string** | SubGrouping option, optional. | [optional] 
**TagIds** | **List&lt;int?&gt;** | Tag IDs, optional, filtering attribute. To filter records with no tags, use [null]. | [optional] 
**TaskIds** | **List&lt;int?&gt;** | Task IDs, optional, filtering attribute. To filter records with no tasks, use [null]. | [optional] 
**TimeEntryIds** | **List&lt;int?&gt;** | TimeEntryIDs filters by time entries. This was added to support retro-compatibility with reports v2. | [optional] 
**UserIds** | **List&lt;int?&gt;** | User IDs, optional, filtering attribute. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

