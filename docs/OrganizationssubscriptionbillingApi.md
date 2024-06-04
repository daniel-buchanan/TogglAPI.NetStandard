# TogglAPI.NetStandard.Api.OrganizationssubscriptionbillingApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBillingPortalSession**](OrganizationssubscriptionbillingApi.md#createbillingportalsession) | **POST** /organizations/{organization_id}/subscription/billing_portal | Create a billing portal session in the unified subscription system


<a name="createbillingportalsession"></a>
# **CreateBillingPortalSession**
> void CreateBillingPortalSession (int? organizationId, BillingportalPayload _params)

Create a billing portal session in the unified subscription system

Create a subscription billing portal session in the unified subscription system

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class CreateBillingPortalSessionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationssubscriptionbillingApi();
            var organizationId = 56;  // int? | Numeric ID of the organization
            var _params = new BillingportalPayload(); // BillingportalPayload | The billing portal session data

            try
            {
                // Create a billing portal session in the unified subscription system
                apiInstance.CreateBillingPortalSession(organizationId, _params);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationssubscriptionbillingApi.CreateBillingPortalSession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization | 
 **_params** | [**BillingportalPayload**](BillingportalPayload.md)| The billing portal session data | 

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

