# TogglAPI.NetStandard.Model.ProjectPatchInput
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Op** | **string** | Patch operation to perform, one of \&quot;add\&quot;, \&quot;remove\&quot;, \&quot;replace\&quot; | [optional] 
**Path** | **string** | Path to the field to patch, example: \&quot;/color\&quot; | [optional] 
**Value** | **Object** | Value to set when operation is \&quot;add\&quot; or \&quot;replace\&quot;, example: \&quot;#000000\&quot;. The value type actually depends on the field being patched. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

