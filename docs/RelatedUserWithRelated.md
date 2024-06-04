# TogglAPI.NetStandard.Model.RelatedUserWithRelated
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiToken** | **string** | will be omitted if empty | [optional] 
**At** | **DateTime?** |  | [optional] 
**AuthorizationUpdatedAt** | **string** | AuthorizationUpdatedAt timestamp when the authorization user session object was last updated. | [optional] 
**BeginningOfWeek** | **int?** |  | [optional] 
**Clients** | [**List&lt;ModelsClient&gt;**](ModelsClient.md) | Clients, null if with_related_data was not set to true or if the user does not have any clients | [optional] 
**CountryId** | **int?** |  | [optional] 
**CreatedAt** | **DateTime?** |  | [optional] 
**DefaultWorkspaceId** | **int?** |  | [optional] 
**Email** | **string** |  | [optional] 
**Fullname** | **string** |  | [optional] 
**HasPassword** | **bool?** |  | [optional] 
**Id** | **int?** |  | [optional] 
**ImageUrl** | **string** |  | [optional] 
**IntercomHash** | **string** | will be omitted if empty | [optional] 
**OauthProviders** | **List&lt;string&gt;** |  | [optional] 
**OpenidEmail** | **string** |  | [optional] 
**OpenidEnabled** | **bool?** |  | [optional] 
**Options** | [**ModelsOptions**](ModelsOptions.md) | will be omitted if empty | [optional] 
**Projects** | [**List&lt;ModelsProject&gt;**](ModelsProject.md) | Projects, null if with_related_data was not set to true or if the user does not have any projects | [optional] 
**Tags** | [**List&lt;ModelsTag&gt;**](ModelsTag.md) | Tags, null if with_related_data was not set to true, or if the user does not have any tags | [optional] 
**Tasks** | [**List&lt;ModelsTask&gt;**](ModelsTask.md) | Tasks, null if with_related_data was not set to true or if the user does not have any tasks | [optional] 
**TimeEntries** | [**List&lt;ModelsTimeEntry&gt;**](ModelsTimeEntry.md) | TimeEntries, null if with_related_data was not set to true or if the user does not have any time entries | [optional] 
**Timezone** | **string** |  | [optional] 
**UpdatedAt** | **DateTime?** |  | [optional] 
**Workspaces** | [**List&lt;WorkspaceWorkspace&gt;**](WorkspaceWorkspace.md) | Workspaces, null if with_related_data was not set to true or if the user does not have any workspaces | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

