# TogglAPI.NetStandard.Api.InvitationsApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetInvitations**](InvitationsApi.md#getinvitations) | **GET** /invitations/{invitation_code} | Get an invitation
[**PostOrganizationAcceptInvitation**](InvitationsApi.md#postorganizationacceptinvitation) | **POST** /organizations/invitations/{invitation_code}/accept | Accepts invitation
[**PostOrganizationInvitation**](InvitationsApi.md#postorganizationinvitation) | **POST** /organizations/{organization_id}/invitations | Creates a new invitation for the user
[**PostRejectInvitation**](InvitationsApi.md#postrejectinvitation) | **POST** /organizations/invitations/{invitation_code}/reject | Rejects invitation
[**PutInvitation**](InvitationsApi.md#putinvitation) | **PUT** /organizations/{organization_id}/invitations/{invitation_code}/resend | Resends user their invitation


<a name="getinvitations"></a>
# **GetInvitations**
> ModelsSSOInvitation GetInvitations (string invitationCode)

Get an invitation

Returns an invitation data by code.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetInvitationsExample
    {
        public void main()
        {
            var apiInstance = new InvitationsApi();
            var invitationCode = invitationCode_example;  // string | Invitation code

            try
            {
                // Get an invitation
                ModelsSSOInvitation result = apiInstance.GetInvitations(invitationCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationsApi.GetInvitations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invitationCode** | **string**| Invitation code | 

### Return type

[**ModelsSSOInvitation**](ModelsSSOInvitation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postorganizationacceptinvitation"></a>
# **PostOrganizationAcceptInvitation**
> string PostOrganizationAcceptInvitation (string inviutationCode)

Accepts invitation

User connected with invitation is marked as joined, email is sent to the inviter.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostOrganizationAcceptInvitationExample
    {
        public void main()
        {
            var apiInstance = new InvitationsApi();
            var inviutationCode = inviutationCode_example;  // string | Invitation code

            try
            {
                // Accepts invitation
                string result = apiInstance.PostOrganizationAcceptInvitation(inviutationCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationsApi.PostOrganizationAcceptInvitation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inviutationCode** | **string**| Invitation code | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postorganizationinvitation"></a>
# **PostOrganizationInvitation**
> InvitationResult PostOrganizationInvitation (int? organizationId, InvitationPost postInvitationRequest)

Creates a new invitation for the user

Creates a new invitation for the user.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostOrganizationInvitationExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new InvitationsApi();
            var organizationId = 56;  // int? | Numeric ID of the organization.
            var postInvitationRequest = new InvitationPost(); // InvitationPost | Input data for invitation creation

            try
            {
                // Creates a new invitation for the user
                InvitationResult result = apiInstance.PostOrganizationInvitation(organizationId, postInvitationRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationsApi.PostOrganizationInvitation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization. | 
 **postInvitationRequest** | [**InvitationPost**](InvitationPost.md)| Input data for invitation creation | 

### Return type

[**InvitationResult**](InvitationResult.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postrejectinvitation"></a>
# **PostRejectInvitation**
> string PostRejectInvitation (string inviutationCode)

Rejects invitation

User connected with invitation is marked as deleted.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostRejectInvitationExample
    {
        public void main()
        {
            var apiInstance = new InvitationsApi();
            var inviutationCode = inviutationCode_example;  // string | Invitation code

            try
            {
                // Rejects invitation
                string result = apiInstance.PostRejectInvitation(inviutationCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationsApi.PostRejectInvitation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inviutationCode** | **string**| Invitation code | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putinvitation"></a>
# **PutInvitation**
> string PutInvitation (int? organizationId, string invitationCode)

Resends user their invitation

Resend invitation email to user.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutInvitationExample
    {
        public void main()
        {
            var apiInstance = new InvitationsApi();
            var organizationId = 56;  // int? | Organization ID
            var invitationCode = invitationCode_example;  // string | Invitation code

            try
            {
                // Resends user their invitation
                string result = apiInstance.PutInvitation(organizationId, invitationCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationsApi.PutInvitation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Organization ID | 
 **invitationCode** | **string**| Invitation code | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

