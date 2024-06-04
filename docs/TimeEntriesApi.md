# TogglAPI.NetStandard.Api.TimeEntriesApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteWorkspaceTimeEntries**](TimeEntriesApi.md#deleteworkspacetimeentries) | **DELETE** /workspaces/{workspace_id}/time_entries/{time_entry_id} | TimeEntries
[**GetCurrentTimeEntry**](TimeEntriesApi.md#getcurrenttimeentry) | **GET** /me/time_entries/current | Get current time entry
[**GetTimeEntries**](TimeEntriesApi.md#gettimeentries) | **GET** /me/time_entries | TimeEntries
[**GetTimeEntryById**](TimeEntriesApi.md#gettimeentrybyid) | **GET** /me/time_entries/{time_entry_id} | Get a time entry by ID.
[**GetTimeNotesEntryNotesById**](TimeEntriesApi.md#gettimenotesentrynotesbyid) | **GET** /me/time_entries/{time_entry_id}/notes | Get a time entries&#39; notes by ID.
[**GetTimeNotesEntryNotesById_0**](TimeEntriesApi.md#gettimenotesentrynotesbyid_0) | **POST** /me/time_entries/{time_entry_id}/notes | Get a time entries&#39; notes by ID.
[**GetWorkspaceTimeEntryInvitations**](TimeEntriesApi.md#getworkspacetimeentryinvitations) | **GET** /workspaces/{workspace_id}/time_entry_invitations | TimeEntries
[**PatchTimeEntries**](TimeEntriesApi.md#patchtimeentries) | **PATCH** /workspaces/{workspace_id}/time_entries/{time_entry_ids} | Bulk editing time entries
[**PatchWorkspaceStopTimeEntryHandler**](TimeEntriesApi.md#patchworkspacestoptimeentryhandler) | **PATCH** /workspaces/{workspace_id}/time_entries/{time_entry_id}/stop | Stop TimeEntry
[**PostMeTimeEntriesSharedWith**](TimeEntriesApi.md#postmetimeentriessharedwith) | **POST** /me/time_entries_shared_with | TimeEntries
[**PostWorkspaceTimeEntries**](TimeEntriesApi.md#postworkspacetimeentries) | **POST** /workspaces/{workspace_id}/time_entries | TimeEntries
[**PostWorkspaceTimeEntryInvitationAction**](TimeEntriesApi.md#postworkspacetimeentryinvitationaction) | **POST** /workspaces/{workspace_id}/time_entry_invitations/{time_entry_invitation_id}/{action} | TimeEntries
[**PutTimeEntryNotesById**](TimeEntriesApi.md#puttimeentrynotesbyid) | **PUT** /me/time_entries/{time_entry_id}/notes | Put a time entry notes by ID.
[**PutWorkspaceTimeEntryHandler**](TimeEntriesApi.md#putworkspacetimeentryhandler) | **PUT** /workspaces/{workspace_id}/time_entries/{time_entry_id} | TimeEntries


<a name="deleteworkspacetimeentries"></a>
# **DeleteWorkspaceTimeEntries**
> string DeleteWorkspaceTimeEntries (int? workspaceId, int? timeEntryId)

TimeEntries

Deletes a workspace time entry.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteWorkspaceTimeEntriesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TimeEntriesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var timeEntryId = 56;  // int? | TimeEntry ID.

            try
            {
                // TimeEntries
                string result = apiInstance.DeleteWorkspaceTimeEntries(workspaceId, timeEntryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeEntriesApi.DeleteWorkspaceTimeEntries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **timeEntryId** | **int?**| TimeEntry ID. | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrenttimeentry"></a>
# **GetCurrentTimeEntry**
> ModelsTimeEntry GetCurrentTimeEntry ()

Get current time entry

Load running time entry for user ID.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetCurrentTimeEntryExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TimeEntriesApi();

            try
            {
                // Get current time entry
                ModelsTimeEntry result = apiInstance.GetCurrentTimeEntry();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeEntriesApi.GetCurrentTimeEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ModelsTimeEntry**](ModelsTimeEntry.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettimeentries"></a>
# **GetTimeEntries**
> List<ModelsTimeEntry> GetTimeEntries (int? since = null, string before = null, string startDate = null, string endDate = null, bool? meta = null, bool? includeSharing = null)

TimeEntries

Lists latest time entries.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetTimeEntriesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TimeEntriesApi();
            var since = 56;  // int? | Get entries modified since this date using UNIX timestamp, including deleted ones. (optional) 
            var before = before_example;  // string | Get entries with start time, before given date (YYYY-MM-DD) or with time in RFC3339 format. (optional) 
            var startDate = startDate_example;  // string | Get entries with start time, from start_date YYYY-MM-DD or with time in RFC3339 format. To be used with end_date. (optional) 
            var endDate = endDate_example;  // string | Get entries with start time, until end_date YYYY-MM-DD or with time in RFC3339 format. To be used with start_date. (optional) 
            var meta = true;  // bool? | Should the response contain data for meta entities (optional) 
            var includeSharing = true;  // bool? | Include sharing details in the response (optional) 

            try
            {
                // TimeEntries
                List&lt;ModelsTimeEntry&gt; result = apiInstance.GetTimeEntries(since, before, startDate, endDate, meta, includeSharing);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeEntriesApi.GetTimeEntries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **since** | **int?**| Get entries modified since this date using UNIX timestamp, including deleted ones. | [optional] 
 **before** | **string**| Get entries with start time, before given date (YYYY-MM-DD) or with time in RFC3339 format. | [optional] 
 **startDate** | **string**| Get entries with start time, from start_date YYYY-MM-DD or with time in RFC3339 format. To be used with end_date. | [optional] 
 **endDate** | **string**| Get entries with start time, until end_date YYYY-MM-DD or with time in RFC3339 format. To be used with start_date. | [optional] 
 **meta** | **bool?**| Should the response contain data for meta entities | [optional] 
 **includeSharing** | **bool?**| Include sharing details in the response | [optional] 

### Return type

[**List<ModelsTimeEntry>**](ModelsTimeEntry.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettimeentrybyid"></a>
# **GetTimeEntryById**
> ModelsTimeEntry GetTimeEntryById (int? timeEntryId, bool? meta = null, bool? includeSharing = null)

Get a time entry by ID.

Load time entry by ID that is accessible by the current user.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetTimeEntryByIdExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TimeEntriesApi();
            var timeEntryId = 56;  // int? | TimeEntry ID.
            var meta = true;  // bool? | Should the response contain data for meta entities (optional) 
            var includeSharing = true;  // bool? | Include sharing details in the response (optional) 

            try
            {
                // Get a time entry by ID.
                ModelsTimeEntry result = apiInstance.GetTimeEntryById(timeEntryId, meta, includeSharing);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeEntriesApi.GetTimeEntryById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timeEntryId** | **int?**| TimeEntry ID. | 
 **meta** | **bool?**| Should the response contain data for meta entities | [optional] 
 **includeSharing** | **bool?**| Include sharing details in the response | [optional] 

### Return type

[**ModelsTimeEntry**](ModelsTimeEntry.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettimenotesentrynotesbyid"></a>
# **GetTimeNotesEntryNotesById**
> ModelsTimeEntryNotes GetTimeNotesEntryNotesById (int? timeEntryId)

Get a time entries' notes by ID.

Load time entry by ID that is accessible by the current user.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetTimeNotesEntryNotesByIdExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TimeEntriesApi();
            var timeEntryId = 56;  // int? | TimeEntry ID.

            try
            {
                // Get a time entries' notes by ID.
                ModelsTimeEntryNotes result = apiInstance.GetTimeNotesEntryNotesById(timeEntryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeEntriesApi.GetTimeNotesEntryNotesById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timeEntryId** | **int?**| TimeEntry ID. | 

### Return type

[**ModelsTimeEntryNotes**](ModelsTimeEntryNotes.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettimenotesentrynotesbyid_0"></a>
# **GetTimeNotesEntryNotesById_0**
> List<ModelsTimeEntryNotes> GetTimeNotesEntryNotesById_0 (int? timeEntryId)

Get a time entries' notes by ID.

Load time entry by ID that is accessible by the current user.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetTimeNotesEntryNotesById_0Example
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TimeEntriesApi();
            var timeEntryId = 56;  // int? | TimeEntry ID.

            try
            {
                // Get a time entries' notes by ID.
                List&lt;ModelsTimeEntryNotes&gt; result = apiInstance.GetTimeNotesEntryNotesById_0(timeEntryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeEntriesApi.GetTimeNotesEntryNotesById_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timeEntryId** | **int?**| TimeEntry ID. | 

### Return type

[**List<ModelsTimeEntryNotes>**](ModelsTimeEntryNotes.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacetimeentryinvitations"></a>
# **GetWorkspaceTimeEntryInvitations**
> List<TimeentriesGetTimEntryInvitationsResponse> GetWorkspaceTimeEntryInvitations (int? workspaceId)

TimeEntries

Get invitations for time entries

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceTimeEntryInvitationsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TimeEntriesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace

            try
            {
                // TimeEntries
                List&lt;TimeentriesGetTimEntryInvitationsResponse&gt; result = apiInstance.GetWorkspaceTimeEntryInvitations(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeEntriesApi.GetWorkspaceTimeEntryInvitations: " + e.Message );
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

[**List<TimeentriesGetTimEntryInvitationsResponse>**](TimeentriesGetTimEntryInvitationsResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchtimeentries"></a>
# **PatchTimeEntries**
> TimeentryPatchOutput PatchTimeEntries (int? workspaceId, string timeEntryIds, TimeentriesPatchPost patchInput, bool? meta = null)

Bulk editing time entries

In short: http://tools.ietf.org/html/rfc6902 and http://tools.ietf.org/html/rfc6901 with some additions. Patch will be executed partially when there are errors with some records. No transaction, no rollback.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PatchTimeEntriesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TimeEntriesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var timeEntryIds = timeEntryIds_example;  // string | Numeric IDs of time_entries, separated by comma. E.g.: `204301830,202700150,202687559`. The limit is 100 IDs per request.
            var patchInput = new TimeentriesPatchPost(); // TimeentriesPatchPost | Array of batch operations
            var meta = true;  // bool? | Should the response contain data for meta entities (optional) 

            try
            {
                // Bulk editing time entries
                TimeentryPatchOutput result = apiInstance.PatchTimeEntries(workspaceId, timeEntryIds, patchInput, meta);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeEntriesApi.PatchTimeEntries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **timeEntryIds** | **string**| Numeric IDs of time_entries, separated by comma. E.g.: &#x60;204301830,202700150,202687559&#x60;. The limit is 100 IDs per request. | 
 **patchInput** | [**TimeentriesPatchPost**](TimeentriesPatchPost.md)| Array of batch operations | 
 **meta** | **bool?**| Should the response contain data for meta entities | [optional] 

### Return type

[**TimeentryPatchOutput**](TimeentryPatchOutput.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchworkspacestoptimeentryhandler"></a>
# **PatchWorkspaceStopTimeEntryHandler**
> ModelsTimeEntry PatchWorkspaceStopTimeEntryHandler (int? workspaceId, int? timeEntryId)

Stop TimeEntry

Stops a workspace time entry.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PatchWorkspaceStopTimeEntryHandlerExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TimeEntriesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var timeEntryId = 56;  // int? | TimeEntry ID.

            try
            {
                // Stop TimeEntry
                ModelsTimeEntry result = apiInstance.PatchWorkspaceStopTimeEntryHandler(workspaceId, timeEntryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeEntriesApi.PatchWorkspaceStopTimeEntryHandler: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **timeEntryId** | **int?**| TimeEntry ID. | 

### Return type

[**ModelsTimeEntry**](ModelsTimeEntry.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postmetimeentriessharedwith"></a>
# **PostMeTimeEntriesSharedWith**
> List<TimeentriesBulkGetSharingResponse> PostMeTimeEntriesSharedWith (List<TimeentriesBulkGetSharingRequest> request)

TimeEntries

Get the sharing details of the specified time entries in bulk

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostMeTimeEntriesSharedWithExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TimeEntriesApi();
            var request = new List<TimeentriesBulkGetSharingRequest>(); // List<TimeentriesBulkGetSharingRequest> | List of time entries to get the sharing details of.

            try
            {
                // TimeEntries
                List&lt;TimeentriesBulkGetSharingResponse&gt; result = apiInstance.PostMeTimeEntriesSharedWith(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeEntriesApi.PostMeTimeEntriesSharedWith: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**List&lt;TimeentriesBulkGetSharingRequest&gt;**](TimeentriesBulkGetSharingRequest.md)| List of time entries to get the sharing details of. | 

### Return type

[**List<TimeentriesBulkGetSharingResponse>**](TimeentriesBulkGetSharingResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postworkspacetimeentries"></a>
# **PostWorkspaceTimeEntries**
> ModelsTimeEntry PostWorkspaceTimeEntries (int? workspaceId, TimeentryPayload workspaceTimeEntryPost, bool? meta = null)

TimeEntries

Creates a new workspace TimeEntry.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostWorkspaceTimeEntriesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TimeEntriesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var workspaceTimeEntryPost = new TimeentryPayload(); // TimeentryPayload | TimeEntry parameters.
            var meta = true;  // bool? | Should the response contain data for meta entities (optional) 

            try
            {
                // TimeEntries
                ModelsTimeEntry result = apiInstance.PostWorkspaceTimeEntries(workspaceId, workspaceTimeEntryPost, meta);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeEntriesApi.PostWorkspaceTimeEntries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **workspaceTimeEntryPost** | [**TimeentryPayload**](TimeentryPayload.md)| TimeEntry parameters. | 
 **meta** | **bool?**| Should the response contain data for meta entities | [optional] 

### Return type

[**ModelsTimeEntry**](ModelsTimeEntry.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postworkspacetimeentryinvitationaction"></a>
# **PostWorkspaceTimeEntryInvitationAction**
> string PostWorkspaceTimeEntryInvitationAction (int? workspaceId, int? timeEntryInvitationId)

TimeEntries

Accept or reject an invitation for a time entry

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostWorkspaceTimeEntryInvitationActionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TimeEntriesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var timeEntryInvitationId = 56;  // int? | Numeric ID of the time entry invitation

            try
            {
                // TimeEntries
                string result = apiInstance.PostWorkspaceTimeEntryInvitationAction(workspaceId, timeEntryInvitationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeEntriesApi.PostWorkspaceTimeEntryInvitationAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **timeEntryInvitationId** | **int?**| Numeric ID of the time entry invitation | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="puttimeentrynotesbyid"></a>
# **PutTimeEntryNotesById**
> ModelsTimeEntryNotes PutTimeEntryNotesById (int? timeEntryId)

Put a time entry notes by ID.

Load time entry notes by ID that is accessible by the current user.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutTimeEntryNotesByIdExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TimeEntriesApi();
            var timeEntryId = 56;  // int? | TimeEntry ID.

            try
            {
                // Put a time entry notes by ID.
                ModelsTimeEntryNotes result = apiInstance.PutTimeEntryNotesById(timeEntryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeEntriesApi.PutTimeEntryNotesById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timeEntryId** | **int?**| TimeEntry ID. | 

### Return type

[**ModelsTimeEntryNotes**](ModelsTimeEntryNotes.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putworkspacetimeentryhandler"></a>
# **PutWorkspaceTimeEntryHandler**
> ModelsTimeEntry PutWorkspaceTimeEntryHandler (int? workspaceId, int? timeEntryId, TimeentryPayload workspaceTimeEntryPost, bool? meta = null, bool? includeSharing = null)

TimeEntries

Updates a workspace time entry.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutWorkspaceTimeEntryHandlerExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TimeEntriesApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var timeEntryId = 56;  // int? | TimeEntry ID.
            var workspaceTimeEntryPost = new TimeentryPayload(); // TimeentryPayload | TimeEntry parameters.
            var meta = true;  // bool? | Should the response contain data for meta entities (optional) 
            var includeSharing = true;  // bool? | Should the response contain time entry sharing details (optional) 

            try
            {
                // TimeEntries
                ModelsTimeEntry result = apiInstance.PutWorkspaceTimeEntryHandler(workspaceId, timeEntryId, workspaceTimeEntryPost, meta, includeSharing);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeEntriesApi.PutWorkspaceTimeEntryHandler: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **timeEntryId** | **int?**| TimeEntry ID. | 
 **workspaceTimeEntryPost** | [**TimeentryPayload**](TimeentryPayload.md)| TimeEntry parameters. | 
 **meta** | **bool?**| Should the response contain data for meta entities | [optional] 
 **includeSharing** | **bool?**| Should the response contain time entry sharing details | [optional] 

### Return type

[**ModelsTimeEntry**](ModelsTimeEntry.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

