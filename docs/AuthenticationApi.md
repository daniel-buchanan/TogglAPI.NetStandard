# TogglAPI.NetStandard.Api.AuthenticationApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSaml2LoginUrl**](AuthenticationApi.md#getsaml2loginurl) | **GET** /auth/saml2/login | SAML2 Identity Provider URL
[**GetWorkspaceSso**](AuthenticationApi.md#getworkspacesso) | **GET** /workspaces/{workspace_id}/sso | Workspace SSO configuration
[**MeSessionsDelete**](AuthenticationApi.md#mesessionsdelete) | **DELETE** /me/sessions | Delete session
[**MeSessionsPost**](AuthenticationApi.md#mesessionspost) | **POST** /me/sessions | Create session
[**PostEnableSso**](AuthenticationApi.md#postenablesso) | **POST** /me/enable_sso | Confirm SSO enabling for user account
[**PostResetToken**](AuthenticationApi.md#postresettoken) | **POST** /me/reset_token | ResetToken
[**PostSaml2Callback**](AuthenticationApi.md#postsaml2callback) | **POST** /auth/saml2/login/{workspace_id} | SAML2 Identity Provider Callback
[**PostSignup**](AuthenticationApi.md#postsignup) | **POST** /signup | Signup


<a name="getsaml2loginurl"></a>
# **GetSaml2LoginUrl**
> Saml2LoginResponse GetSaml2LoginUrl (string email, string _client = null, string state = null)

SAML2 Identity Provider URL

Returns the SSO URL given an email address for authenticating in an Identity Provider.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetSaml2LoginUrlExample
    {
        public void main()
        {
            var apiInstance = new AuthenticationApi();
            var email = email_example;  // string | User email
            var _client = _client_example;  // string | Client identification (webapp/toggl-button/client) TODO: add desktop identification (optional) 
            var state = state_example;  // string | State to be preserved when redirecting to Accounts API (optional) 

            try
            {
                // SAML2 Identity Provider URL
                Saml2LoginResponse result = apiInstance.GetSaml2LoginUrl(email, _client, state);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.GetSaml2LoginUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| User email | 
 **_client** | **string**| Client identification (webapp/toggl-button/client) TODO: add desktop identification | [optional] 
 **state** | **string**| State to be preserved when redirecting to Accounts API | [optional] 

### Return type

[**Saml2LoginResponse**](Saml2LoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacesso"></a>
# **GetWorkspaceSso**
> SsoConfigResult GetWorkspaceSso (int? workspaceId)

Workspace SSO configuration

Returns the SSO configuration for a workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceSsoExample
    {
        public void main()
        {
            var apiInstance = new AuthenticationApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace

            try
            {
                // Workspace SSO configuration
                SsoConfigResult result = apiInstance.GetWorkspaceSso(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.GetWorkspaceSso: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 

### Return type

[**SsoConfigResult**](SsoConfigResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mesessionsdelete"></a>
# **MeSessionsDelete**
> void MeSessionsDelete ()

Delete session

Deletes a session used for authenticating the current request

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class MeSessionsDeleteExample
    {
        public void main()
        {
            var apiInstance = new AuthenticationApi();

            try
            {
                // Delete session
                apiInstance.MeSessionsDelete();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.MeSessionsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mesessionspost"></a>
# **MeSessionsPost**
> ModelsUser MeSessionsPost (MePostSessionHandlerRequestBody sessionPost = null)

Create session

Creates a session and sets a cookie in the response header which can be used for authentication in API requests

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class MeSessionsPostExample
    {
        public void main()
        {
            var apiInstance = new AuthenticationApi();
            var sessionPost = new MePostSessionHandlerRequestBody(); // MePostSessionHandlerRequestBody | Session preferences (optional) 

            try
            {
                // Create session
                ModelsUser result = apiInstance.MeSessionsPost(sessionPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.MeSessionsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionPost** | [**MePostSessionHandlerRequestBody**](MePostSessionHandlerRequestBody.md)| Session preferences | [optional] 

### Return type

[**ModelsUser**](ModelsUser.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postenablesso"></a>
# **PostEnableSso**
> string PostEnableSso (SsoConfirmation enableSsoPost)

Confirm SSO enabling for user account

Confirm SSO enabling in existing Toggl account after successful SSO

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostEnableSsoExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AuthenticationApi();
            var enableSsoPost = new SsoConfirmation(); // SsoConfirmation | SSO enabling confirmation data

            try
            {
                // Confirm SSO enabling for user account
                string result = apiInstance.PostEnableSso(enableSsoPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.PostEnableSso: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enableSsoPost** | [**SsoConfirmation**](SsoConfirmation.md)| SSO enabling confirmation data | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postresettoken"></a>
# **PostResetToken**
> string PostResetToken ()

ResetToken

Resets API token for the current user.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostResetTokenExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AuthenticationApi();

            try
            {
                // ResetToken
                string result = apiInstance.PostResetToken();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.PostResetToken: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsaml2callback"></a>
# **PostSaml2Callback**
> void PostSaml2Callback (int? workspaceId, string sAMLResponse, string relayState = null)

SAML2 Identity Provider Callback

Receives the IdP Callback containing the SAML2 assertion with response of user authentication in the IdP.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostSaml2CallbackExample
    {
        public void main()
        {
            var apiInstance = new AuthenticationApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var sAMLResponse = sAMLResponse_example;  // string | SAML2 assertion with authentication response
            var relayState = relayState_example;  // string | Encoded string containing client and host which originated the requests (optional) 

            try
            {
                // SAML2 Identity Provider Callback
                apiInstance.PostSaml2Callback(workspaceId, sAMLResponse, relayState);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.PostSaml2Callback: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **sAMLResponse** | **string**| SAML2 assertion with authentication response | 
 **relayState** | **string**| Encoded string containing client and host which originated the requests | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsignup"></a>
# **PostSignup**
> ModelsTogglUser PostSignup (MePostUser postUser)

Signup

Sign up as a new user.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostSignupExample
    {
        public void main()
        {
            var apiInstance = new AuthenticationApi();
            var postUser = new MePostUser(); // MePostUser | authorization data

            try
            {
                // Signup
                ModelsTogglUser result = apiInstance.PostSignup(postUser);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.PostSignup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postUser** | [**MePostUser**](MePostUser.md)| authorization data | 

### Return type

[**ModelsTogglUser**](ModelsTogglUser.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

