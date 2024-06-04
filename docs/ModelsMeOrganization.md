# TogglAPI.NetStandard.Model.ModelsMeOrganization
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Admin** | **bool?** | Whether the requester is an admin of the organization | [optional] 
**At** | **DateTime?** | Organization&#39;s last modification date | [optional] 
**CreatedAt** | **DateTime?** | Organization&#39;s creation date | [optional] 
**Id** | **int?** | Organization ID | [optional] 
**IsMultiWorkspaceEnabled** | **bool?** | Is true when the organization option is_multi_workspace_enabled is set | [optional] 
**IsUnified** | **bool?** |  | [optional] 
**MaxDataRetentionDays** | **int?** | How far back free workspaces in this org can access data. | [optional] 
**MaxWorkspaces** | **int?** | Maximum number of workspaces allowed for the organization | [optional] 
**Name** | **string** | Organization Name | [optional] 
**Owner** | **bool?** | Whether the requester is a the owner of the organization | [optional] 
**PaymentMethods** | **string** | Organization&#39;s subscription payment methods. Omitted if empty. | [optional] 
**Permissions** | **string** |  | [optional] 
**PricingPlanEnterprise** | **bool?** | The subscription plan is an enterprise plan | [optional] 
**PricingPlanId** | **int?** | Organization plan ID | [optional] 
**PricingPlanName** | **string** | The subscription plan name the org is currently on. Free or any plan name coming from payment provider | [optional] 
**ServerDeletedAt** | **DateTime?** | Organization&#39;s delete date | [optional] 
**SuspendedAt** | **string** | Whether the organization is currently suspended | [optional] 
**TrialInfo** | [**ModelsTrialInfo**](ModelsTrialInfo.md) |  | [optional] 
**UserCount** | **int?** | Number of organization users | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

