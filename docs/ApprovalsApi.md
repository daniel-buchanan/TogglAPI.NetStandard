# TogglAPI.NetStandard.Api.ApprovalsApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteTimesheetSetups**](ApprovalsApi.md#deletetimesheetsetups) | **DELETE** /workspaces/{workspace_id}/timesheet_setups/{setup_id} | Delete a timesheet setup
[**GetTimesheetSetups**](ApprovalsApi.md#gettimesheetsetups) | **GET** /workspaces/{workspace_id}/timesheet_setups | Get timesheet setups
[**GetWorkspaceTimesheetHoursHandler**](ApprovalsApi.md#getworkspacetimesheethourshandler) | **POST** /workspaces/{workspace_id}/timesheets/hours | Get timesheets hours
[**GetWorkspaceTimesheetTimeEntriesHandler**](ApprovalsApi.md#getworkspacetimesheettimeentrieshandler) | **GET** /workspaces/{workspace_id}/timesheets/{setup_id}/{start_date} | Get timesheet time entries
[**GetWorkspaceTimesheetsHandler**](ApprovalsApi.md#getworkspacetimesheetshandler) | **GET** /workspaces/{workspace_id}/timesheets | Get timesheets
[**PostTimesheetSetups**](ApprovalsApi.md#posttimesheetsetups) | **POST** /workspaces/{workspace_id}/timesheet_setups | Create a timesheet setup
[**PutTimesheetSetups**](ApprovalsApi.md#puttimesheetsetups) | **POST** /workspaces/{workspace_id}/timesheet_setups/{setup_id} | Update a timesheet setup
[**PutWorkspaceTimesheetsHandler**](ApprovalsApi.md#putworkspacetimesheetshandler) | **PUT** /workspaces/{workspace_id}/timesheets/{setup_id}/{start_date} | Update timesheets


<a name="deletetimesheetsetups"></a>
# **DeleteTimesheetSetups**
> string DeleteTimesheetSetups (int? workspaceId, int? setupId)

Delete a timesheet setup

Delete a timesheet setup for a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteTimesheetSetupsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ApprovalsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var setupId = 56;  // int? | Numeric ID of the timesheet setup

            try
            {
                // Delete a timesheet setup
                string result = apiInstance.DeleteTimesheetSetups(workspaceId, setupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApprovalsApi.DeleteTimesheetSetups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **setupId** | **int?**| Numeric ID of the timesheet setup | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettimesheetsetups"></a>
# **GetTimesheetSetups**
> TimesheetsetupsGetPaginatedResponse GetTimesheetSetups (int? workspaceId, int? memberIds = null, int? approverIds = null, string sortField = null, string sortOrder = null)

Get timesheet setups

Get timesheet setups for a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetTimesheetSetupsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ApprovalsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var memberIds = 56;  // int? | Numeric ID of the members, comma-separated (optional) 
            var approverIds = 56;  // int? | Numeric ID of the approvers, comma-separated (optional) 
            var sortField = sortField_example;  // string | Field used for sorting, default start_date. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order. (optional) 

            try
            {
                // Get timesheet setups
                TimesheetsetupsGetPaginatedResponse result = apiInstance.GetTimesheetSetups(workspaceId, memberIds, approverIds, sortField, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApprovalsApi.GetTimesheetSetups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **memberIds** | **int?**| Numeric ID of the members, comma-separated | [optional] 
 **approverIds** | **int?**| Numeric ID of the approvers, comma-separated | [optional] 
 **sortField** | **string**| Field used for sorting, default start_date. | [optional] 
 **sortOrder** | **string**| Sort order. | [optional] 

### Return type

[**TimesheetsetupsGetPaginatedResponse**](TimesheetsetupsGetPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacetimesheethourshandler"></a>
# **GetWorkspaceTimesheetHoursHandler**
> List<TimesheetsTimesheetHoursResponse> GetWorkspaceTimesheetHoursHandler (int? workspaceId, TimesheetsPostTimesheetHoursPayload payload)

Get timesheets hours

Get timesheet working hours and total tracked seconds.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceTimesheetHoursHandlerExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ApprovalsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var payload = new TimesheetsPostTimesheetHoursPayload(); // TimesheetsPostTimesheetHoursPayload | Array of timesheet setup IDs and start dates.

            try
            {
                // Get timesheets hours
                List&lt;TimesheetsTimesheetHoursResponse&gt; result = apiInstance.GetWorkspaceTimesheetHoursHandler(workspaceId, payload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApprovalsApi.GetWorkspaceTimesheetHoursHandler: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **payload** | [**TimesheetsPostTimesheetHoursPayload**](TimesheetsPostTimesheetHoursPayload.md)| Array of timesheet setup IDs and start dates. | 

### Return type

[**List<TimesheetsTimesheetHoursResponse>**](TimesheetsTimesheetHoursResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacetimesheettimeentrieshandler"></a>
# **GetWorkspaceTimesheetTimeEntriesHandler**
> List<ModelsTimeEntry> GetWorkspaceTimesheetTimeEntriesHandler (int? workspaceId, int? setupId, string startDate)

Get timesheet time entries

Get the time entries from within a timesheet timeframe.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceTimesheetTimeEntriesHandlerExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ApprovalsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var setupId = 56;  // int? | Numeric ID of the timesheet setup.
            var startDate = startDate_example;  // string | Start date (YYYY-MM-DD) of the timesheet.

            try
            {
                // Get timesheet time entries
                List&lt;ModelsTimeEntry&gt; result = apiInstance.GetWorkspaceTimesheetTimeEntriesHandler(workspaceId, setupId, startDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApprovalsApi.GetWorkspaceTimesheetTimeEntriesHandler: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **setupId** | **int?**| Numeric ID of the timesheet setup. | 
 **startDate** | **string**| Start date (YYYY-MM-DD) of the timesheet. | 

### Return type

[**List<ModelsTimeEntry>**](ModelsTimeEntry.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacetimesheetshandler"></a>
# **GetWorkspaceTimesheetsHandler**
> List<TimesheetsGetPaginatedResponse> GetWorkspaceTimesheetsHandler (int? workspaceId, int? memberIds = null, int? approverIds = null, int? timesheetSetupIds = null, int? statuses = null, int? before = null, int? after = null, int? page = null, int? perPage = null, string sortField = null, string sortOrder = null)

Get timesheets

Get timesheets applying various filters.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceTimesheetsHandlerExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ApprovalsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var memberIds = 56;  // int? | Numeric ID of the members, comma-separated (optional) 
            var approverIds = 56;  // int? | Numeric ID of the approvers, comma-separated (optional) 
            var timesheetSetupIds = 56;  // int? | Numeric ID for timesheet setup, comma-separated. (optional) 
            var statuses = 56;  // int? | Timesheet status, comma-separated. (optional) 
            var before = 56;  // int? | Timesheets starting before this date (YYYY-MM-DD). (optional) 
            var after = 56;  // int? | Timesheets starting after this date (YYYY-MM-DD). (optional) 
            var page = 56;  // int? | Page number, default 1. (optional) 
            var perPage = 56;  // int? | Number of items per page, default 20. Also defaults to 20 if provided an greater than 1000. (optional) 
            var sortField = sortField_example;  // string | Field used for sorting, default start_date. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order. (optional) 

            try
            {
                // Get timesheets
                List&lt;TimesheetsGetPaginatedResponse&gt; result = apiInstance.GetWorkspaceTimesheetsHandler(workspaceId, memberIds, approverIds, timesheetSetupIds, statuses, before, after, page, perPage, sortField, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApprovalsApi.GetWorkspaceTimesheetsHandler: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **memberIds** | **int?**| Numeric ID of the members, comma-separated | [optional] 
 **approverIds** | **int?**| Numeric ID of the approvers, comma-separated | [optional] 
 **timesheetSetupIds** | **int?**| Numeric ID for timesheet setup, comma-separated. | [optional] 
 **statuses** | **int?**| Timesheet status, comma-separated. | [optional] 
 **before** | **int?**| Timesheets starting before this date (YYYY-MM-DD). | [optional] 
 **after** | **int?**| Timesheets starting after this date (YYYY-MM-DD). | [optional] 
 **page** | **int?**| Page number, default 1. | [optional] 
 **perPage** | **int?**| Number of items per page, default 20. Also defaults to 20 if provided an greater than 1000. | [optional] 
 **sortField** | **string**| Field used for sorting, default start_date. | [optional] 
 **sortOrder** | **string**| Sort order. | [optional] 

### Return type

[**List<TimesheetsGetPaginatedResponse>**](TimesheetsGetPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttimesheetsetups"></a>
# **PostTimesheetSetups**
> List<TimesheetsetupsAPITimesheetSetup> PostTimesheetSetups (int? workspaceId, TimesheetsetupsCreatePayload payload)

Create a timesheet setup

Create timesheet setups.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostTimesheetSetupsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ApprovalsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var payload = new TimesheetsetupsCreatePayload(); // TimesheetsetupsCreatePayload | Arrays of setup creation parameters.

            try
            {
                // Create a timesheet setup
                List&lt;TimesheetsetupsAPITimesheetSetup&gt; result = apiInstance.PostTimesheetSetups(workspaceId, payload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApprovalsApi.PostTimesheetSetups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **payload** | [**TimesheetsetupsCreatePayload**](TimesheetsetupsCreatePayload.md)| Arrays of setup creation parameters. | 

### Return type

[**List<TimesheetsetupsAPITimesheetSetup>**](TimesheetsetupsAPITimesheetSetup.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="puttimesheetsetups"></a>
# **PutTimesheetSetups**
> TimesheetsetupsAPITimesheetSetup PutTimesheetSetups (int? workspaceId, int? setupId, TimesheetsetupsUpdatePayload payload)

Update a timesheet setup

Updates a timesheet setups.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutTimesheetSetupsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ApprovalsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var setupId = 56;  // int? | Numeric ID of the timesheet setup
            var payload = new TimesheetsetupsUpdatePayload(); // TimesheetsetupsUpdatePayload | Setup update parameters.

            try
            {
                // Update a timesheet setup
                TimesheetsetupsAPITimesheetSetup result = apiInstance.PutTimesheetSetups(workspaceId, setupId, payload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApprovalsApi.PutTimesheetSetups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **setupId** | **int?**| Numeric ID of the timesheet setup | 
 **payload** | [**TimesheetsetupsUpdatePayload**](TimesheetsetupsUpdatePayload.md)| Setup update parameters. | 

### Return type

[**TimesheetsetupsAPITimesheetSetup**](TimesheetsetupsAPITimesheetSetup.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putworkspacetimesheetshandler"></a>
# **PutWorkspaceTimesheetsHandler**
> TimesheetsAPITimesheet PutWorkspaceTimesheetsHandler (int? workspaceId, int? setupId, string startDate, TimesheetsPutTimesheetPayload payload)

Update timesheets

Updates a timesheet.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutWorkspaceTimesheetsHandlerExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ApprovalsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var setupId = 56;  // int? | Numeric ID of the timesheet setup.
            var startDate = startDate_example;  // string | Start date (YYYY-MM-DD) of the timesheet.
            var payload = new TimesheetsPutTimesheetPayload(); // TimesheetsPutTimesheetPayload | Timesheet status and rejection comment.

            try
            {
                // Update timesheets
                TimesheetsAPITimesheet result = apiInstance.PutWorkspaceTimesheetsHandler(workspaceId, setupId, startDate, payload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApprovalsApi.PutWorkspaceTimesheetsHandler: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **setupId** | **int?**| Numeric ID of the timesheet setup. | 
 **startDate** | **string**| Start date (YYYY-MM-DD) of the timesheet. | 
 **payload** | [**TimesheetsPutTimesheetPayload**](TimesheetsPutTimesheetPayload.md)| Timesheet status and rejection comment. | 

### Return type

[**TimesheetsAPITimesheet**](TimesheetsAPITimesheet.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

