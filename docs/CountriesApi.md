# TogglAPI.NetStandard.Api.CountriesApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCountries**](CountriesApi.md#getcountries) | **GET** /countries | Countries
[**GetCountriesCountryIdSubdivisions**](CountriesApi.md#getcountriescountryidsubdivisions) | **GET** /countries/{country_id}/subdivisions | CountrySubdivisions


<a name="getcountries"></a>
# **GetCountries**
> List<ModelsCountry> GetCountries ()

Countries

Returns a list of existing countries

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetCountriesExample
    {
        public void main()
        {
            var apiInstance = new CountriesApi();

            try
            {
                // Countries
                List&lt;ModelsCountry&gt; result = apiInstance.GetCountries();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CountriesApi.GetCountries: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ModelsCountry>**](ModelsCountry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcountriescountryidsubdivisions"></a>
# **GetCountriesCountryIdSubdivisions**
> List<ModelsSubdivision> GetCountriesCountryIdSubdivisions (int? countryId)

CountrySubdivisions

Returns a list of subdivisions for a specific country.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetCountriesCountryIdSubdivisionsExample
    {
        public void main()
        {
            var apiInstance = new CountriesApi();
            var countryId = 56;  // int? | country id

            try
            {
                // CountrySubdivisions
                List&lt;ModelsSubdivision&gt; result = apiInstance.GetCountriesCountryIdSubdivisions(countryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CountriesApi.GetCountriesCountryIdSubdivisions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryId** | **int?**| country id | 

### Return type

[**List<ModelsSubdivision>**](ModelsSubdivision.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

