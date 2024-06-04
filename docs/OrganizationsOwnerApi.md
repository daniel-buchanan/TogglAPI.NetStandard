# TogglAPI.NetStandard.Api.OrganizationsOwnerApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOwnershipTransfer**](OrganizationsOwnerApi.md#getownershiptransfer) | **GET** /organizations/{organization_id}/owner/transfer/{transfer_id} | Returns single organization transfer in the organization
[**GetOwnershipTransfers**](OrganizationsOwnerApi.md#getownershiptransfers) | **GET** /organizations/{organization_id}/owner/transfer | Returns list of organization transfers made in the organization
[**PostOwnershipTransfer**](OrganizationsOwnerApi.md#postownershiptransfer) | **POST** /organizations/{organization_id}/owner/transfer | Creates new ownership transfer process
[**PostOwnershipTransferActions**](OrganizationsOwnerApi.md#postownershiptransferactions) | **POST** /organizations/{organization_id}/owner/transfer/{transfer_id}/{action} | Updates transfer process and emails stakeholders


<a name="getownershiptransfer"></a>
# **GetOwnershipTransfer**
> ModelsTransfer GetOwnershipTransfer (int? organizationId, int? transferId)

Returns single organization transfer in the organization

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetOwnershipTransferExample
    {
        public void main()
        {
            var apiInstance = new OrganizationsOwnerApi();
            var organizationId = 56;  // int? | Numeric ID of the organization.
            var transferId = 56;  // int? | Numeric ID of the transfer.

            try
            {
                // Returns single organization transfer in the organization
                ModelsTransfer result = apiInstance.GetOwnershipTransfer(organizationId, transferId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsOwnerApi.GetOwnershipTransfer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization. | 
 **transferId** | **int?**| Numeric ID of the transfer. | 

### Return type

[**ModelsTransfer**](ModelsTransfer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownershiptransfers"></a>
# **GetOwnershipTransfers**
> List<ModelsTransfer> GetOwnershipTransfers (int? organizationId, string ongoing = null)

Returns list of organization transfers made in the organization

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetOwnershipTransfersExample
    {
        public void main()
        {
            var apiInstance = new OrganizationsOwnerApi();
            var organizationId = 56;  // int? | Numeric ID of the organization.
            var ongoing = ongoing_example;  // string | If true, returns only current, not finished transfer (optional) 

            try
            {
                // Returns list of organization transfers made in the organization
                List&lt;ModelsTransfer&gt; result = apiInstance.GetOwnershipTransfers(organizationId, ongoing);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsOwnerApi.GetOwnershipTransfers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization. | 
 **ongoing** | **string**| If true, returns only current, not finished transfer | [optional] 

### Return type

[**List<ModelsTransfer>**](ModelsTransfer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postownershiptransfer"></a>
# **PostOwnershipTransfer**
> ModelsTransfer PostOwnershipTransfer (int? organizationId)

Creates new ownership transfer process

Return the ownership transfer for a given organization.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostOwnershipTransferExample
    {
        public void main()
        {
            var apiInstance = new OrganizationsOwnerApi();
            var organizationId = 56;  // int? | Numeric ID of the organization.

            try
            {
                // Creates new ownership transfer process
                ModelsTransfer result = apiInstance.PostOwnershipTransfer(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsOwnerApi.PostOwnershipTransfer: " + e.Message );
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

[**ModelsTransfer**](ModelsTransfer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postownershiptransferactions"></a>
# **PostOwnershipTransferActions**
> ModelsTransfer PostOwnershipTransferActions (int? organizationId, int? transferId, string action)

Updates transfer process and emails stakeholders

Return the ownership transfer for a given organization and emails stakeholders.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostOwnershipTransferActionsExample
    {
        public void main()
        {
            var apiInstance = new OrganizationsOwnerApi();
            var organizationId = 56;  // int? | Numeric ID of the organization.
            var transferId = 56;  // int? | Numeric ID of the transfer.
            var action = action_example;  // string | Action to update transfer with.

            try
            {
                // Updates transfer process and emails stakeholders
                ModelsTransfer result = apiInstance.PostOwnershipTransferActions(organizationId, transferId, action);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsOwnerApi.PostOwnershipTransferActions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Numeric ID of the organization. | 
 **transferId** | **int?**| Numeric ID of the transfer. | 
 **action** | **string**| Action to update transfer with. | 

### Return type

[**ModelsTransfer**](ModelsTransfer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

