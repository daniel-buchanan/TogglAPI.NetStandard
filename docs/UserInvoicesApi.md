# TogglAPI.NetStandard.Api.UserInvoicesApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteWorkspaceInvoice**](UserInvoicesApi.md#deleteworkspaceinvoice) | **DELETE** /workspaces/{workspace_id}/invoices/{user_invoice_id} | Delete user invoice.
[**GetWorkspaceInvoices**](UserInvoicesApi.md#getworkspaceinvoices) | **GET** /workspaces/{workspace_id}/invoices | Get workspace invoices.
[**PostWorkspaceUserInvoice**](UserInvoicesApi.md#postworkspaceuserinvoice) | **POST** /workspaces/{workspace_id}/invoices | Create user invoice


<a name="deleteworkspaceinvoice"></a>
# **DeleteWorkspaceInvoice**
> string DeleteWorkspaceInvoice (int? workspaceId, int? userInvoiceId)

Delete user invoice.

Deletes user invoice by ID if exists.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteWorkspaceInvoiceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UserInvoicesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var userInvoiceId = 56;  // int? | User invoice ID to be deleted

            try
            {
                // Delete user invoice.
                string result = apiInstance.DeleteWorkspaceInvoice(workspaceId, userInvoiceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserInvoicesApi.DeleteWorkspaceInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **userInvoiceId** | **int?**| User invoice ID to be deleted | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspaceinvoices"></a>
# **GetWorkspaceInvoices**
> List<ModelsUserInvoice> GetWorkspaceInvoices (string sortOrder = null, int? perPage = null, int? page = null, string sortField = null)

Get workspace invoices.

Get invoices for given workspace with pagination.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceInvoicesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UserInvoicesApi();
            var sortOrder = sortOrder_example;  // string | Sort order, default ASC. (optional) 
            var perPage = 56;  // int? | Number of items per page, default 50. (optional) 
            var page = 56;  // int? | Page number, default 1. (optional) 
            var sortField = sortField_example;  // string | Sort field, default created_at. (optional) 

            try
            {
                // Get workspace invoices.
                List&lt;ModelsUserInvoice&gt; result = apiInstance.GetWorkspaceInvoices(sortOrder, perPage, page, sortField);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserInvoicesApi.GetWorkspaceInvoices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sortOrder** | **string**| Sort order, default ASC. | [optional] 
 **perPage** | **int?**| Number of items per page, default 50. | [optional] 
 **page** | **int?**| Page number, default 1. | [optional] 
 **sortField** | **string**| Sort field, default created_at. | [optional] 

### Return type

[**List<ModelsUserInvoice>**](ModelsUserInvoice.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postworkspaceuserinvoice"></a>
# **PostWorkspaceUserInvoice**
> List<ModelsUserInvoice> PostWorkspaceUserInvoice (int? workspaceId, ModelsUserInvoice tagPost)

Create user invoice

Creates new user invoice.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostWorkspaceUserInvoiceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UserInvoicesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var tagPost = new ModelsUserInvoice(); // ModelsUserInvoice | Post data

            try
            {
                // Create user invoice
                List&lt;ModelsUserInvoice&gt; result = apiInstance.PostWorkspaceUserInvoice(workspaceId, tagPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserInvoicesApi.PostWorkspaceUserInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **tagPost** | [**ModelsUserInvoice**](ModelsUserInvoice.md)| Post data | 

### Return type

[**List<ModelsUserInvoice>**](ModelsUserInvoice.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

