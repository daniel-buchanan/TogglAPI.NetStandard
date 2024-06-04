# TogglAPI.NetStandard.Api.OrganizationRolesApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RolesProductIdOrganizationIdGet**](OrganizationRolesApi.md#rolesproductidorganizationidget) | **GET** /roles/{product_id}/{organization_id} | Get organization roles
[**RolesProductIdOrganizationIdPost**](OrganizationRolesApi.md#rolesproductidorganizationidpost) | **POST** /roles/{product_id}/{organization_id} | Create organization role
[**RolesProductIdOrganizationIdRoleIdDelete**](OrganizationRolesApi.md#rolesproductidorganizationidroleiddelete) | **DELETE** /roles/{product_id}/{organization_id}/{role_id} | Delete organization role
[**RolesProductIdOrganizationIdRoleIdDuplicatePost**](OrganizationRolesApi.md#rolesproductidorganizationidroleidduplicatepost) | **POST** /roles/{product_id}/{organization_id}/{role_id}/duplicate | Duplicate organization role
[**RolesProductIdOrganizationIdRoleIdGet**](OrganizationRolesApi.md#rolesproductidorganizationidroleidget) | **GET** /roles/{product_id}/{organization_id}/{role_id} | Get specific organization role
[**RolesProductIdOrganizationIdRoleIdPut**](OrganizationRolesApi.md#rolesproductidorganizationidroleidput) | **PUT** /roles/{product_id}/{organization_id}/{role_id} | Update organization role


<a name="rolesproductidorganizationidget"></a>
# **RolesProductIdOrganizationIdGet**
> List<RolesRole> RolesProductIdOrganizationIdGet (int? productId, int? organizationId)

Get organization roles

Retrieves all roles for a specific organization and product.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class RolesProductIdOrganizationIdGetExample
    {
        public void main()
        {
            var apiInstance = new OrganizationRolesApi();
            var productId = 56;  // int? | Product ID
            var organizationId = 56;  // int? | Organization ID

            try
            {
                // Get organization roles
                List&lt;RolesRole&gt; result = apiInstance.RolesProductIdOrganizationIdGet(productId, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationRolesApi.RolesProductIdOrganizationIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| Product ID | 
 **organizationId** | **int?**| Organization ID | 

### Return type

[**List<RolesRole>**](RolesRole.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rolesproductidorganizationidpost"></a>
# **RolesProductIdOrganizationIdPost**
> RolesRole RolesProductIdOrganizationIdPost (int? productId, int? organizationId, RolesCreateOrganizationRoleParams body)

Create organization role

Creates a new role within an organization with the specified product.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class RolesProductIdOrganizationIdPostExample
    {
        public void main()
        {
            var apiInstance = new OrganizationRolesApi();
            var productId = 56;  // int? | Product ID
            var organizationId = 56;  // int? | Organization ID
            var body = new RolesCreateOrganizationRoleParams(); // RolesCreateOrganizationRoleParams | Role creation data

            try
            {
                // Create organization role
                RolesRole result = apiInstance.RolesProductIdOrganizationIdPost(productId, organizationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationRolesApi.RolesProductIdOrganizationIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| Product ID | 
 **organizationId** | **int?**| Organization ID | 
 **body** | [**RolesCreateOrganizationRoleParams**](RolesCreateOrganizationRoleParams.md)| Role creation data | 

### Return type

[**RolesRole**](RolesRole.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rolesproductidorganizationidroleiddelete"></a>
# **RolesProductIdOrganizationIdRoleIdDelete**
> Dictionary<string, > RolesProductIdOrganizationIdRoleIdDelete (int? productId, int? organizationId, int? roleId)

Delete organization role

Deletes a specific role within an organization by role ID.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class RolesProductIdOrganizationIdRoleIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new OrganizationRolesApi();
            var productId = 56;  // int? | Product ID
            var organizationId = 56;  // int? | Organization ID
            var roleId = 56;  // int? | Role ID

            try
            {
                // Delete organization role
                Dictionary&lt;string, &gt; result = apiInstance.RolesProductIdOrganizationIdRoleIdDelete(productId, organizationId, roleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationRolesApi.RolesProductIdOrganizationIdRoleIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| Product ID | 
 **organizationId** | **int?**| Organization ID | 
 **roleId** | **int?**| Role ID | 

### Return type

[**Dictionary<string, >**](.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rolesproductidorganizationidroleidduplicatepost"></a>
# **RolesProductIdOrganizationIdRoleIdDuplicatePost**
> RolesRole RolesProductIdOrganizationIdRoleIdDuplicatePost (int? productId, int? organizationId, int? roleId, RolesDuplicateOrganizationRoleParams body)

Duplicate organization role

Duplicates a specific role within an organization by role ID with a new code.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class RolesProductIdOrganizationIdRoleIdDuplicatePostExample
    {
        public void main()
        {
            var apiInstance = new OrganizationRolesApi();
            var productId = 56;  // int? | Product ID
            var organizationId = 56;  // int? | Organization ID
            var roleId = 56;  // int? | Role ID
            var body = new RolesDuplicateOrganizationRoleParams(); // RolesDuplicateOrganizationRoleParams | Role duplication data

            try
            {
                // Duplicate organization role
                RolesRole result = apiInstance.RolesProductIdOrganizationIdRoleIdDuplicatePost(productId, organizationId, roleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationRolesApi.RolesProductIdOrganizationIdRoleIdDuplicatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| Product ID | 
 **organizationId** | **int?**| Organization ID | 
 **roleId** | **int?**| Role ID | 
 **body** | [**RolesDuplicateOrganizationRoleParams**](RolesDuplicateOrganizationRoleParams.md)| Role duplication data | 

### Return type

[**RolesRole**](RolesRole.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rolesproductidorganizationidroleidget"></a>
# **RolesProductIdOrganizationIdRoleIdGet**
> RolesRole RolesProductIdOrganizationIdRoleIdGet (int? productId, int? organizationId, int? roleId)

Get specific organization role

Retrieves a specific role by ID for a given organization and product.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class RolesProductIdOrganizationIdRoleIdGetExample
    {
        public void main()
        {
            var apiInstance = new OrganizationRolesApi();
            var productId = 56;  // int? | Product ID
            var organizationId = 56;  // int? | Organization ID
            var roleId = 56;  // int? | Role ID

            try
            {
                // Get specific organization role
                RolesRole result = apiInstance.RolesProductIdOrganizationIdRoleIdGet(productId, organizationId, roleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationRolesApi.RolesProductIdOrganizationIdRoleIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| Product ID | 
 **organizationId** | **int?**| Organization ID | 
 **roleId** | **int?**| Role ID | 

### Return type

[**RolesRole**](RolesRole.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rolesproductidorganizationidroleidput"></a>
# **RolesProductIdOrganizationIdRoleIdPut**
> RolesRole RolesProductIdOrganizationIdRoleIdPut (int? productId, int? organizationId, int? roleId, RolesUpdateOrganizationRoleParams body)

Update organization role

Updates an existing role within an organization by role ID.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class RolesProductIdOrganizationIdRoleIdPutExample
    {
        public void main()
        {
            var apiInstance = new OrganizationRolesApi();
            var productId = 56;  // int? | Product ID
            var organizationId = 56;  // int? | Organization ID
            var roleId = 56;  // int? | Role ID
            var body = new RolesUpdateOrganizationRoleParams(); // RolesUpdateOrganizationRoleParams | Role update data

            try
            {
                // Update organization role
                RolesRole result = apiInstance.RolesProductIdOrganizationIdRoleIdPut(productId, organizationId, roleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationRolesApi.RolesProductIdOrganizationIdRoleIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| Product ID | 
 **organizationId** | **int?**| Organization ID | 
 **roleId** | **int?**| Role ID | 
 **body** | [**RolesUpdateOrganizationRoleParams**](RolesUpdateOrganizationRoleParams.md)| Role update data | 

### Return type

[**RolesRole**](RolesRole.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

