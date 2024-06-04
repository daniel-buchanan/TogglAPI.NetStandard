# TogglAPI.NetStandard.Api.DetailedReportsApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesExtensionPost**](DetailedReportsApi.md#reportsapiv3workspaceworkspaceidsearchtimeentriesextensionpost) | **POST** /reports/api/v3/workspace/{workspace_id}/search/time_entries.{extension} | Export detailed report
[**ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesPdfPost**](DetailedReportsApi.md#reportsapiv3workspaceworkspaceidsearchtimeentriespdfpost) | **POST** /reports/api/v3/workspace/{workspace_id}/search/time_entries.pdf | Export detailed report
[**ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesPost**](DetailedReportsApi.md#reportsapiv3workspaceworkspaceidsearchtimeentriespost) | **POST** /reports/api/v3/workspace/{workspace_id}/search/time_entries | Search time entries
[**ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesTotalsPost**](DetailedReportsApi.md#reportsapiv3workspaceworkspaceidsearchtimeentriestotalspost) | **POST** /reports/api/v3/workspace/{workspace_id}/search/time_entries/totals | Load totals detailed report


<a name="reportsapiv3workspaceworkspaceidsearchtimeentriesextensionpost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesExtensionPost**
> string ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesExtensionPost (int? workspaceId, string extension, DetailedSearchExportPost detailedExportPost)

Export detailed report

Downloads detailed report in the specified format: csv or xlsx.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesExtensionPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DetailedReportsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var extension = extension_example;  // string | csv,xlsx
            var detailedExportPost = new DetailedSearchExportPost(); // DetailedSearchExportPost | Detailed report conditions

            try
            {
                // Export detailed report
                string result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesExtensionPost(workspaceId, extension, detailedExportPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DetailedReportsApi.ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesExtensionPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **extension** | **string**| csv,xlsx | 
 **detailedExportPost** | [**DetailedSearchExportPost**](DetailedSearchExportPost.md)| Detailed report conditions | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv, text/xlsx

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3workspaceworkspaceidsearchtimeentriespdfpost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesPdfPost**
> string ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesPdfPost (int? workspaceId, DetailedExportPDFPost detailedExportPdfPost)

Export detailed report

Downloads detailed report in pdf format.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesPdfPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DetailedReportsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var detailedExportPdfPost = new DetailedExportPDFPost(); // DetailedExportPDFPost | Detailed report conditions

            try
            {
                // Export detailed report
                string result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesPdfPost(workspaceId, detailedExportPdfPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DetailedReportsApi.ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesPdfPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **detailedExportPdfPost** | [**DetailedExportPDFPost**](DetailedExportPDFPost.md)| Detailed report conditions | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3workspaceworkspaceidsearchtimeentriespost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesPost**
> string ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesPost (int? workspaceId, DetailedPost searchPost)

Search time entries

Returns time entries for detailed report according to the given filters. Supports pagination via X-Next-ID and X-Next-Row-Number headers returned in the response. See [Overview](https://developers.track.toggl.com/docs/reports_start#detailed-reports)

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DetailedReportsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var searchPost = new DetailedPost(); // DetailedPost | Search report conditions

            try
            {
                // Search time entries
                string result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesPost(workspaceId, searchPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DetailedReportsApi.ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **searchPost** | [**DetailedPost**](DetailedPost.md)| Search report conditions | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3workspaceworkspaceidsearchtimeentriestotalspost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesTotalsPost**
> string ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesTotalsPost (int? workspaceId, TotalsReportPost totalsPost)

Load totals detailed report

Returns totals sums for detailed report.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesTotalsPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DetailedReportsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var totalsPost = new TotalsReportPost(); // TotalsReportPost | Totals detailed report conditions

            try
            {
                // Load totals detailed report
                string result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesTotalsPost(workspaceId, totalsPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DetailedReportsApi.ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesTotalsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **totalsPost** | [**TotalsReportPost**](TotalsReportPost.md)| Totals detailed report conditions | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

