# TogglAPI.NetStandard.Api.WorkspacesApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAlerts**](WorkspacesApi.md#deletealerts) | **DELETE** /workspaces/{workspace_id}/alerts/{alert_id} | Alerts
[**DeleteTimesheetSetups**](WorkspacesApi.md#deletetimesheetsetups) | **DELETE** /workspaces/{workspace_id}/timesheet_setups/{setup_id} | Delete a timesheet setup
[**DeleteWorkspaceTrackReminder**](WorkspacesApi.md#deleteworkspacetrackreminder) | **DELETE** /workspaces/{workspace_id}/track_reminders/{reminder_id} | TrackReminder
[**DeleteWorkspaceUser**](WorkspacesApi.md#deleteworkspaceuser) | **DELETE** /workspaces/{workspace_id}/workspace_users/{workspace_user_id} | Delete workspace user
[**GetOrganizationWorkspacesGroups**](WorkspacesApi.md#getorganizationworkspacesgroups) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/groups | List of groups in a workspace within an organization with user assignments.
[**GetOrganizationWorkspacesStatistics**](WorkspacesApi.md#getorganizationworkspacesstatistics) | **GET** /organizations/{organization_id}/workspaces/statistics | Statistics for all workspaces in the organization
[**GetOrganizationWorkspacesWorkspaceusers**](WorkspacesApi.md#getorganizationworkspacesworkspaceusers) | **GET** /organizations/{organization_id}/workspaces/{workspace_id}/workspace_users | List of users who belong to the given workspace.
[**GetTimesheetSetups**](WorkspacesApi.md#gettimesheetsetups) | **GET** /workspaces/{workspace_id}/timesheet_setups | Get timesheet setups
[**GetWorkspace**](WorkspacesApi.md#getworkspace) | **GET** /workspaces/{workspace_id} | Get single workspace
[**GetWorkspaceStatistics**](WorkspacesApi.md#getworkspacestatistics) | **GET** /workspaces/{workspace_id}/statistics | Workspace statistics
[**GetWorkspaceTimeEntryConstraints**](WorkspacesApi.md#getworkspacetimeentryconstraints) | **GET** /workspaces/{workspace_id}/time_entry_constraints | Get workspace time entry constraints
[**GetWorkspaceTimesheetHoursHandler**](WorkspacesApi.md#getworkspacetimesheethourshandler) | **POST** /workspaces/{workspace_id}/timesheets/hours | Get timesheets hours
[**GetWorkspaceTimesheetTimeEntriesHandler**](WorkspacesApi.md#getworkspacetimesheettimeentrieshandler) | **GET** /workspaces/{workspace_id}/timesheets/{setup_id}/{start_date} | Get timesheet time entries
[**GetWorkspaceTimesheetsHandler**](WorkspacesApi.md#getworkspacetimesheetshandler) | **GET** /workspaces/{workspace_id}/timesheets | Get timesheets
[**GetWorkspaceTrackReminders**](WorkspacesApi.md#getworkspacetrackreminders) | **GET** /workspaces/{workspace_id}/track_reminders | TrackReminders
[**GetWorkspaceUsers**](WorkspacesApi.md#getworkspaceusers) | **GET** /workspaces/{workspace_id}/users | Get workspace users
[**GetWorkspaces**](WorkspacesApi.md#getworkspaces) | **GET** /me/workspaces | Workspaces
[**PatchOrganizationWorkspaceUsers**](WorkspacesApi.md#patchorganizationworkspaceusers) | **PATCH** /organizations/{organization_id}/workspaces/{workspace_id}/workspace_users | Changes the users in a workspace.
[**PostAlerts**](WorkspacesApi.md#postalerts) | **POST** /workspaces/{workspace_id}/alerts | Alerts
[**PostOrganizationWorkspaces**](WorkspacesApi.md#postorganizationworkspaces) | **POST** /organizations/{organization_id}/workspaces | Create a new workspace.
[**PostTimesheetSetups**](WorkspacesApi.md#posttimesheetsetups) | **POST** /workspaces/{workspace_id}/timesheet_setups | Create a timesheet setup
[**PostWorkspaceTrackReminders**](WorkspacesApi.md#postworkspacetrackreminders) | **POST** /workspaces/{workspace_id}/track_reminders | TrackReminders
[**PostWorkspaceUsersLostPassword**](WorkspacesApi.md#postworkspaceuserslostpassword) | **POST** /workspaces/{workspace_id}/users/{user_id}/lost_password | Change a lost password
[**PutOrganizationWorkspacesAssignments**](WorkspacesApi.md#putorganizationworkspacesassignments) | **PUT** /organizations/{organization_id}/workspaces/{workspace_id}/assignments | Change assignments of users within a workspace.
[**PutTimesheetSetups**](WorkspacesApi.md#puttimesheetsetups) | **POST** /workspaces/{workspace_id}/timesheet_setups/{setup_id} | Update a timesheet setup
[**PutWorkspaceTimesheetsHandler**](WorkspacesApi.md#putworkspacetimesheetshandler) | **PUT** /workspaces/{workspace_id}/timesheets/{setup_id}/{start_date} | Update timesheets
[**PutWorkspaceTrackReminder**](WorkspacesApi.md#putworkspacetrackreminder) | **PUT** /workspaces/{workspace_id}/track_reminders/{reminder_id} | TrackReminder
[**PutWorkspaceUsers**](WorkspacesApi.md#putworkspaceusers) | **PUT** /workspaces/{workspace_id}/users/{user_id} | Update workspace user
[**PutWorkspaceWorkspaceUsers**](WorkspacesApi.md#putworkspaceworkspaceusers) | **PUT** /workspaces/{workspace_id}/workspace_users/{workspace_user_id} | Update workspace-user
[**PutWorkspaces**](WorkspacesApi.md#putworkspaces) | **PUT** /workspaces/{workspace_id} | Update workspace


<a name="deletealerts"></a>
# **DeleteAlerts**
> string DeleteAlerts ()

Alerts

Handles DELETE alert requests.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteAlertsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WorkspacesApi();

            try
            {
                // Alerts
                string result = apiInstance.DeleteAlerts();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.DeleteAlerts: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetimesheetsetups"></a>
# **DeleteTimesheetSetups**
> string DeleteTimesheetSetups (int? workspaceId, int? setupId)

Delete a timesheet setup

Delete a timesheet setup for a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteTimesheetSetupsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WorkspacesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var setupId = 56;  // int? | Numeric ID of the timesheet setup

            try
            {
                // Delete a timesheet setup
                string result = apiInstance.DeleteTimesheetSetups(workspaceId, setupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.DeleteTimesheetSetups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **setupId** | **int?**| Numeric ID of the timesheet setup | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteworkspacetrackreminder"></a>
# **DeleteWorkspaceTrackReminder**
> string DeleteWorkspaceTrackReminder (int? workspaceId, int? reminderId)

TrackReminder

Deletes a workspace tracking reminder.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteWorkspaceTrackReminderExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WorkspacesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var reminderId = 56;  // int? | Reminder ID.

            try
            {
                // TrackReminder
                string result = apiInstance.DeleteWorkspaceTrackReminder(workspaceId, reminderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.DeleteWorkspaceTrackReminder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **reminderId** | **int?**| Reminder ID. | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

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
            var apiInstance = new WorkspacesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.
            var workspaceUserId = 56;  // int? | Numeric ID of the workspace user.

            try
            {
                // Delete workspace user
                apiInstance.DeleteWorkspaceUser(workspaceId, workspaceUserId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.DeleteWorkspaceUser: " + e.Message );
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

            var apiInstance = new WorkspacesApi();
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
                Debug.Print("Exception when calling WorkspacesApi.GetOrganizationWorkspacesGroups: " + e.Message );
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

            var apiInstance = new WorkspacesApi();

            try
            {
                // Statistics for all workspaces in the organization
                Dictionary&lt;string, ModelsStatistics&gt; result = apiInstance.GetOrganizationWorkspacesStatistics();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.GetOrganizationWorkspacesStatistics: " + e.Message );
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

            var apiInstance = new WorkspacesApi();
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
                Debug.Print("Exception when calling WorkspacesApi.GetOrganizationWorkspacesWorkspaceusers: " + e.Message );
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

<a name="gettimesheetsetups"></a>
# **GetTimesheetSetups**
> TimesheetsetupsGetPaginatedResponse GetTimesheetSetups (int? workspaceId, int? memberIds = null, int? approverIds = null, string sortField = null, string sortOrder = null)

Get timesheet setups

Get timesheet setups for a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetTimesheetSetupsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WorkspacesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var memberIds = 56;  // int? | Numeric ID of the members, comma-separated (optional) 
            var approverIds = 56;  // int? | Numeric ID of the approvers, comma-separated (optional) 
            var sortField = sortField_example;  // string | Field used for sorting, default start_date. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order. (optional) 

            try
            {
                // Get timesheet setups
                TimesheetsetupsGetPaginatedResponse result = apiInstance.GetTimesheetSetups(workspaceId, memberIds, approverIds, sortField, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.GetTimesheetSetups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **memberIds** | **int?**| Numeric ID of the members, comma-separated | [optional] 
 **approverIds** | **int?**| Numeric ID of the approvers, comma-separated | [optional] 
 **sortField** | **string**| Field used for sorting, default start_date. | [optional] 
 **sortOrder** | **string**| Sort order. | [optional] 

### Return type

[**TimesheetsetupsGetPaginatedResponse**](TimesheetsetupsGetPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspace"></a>
# **GetWorkspace**
> WorkspaceWorkspace GetWorkspace (int? workspaceId)

Get single workspace

Get information of single workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WorkspacesApi();
            var workspaceId = 56;  // int? | Numeric Workspace ID

            try
            {
                // Get single workspace
                WorkspaceWorkspace result = apiInstance.GetWorkspace(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.GetWorkspace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric Workspace ID | 

### Return type

[**WorkspaceWorkspace**](WorkspaceWorkspace.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacestatistics"></a>
# **GetWorkspaceStatistics**
> ModelsStatistics GetWorkspaceStatistics ()

Workspace statistics

Returns workspace admins list, members count and groups count

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceStatisticsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WorkspacesApi();

            try
            {
                // Workspace statistics
                ModelsStatistics result = apiInstance.GetWorkspaceStatistics();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.GetWorkspaceStatistics: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ModelsStatistics**](ModelsStatistics.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacetimeentryconstraints"></a>
# **GetWorkspaceTimeEntryConstraints**
> ModelsTimeEntryConstraints GetWorkspaceTimeEntryConstraints (int? workspaceId)

Get workspace time entry constraints

Get the time entry constraints for a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceTimeEntryConstraintsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WorkspacesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace

            try
            {
                // Get workspace time entry constraints
                ModelsTimeEntryConstraints result = apiInstance.GetWorkspaceTimeEntryConstraints(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.GetWorkspaceTimeEntryConstraints: " + e.Message );
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

[**ModelsTimeEntryConstraints**](ModelsTimeEntryConstraints.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacetimesheethourshandler"></a>
# **GetWorkspaceTimesheetHoursHandler**
> List<TimesheetsTimesheetHoursResponse> GetWorkspaceTimesheetHoursHandler (int? workspaceId, TimesheetsPostTimesheetHoursPayload payload)

Get timesheets hours

Get timesheet working hours and total tracked seconds.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceTimesheetHoursHandlerExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WorkspacesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var payload = new TimesheetsPostTimesheetHoursPayload(); // TimesheetsPostTimesheetHoursPayload | Array of timesheet setup IDs and start dates.

            try
            {
                // Get timesheets hours
                List&lt;TimesheetsTimesheetHoursResponse&gt; result = apiInstance.GetWorkspaceTimesheetHoursHandler(workspaceId, payload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.GetWorkspaceTimesheetHoursHandler: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **payload** | [**TimesheetsPostTimesheetHoursPayload**](TimesheetsPostTimesheetHoursPayload.md)| Array of timesheet setup IDs and start dates. | 

### Return type

[**List<TimesheetsTimesheetHoursResponse>**](TimesheetsTimesheetHoursResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacetimesheettimeentrieshandler"></a>
# **GetWorkspaceTimesheetTimeEntriesHandler**
> List<ModelsTimeEntry> GetWorkspaceTimesheetTimeEntriesHandler (int? workspaceId, int? setupId, string startDate)

Get timesheet time entries

Get the time entries from within a timesheet timeframe.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceTimesheetTimeEntriesHandlerExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WorkspacesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var setupId = 56;  // int? | Numeric ID of the timesheet setup.
            var startDate = startDate_example;  // string | Start date (YYYY-MM-DD) of the timesheet.

            try
            {
                // Get timesheet time entries
                List&lt;ModelsTimeEntry&gt; result = apiInstance.GetWorkspaceTimesheetTimeEntriesHandler(workspaceId, setupId, startDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.GetWorkspaceTimesheetTimeEntriesHandler: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **setupId** | **int?**| Numeric ID of the timesheet setup. | 
 **startDate** | **string**| Start date (YYYY-MM-DD) of the timesheet. | 

### Return type

[**List<ModelsTimeEntry>**](ModelsTimeEntry.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacetimesheetshandler"></a>
# **GetWorkspaceTimesheetsHandler**
> List<TimesheetsGetPaginatedResponse> GetWorkspaceTimesheetsHandler (int? workspaceId, int? memberIds = null, int? approverIds = null, int? timesheetSetupIds = null, int? statuses = null, int? before = null, int? after = null, int? page = null, int? perPage = null, string sortField = null, string sortOrder = null)

Get timesheets

Get timesheets applying various filters.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceTimesheetsHandlerExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WorkspacesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var memberIds = 56;  // int? | Numeric ID of the members, comma-separated (optional) 
            var approverIds = 56;  // int? | Numeric ID of the approvers, comma-separated (optional) 
            var timesheetSetupIds = 56;  // int? | Numeric ID for timesheet setup, comma-separated. (optional) 
            var statuses = 56;  // int? | Timesheet status, comma-separated. (optional) 
            var before = 56;  // int? | Timesheets starting before this date (YYYY-MM-DD). (optional) 
            var after = 56;  // int? | Timesheets starting after this date (YYYY-MM-DD). (optional) 
            var page = 56;  // int? | Page number, default 1. (optional) 
            var perPage = 56;  // int? | Number of items per page, default 20. Also defaults to 20 if provided an greater than 1000. (optional) 
            var sortField = sortField_example;  // string | Field used for sorting, default start_date. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order. (optional) 

            try
            {
                // Get timesheets
                List&lt;TimesheetsGetPaginatedResponse&gt; result = apiInstance.GetWorkspaceTimesheetsHandler(workspaceId, memberIds, approverIds, timesheetSetupIds, statuses, before, after, page, perPage, sortField, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.GetWorkspaceTimesheetsHandler: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **memberIds** | **int?**| Numeric ID of the members, comma-separated | [optional] 
 **approverIds** | **int?**| Numeric ID of the approvers, comma-separated | [optional] 
 **timesheetSetupIds** | **int?**| Numeric ID for timesheet setup, comma-separated. | [optional] 
 **statuses** | **int?**| Timesheet status, comma-separated. | [optional] 
 **before** | **int?**| Timesheets starting before this date (YYYY-MM-DD). | [optional] 
 **after** | **int?**| Timesheets starting after this date (YYYY-MM-DD). | [optional] 
 **page** | **int?**| Page number, default 1. | [optional] 
 **perPage** | **int?**| Number of items per page, default 20. Also defaults to 20 if provided an greater than 1000. | [optional] 
 **sortField** | **string**| Field used for sorting, default start_date. | [optional] 
 **sortOrder** | **string**| Sort order. | [optional] 

### Return type

[**List<TimesheetsGetPaginatedResponse>**](TimesheetsGetPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacetrackreminders"></a>
# **GetWorkspaceTrackReminders**
> List<ModelsTrackReminder> GetWorkspaceTrackReminders (int? workspaceId)

TrackReminders

Returns a list of track reminders.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceTrackRemindersExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WorkspacesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace

            try
            {
                // TrackReminders
                List&lt;ModelsTrackReminder&gt; result = apiInstance.GetWorkspaceTrackReminders(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.GetWorkspaceTrackReminders: " + e.Message );
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

[**List<ModelsTrackReminder>**](ModelsTrackReminder.md)

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

            var apiInstance = new WorkspacesApi();
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
                Debug.Print("Exception when calling WorkspacesApi.GetWorkspaceUsers: " + e.Message );
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

<a name="getworkspaces"></a>
# **GetWorkspaces**
> List<WorkspaceWithActiveProjectCount> GetWorkspaces (int? since = null)

Workspaces

Lists workspaces for given user.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspacesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WorkspacesApi();
            var since = 56;  // int? | Retrieve workspaces created/modified/deleted since this date using UNIX timestamp, including the dates a workspace member got added, removed or updated in the workspace. (optional) 

            try
            {
                // Workspaces
                List&lt;WorkspaceWithActiveProjectCount&gt; result = apiInstance.GetWorkspaces(since);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.GetWorkspaces: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **since** | **int?**| Retrieve workspaces created/modified/deleted since this date using UNIX timestamp, including the dates a workspace member got added, removed or updated in the workspace. | [optional] 

### Return type

[**List<WorkspaceWithActiveProjectCount>**](WorkspaceWithActiveProjectCount.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

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

            var apiInstance = new WorkspacesApi();
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
                Debug.Print("Exception when calling WorkspacesApi.PatchOrganizationWorkspaceUsers: " + e.Message );
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

<a name="postalerts"></a>
# **PostAlerts**
> ModelsAlert PostAlerts (object request)

Alerts

Handles POST alert requests.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostAlertsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WorkspacesApi();
            var request = new object(); // object | Alert data

            try
            {
                // Alerts
                ModelsAlert result = apiInstance.PostAlerts(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.PostAlerts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**object**](object.md)| Alert data | 

### Return type

[**ModelsAlert**](ModelsAlert.md)

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

            var apiInstance = new WorkspacesApi();
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
                Debug.Print("Exception when calling WorkspacesApi.PostOrganizationWorkspaces: " + e.Message );
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

<a name="posttimesheetsetups"></a>
# **PostTimesheetSetups**
> List<TimesheetsetupsAPITimesheetSetup> PostTimesheetSetups (int? workspaceId, TimesheetsetupsCreatePayload payload)

Create a timesheet setup

Create timesheet setups.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostTimesheetSetupsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WorkspacesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var payload = new TimesheetsetupsCreatePayload(); // TimesheetsetupsCreatePayload | Arrays of setup creation parameters.

            try
            {
                // Create a timesheet setup
                List&lt;TimesheetsetupsAPITimesheetSetup&gt; result = apiInstance.PostTimesheetSetups(workspaceId, payload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.PostTimesheetSetups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **payload** | [**TimesheetsetupsCreatePayload**](TimesheetsetupsCreatePayload.md)| Arrays of setup creation parameters. | 

### Return type

[**List<TimesheetsetupsAPITimesheetSetup>**](TimesheetsetupsAPITimesheetSetup.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postworkspacetrackreminders"></a>
# **PostWorkspaceTrackReminders**
> ModelsTrackReminder PostWorkspaceTrackReminders (int? workspaceId, RemindersPayload trackReminderPost)

TrackReminders

Creates a workspace tracking reminder.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostWorkspaceTrackRemindersExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WorkspacesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var trackReminderPost = new RemindersPayload(); // RemindersPayload | Reminder parameters.

            try
            {
                // TrackReminders
                ModelsTrackReminder result = apiInstance.PostWorkspaceTrackReminders(workspaceId, trackReminderPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.PostWorkspaceTrackReminders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **trackReminderPost** | [**RemindersPayload**](RemindersPayload.md)| Reminder parameters. | 

### Return type

[**ModelsTrackReminder**](ModelsTrackReminder.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

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

            var apiInstance = new WorkspacesApi();
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
                Debug.Print("Exception when calling WorkspacesApi.PostWorkspaceUsersLostPassword: " + e.Message );
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

            var apiInstance = new WorkspacesApi();
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
                Debug.Print("Exception when calling WorkspacesApi.PutOrganizationWorkspacesAssignments: " + e.Message );
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

<a name="puttimesheetsetups"></a>
# **PutTimesheetSetups**
> TimesheetsetupsAPITimesheetSetup PutTimesheetSetups (int? workspaceId, int? setupId, TimesheetsetupsUpdatePayload payload)

Update a timesheet setup

Updates a timesheet setups.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutTimesheetSetupsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WorkspacesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var setupId = 56;  // int? | Numeric ID of the timesheet setup
            var payload = new TimesheetsetupsUpdatePayload(); // TimesheetsetupsUpdatePayload | Setup update parameters.

            try
            {
                // Update a timesheet setup
                TimesheetsetupsAPITimesheetSetup result = apiInstance.PutTimesheetSetups(workspaceId, setupId, payload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.PutTimesheetSetups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **setupId** | **int?**| Numeric ID of the timesheet setup | 
 **payload** | [**TimesheetsetupsUpdatePayload**](TimesheetsetupsUpdatePayload.md)| Setup update parameters. | 

### Return type

[**TimesheetsetupsAPITimesheetSetup**](TimesheetsetupsAPITimesheetSetup.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putworkspacetimesheetshandler"></a>
# **PutWorkspaceTimesheetsHandler**
> TimesheetsAPITimesheet PutWorkspaceTimesheetsHandler (int? workspaceId, int? setupId, string startDate, TimesheetsPutTimesheetPayload payload)

Update timesheets

Updates a timesheet.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutWorkspaceTimesheetsHandlerExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WorkspacesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var setupId = 56;  // int? | Numeric ID of the timesheet setup.
            var startDate = startDate_example;  // string | Start date (YYYY-MM-DD) of the timesheet.
            var payload = new TimesheetsPutTimesheetPayload(); // TimesheetsPutTimesheetPayload | Timesheet status and rejection comment.

            try
            {
                // Update timesheets
                TimesheetsAPITimesheet result = apiInstance.PutWorkspaceTimesheetsHandler(workspaceId, setupId, startDate, payload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.PutWorkspaceTimesheetsHandler: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **setupId** | **int?**| Numeric ID of the timesheet setup. | 
 **startDate** | **string**| Start date (YYYY-MM-DD) of the timesheet. | 
 **payload** | [**TimesheetsPutTimesheetPayload**](TimesheetsPutTimesheetPayload.md)| Timesheet status and rejection comment. | 

### Return type

[**TimesheetsAPITimesheet**](TimesheetsAPITimesheet.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putworkspacetrackreminder"></a>
# **PutWorkspaceTrackReminder**
> ModelsTrackReminder PutWorkspaceTrackReminder (int? workspaceId, int? reminderId, RemindersPayload trackReminderPost)

TrackReminder

Updates a workspace tracking reminder.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutWorkspaceTrackReminderExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WorkspacesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var reminderId = 56;  // int? | Reminder ID.
            var trackReminderPost = new RemindersPayload(); // RemindersPayload | Reminder parameters.

            try
            {
                // TrackReminder
                ModelsTrackReminder result = apiInstance.PutWorkspaceTrackReminder(workspaceId, reminderId, trackReminderPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.PutWorkspaceTrackReminder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **reminderId** | **int?**| Reminder ID. | 
 **trackReminderPost** | [**RemindersPayload**](RemindersPayload.md)| Reminder parameters. | 

### Return type

[**ModelsTrackReminder**](ModelsTrackReminder.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

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

            var apiInstance = new WorkspacesApi();
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
                Debug.Print("Exception when calling WorkspacesApi.PutWorkspaceUsers: " + e.Message );
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

            var apiInstance = new WorkspacesApi();
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
                Debug.Print("Exception when calling WorkspacesApi.PutWorkspaceWorkspaceUsers: " + e.Message );
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

<a name="putworkspaces"></a>
# **PutWorkspaces**
> WorkspaceWorkspace PutWorkspaces (int? workspaceId, WorkspacePayload post)

Update workspace

Update a specific workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutWorkspacesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WorkspacesApi();
            var workspaceId = 56;  // int? | Numeric Workspace ID
            var post = new WorkspacePayload(); // WorkspacePayload | Workspace parameters

            try
            {
                // Update workspace
                WorkspaceWorkspace result = apiInstance.PutWorkspaces(workspaceId, post);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.PutWorkspaces: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric Workspace ID | 
 **post** | [**WorkspacePayload**](WorkspacePayload.md)| Workspace parameters | 

### Return type

[**WorkspaceWorkspace**](WorkspaceWorkspace.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

