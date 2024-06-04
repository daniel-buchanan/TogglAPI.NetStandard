# TogglAPI.NetStandard.Api.GoalsApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GoalsGoalIdStatsGet**](GoalsApi.md#goalsgoalidstatsget) | **GET** /goals/{goal_id}/stats | Get stats for a goal
[**GoalsInsightPost**](GoalsApi.md#goalsinsightpost) | **POST** /goals/insight | Get a insight
[**MeGoalsGet**](GoalsApi.md#megoalsget) | **GET** /me/goals | Get a list of user goals
[**WorkspacesWorkspaceIdGoalsGet**](GoalsApi.md#workspacesworkspaceidgoalsget) | **GET** /workspaces/{workspace_id}/goals | Get a list of goals
[**WorkspacesWorkspaceIdGoalsGoalIdDelete**](GoalsApi.md#workspacesworkspaceidgoalsgoaliddelete) | **DELETE** /workspaces/{workspace_id}/goals/{goal_id} | Delete one goal
[**WorkspacesWorkspaceIdGoalsGoalIdGet**](GoalsApi.md#workspacesworkspaceidgoalsgoalidget) | **GET** /workspaces/{workspace_id}/goals/{goal_id} | Get one goal
[**WorkspacesWorkspaceIdGoalsGoalIdPut**](GoalsApi.md#workspacesworkspaceidgoalsgoalidput) | **PUT** /workspaces/{workspace_id}/goals/{goal_id} | Update a Goal
[**WorkspacesWorkspaceIdGoalsPost**](GoalsApi.md#workspacesworkspaceidgoalspost) | **POST** /workspaces/{workspace_id}/goals | Create a Goal


<a name="goalsgoalidstatsget"></a>
# **GoalsGoalIdStatsGet**
> ModelsGoalStats GoalsGoalIdStatsGet (int? goalId)

Get stats for a goal

Gets stats for a given goal that must belong to the calling user

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GoalsGoalIdStatsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GoalsApi();
            var goalId = 56;  // int? | Goal ID

            try
            {
                // Get stats for a goal
                ModelsGoalStats result = apiInstance.GoalsGoalIdStatsGet(goalId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GoalsApi.GoalsGoalIdStatsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **goalId** | **int?**| Goal ID | 

### Return type

[**ModelsGoalStats**](ModelsGoalStats.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="goalsinsightpost"></a>
# **GoalsInsightPost**
> GoalsInsightResponse GoalsInsightPost (GoalsParamsInsight goal)

Get a insight

Get data insight for user simulating how much the user would accomplish for a given Goal

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GoalsInsightPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GoalsApi();
            var goal = new GoalsParamsInsight(); // GoalsParamsInsight | Insight details

            try
            {
                // Get a insight
                GoalsInsightResponse result = apiInstance.GoalsInsightPost(goal);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GoalsApi.GoalsInsightPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **goal** | [**GoalsParamsInsight**](GoalsParamsInsight.md)| Insight details | 

### Return type

[**GoalsInsightResponse**](GoalsInsightResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="megoalsget"></a>
# **MeGoalsGet**
> List<HandlergoalsAPIResponse> MeGoalsGet (bool? active = null)

Get a list of user goals

Gets all goals for the requesting user.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class MeGoalsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GoalsApi();
            var active = true;  // bool? | archived goals (optional) 

            try
            {
                // Get a list of user goals
                List&lt;HandlergoalsAPIResponse&gt; result = apiInstance.MeGoalsGet(active);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GoalsApi.MeGoalsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **active** | **bool?**| archived goals | [optional] 

### Return type

[**List<HandlergoalsAPIResponse>**](HandlergoalsAPIResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workspacesworkspaceidgoalsget"></a>
# **WorkspacesWorkspaceIdGoalsGet**
> List<HandlergoalsAPIResponse> WorkspacesWorkspaceIdGoalsGet (bool? teamGoals = null, bool? active = null)

Get a list of goals

Gets all goals for the requesting user in the workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class WorkspacesWorkspaceIdGoalsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GoalsApi();
            var teamGoals = true;  // bool? | team goals (optional) 
            var active = true;  // bool? | archived goals (optional) 

            try
            {
                // Get a list of goals
                List&lt;HandlergoalsAPIResponse&gt; result = apiInstance.WorkspacesWorkspaceIdGoalsGet(teamGoals, active);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GoalsApi.WorkspacesWorkspaceIdGoalsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamGoals** | **bool?**| team goals | [optional] 
 **active** | **bool?**| archived goals | [optional] 

### Return type

[**List<HandlergoalsAPIResponse>**](HandlergoalsAPIResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workspacesworkspaceidgoalsgoaliddelete"></a>
# **WorkspacesWorkspaceIdGoalsGoalIdDelete**
> void WorkspacesWorkspaceIdGoalsGoalIdDelete (int? workspaceId, int? goalId)

Delete one goal

Delete a goal that was created by the calling user

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class WorkspacesWorkspaceIdGoalsGoalIdDeleteExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GoalsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var goalId = 56;  // int? | Goal ID

            try
            {
                // Delete one goal
                apiInstance.WorkspacesWorkspaceIdGoalsGoalIdDelete(workspaceId, goalId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GoalsApi.WorkspacesWorkspaceIdGoalsGoalIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **goalId** | **int?**| Goal ID | 

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workspacesworkspaceidgoalsgoalidget"></a>
# **WorkspacesWorkspaceIdGoalsGoalIdGet**
> HandlergoalsAPIResponse WorkspacesWorkspaceIdGoalsGoalIdGet (int? workspaceId, int? goalId)

Get one goal

Gets a goal that relates to the calling user in the specified workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class WorkspacesWorkspaceIdGoalsGoalIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GoalsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var goalId = 56;  // int? | Goal ID

            try
            {
                // Get one goal
                HandlergoalsAPIResponse result = apiInstance.WorkspacesWorkspaceIdGoalsGoalIdGet(workspaceId, goalId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GoalsApi.WorkspacesWorkspaceIdGoalsGoalIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **goalId** | **int?**| Goal ID | 

### Return type

[**HandlergoalsAPIResponse**](HandlergoalsAPIResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workspacesworkspaceidgoalsgoalidput"></a>
# **WorkspacesWorkspaceIdGoalsGoalIdPut**
> ModelsGoal WorkspacesWorkspaceIdGoalsGoalIdPut (HandlergoalsUpdatePayload goal)

Update a Goal

Update a goal with the updatable parameters given by UpdatePayload

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class WorkspacesWorkspaceIdGoalsGoalIdPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GoalsApi();
            var goal = new HandlergoalsUpdatePayload(); // HandlergoalsUpdatePayload | Goal details

            try
            {
                // Update a Goal
                ModelsGoal result = apiInstance.WorkspacesWorkspaceIdGoalsGoalIdPut(goal);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GoalsApi.WorkspacesWorkspaceIdGoalsGoalIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **goal** | [**HandlergoalsUpdatePayload**](HandlergoalsUpdatePayload.md)| Goal details | 

### Return type

[**ModelsGoal**](ModelsGoal.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workspacesworkspaceidgoalspost"></a>
# **WorkspacesWorkspaceIdGoalsPost**
> ModelsGoal WorkspacesWorkspaceIdGoalsPost (HandlergoalsCreatePayload goal)

Create a Goal

Create a Goal object with its parameters.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class WorkspacesWorkspaceIdGoalsPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GoalsApi();
            var goal = new HandlergoalsCreatePayload(); // HandlergoalsCreatePayload | Goal details

            try
            {
                // Create a Goal
                ModelsGoal result = apiInstance.WorkspacesWorkspaceIdGoalsPost(goal);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GoalsApi.WorkspacesWorkspaceIdGoalsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **goal** | [**HandlergoalsCreatePayload**](HandlergoalsCreatePayload.md)| Goal details | 

### Return type

[**ModelsGoal**](ModelsGoal.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

