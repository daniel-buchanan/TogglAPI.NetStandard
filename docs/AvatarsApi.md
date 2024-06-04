# TogglAPI.NetStandard.Api.AvatarsApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAvatars**](AvatarsApi.md#deleteavatars) | **DELETE** /avatars | Avatars
[**PostAvatars**](AvatarsApi.md#postavatars) | **POST** /avatars | Avatars
[**PostUseGravatar**](AvatarsApi.md#postusegravatar) | **POST** /avatars/use_gravatar | UseGravatar


<a name="deleteavatars"></a>
# **DeleteAvatars**
> string DeleteAvatars ()

Avatars

Handles DELETE avatar requests.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteAvatarsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AvatarsApi();

            try
            {
                // Avatars
                string result = apiInstance.DeleteAvatars();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AvatarsApi.DeleteAvatars: " + e.Message );
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

<a name="postavatars"></a>
# **PostAvatars**
> ModelsAvatar PostAvatars (string _file)

Avatars

Handles POST avatar requests.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostAvatarsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AvatarsApi();
            var _file = _file_example;  // string | file form data

            try
            {
                // Avatars
                ModelsAvatar result = apiInstance.PostAvatars(_file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AvatarsApi.PostAvatars: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_file** | **string**| file form data | 

### Return type

[**ModelsAvatar**](ModelsAvatar.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postusegravatar"></a>
# **PostUseGravatar**
> ModelsAvatar PostUseGravatar ()

UseGravatar

Change user avatar to gravatar.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostUseGravatarExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AvatarsApi();

            try
            {
                // UseGravatar
                ModelsAvatar result = apiInstance.PostUseGravatar();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AvatarsApi.PostUseGravatar: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ModelsAvatar**](ModelsAvatar.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

