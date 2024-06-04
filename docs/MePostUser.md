# TogglAPI.NetStandard.Model.MePostUser
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CountryId** | **int?** | User&#39;s country ID, if not provided will be United States | [optional] 
**CreatedWith** | **string** | Should describe the application/service that is using the API | [optional] 
**Email** | **string** | Email for new user account | 
**FullName** | **string** | User&#39;s full name, if not provided will be derived from the email address | [optional] 
**InvitationCode** | **string** | Optional, used when creating account through an invitation | [optional] 
**Password** | **string** | Password for new user account | 
**Timezone** | **string** | User&#39;s timezone, if not provided will be UTC | [optional] 
**TosAccepted** | **bool?** | Whether the Terms of Service have been accepted | 
**Workspace** | [**MePostInitialWorkspace**](MePostInitialWorkspace.md) | Optional workspace settings, used when creating account not through an invitation | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

