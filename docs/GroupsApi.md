# TogglAPI.NetStandard.Api.GroupsApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteOrganizationGroup**](GroupsApi.md#deleteorganizationgroup) | **DELETE** /organizations/{organization_id}/groups/{group_id} | Deletes group
[**DeleteProjectGroup**](GroupsApi.md#deleteprojectgroup) | **DELETE** /workspaces/{workspace_id}/project_groups/{project_group_id} | Remove project group.
[**DeleteWorkspaceGroup**](GroupsApi.md#deleteworkspacegroup) | **DELETE** /workspaces/{workspace_id}/groups/{group_id} | Delete group
[**GetOrganizationGroups**](GroupsApi.md#getorganizationgroups) | **GET** /organizations/{organization_id}/groups | List of groups in organization with user and workspace assignments
[**GetOrganizationWorkspacesGroups**](GroupsApi.md#getorganizationworkspacesgroups) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/groups | List of groups in a workspace within an organization with user assignments.
[**GetProjectGroups**](GroupsApi.md#getprojectgroups) | **GET** /workspaces/{workspace_id}/project_groups | Get workspace project groups.
[**GetWorkspaceGroups**](GroupsApi.md#getworkspacegroups) | **GET** /workspaces/{workspace_id}/groups | Get workspace groups
[**PatchOrganizationGroup**](GroupsApi.md#patchorganizationgroup) | **PATCH** /organizations/{organization_id}/groups/{group_id} | Patch group
[**PostOrganizationGroup**](GroupsApi.md#postorganizationgroup) | **POST** /organizations/{organization_id}/groups | Create group
[**PostProjectGroup**](GroupsApi.md#postprojectgroup) | **POST** /workspaces/{workspace_id}/project_groups | Adds group to project.
[**PostWorkspaceGroup**](GroupsApi.md#postworkspacegroup) | **POST** /workspaces/{workspace_id}/groups | Create group
[**PutOrganizationGroup**](GroupsApi.md#putorganizationgroup) | **PUT** /organizations/{organization_id}/groups/{group_id} | Edit group
[**PutOrganizationWorkspacesAssignments**](GroupsApi.md#putorganizationworkspacesassignments) | **PUT** /organizations/{organization_id}/workspaces/{workspace_id}/assignments | Change assignments of users within a workspace.
[**PutWorkspaceGroup**](GroupsApi.md#putworkspacegroup) | **PUT** /workspaces/{workspace_id}/groups/{group_id} | Update group


<a name="deleteorganizationgroup"></a>
# **DeleteOrganizationGroup**
> string DeleteOrganizationGroup (int? organizationId, int? groupId)

Deletes group

Deletes a group from the specified organization

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteOrganizationGroupExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GroupsApi();
            var organizationId = 56;  // int? | Numeric ID of the organization.
            var groupId = 56;  // int? | Numeric ID of the group.

            try
            {
                // Deletes group
                string result = apiInstance.DeleteOrganizationGroup(organizationId, groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteOrganizationGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization. | 
 **groupId** | **int?**| Numeric ID of the group. | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprojectgroup"></a>
# **DeleteProjectGroup**
> string DeleteProjectGroup (int? workspaceId, int? projectGroupId)

Remove project group.

Remove project group for a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteProjectGroupExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GroupsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var projectGroupId = 56;  // int? | Numeric ID of the project group

            try
            {
                // Remove project group.
                string result = apiInstance.DeleteProjectGroup(workspaceId, projectGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteProjectGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **projectGroupId** | **int?**| Numeric ID of the project group | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteworkspacegroup"></a>
# **DeleteWorkspaceGroup**
> void DeleteWorkspaceGroup (int? workspaceId, int? groupId)

Delete group

Deletes the group.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteWorkspaceGroupExample
    {
        public void main()
        {
            var apiInstance = new GroupsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.
            var groupId = 56;  // int? | Numeric ID of the group.

            try
            {
                // Delete group
                apiInstance.DeleteWorkspaceGroup(workspaceId, groupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteWorkspaceGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace. | 
 **groupId** | **int?**| Numeric ID of the group. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationgroups"></a>
# **GetOrganizationGroups**
> List<GroupOrganizationGroupResponse> GetOrganizationGroups (int? organizationId, string name = null, string workspace = null)

List of groups in organization with user and workspace assignments

Returns list of groups in organization based on set of url parameters. List is sorted by name.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetOrganizationGroupsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GroupsApi();
            var organizationId = 56;  // int? | Numeric ID of the organization
            var name = name_example;  // string | Returns records where name contains this string (optional) 
            var workspace = workspace_example;  // string | ID of workspace. Returns groups assigned to this workspace (optional) 

            try
            {
                // List of groups in organization with user and workspace assignments
                List&lt;GroupOrganizationGroupResponse&gt; result = apiInstance.GetOrganizationGroups(organizationId, name, workspace);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetOrganizationGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization | 
 **name** | **string**| Returns records where name contains this string | [optional] 
 **workspace** | **string**| ID of workspace. Returns groups assigned to this workspace | [optional] 

### Return type

[**List<GroupOrganizationGroupResponse>**](GroupOrganizationGroupResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationworkspacesgroups"></a>
# **GetOrganizationWorkspacesGroups**
> List<GroupOrganizationGroupResponse> GetOrganizationWorkspacesGroups (int? organizationId, int? workspaceId)

List of groups in a workspace within an organization with user assignments.

Returns list of groups in a workspace based on set of url parameters. List is sorted by name.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetOrganizationWorkspacesGroupsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GroupsApi();
            var organizationId = 56;  // int? | Numeric ID of the organization
            var workspaceId = 56;  // int? | Numeric ID of the workspace within the organization

            try
            {
                // List of groups in a workspace within an organization with user assignments.
                List&lt;GroupOrganizationGroupResponse&gt; result = apiInstance.GetOrganizationWorkspacesGroups(organizationId, workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetOrganizationWorkspacesGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization | 
 **workspaceId** | **int?**| Numeric ID of the workspace within the organization | 

### Return type

[**List<GroupOrganizationGroupResponse>**](GroupOrganizationGroupResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojectgroups"></a>
# **GetProjectGroups**
> List<ModelsProjectGroup> GetProjectGroups (int? workspaceId, string projectIds)

Get workspace project groups.

Get project groups for given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetProjectGroupsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GroupsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var projectIds = projectIds_example;  // string | Project IDs separated by comma.

            try
            {
                // Get workspace project groups.
                List&lt;ModelsProjectGroup&gt; result = apiInstance.GetProjectGroups(workspaceId, projectIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetProjectGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **projectIds** | **string**| Project IDs separated by comma. | 

### Return type

[**List<ModelsProjectGroup>**](ModelsProjectGroup.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacegroups"></a>
# **GetWorkspaceGroups**
> List<ModelsGroup> GetWorkspaceGroups (int? workspaceId)

Get workspace groups

Returns a list of groups for the specified workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceGroupsExample
    {
        public void main()
        {
            var apiInstance = new GroupsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.

            try
            {
                // Get workspace groups
                List&lt;ModelsGroup&gt; result = apiInstance.GetWorkspaceGroups(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetWorkspaceGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace. | 

### Return type

[**List<ModelsGroup>**](ModelsGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchorganizationgroup"></a>
# **PatchOrganizationGroup**
> GroupsPatchOutput PatchOrganizationGroup (int? organizationId, int? groupId, List<GroupsPatchInput> patchGroupRequest)

Patch group

Patches a group in the specified organization. Patches are applied individually.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PatchOrganizationGroupExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GroupsApi();
            var organizationId = 56;  // int? | Numeric ID of the organization.
            var groupId = 56;  // int? | Numeric ID of the group.
            var patchGroupRequest = new List<GroupsPatchInput>(); // List<GroupsPatchInput> | Array of patch operations.

            try
            {
                // Patch group
                GroupsPatchOutput result = apiInstance.PatchOrganizationGroup(organizationId, groupId, patchGroupRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PatchOrganizationGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization. | 
 **groupId** | **int?**| Numeric ID of the group. | 
 **patchGroupRequest** | [**List&lt;GroupsPatchInput&gt;**](GroupsPatchInput.md)| Array of patch operations. | 

### Return type

[**GroupsPatchOutput**](GroupsPatchOutput.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postorganizationgroup"></a>
# **PostOrganizationGroup**
> GroupOrganizationGroupResponse PostOrganizationGroup (int? organizationId, GroupPayload postGroupRequest)

Create group

Creates a group in the specified organization

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostOrganizationGroupExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GroupsApi();
            var organizationId = 56;  // int? | Numeric ID of the organization.
            var postGroupRequest = new GroupPayload(); // GroupPayload | Input data for group creation.

            try
            {
                // Create group
                GroupOrganizationGroupResponse result = apiInstance.PostOrganizationGroup(organizationId, postGroupRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PostOrganizationGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization. | 
 **postGroupRequest** | [**GroupPayload**](GroupPayload.md)| Input data for group creation. | 

### Return type

[**GroupOrganizationGroupResponse**](GroupOrganizationGroupResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postprojectgroup"></a>
# **PostProjectGroup**
> string PostProjectGroup (int? workspaceId, GroupProjectGroupPayload projectGroupPost)

Adds group to project.

Adds group to project for given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostProjectGroupExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GroupsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var projectGroupPost = new GroupProjectGroupPayload(); // GroupProjectGroupPayload | Input data

            try
            {
                // Adds group to project.
                string result = apiInstance.PostProjectGroup(workspaceId, projectGroupPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PostProjectGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **projectGroupPost** | [**GroupProjectGroupPayload**](GroupProjectGroupPayload.md)| Input data | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postworkspacegroup"></a>
# **PostWorkspaceGroup**
> ModelsGroup PostWorkspaceGroup (int? workspaceId, GroupNamePayload postGroupRequest)

Create group

Creates a group in the specified workspace

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostWorkspaceGroupExample
    {
        public void main()
        {
            var apiInstance = new GroupsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.
            var postGroupRequest = new GroupNamePayload(); // GroupNamePayload | Input data for group creation.

            try
            {
                // Create group
                ModelsGroup result = apiInstance.PostWorkspaceGroup(workspaceId, postGroupRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PostWorkspaceGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace. | 
 **postGroupRequest** | [**GroupNamePayload**](GroupNamePayload.md)| Input data for group creation. | 

### Return type

[**ModelsGroup**](ModelsGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putorganizationgroup"></a>
# **PutOrganizationGroup**
> GroupOrganizationGroupResponse PutOrganizationGroup (int? organizationId, GroupPayload putGroupRequest)

Edit group

Edits a group in the specified organization

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutOrganizationGroupExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GroupsApi();
            var organizationId = 56;  // int? | Numeric ID of the organization.
            var putGroupRequest = new GroupPayload(); // GroupPayload | Input data for group modification.

            try
            {
                // Edit group
                GroupOrganizationGroupResponse result = apiInstance.PutOrganizationGroup(organizationId, putGroupRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PutOrganizationGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization. | 
 **putGroupRequest** | [**GroupPayload**](GroupPayload.md)| Input data for group modification. | 

### Return type

[**GroupOrganizationGroupResponse**](GroupOrganizationGroupResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putorganizationworkspacesassignments"></a>
# **PutOrganizationWorkspacesAssignments**
> string PutOrganizationWorkspacesAssignments (int? organizationId, int? workspaceId, UserAssignmentsPayload post)

Change assignments of users within a workspace.

Assign or remove users to/from a workspace or to/from groups belonging to said workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutOrganizationWorkspacesAssignmentsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GroupsApi();
            var organizationId = 56;  // int? | Numeric ID of the organization
            var workspaceId = 56;  // int? | Numeric ID of the workspace within the organization
            var post = new UserAssignmentsPayload(); // UserAssignmentsPayload | Describes the change in assignment

            try
            {
                // Change assignments of users within a workspace.
                string result = apiInstance.PutOrganizationWorkspacesAssignments(organizationId, workspaceId, post);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PutOrganizationWorkspacesAssignments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization | 
 **workspaceId** | **int?**| Numeric ID of the workspace within the organization | 
 **post** | [**UserAssignmentsPayload**](UserAssignmentsPayload.md)| Describes the change in assignment | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putworkspacegroup"></a>
# **PutWorkspaceGroup**
> ModelsGroup PutWorkspaceGroup (int? workspaceId, int? groupId, GroupNamePayload putGroupRequest)

Update group

Updates the group.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutWorkspaceGroupExample
    {
        public void main()
        {
            var apiInstance = new GroupsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.
            var groupId = 56;  // int? | Numeric ID of the group.
            var putGroupRequest = new GroupNamePayload(); // GroupNamePayload | Input data for group update.

            try
            {
                // Update group
                ModelsGroup result = apiInstance.PutWorkspaceGroup(workspaceId, groupId, putGroupRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PutWorkspaceGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace. | 
 **groupId** | **int?**| Numeric ID of the group. | 
 **putGroupRequest** | [**GroupNamePayload**](GroupNamePayload.md)| Input data for group update. | 

### Return type

[**ModelsGroup**](ModelsGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

