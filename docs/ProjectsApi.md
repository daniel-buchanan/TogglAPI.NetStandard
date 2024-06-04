# TogglAPI.NetStandard.Api.ProjectsApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteWorkspaceProject**](ProjectsApi.md#deleteworkspaceproject) | **DELETE** /workspaces/{workspace_id}/projects/{project_id} | WorkspaceProject
[**DeleteWorkspaceProjectUsers**](ProjectsApi.md#deleteworkspaceprojectusers) | **DELETE** /workspaces/{workspace_id}/project_users/{project_user_id} | Delete a project user from workspace projects users
[**GetProjects**](ProjectsApi.md#getprojects) | **GET** /workspaces/{workspace_id}/projects | WorkspaceProjects
[**GetProjectsTemplates**](ProjectsApi.md#getprojectstemplates) | **GET** /workspaces/{workspace_id}/projects/templates | WorkspaceProjectsTemplates
[**GetSharedProject**](ProjectsApi.md#getsharedproject) | **GET** /shared-project/{hash}/project | SharedProject
[**GetWorkspaceProjectPeriods**](ProjectsApi.md#getworkspaceprojectperiods) | **GET** /workspaces/{workspace_id}/projects/{project_id}/periods | Get Recurring Project Periods
[**GetWorkspaceProjectUsers**](ProjectsApi.md#getworkspaceprojectusers) | **GET** /workspaces/{workspace_id}/project_users | Get workspace projects users
[**PatchWorkspaceProjectUsersIds**](ProjectsApi.md#patchworkspaceprojectusersids) | **PATCH** /workspaces/{workspace_id}/project_users/{project_user_ids} | Patch project users from workspace
[**PatchWorkspaceProjects**](ProjectsApi.md#patchworkspaceprojects) | **PATCH** /workspaces/{workspace_id}/projects/{project_ids} | WorkspaceProjects
[**PostWorkspaceProjectCreate**](ProjectsApi.md#postworkspaceprojectcreate) | **POST** /workspaces/{workspace_id}/projects | WorkspaceProjects
[**PostWorkspaceProjectUsers**](ProjectsApi.md#postworkspaceprojectusers) | **POST** /workspaces/{workspace_id}/project_users | Add an user into workspace projects users
[**PutSharedProjectTimeEntries**](ProjectsApi.md#putsharedprojecttimeentries) | **GET** /shared-project/{hash}/time-entries | SharedProjectTimeEntry
[**PutWorkspaceProject**](ProjectsApi.md#putworkspaceproject) | **PUT** /workspaces/{workspace_id}/projects/{project_id} | WorkspaceProject
[**PutWorkspaceProjectUsers**](ProjectsApi.md#putworkspaceprojectusers) | **PUT** /workspaces/{workspace_id}/project_users/{project_user_id} | Update an user into workspace projects users
[**WorkspacesWorkspaceIdProjectsBillableAmountsPost**](ProjectsApi.md#workspacesworkspaceidprojectsbillableamountspost) | **POST** /workspaces/{workspace_id}/projects/billable-amounts | Projects
[**WorkspacesWorkspaceIdProjectsProjectIdGet**](ProjectsApi.md#workspacesworkspaceidprojectsprojectidget) | **GET** /workspaces/{workspace_id}/projects/{project_id} | WorkspaceProject
[**WorkspacesWorkspaceIdProjectsProjectIdStatisticsGet**](ProjectsApi.md#workspacesworkspaceidprojectsprojectidstatisticsget) | **GET** /workspaces/{workspace_id}/projects/{project_id}/statistics | WorkspaceProject


<a name="deleteworkspaceproject"></a>
# **DeleteWorkspaceProject**
> int? DeleteWorkspaceProject (int? workspaceId, int? projectId, string teDeletionMode = null)

WorkspaceProject

Delete project for given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteWorkspaceProjectExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProjectsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var projectId = 56;  // int? | Numeric ID of the project
            var teDeletionMode = teDeletionMode_example;  // string | Time entries deletion mode: 'delete' or 'unassign' (optional) 

            try
            {
                // WorkspaceProject
                int? result = apiInstance.DeleteWorkspaceProject(workspaceId, projectId, teDeletionMode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.DeleteWorkspaceProject: " + e.Message );
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
 **teDeletionMode** | **string**| Time entries deletion mode: &#39;delete&#39; or &#39;unassign&#39; | [optional] 

### Return type

**int?**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteworkspaceprojectusers"></a>
# **DeleteWorkspaceProjectUsers**
> int? DeleteWorkspaceProjectUsers (int? workspaceId, int? projectUserId)

Delete a project user from workspace projects users

Delete a project user for a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteWorkspaceProjectUsersExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProjectsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var projectUserId = 56;  // int? | Numeric ID of the project user

            try
            {
                // Delete a project user from workspace projects users
                int? result = apiInstance.DeleteWorkspaceProjectUsers(workspaceId, projectUserId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.DeleteWorkspaceProjectUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **projectUserId** | **int?**| Numeric ID of the project user | 

### Return type

**int?**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojects"></a>
# **GetProjects**
> List<ModelsProject> GetProjects (int? workspaceId, string name, int? page, string sortField, string sortOrder, bool? onlyTemplates, bool? active = null, int? since = null, bool? billable = null, List<string> userIds = null, List<string> clientIds = null, List<string> groupIds = null, List<string> statuses = null, bool? onlyMe = null, int? perPage = null)

WorkspaceProjects

Get projects for given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetProjectsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProjectsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var name = name_example;  // string | name
            var page = 56;  // int? | page
            var sortField = sortField_example;  // string | sort_field
            var sortOrder = sortOrder_example;  // string | sort_order
            var onlyTemplates = true;  // bool? | only_templates
            var active = true;  // bool? | Return active or inactive project. You can pass 'both' to get both active and inactive projects. (optional) 
            var since = 56;  // int? | Retrieve projects created/modified/deleted since this date using UNIX timestamp. (optional) 
            var billable = true;  // bool? | billable (optional) 
            var userIds = new List<string>(); // List<string> | user_ids (optional) 
            var clientIds = new List<string>(); // List<string> | client_ids (optional) 
            var groupIds = new List<string>(); // List<string> | group_ids (optional) 
            var statuses = new List<string>(); // List<string> | statuses (optional) 
            var onlyMe = true;  // bool? | get only projects assigned to the current user (optional) 
            var perPage = 56;  // int? | Number of items per page, default 151. Cannot exceed 200. (optional) 

            try
            {
                // WorkspaceProjects
                List&lt;ModelsProject&gt; result = apiInstance.GetProjects(workspaceId, name, page, sortField, sortOrder, onlyTemplates, active, since, billable, userIds, clientIds, groupIds, statuses, onlyMe, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.GetProjects: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **name** | **string**| name | 
 **page** | **int?**| page | 
 **sortField** | **string**| sort_field | 
 **sortOrder** | **string**| sort_order | 
 **onlyTemplates** | **bool?**| only_templates | 
 **active** | **bool?**| Return active or inactive project. You can pass &#39;both&#39; to get both active and inactive projects. | [optional] 
 **since** | **int?**| Retrieve projects created/modified/deleted since this date using UNIX timestamp. | [optional] 
 **billable** | **bool?**| billable | [optional] 
 **userIds** | [**List&lt;string&gt;**](string.md)| user_ids | [optional] 
 **clientIds** | [**List&lt;string&gt;**](string.md)| client_ids | [optional] 
 **groupIds** | [**List&lt;string&gt;**](string.md)| group_ids | [optional] 
 **statuses** | [**List&lt;string&gt;**](string.md)| statuses | [optional] 
 **onlyMe** | **bool?**| get only projects assigned to the current user | [optional] 
 **perPage** | **int?**| Number of items per page, default 151. Cannot exceed 200. | [optional] 

### Return type

[**List<ModelsProject>**](ModelsProject.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojectstemplates"></a>
# **GetProjectsTemplates**
> string GetProjectsTemplates (int? workspaceId)

WorkspaceProjectsTemplates

Get projects templates for given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetProjectsTemplatesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProjectsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace

            try
            {
                // WorkspaceProjectsTemplates
                string result = apiInstance.GetProjectsTemplates(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.GetProjectsTemplates: " + e.Message );
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

<a name="getsharedproject"></a>
# **GetSharedProject**
> List<ModelsSharedProject> GetSharedProject (string hash)

SharedProject

Get shared project for the given hash.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetSharedProjectExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProjectsApi();
            var hash = hash_example;  // string | Share hash identifier

            try
            {
                // SharedProject
                List&lt;ModelsSharedProject&gt; result = apiInstance.GetSharedProject(hash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.GetSharedProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hash** | **string**| Share hash identifier | 

### Return type

[**List<ModelsSharedProject>**](ModelsSharedProject.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspaceprojectperiods"></a>
# **GetWorkspaceProjectPeriods**
> ModelsRecurringPeriod GetWorkspaceProjectPeriods (int? workspaceId, int? projectId, string startDate = null, string endDate = null)

Get Recurring Project Periods

Get recurring project periods for given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceProjectPeriodsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProjectsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var projectId = 56;  // int? | Numeric ID of the project
            var startDate = startDate_example;  // string | Smallest boundary date to search for recurring periods (optional) 
            var endDate = endDate_example;  // string | Biggest boundary date to search for for recurring periods (optional) 

            try
            {
                // Get Recurring Project Periods
                ModelsRecurringPeriod result = apiInstance.GetWorkspaceProjectPeriods(workspaceId, projectId, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.GetWorkspaceProjectPeriods: " + e.Message );
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
 **startDate** | **string**| Smallest boundary date to search for recurring periods | [optional] 
 **endDate** | **string**| Biggest boundary date to search for for recurring periods | [optional] 

### Return type

[**ModelsRecurringPeriod**](ModelsRecurringPeriod.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspaceprojectusers"></a>
# **GetWorkspaceProjectUsers**
> List<ModelsProjectUser> GetWorkspaceProjectUsers (int? workspaceId, string projectIds = null, bool? withGroupMembers = null)

Get workspace projects users

List all projects users for a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceProjectUsersExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProjectsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var projectIds = projectIds_example;  // string | Numeric IDs of projects, comma-separated (optional) 
            var withGroupMembers = true;  // bool? | Include group members (optional) 

            try
            {
                // Get workspace projects users
                List&lt;ModelsProjectUser&gt; result = apiInstance.GetWorkspaceProjectUsers(workspaceId, projectIds, withGroupMembers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.GetWorkspaceProjectUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **projectIds** | **string**| Numeric IDs of projects, comma-separated | [optional] 
 **withGroupMembers** | **bool?**| Include group members | [optional] 

### Return type

[**List<ModelsProjectUser>**](ModelsProjectUser.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchworkspaceprojectusersids"></a>
# **PatchWorkspaceProjectUsersIds**
> UserOutput PatchWorkspaceProjectUsersIds (int? workspaceId, List<int?> projectUserIds)

Patch project users from workspace

Patch a list of project users for a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PatchWorkspaceProjectUsersIdsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProjectsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var projectUserIds = new List<int?>(); // List<int?> | Numeric IDs of the project users

            try
            {
                // Patch project users from workspace
                UserOutput result = apiInstance.PatchWorkspaceProjectUsersIds(workspaceId, projectUserIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.PatchWorkspaceProjectUsersIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **projectUserIds** | [**List&lt;int?&gt;**](int?.md)| Numeric IDs of the project users | 

### Return type

[**UserOutput**](UserOutput.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchworkspaceprojects"></a>
# **PatchWorkspaceProjects**
> ProjectsPatchOutput PatchWorkspaceProjects (int? workspaceId, string projectIds, ProjectsPatchPost patchInput)

WorkspaceProjects

Bulk editing workspace projects.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PatchWorkspaceProjectsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProjectsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var projectIds = projectIds_example;  // string | Numeric IDs of project ids, separated by comma. E.g.: `204301830,202700150,202687559`
            var patchInput = new ProjectsPatchPost(); // ProjectsPatchPost | Array of batch operations

            try
            {
                // WorkspaceProjects
                ProjectsPatchOutput result = apiInstance.PatchWorkspaceProjects(workspaceId, projectIds, patchInput);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.PatchWorkspaceProjects: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **projectIds** | **string**| Numeric IDs of project ids, separated by comma. E.g.: &#x60;204301830,202700150,202687559&#x60; | 
 **patchInput** | [**ProjectsPatchPost**](ProjectsPatchPost.md)| Array of batch operations | 

### Return type

[**ProjectsPatchOutput**](ProjectsPatchOutput.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postworkspaceprojectcreate"></a>
# **PostWorkspaceProjectCreate**
> ModelsProject PostWorkspaceProjectCreate (int? workspaceId, ProjectPayload postInput)

WorkspaceProjects

Create project for given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostWorkspaceProjectCreateExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProjectsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var postInput = new ProjectPayload(); // ProjectPayload | Post parameters

            try
            {
                // WorkspaceProjects
                ModelsProject result = apiInstance.PostWorkspaceProjectCreate(workspaceId, postInput);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.PostWorkspaceProjectCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **postInput** | [**ProjectPayload**](ProjectPayload.md)| Post parameters | 

### Return type

[**ModelsProject**](ModelsProject.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postworkspaceprojectusers"></a>
# **PostWorkspaceProjectUsers**
> ModelsProjectUser PostWorkspaceProjectUsers (int? workspaceId, UserPostPayload projectUser)

Add an user into workspace projects users

Include a project user for a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostWorkspaceProjectUsersExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProjectsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var projectUser = new UserPostPayload(); // UserPostPayload | Input data of the user.

            try
            {
                // Add an user into workspace projects users
                ModelsProjectUser result = apiInstance.PostWorkspaceProjectUsers(workspaceId, projectUser);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.PostWorkspaceProjectUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **projectUser** | [**UserPostPayload**](UserPostPayload.md)| Input data of the user. | 

### Return type

[**ModelsProjectUser**](ModelsProjectUser.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putsharedprojecttimeentries"></a>
# **PutSharedProjectTimeEntries**
> ModelsTimeEntry PutSharedProjectTimeEntries (string hash, TimeentryPayload workspaceTimeEntryPut)

SharedProjectTimeEntry

Create time-entry in shared project for the given hash.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutSharedProjectTimeEntriesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProjectsApi();
            var hash = hash_example;  // string | Share hash identifier
            var workspaceTimeEntryPut = new TimeentryPayload(); // TimeentryPayload | TimeEntry parameters.

            try
            {
                // SharedProjectTimeEntry
                ModelsTimeEntry result = apiInstance.PutSharedProjectTimeEntries(hash, workspaceTimeEntryPut);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.PutSharedProjectTimeEntries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hash** | **string**| Share hash identifier | 
 **workspaceTimeEntryPut** | [**TimeentryPayload**](TimeentryPayload.md)| TimeEntry parameters. | 

### Return type

[**ModelsTimeEntry**](ModelsTimeEntry.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putworkspaceproject"></a>
# **PutWorkspaceProject**
> ModelsProject PutWorkspaceProject (int? workspaceId, int? projectId, ProjectPayload postInput)

WorkspaceProject

Update project for given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutWorkspaceProjectExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProjectsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var projectId = 56;  // int? | Numeric ID of the project
            var postInput = new ProjectPayload(); // ProjectPayload | Post parameters

            try
            {
                // WorkspaceProject
                ModelsProject result = apiInstance.PutWorkspaceProject(workspaceId, projectId, postInput);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.PutWorkspaceProject: " + e.Message );
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
 **postInput** | [**ProjectPayload**](ProjectPayload.md)| Post parameters | 

### Return type

[**ModelsProject**](ModelsProject.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putworkspaceprojectusers"></a>
# **PutWorkspaceProjectUsers**
> ModelsProjectUser PutWorkspaceProjectUsers (int? workspaceId, int? projectUserId, UserPutPayload projectUser)

Update an user into workspace projects users

Update the data for a project user for a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutWorkspaceProjectUsersExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProjectsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var projectUserId = 56;  // int? | Numeric ID of the project user
            var projectUser = new UserPutPayload(); // UserPutPayload | Input data of the user.

            try
            {
                // Update an user into workspace projects users
                ModelsProjectUser result = apiInstance.PutWorkspaceProjectUsers(workspaceId, projectUserId, projectUser);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.PutWorkspaceProjectUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **projectUserId** | **int?**| Numeric ID of the project user | 
 **projectUser** | [**UserPutPayload**](UserPutPayload.md)| Input data of the user. | 

### Return type

[**ModelsProjectUser**](ModelsProjectUser.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workspacesworkspaceidprojectsbillableamountspost"></a>
# **WorkspacesWorkspaceIdProjectsBillableAmountsPost**
> List<ModelsProject> WorkspacesWorkspaceIdProjectsBillableAmountsPost (int? workspaceId, ProjectsPayload postInput)

Projects

Get projects billable amounts

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class WorkspacesWorkspaceIdProjectsBillableAmountsPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProjectsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var postInput = new ProjectsPayload(); // ProjectsPayload | Project IDs

            try
            {
                // Projects
                List&lt;ModelsProject&gt; result = apiInstance.WorkspacesWorkspaceIdProjectsBillableAmountsPost(workspaceId, postInput);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.WorkspacesWorkspaceIdProjectsBillableAmountsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **postInput** | [**ProjectsPayload**](ProjectsPayload.md)| Project IDs | 

### Return type

[**List<ModelsProject>**](ModelsProject.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workspacesworkspaceidprojectsprojectidget"></a>
# **WorkspacesWorkspaceIdProjectsProjectIdGet**
> ModelsProject WorkspacesWorkspaceIdProjectsProjectIdGet (int? workspaceId, int? projectId)

WorkspaceProject

Get project for given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class WorkspacesWorkspaceIdProjectsProjectIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProjectsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var projectId = 56;  // int? | Numeric ID of the project

            try
            {
                // WorkspaceProject
                ModelsProject result = apiInstance.WorkspacesWorkspaceIdProjectsProjectIdGet(workspaceId, projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.WorkspacesWorkspaceIdProjectsProjectIdGet: " + e.Message );
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

[**ModelsProject**](ModelsProject.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workspacesworkspaceidprojectsprojectidstatisticsget"></a>
# **WorkspacesWorkspaceIdProjectsProjectIdStatisticsGet**
> ModelsProjectStatistics WorkspacesWorkspaceIdProjectsProjectIdStatisticsGet (int? workspaceId, int? projectId)

WorkspaceProject

Get statistics for given workspace and project. For time entry related information, this endpoint does not consider running ones.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class WorkspacesWorkspaceIdProjectsProjectIdStatisticsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProjectsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var projectId = 56;  // int? | Numeric ID of the project

            try
            {
                // WorkspaceProject
                ModelsProjectStatistics result = apiInstance.WorkspacesWorkspaceIdProjectsProjectIdStatisticsGet(workspaceId, projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.WorkspacesWorkspaceIdProjectsProjectIdStatisticsGet: " + e.Message );
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

[**ModelsProjectStatistics**](ModelsProjectStatistics.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

