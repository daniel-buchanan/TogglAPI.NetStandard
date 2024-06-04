# TogglAPI.NetStandard.Api.TimeEntryConstraintsApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetWorkspaceTimeEntryConstraints**](TimeEntryConstraintsApi.md#getworkspacetimeentryconstraints) | **GET** /workspaces/{workspace_id}/time_entry_constraints | Get workspace time entry constraints


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

            var apiInstance = new TimeEntryConstraintsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace

            try
            {
                // Get workspace time entry constraints
                ModelsTimeEntryConstraints result = apiInstance.GetWorkspaceTimeEntryConstraints(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeEntryConstraintsApi.GetWorkspaceTimeEntryConstraints: " + e.Message );
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

