# TogglAPI.NetStandard.Model.SubscriptionOutData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoRenew** | **bool?** |  | [optional] 
**BillingPeriodInMonths** | **int?** |  | [optional] 
**CampaignAvailable** | **bool?** |  | [optional] 
**CancelDate** | **string** |  | [optional] 
**CardDetails** | [**ModelsCardDetails**](ModelsCardDetails.md) |  | [optional] 
**CompanyId** | **int?** |  | [optional] 
**ContactDetails** | [**ModelsContactDetail**](ModelsContactDetail.md) |  | [optional] 
**Currency** | **string** |  | [optional] 
**CurrentPeriodEndsAt** | **string** |  | [optional] 
**CurrentPeriodStartsAt** | **string** |  | [optional] 
**CustomerId** | **int?** |  | [optional] 
**EndDate** | **string** | Deprecated: this field will be replaced by CurrentPeriodEndsAt | [optional] 
**Enterprise** | **bool?** |  | [optional] 
**IsSubscriptionBeta** | **bool?** | temporary flag which is true iff there is at least one admin in the organization, who has the &#x60;multi_workspace_payments&#x60; beta flag enabled | [optional] 
**IsUnified** | **bool?** |  | [optional] 
**LastInvoice** | [**SubscriptionInvoiceInfo**](SubscriptionInvoiceInfo.md) |  | [optional] 
**LastPayment** | [**ModelsPaymentInfo**](ModelsPaymentInfo.md) |  | [optional] 
**LastPricingPlanId** | **int?** |  | [optional] 
**NewSignupTrial** | **bool?** |  | [optional] 
**NextPaymentDate** | **string** |  | [optional] 
**PaymentMethod** | **string** |  | [optional] 
**PlanName** | **string** |  | [optional] 
**PricingPlanId** | **int?** | Legacy fields (kept for compatibility with FE) | [optional] 
**RenewalAt** | **string** |  | [optional] 
**RenewalDate** | **string** |  | [optional] 
**SeatCostInCents** | **int?** |  | [optional] 
**Seats** | **int?** |  | [optional] 
**Site** | **string** |  | [optional] 
**StartDate** | **string** | Deprecated: this field will be replaced by CurrentPeriodStartsAt | [optional] 
**State** | **string** |  | [optional] 
**SubscriptionCreatedAt** | **string** |  | [optional] 
**SubscriptionPeriod** | [**ModelsPeriod**](ModelsPeriod.md) |  | [optional] 
**TrialAvailable** | **bool?** |  | [optional] 
**TrialEndDate** | **string** |  | [optional] 
**TrialStartDate** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

