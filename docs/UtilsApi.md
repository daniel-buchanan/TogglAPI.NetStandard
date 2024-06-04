# TogglAPI.NetStandard.Api.UtilsApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReportsApiV3WorkspaceWorkspaceIdActionTasksPost**](UtilsApi.md#reportsapiv3workspaceworkspaceidactiontaskspost) | **POST** /reports/api/v3/workspace/{workspace_id}/{action}/tasks | List tasks
[**ReportsApiV3WorkspaceWorkspaceIdFiltersClientsPost**](UtilsApi.md#reportsapiv3workspaceworkspaceidfiltersclientspost) | **POST** /reports/api/v3/workspace/{workspace_id}/filters/clients | List clients
[**ReportsApiV3WorkspaceWorkspaceIdFiltersProjectGroupsPost**](UtilsApi.md#reportsapiv3workspaceworkspaceidfiltersprojectgroupspost) | **POST** /reports/api/v3/workspace/{workspace_id}/filters/project_groups | List project groups filter
[**ReportsApiV3WorkspaceWorkspaceIdFiltersProjectUsersPost**](UtilsApi.md#reportsapiv3workspaceworkspaceidfiltersprojectuserspost) | **POST** /reports/api/v3/workspace/{workspace_id}/filters/project_users | List project users
[**ReportsApiV3WorkspaceWorkspaceIdFiltersProjectsPost**](UtilsApi.md#reportsapiv3workspaceworkspaceidfiltersprojectspost) | **POST** /reports/api/v3/workspace/{workspace_id}/filters/projects | List projects
[**ReportsApiV3WorkspaceWorkspaceIdFiltersProjectsStatusPost**](UtilsApi.md#reportsapiv3workspaceworkspaceidfiltersprojectsstatuspost) | **POST** /reports/api/v3/workspace/{workspace_id}/filters/projects/status | List projects statuses
[**ReportsApiV3WorkspaceWorkspaceIdFiltersTasksStatusPost**](UtilsApi.md#reportsapiv3workspaceworkspaceidfilterstasksstatuspost) | **POST** /reports/api/v3/workspace/{workspace_id}/filters/tasks/status | List tasks statuses
[**ReportsApiV3WorkspaceWorkspaceIdFiltersUsersPost**](UtilsApi.md#reportsapiv3workspaceworkspaceidfiltersuserspost) | **POST** /reports/api/v3/workspace/{workspace_id}/filters/users | List users
[**ReportsApiV3WorkspaceWorkspaceIdSearchClientsPost**](UtilsApi.md#reportsapiv3workspaceworkspaceidsearchclientspost) | **POST** /reports/api/v3/workspace/{workspace_id}/search/clients | Search clients
[**ReportsApiV3WorkspaceWorkspaceIdSearchProjectsPost**](UtilsApi.md#reportsapiv3workspaceworkspaceidsearchprojectspost) | **POST** /reports/api/v3/workspace/{workspace_id}/search/projects | List projects
[**ReportsApiV3WorkspaceWorkspaceIdSearchUsersPost**](UtilsApi.md#reportsapiv3workspaceworkspaceidsearchuserspost) | **POST** /reports/api/v3/workspace/{workspace_id}/search/users | List users


<a name="reportsapiv3workspaceworkspaceidactiontaskspost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdActionTasksPost**
> List<ModelsTask> ReportsApiV3WorkspaceWorkspaceIdActionTasksPost (int? workspaceId, string action, TasksTasksPost tasksPost = null)

List tasks

Returns filtered tasks from workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdActionTasksPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UtilsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var action = action_example;  // string | search,filters
            var tasksPost = new TasksTasksPost(); // TasksTasksPost | Task search conditions (optional) 

            try
            {
                // List tasks
                List&lt;ModelsTask&gt; result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdActionTasksPost(workspaceId, action, tasksPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilsApi.ReportsApiV3WorkspaceWorkspaceIdActionTasksPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **action** | **string**| search,filters | 
 **tasksPost** | [**TasksTasksPost**](TasksTasksPost.md)| Task search conditions | [optional] 

### Return type

[**List<ModelsTask>**](ModelsTask.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3workspaceworkspaceidfiltersclientspost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdFiltersClientsPost**
> List<DtoClientFilterResponse> ReportsApiV3WorkspaceWorkspaceIdFiltersClientsPost (int? workspaceId, DtoClientFilterParamsRequest clientsPost = null)

List clients

Returns filtered clients from a workspace (only ID and name).

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdFiltersClientsPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UtilsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var clientsPost = new DtoClientFilterParamsRequest(); // DtoClientFilterParamsRequest | Clients filter conditions (optional) 

            try
            {
                // List clients
                List&lt;DtoClientFilterResponse&gt; result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdFiltersClientsPost(workspaceId, clientsPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilsApi.ReportsApiV3WorkspaceWorkspaceIdFiltersClientsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **clientsPost** | [**DtoClientFilterParamsRequest**](DtoClientFilterParamsRequest.md)| Clients filter conditions | [optional] 

### Return type

[**List<DtoClientFilterResponse>**](DtoClientFilterResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3workspaceworkspaceidfiltersprojectgroupspost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdFiltersProjectGroupsPost**
> List<DtoProjectGroupResponse> ReportsApiV3WorkspaceWorkspaceIdFiltersProjectGroupsPost (int? workspaceId, DtoProjectGroupParamsRequest projectGroupsParams = null)

List project groups filter

Returns the project groups from a workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdFiltersProjectGroupsPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UtilsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var projectGroupsParams = new DtoProjectGroupParamsRequest(); // DtoProjectGroupParamsRequest | Project groups filter conditions (optional) 

            try
            {
                // List project groups filter
                List&lt;DtoProjectGroupResponse&gt; result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdFiltersProjectGroupsPost(workspaceId, projectGroupsParams);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilsApi.ReportsApiV3WorkspaceWorkspaceIdFiltersProjectGroupsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **projectGroupsParams** | [**DtoProjectGroupParamsRequest**](DtoProjectGroupParamsRequest.md)| Project groups filter conditions | [optional] 

### Return type

[**List<DtoProjectGroupResponse>**](DtoProjectGroupResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3workspaceworkspaceidfiltersprojectuserspost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdFiltersProjectUsersPost**
> List<DtoProjectUserResponse> ReportsApiV3WorkspaceWorkspaceIdFiltersProjectUsersPost (int? workspaceId, DtoProjectUserParamsRequest statusPost)

List project users

Returns filtered user projects.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdFiltersProjectUsersPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UtilsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var statusPost = new DtoProjectUserParamsRequest(); // DtoProjectUserParamsRequest | User projects filter conditions

            try
            {
                // List project users
                List&lt;DtoProjectUserResponse&gt; result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdFiltersProjectUsersPost(workspaceId, statusPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilsApi.ReportsApiV3WorkspaceWorkspaceIdFiltersProjectUsersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **statusPost** | [**DtoProjectUserParamsRequest**](DtoProjectUserParamsRequest.md)| User projects filter conditions | 

### Return type

[**List<DtoProjectUserResponse>**](DtoProjectUserResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3workspaceworkspaceidfiltersprojectspost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdFiltersProjectsPost**
> List<DtoProjectFilterResponse> ReportsApiV3WorkspaceWorkspaceIdFiltersProjectsPost (int? workspaceId, DtoProjectFilterParamRequest projectsPost = null)

List projects

Returns filtered projects from a workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdFiltersProjectsPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UtilsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var projectsPost = new DtoProjectFilterParamRequest(); // DtoProjectFilterParamRequest | Projects filter conditions (optional) 

            try
            {
                // List projects
                List&lt;DtoProjectFilterResponse&gt; result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdFiltersProjectsPost(workspaceId, projectsPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilsApi.ReportsApiV3WorkspaceWorkspaceIdFiltersProjectsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **projectsPost** | [**DtoProjectFilterParamRequest**](DtoProjectFilterParamRequest.md)| Projects filter conditions | [optional] 

### Return type

[**List<DtoProjectFilterResponse>**](DtoProjectFilterResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3workspaceworkspaceidfiltersprojectsstatuspost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdFiltersProjectsStatusPost**
> List<StatusProjectStatus> ReportsApiV3WorkspaceWorkspaceIdFiltersProjectsStatusPost (int? workspaceId, StatusStatusPost statusPost = null)

List projects statuses

Returns filtered projects statuses from a workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdFiltersProjectsStatusPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UtilsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var statusPost = new StatusStatusPost(); // StatusStatusPost | Projects statuses filter conditions (optional) 

            try
            {
                // List projects statuses
                List&lt;StatusProjectStatus&gt; result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdFiltersProjectsStatusPost(workspaceId, statusPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilsApi.ReportsApiV3WorkspaceWorkspaceIdFiltersProjectsStatusPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **statusPost** | [**StatusStatusPost**](StatusStatusPost.md)| Projects statuses filter conditions | [optional] 

### Return type

[**List<StatusProjectStatus>**](StatusProjectStatus.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3workspaceworkspaceidfilterstasksstatuspost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdFiltersTasksStatusPost**
> List<TasksTaskStatus> ReportsApiV3WorkspaceWorkspaceIdFiltersTasksStatusPost (int? workspaceId, TasksTasksStatusPost tasksStatusPost)

List tasks statuses

Filter tasks statuses from a workspace

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdFiltersTasksStatusPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UtilsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var tasksStatusPost = new TasksTasksStatusPost(); // TasksTasksStatusPost | Task filter conditions

            try
            {
                // List tasks statuses
                List&lt;TasksTaskStatus&gt; result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdFiltersTasksStatusPost(workspaceId, tasksStatusPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilsApi.ReportsApiV3WorkspaceWorkspaceIdFiltersTasksStatusPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **tasksStatusPost** | [**TasksTasksStatusPost**](TasksTasksStatusPost.md)| Task filter conditions | 

### Return type

[**List<TasksTaskStatus>**](TasksTaskStatus.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3workspaceworkspaceidfiltersuserspost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdFiltersUsersPost**
> List<DtoUserFilterResponse> ReportsApiV3WorkspaceWorkspaceIdFiltersUsersPost (int? workspaceId, DtoUserFilterParamsRequest usersFilter = null)

List users

Returns filtered users from a workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdFiltersUsersPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UtilsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var usersFilter = new DtoUserFilterParamsRequest(); // DtoUserFilterParamsRequest | Users filter conditions (optional) 

            try
            {
                // List users
                List&lt;DtoUserFilterResponse&gt; result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdFiltersUsersPost(workspaceId, usersFilter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilsApi.ReportsApiV3WorkspaceWorkspaceIdFiltersUsersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **usersFilter** | [**DtoUserFilterParamsRequest**](DtoUserFilterParamsRequest.md)| Users filter conditions | [optional] 

### Return type

[**List<DtoUserFilterResponse>**](DtoUserFilterResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3workspaceworkspaceidsearchclientspost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdSearchClientsPost**
> List<DtoClientFilterResponse> ReportsApiV3WorkspaceWorkspaceIdSearchClientsPost (int? workspaceId, DtoClientFilterParamsRequest clientsPost)

Search clients

Returns filtered clients from a workspace (whole client object).

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdSearchClientsPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UtilsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var clientsPost = new DtoClientFilterParamsRequest(); // DtoClientFilterParamsRequest | Clients search conditions

            try
            {
                // Search clients
                List&lt;DtoClientFilterResponse&gt; result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdSearchClientsPost(workspaceId, clientsPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilsApi.ReportsApiV3WorkspaceWorkspaceIdSearchClientsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **clientsPost** | [**DtoClientFilterParamsRequest**](DtoClientFilterParamsRequest.md)| Clients search conditions | 

### Return type

[**List<DtoClientFilterResponse>**](DtoClientFilterResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3workspaceworkspaceidsearchprojectspost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdSearchProjectsPost**
> List<Object> ReportsApiV3WorkspaceWorkspaceIdSearchProjectsPost (int? workspaceId, ProjectsProjectsPost projectsPost)

List projects

Returns filtered projects from a workspace (whole project object).

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdSearchProjectsPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UtilsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var projectsPost = new ProjectsProjectsPost(); // ProjectsProjectsPost | Projects list conditions

            try
            {
                // List projects
                List&lt;Object&gt; result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdSearchProjectsPost(workspaceId, projectsPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilsApi.ReportsApiV3WorkspaceWorkspaceIdSearchProjectsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **projectsPost** | [**ProjectsProjectsPost**](ProjectsProjectsPost.md)| Projects list conditions | 

### Return type

**List<Object>**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3workspaceworkspaceidsearchuserspost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdSearchUsersPost**
> List<DtoUserFilterResponse> ReportsApiV3WorkspaceWorkspaceIdSearchUsersPost (int? workspaceId, DtoUserFilterParamsRequest usersFilter)

List users

Returns filtered users from a workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdSearchUsersPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UtilsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var usersFilter = new DtoUserFilterParamsRequest(); // DtoUserFilterParamsRequest | Users list conditions

            try
            {
                // List users
                List&lt;DtoUserFilterResponse&gt; result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdSearchUsersPost(workspaceId, usersFilter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilsApi.ReportsApiV3WorkspaceWorkspaceIdSearchUsersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **usersFilter** | [**DtoUserFilterParamsRequest**](DtoUserFilterParamsRequest.md)| Users list conditions | 

### Return type

[**List<DtoUserFilterResponse>**](DtoUserFilterResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

