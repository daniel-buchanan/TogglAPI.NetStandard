# TogglAPI.NetStandard.Api.OrganizationssubscriptionApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostOrganizationSubscriptionCalculate**](OrganizationssubscriptionApi.md#postorganizationsubscriptioncalculate) | **POST** /organizations/{organization_id}/subscription/calculate | SubscriptionCalculation


<a name="postorganizationsubscriptioncalculate"></a>
# **PostOrganizationSubscriptionCalculate**
> CalculateResponse PostOrganizationSubscriptionCalculate (int? organizationId, CalculateCalculateRequest calculationDataRequest)

SubscriptionCalculation

Returns calculation of the subscription price for given pricing plan, period count, user count, currency, taxes etc.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostOrganizationSubscriptionCalculateExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationssubscriptionApi();
            var organizationId = 56;  // int? | Numeric ID of the organizaiton.
            var calculationDataRequest = new CalculateCalculateRequest(); // CalculateCalculateRequest | Input data for calculation.

            try
            {
                // SubscriptionCalculation
                CalculateResponse result = apiInstance.PostOrganizationSubscriptionCalculate(organizationId, calculationDataRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationssubscriptionApi.PostOrganizationSubscriptionCalculate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organizaiton. | 
 **calculationDataRequest** | [**CalculateCalculateRequest**](CalculateCalculateRequest.md)| Input data for calculation. | 

### Return type

[**CalculateResponse**](CalculateResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

