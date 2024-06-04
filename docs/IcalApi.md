# TogglAPI.NetStandard.Api.IcalApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetIcal**](IcalApi.md#getical) | **GET** /ical/workspace_user/{token} | Ical file
[**PostWorkspaceIcalReset**](IcalApi.md#postworkspaceicalreset) | **POST** /workspaces/{workspace_id}/ical/reset | Reset iCal token
[**PostWorkspaceIcalToggle**](IcalApi.md#postworkspaceicaltoggle) | **POST** /workspaces/{workspace_id}/ical/toggle | Toggle the iCal token


<a name="getical"></a>
# **GetIcal**
> void GetIcal ()

Ical file

Returns ical file with TEs from last 14 days

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetIcalExample
    {
        public void main()
        {
            var apiInstance = new IcalApi();

            try
            {
                // Ical file
                apiInstance.GetIcal();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IcalApi.GetIcal: " + e.Message );
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
 - **Accept**: text/calendar

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postworkspaceicalreset"></a>
# **PostWorkspaceIcalReset**
> string PostWorkspaceIcalReset (int? workspaceId)

Reset iCal token

Reset the iCal token for a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostWorkspaceIcalResetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new IcalApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace

            try
            {
                // Reset iCal token
                string result = apiInstance.PostWorkspaceIcalReset(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IcalApi.PostWorkspaceIcalReset: " + e.Message );
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

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postworkspaceicaltoggle"></a>
# **PostWorkspaceIcalToggle**
> string PostWorkspaceIcalToggle (int? workspaceId)

Toggle the iCal token

Toggle the iCal token on/off for a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostWorkspaceIcalToggleExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new IcalApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace

            try
            {
                // Toggle the iCal token
                string result = apiInstance.PostWorkspaceIcalToggle(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IcalApi.PostWorkspaceIcalToggle: " + e.Message );
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

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

