# TogglAPI.NetStandard.Api.ReportsApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSavedReportResource**](ReportsApi.md#deletesavedreportresource) | **DELETE** /workspaces/{workspace_id}/reports/shared/{report_id} | models.SavedReport
[**DeleteWorkspaceScheduledReports**](ReportsApi.md#deleteworkspacescheduledreports) | **DELETE** /workspaces/{workspace_id}/scheduled_reports/{report_id} | ScheduledReport
[**GetSavedReportResource**](ReportsApi.md#getsavedreportresource) | **GET** /workspaces/{workspace_id}/reports/shared/{report_id} | models.SavedReport
[**GetSharedReport**](ReportsApi.md#getsharedreport) | **GET** /workspaces/{workspace_id}/reports/shared | workspace.SharedReport
[**GetWorkspaceScheduledReports**](ReportsApi.md#getworkspacescheduledreports) | **GET** /workspaces/{workspace_id}/scheduled_reports | ScheduledReports
[**PostSharedReport**](ReportsApi.md#postsharedreport) | **POST** /workspaces/{workspace_id}/reports/shared | workspace.SharedReport
[**PostWorkspaceScheduledReports**](ReportsApi.md#postworkspacescheduledreports) | **POST** /workspaces/{workspace_id}/scheduled_reports | ScheduledReports
[**PutSavedReportResource**](ReportsApi.md#putsavedreportresource) | **PUT** /workspaces/{workspace_id}/reports/shared/{report_id} | models.SavedReport
[**PutSharedReport**](ReportsApi.md#putsharedreport) | **PUT** /workspaces/{workspace_id}/reports/shared | workspace.SharedReport


<a name="deletesavedreportresource"></a>
# **DeleteSavedReportResource**
> ModelsSavedReport DeleteSavedReportResource (int? workspaceId, int? reportId)

models.SavedReport

Delete saved report.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteSavedReportResourceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ReportsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.
            var reportId = 56;  // int? | Numeric ID of the report.

            try
            {
                // models.SavedReport
                ModelsSavedReport result = apiInstance.DeleteSavedReportResource(workspaceId, reportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.DeleteSavedReportResource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace. | 
 **reportId** | **int?**| Numeric ID of the report. | 

### Return type

[**ModelsSavedReport**](ModelsSavedReport.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteworkspacescheduledreports"></a>
# **DeleteWorkspaceScheduledReports**
> string DeleteWorkspaceScheduledReports (int? workspaceId, int? reportId)

ScheduledReport

Endpoint for delete a scheduled report.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteWorkspaceScheduledReportsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ReportsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var reportId = 56;  // int? | Numeric ID of the report

            try
            {
                // ScheduledReport
                string result = apiInstance.DeleteWorkspaceScheduledReports(workspaceId, reportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.DeleteWorkspaceScheduledReports: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **reportId** | **int?**| Numeric ID of the report | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsavedreportresource"></a>
# **GetSavedReportResource**
> ModelsSavedReport GetSavedReportResource (int? workspaceId, int? reportId)

models.SavedReport

Get saved report.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetSavedReportResourceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ReportsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.
            var reportId = 56;  // int? | Numeric ID of the report.

            try
            {
                // models.SavedReport
                ModelsSavedReport result = apiInstance.GetSavedReportResource(workspaceId, reportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetSavedReportResource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace. | 
 **reportId** | **int?**| Numeric ID of the report. | 

### Return type

[**ModelsSavedReport**](ModelsSavedReport.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsharedreport"></a>
# **GetSharedReport**
> List<ModelsSavedReport> GetSharedReport (int? workspaceId, bool? fixedDates = null, string name = null, int? ownerID = null, int? page = null, int? perPage = null, bool? _public = null, bool? scheduled = null, string sortDirection = null, string sortField = null)

workspace.SharedReport

Get shared report.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetSharedReportExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ReportsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.
            var fixedDates = true;  // bool? |  (optional) 
            var name = name_example;  // string |  (optional) 
            var ownerID = 56;  // int? |  (optional) 
            var page = 56;  // int? |  (optional) 
            var perPage = 56;  // int? |  (optional) 
            var _public = true;  // bool? |  (optional) 
            var scheduled = true;  // bool? |  (optional) 
            var sortDirection = sortDirection_example;  // string |  (optional) 
            var sortField = sortField_example;  // string |  (optional) 

            try
            {
                // workspace.SharedReport
                List&lt;ModelsSavedReport&gt; result = apiInstance.GetSharedReport(workspaceId, fixedDates, name, ownerID, page, perPage, _public, scheduled, sortDirection, sortField);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetSharedReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace. | 
 **fixedDates** | **bool?**|  | [optional] 
 **name** | **string**|  | [optional] 
 **ownerID** | **int?**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **perPage** | **int?**|  | [optional] 
 **_public** | **bool?**|  | [optional] 
 **scheduled** | **bool?**|  | [optional] 
 **sortDirection** | **string**|  | [optional] 
 **sortField** | **string**|  | [optional] 

### Return type

[**List<ModelsSavedReport>**](ModelsSavedReport.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacescheduledreports"></a>
# **GetWorkspaceScheduledReports**
> List<ModelsScheduledReport> GetWorkspaceScheduledReports (int? workspaceId)

ScheduledReports

Lists scheduled reports.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceScheduledReportsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ReportsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace

            try
            {
                // ScheduledReports
                List&lt;ModelsScheduledReport&gt; result = apiInstance.GetWorkspaceScheduledReports(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetWorkspaceScheduledReports: " + e.Message );
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

[**List<ModelsScheduledReport>**](ModelsScheduledReport.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsharedreport"></a>
# **PostSharedReport**
> ModelsSavedReport PostSharedReport (int? workspaceId, SavedPayload savedReportPayload)

workspace.SharedReport

Add shared report.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostSharedReportExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ReportsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.
            var savedReportPayload = new SavedPayload(); // SavedPayload | Saved Report Payload

            try
            {
                // workspace.SharedReport
                ModelsSavedReport result = apiInstance.PostSharedReport(workspaceId, savedReportPayload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.PostSharedReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace. | 
 **savedReportPayload** | [**SavedPayload**](SavedPayload.md)| Saved Report Payload | 

### Return type

[**ModelsSavedReport**](ModelsSavedReport.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postworkspacescheduledreports"></a>
# **PostWorkspaceScheduledReports**
> ModelsScheduledReport PostWorkspaceScheduledReports (int? workspaceId, ScheduledPayload workspaceId2)

ScheduledReports

Endpoint for setting up a scheduled report.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostWorkspaceScheduledReportsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ReportsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var workspaceId2 = new ScheduledPayload(); // ScheduledPayload | Comment from the client on the pricing plan change

            try
            {
                // ScheduledReports
                ModelsScheduledReport result = apiInstance.PostWorkspaceScheduledReports(workspaceId, workspaceId2);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.PostWorkspaceScheduledReports: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **workspaceId2** | [**ScheduledPayload**](ScheduledPayload.md)| Comment from the client on the pricing plan change | 

### Return type

[**ModelsScheduledReport**](ModelsScheduledReport.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putsavedreportresource"></a>
# **PutSavedReportResource**
> ModelsSavedReport PutSavedReportResource (int? workspaceId, int? reportId, SavedPayload savedReportPayload)

models.SavedReport

Change saved report.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutSavedReportResourceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ReportsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.
            var reportId = 56;  // int? | Numeric ID of the report.
            var savedReportPayload = new SavedPayload(); // SavedPayload | Saved Report Payload

            try
            {
                // models.SavedReport
                ModelsSavedReport result = apiInstance.PutSavedReportResource(workspaceId, reportId, savedReportPayload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.PutSavedReportResource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace. | 
 **reportId** | **int?**| Numeric ID of the report. | 
 **savedReportPayload** | [**SavedPayload**](SavedPayload.md)| Saved Report Payload | 

### Return type

[**ModelsSavedReport**](ModelsSavedReport.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putsharedreport"></a>
# **PutSharedReport**
> ModelsSavedReport PutSharedReport (int? workspaceId, int? reportId, List<SavedPayload> savedReportPayload)

workspace.SharedReport

Change shared report.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutSharedReportExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ReportsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.
            var reportId = 56;  // int? | Numeric ID of the report.
            var savedReportPayload = new List<SavedPayload>(); // List<SavedPayload> | Saved Report Payload

            try
            {
                // workspace.SharedReport
                ModelsSavedReport result = apiInstance.PutSharedReport(workspaceId, reportId, savedReportPayload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.PutSharedReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace. | 
 **reportId** | **int?**| Numeric ID of the report. | 
 **savedReportPayload** | [**List&lt;SavedPayload&gt;**](SavedPayload.md)| Saved Report Payload | 

### Return type

[**ModelsSavedReport**](ModelsSavedReport.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

