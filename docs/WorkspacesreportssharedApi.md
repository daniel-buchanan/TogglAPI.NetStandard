# TogglAPI.NetStandard.Api.WorkspacesreportssharedApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkDeleteSavedReportResource**](WorkspacesreportssharedApi.md#bulkdeletesavedreportresource) | **PATCH** /workspaces/{workspace_id}/reports/shared/bulk_delete | SavedReport


<a name="bulkdeletesavedreportresource"></a>
# **BulkDeleteSavedReportResource**
> List<ModelsSavedReport> BulkDeleteSavedReportResource (int? workspaceId, SharedBulkDeleteInputData inputData)

SavedReport

Bulk delete saved report.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class BulkDeleteSavedReportResourceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WorkspacesreportssharedApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.
            var inputData = new SharedBulkDeleteInputData(); // SharedBulkDeleteInputData | Input data

            try
            {
                // SavedReport
                List&lt;ModelsSavedReport&gt; result = apiInstance.BulkDeleteSavedReportResource(workspaceId, inputData);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesreportssharedApi.BulkDeleteSavedReportResource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace. | 
 **inputData** | [**SharedBulkDeleteInputData**](SharedBulkDeleteInputData.md)| Input data | 

### Return type

[**List<ModelsSavedReport>**](ModelsSavedReport.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

