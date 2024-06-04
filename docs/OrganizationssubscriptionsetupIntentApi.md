# TogglAPI.NetStandard.Api.OrganizationssubscriptionsetupIntentApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSetupIntent**](OrganizationssubscriptionsetupIntentApi.md#createsetupintent) | **POST** /organizations/{organization_id}/subscription/setup_intent | Create a setup intent for collecting customer&#39;s payment method


<a name="createsetupintent"></a>
# **CreateSetupIntent**
> void CreateSetupIntent (int? organizationId)

Create a setup intent for collecting customer's payment method

Create a setup intent for collecting customer's payment method for future payments

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class CreateSetupIntentExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationssubscriptionsetupIntentApi();
            var organizationId = 56;  // int? | Numeric ID of the organization

            try
            {
                // Create a setup intent for collecting customer's payment method
                apiInstance.CreateSetupIntent(organizationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationssubscriptionsetupIntentApi.CreateSetupIntent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization | 

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

