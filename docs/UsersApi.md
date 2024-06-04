# TogglAPI.NetStandard.Api.UsersApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteOrganizationUsersLeave**](UsersApi.md#deleteorganizationusersleave) | **DELETE** /organizations/{organization_id}/users/leave | Leaves organization
[**DeleteWorkspaceUser**](UsersApi.md#deleteworkspaceuser) | **DELETE** /workspaces/{workspace_id}/workspace_users/{workspace_user_id} | Delete workspace user
[**GetOrganizationUsers**](UsersApi.md#getorganizationusers) | **GET** /organizations/{organization_id}/users | List of users in organization
[**GetOrganizationUsersDetailed**](UsersApi.md#getorganizationusersdetailed) | **GET** /organizations/{organization_id}/users/detailed | List of users in organization with details
[**GetOrganizationWorkspacesWorkspaceusers**](UsersApi.md#getorganizationworkspacesworkspaceusers) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/workspace_users | List of users who belong to the given workspace.
[**GetWorkspaceUsers**](UsersApi.md#getworkspaceusers) | **GET** /workspaces/{workspace_id}/users | Get workspace users
[**GetWorkspaceWorkspaceUsers**](UsersApi.md#getworkspaceworkspaceusers) | **GET** /workspaces/{workspace_id}/workspace_users | Get workspace workspace-users
[**PatchOrganizationUsers**](UsersApi.md#patchorganizationusers) | **PATCH** /organizations/{organization_id}/users | Apply changes in bulk to users in an organization
[**PatchOrganizationWorkspaceUsers**](UsersApi.md#patchorganizationworkspaceusers) | **PATCH** /organizations/{organization_id}/workspaces/{workspace_id}/workspace_users | Changes the users in a workspace.
[**PostWorkspaceUsersLostPassword**](UsersApi.md#postworkspaceuserslostpassword) | **POST** /workspaces/{workspace_id}/users/{user_id}/lost_password | Change a lost password
[**PutOrganizationUsers**](UsersApi.md#putorganizationusers) | **PUT** /organizations/{organization_id}/users/{organization_user_id} | Changes a single organization-user
[**PutOrganizationWorkspacesAssignments**](UsersApi.md#putorganizationworkspacesassignments) | **PUT** /organizations/{organization_id}/workspaces/{workspace_id}/assignments | Change assignments of users within a workspace.
[**PutWorkspaceUsers**](UsersApi.md#putworkspaceusers) | **PUT** /workspaces/{workspace_id}/users/{user_id} | Update workspace user
[**PutWorkspaceWorkspaceUsers**](UsersApi.md#putworkspaceworkspaceusers) | **PUT** /workspaces/{workspace_id}/workspace_users/{workspace_user_id} | Update workspace-user


<a name="deleteorganizationusersleave"></a>
# **DeleteOrganizationUsersLeave**
> string DeleteOrganizationUsersLeave (int? organizationId)

Leaves organization

Leaves organization, effectively delete user account in org and delete organization if it is last user

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteOrganizationUsersLeaveExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var organizationId = 56;  // int? | Numeric ID of the organization

            try
            {
                // Leaves organization
                string result = apiInstance.DeleteOrganizationUsersLeave(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteOrganizationUsersLeave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteworkspaceuser"></a>
# **DeleteWorkspaceUser**
> void DeleteWorkspaceUser (int? workspaceId, int? workspaceUserId)

Delete workspace user

Removes user from workspace

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteWorkspaceUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.
            var workspaceUserId = 56;  // int? | Numeric ID of the workspace user.

            try
            {
                // Delete workspace user
                apiInstance.DeleteWorkspaceUser(workspaceId, workspaceUserId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteWorkspaceUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace. | 
 **workspaceUserId** | **int?**| Numeric ID of the workspace user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationusers"></a>
# **GetOrganizationUsers**
> List<ModelsOrgUser> GetOrganizationUsers (int? organizationId, string filter = null, string activeStatus = null, string onlyAdmins = null, string groups = null, string workspaces = null, int? page = null, int? perPage = null, string sortDir = null)

List of users in organization

Returns list of users in organization based on set of url parameters: Result is paginated. Pagination params are returned in headers

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetOrganizationUsersExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var organizationId = 56;  // int? | Numeric ID of the organization
            var filter = filter_example;  // string | Returns records where name or email contains this string (optional) 
            var activeStatus = activeStatus_example;  // string | List of `active` `inactive` `invited` comma separated(if not present, all statuses) (optional) 
            var onlyAdmins = onlyAdmins_example;  // string | If true returns admins only (optional) 
            var groups = groups_example;  // string | Comma-separated list of groups ids, returns users belonging to these groups only (optional) 
            var workspaces = workspaces_example;  // string | Comma-separated list of workspaces ids, returns users belonging to this workspaces only (optional) 
            var page = 56;  // int? | Page number, default 1 (optional) 
            var perPage = 56;  // int? | Number of items per page, default 50 (optional) 
            var sortDir = sortDir_example;  // string | Values 'asc' or 'desc', result is sorted on 'names' column, default 'asc' (optional) 

            try
            {
                // List of users in organization
                List&lt;ModelsOrgUser&gt; result = apiInstance.GetOrganizationUsers(organizationId, filter, activeStatus, onlyAdmins, groups, workspaces, page, perPage, sortDir);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetOrganizationUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization | 
 **filter** | **string**| Returns records where name or email contains this string | [optional] 
 **activeStatus** | **string**| List of &#x60;active&#x60; &#x60;inactive&#x60; &#x60;invited&#x60; comma separated(if not present, all statuses) | [optional] 
 **onlyAdmins** | **string**| If true returns admins only | [optional] 
 **groups** | **string**| Comma-separated list of groups ids, returns users belonging to these groups only | [optional] 
 **workspaces** | **string**| Comma-separated list of workspaces ids, returns users belonging to this workspaces only | [optional] 
 **page** | **int?**| Page number, default 1 | [optional] 
 **perPage** | **int?**| Number of items per page, default 50 | [optional] 
 **sortDir** | **string**| Values &#39;asc&#39; or &#39;desc&#39;, result is sorted on &#39;names&#39; column, default &#39;asc&#39; | [optional] 

### Return type

[**List<ModelsOrgUser>**](ModelsOrgUser.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationusersdetailed"></a>
# **GetOrganizationUsersDetailed**
> List<ModelsOrgUserDetailed> GetOrganizationUsersDetailed (int? organizationId, string filter = null, string activeStatus = null, string onlyAdmins = null, string groups = null, string workspaces = null, int? page = null, int? perPage = null, string sortDir = null)

List of users in organization with details

Returns list of users in organization based on set of url parameters: Result is paginated. Pagination params are returned in headers

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetOrganizationUsersDetailedExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var organizationId = 56;  // int? | Numeric ID of the organization
            var filter = filter_example;  // string | Returns records where name or email contains this string (optional) 
            var activeStatus = activeStatus_example;  // string | List of `active` `inactive` `invited` comma separated(if not present, all statuses) (optional) 
            var onlyAdmins = onlyAdmins_example;  // string | If true returns admins only (optional) 
            var groups = groups_example;  // string | Comma-separated list of groups ids, returns users belonging to these groups only (optional) 
            var workspaces = workspaces_example;  // string | Comma-separated list of workspaces ids, returns users belonging to this workspaces only (optional) 
            var page = 56;  // int? | Page number, default 1 (optional) 
            var perPage = 56;  // int? | Number of items per page, default 50 (optional) 
            var sortDir = sortDir_example;  // string | Values 'asc' or 'desc', result is sorted on 'names' column, default 'asc' (optional) 

            try
            {
                // List of users in organization with details
                List&lt;ModelsOrgUserDetailed&gt; result = apiInstance.GetOrganizationUsersDetailed(organizationId, filter, activeStatus, onlyAdmins, groups, workspaces, page, perPage, sortDir);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetOrganizationUsersDetailed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization | 
 **filter** | **string**| Returns records where name or email contains this string | [optional] 
 **activeStatus** | **string**| List of &#x60;active&#x60; &#x60;inactive&#x60; &#x60;invited&#x60; comma separated(if not present, all statuses) | [optional] 
 **onlyAdmins** | **string**| If true returns admins only | [optional] 
 **groups** | **string**| Comma-separated list of groups ids, returns users belonging to these groups only | [optional] 
 **workspaces** | **string**| Comma-separated list of workspaces ids, returns users belonging to this workspaces only | [optional] 
 **page** | **int?**| Page number, default 1 | [optional] 
 **perPage** | **int?**| Number of items per page, default 50 | [optional] 
 **sortDir** | **string**| Values &#39;asc&#39; or &#39;desc&#39;, result is sorted on &#39;names&#39; column, default &#39;asc&#39; | [optional] 

### Return type

[**List<ModelsOrgUserDetailed>**](ModelsOrgUserDetailed.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationworkspacesworkspaceusers"></a>
# **GetOrganizationWorkspacesWorkspaceusers**
> List<ModelsOrganizationWorkspaceUser> GetOrganizationWorkspacesWorkspaceusers (int? organizationId, int? workspaceId, string name)

List of users who belong to the given workspace.

Returns any users who belong to the workspace directly or through at least one group.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetOrganizationWorkspacesWorkspaceusersExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var organizationId = 56;  // int? | Numeric ID of the organization
            var workspaceId = 56;  // int? | Numeric ID of the workspace within the organization
            var name = name_example;  // string | Workspace user name to filter by

            try
            {
                // List of users who belong to the given workspace.
                List&lt;ModelsOrganizationWorkspaceUser&gt; result = apiInstance.GetOrganizationWorkspacesWorkspaceusers(organizationId, workspaceId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetOrganizationWorkspacesWorkspaceusers: " + e.Message );
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
 **name** | **string**| Workspace user name to filter by | 

### Return type

[**List<ModelsOrganizationWorkspaceUser>**](ModelsOrganizationWorkspaceUser.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspaceusers"></a>
# **GetWorkspaceUsers**
> List<ModelsSimpleWorkspaceUser> GetWorkspaceUsers (int? workspaceId, bool? excludeDeleted = null)

Get workspace users

List all users for a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceUsersExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var excludeDeleted = true;  // bool? | Exclude deleted records in the response (optional) 

            try
            {
                // Get workspace users
                List&lt;ModelsSimpleWorkspaceUser&gt; result = apiInstance.GetWorkspaceUsers(workspaceId, excludeDeleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetWorkspaceUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **excludeDeleted** | **bool?**| Exclude deleted records in the response | [optional] 

### Return type

[**List<ModelsSimpleWorkspaceUser>**](ModelsSimpleWorkspaceUser.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspaceworkspaceusers"></a>
# **GetWorkspaceWorkspaceUsers**
> List<ModelsWorkspaceUser> GetWorkspaceWorkspaceUsers (int? workspaceId, string includeIndirect)

Get workspace workspace-users

List all workspace_users for a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceWorkspaceUsersExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var includeIndirect = includeIndirect_example;  // string | If true, includes indirect users (i.e. users assigned via group) to workspace user list

            try
            {
                // Get workspace workspace-users
                List&lt;ModelsWorkspaceUser&gt; result = apiInstance.GetWorkspaceWorkspaceUsers(workspaceId, includeIndirect);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetWorkspaceWorkspaceUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **includeIndirect** | **string**| If true, includes indirect users (i.e. users assigned via group) to workspace user list | 

### Return type

[**List<ModelsWorkspaceUser>**](ModelsWorkspaceUser.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchorganizationusers"></a>
# **PatchOrganizationUsers**
> string PatchOrganizationUsers (int? organizationId, UserPatchParams _params)

Apply changes in bulk to users in an organization

Apply changes in bulk to users in an organization (currently deletion only).

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PatchOrganizationUsersExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var organizationId = 56;  // int? | Numeric ID of the organization
            var _params = new UserPatchParams(); // UserPatchParams | Input data of the users to be patched.

            try
            {
                // Apply changes in bulk to users in an organization
                string result = apiInstance.PatchOrganizationUsers(organizationId, _params);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PatchOrganizationUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization | 
 **_params** | [**UserPatchParams**](UserPatchParams.md)| Input data of the users to be patched. | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchorganizationworkspaceusers"></a>
# **PatchOrganizationWorkspaceUsers**
> string PatchOrganizationWorkspaceUsers (int? organizationId, int? workspaceId, WorkspaceUsersPatchParams _params)

Changes the users in a workspace.

Changes the users in a workspace (currently deletion only).

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PatchOrganizationWorkspaceUsersExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var organizationId = 56;  // int? | Numeric ID of the organization
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var _params = new WorkspaceUsersPatchParams(); // WorkspaceUsersPatchParams | Input data of the users to be patched.

            try
            {
                // Changes the users in a workspace.
                string result = apiInstance.PatchOrganizationWorkspaceUsers(organizationId, workspaceId, _params);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PatchOrganizationWorkspaceUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization | 
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **_params** | [**WorkspaceUsersPatchParams**](WorkspaceUsersPatchParams.md)| Input data of the users to be patched. | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postworkspaceuserslostpassword"></a>
# **PostWorkspaceUsersLostPassword**
> UsersLostPasswordURL PostWorkspaceUsersLostPassword (int? workspaceId, int? userId)

Change a lost password

Request a change password action

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostWorkspaceUsersLostPasswordExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var userId = 56;  // int? | Numeric ID of the user

            try
            {
                // Change a lost password
                UsersLostPasswordURL result = apiInstance.PostWorkspaceUsersLostPassword(workspaceId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostWorkspaceUsersLostPassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **userId** | **int?**| Numeric ID of the user | 

### Return type

[**UsersLostPasswordURL**](UsersLostPasswordURL.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putorganizationusers"></a>
# **PutOrganizationUsers**
> string PutOrganizationUsers (int? organizationId, UserPayload _params)

Changes a single organization-user

Changes a single organization-user. Can affect the following values:

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutOrganizationUsersExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var organizationId = 56;  // int? | Numeric ID of the organization
            var _params = new UserPayload(); // UserPayload | Input data of the organization user to be changed.

            try
            {
                // Changes a single organization-user
                string result = apiInstance.PutOrganizationUsers(organizationId, _params);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutOrganizationUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization | 
 **_params** | [**UserPayload**](UserPayload.md)| Input data of the organization user to be changed. | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

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

            var apiInstance = new UsersApi();
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
                Debug.Print("Exception when calling UsersApi.PutOrganizationWorkspacesAssignments: " + e.Message );
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

<a name="putworkspaceusers"></a>
# **PutWorkspaceUsers**
> string PutWorkspaceUsers (int? workspaceId, int? userId)

Update workspace user

Update the data for a user in a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutWorkspaceUsersExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var userId = 56;  // int? | Numeric ID of the user

            try
            {
                // Update workspace user
                string result = apiInstance.PutWorkspaceUsers(workspaceId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutWorkspaceUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **userId** | **int?**| Numeric ID of the user | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putworkspaceworkspaceusers"></a>
# **PutWorkspaceWorkspaceUsers**
> string PutWorkspaceWorkspaceUsers (int? workspaceId, int? workspaceUserId, UserPayload post)

Update workspace-user

Update the data for a workspace_user in a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutWorkspaceWorkspaceUsersExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var workspaceUserId = 56;  // int? | Numeric ID of the workspace user
            var post = new UserPayload(); // UserPayload | Changes that need to be applied to the user data.

            try
            {
                // Update workspace-user
                string result = apiInstance.PutWorkspaceWorkspaceUsers(workspaceId, workspaceUserId, post);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutWorkspaceWorkspaceUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **workspaceUserId** | **int?**| Numeric ID of the workspace user | 
 **post** | [**UserPayload**](UserPayload.md)| Changes that need to be applied to the user data. | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

