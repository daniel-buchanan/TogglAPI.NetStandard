# TogglAPI.NetStandard.Api.OrganizationscustomerApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOrganizationCustomer**](OrganizationscustomerApi.md#getorganizationcustomer) | **GET** /organizations/{organization_id}/customer | Customer
[**GetUnifiedCustomer**](OrganizationscustomerApi.md#getunifiedcustomer) | **GET** /organizations/{organization_id}/subscription/customer | Retrieve unified customer
[**PostOrganizationCustomer**](OrganizationscustomerApi.md#postorganizationcustomer) | **POST** /organizations/{organization_id}/customer/contact_detail | ContactDetails
[**PostUnifiedCustomer**](OrganizationscustomerApi.md#postunifiedcustomer) | **POST** /organizations/{organization_id}/subscription/customer | Create unified customer
[**PutUnifiedCustomer**](OrganizationscustomerApi.md#putunifiedcustomer) | **PUT** /organizations/{organization_id}/subscription/customer | Update unified customer


<a name="getorganizationcustomer"></a>
# **GetOrganizationCustomer**
> ModelsCustomer GetOrganizationCustomer (int? organizationId)

Customer

Allows to fetch customer data.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetOrganizationCustomerExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationscustomerApi();
            var organizationId = 56;  // int? | Numeric ID of the organization

            try
            {
                // Customer
                ModelsCustomer result = apiInstance.GetOrganizationCustomer(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationscustomerApi.GetOrganizationCustomer: " + e.Message );
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

[**ModelsCustomer**](ModelsCustomer.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getunifiedcustomer"></a>
# **GetUnifiedCustomer**
> CustomerUnifiedCustomerResponse GetUnifiedCustomer (int? organizationId)

Retrieve unified customer

Retrieve unified customer belonging to the organization.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetUnifiedCustomerExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationscustomerApi();
            var organizationId = 56;  // int? | Numeric ID of the organization

            try
            {
                // Retrieve unified customer
                CustomerUnifiedCustomerResponse result = apiInstance.GetUnifiedCustomer(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationscustomerApi.GetUnifiedCustomer: " + e.Message );
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

[**CustomerUnifiedCustomerResponse**](CustomerUnifiedCustomerResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postorganizationcustomer"></a>
# **PostOrganizationCustomer**
> ModelsContactDetail PostOrganizationCustomer (int? organizationId, SubscriptionContactDetailRequest contactDetailRequest)

ContactDetails

Allows to save contact details.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostOrganizationCustomerExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationscustomerApi();
            var organizationId = 56;  // int? | Numeric ID of the workspace.
            var contactDetailRequest = new SubscriptionContactDetailRequest(); // SubscriptionContactDetailRequest | Input data for contact details.

            try
            {
                // ContactDetails
                ModelsContactDetail result = apiInstance.PostOrganizationCustomer(organizationId, contactDetailRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationscustomerApi.PostOrganizationCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the workspace. | 
 **contactDetailRequest** | [**SubscriptionContactDetailRequest**](SubscriptionContactDetailRequest.md)| Input data for contact details. | 

### Return type

[**ModelsContactDetail**](ModelsContactDetail.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postunifiedcustomer"></a>
# **PostUnifiedCustomer**
> CustomerUnifiedCustomerResponse PostUnifiedCustomer (int? organizationId)

Create unified customer

Creates unified customer for organization.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostUnifiedCustomerExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationscustomerApi();
            var organizationId = 56;  // int? | Numeric ID of the organization

            try
            {
                // Create unified customer
                CustomerUnifiedCustomerResponse result = apiInstance.PostUnifiedCustomer(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationscustomerApi.PostUnifiedCustomer: " + e.Message );
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

[**CustomerUnifiedCustomerResponse**](CustomerUnifiedCustomerResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putunifiedcustomer"></a>
# **PutUnifiedCustomer**
> CustomerUnifiedCustomerResponse PutUnifiedCustomer (int? organizationId)

Update unified customer

Allows to update unified customer data. Customer name, email, country & postal code are mandatory fields. Optional fields will be cleared if they don't have a value.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutUnifiedCustomerExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationscustomerApi();
            var organizationId = 56;  // int? | Numeric ID of the organization

            try
            {
                // Update unified customer
                CustomerUnifiedCustomerResponse result = apiInstance.PutUnifiedCustomer(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationscustomerApi.PutUnifiedCustomer: " + e.Message );
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

[**CustomerUnifiedCustomerResponse**](CustomerUnifiedCustomerResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

