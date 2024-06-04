# TogglAPI.NetStandard.Model.ModelsTimeEntry
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**At** | **string** | When was last updated | [optional] 
**Billable** | **bool?** | Whether the time entry is marked as billable | [optional] 
**ClientName** | **string** | Related entities meta fields - if requested | [optional] 
**Description** | **string** | Time Entry description, null if not provided at creation/update | [optional] 
**Duration** | **int?** | Time entry duration. For running entries should be negative, preferable -1 | [optional] 
**Duronly** | **bool?** | Used to create a TE with a duration but without a stop time, this field is deprecated for GET endpoints where the value will always be true. | [optional] 
**Id** | **int?** | Time Entry ID | [optional] 
**Permissions** | **List&lt;string&gt;** | Permission list | [optional] 
**Pid** | **int?** | Project ID, legacy field | [optional] 
**ProjectActive** | **bool?** |  | [optional] 
**ProjectColor** | **string** |  | [optional] 
**ProjectId** | **int?** | Project ID. Can be null if project was not provided or project was later deleted | [optional] 
**ProjectName** | **string** |  | [optional] 
**ServerDeletedAt** | **string** | When was deleted, null if not deleted | [optional] 
**SharedWith** | [**List&lt;ModelsTimeEntrySharedWith&gt;**](ModelsTimeEntrySharedWith.md) | Indicates who the time entry has been shared with | [optional] 
**Start** | **string** | Start time in UTC | [optional] 
**Stop** | **string** | Stop time in UTC, can be null if it&#39;s still running or created with \&quot;duration\&quot; and \&quot;duronly\&quot; fields | [optional] 
**TagIds** | **List&lt;int?&gt;** | Tag IDs, null if tags were not provided or were later deleted | [optional] 
**Tags** | **List&lt;string&gt;** | Tag names, null if tags were not provided or were later deleted | [optional] 
**TaskId** | **int?** | Task ID. Can be null if task was not provided or project was later deleted | [optional] 
**TaskName** | **string** |  | [optional] 
**Tid** | **int?** | Task ID, legacy field | [optional] 
**Uid** | **int?** | Time Entry creator ID, legacy field | [optional] 
**UserAvatarUrl** | **string** |  | [optional] 
**UserId** | **int?** | Time Entry creator ID | [optional] 
**UserName** | **string** |  | [optional] 
**Wid** | **int?** | Workspace ID, legacy field | [optional] 
**WorkspaceId** | **int?** | Workspace ID | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

