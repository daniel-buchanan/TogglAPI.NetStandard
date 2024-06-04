# TogglAPI.NetStandard.Api.PreferencesApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPreferences**](PreferencesApi.md#getpreferences) | **GET** /me/preferences | Preferences for the current user
[**GetPreferencesClient**](PreferencesApi.md#getpreferencesclient) | **GET** /me/preferences/{client} | Preferences for an specific client of the current user
[**GetWorkspacePreferences**](PreferencesApi.md#getworkspacepreferences) | **GET** /workspaces/{workspace_id}/preferences | Get workspace preferences
[**PostPreferences**](PreferencesApi.md#postpreferences) | **POST** /me/preferences | Update the preferences for the current user
[**PostPreferencesClient**](PreferencesApi.md#postpreferencesclient) | **POST** /me/preferences/{client} | Update the preferences for an specific client of the current user
[**PostWorkspacePreferences**](PreferencesApi.md#postworkspacepreferences) | **POST** /workspaces/{workspace_id}/preferences | Get workspace preferences


<a name="getpreferences"></a>
# **GetPreferences**
> ModelsAllPreferences GetPreferences ()

Preferences for the current user

Returns user preferences and alpha features. The list of alpha features contains a full list of feature codes (every feature that exists in database) and the `enabled` flag specifying if that feature should be enabled or disabled for the user.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetPreferencesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PreferencesApi();

            try
            {
                // Preferences for the current user
                ModelsAllPreferences result = apiInstance.GetPreferences();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PreferencesApi.GetPreferences: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ModelsAllPreferences**](ModelsAllPreferences.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpreferencesclient"></a>
# **GetPreferencesClient**
> ModelsAllPreferences GetPreferencesClient (string _client, int? since = null)

Preferences for an specific client of the current user

Returns user preferences and alpha features. The list of alpha features contains a full list of feature codes (every feature that exists in database) and the `enabled` flag specifying if that feature should be enabled or disabled for the user.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetPreferencesClientExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PreferencesApi();
            var _client = _client_example;  // string | Client type
            var since = 56;  // int? | Retrieve preference modified since this date using UNIX timestamp. (optional) 

            try
            {
                // Preferences for an specific client of the current user
                ModelsAllPreferences result = apiInstance.GetPreferencesClient(_client, since);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PreferencesApi.GetPreferencesClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_client** | **string**| Client type | 
 **since** | **int?**| Retrieve preference modified since this date using UNIX timestamp. | [optional] 

### Return type

[**ModelsAllPreferences**](ModelsAllPreferences.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacepreferences"></a>
# **GetWorkspacePreferences**
> ModelsLogo GetWorkspacePreferences (int? workspaceId)

Get workspace preferences

Get the preferences for a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspacePreferencesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PreferencesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace

            try
            {
                // Get workspace preferences
                ModelsLogo result = apiInstance.GetWorkspacePreferences(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PreferencesApi.GetWorkspacePreferences: " + e.Message );
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

[**ModelsLogo**](ModelsLogo.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpreferences"></a>
# **PostPreferences**
> string PostPreferences (ModelsAllPreferences preferences)

Update the preferences for the current user

With this endpoint, preferences can be modified and alpha features can be enabled or disabled.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostPreferencesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PreferencesApi();
            var preferences = new ModelsAllPreferences(); // ModelsAllPreferences | Preferences

            try
            {
                // Update the preferences for the current user
                string result = apiInstance.PostPreferences(preferences);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PreferencesApi.PostPreferences: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **preferences** | [**ModelsAllPreferences**](ModelsAllPreferences.md)| Preferences | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpreferencesclient"></a>
# **PostPreferencesClient**
> string PostPreferencesClient (string _client, ModelsAllPreferences preferences)

Update the preferences for an specific client of the current user

With this endpoint, preferences can be modified and alpha features can be enabled or disabled.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostPreferencesClientExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PreferencesApi();
            var _client = _client_example;  // string | Client type
            var preferences = new ModelsAllPreferences(); // ModelsAllPreferences | Preferences

            try
            {
                // Update the preferences for an specific client of the current user
                string result = apiInstance.PostPreferencesClient(_client, preferences);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PreferencesApi.PostPreferencesClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_client** | **string**| Client type | 
 **preferences** | [**ModelsAllPreferences**](ModelsAllPreferences.md)| Preferences | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postworkspacepreferences"></a>
# **PostWorkspacePreferences**
> ModelsLogo PostWorkspacePreferences (int? workspaceId, ModelsWorkspacePreferences preferences)

Get workspace preferences

Get the preferences for a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostWorkspacePreferencesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PreferencesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var preferences = new ModelsWorkspacePreferences(); // ModelsWorkspacePreferences | Input data of the preferences.

            try
            {
                // Get workspace preferences
                ModelsLogo result = apiInstance.PostWorkspacePreferences(workspaceId, preferences);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PreferencesApi.PostWorkspacePreferences: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **preferences** | [**ModelsWorkspacePreferences**](ModelsWorkspacePreferences.md)| Input data of the preferences. | 

### Return type

[**ModelsLogo**](ModelsLogo.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

