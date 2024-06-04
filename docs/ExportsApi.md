# TogglAPI.NetStandard.Api.ExportsApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMeExport**](ExportsApi.md#getmeexport) | **GET** /me/export | Get a list of objects to be downloaded
[**GetMeExportDataUuidZip**](ExportsApi.md#getmeexportdatauuidzip) | **GET** /me/export/data/{uuid}.zip | Get the zip file with download requests
[**GetWorkspaceExports**](ExportsApi.md#getworkspaceexports) | **GET** /workspaces/{workspace_id}/exports | Get a list with the workspace download requests
[**GetWorkspaceExportsDataUuidZip**](ExportsApi.md#getworkspaceexportsdatauuidzip) | **GET** /workspaces/{workspace_id}/exports/data/{uuid}.zip | Get the zip file with workspace download requests
[**InsightsApiV1WorkspaceWorkspaceIdProfitabilityEmployeesExtensionPost**](ExportsApi.md#insightsapiv1workspaceworkspaceidprofitabilityemployeesextensionpost) | **POST** /insights/api/v1/workspace/{workspace_id}/profitability/employees.{extension} | Export employee profitability insights
[**InsightsApiV1WorkspaceWorkspaceIdProfitabilityProjectsExtensionPost**](ExportsApi.md#insightsapiv1workspaceworkspaceidprofitabilityprojectsextensionpost) | **POST** /insights/api/v1/workspace/{workspace_id}/profitability/projects.{extension} | Export profitability project insights
[**InsightsApiV1WorkspaceWorkspaceIdTrendsProjectsExtensionPost**](ExportsApi.md#insightsapiv1workspaceworkspaceidtrendsprojectsextensionpost) | **POST** /insights/api/v1/workspace/{workspace_id}/trends/projects.{extension} | Export projects data trends
[**PostMeExport**](ExportsApi.md#postmeexport) | **POST** /me/export | Post an object which data to be downloaded
[**PostWorkspaceExports**](ExportsApi.md#postworkspaceexports) | **POST** /workspaces/{workspace_id}/exports | Post a list with the workspace to be downloaded
[**ReportsApiV3SharedReportTokenCsvPost**](ExportsApi.md#reportsapiv3sharedreporttokencsvpost) | **POST** /reports/api/v3/shared/{report_token}.csv | Export CSV for saved report
[**ReportsApiV3SharedReportTokenPdfPost**](ExportsApi.md#reportsapiv3sharedreporttokenpdfpost) | **POST** /reports/api/v3/shared/{report_token}/pdf | Export saved report in pdf format
[**ReportsApiV3SharedReportTokenXlsxPost**](ExportsApi.md#reportsapiv3sharedreporttokenxlsxpost) | **POST** /reports/api/v3/shared/{report_token}.xlsx | Export XSLX saved report
[**ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesExtensionPost**](ExportsApi.md#reportsapiv3workspaceworkspaceidsearchtimeentriesextensionpost) | **POST** /reports/api/v3/workspace/{workspace_id}/search/time_entries.{extension} | Export detailed report
[**ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesPdfPost**](ExportsApi.md#reportsapiv3workspaceworkspaceidsearchtimeentriespdfpost) | **POST** /reports/api/v3/workspace/{workspace_id}/search/time_entries.pdf | Export detailed report
[**ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesExtensionPost**](ExportsApi.md#reportsapiv3workspaceworkspaceidsummarytimeentriesextensionpost) | **POST** /reports/api/v3/workspace/{workspace_id}/summary/time_entries.{extension} | Export summary report
[**ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesPdfPost**](ExportsApi.md#reportsapiv3workspaceworkspaceidsummarytimeentriespdfpost) | **POST** /reports/api/v3/workspace/{workspace_id}/summary/time_entries.pdf | Export summary report
[**ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesCsvPost**](ExportsApi.md#reportsapiv3workspaceworkspaceidweeklytimeentriescsvpost) | **POST** /reports/api/v3/workspace/{workspace_id}/weekly/time_entries.csv | Export weekly report
[**ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesPdfPost**](ExportsApi.md#reportsapiv3workspaceworkspaceidweeklytimeentriespdfpost) | **POST** /reports/api/v3/workspace/{workspace_id}/weekly/time_entries.pdf | Export weekly report


<a name="getmeexport"></a>
# **GetMeExport**
> List<ModelsDownloadRequestRecord> GetMeExport ()

Get a list of objects to be downloaded

List of objects to be downloaded for an user

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetMeExportExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExportsApi();

            try
            {
                // Get a list of objects to be downloaded
                List&lt;ModelsDownloadRequestRecord&gt; result = apiInstance.GetMeExport();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportsApi.GetMeExport: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ModelsDownloadRequestRecord>**](ModelsDownloadRequestRecord.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmeexportdatauuidzip"></a>
# **GetMeExportDataUuidZip**
> string GetMeExportDataUuidZip ()

Get the zip file with download requests

Get a zip file List of download requests from an user.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetMeExportDataUuidZipExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExportsApi();

            try
            {
                // Get the zip file with download requests
                string result = apiInstance.GetMeExportDataUuidZip();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportsApi.GetMeExportDataUuidZip: " + e.Message );
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

<a name="getworkspaceexports"></a>
# **GetWorkspaceExports**
> List<ModelsDownloadRequestRecord> GetWorkspaceExports (int? workspaceId)

Get a list with the workspace download requests

List of workspace download requests from a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceExportsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExportsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace

            try
            {
                // Get a list with the workspace download requests
                List&lt;ModelsDownloadRequestRecord&gt; result = apiInstance.GetWorkspaceExports(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportsApi.GetWorkspaceExports: " + e.Message );
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

[**List<ModelsDownloadRequestRecord>**](ModelsDownloadRequestRecord.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspaceexportsdatauuidzip"></a>
# **GetWorkspaceExportsDataUuidZip**
> string GetWorkspaceExportsDataUuidZip (int? workspaceId)

Get the zip file with workspace download requests

Send a zip file List of workspace download requests from a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceExportsDataUuidZipExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExportsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace

            try
            {
                // Get the zip file with workspace download requests
                string result = apiInstance.GetWorkspaceExportsDataUuidZip(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportsApi.GetWorkspaceExportsDataUuidZip: " + e.Message );
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

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insightsapiv1workspaceworkspaceidprofitabilityemployeesextensionpost"></a>
# **InsightsApiV1WorkspaceWorkspaceIdProfitabilityEmployeesExtensionPost**
> string InsightsApiV1WorkspaceWorkspaceIdProfitabilityEmployeesExtensionPost (RequestsEmployeeProfitability parameters)

Export employee profitability insights

Downloads employee profitability insights in the specified format: csv or xlsx.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class InsightsApiV1WorkspaceWorkspaceIdProfitabilityEmployeesExtensionPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExportsApi();
            var parameters = new RequestsEmployeeProfitability(); // RequestsEmployeeProfitability | Parameters for report

            try
            {
                // Export employee profitability insights
                string result = apiInstance.InsightsApiV1WorkspaceWorkspaceIdProfitabilityEmployeesExtensionPost(parameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportsApi.InsightsApiV1WorkspaceWorkspaceIdProfitabilityEmployeesExtensionPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parameters** | [**RequestsEmployeeProfitability**](RequestsEmployeeProfitability.md)| Parameters for report | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv, text/xlsx

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insightsapiv1workspaceworkspaceidprofitabilityprojectsextensionpost"></a>
# **InsightsApiV1WorkspaceWorkspaceIdProfitabilityProjectsExtensionPost**
> string InsightsApiV1WorkspaceWorkspaceIdProfitabilityProjectsExtensionPost (RequestsProjectProfitability parameters, string extension)

Export profitability project insights

Downloads profitability project insights in the specified format: csv or xlsx.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class InsightsApiV1WorkspaceWorkspaceIdProfitabilityProjectsExtensionPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExportsApi();
            var parameters = new RequestsProjectProfitability(); // RequestsProjectProfitability | Parameters for report
            var extension = extension_example;  // string | csv,xlsx

            try
            {
                // Export profitability project insights
                string result = apiInstance.InsightsApiV1WorkspaceWorkspaceIdProfitabilityProjectsExtensionPost(parameters, extension);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportsApi.InsightsApiV1WorkspaceWorkspaceIdProfitabilityProjectsExtensionPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parameters** | [**RequestsProjectProfitability**](RequestsProjectProfitability.md)| Parameters for report | 
 **extension** | **string**| csv,xlsx | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv, text/xlsx

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insightsapiv1workspaceworkspaceidtrendsprojectsextensionpost"></a>
# **InsightsApiV1WorkspaceWorkspaceIdTrendsProjectsExtensionPost**
> List<ProjectsProjectTrends> InsightsApiV1WorkspaceWorkspaceIdTrendsProjectsExtensionPost (int? workspaceId, string extension, ProjectsProjectTrend projectTrend = null)

Export projects data trends

Downloads projects data trends in the specified format: csv or xlsx.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class InsightsApiV1WorkspaceWorkspaceIdTrendsProjectsExtensionPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExportsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var extension = extension_example;  // string | csv,xlsx
            var projectTrend = new ProjectsProjectTrend(); // ProjectsProjectTrend | Projects filter conditions (optional) 

            try
            {
                // Export projects data trends
                List&lt;ProjectsProjectTrends&gt; result = apiInstance.InsightsApiV1WorkspaceWorkspaceIdTrendsProjectsExtensionPost(workspaceId, extension, projectTrend);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportsApi.InsightsApiV1WorkspaceWorkspaceIdTrendsProjectsExtensionPost: " + e.Message );
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
 **projectTrend** | [**ProjectsProjectTrend**](ProjectsProjectTrend.md)| Projects filter conditions | [optional] 

### Return type

[**List<ProjectsProjectTrends>**](ProjectsProjectTrends.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postmeexport"></a>
# **PostMeExport**
> string PostMeExport (ExportPayload dataExportObject)

Post an object which data to be downloaded

An object which data to be downloaded for an user

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostMeExportExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExportsApi();
            var dataExportObject = new ExportPayload(); // ExportPayload | Objects to export

            try
            {
                // Post an object which data to be downloaded
                string result = apiInstance.PostMeExport(dataExportObject);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportsApi.PostMeExport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dataExportObject** | [**ExportPayload**](ExportPayload.md)| Objects to export | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postworkspaceexports"></a>
# **PostWorkspaceExports**
> string PostWorkspaceExports (int? workspaceId, List<string> tokensList)

Post a list with the workspace to be downloaded

List of workspaces downloaded from a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostWorkspaceExportsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExportsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var tokensList = ;  // List<string> | Objects to export

            try
            {
                // Post a list with the workspace to be downloaded
                string result = apiInstance.PostWorkspaceExports(workspaceId, tokensList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportsApi.PostWorkspaceExports: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **tokensList** | **List&lt;string&gt;**| Objects to export | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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
            var apiInstance = new ExportsApi();
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
                Debug.Print("Exception when calling ExportsApi.ReportsApiV3SharedReportTokenCsvPost: " + e.Message );
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
            var apiInstance = new ExportsApi();
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
                Debug.Print("Exception when calling ExportsApi.ReportsApiV3SharedReportTokenPdfPost: " + e.Message );
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
            var apiInstance = new ExportsApi();
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
                Debug.Print("Exception when calling ExportsApi.ReportsApiV3SharedReportTokenXlsxPost: " + e.Message );
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

            var apiInstance = new ExportsApi();
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
                Debug.Print("Exception when calling ExportsApi.ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesExtensionPost: " + e.Message );
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

            var apiInstance = new ExportsApi();
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
                Debug.Print("Exception when calling ExportsApi.ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesPdfPost: " + e.Message );
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
            var apiInstance = new ExportsApi();
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
                Debug.Print("Exception when calling ExportsApi.ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesExtensionPost: " + e.Message );
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

            var apiInstance = new ExportsApi();
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
                Debug.Print("Exception when calling ExportsApi.ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesPdfPost: " + e.Message );
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

            var apiInstance = new ExportsApi();
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
                Debug.Print("Exception when calling ExportsApi.ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesCsvPost: " + e.Message );
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

            var apiInstance = new ExportsApi();
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
                Debug.Print("Exception when calling ExportsApi.ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesPdfPost: " + e.Message );
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

