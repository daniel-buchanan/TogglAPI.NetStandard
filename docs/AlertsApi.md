# TogglAPI.NetStandard.Api.AlertsApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAlerts**](AlertsApi.md#deletealerts) | **DELETE** /workspaces/{workspace_id}/alerts/{alert_id} | Alerts
[**GetAlerts**](AlertsApi.md#getalerts) | **GET** /workspaces/{workspace_id}/alerts | Alerts
[**PostAlerts**](AlertsApi.md#postalerts) | **POST** /workspaces/{workspace_id}/alerts | Alerts
[**PutAlerts**](AlertsApi.md#putalerts) | **PUT** /workspaces/{workspace_id}/alerts/{alert_id} | Alerts


<a name="deletealerts"></a>
# **DeleteAlerts**
> string DeleteAlerts ()

Alerts

Handles DELETE alert requests.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteAlertsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AlertsApi();

            try
            {
                // Alerts
                string result = apiInstance.DeleteAlerts();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.DeleteAlerts: " + e.Message );
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

<a name="getalerts"></a>
# **GetAlerts**
> List<ModelsAlert> GetAlerts ()

Alerts

Returns a list of existing alerts

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetAlertsExample
    {
        public void main()
        {
            var apiInstance = new AlertsApi();

            try
            {
                // Alerts
                List&lt;ModelsAlert&gt; result = apiInstance.GetAlerts();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.GetAlerts: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ModelsAlert>**](ModelsAlert.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postalerts"></a>
# **PostAlerts**
> ModelsAlert PostAlerts (object request)

Alerts

Handles POST alert requests.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostAlertsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AlertsApi();
            var request = new object(); // object | Alert data

            try
            {
                // Alerts
                ModelsAlert result = apiInstance.PostAlerts(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.PostAlerts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**object**](object.md)| Alert data | 

### Return type

[**ModelsAlert**](ModelsAlert.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putalerts"></a>
# **PutAlerts**
> ModelsAlert PutAlerts (object request)

Alerts

Handles PUT alert requests.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutAlertsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AlertsApi();
            var request = new object(); // object | Alert data

            try
            {
                // Alerts
                ModelsAlert result = apiInstance.PutAlerts(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.PutAlerts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**object**](object.md)| Alert data | 

### Return type

[**ModelsAlert**](ModelsAlert.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

