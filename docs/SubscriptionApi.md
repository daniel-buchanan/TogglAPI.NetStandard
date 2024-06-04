# TogglAPI.NetStandard.Api.SubscriptionApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteOrganizationSubscription**](SubscriptionApi.md#deleteorganizationsubscription) | **DELETE** /organizations/{organization_id}/subscription | Subscription
[**DeleteWorkspaceSubscription**](SubscriptionApi.md#deleteworkspacesubscription) | **DELETE** /workspaces/{workspace_id}/subscription/{subscription_id} | Subscription
[**GetCurrencies**](SubscriptionApi.md#getcurrencies) | **GET** /currencies | Currencies
[**GetOrganizationInvoice**](SubscriptionApi.md#getorganizationinvoice) | **GET** /organizations/{organization_id}/invoices/{invoice_uid}.pdf | InvoicePdf
[**GetOrganizationInvoiceSummary**](SubscriptionApi.md#getorganizationinvoicesummary) | **GET** /organizations/{organization_id}/subscription/invoice_summary | Invoice Summary
[**GetOrganizationSubscription**](SubscriptionApi.md#getorganizationsubscription) | **GET** /organizations/{organization_id}/subscription | Subscription
[**GetPublicSubscriptionPlans**](SubscriptionApi.md#getpublicsubscriptionplans) | **GET** /workspaces/plans | Public Subscription Plans
[**GetWorkspaceCurrencies**](SubscriptionApi.md#getworkspacecurrencies) | **GET** /workspaces/{workspace_id}/currencies | Get workspace currencies
[**GetWorkspaceCustomer**](SubscriptionApi.md#getworkspacecustomer) | **GET** /workspaces/{workspace_id}/customer | Customer
[**GetWorkspaceFeatures**](SubscriptionApi.md#getworkspacefeatures) | **GET** /workspaces/{workspace_id}/subscription/features | Features
[**GetWorkspaceFeaturesSelected**](SubscriptionApi.md#getworkspacefeaturesselected) | **GET** /workspaces/{workspace_id}/subscription/selected_features | SelectedFeatures
[**GetWorkspaceInvoices**](SubscriptionApi.md#getworkspaceinvoices) | **GET** /workspaces/{workspace_id}/invoices/{invoice_id}.pdf | InvoicePdf
[**GetWorkspacePaymentReceipts**](SubscriptionApi.md#getworkspacepaymentreceipts) | **GET** /workspaces/{workspace_id}/payment_receipts/{payment_id}.pdf | PaymentReceipts
[**GetWorkspacePaymentRecords**](SubscriptionApi.md#getworkspacepaymentrecords) | **GET** /workspaces/{workspace_id}/payment_records | PaymentRecords
[**GetWorkspacePlans**](SubscriptionApi.md#getworkspaceplans) | **GET** /workspaces/{workspace_id}/plans | WorkspacePlans
[**GetWorkspacePlansPricing**](SubscriptionApi.md#getworkspaceplanspricing) | **GET** /workspaces/{workspace_id}/plans/{plan_id} | WorkspacePlan
[**GetWorkspacePurchaseOrderPdf**](SubscriptionApi.md#getworkspacepurchaseorderpdf) | **GET** /workspaces/{workspace_id}/subscription/purchase_orders/{purchase_order_id}.pdf | PurchaseOrderPdf
[**GetWorkspaceSubscription**](SubscriptionApi.md#getworkspacesubscription) | **GET** /workspaces/{workspace_id}/subscription | Subscription
[**PostOrganizationPlansPricingFeedback**](SubscriptionApi.md#postorganizationplanspricingfeedback) | **POST** /organizations/{organization_id}/pricing_plans/{pricing_plan_id}/feedback | Feedback
[**PostOrganizationPurchaseOrder**](SubscriptionApi.md#postorganizationpurchaseorder) | **POST** /organizations/{organization_id}/subscription/purchase_orders | PurchaseOrders
[**PostOrganizationSubscription**](SubscriptionApi.md#postorganizationsubscription) | **POST** /organizations/{organization_id}/subscription | Subscription
[**PostOrganizationSubscription_0**](SubscriptionApi.md#postorganizationsubscription_0) | **POST** /organizations/{organization_id}/subscription/trial | Subscription
[**PostWorkspaceCustomer**](SubscriptionApi.md#postworkspacecustomer) | **POST** /workspaces/{workspace_id}/customer/contact_detail | ContactDetails
[**PostWorkspacePlansPricingFeedback**](SubscriptionApi.md#postworkspaceplanspricingfeedback) | **POST** /workspaces/{workspace_id}/pricing_plans/{pricing_plan_id}/feedback | Feedback
[**PostWorkspacePurchaseOrder**](SubscriptionApi.md#postworkspacepurchaseorder) | **POST** /workspaces/{workspace_id}/subscription/purchase_orders | PurchaseOrders
[**PostWorkspaceSubscription**](SubscriptionApi.md#postworkspacesubscription) | **POST** /workspaces/{workspace_id}/subscription | Subscription
[**PostWorkspaceSubscriptionCalculate**](SubscriptionApi.md#postworkspacesubscriptioncalculate) | **POST** /workspaces/{workspace_id}/subscription/calculate | SubscriptionCalculation
[**PostWorkspaceSubscriptionIncAccept**](SubscriptionApi.md#postworkspacesubscriptionincaccept) | **POST** /workspaces/{workspace_id}/subscription/inc_accept | IncAccept
[**PutOrganizationSubscription**](SubscriptionApi.md#putorganizationsubscription) | **PUT** /organizations/{organization_id}/subscription | Subscription
[**PutWorkspaceProfile**](SubscriptionApi.md#putworkspaceprofile) | **PUT** /workspaces/{workspace_id}/profile/{profile_id} | Profile


<a name="deleteorganizationsubscription"></a>
# **DeleteOrganizationSubscription**
> string DeleteOrganizationSubscription (int? organizationId, string immediateCancel)

Subscription

Cancels an existing subscription.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteOrganizationSubscriptionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var organizationId = 56;  // int? | Numeric ID of the organization.
            var immediateCancel = immediateCancel_example;  // string | If true, the subscription is canceled immediately otherwise canceled at period end

            try
            {
                // Subscription
                string result = apiInstance.DeleteOrganizationSubscription(organizationId, immediateCancel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.DeleteOrganizationSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization. | 
 **immediateCancel** | **string**| If true, the subscription is canceled immediately otherwise canceled at period end | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteworkspacesubscription"></a>
# **DeleteWorkspaceSubscription**
> string DeleteWorkspaceSubscription (int? workspaceId, int? subscriptionId, ModelsPlanChangeFeedback feedbackData)

Subscription

Cancels the subscription and saves feedback if present.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteWorkspaceSubscriptionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.
            var subscriptionId = 56;  // int? | Numeric ID of the subscription.
            var feedbackData = new ModelsPlanChangeFeedback(); // ModelsPlanChangeFeedback | Feedback data.

            try
            {
                // Subscription
                string result = apiInstance.DeleteWorkspaceSubscription(workspaceId, subscriptionId, feedbackData);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.DeleteWorkspaceSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace. | 
 **subscriptionId** | **int?**| Numeric ID of the subscription. | 
 **feedbackData** | [**ModelsPlanChangeFeedback**](ModelsPlanChangeFeedback.md)| Feedback data. | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrencies"></a>
# **GetCurrencies**
> List<ModelsCurrency> GetCurrencies ()

Currencies

Returns a list of available currencies.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetCurrenciesExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionApi();

            try
            {
                // Currencies
                List&lt;ModelsCurrency&gt; result = apiInstance.GetCurrencies();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetCurrencies: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ModelsCurrency>**](ModelsCurrency.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationinvoice"></a>
# **GetOrganizationInvoice**
> string GetOrganizationInvoice (int? organizationId, string invoiceUid)

InvoicePdf

Returns a Invoice document in PDF form.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetOrganizationInvoiceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var organizationId = 56;  // int? | Numeric ID of the organization.
            var invoiceUid = invoiceUid_example;  // string | Numeric ID or string ID of the invoice.

            try
            {
                // InvoicePdf
                string result = apiInstance.GetOrganizationInvoice(organizationId, invoiceUid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetOrganizationInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization. | 
 **invoiceUid** | **string**| Numeric ID or string ID of the invoice. | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationinvoicesummary"></a>
# **GetOrganizationInvoiceSummary**
> string GetOrganizationInvoiceSummary (int? organizationId, int? quantity = null, string pricingPlanTag = null)

Invoice Summary

Returns a summary of the next invoice for an Organization

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetOrganizationInvoiceSummaryExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var organizationId = 56;  // int? | Numeric ID of the organization.
            var quantity = 56;  // int? | Quantity of the subscription (optional) 
            var pricingPlanTag = pricingPlanTag_example;  // string | Pricing plan tag (optional) 

            try
            {
                // Invoice Summary
                string result = apiInstance.GetOrganizationInvoiceSummary(organizationId, quantity, pricingPlanTag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetOrganizationInvoiceSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization. | 
 **quantity** | **int?**| Quantity of the subscription | [optional] 
 **pricingPlanTag** | **string**| Pricing plan tag | [optional] 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationsubscription"></a>
# **GetOrganizationSubscription**
> SubscriptionOutData GetOrganizationSubscription (int? organizationId)

Subscription

Returns subscription data.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetOrganizationSubscriptionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var organizationId = 56;  // int? | Numeric ID of the organization.

            try
            {
                // Subscription
                SubscriptionOutData result = apiInstance.GetOrganizationSubscription(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetOrganizationSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization. | 

### Return type

[**SubscriptionOutData**](SubscriptionOutData.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpublicsubscriptionplans"></a>
# **GetPublicSubscriptionPlans**
> List<BillingFancyPlan> GetPublicSubscriptionPlans ()

Public Subscription Plans

Lists Public subscription plans.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetPublicSubscriptionPlansExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionApi();

            try
            {
                // Public Subscription Plans
                List&lt;BillingFancyPlan&gt; result = apiInstance.GetPublicSubscriptionPlans();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetPublicSubscriptionPlans: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<BillingFancyPlan>**](BillingFancyPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacecurrencies"></a>
# **GetWorkspaceCurrencies**
> List<string> GetWorkspaceCurrencies (int? workspaceId)

Get workspace currencies

Get the currencies for a given workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceCurrenciesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace

            try
            {
                // Get workspace currencies
                List&lt;string&gt; result = apiInstance.GetWorkspaceCurrencies(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetWorkspaceCurrencies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 

### Return type

**List<string>**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacecustomer"></a>
# **GetWorkspaceCustomer**
> ModelsCustomer GetWorkspaceCustomer (int? workspaceId)

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
    public class GetWorkspaceCustomerExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace

            try
            {
                // Customer
                ModelsCustomer result = apiInstance.GetWorkspaceCustomer(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetWorkspaceCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 

### Return type

[**ModelsCustomer**](ModelsCustomer.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacefeatures"></a>
# **GetWorkspaceFeatures**
> SubscriptionFeatureReturn GetWorkspaceFeatures (int? workspaceId)

Features

Returns list of the features available for a workspace

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceFeaturesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.

            try
            {
                // Features
                SubscriptionFeatureReturn result = apiInstance.GetWorkspaceFeatures(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetWorkspaceFeatures: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace. | 

### Return type

[**SubscriptionFeatureReturn**](SubscriptionFeatureReturn.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacefeaturesselected"></a>
# **GetWorkspaceFeaturesSelected**
> SubscriptionFeatureReturn GetWorkspaceFeaturesSelected (int? workspaceId)

SelectedFeatures

Returns list of the features assigned to the workspace

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceFeaturesSelectedExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.

            try
            {
                // SelectedFeatures
                SubscriptionFeatureReturn result = apiInstance.GetWorkspaceFeaturesSelected(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetWorkspaceFeaturesSelected: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace. | 

### Return type

[**SubscriptionFeatureReturn**](SubscriptionFeatureReturn.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspaceinvoices"></a>
# **GetWorkspaceInvoices**
> string GetWorkspaceInvoices (int? workspaceId, int? invoiceId)

InvoicePdf

Returns an Invoice document in PDF form.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceInvoicesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.
            var invoiceId = 56;  // int? | Numeric ID of the invoice.

            try
            {
                // InvoicePdf
                string result = apiInstance.GetWorkspaceInvoices(workspaceId, invoiceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetWorkspaceInvoices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace. | 
 **invoiceId** | **int?**| Numeric ID of the invoice. | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacepaymentreceipts"></a>
# **GetWorkspacePaymentReceipts**
> string GetWorkspacePaymentReceipts (int? workspaceId, int? paymentId)

PaymentReceipts

Returns payment receipt pdf file.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspacePaymentReceiptsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var paymentId = 56;  // int? | Numeric ID of the receipt

            try
            {
                // PaymentReceipts
                string result = apiInstance.GetWorkspacePaymentReceipts(workspaceId, paymentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetWorkspacePaymentReceipts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **paymentId** | **int?**| Numeric ID of the receipt | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacepaymentrecords"></a>
# **GetWorkspacePaymentRecords**
> List<ModelsPaymentRecord> GetWorkspacePaymentRecords (int? workspaceId)

PaymentRecords

Returns payment records.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspacePaymentRecordsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace

            try
            {
                // PaymentRecords
                List&lt;ModelsPaymentRecord&gt; result = apiInstance.GetWorkspacePaymentRecords(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetWorkspacePaymentRecords: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 

### Return type

[**List<ModelsPaymentRecord>**](ModelsPaymentRecord.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspaceplans"></a>
# **GetWorkspacePlans**
> string GetWorkspacePlans (int? workspaceId)

WorkspacePlans

Returns pricing plans for a workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspacePlansExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace

            try
            {
                // WorkspacePlans
                string result = apiInstance.GetWorkspacePlans(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetWorkspacePlans: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspaceplanspricing"></a>
# **GetWorkspacePlansPricing**
> List<BillingFancyPlan> GetWorkspacePlansPricing (int? workspaceId, int? planId)

WorkspacePlan

Returns plans fitered by plan ID.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspacePlansPricingExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var planId = 56;  // int? | Numeric ID of the plan to get

            try
            {
                // WorkspacePlan
                List&lt;BillingFancyPlan&gt; result = apiInstance.GetWorkspacePlansPricing(workspaceId, planId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetWorkspacePlansPricing: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **planId** | **int?**| Numeric ID of the plan to get | 

### Return type

[**List<BillingFancyPlan>**](BillingFancyPlan.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacepurchaseorderpdf"></a>
# **GetWorkspacePurchaseOrderPdf**
> string GetWorkspacePurchaseOrderPdf (int? workspaceId, int? purchaseOrderId)

PurchaseOrderPdf

Returns a Purchase Order document in PDF form.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspacePurchaseOrderPdfExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.
            var purchaseOrderId = 56;  // int? | Numeric ID of the purchase order.

            try
            {
                // PurchaseOrderPdf
                string result = apiInstance.GetWorkspacePurchaseOrderPdf(workspaceId, purchaseOrderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetWorkspacePurchaseOrderPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace. | 
 **purchaseOrderId** | **int?**| Numeric ID of the purchase order. | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacesubscription"></a>
# **GetWorkspaceSubscription**
> SubscriptionOutData GetWorkspaceSubscription (int? workspaceId)

Subscription

Returns subscription data.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceSubscriptionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.

            try
            {
                // Subscription
                SubscriptionOutData result = apiInstance.GetWorkspaceSubscription(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetWorkspaceSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace. | 

### Return type

[**SubscriptionOutData**](SubscriptionOutData.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postorganizationplanspricingfeedback"></a>
# **PostOrganizationPlansPricingFeedback**
> string PostOrganizationPlansPricingFeedback (int? organizationId, int? pricingPlanId, ModelsPlanChangeFeedback comment = null)

Feedback

Endpoint for client's feedback on change of a pricing plan. It triggers an e-mail message with comment content to support.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostOrganizationPlansPricingFeedbackExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var organizationId = 56;  // int? | Numeric ID of the organization
            var pricingPlanId = 56;  // int? | Numeric ID of the old pricing_plan_id
            var comment = new ModelsPlanChangeFeedback(); // ModelsPlanChangeFeedback | Comment from the client on the pricing plan change (optional) 

            try
            {
                // Feedback
                string result = apiInstance.PostOrganizationPlansPricingFeedback(organizationId, pricingPlanId, comment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.PostOrganizationPlansPricingFeedback: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization | 
 **pricingPlanId** | **int?**| Numeric ID of the old pricing_plan_id | 
 **comment** | [**ModelsPlanChangeFeedback**](ModelsPlanChangeFeedback.md)| Comment from the client on the pricing plan change | [optional] 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postorganizationpurchaseorder"></a>
# **PostOrganizationPurchaseOrder**
> AccountingPurchaseOrderListItem PostOrganizationPurchaseOrder (int? organizationId, PurchaseordersPayload organizationPurchaseOrderRequest)

PurchaseOrders

Create a Purchase Order document for an organization and send an email to the customer with a reference to the document.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostOrganizationPurchaseOrderExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var organizationId = 56;  // int? | Numeric ID of the organization.
            var organizationPurchaseOrderRequest = new PurchaseordersPayload(); // PurchaseordersPayload | Input data for purchase order creation.

            try
            {
                // PurchaseOrders
                AccountingPurchaseOrderListItem result = apiInstance.PostOrganizationPurchaseOrder(organizationId, organizationPurchaseOrderRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.PostOrganizationPurchaseOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization. | 
 **organizationPurchaseOrderRequest** | [**PurchaseordersPayload**](PurchaseordersPayload.md)| Input data for purchase order creation. | 

### Return type

[**AccountingPurchaseOrderListItem**](AccountingPurchaseOrderListItem.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postorganizationsubscription"></a>
# **PostOrganizationSubscription**
> void PostOrganizationSubscription (int? organizationId, SubscriptionCreateUnifiedSubsRequest organizationSubscriptionRequest)

Subscription

Allows to create a new unified subscription for an organization.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostOrganizationSubscriptionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var organizationId = 56;  // int? | Numeric ID of the organization.
            var organizationSubscriptionRequest = new SubscriptionCreateUnifiedSubsRequest(); // SubscriptionCreateUnifiedSubsRequest | Input data for subscription creation.

            try
            {
                // Subscription
                apiInstance.PostOrganizationSubscription(organizationId, organizationSubscriptionRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.PostOrganizationSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization. | 
 **organizationSubscriptionRequest** | [**SubscriptionCreateUnifiedSubsRequest**](SubscriptionCreateUnifiedSubsRequest.md)| Input data for subscription creation. | 

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postorganizationsubscription_0"></a>
# **PostOrganizationSubscription_0**
> void PostOrganizationSubscription_0 (int? organizationId)

Subscription

Allows to create a new unified subscription on initial 30-day trial for an organization.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostOrganizationSubscription_0Example
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var organizationId = 56;  // int? | Numeric ID of the organization.

            try
            {
                // Subscription
                apiInstance.PostOrganizationSubscription_0(organizationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.PostOrganizationSubscription_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization. | 

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postworkspacecustomer"></a>
# **PostWorkspaceCustomer**
> ModelsContactDetail PostWorkspaceCustomer (int? workspaceId, SubscriptionContactDetailRequest contactDetailRequest)

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
    public class PostWorkspaceCustomerExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.
            var contactDetailRequest = new SubscriptionContactDetailRequest(); // SubscriptionContactDetailRequest | Input data for contact details.

            try
            {
                // ContactDetails
                ModelsContactDetail result = apiInstance.PostWorkspaceCustomer(workspaceId, contactDetailRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.PostWorkspaceCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace. | 
 **contactDetailRequest** | [**SubscriptionContactDetailRequest**](SubscriptionContactDetailRequest.md)| Input data for contact details. | 

### Return type

[**ModelsContactDetail**](ModelsContactDetail.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postworkspaceplanspricingfeedback"></a>
# **PostWorkspacePlansPricingFeedback**
> string PostWorkspacePlansPricingFeedback (int? workspaceId, int? pricingPlanId, ModelsPlanChangeFeedback comment = null)

Feedback

Endpoint for client's feedback on change of a pricing plan. It triggers an e-mail message with comment content to support.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostWorkspacePlansPricingFeedbackExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var pricingPlanId = 56;  // int? | Numeric ID of the old pricing_plan_id
            var comment = new ModelsPlanChangeFeedback(); // ModelsPlanChangeFeedback | Comment from the client on the pricing plan change (optional) 

            try
            {
                // Feedback
                string result = apiInstance.PostWorkspacePlansPricingFeedback(workspaceId, pricingPlanId, comment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.PostWorkspacePlansPricingFeedback: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **pricingPlanId** | **int?**| Numeric ID of the old pricing_plan_id | 
 **comment** | [**ModelsPlanChangeFeedback**](ModelsPlanChangeFeedback.md)| Comment from the client on the pricing plan change | [optional] 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postworkspacepurchaseorder"></a>
# **PostWorkspacePurchaseOrder**
> AccountingPurchaseOrderListItem PostWorkspacePurchaseOrder (int? workspaceId, PurchaseordersPayload workspacePurchaseOrderRequest)

PurchaseOrders

Create a Purchase Order document for a workspace and send an email to the customer with a reference to the document.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostWorkspacePurchaseOrderExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.
            var workspacePurchaseOrderRequest = new PurchaseordersPayload(); // PurchaseordersPayload | Input data for purchase order creation.

            try
            {
                // PurchaseOrders
                AccountingPurchaseOrderListItem result = apiInstance.PostWorkspacePurchaseOrder(workspaceId, workspacePurchaseOrderRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.PostWorkspacePurchaseOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace. | 
 **workspacePurchaseOrderRequest** | [**PurchaseordersPayload**](PurchaseordersPayload.md)| Input data for purchase order creation. | 

### Return type

[**AccountingPurchaseOrderListItem**](AccountingPurchaseOrderListItem.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postworkspacesubscription"></a>
# **PostWorkspaceSubscription**
> ModelsSubscription PostWorkspaceSubscription (int? workspaceId, SubscriptionPayload workspaceSubscriptionRequest)

Subscription

Allows to create a new subscription, cancel existing one or change the pricing plan.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostWorkspaceSubscriptionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.
            var workspaceSubscriptionRequest = new SubscriptionPayload(); // SubscriptionPayload | Input data for purchase order creation.

            try
            {
                // Subscription
                ModelsSubscription result = apiInstance.PostWorkspaceSubscription(workspaceId, workspaceSubscriptionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.PostWorkspaceSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace. | 
 **workspaceSubscriptionRequest** | [**SubscriptionPayload**](SubscriptionPayload.md)| Input data for purchase order creation. | 

### Return type

[**ModelsSubscription**](ModelsSubscription.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postworkspacesubscriptioncalculate"></a>
# **PostWorkspaceSubscriptionCalculate**
> SubscriptionCalculatedData PostWorkspaceSubscriptionCalculate (int? workspaceId, SubscriptionCalculateRequest calculationDataRequest)

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
    public class PostWorkspaceSubscriptionCalculateExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.
            var calculationDataRequest = new SubscriptionCalculateRequest(); // SubscriptionCalculateRequest | Input data for calculation.

            try
            {
                // SubscriptionCalculation
                SubscriptionCalculatedData result = apiInstance.PostWorkspaceSubscriptionCalculate(workspaceId, calculationDataRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.PostWorkspaceSubscriptionCalculate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace. | 
 **calculationDataRequest** | [**SubscriptionCalculateRequest**](SubscriptionCalculateRequest.md)| Input data for calculation. | 

### Return type

[**SubscriptionCalculatedData**](SubscriptionCalculatedData.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postworkspacesubscriptionincaccept"></a>
# **PostWorkspaceSubscriptionIncAccept**
> string PostWorkspaceSubscriptionIncAccept (int? workspaceId)

IncAccept

Records user acceptance of Terms of Service.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostWorkspaceSubscriptionIncAcceptExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.

            try
            {
                // IncAccept
                string result = apiInstance.PostWorkspaceSubscriptionIncAccept(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.PostWorkspaceSubscriptionIncAccept: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace. | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putorganizationsubscription"></a>
# **PutOrganizationSubscription**
> void PutOrganizationSubscription (int? organizationId, SubscriptionUpdateUnifiedSubsRequest organizationSubscriptionRequest)

Subscription

Allows to update existing unified subscription for an organization.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutOrganizationSubscriptionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var organizationId = 56;  // int? | Numeric ID of the organization.
            var organizationSubscriptionRequest = new SubscriptionUpdateUnifiedSubsRequest(); // SubscriptionUpdateUnifiedSubsRequest | Input data for updating subscription.

            try
            {
                // Subscription
                apiInstance.PutOrganizationSubscription(organizationId, organizationSubscriptionRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.PutOrganizationSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization. | 
 **organizationSubscriptionRequest** | [**SubscriptionUpdateUnifiedSubsRequest**](SubscriptionUpdateUnifiedSubsRequest.md)| Input data for updating subscription. | 

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putworkspaceprofile"></a>
# **PutWorkspaceProfile**
> string PutWorkspaceProfile (int? workspaceId, int? profileId, ModelsPlanChangeFeedback feedbackData = null)

Profile

Allows to change profile (subscription). This endpoint will be deprecated.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutWorkspaceProfileExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubscriptionApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace.
            var profileId = 56;  // int? | Numeric ID of the profile (pricing plan).
            var feedbackData = new ModelsPlanChangeFeedback(); // ModelsPlanChangeFeedback | Feedback data. (optional) 

            try
            {
                // Profile
                string result = apiInstance.PutWorkspaceProfile(workspaceId, profileId, feedbackData);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.PutWorkspaceProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace. | 
 **profileId** | **int?**| Numeric ID of the profile (pricing plan). | 
 **feedbackData** | [**ModelsPlanChangeFeedback**](ModelsPlanChangeFeedback.md)| Feedback data. | [optional] 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

