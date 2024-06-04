# TogglAPI.NetStandard.Api.TasksApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteWorkspaceProjectTask**](TasksApi.md#deleteworkspaceprojecttask) | **DELETE** /workspaces/{workspace_id}/projects/{project_id}/tasks/{task_id} | WorkspaceProjectTask
[**GetWorkspaceProjectTask**](TasksApi.md#getworkspaceprojecttask) | **GET** /workspaces/{workspace_id}/projects/{project_id}/tasks/{task_id} | WorkspaceProjectTask
[**GetWorkspaceProjectTasks**](TasksApi.md#getworkspaceprojecttasks) | **GET** /workspaces/{workspace_id}/projects/{project_id}/tasks | WorkspaceProjectTasks
[**GetWorkspaceTasks**](TasksApi.md#getworkspacetasks) | **GET** /workspaces/{workspace_id}/tasks | Tasks
[**PatchWorkspaceProjectTasks**](TasksApi.md#patchworkspaceprojecttasks) | **PATCH** /workspaces/{workspace_id}/projects/{project_id}/tasks/{task_ids} | WorkspaceProjectTasks
[**PostWorkspaceProjectTasks**](TasksApi.md#postworkspaceprojecttasks) | **POST** /workspaces/{workspace_id}/projects/{project_id}/tasks | WorkspaceProjectTasks
[**PutWorkspaceProjectTask**](TasksApi.md#putworkspaceprojecttask) | **PUT** /workspaces/{workspace_id}/projects/{project_id}/tasks/{task_id} | WorkspaceProjectTask


<a name="deleteworkspaceprojecttask"></a>
# **DeleteWorkspaceProjectTask**
> string DeleteWorkspaceProjectTask (int? workspaceId, int? projectId, int? taskId)

WorkspaceProjectTask

Delete projects task for given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteWorkspaceProjectTaskExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var projectId = 56;  // int? | Numeric ID of the project
            var taskId = 56;  // int? | Numeric ID of the task

            try
            {
                // WorkspaceProjectTask
                string result = apiInstance.DeleteWorkspaceProjectTask(workspaceId, projectId, taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.DeleteWorkspaceProjectTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **projectId** | **int?**| Numeric ID of the project | 
 **taskId** | **int?**| Numeric ID of the task | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspaceprojecttask"></a>
# **GetWorkspaceProjectTask**
> ModelsTask GetWorkspaceProjectTask (int? workspaceId, int? projectId, int? taskId)

WorkspaceProjectTask

Get project task for given task id.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceProjectTaskExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var projectId = 56;  // int? | Numeric ID of the project
            var taskId = 56;  // int? | Numeric ID of the task

            try
            {
                // WorkspaceProjectTask
                ModelsTask result = apiInstance.GetWorkspaceProjectTask(workspaceId, projectId, taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetWorkspaceProjectTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **projectId** | **int?**| Numeric ID of the project | 
 **taskId** | **int?**| Numeric ID of the task | 

### Return type

[**ModelsTask**](ModelsTask.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspaceprojecttasks"></a>
# **GetWorkspaceProjectTasks**
> ModelsTask GetWorkspaceProjectTasks (int? workspaceId, int? projectId)

WorkspaceProjectTasks

Get project tasks for given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceProjectTasksExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var projectId = 56;  // int? | Numeric ID of the project

            try
            {
                // WorkspaceProjectTasks
                ModelsTask result = apiInstance.GetWorkspaceProjectTasks(workspaceId, projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetWorkspaceProjectTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **projectId** | **int?**| Numeric ID of the project | 

### Return type

[**ModelsTask**](ModelsTask.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacetasks"></a>
# **GetWorkspaceTasks**
> TaskResponse GetWorkspaceTasks (int? workspaceId, int? since = null, int? page = null, int? perPage = null, string sortOrder = null, string sortField = null, bool? active = null, int? pid = null, DateTime? startDate = null, DateTime? endDate = null)

Tasks

List Workspace tasks.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceTasksExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var since = 56;  // int? | Retrieve tasks created/modified/deleted since this date using UNIX timestamp. (optional) 
            var page = 56;  // int? | Page number, default 1 (optional) 
            var perPage = 56;  // int? | Number of items per page, default 50 (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order, default ASC (optional) 
            var sortField = sortField_example;  // string | Field used for sorting. Default is name. Valid values are 'name' and 'created_at' (optional) 
            var active = true;  // bool? | Filter by active state. You can also pass 'both' to get both active and inactive tasks. (optional) 
            var pid = 56;  // int? | Filter by project id (optional) 
            var startDate = 2013-10-20;  // DateTime? | Smallest boundary date in the format YYYY-MM-DD (optional) 
            var endDate = 2013-10-20;  // DateTime? | Biggest boundary date in the format YYYY-MM-DD (optional) 

            try
            {
                // Tasks
                TaskResponse result = apiInstance.GetWorkspaceTasks(workspaceId, since, page, perPage, sortOrder, sortField, active, pid, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetWorkspaceTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **since** | **int?**| Retrieve tasks created/modified/deleted since this date using UNIX timestamp. | [optional] 
 **page** | **int?**| Page number, default 1 | [optional] 
 **perPage** | **int?**| Number of items per page, default 50 | [optional] 
 **sortOrder** | **string**| Sort order, default ASC | [optional] 
 **sortField** | **string**| Field used for sorting. Default is name. Valid values are &#39;name&#39; and &#39;created_at&#39; | [optional] 
 **active** | **bool?**| Filter by active state. You can also pass &#39;both&#39; to get both active and inactive tasks. | [optional] 
 **pid** | **int?**| Filter by project id | [optional] 
 **startDate** | **DateTime?**| Smallest boundary date in the format YYYY-MM-DD | [optional] 
 **endDate** | **DateTime?**| Biggest boundary date in the format YYYY-MM-DD | [optional] 

### Return type

[**TaskResponse**](TaskResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchworkspaceprojecttasks"></a>
# **PatchWorkspaceProjectTasks**
> TaskPatchOutput PatchWorkspaceProjectTasks (int? workspaceId, int? projectId, string taskIds, List<TaskPatchInput> patchInput)

WorkspaceProjectTasks

Patch project tasks for given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PatchWorkspaceProjectTasksExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var projectId = 56;  // int? | Numeric ID of the project
            var taskIds = taskIds_example;  // string | Numeric IDs of project tasks separated by comma
            var patchInput = new List<TaskPatchInput>(); // List<TaskPatchInput> | Patch operations

            try
            {
                // WorkspaceProjectTasks
                TaskPatchOutput result = apiInstance.PatchWorkspaceProjectTasks(workspaceId, projectId, taskIds, patchInput);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.PatchWorkspaceProjectTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **projectId** | **int?**| Numeric ID of the project | 
 **taskIds** | **string**| Numeric IDs of project tasks separated by comma | 
 **patchInput** | [**List&lt;TaskPatchInput&gt;**](TaskPatchInput.md)| Patch operations | 

### Return type

[**TaskPatchOutput**](TaskPatchOutput.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postworkspaceprojecttasks"></a>
# **PostWorkspaceProjectTasks**
> ModelsTask PostWorkspaceProjectTasks (int? workspaceId, int? projectId, TaskPayload postInput)

WorkspaceProjectTasks

Post project tasks for given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostWorkspaceProjectTasksExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var projectId = 56;  // int? | Numeric ID of the project
            var postInput = new TaskPayload(); // TaskPayload | Post parameters

            try
            {
                // WorkspaceProjectTasks
                ModelsTask result = apiInstance.PostWorkspaceProjectTasks(workspaceId, projectId, postInput);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.PostWorkspaceProjectTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **projectId** | **int?**| Numeric ID of the project | 
 **postInput** | [**TaskPayload**](TaskPayload.md)| Post parameters | 

### Return type

[**ModelsTask**](ModelsTask.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putworkspaceprojecttask"></a>
# **PutWorkspaceProjectTask**
> ModelsTask PutWorkspaceProjectTask (int? workspaceId, int? projectId, string taskId, TaskPayload patchInput)

WorkspaceProjectTask

Put project task for given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutWorkspaceProjectTaskExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var projectId = 56;  // int? | Numeric ID of the project
            var taskId = taskId_example;  // string | Numeric ID of project task
            var patchInput = new TaskPayload(); // TaskPayload | Put parameters

            try
            {
                // WorkspaceProjectTask
                ModelsTask result = apiInstance.PutWorkspaceProjectTask(workspaceId, projectId, taskId, patchInput);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.PutWorkspaceProjectTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **projectId** | **int?**| Numeric ID of the project | 
 **taskId** | **string**| Numeric ID of project task | 
 **patchInput** | [**TaskPayload**](TaskPayload.md)| Put parameters | 

### Return type

[**ModelsTask**](ModelsTask.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

