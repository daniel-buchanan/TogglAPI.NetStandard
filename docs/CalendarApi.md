# TogglAPI.NetStandard.Api.CalendarApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IntegrationsCalendarCalendarsSelectedGet**](CalendarApi.md#integrationscalendarcalendarsselectedget) | **GET** /integrations/calendar/calendars/selected | Get all calendars for a given user.
[**IntegrationsCalendarCallbackProviderGet**](CalendarApi.md#integrationscalendarcallbackproviderget) | **GET** /integrations/calendar/callback/{provider} | Callback for provider OAuth setup.
[**IntegrationsCalendarEventsDetailsSuggestionPost**](CalendarApi.md#integrationscalendareventsdetailssuggestionpost) | **POST** /integrations/calendar/events/details-suggestion | Get details suggestion for given events.
[**IntegrationsCalendarEventsEventIdDetailsSuggestionGet**](CalendarApi.md#integrationscalendareventseventiddetailssuggestionget) | **GET** /integrations/calendar/events/{event_id}/details-suggestion | Get details suggestion for a given event.
[**IntegrationsCalendarEventsGet**](CalendarApi.md#integrationscalendareventsget) | **GET** /integrations/calendar/events | Get all events for the caller user.
[**IntegrationsCalendarEventsUpdatePost**](CalendarApi.md#integrationscalendareventsupdatepost) | **POST** /integrations/calendar/events/update | Update all events from selected calendars for a user.
[**IntegrationsCalendarGet**](CalendarApi.md#integrationscalendarget) | **GET** /integrations/calendar | Get all integrations a user has.
[**IntegrationsCalendarIntegrationIdCalendarsCalendarIdPatch**](CalendarApi.md#integrationscalendarintegrationidcalendarscalendaridpatch) | **PATCH** /integrations/calendar/{integration_id}/calendars/{calendar_id} | Sets whether a calendar is or not selected by the user.
[**IntegrationsCalendarIntegrationIdCalendarsGet**](CalendarApi.md#integrationscalendarintegrationidcalendarsget) | **GET** /integrations/calendar/{integration_id}/calendars | Get all calendars for a given integration.
[**IntegrationsCalendarIntegrationIdCalendarsIdCalendarEventsGet**](CalendarApi.md#integrationscalendarintegrationidcalendarsidcalendareventsget) | **GET** /integrations/calendar/{integration_id}/calendars/{id_calendar}/events | (DEPRECATED) Get all events for a given calendar in a given integration.
[**IntegrationsCalendarIntegrationIdCalendarsUpdatePost**](CalendarApi.md#integrationscalendarintegrationidcalendarsupdatepost) | **POST** /integrations/calendar/{integration_id}/calendars/update | Updates calendar data according to provider API.
[**IntegrationsCalendarIntegrationIdDelete**](CalendarApi.md#integrationscalendarintegrationiddelete) | **DELETE** /integrations/calendar/{integration_id} | Delete a given integration.
[**IntegrationsCalendarSetupGet**](CalendarApi.md#integrationscalendarsetupget) | **GET** /integrations/calendar/setup | Get URL for setting up a calendar integration with given provider.


<a name="integrationscalendarcalendarsselectedget"></a>
# **IntegrationsCalendarCalendarsSelectedGet**
> HandlercalendarCalendarsResponse IntegrationsCalendarCalendarsSelectedGet (string limit = null, string pageToken = null, int? integrationId = null, bool? selected = null)

Get all calendars for a given user.

Get all calendars for a given user that was previously saved in the database.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class IntegrationsCalendarCalendarsSelectedGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CalendarApi();
            var limit = limit_example;  // string | Max results per page (optional) 
            var pageToken = pageToken_example;  // string | Token for next page. Used in pagination when the number of results exceed 'limit' (optional) 
            var integrationId = 56;  // int? | Filter calendars by the integration ID (optional) 
            var selected = true;  // bool? | filter calendars by selected value (optional) 

            try
            {
                // Get all calendars for a given user.
                HandlercalendarCalendarsResponse result = apiInstance.IntegrationsCalendarCalendarsSelectedGet(limit, pageToken, integrationId, selected);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarApi.IntegrationsCalendarCalendarsSelectedGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **string**| Max results per page | [optional] 
 **pageToken** | **string**| Token for next page. Used in pagination when the number of results exceed &#39;limit&#39; | [optional] 
 **integrationId** | **int?**| Filter calendars by the integration ID | [optional] 
 **selected** | **bool?**| filter calendars by selected value | [optional] 

### Return type

[**HandlercalendarCalendarsResponse**](HandlercalendarCalendarsResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="integrationscalendarcallbackproviderget"></a>
# **IntegrationsCalendarCallbackProviderGet**
> void IntegrationsCalendarCallbackProviderGet (string provider, string state, string code)

Callback for provider OAuth setup.

Callback endpoint used only by the Calendar Service Provider, which fetches the code

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class IntegrationsCalendarCallbackProviderGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CalendarApi();
            var provider = provider_example;  // string | Calendar service provider
            var state = state_example;  // string | state string to verify user authenticity
            var code = code_example;  // string | Temporary code which will be used to fetch credentials

            try
            {
                // Callback for provider OAuth setup.
                apiInstance.IntegrationsCalendarCallbackProviderGet(provider, state, code);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarApi.IntegrationsCalendarCallbackProviderGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **provider** | **string**| Calendar service provider | 
 **state** | **string**| state string to verify user authenticity | 
 **code** | **string**| Temporary code which will be used to fetch credentials | 

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="integrationscalendareventsdetailssuggestionpost"></a>
# **IntegrationsCalendarEventsDetailsSuggestionPost**
> HandlercalendarPostDetailsSuggestionResponse IntegrationsCalendarEventsDetailsSuggestionPost (HandlercalendarPostDetailsSuggestionRequest request)

Get details suggestion for given events.

Given one or more event IDs, this endpoint responds with the most probable event details (and its accuracy) to assign to the to-be-created time entry for each event ID. This endpoint will only suggests time entries with description and project not empty, because it uses the description to tell if the TE is similar and the project as the main detail to be suggested.  If the description is equal, as well as all the other details, the accuracy will be 100%, in the case the description is equal but the other details differs, the most frequent will be suggested and the accuracy will be given based on the frequency. In the case there is no TE with the same description the most similar will be suggested based on the Jaro-Winkler algorithm, and the accuracy will be the similarity rating.  This endpoint returns status 200 OK with only the successful suggestions. Any event ID that is invalid or the user does not have access to will be ignored, as well as any event that has no available suggestion.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class IntegrationsCalendarEventsDetailsSuggestionPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CalendarApi();
            var request = new HandlercalendarPostDetailsSuggestionRequest(); // HandlercalendarPostDetailsSuggestionRequest | Request body containing the event IDs we want to get the suggestion for

            try
            {
                // Get details suggestion for given events.
                HandlercalendarPostDetailsSuggestionResponse result = apiInstance.IntegrationsCalendarEventsDetailsSuggestionPost(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarApi.IntegrationsCalendarEventsDetailsSuggestionPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**HandlercalendarPostDetailsSuggestionRequest**](HandlercalendarPostDetailsSuggestionRequest.md)| Request body containing the event IDs we want to get the suggestion for | 

### Return type

[**HandlercalendarPostDetailsSuggestionResponse**](HandlercalendarPostDetailsSuggestionResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="integrationscalendareventseventiddetailssuggestionget"></a>
# **IntegrationsCalendarEventsEventIdDetailsSuggestionGet**
> ModelsSuggestion IntegrationsCalendarEventsEventIdDetailsSuggestionGet (int? eventId)

Get details suggestion for a given event.

Given an event ID, this endpoint responds with the most probable event details (and the accuracy) to assign to the to-be-created time entry. This endpoint will only suggests time entries with description and project not empty, because it uses the description to tell if the TE is similar and the project as the main detail to be suggested.  If the description is equal, as well as all the other details, the accuracy will be 100%, in the case the description is equal but the other details differs, the most frequent will be suggested and the accuracy will be given based on the frequency. In the case there is no TE with the same description the most similar will be suggested based on the Jaro-Winkler algorithm, and the accuracy will be the similarity rating.  This endpoint returns status 200 OK and a \"null\" string in case no suggestion was found.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class IntegrationsCalendarEventsEventIdDetailsSuggestionGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CalendarApi();
            var eventId = 56;  // int? | Calendar event ID which we want to get a possible project to match

            try
            {
                // Get details suggestion for a given event.
                ModelsSuggestion result = apiInstance.IntegrationsCalendarEventsEventIdDetailsSuggestionGet(eventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarApi.IntegrationsCalendarEventsEventIdDetailsSuggestionGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventId** | **int?**| Calendar event ID which we want to get a possible project to match | 

### Return type

[**ModelsSuggestion**](ModelsSuggestion.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="integrationscalendareventsget"></a>
# **IntegrationsCalendarEventsGet**
> HandlercalendarEventsResponse IntegrationsCalendarEventsGet (string startDate, string endDate, string limit = null, string pageToken = null)

Get all events for the caller user.

Get all events from selected calendars for the caller user. This endpoint will only return events if events were fetched from provider before the request is made. Check which is the endpoint for the events.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class IntegrationsCalendarEventsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CalendarApi();
            var startDate = startDate_example;  // string | Smallest boundary date to search for calendar events
            var endDate = endDate_example;  // string | Biggest boundary date to search for calendar events
            var limit = limit_example;  // string | Max results per page (optional) 
            var pageToken = pageToken_example;  // string | Token for next page. Used in pagination when the number of results exceed 'limit' (optional) 

            try
            {
                // Get all events for the caller user.
                HandlercalendarEventsResponse result = apiInstance.IntegrationsCalendarEventsGet(startDate, endDate, limit, pageToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarApi.IntegrationsCalendarEventsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **string**| Smallest boundary date to search for calendar events | 
 **endDate** | **string**| Biggest boundary date to search for calendar events | 
 **limit** | **string**| Max results per page | [optional] 
 **pageToken** | **string**| Token for next page. Used in pagination when the number of results exceed &#39;limit&#39; | [optional] 

### Return type

[**HandlercalendarEventsResponse**](HandlercalendarEventsResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="integrationscalendareventsupdatepost"></a>
# **IntegrationsCalendarEventsUpdatePost**
> HandlercalendarResponse IntegrationsCalendarEventsUpdatePost ()

Update all events from selected calendars for a user.

Fetch all events from a user's selected calendars and save in database.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class IntegrationsCalendarEventsUpdatePostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CalendarApi();

            try
            {
                // Update all events from selected calendars for a user.
                HandlercalendarResponse result = apiInstance.IntegrationsCalendarEventsUpdatePost();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarApi.IntegrationsCalendarEventsUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**HandlercalendarResponse**](HandlercalendarResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="integrationscalendarget"></a>
# **IntegrationsCalendarGet**
> List<ModelsIntegration> IntegrationsCalendarGet ()

Get all integrations a user has.

Get all integrations a user has. Each user may have at most one integration per provider.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class IntegrationsCalendarGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CalendarApi();

            try
            {
                // Get all integrations a user has.
                List&lt;ModelsIntegration&gt; result = apiInstance.IntegrationsCalendarGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarApi.IntegrationsCalendarGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ModelsIntegration>**](ModelsIntegration.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="integrationscalendarintegrationidcalendarscalendaridpatch"></a>
# **IntegrationsCalendarIntegrationIdCalendarsCalendarIdPatch**
> List<ModelsCalendar> IntegrationsCalendarIntegrationIdCalendarsCalendarIdPatch (int? integrationId, int? calendarId, HandlercalendarPatchCalendar payload = null)

Sets whether a calendar is or not selected by the user.

This endpoint is used to set updatable fields of a calendar like selected field.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class IntegrationsCalendarIntegrationIdCalendarsCalendarIdPatchExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CalendarApi();
            var integrationId = 56;  // int? | Integration ID as saved in the database
            var calendarId = 56;  // int? | Calendar ID as saved in the database
            var payload = new HandlercalendarPatchCalendar(); // HandlercalendarPatchCalendar | Calendar fields to be updated (optional) 

            try
            {
                // Sets whether a calendar is or not selected by the user.
                List&lt;ModelsCalendar&gt; result = apiInstance.IntegrationsCalendarIntegrationIdCalendarsCalendarIdPatch(integrationId, calendarId, payload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarApi.IntegrationsCalendarIntegrationIdCalendarsCalendarIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **integrationId** | **int?**| Integration ID as saved in the database | 
 **calendarId** | **int?**| Calendar ID as saved in the database | 
 **payload** | [**HandlercalendarPatchCalendar**](HandlercalendarPatchCalendar.md)| Calendar fields to be updated | [optional] 

### Return type

[**List<ModelsCalendar>**](ModelsCalendar.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="integrationscalendarintegrationidcalendarsget"></a>
# **IntegrationsCalendarIntegrationIdCalendarsGet**
> HandlercalendarCalendarsResponse IntegrationsCalendarIntegrationIdCalendarsGet (int? integrationId, int? limit = null, bool? selected = null, string pageToken = null)

Get all calendars for a given integration.

Get all calendars for a given integration that was previously saved in the database.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class IntegrationsCalendarIntegrationIdCalendarsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CalendarApi();
            var integrationId = 56;  // int? | Integration ID as saved in the database
            var limit = 56;  // int? | Max results per page (optional) 
            var selected = true;  // bool? | if we should get the selected or not calendars, or all calendars, in case of omission (optional) 
            var pageToken = pageToken_example;  // string | Token for next page. Used in pagination when the number of results exceed 'limit' (optional) 

            try
            {
                // Get all calendars for a given integration.
                HandlercalendarCalendarsResponse result = apiInstance.IntegrationsCalendarIntegrationIdCalendarsGet(integrationId, limit, selected, pageToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarApi.IntegrationsCalendarIntegrationIdCalendarsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **integrationId** | **int?**| Integration ID as saved in the database | 
 **limit** | **int?**| Max results per page | [optional] 
 **selected** | **bool?**| if we should get the selected or not calendars, or all calendars, in case of omission | [optional] 
 **pageToken** | **string**| Token for next page. Used in pagination when the number of results exceed &#39;limit&#39; | [optional] 

### Return type

[**HandlercalendarCalendarsResponse**](HandlercalendarCalendarsResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="integrationscalendarintegrationidcalendarsidcalendareventsget"></a>
# **IntegrationsCalendarIntegrationIdCalendarsIdCalendarEventsGet**
> HandlercalendarEventsResponse IntegrationsCalendarIntegrationIdCalendarsIdCalendarEventsGet (int? integrationId, string idCalendar, string startDate, string endDate, string limit = null, string pageToken = null)

(DEPRECATED) Get all events for a given calendar in a given integration.

Get all events for a given calendar in a given integration.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class IntegrationsCalendarIntegrationIdCalendarsIdCalendarEventsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CalendarApi();
            var integrationId = 56;  // int? | Integration ID as saved in the database
            var idCalendar = idCalendar_example;  // string | Calendar ID as returned by the provider, it may be an e-mail address, for instance
            var startDate = startDate_example;  // string | Smallest boundary date to search for calendar events
            var endDate = endDate_example;  // string | Biggest boundary date to search for calendar events
            var limit = limit_example;  // string | Max results per page (optional) 
            var pageToken = pageToken_example;  // string | Token for next page. Used in pagination when the number of results exceed 'limit' (optional) 

            try
            {
                // (DEPRECATED) Get all events for a given calendar in a given integration.
                HandlercalendarEventsResponse result = apiInstance.IntegrationsCalendarIntegrationIdCalendarsIdCalendarEventsGet(integrationId, idCalendar, startDate, endDate, limit, pageToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarApi.IntegrationsCalendarIntegrationIdCalendarsIdCalendarEventsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **integrationId** | **int?**| Integration ID as saved in the database | 
 **idCalendar** | **string**| Calendar ID as returned by the provider, it may be an e-mail address, for instance | 
 **startDate** | **string**| Smallest boundary date to search for calendar events | 
 **endDate** | **string**| Biggest boundary date to search for calendar events | 
 **limit** | **string**| Max results per page | [optional] 
 **pageToken** | **string**| Token for next page. Used in pagination when the number of results exceed &#39;limit&#39; | [optional] 

### Return type

[**HandlercalendarEventsResponse**](HandlercalendarEventsResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="integrationscalendarintegrationidcalendarsupdatepost"></a>
# **IntegrationsCalendarIntegrationIdCalendarsUpdatePost**
> HandlercalendarFetchedCalendarsResponse IntegrationsCalendarIntegrationIdCalendarsUpdatePost (int? integrationId)

Updates calendar data according to provider API.

This endpoint uses the passed integration to get a provider and update all the calendars from that

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class IntegrationsCalendarIntegrationIdCalendarsUpdatePostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CalendarApi();
            var integrationId = 56;  // int? | Integration ID as saved in the database

            try
            {
                // Updates calendar data according to provider API.
                HandlercalendarFetchedCalendarsResponse result = apiInstance.IntegrationsCalendarIntegrationIdCalendarsUpdatePost(integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarApi.IntegrationsCalendarIntegrationIdCalendarsUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **integrationId** | **int?**| Integration ID as saved in the database | 

### Return type

[**HandlercalendarFetchedCalendarsResponse**](HandlercalendarFetchedCalendarsResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="integrationscalendarintegrationiddelete"></a>
# **IntegrationsCalendarIntegrationIdDelete**
> string IntegrationsCalendarIntegrationIdDelete (int? integrationId)

Delete a given integration.

Executes logic deletion of an integration.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class IntegrationsCalendarIntegrationIdDeleteExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CalendarApi();
            var integrationId = 56;  // int? | Integration ID as saved in the database

            try
            {
                // Delete a given integration.
                string result = apiInstance.IntegrationsCalendarIntegrationIdDelete(integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarApi.IntegrationsCalendarIntegrationIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **integrationId** | **int?**| Integration ID as saved in the database | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="integrationscalendarsetupget"></a>
# **IntegrationsCalendarSetupGet**
> void IntegrationsCalendarSetupGet (string provider, string returnTo = null)

Get URL for setting up a calendar integration with given provider.

Set up an integration with a given provider, returning a URL to the said provider in order to

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class IntegrationsCalendarSetupGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CalendarApi();
            var provider = provider_example;  // string | Calendar service provider which the calendars will be retrieved
            var returnTo = returnTo_example;  // string | Page to which the user will be redirected after authenticating (optional) 

            try
            {
                // Get URL for setting up a calendar integration with given provider.
                apiInstance.IntegrationsCalendarSetupGet(provider, returnTo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarApi.IntegrationsCalendarSetupGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **provider** | **string**| Calendar service provider which the calendars will be retrieved | 
 **returnTo** | **string**| Page to which the user will be redirected after authenticating | [optional] 

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

