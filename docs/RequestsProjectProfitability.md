# TogglAPI.NetStandard.Model.RequestsProjectProfitability
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Billable** | **bool?** | Whether the project is set as billable, optional, premium feature. | [optional] 
**ClientIds** | **List&lt;int?&gt;** | Client IDs, optional. A nil entry on this list means that only projects without client will be selected. | [optional] 
**Currency** | **string** | Currency, example: \&quot;usd\&quot;. | 
**EndDate** | **string** | End date, optional, example: time.DateOnly. Should be greater than Start date. | [optional] 
**ProjectIds** | **List&lt;int?&gt;** | Project IDS, optional. | [optional] 
**Resolution** | **string** | Resolution, optional. Can be \&quot;day\&quot;, \&quot;week\&quot; or \&quot;month\&quot;. | [optional] 
**Rounding** | **int?** | Rounding, optional, duration rounding settings, premium feature. | [optional] 
**RoundingMinutes** | **int?** | RoundingMinutes, optional, duration rounding minutes settings, premium feature. | [optional] 
**StartDate** | **string** | Start date, optional, example: time.DateOnly. Should be less than End date. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

