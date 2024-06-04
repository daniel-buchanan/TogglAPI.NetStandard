# TogglAPI.NetStandard.Api.TimelineApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TimelineDelete**](TimelineApi.md#timelinedelete) | **DELETE** /timeline | Delete all timeline data
[**TimelineGet**](TimelineApi.md#timelineget) | **GET** /timeline | Get timeline events
[**TimelinePost**](TimelineApi.md#timelinepost) | **POST** /timeline | Save timeline events


<a name="timelinedelete"></a>
# **TimelineDelete**
> void TimelineDelete ()

Delete all timeline data

Delete all timeline data for the current user

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class TimelineDeleteExample
    {
        public void main()
        {
            var apiInstance = new TimelineApi();

            try
            {
                // Delete all timeline data
                apiInstance.TimelineDelete();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimelineApi.TimelineDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timelineget"></a>
# **TimelineGet**
> List<ModelsTimelineEvent> TimelineGet (int? startDate = null, int? endDate = null)

Get timeline events

Get timeline events

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class TimelineGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TimelineApi();
            var startDate = 56;  // int? | Unix timestamp of the start date (optional) 
            var endDate = 56;  // int? | Unix timestamp of the end date (optional) 

            try
            {
                // Get timeline events
                List&lt;ModelsTimelineEvent&gt; result = apiInstance.TimelineGet(startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimelineApi.TimelineGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **int?**| Unix timestamp of the start date | [optional] 
 **endDate** | **int?**| Unix timestamp of the end date | [optional] 

### Return type

[**List<ModelsTimelineEvent>**](ModelsTimelineEvent.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timelinepost"></a>
# **TimelinePost**
> ModelsTimelineSettings TimelinePost (List<ModelsTimelineEvent> timelinePost = null)

Save timeline events

Save timeline events and returns timeline settings

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class TimelinePostExample
    {
        public void main()
        {
            var apiInstance = new TimelineApi();
            var timelinePost = new List<ModelsTimelineEvent>(); // List<ModelsTimelineEvent> | timeline events (optional) 

            try
            {
                // Save timeline events
                ModelsTimelineSettings result = apiInstance.TimelinePost(timelinePost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimelineApi.TimelinePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timelinePost** | [**List&lt;ModelsTimelineEvent&gt;**](ModelsTimelineEvent.md)| timeline events | [optional] 

### Return type

[**ModelsTimelineSettings**](ModelsTimelineSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

