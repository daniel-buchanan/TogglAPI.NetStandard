# TogglAPI.NetStandard.Model.SubscriptionContactDetailRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompanyAddress** | **string** |  | 
**CompanyCity** | **string** |  | [optional] 
**CompanyName** | **string** |  | 
**ContactEmail** | **string** |  | 
**ContactPerson** | **string** |  | [optional] 
**CountryId** | **int?** |  | 
**CountrySubdivisionId** | **int?** | CountrySubdivisionID is the ID of the country subdivision (state in USA) This field is required if country_id &#x3D;&#x3D; 235 (United states) | [optional] 
**SubDivision** | [**ModelsSubdivision**](ModelsSubdivision.md) |  | [optional] 
**TaxNumber** | **string** |  | [optional] 
**ZipCode** | **string** | ZIPCode field is required if country_id &#x3D;&#x3D; 235 (United states) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

