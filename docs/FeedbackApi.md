# TogglAPI.NetStandard.Api.FeedbackApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostFeedbackWeb**](FeedbackApi.md#postfeedbackweb) | **POST** /feedback/web | FeedbackWeb
[**PostUnifiedFeedback**](FeedbackApi.md#postunifiedfeedback) | **POST** /feedback | Feedback


<a name="postfeedbackweb"></a>
# **PostFeedbackWeb**
> void PostFeedbackWeb (string togglVersion, string date, string details, string updateChannel = null, string subject = null, bool? latest = null, System.IO.Stream files = null)

FeedbackWeb

Send Feedback web.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostFeedbackWebExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FeedbackApi();
            var togglVersion = togglVersion_example;  // string | Toggl version.
            var date = date_example;  // string | Feedback date.
            var details = details_example;  // string | Feedback details.
            var updateChannel = updateChannel_example;  // string | Update channel. (optional) 
            var subject = subject_example;  // string | Email subject. (optional) 
            var latest = true;  // bool? | Latest feedback. (optional) 
            var files = new System.IO.Stream(); // System.IO.Stream | One or more files. (optional) 

            try
            {
                // FeedbackWeb
                apiInstance.PostFeedbackWeb(togglVersion, date, details, updateChannel, subject, latest, files);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeedbackApi.PostFeedbackWeb: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **togglVersion** | **string**| Toggl version. | 
 **date** | **string**| Feedback date. | 
 **details** | **string**| Feedback details. | 
 **updateChannel** | **string**| Update channel. | [optional] 
 **subject** | **string**| Email subject. | [optional] 
 **latest** | **bool?**| Latest feedback. | [optional] 
 **files** | **System.IO.Stream**| One or more files. | [optional] 

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postunifiedfeedback"></a>
# **PostUnifiedFeedback**
> void PostUnifiedFeedback (string togglVersion, string date, string details, string updateChannel = null, string subject = null, string deviceModel = null, string buildNumber = null, string operatingSystem = null, bool? latest = null, System.IO.Stream files = null)

Feedback

Send Feedback

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostUnifiedFeedbackExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FeedbackApi();
            var togglVersion = togglVersion_example;  // string | Toggl version.
            var date = date_example;  // string | Feedback date.
            var details = details_example;  // string | Feedback details.
            var updateChannel = updateChannel_example;  // string | Update channel. (optional) 
            var subject = subject_example;  // string | Email subject. (optional) 
            var deviceModel = deviceModel_example;  // string | Device Model. (optional) 
            var buildNumber = buildNumber_example;  // string | Build Number. (optional) 
            var operatingSystem = operatingSystem_example;  // string | Operating system. (optional) 
            var latest = true;  // bool? | Latest feedback. (optional) 
            var files = new System.IO.Stream(); // System.IO.Stream | One or more files. (optional) 

            try
            {
                // Feedback
                apiInstance.PostUnifiedFeedback(togglVersion, date, details, updateChannel, subject, deviceModel, buildNumber, operatingSystem, latest, files);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeedbackApi.PostUnifiedFeedback: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **togglVersion** | **string**| Toggl version. | 
 **date** | **string**| Feedback date. | 
 **details** | **string**| Feedback details. | 
 **updateChannel** | **string**| Update channel. | [optional] 
 **subject** | **string**| Email subject. | [optional] 
 **deviceModel** | **string**| Device Model. | [optional] 
 **buildNumber** | **string**| Build Number. | [optional] 
 **operatingSystem** | **string**| Operating system. | [optional] 
 **latest** | **bool?**| Latest feedback. | [optional] 
 **files** | **System.IO.Stream**| One or more files. | [optional] 

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

