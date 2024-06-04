# TogglAPI.NetStandard.Api.TimeEntriesNotesApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteTimeEntryNotesById**](TimeEntriesNotesApi.md#deletetimeentrynotesbyid) | **DELETE** /me/time_entries/{time_entry_id}/notes | delete a time entry note by ID.


<a name="deletetimeentrynotesbyid"></a>
# **DeleteTimeEntryNotesById**
> string DeleteTimeEntryNotesById (int? timeEntryId)

delete a time entry note by ID.

Delete time entry notes by ID that is accessible by the current user.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteTimeEntryNotesByIdExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TimeEntriesNotesApi();
            var timeEntryId = 56;  // int? | TimeEntry ID.

            try
            {
                // delete a time entry note by ID.
                string result = apiInstance.DeleteTimeEntryNotesById(timeEntryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeEntriesNotesApi.DeleteTimeEntryNotesById: " + e.Message );
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

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

