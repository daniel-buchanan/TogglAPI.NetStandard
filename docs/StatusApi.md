# TogglAPI.NetStandard.Api.StatusApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetStatus**](StatusApi.md#getstatus) | **GET** /status | Status


<a name="getstatus"></a>
# **GetStatus**
> string GetStatus ()

Status

Returns API status.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetStatusExample
    {
        public void main()
        {
            var apiInstance = new StatusApi();

            try
            {
                // Status
                string result = apiInstance.GetStatus();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatusApi.GetStatus: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

