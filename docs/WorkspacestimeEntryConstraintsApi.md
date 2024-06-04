# TogglAPI.NetStandard.Api.WorkspacestimeEntryConstraintsApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostWorkspaceTimeEntryConstraints**](WorkspacestimeEntryConstraintsApi.md#postworkspacetimeentryconstraints) | **POST** /workspaces/{workspace_id}/time_entry_constraints | Post workspace time entry constraints


<a name="postworkspacetimeentryconstraints"></a>
# **PostWorkspaceTimeEntryConstraints**
> WorkspacesJSONResult PostWorkspaceTimeEntryConstraints (int? workspaceId, ModelsTimeEntryConstraints timeEntryConstraints)

Post workspace time entry constraints

Post the time entry constraints for a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostWorkspaceTimeEntryConstraintsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WorkspacestimeEntryConstraintsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var timeEntryConstraints = new ModelsTimeEntryConstraints(); // ModelsTimeEntryConstraints | Input data of the time entry constraints.

            try
            {
                // Post workspace time entry constraints
                WorkspacesJSONResult result = apiInstance.PostWorkspaceTimeEntryConstraints(workspaceId, timeEntryConstraints);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacestimeEntryConstraintsApi.PostWorkspaceTimeEntryConstraints: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **timeEntryConstraints** | [**ModelsTimeEntryConstraints**](ModelsTimeEntryConstraints.md)| Input data of the time entry constraints. | 

### Return type

[**WorkspacesJSONResult**](WorkspacesJSONResult.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

