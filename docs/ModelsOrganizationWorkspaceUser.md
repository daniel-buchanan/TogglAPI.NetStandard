# TogglAPI.NetStandard.Model.ModelsOrganizationWorkspaceUser
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool?** | Flag indicating if user accepted the invitation | [optional] 
**Admin** | **bool?** | Flag indicating if user is admin | [optional] 
**At** | **string** | Timestamp of the last update | [optional] 
**AvatarFileName** | **string** | URL of avatar | [optional] 
**Email** | **string** | Email of the user | [optional] 
**GroupIds** | [**UtilsInt64Slice**](UtilsInt64Slice.md) | List of groups the user belongs to | [optional] 
**Id** | **int?** | Identifier of the user inside workspace | [optional] 
**Inactive** | **bool?** | Flag indicating if user was deactivated by admin of the workspace | [optional] 
**InvitationCode** | **string** | internal | [optional] 
**InviteUrl** | **string** | internal | [optional] 
**IsDirect** | **bool?** | Flag indicating if user is a direct member of the workspace (is not assigned to the workspace using the group) | [optional] 
**LabourCost** | **int?** | Labour cost assigned to the user | [optional] 
**Name** | **string** | Name of the user | [optional] 
**OrganizationAdmin** | **bool?** | Flag indicating if user is admin inside organization | [optional] 
**Rate** | **decimal?** | Rate assigned to the user | [optional] 
**RateLastUpdated** | **string** | Timestamp of the last rate update | [optional] 
**Role** | **string** | Role of the user | [optional] 
**Timezone** | **string** | Timezone of the user | [optional] 
**UserId** | **int?** | Global user identifier | [optional] 
**WorkingHoursInMinutes** | **int?** | Working hours value in minutes | [optional] 
**WorkspaceAdmin** | **bool?** | Flag indicating if user is admin inside workspace | [optional] 
**WorkspaceId** | **int?** | Workspace identifier | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

