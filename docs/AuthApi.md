# TogglAPI.NetStandard.Api.AuthApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DesktopLoginGet**](AuthApi.md#desktoploginget) | **GET** /desktop_login | Get desktop login token
[**DesktopLoginTokensPost**](AuthApi.md#desktoplogintokenspost) | **POST** /desktop_login_tokens | Post desktop login token


<a name="desktoploginget"></a>
# **DesktopLoginGet**
> void DesktopLoginGet ()

Get desktop login token

Store new desktop login token

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DesktopLoginGetExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();

            try
            {
                // Get desktop login token
                apiInstance.DesktopLoginGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.DesktopLoginGet: " + e.Message );
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

<a name="desktoplogintokenspost"></a>
# **DesktopLoginTokensPost**
> DesktopLoginToken DesktopLoginTokensPost ()

Post desktop login token

Store new desktop login token

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DesktopLoginTokensPostExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();

            try
            {
                // Post desktop login token
                DesktopLoginToken result = apiInstance.DesktopLoginTokensPost();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.DesktopLoginTokensPost: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**DesktopLoginToken**](DesktopLoginToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

