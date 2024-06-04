# TogglAPI.NetStandard.Api.ClientsApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ArchiveClient**](ClientsApi.md#archiveclient) | **POST** /workspaces/{workspace_id}/clients/{client_id}/archive | Archives client
[**DeleteWorkspaceClients**](ClientsApi.md#deleteworkspaceclients) | **DELETE** /workspaces/{workspace_id}/clients/{client_id} | Delete client
[**GetWorkspaceClient**](ClientsApi.md#getworkspaceclient) | **GET** /workspaces/{workspace_id}/clients/{client_id} | Load client from ID
[**GetWorkspaceClients**](ClientsApi.md#getworkspaceclients) | **GET** /workspaces/{workspace_id}/clients | List clients
[**PostWorkspaceClients**](ClientsApi.md#postworkspaceclients) | **POST** /workspaces/{workspace_id}/clients | Create client
[**PutWorkspaceClients**](ClientsApi.md#putworkspaceclients) | **PUT** /workspaces/{workspace_id}/clients/{client_id} | Change client
[**RestoreClient**](ClientsApi.md#restoreclient) | **POST** /workspaces/{workspace_id}/clients/{client_id}/restore | Restores client and related projects.


<a name="archiveclient"></a>
# **ArchiveClient**
> List<int?> ArchiveClient (int? workspaceId, int? clientId)

Archives client

Archives a workspace client and related projects. Only for premium workspaces.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ArchiveClientExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ClientsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var clientId = 56;  // int? | Numeric ID of the client

            try
            {
                // Archives client
                List&lt;int?&gt; result = apiInstance.ArchiveClient(workspaceId, clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.ArchiveClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **clientId** | **int?**| Numeric ID of the client | 

### Return type

**List<int?>**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteworkspaceclients"></a>
# **DeleteWorkspaceClients**
> decimal? DeleteWorkspaceClients (int? workspaceId, int? clientId)

Delete client

Delete workspace client.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteWorkspaceClientsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ClientsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var clientId = 56;  // int? | Numeric ID of the client

            try
            {
                // Delete client
                decimal? result = apiInstance.DeleteWorkspaceClients(workspaceId, clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.DeleteWorkspaceClients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **clientId** | **int?**| Numeric ID of the client | 

### Return type

**decimal?**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspaceclient"></a>
# **GetWorkspaceClient**
> ModelsClient GetWorkspaceClient (int? workspaceId, int? clientId)

Load client from ID

Load client from workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceClientExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ClientsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var clientId = 56;  // int? | Numeric ID of the client

            try
            {
                // Load client from ID
                ModelsClient result = apiInstance.GetWorkspaceClient(workspaceId, clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.GetWorkspaceClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **clientId** | **int?**| Numeric ID of the client | 

### Return type

[**ModelsClient**](ModelsClient.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspaceclients"></a>
# **GetWorkspaceClients**
> List<ModelsClient> GetWorkspaceClients (int? workspaceId, string status = null, string name = null)

List clients

List clients from workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceClientsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ClientsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var status = status_example;  // string | Use 'active' to only list active clients, 'archived' to only list archived clients and 'both' to retrieve active and archived clients. If not provided, only active clients are returned. (optional) 
            var name = name_example;  // string | If provided, allows to filter by client name in a case insensitive manner, returning all the ones that contain the given string. (optional) 

            try
            {
                // List clients
                List&lt;ModelsClient&gt; result = apiInstance.GetWorkspaceClients(workspaceId, status, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.GetWorkspaceClients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **status** | **string**| Use &#39;active&#39; to only list active clients, &#39;archived&#39; to only list archived clients and &#39;both&#39; to retrieve active and archived clients. If not provided, only active clients are returned. | [optional] 
 **name** | **string**| If provided, allows to filter by client name in a case insensitive manner, returning all the ones that contain the given string. | [optional] 

### Return type

[**List<ModelsClient>**](ModelsClient.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postworkspaceclients"></a>
# **PostWorkspaceClients**
> ModelsClient PostWorkspaceClients (int? workspaceId, ClientPayload postedClient)

Create client

Create workspace client.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostWorkspaceClientsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ClientsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var postedClient = new ClientPayload(); // ClientPayload | Client

            try
            {
                // Create client
                ModelsClient result = apiInstance.PostWorkspaceClients(workspaceId, postedClient);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.PostWorkspaceClients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **postedClient** | [**ClientPayload**](ClientPayload.md)| Client | 

### Return type

[**ModelsClient**](ModelsClient.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putworkspaceclients"></a>
# **PutWorkspaceClients**
> ModelsClient PutWorkspaceClients (int? workspaceId, int? clientId, ClientPayload postedClient)

Change client

Update workspace client.  Note: use /workspaces/{workspace_id}/clients/{client_id}/archive to archive the client and /workspaces/{workspace_id}/clients/{client_id}/restore to restore it.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutWorkspaceClientsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ClientsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var clientId = 56;  // int? | Numeric ID of the client
            var postedClient = new ClientPayload(); // ClientPayload | Client

            try
            {
                // Change client
                ModelsClient result = apiInstance.PutWorkspaceClients(workspaceId, clientId, postedClient);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.PutWorkspaceClients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **clientId** | **int?**| Numeric ID of the client | 
 **postedClient** | [**ClientPayload**](ClientPayload.md)| Client | 

### Return type

[**ModelsClient**](ModelsClient.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="restoreclient"></a>
# **RestoreClient**
> ModelsClient RestoreClient (int? workspaceId, int? clientId, ProjectRestoreParams restoreParams = null)

Restores client and related projects.

Restores client and all related or specified projects from the given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class RestoreClientExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ClientsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var clientId = 56;  // int? | Numeric ID of the client
            var restoreParams = new ProjectRestoreParams(); // ProjectRestoreParams | Specify which projects should be restored with the client (optional) 

            try
            {
                // Restores client and related projects.
                ModelsClient result = apiInstance.RestoreClient(workspaceId, clientId, restoreParams);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.RestoreClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **clientId** | **int?**| Numeric ID of the client | 
 **restoreParams** | [**ProjectRestoreParams**](ProjectRestoreParams.md)| Specify which projects should be restored with the client | [optional] 

### Return type

[**ModelsClient**](ModelsClient.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

