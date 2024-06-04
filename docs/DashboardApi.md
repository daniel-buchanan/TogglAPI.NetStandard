# TogglAPI.NetStandard.Api.DashboardApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetWorkspaceAllActivities**](DashboardApi.md#getworkspaceallactivities) | **GET** /workspaces/{workspace_id}/dashboard/all_activity | Get last activity for every workspace user
[**GetWorkspaceMostActive**](DashboardApi.md#getworkspacemostactive) | **GET** /workspaces/{workspace_id}/dashboard/most_active | Get most active users
[**GetWorkspaceTopActivity**](DashboardApi.md#getworkspacetopactivity) | **GET** /workspaces/{workspace_id}/dashboard/top_activity | Get top activities


<a name="getworkspaceallactivities"></a>
# **GetWorkspaceAllActivities**
> List<DashboardAllActivities> GetWorkspaceAllActivities (int? workspaceId, int? since = null)

Get last activity for every workspace user

Dashboard's main purpose is to give an overview of what users in the workspace are doing and have been doing. The activity object holds the data of 20 latest actions in the workspace or latest activity for every workspace user. Activity object has the following properties * user_id: user ID * project_id: project ID (ID is 0 if time entry doesn't have project connected to it) * duration: time entry duration in seconds. If the time entry is currently running, the duration attribute contains a negative value, denoting the start of the time entry in seconds since epoch (Jan 1 1970). The correct duration can be calculated as current_time + duration, where current_time is the current time in seconds since epoch. * description: (Description property is not present if time entry description is empty) * stop: time entry stop time (ISO 8601 date and time. Stop property is not present when time entry is still running) * tid: task id, if applicable

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceAllActivitiesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DashboardApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var since = 56;  // int? | Filter activities since this date using UNIX timestamp. (optional) 

            try
            {
                // Get last activity for every workspace user
                List&lt;DashboardAllActivities&gt; result = apiInstance.GetWorkspaceAllActivities(workspaceId, since);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DashboardApi.GetWorkspaceAllActivities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **since** | **int?**| Filter activities since this date using UNIX timestamp. | [optional] 

### Return type

[**List<DashboardAllActivities>**](DashboardAllActivities.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacemostactive"></a>
# **GetWorkspaceMostActive**
> List<ModelsMostActiveUser> GetWorkspaceMostActive (int? workspaceId, int? since = null)

Get most active users

Dashboard's main purpose is to give an overview of what users in the workspace are doing and have been doing. The most active user object holds the data of the top 5 users who have tracked the most time during last 7 days. Most active user object has the following properties * user_id: user ID * duration: Sum of time entry durations that have been created during last 7 days.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceMostActiveExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DashboardApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var since = 56;  // int? | Filter activities since this date using UNIX timestamp. (optional) 

            try
            {
                // Get most active users
                List&lt;ModelsMostActiveUser&gt; result = apiInstance.GetWorkspaceMostActive(workspaceId, since);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DashboardApi.GetWorkspaceMostActive: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **since** | **int?**| Filter activities since this date using UNIX timestamp. | [optional] 

### Return type

[**List<ModelsMostActiveUser>**](ModelsMostActiveUser.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacetopactivity"></a>
# **GetWorkspaceTopActivity**
> List<DashboardAllActivities> GetWorkspaceTopActivity (int? workspaceId, int? since = null)

Get top activities

Dashboard's main purpose is to give an overview of what users in the workspace are doing and have been doing. Return objects are same as with the `/workspaces/{workspace_id}/dashboard/all_activity` request.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceTopActivityExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DashboardApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var since = 56;  // int? | Filter activities since this date using UNIX timestamp. (optional) 

            try
            {
                // Get top activities
                List&lt;DashboardAllActivities&gt; result = apiInstance.GetWorkspaceTopActivity(workspaceId, since);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DashboardApi.GetWorkspaceTopActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **since** | **int?**| Filter activities since this date using UNIX timestamp. | [optional] 

### Return type

[**List<DashboardAllActivities>**](DashboardAllActivities.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

