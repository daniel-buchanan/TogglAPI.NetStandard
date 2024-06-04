# TogglAPI.NetStandard.Model.ModelsAlert
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;ModelsAlertError&gt;**](ModelsAlertError.md) |  | [optional] 
**Id** | **int?** |  | [optional] 
**ObjectType** | **int?** |  | [optional] 
**ProjectId** | **int?** |  | [optional] 
**ReceiverGroups** | **string** |  | [optional] 
**ReceiverRoles** | **string** |  | [optional] 
**ReceiverUsers** | **string** |  | [optional] 
**Receivers** | **int?** |  | [optional] 
**SourceKind** | **string** |  | [optional] 
**Threshold** | **int?** |  | [optional] 
**ThresholdType** | **string** |  | [optional] 
**Thresholds** | **string** | using pq types is a workaround to enable reading postgres arrays into go types we should wrap these pq types to avoid polluting our domain | [optional] 
**Wid** | **int?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

