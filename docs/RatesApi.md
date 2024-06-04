# TogglAPI.NetStandard.Api.RatesApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRate**](RatesApi.md#createrate) | **POST** /workspaces/{workspace_id}/rates | Rates creation
[**DeleteRate**](RatesApi.md#deleterate) | **DELETE** /workspaces/{workspace_id}/rates/{rate_id} | Rates delete
[**GetRatesByLevel**](RatesApi.md#getratesbylevel) | **GET** /workspaces/{workspace_id}/rates/{level}/{level_id} | Rates list


<a name="createrate"></a>
# **CreateRate**
> DtoGetResponse CreateRate (int? workspaceId, DtoCreationRequest ratePost)

Rates creation

Creates a new rate.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class CreateRateExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RatesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var ratePost = new DtoCreationRequest(); // DtoCreationRequest | Rate attributes

            try
            {
                // Rates creation
                DtoGetResponse result = apiInstance.CreateRate(workspaceId, ratePost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RatesApi.CreateRate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **ratePost** | [**DtoCreationRequest**](DtoCreationRequest.md)| Rate attributes | 

### Return type

[**DtoGetResponse**](DtoGetResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterate"></a>
# **DeleteRate**
> void DeleteRate (int? workspaceId, int? rateId)

Rates delete

Removes a rate.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteRateExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RatesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var rateId = 56;  // int? | Numeric ID of the rate

            try
            {
                // Rates delete
                apiInstance.DeleteRate(workspaceId, rateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RatesApi.DeleteRate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **rateId** | **int?**| Numeric ID of the rate | 

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getratesbylevel"></a>
# **GetRatesByLevel**
> List<DtoGetResponse> GetRatesByLevel (int? workspaceId, string level, int? levelId)

Rates list

Get rates by level(workspace|project|user).

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetRatesByLevelExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RatesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var level = level_example;  // string | Rates level: workspace, project or user
            var levelId = 56;  // int? | Numeric ID of the entity level

            try
            {
                // Rates list
                List&lt;DtoGetResponse&gt; result = apiInstance.GetRatesByLevel(workspaceId, level, levelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RatesApi.GetRatesByLevel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **level** | **string**| Rates level: workspace, project or user | 
 **levelId** | **int?**| Numeric ID of the entity level | 

### Return type

[**List<DtoGetResponse>**](DtoGetResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

