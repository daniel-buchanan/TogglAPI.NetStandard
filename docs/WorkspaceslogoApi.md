# TogglAPI.NetStandard.Api.WorkspaceslogoApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetWorkspaceLogo**](WorkspaceslogoApi.md#getworkspacelogo) | **GET** /workspaces/{workspace_id}/logo | Get workspace logo
[**GetWorkspaceLogo_0**](WorkspaceslogoApi.md#getworkspacelogo_0) | **DELETE** /workspaces/{workspace_id}/logo | Delete workspace logo
[**PostWorkspaceLogo**](WorkspaceslogoApi.md#postworkspacelogo) | **POST** /workspaces/{workspace_id}/logo | Post workspace logo


<a name="getworkspacelogo"></a>
# **GetWorkspaceLogo**
> ModelsLogo GetWorkspaceLogo (int? workspaceId)

Get workspace logo

Get the logo for a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceLogoExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WorkspaceslogoApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace

            try
            {
                // Get workspace logo
                ModelsLogo result = apiInstance.GetWorkspaceLogo(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspaceslogoApi.GetWorkspaceLogo: " + e.Message );
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

<a name="getworkspacelogo_0"></a>
# **GetWorkspaceLogo_0**
> ModelsLogo GetWorkspaceLogo_0 (int? workspaceId)

Delete workspace logo

Delete the logo for a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceLogo_0Example
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WorkspaceslogoApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace

            try
            {
                // Delete workspace logo
                ModelsLogo result = apiInstance.GetWorkspaceLogo_0(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspaceslogoApi.GetWorkspaceLogo_0: " + e.Message );
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

<a name="postworkspacelogo"></a>
# **PostWorkspaceLogo**
> ModelsLogo PostWorkspaceLogo (int? workspaceId)

Post workspace logo

Post the logo for a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostWorkspaceLogoExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WorkspaceslogoApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace

            try
            {
                // Post workspace logo
                ModelsLogo result = apiInstance.PostWorkspaceLogo(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspaceslogoApi.PostWorkspaceLogo: " + e.Message );
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

