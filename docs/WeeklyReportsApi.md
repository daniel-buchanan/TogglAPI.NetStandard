# TogglAPI.NetStandard.Api.WeeklyReportsApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesCsvPost**](WeeklyReportsApi.md#reportsapiv3workspaceworkspaceidweeklytimeentriescsvpost) | **POST** /reports/api/v3/workspace/{workspace_id}/weekly/time_entries.csv | Export weekly report
[**ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesPdfPost**](WeeklyReportsApi.md#reportsapiv3workspaceworkspaceidweeklytimeentriespdfpost) | **POST** /reports/api/v3/workspace/{workspace_id}/weekly/time_entries.pdf | Export weekly report
[**ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesPost**](WeeklyReportsApi.md#reportsapiv3workspaceworkspaceidweeklytimeentriespost) | **POST** /reports/api/v3/workspace/{workspace_id}/weekly/time_entries | Search time entries


<a name="reportsapiv3workspaceworkspaceidweeklytimeentriescsvpost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesCsvPost**
> string ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesCsvPost (int? workspaceId, WeeklyExportPost weeklyExportPost)

Export weekly report

Downloads weekly report in csv format.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesCsvPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WeeklyReportsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var weeklyExportPost = new WeeklyExportPost(); // WeeklyExportPost | Weekly report conditions

            try
            {
                // Export weekly report
                string result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesCsvPost(workspaceId, weeklyExportPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WeeklyReportsApi.ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesCsvPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **weeklyExportPost** | [**WeeklyExportPost**](WeeklyExportPost.md)| Weekly report conditions | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3workspaceworkspaceidweeklytimeentriespdfpost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesPdfPost**
> string ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesPdfPost (int? workspaceId, WeeklyExportPDFPost weeklyExportPdfPost)

Export weekly report

Downloads weekly report in pdf format.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesPdfPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WeeklyReportsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var weeklyExportPdfPost = new WeeklyExportPDFPost(); // WeeklyExportPDFPost | Weekly report conditions

            try
            {
                // Export weekly report
                string result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesPdfPost(workspaceId, weeklyExportPdfPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WeeklyReportsApi.ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesPdfPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **weeklyExportPdfPost** | [**WeeklyExportPDFPost**](WeeklyExportPDFPost.md)| Weekly report conditions | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3workspaceworkspaceidweeklytimeentriespost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesPost**
> string ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesPost (int? workspaceId, BasePost post)

Search time entries

Returns time entries for weekly report according to the given filters.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WeeklyReportsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var post = new BasePost(); // BasePost | Weekly report conditions

            try
            {
                // Search time entries
                string result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesPost(workspaceId, post);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WeeklyReportsApi.ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **post** | [**BasePost**](BasePost.md)| Weekly report conditions | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

