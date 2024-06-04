# TogglAPI.NetStandard.Api.KeysApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetKeys**](KeysApi.md#getkeys) | **GET** /keys | get keys


<a name="getkeys"></a>
# **GetKeys**
> JwkSet GetKeys ()

get keys

Returns the current JWKS keyset used to sign JWT tokens.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetKeysExample
    {
        public void main()
        {
            var apiInstance = new KeysApi();

            try
            {
                // get keys
                JwkSet result = apiInstance.GetKeys();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeysApi.GetKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**JwkSet**](JwkSet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

