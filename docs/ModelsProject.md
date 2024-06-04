# TogglAPI.NetStandard.Model.ModelsProject
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool?** | Whether the project is active or archived | [optional] 
**ActualHours** | **int?** | Actual hours | [optional] 
**ActualSeconds** | **int?** | Actual seconds | [optional] 
**At** | **string** | Last updated date | [optional] 
**AutoEstimates** | **bool?** | Whether estimates are based on task hours, premium feature | [optional] 
**Billable** | **bool?** | Whether the project is billable, premium feature | [optional] 
**CanTrackTime** | **bool?** |  | [optional] 
**Cid** | **int?** | Client ID legacy field | [optional] 
**ClientId** | **int?** | Client ID | [optional] 
**Color** | **string** | Color | [optional] 
**CreatedAt** | **string** | Creation date | [optional] 
**Currency** | **string** | Currency, premium feature | [optional] 
**CurrentPeriod** | [**ModelsRecurringPeriod**](ModelsRecurringPeriod.md) | Current project period, premium feature | [optional] 
**EndDate** | **string** | End date | [optional] 
**EstimatedHours** | **int?** | Estimated hours | [optional] 
**EstimatedSeconds** | **int?** | Estimated seconds | [optional] 
**FixedFee** | **decimal?** | Fixed fee, premium feature | [optional] 
**Id** | **int?** | Project ID | [optional] 
**IsPrivate** | **bool?** | Whether the project is private | [optional] 
**IsShared** | **bool?** | Shared Project | [optional] 
**Name** | **string** | Name | [optional] 
**Permissions** | **string** |  | [optional] 
**Rate** | **decimal?** | Hourly rate | [optional] 
**RateLastUpdated** | **string** | Last date for rate change | [optional] 
**Recurring** | **bool?** | Whether the project is recurring, premium feature | [optional] 
**RecurringParameters** | [**List&lt;ModelsRecurringProjectParameters&gt;**](ModelsRecurringProjectParameters.md) | Project recurring parameters, premium feature | [optional] 
**ServerDeletedAt** | **string** | Deletion date | [optional] 
**SharedAt** | **string** |  | [optional] 
**SharedHash** | **string** |  | [optional] 
**StartDate** | **string** | Start date | [optional] 
**Status** | **string** | Status of the project (upcoming, active, ended, archived, deleted) | [optional] 
**Template** | **bool?** | Whether the project is used as template, premium feature | [optional] 
**TemplateId** | **int?** | Template ID | [optional] 
**Wid** | **int?** | Workspace ID legacy field | [optional] 
**WorkspaceId** | **int?** | Workspace ID | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

