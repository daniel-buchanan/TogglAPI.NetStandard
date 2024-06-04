# TogglAPI.NetStandard.Api.RolesApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RolesProductIdFindPost**](RolesApi.md#rolesproductidfindpost) | **POST** /roles/{product_id}/find | Find role
[**RolesProductIdGet**](RolesApi.md#rolesproductidget) | **GET** /roles/{product_id} | Get roles


<a name="rolesproductidfindpost"></a>
# **RolesProductIdFindPost**
> RolesRole RolesProductIdFindPost (int? productId, RolesFindRoleParams body)

Find role

Finds a role within a product by code, optional organization ID.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class RolesProductIdFindPostExample
    {
        public void main()
        {
            var apiInstance = new RolesApi();
            var productId = 56;  // int? | Product ID
            var body = new RolesFindRoleParams(); // RolesFindRoleParams | Role find data

            try
            {
                // Find role
                RolesRole result = apiInstance.RolesProductIdFindPost(productId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.RolesProductIdFindPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| Product ID | 
 **body** | [**RolesFindRoleParams**](RolesFindRoleParams.md)| Role find data | 

### Return type

[**RolesRole**](RolesRole.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rolesproductidget"></a>
# **RolesProductIdGet**
> List<RolesRole> RolesProductIdGet (int? productId)

Get roles

Retrieves roles based on product ID.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class RolesProductIdGetExample
    {
        public void main()
        {
            var apiInstance = new RolesApi();
            var productId = 56;  // int? | Product ID

            try
            {
                // Get roles
                List&lt;RolesRole&gt; result = apiInstance.RolesProductIdGet(productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.RolesProductIdGet: " + e.Message );
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

[**List<RolesRole>**](RolesRole.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

