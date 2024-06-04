# TogglAPI.NetStandard.Api.SmailApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostSmailContact**](SmailApi.md#postsmailcontact) | **POST** /smail/contact | Send an email to a contact
[**PostSmailDemo**](SmailApi.md#postsmaildemo) | **POST** /smail/demo | Send an email for a demo
[**PostSmailMeet**](SmailApi.md#postsmailmeet) | **POST** /smail/meet | Send an email for meet


<a name="postsmailcontact"></a>
# **PostSmailContact**
> string PostSmailContact (SmailContactPayload emailInfo)

Send an email to a contact

Send an email to a contact

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostSmailContactExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SmailApi();
            var emailInfo = new SmailContactPayload(); // SmailContactPayload | Email informations

            try
            {
                // Send an email to a contact
                string result = apiInstance.PostSmailContact(emailInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmailApi.PostSmailContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailInfo** | [**SmailContactPayload**](SmailContactPayload.md)| Email informations | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsmaildemo"></a>
# **PostSmailDemo**
> string PostSmailDemo (SmailDemoPayload emailInfo)

Send an email for a demo

Send an email for a demo

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostSmailDemoExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SmailApi();
            var emailInfo = new SmailDemoPayload(); // SmailDemoPayload | Email informations

            try
            {
                // Send an email for a demo
                string result = apiInstance.PostSmailDemo(emailInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmailApi.PostSmailDemo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailInfo** | [**SmailDemoPayload**](SmailDemoPayload.md)| Email informations | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsmailmeet"></a>
# **PostSmailMeet**
> string PostSmailMeet (SmailMeetPayload emailLocation)

Send an email for meet

Send an email for meet with message and location

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostSmailMeetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SmailApi();
            var emailLocation = new SmailMeetPayload(); // SmailMeetPayload | Email and Location

            try
            {
                // Send an email for meet
                string result = apiInstance.PostSmailMeet(emailLocation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmailApi.PostSmailMeet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailLocation** | [**SmailMeetPayload**](SmailMeetPayload.md)| Email and Location | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

