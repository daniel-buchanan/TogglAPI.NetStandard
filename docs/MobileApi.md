# TogglAPI.NetStandard.Api.MobileApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostMobileFeedback**](MobileApi.md#postmobilefeedback) | **POST** /mobile/feedback | MobileFeedback


<a name="postmobilefeedback"></a>
# **PostMobileFeedback**
> string PostMobileFeedback (ModelsMobileFeedback mobileFeedbackPost)

MobileFeedback

Send Mobile Feedback.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostMobileFeedbackExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MobileApi();
            var mobileFeedbackPost = new ModelsMobileFeedback(); // ModelsMobileFeedback | Feedback parameters.

            try
            {
                // MobileFeedback
                string result = apiInstance.PostMobileFeedback(mobileFeedbackPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileApi.PostMobileFeedback: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mobileFeedbackPost** | [**ModelsMobileFeedback**](ModelsMobileFeedback.md)| Feedback parameters. | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

