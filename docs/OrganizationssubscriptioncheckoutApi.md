# TogglAPI.NetStandard.Api.OrganizationssubscriptioncheckoutApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSubscriptionCheckoutSession**](OrganizationssubscriptioncheckoutApi.md#createsubscriptioncheckoutsession) | **POST** /organizations/{organization_id}/subscription/checkout_session | Create a subscription checkout session in the unified subscription system


<a name="createsubscriptioncheckoutsession"></a>
# **CreateSubscriptionCheckoutSession**
> void CreateSubscriptionCheckoutSession (int? organizationId, SubscriptionsCheckoutSessionPayload _params)

Create a subscription checkout session in the unified subscription system

Create a subscription checkout session in the unified subscription system

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class CreateSubscriptionCheckoutSessionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationssubscriptioncheckoutApi();
            var organizationId = 56;  // int? | Numeric ID of the organization
            var _params = new SubscriptionsCheckoutSessionPayload(); // SubscriptionsCheckoutSessionPayload | The checkout session data

            try
            {
                // Create a subscription checkout session in the unified subscription system
                apiInstance.CreateSubscriptionCheckoutSession(organizationId, _params);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationssubscriptioncheckoutApi.CreateSubscriptionCheckoutSession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization | 
 **_params** | [**SubscriptionsCheckoutSessionPayload**](SubscriptionsCheckoutSessionPayload.md)| The checkout session data | 

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

