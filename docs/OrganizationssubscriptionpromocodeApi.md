# TogglAPI.NetStandard.Api.OrganizationssubscriptionpromocodeApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePromotionCode**](OrganizationssubscriptionpromocodeApi.md#deletepromotioncode) | **DELETE** /organizations/{organization_id}/subscription/promocode | Removes any discount (promotion code) applied to the organization&#39;s customer
[**PostPromotionCode**](OrganizationssubscriptionpromocodeApi.md#postpromotioncode) | **POST** /organizations/{organization_id}/subscription/promocode | Applies the given promotion code to organization&#39;s customer


<a name="deletepromotioncode"></a>
# **DeletePromotionCode**
> void DeletePromotionCode (int? organizationId)

Removes any discount (promotion code) applied to the organization's customer

Removes any discount (promotion code) applied to the organization's customer

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeletePromotionCodeExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationssubscriptionpromocodeApi();
            var organizationId = 56;  // int? | Numeric ID of the organization

            try
            {
                // Removes any discount (promotion code) applied to the organization's customer
                apiInstance.DeletePromotionCode(organizationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationssubscriptionpromocodeApi.DeletePromotionCode: " + e.Message );
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

<a name="postpromotioncode"></a>
# **PostPromotionCode**
> void PostPromotionCode (int? organizationId)

Applies the given promotion code to organization's customer

Applies the given promotion code to organization's customer If the customer already has the promotion code, then it will be overridden

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostPromotionCodeExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationssubscriptionpromocodeApi();
            var organizationId = 56;  // int? | Numeric ID of the organization

            try
            {
                // Applies the given promotion code to organization's customer
                apiInstance.PostPromotionCode(organizationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationssubscriptionpromocodeApi.PostPromotionCode: " + e.Message );
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

