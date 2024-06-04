# TogglAPI.NetStandard.Api.OrganizationsApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteOrganizationGroup**](OrganizationsApi.md#deleteorganizationgroup) | **DELETE** /organizations/{organization_id}/groups/{group_id} | Deletes group
[**DeleteOrganizationUsersLeave**](OrganizationsApi.md#deleteorganizationusersleave) | **DELETE** /organizations/{organization_id}/users/leave | Leaves organization
[**GetOrganization**](OrganizationsApi.md#getorganization) | **GET** /organizations/{organization_id} | Organization data
[**GetOrganizationGroups**](OrganizationsApi.md#getorganizationgroups) | **GET** /organizations/{organization_id}/groups | List of groups in organization with user and workspace assignments
[**GetOrganizationOwner**](OrganizationsApi.md#getorganizationowner) | **GET** /organizations/{organization_id}/owner | Get owner of the organization
[**GetOrganizationRoles**](OrganizationsApi.md#getorganizationroles) | **GET** /organizations/{organization_id}/roles | Organization roles.
[**GetOrganizationSegmentation**](OrganizationsApi.md#getorganizationsegmentation) | **GET** /organizations/{organization_id}/segmentation | Organization segmentation data
[**GetOrganizationUsers**](OrganizationsApi.md#getorganizationusers) | **GET** /organizations/{organization_id}/users | List of users in organization
[**GetOrganizationUsersDetailed**](OrganizationsApi.md#getorganizationusersdetailed) | **GET** /organizations/{organization_id}/users/detailed | List of users in organization with details
[**GetOrganizationWorkspacesGroups**](OrganizationsApi.md#getorganizationworkspacesgroups) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/groups | List of groups in a workspace within an organization with user assignments.
[**GetOrganizationWorkspacesStatistics**](OrganizationsApi.md#getorganizationworkspacesstatistics) | **GET** /organizations/{organization_id}/workspaces/statistics | Statistics for all workspaces in the organization
[**GetOrganizationsPaymentsRecords**](OrganizationsApi.md#getorganizationspaymentsrecords) | **GET** /organizations/{organization_id}/payment_records | OrganizationsPaymentRecords
[**GetOrganizationsPlans**](OrganizationsApi.md#getorganizationsplans) | **GET** /organizations/{organization_id}/plans | OrganizationsPlans
[**GetOrganizationsPlans_0**](OrganizationsApi.md#getorganizationsplans_0) | **GET** /organizations/{organization_id}/plans/{plan_id} | OrganizationsPlan
[**PatchOrganizationGroup**](OrganizationsApi.md#patchorganizationgroup) | **PATCH** /organizations/{organization_id}/groups/{group_id} | Patch group
[**PatchOrganizationUsers**](OrganizationsApi.md#patchorganizationusers) | **PATCH** /organizations/{organization_id}/users | Apply changes in bulk to users in an organization
[**PostOrganization**](OrganizationsApi.md#postorganization) | **POST** /organizations | Creates a new organization
[**PostOrganizationAcceptInvitation**](OrganizationsApi.md#postorganizationacceptinvitation) | **POST** /organizations/invitations/{invitation_code}/accept | Accepts invitation
[**PostOrganizationGroup**](OrganizationsApi.md#postorganizationgroup) | **POST** /organizations/{organization_id}/groups | Create group
[**PostOrganizationInvitation**](OrganizationsApi.md#postorganizationinvitation) | **POST** /organizations/{organization_id}/invitations | Creates a new invitation for the user
[**PostOrganizationWorkspaces**](OrganizationsApi.md#postorganizationworkspaces) | **POST** /organizations/{organization_id}/workspaces | Create a new workspace.
[**PutOrganization**](OrganizationsApi.md#putorganization) | **PUT** /organizations/{organization_id} | Updates an existing organization
[**PutOrganizationGroup**](OrganizationsApi.md#putorganizationgroup) | **PUT** /organizations/{organization_id}/groups/{group_id} | Edit group
[**PutOrganizationSegmentation**](OrganizationsApi.md#putorganizationsegmentation) | **PUT** /organizations/{organization_id}/segmentation | Organization segmentation data
[**PutOrganizationUsers**](OrganizationsApi.md#putorganizationusers) | **PUT** /organizations/{organization_id}/users/{organization_user_id} | Changes a single organization-user
[**PutOrganizationWorkspacesAssignments**](OrganizationsApi.md#putorganizationworkspacesassignments) | **PUT** /organizations/{organization_id}/workspaces/{workspace_id}/assignments | Change assignments of users within a workspace.


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

            var apiInstance = new OrganizationsApi();
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
                Debug.Print("Exception when calling OrganizationsApi.DeleteOrganizationGroup: " + e.Message );
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

            var apiInstance = new OrganizationsApi();
            var organizationId = 56;  // int? | Numeric ID of the organization

            try
            {
                // Leaves organization
                string result = apiInstance.DeleteOrganizationUsersLeave(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.DeleteOrganizationUsersLeave: " + e.Message );
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

<a name="getorganization"></a>
# **GetOrganization**
> ModelsMeOrganization GetOrganization (int? organizationId)

Organization data

Returns organization name and current pricing plan

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetOrganizationExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationsApi();
            var organizationId = 56;  // int? | Numeric ID of the organization

            try
            {
                // Organization data
                ModelsMeOrganization result = apiInstance.GetOrganization(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetOrganization: " + e.Message );
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

[**ModelsMeOrganization**](ModelsMeOrganization.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

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

            var apiInstance = new OrganizationsApi();
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
                Debug.Print("Exception when calling OrganizationsApi.GetOrganizationGroups: " + e.Message );
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

<a name="getorganizationowner"></a>
# **GetOrganizationOwner**
> ModelsOrganizationOwner GetOrganizationOwner (int? organizationId)

Get owner of the organization

Returns organization owner data.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetOrganizationOwnerExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationsApi();
            var organizationId = 56;  // int? | Numeric ID of the organization

            try
            {
                // Get owner of the organization
                ModelsOrganizationOwner result = apiInstance.GetOrganizationOwner(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetOrganizationOwner: " + e.Message );
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

[**ModelsOrganizationOwner**](ModelsOrganizationOwner.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationroles"></a>
# **GetOrganizationRoles**
> List<TypesRole> GetOrganizationRoles (int? organizationId)

Organization roles.

Returns a list of organization specific and global roles.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetOrganizationRolesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationsApi();
            var organizationId = 56;  // int? | Numeric ID of the organization

            try
            {
                // Organization roles.
                List&lt;TypesRole&gt; result = apiInstance.GetOrganizationRoles(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetOrganizationRoles: " + e.Message );
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

[**List<TypesRole>**](TypesRole.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationsegmentation"></a>
# **GetOrganizationSegmentation**
> ModelsOrganizationSegmentation GetOrganizationSegmentation (int? organizationId)

Organization segmentation data

Returns organization segmentation information

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetOrganizationSegmentationExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationsApi();
            var organizationId = 56;  // int? | Numeric ID of the organization

            try
            {
                // Organization segmentation data
                ModelsOrganizationSegmentation result = apiInstance.GetOrganizationSegmentation(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetOrganizationSegmentation: " + e.Message );
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

[**ModelsOrganizationSegmentation**](ModelsOrganizationSegmentation.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

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

            var apiInstance = new OrganizationsApi();
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
                Debug.Print("Exception when calling OrganizationsApi.GetOrganizationUsers: " + e.Message );
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

            var apiInstance = new OrganizationsApi();
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
                Debug.Print("Exception when calling OrganizationsApi.GetOrganizationUsersDetailed: " + e.Message );
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

            var apiInstance = new OrganizationsApi();
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
                Debug.Print("Exception when calling OrganizationsApi.GetOrganizationWorkspacesGroups: " + e.Message );
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

<a name="getorganizationworkspacesstatistics"></a>
# **GetOrganizationWorkspacesStatistics**
> Dictionary<string, ModelsStatistics> GetOrganizationWorkspacesStatistics ()

Statistics for all workspaces in the organization

Returns map indexed by workspace ID where each map element contains workspace admins list, members count and groups count.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetOrganizationWorkspacesStatisticsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationsApi();

            try
            {
                // Statistics for all workspaces in the organization
                Dictionary&lt;string, ModelsStatistics&gt; result = apiInstance.GetOrganizationWorkspacesStatistics();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetOrganizationWorkspacesStatistics: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Dictionary<string, ModelsStatistics>**](ModelsStatistics.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationspaymentsrecords"></a>
# **GetOrganizationsPaymentsRecords**
> List<ModelsUnifiedSubscriptionInvoiceList> GetOrganizationsPaymentsRecords (int? organizationId, bool? isUnified = null, string next = null, string prev = null)

OrganizationsPaymentRecords

Returns paid invoices

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetOrganizationsPaymentsRecordsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationsApi();
            var organizationId = 56;  // int? | Numeric ID of the organization
            var isUnified = true;  // bool? | If 'true', returns unified invoices (optional) 
            var next = next_example;  // string | Next cursor for unified subsriptions. Cannot be used at the same time `prev` (optional) 
            var prev = prev_example;  // string | Previous cursor for unified subsriptions. Cannot be used at the same time with `next` (optional) 

            try
            {
                // OrganizationsPaymentRecords
                List&lt;ModelsUnifiedSubscriptionInvoiceList&gt; result = apiInstance.GetOrganizationsPaymentsRecords(organizationId, isUnified, next, prev);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetOrganizationsPaymentsRecords: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization | 
 **isUnified** | **bool?**| If &#39;true&#39;, returns unified invoices | [optional] 
 **next** | **string**| Next cursor for unified subsriptions. Cannot be used at the same time &#x60;prev&#x60; | [optional] 
 **prev** | **string**| Previous cursor for unified subsriptions. Cannot be used at the same time with &#x60;next&#x60; | [optional] 

### Return type

[**List<ModelsUnifiedSubscriptionInvoiceList>**](ModelsUnifiedSubscriptionInvoiceList.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationsplans"></a>
# **GetOrganizationsPlans**
> BillingPricingStruct GetOrganizationsPlans (int? organizationId)

OrganizationsPlans

Returns pricing plans for an organization

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetOrganizationsPlansExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationsApi();
            var organizationId = 56;  // int? | Numeric ID of the organization

            try
            {
                // OrganizationsPlans
                BillingPricingStruct result = apiInstance.GetOrganizationsPlans(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetOrganizationsPlans: " + e.Message );
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

[**BillingPricingStruct**](BillingPricingStruct.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationsplans_0"></a>
# **GetOrganizationsPlans_0**
> BillingPricingStruct GetOrganizationsPlans_0 (int? organizationId, int? planId)

OrganizationsPlan

Returns pricing plan for an organization identified by plan_id

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetOrganizationsPlans_0Example
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationsApi();
            var organizationId = 56;  // int? | Numeric ID of the organization
            var planId = 56;  // int? | Numeric ID of the plan

            try
            {
                // OrganizationsPlan
                BillingPricingStruct result = apiInstance.GetOrganizationsPlans_0(organizationId, planId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetOrganizationsPlans_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization | 
 **planId** | **int?**| Numeric ID of the plan | 

### Return type

[**BillingPricingStruct**](BillingPricingStruct.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

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

            var apiInstance = new OrganizationsApi();
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
                Debug.Print("Exception when calling OrganizationsApi.PatchOrganizationGroup: " + e.Message );
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

            var apiInstance = new OrganizationsApi();
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
                Debug.Print("Exception when calling OrganizationsApi.PatchOrganizationUsers: " + e.Message );
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

<a name="postorganization"></a>
# **PostOrganization**
> OrganizationPostOrganizationReply PostOrganization (ModelsPostPayload postOrganizationsRequest)

Creates a new organization

Creates a new organization with a single workspace and assigns current user as the organization owner

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostOrganizationExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationsApi();
            var postOrganizationsRequest = new ModelsPostPayload(); // ModelsPostPayload | Input data for organization.

            try
            {
                // Creates a new organization
                OrganizationPostOrganizationReply result = apiInstance.PostOrganization(postOrganizationsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PostOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postOrganizationsRequest** | [**ModelsPostPayload**](ModelsPostPayload.md)| Input data for organization. | 

### Return type

[**OrganizationPostOrganizationReply**](OrganizationPostOrganizationReply.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postorganizationacceptinvitation"></a>
# **PostOrganizationAcceptInvitation**
> string PostOrganizationAcceptInvitation (string inviutationCode)

Accepts invitation

User connected with invitation is marked as joined, email is sent to the inviter.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostOrganizationAcceptInvitationExample
    {
        public void main()
        {
            var apiInstance = new OrganizationsApi();
            var inviutationCode = inviutationCode_example;  // string | Invitation code

            try
            {
                // Accepts invitation
                string result = apiInstance.PostOrganizationAcceptInvitation(inviutationCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PostOrganizationAcceptInvitation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inviutationCode** | **string**| Invitation code | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

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

            var apiInstance = new OrganizationsApi();
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
                Debug.Print("Exception when calling OrganizationsApi.PostOrganizationGroup: " + e.Message );
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

<a name="postorganizationinvitation"></a>
# **PostOrganizationInvitation**
> InvitationResult PostOrganizationInvitation (int? organizationId, InvitationPost postInvitationRequest)

Creates a new invitation for the user

Creates a new invitation for the user.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostOrganizationInvitationExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationsApi();
            var organizationId = 56;  // int? | Numeric ID of the organization.
            var postInvitationRequest = new InvitationPost(); // InvitationPost | Input data for invitation creation

            try
            {
                // Creates a new invitation for the user
                InvitationResult result = apiInstance.PostOrganizationInvitation(organizationId, postInvitationRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PostOrganizationInvitation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization. | 
 **postInvitationRequest** | [**InvitationPost**](InvitationPost.md)| Input data for invitation creation | 

### Return type

[**InvitationResult**](InvitationResult.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postorganizationworkspaces"></a>
# **PostOrganizationWorkspaces**
> WorkspaceWorkspace PostOrganizationWorkspaces (int? organizationId, WorkspacePayload post)

Create a new workspace.

Create a workspace within an existing organization.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostOrganizationWorkspacesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationsApi();
            var organizationId = 56;  // int? | Numeric ID of the organization
            var post = new WorkspacePayload(); // WorkspacePayload | Parameters of the new workspace

            try
            {
                // Create a new workspace.
                WorkspaceWorkspace result = apiInstance.PostOrganizationWorkspaces(organizationId, post);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PostOrganizationWorkspaces: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization | 
 **post** | [**WorkspacePayload**](WorkspacePayload.md)| Parameters of the new workspace | 

### Return type

[**WorkspaceWorkspace**](WorkspaceWorkspace.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putorganization"></a>
# **PutOrganization**
> string PutOrganization (int? organizationId, ModelsPutPayload putOrganizationsRequest)

Updates an existing organization

Updates an existing organization

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutOrganizationExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationsApi();
            var organizationId = 56;  // int? | Numeric ID of the organization.
            var putOrganizationsRequest = new ModelsPutPayload(); // ModelsPutPayload | Input data for organization.

            try
            {
                // Updates an existing organization
                string result = apiInstance.PutOrganization(organizationId, putOrganizationsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PutOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization. | 
 **putOrganizationsRequest** | [**ModelsPutPayload**](ModelsPutPayload.md)| Input data for organization. | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

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

            var apiInstance = new OrganizationsApi();
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
                Debug.Print("Exception when calling OrganizationsApi.PutOrganizationGroup: " + e.Message );
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

<a name="putorganizationsegmentation"></a>
# **PutOrganizationSegmentation**
> ModelsOrganizationSegmentation PutOrganizationSegmentation (int? organizationId)

Organization segmentation data

Save organization segmentation information

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutOrganizationSegmentationExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationsApi();
            var organizationId = 56;  // int? | Numeric ID of the organization

            try
            {
                // Organization segmentation data
                ModelsOrganizationSegmentation result = apiInstance.PutOrganizationSegmentation(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PutOrganizationSegmentation: " + e.Message );
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

[**ModelsOrganizationSegmentation**](ModelsOrganizationSegmentation.md)

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

            var apiInstance = new OrganizationsApi();
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
                Debug.Print("Exception when calling OrganizationsApi.PutOrganizationUsers: " + e.Message );
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

            var apiInstance = new OrganizationsApi();
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
                Debug.Print("Exception when calling OrganizationsApi.PutOrganizationWorkspacesAssignments: " + e.Message );
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

