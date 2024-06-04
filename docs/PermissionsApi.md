# TogglAPI.NetStandard.Api.PermissionsApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PermissionsProductIdGet**](PermissionsApi.md#permissionsproductidget) | **GET** /permissions/{product_id} | Get permissions


<a name="permissionsproductidget"></a>
# **PermissionsProductIdGet**
> List<RolesPermission> PermissionsProductIdGet (int? productId)

Get permissions

Retrieves permissions based on product ID.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PermissionsProductIdGetExample
    {
        public void main()
        {
            var apiInstance = new PermissionsApi();
            var productId = 56;  // int? | Product ID

            try
            {
                // Get permissions
                List&lt;RolesPermission&gt; result = apiInstance.PermissionsProductIdGet(productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionsApi.PermissionsProductIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| Product ID | 

### Return type

[**List<RolesPermission>**](RolesPermission.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

