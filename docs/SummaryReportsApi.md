# TogglAPI.NetStandard.Api.SummaryReportsApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReportsApiV3WorkspaceWorkspaceIdProjectsProjectIdSummaryPost**](SummaryReportsApi.md#reportsapiv3workspaceworkspaceidprojectsprojectidsummarypost) | **POST** /reports/api/v3/workspace/{workspace_id}/projects/{project_id}/summary | Load project summary
[**ReportsApiV3WorkspaceWorkspaceIdProjectsSummaryPost**](SummaryReportsApi.md#reportsapiv3workspaceworkspaceidprojectssummarypost) | **POST** /reports/api/v3/workspace/{workspace_id}/projects/summary | List project users
[**ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesExtensionPost**](SummaryReportsApi.md#reportsapiv3workspaceworkspaceidsummarytimeentriesextensionpost) | **POST** /reports/api/v3/workspace/{workspace_id}/summary/time_entries.{extension} | Export summary report
[**ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesPdfPost**](SummaryReportsApi.md#reportsapiv3workspaceworkspaceidsummarytimeentriespdfpost) | **POST** /reports/api/v3/workspace/{workspace_id}/summary/time_entries.pdf | Export summary report
[**ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesPost**](SummaryReportsApi.md#reportsapiv3workspaceworkspaceidsummarytimeentriespost) | **POST** /reports/api/v3/workspace/{workspace_id}/summary/time_entries | Search time entries


<a name="reportsapiv3workspaceworkspaceidprojectsprojectidsummarypost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdProjectsProjectIdSummaryPost**
> TotalsReportData ReportsApiV3WorkspaceWorkspaceIdProjectsProjectIdSummaryPost (int? workspaceId, int? projectId, BaseRangePost rangePost = null)

Load project summary

Returns project's summary.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdProjectsProjectIdSummaryPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SummaryReportsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var projectId = 56;  // int? | Project ID
            var rangePost = new BaseRangePost(); // BaseRangePost | Date range conditions (optional) 

            try
            {
                // Load project summary
                TotalsReportData result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdProjectsProjectIdSummaryPost(workspaceId, projectId, rangePost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SummaryReportsApi.ReportsApiV3WorkspaceWorkspaceIdProjectsProjectIdSummaryPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **projectId** | **int?**| Project ID | 
 **rangePost** | [**BaseRangePost**](BaseRangePost.md)| Date range conditions | [optional] 

### Return type

[**TotalsReportData**](TotalsReportData.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3workspaceworkspaceidprojectssummarypost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdProjectsSummaryPost**
> List<UsersProjectUsersSummaryRow> ReportsApiV3WorkspaceWorkspaceIdProjectsSummaryPost (int? workspaceId, DtoProjectUsersRequest projectUsersInput)

List project users

Returns summary user projects.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdProjectsSummaryPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SummaryReportsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var projectUsersInput = new DtoProjectUsersRequest(); // DtoProjectUsersRequest | User projects summary input filter

            try
            {
                // List project users
                List&lt;UsersProjectUsersSummaryRow&gt; result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdProjectsSummaryPost(workspaceId, projectUsersInput);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SummaryReportsApi.ReportsApiV3WorkspaceWorkspaceIdProjectsSummaryPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **projectUsersInput** | [**DtoProjectUsersRequest**](DtoProjectUsersRequest.md)| User projects summary input filter | 

### Return type

[**List<UsersProjectUsersSummaryRow>**](UsersProjectUsersSummaryRow.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3workspaceworkspaceidsummarytimeentriesextensionpost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesExtensionPost**
> string ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesExtensionPost (int? workspaceId, string extension, SummaryExportPost summaryExportPost)

Export summary report

Downloads summary report in the specified in the specified format: csv or xlsx.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesExtensionPostExample
    {
        public void main()
        {
            var apiInstance = new SummaryReportsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var extension = extension_example;  // string | csv,xlsx
            var summaryExportPost = new SummaryExportPost(); // SummaryExportPost | Summary report conditions

            try
            {
                // Export summary report
                string result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesExtensionPost(workspaceId, extension, summaryExportPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SummaryReportsApi.ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesExtensionPost: " + e.Message );
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
 **summaryExportPost** | [**SummaryExportPost**](SummaryExportPost.md)| Summary report conditions | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv, text/xlsx

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3workspaceworkspaceidsummarytimeentriespdfpost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesPdfPost**
> string ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesPdfPost (int? workspaceId, SummaryExportPDFPost summaryExportPdfPost)

Export summary report

Downloads summary report in pdf format.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesPdfPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SummaryReportsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var summaryExportPdfPost = new SummaryExportPDFPost(); // SummaryExportPDFPost | Summary report conditions

            try
            {
                // Export summary report
                string result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesPdfPost(workspaceId, summaryExportPdfPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SummaryReportsApi.ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesPdfPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **summaryExportPdfPost** | [**SummaryExportPDFPost**](SummaryExportPDFPost.md)| Summary report conditions | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3workspaceworkspaceidsummarytimeentriespost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesPost**
> string ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesPost (int? workspaceId, SummaryReportPost summaryPost)

Search time entries

Returns time entries for summary report according to the given filters.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SummaryReportsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var summaryPost = new SummaryReportPost(); // SummaryReportPost | Summary report conditions

            try
            {
                // Search time entries
                string result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesPost(workspaceId, summaryPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SummaryReportsApi.ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **summaryPost** | [**SummaryReportPost**](SummaryReportPost.md)| Summary report conditions | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

