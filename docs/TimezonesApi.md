# TogglAPI.NetStandard.Api.TimezonesApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOffsets**](TimezonesApi.md#getoffsets) | **GET** /timezones/offsets | Offsets
[**GetTimezones**](TimezonesApi.md#gettimezones) | **GET** /timezones | Timezones


<a name="getoffsets"></a>
# **GetOffsets**
> List<ModelsTimezone> GetOffsets ()

Offsets

Returns known timezones with their offsets.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetOffsetsExample
    {
        public void main()
        {
            var apiInstance = new TimezonesApi();

            try
            {
                // Offsets
                List&lt;ModelsTimezone&gt; result = apiInstance.GetOffsets();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimezonesApi.GetOffsets: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ModelsTimezone>**](ModelsTimezone.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettimezones"></a>
# **GetTimezones**
> List<string> GetTimezones ()

Timezones

Returns known timezones.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetTimezonesExample
    {
        public void main()
        {
            var apiInstance = new TimezonesApi();

            try
            {
                // Timezones
                List&lt;string&gt; result = apiInstance.GetTimezones();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimezonesApi.GetTimezones: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

