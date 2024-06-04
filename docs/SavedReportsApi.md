# TogglAPI.NetStandard.Api.SavedReportsApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReportsApiV3SharedReportTokenCsvPost**](SavedReportsApi.md#reportsapiv3sharedreporttokencsvpost) | **POST** /reports/api/v3/shared/{report_token}.csv | Export CSV for saved report
[**ReportsApiV3SharedReportTokenPdfPost**](SavedReportsApi.md#reportsapiv3sharedreporttokenpdfpost) | **POST** /reports/api/v3/shared/{report_token}/pdf | Export saved report in pdf format
[**ReportsApiV3SharedReportTokenPost**](SavedReportsApi.md#reportsapiv3sharedreporttokenpost) | **POST** /reports/api/v3/shared/{report_token} | Load the previously saved report
[**ReportsApiV3SharedReportTokenXlsxPost**](SavedReportsApi.md#reportsapiv3sharedreporttokenxlsxpost) | **POST** /reports/api/v3/shared/{report_token}.xlsx | Export XSLX saved report


<a name="reportsapiv3sharedreporttokencsvpost"></a>
# **ReportsApiV3SharedReportTokenCsvPost**
> string ReportsApiV3SharedReportTokenCsvPost (string reportToken, string startDate = null, string endDate = null)

Export CSV for saved report

<p>Downloads a previously saved report in csv.</p> <p><b>Authentication</b></p><p>A public report is accessible by anyone, a private one is only accessible by the report's owner or workspace admin. If the criteria aren't met it returns 403 status code.</p> <p><b>Parameters</b></p><p>The report can be executed without parameters, and in this case the saved or default parameters will be used.</p>

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3SharedReportTokenCsvPostExample
    {
        public void main()
        {
            var apiInstance = new SavedReportsApi();
            var reportToken = reportToken_example;  // string | Token for the saved report
            var startDate = startDate_example;  // string | Starting date in the format YYYY-MM-DD (optional) 
            var endDate = endDate_example;  // string | End date in the format YYYY-MM-DD (optional) 

            try
            {
                // Export CSV for saved report
                string result = apiInstance.ReportsApiV3SharedReportTokenCsvPost(reportToken, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SavedReportsApi.ReportsApiV3SharedReportTokenCsvPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportToken** | **string**| Token for the saved report | 
 **startDate** | **string**| Starting date in the format YYYY-MM-DD | [optional] 
 **endDate** | **string**| End date in the format YYYY-MM-DD | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3sharedreporttokenpdfpost"></a>
# **ReportsApiV3SharedReportTokenPdfPost**
> string ReportsApiV3SharedReportTokenPdfPost (string reportToken, string startDate = null, string endDate = null, string displayMode = null)

Export saved report in pdf format

<p><b>Authentication</b></p><p>A public report is accessible by anyone, a private one is only accessible by the report's owner or workspace admin. If the criteria aren't met it returns 403 status code.</p> <p><b>Parameters</b></p><p>The report can be executed without parameters, and in this case the saved or default parameters will be used.</p>

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3SharedReportTokenPdfPostExample
    {
        public void main()
        {
            var apiInstance = new SavedReportsApi();
            var reportToken = reportToken_example;  // string | Token for the saved report
            var startDate = startDate_example;  // string | Starting date in the format YYYY-MM-DD (optional) 
            var endDate = endDate_example;  // string | End date in the format YYYY-MM-DD (optional) 
            var displayMode = displayMode_example;  // string | Display mode for time data, only for detailed reports. Possible values: 'date_only', 'time_only', 'date_time'. Default value: 'date_and_time' (optional) 

            try
            {
                // Export saved report in pdf format
                string result = apiInstance.ReportsApiV3SharedReportTokenPdfPost(reportToken, startDate, endDate, displayMode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SavedReportsApi.ReportsApiV3SharedReportTokenPdfPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportToken** | **string**| Token for the saved report | 
 **startDate** | **string**| Starting date in the format YYYY-MM-DD | [optional] 
 **endDate** | **string**| End date in the format YYYY-MM-DD | [optional] 
 **displayMode** | **string**| Display mode for time data, only for detailed reports. Possible values: &#39;date_only&#39;, &#39;time_only&#39;, &#39;date_time&#39;. Default value: &#39;date_and_time&#39; | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3sharedreporttokenpost"></a>
# **ReportsApiV3SharedReportTokenPost**
> SavedReportOutput ReportsApiV3SharedReportTokenPost (string reportToken, string startDate = null, int? firstTimestamp = null, string endDate = null, List<int?> groupIds = null, List<int?> userIds = null, List<int?> clientIds = null, List<int?> projectIds = null, List<int?> taskIds = null, List<int?> tagIds = null, string description = null, bool? billable = null, int? rounding = null, int? roundingMinutes = null, bool? grouped = null, string grouping = null, string subGrouping = null)

Load the previously saved report

<p>Returns the previously saved report.</p> <p><b>Authentication</b></p><p>A public report is accessible by anyone, a private one is only accessible by the report's owner or workspace admin. If the criteria aren't met it returns 403 status code.</p> <p><b>Parameters</b></p><p>The report can be executed without parameters, and in this case the saved or default parameters will be used.</p>

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3SharedReportTokenPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SavedReportsApi();
            var reportToken = reportToken_example;  // string | Token for the saved report
            var startDate = startDate_example;  // string | Starting date in the format YYYY-MM-DD (optional) 
            var firstTimestamp = 56;  // int? | Unix timestamp(UTC) or null for proper pagination. This parameter only works in Detailed and Summary reports. (optional) 
            var endDate = endDate_example;  // string | End date in the format YYYY-MM-DD. This parameter only works in Detailed and Summary reports. (optional) 
            var groupIds = ;  // List<int?> | Integer array with group_ids (optional) 
            var userIds = ;  // List<int?> | Integer array with user_ids (optional) 
            var clientIds = ;  // List<int?> | Integer array with client_ids (optional) 
            var projectIds = ;  // List<int?> | Integer array with project_ids (optional) 
            var taskIds = ;  // List<int?> | Integer array with task_ids (optional) 
            var tagIds = ;  // List<int?> | Integer array with tag_ids (optional) 
            var description = description_example;  // string | Case insensitive pattern that matches `.*(description).*` (optional) 
            var billable = true;  // bool? | Is billable filter on (optional) 
            var rounding = 56;  // int? | How the rounding is done: 1 is rounding up, -1 down, 0 for no rounding. (optional) 
            var roundingMinutes = 56;  // int? | Rounding amount in minutes (optional) 
            var grouped = true;  // bool? | If it is grouped or not. This parameter only works for Detailed report. (optional) 
            var grouping = grouping_example;  // string | Criteria to group by. This parameter only works for Summary report. (optional) 
            var subGrouping = subGrouping_example;  // string | Criteria to subgroup. This parameter only works for Summary report. (optional) 

            try
            {
                // Load the previously saved report
                SavedReportOutput result = apiInstance.ReportsApiV3SharedReportTokenPost(reportToken, startDate, firstTimestamp, endDate, groupIds, userIds, clientIds, projectIds, taskIds, tagIds, description, billable, rounding, roundingMinutes, grouped, grouping, subGrouping);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SavedReportsApi.ReportsApiV3SharedReportTokenPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportToken** | **string**| Token for the saved report | 
 **startDate** | **string**| Starting date in the format YYYY-MM-DD | [optional] 
 **firstTimestamp** | **int?**| Unix timestamp(UTC) or null for proper pagination. This parameter only works in Detailed and Summary reports. | [optional] 
 **endDate** | **string**| End date in the format YYYY-MM-DD. This parameter only works in Detailed and Summary reports. | [optional] 
 **groupIds** | **List&lt;int?&gt;**| Integer array with group_ids | [optional] 
 **userIds** | **List&lt;int?&gt;**| Integer array with user_ids | [optional] 
 **clientIds** | **List&lt;int?&gt;**| Integer array with client_ids | [optional] 
 **projectIds** | **List&lt;int?&gt;**| Integer array with project_ids | [optional] 
 **taskIds** | **List&lt;int?&gt;**| Integer array with task_ids | [optional] 
 **tagIds** | **List&lt;int?&gt;**| Integer array with tag_ids | [optional] 
 **description** | **string**| Case insensitive pattern that matches &#x60;.*(description).*&#x60; | [optional] 
 **billable** | **bool?**| Is billable filter on | [optional] 
 **rounding** | **int?**| How the rounding is done: 1 is rounding up, -1 down, 0 for no rounding. | [optional] 
 **roundingMinutes** | **int?**| Rounding amount in minutes | [optional] 
 **grouped** | **bool?**| If it is grouped or not. This parameter only works for Detailed report. | [optional] 
 **grouping** | **string**| Criteria to group by. This parameter only works for Summary report. | [optional] 
 **subGrouping** | **string**| Criteria to subgroup. This parameter only works for Summary report. | [optional] 

### Return type

[**SavedReportOutput**](SavedReportOutput.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3sharedreporttokenxlsxpost"></a>
# **ReportsApiV3SharedReportTokenXlsxPost**
> string ReportsApiV3SharedReportTokenXlsxPost (string reportToken, string startDate = null, string endDate = null)

Export XSLX saved report

<p>Downloads a previously saved report in xlsx.</p> <p><b>Authentication</b></p><p>A public report is accessible by anyone, a private one is only accessible by the report's owner or workspace admin. If the criteria aren't met it returns 403 status code.</p> <p><b>Parameters</b></p><p>The report can be executed without parameters, and in this case the saved or default parameters will be used.</p>

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3SharedReportTokenXlsxPostExample
    {
        public void main()
        {
            var apiInstance = new SavedReportsApi();
            var reportToken = reportToken_example;  // string | Token for the saved report
            var startDate = startDate_example;  // string | Starting date in the format YYYY-MM-DD (optional) 
            var endDate = endDate_example;  // string | End date in the format YYYY-MM-DD (optional) 

            try
            {
                // Export XSLX saved report
                string result = apiInstance.ReportsApiV3SharedReportTokenXlsxPost(reportToken, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SavedReportsApi.ReportsApiV3SharedReportTokenXlsxPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportToken** | **string**| Token for the saved report | 
 **startDate** | **string**| Starting date in the format YYYY-MM-DD | [optional] 
 **endDate** | **string**| End date in the format YYYY-MM-DD | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/xlsx

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

