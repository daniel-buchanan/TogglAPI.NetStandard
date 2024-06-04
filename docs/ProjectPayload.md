# TogglAPI.NetStandard.Model.ProjectPayload
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool?** | Whether the project is active or archived | [optional] 
**AutoEstimates** | **bool?** | Whether estimates are based on task hours, optional, premium feature | [optional] 
**Billable** | **bool?** | Whether the project is set as billable, optional, premium feature | [optional] 
**Cid** | **int?** | Client ID, legacy | [optional] 
**ClientId** | **int?** | Client ID, optional | [optional] 
**ClientName** | **string** | Client name, optional | [optional] 
**Color** | **string** | Project color | [optional] 
**Currency** | **string** | Project currency, optional, premium feature | [optional] 
**EndDate** | **string** | End date of a project timeframe | [optional] 
**EstimatedHours** | **int?** | Estimated hours, optional, premium feature | [optional] 
**FixedFee** | **decimal?** | Project fixed fee, optional, premium feature | [optional] 
**IsPrivate** | **bool?** | Whether the project is private or not | [optional] 
**IsShared** | **bool?** | Shared | [optional] 
**Name** | **string** | Project name | [optional] 
**Rate** | **decimal?** | Hourly rate, optional, premium feature | [optional] 
**RateChangeMode** | **string** | Rate change mode, optional, premium feature. Can be \&quot;start-today\&quot;, \&quot;override-current\&quot;, \&quot;override-all\&quot; | [optional] 
**Recurring** | **bool?** | Project is recurring, optional, premium feature | [optional] 
**RecurringParameters** | [**ProjectRecurringParameters**](ProjectRecurringParameters.md) | Project recurring parameters, optional, premium feature | [optional] 
**StartDate** | **string** | Start date of a project timeframe | [optional] 
**Template** | **bool?** | Project is template, optional, premium feature | [optional] 
**TemplateId** | **int?** | Template ID, optional | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

