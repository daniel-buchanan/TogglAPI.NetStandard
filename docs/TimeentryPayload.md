# TogglAPI.NetStandard.Model.TimeentryPayload
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Billable** | **bool?** | Whether the time entry is marked as billable, optional, default false | [optional] 
**CreatedWith** | **string** | Must be provided when creating a time entry and should identify the service/application used to create it | [optional] 
**Description** | **string** | Time entry description, optional | [optional] 
**Duration** | **int?** | Time entry duration. For running entries should be negative, preferable -1 | [optional] 
**Duronly** | **bool?** | Deprecated: Used to create a time entry with a duration but without a stop time. This parameter can be ignored. | [optional] 
**Pid** | **int?** | Project ID, legacy field | [optional] 
**ProjectId** | **int?** | Project ID, optional | [optional] 
**SharedWithUserIds** | **List&lt;int?&gt;** | List of user IDs to share this time entry with | [optional] 
**Start** | **string** | Start time in UTC, required for creation. Format: 2006-01-02T15:04:05Z | [optional] 
**StartDate** | **string** | If provided during creation, the date part will take precedence over the date part of \&quot;start\&quot;. Format: 2006-11-07 | [optional] 
**Stop** | **string** | Stop time in UTC, can be omitted if it&#39;s still running or created with \&quot;duration\&quot;. If \&quot;stop\&quot; and \&quot;duration\&quot; are provided, values must be consistent (start + duration &#x3D;&#x3D; stop) | [optional] 
**TagAction** | **string** | Can be \&quot;add\&quot; or \&quot;delete\&quot;. Used when updating an existing time entry | [optional] 
**TagIds** | **List&lt;int?&gt;** | IDs of tags to add/remove | [optional] 
**Tags** | **List&lt;string&gt;** | Names of tags to add/remove. If name does not exist as tag, one will be created automatically | [optional] 
**TaskId** | **int?** | Task ID, optional | [optional] 
**Tid** | **int?** | Task ID, legacy field | [optional] 
**Uid** | **int?** | Time Entry creator ID, legacy field | [optional] 
**UserId** | **int?** | Time Entry creator ID, if omitted will use the requester user ID | [optional] 
**Wid** | **int?** | Workspace ID, legacy field | [optional] 
**WorkspaceId** | **int?** | Workspace ID, required | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

