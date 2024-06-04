# TogglAPI.NetStandard.Api.MeApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePushServices**](MeApi.md#deletepushservices) | **DELETE** /me/push_services | PushServices
[**GetClients**](MeApi.md#getclients) | **GET** /me/clients | Clients
[**GetLostPassword**](MeApi.md#getlostpassword) | **GET** /me/lost_passwords | LostPassword
[**GetMe**](MeApi.md#getme) | **GET** /me | Me
[**GetMeFeatures**](MeApi.md#getmefeatures) | **GET** /me/features | Features
[**GetMeFlags**](MeApi.md#getmeflags) | **GET** /me/flags | Flags
[**GetMeLocation**](MeApi.md#getmelocation) | **GET** /me/location | User&#39;s last known location
[**GetMeNotifications**](MeApi.md#getmenotifications) | **GET** /me/notifications | Notifications
[**GetMeProjects**](MeApi.md#getmeprojects) | **GET** /me/projects | Projects
[**GetMeProjectsPaginated**](MeApi.md#getmeprojectspaginated) | **GET** /me/projects/paginated | ProjectsPaginated
[**GetMeTimesheets**](MeApi.md#getmetimesheets) | **GET** /me/timesheets | User&#39;s Timesheets
[**GetMeTrackReminders**](MeApi.md#getmetrackreminders) | **GET** /me/track_reminders | TrackReminders
[**GetOrganizations**](MeApi.md#getorganizations) | **GET** /me/organizations | Organizations that a user is part of
[**GetPushServices**](MeApi.md#getpushservices) | **GET** /me/push_services | PushServices
[**GetTags**](MeApi.md#gettags) | **GET** /me/tags | Tags
[**GetTasks**](MeApi.md#gettasks) | **GET** /me/tasks | Tasks
[**GetWebTimer**](MeApi.md#getwebtimer) | **GET** /me/web-timer | WebTimer
[**GetWorkspaces**](MeApi.md#getworkspaces) | **GET** /me/workspaces | Workspaces
[**MeLoggedGet**](MeApi.md#meloggedget) | **GET** /me/logged | Logged
[**PostCloseAccount**](MeApi.md#postcloseaccount) | **POST** /me/close_account | CloseAccount
[**PostLostPassword**](MeApi.md#postlostpassword) | **POST** /me/lost_passwords | LostPassword
[**PostLostPasswordConfirm**](MeApi.md#postlostpasswordconfirm) | **POST** /me/lost_passwords/confirm | LostPassword conformation
[**PostMeAcceptTos**](MeApi.md#postmeaccepttos) | **POST** /me/accept_tos | AcceptTOS
[**PostMeDisableProductEmails**](MeApi.md#postmedisableproductemails) | **POST** /me/disable_product_emails/{disable_code} | Disable product emails
[**PostMeDisableWeeklyReport**](MeApi.md#postmedisableweeklyreport) | **POST** /me/disable_weekly_report/{weekly_report_code} | Disable weekly report
[**PostMeFlags**](MeApi.md#postmeflags) | **POST** /me/flags | Flags
[**PostPushServices**](MeApi.md#postpushservices) | **POST** /me/push_services | PushServices
[**PutMe**](MeApi.md#putme) | **PUT** /me | Me
[**PutNotifications**](MeApi.md#putnotifications) | **POST** /me/notifications/{notification_id}/seen | Notifications


<a name="deletepushservices"></a>
# **DeletePushServices**
> string DeletePushServices (PushDeletePushServicesUnsubscribe deletePushServicesUnsubscribe)

PushServices

Unregister Firebase token for current user

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeletePushServicesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MeApi();
            var deletePushServicesUnsubscribe = new PushDeletePushServicesUnsubscribe(); // PushDeletePushServicesUnsubscribe | FirebaseToken

            try
            {
                // PushServices
                string result = apiInstance.DeletePushServices(deletePushServicesUnsubscribe);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.DeletePushServices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deletePushServicesUnsubscribe** | [**PushDeletePushServicesUnsubscribe**](PushDeletePushServicesUnsubscribe.md)| FirebaseToken | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclients"></a>
# **GetClients**
> List<ModelsClient> GetClients (int? since = null)

Clients

Get Clients.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetClientsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MeApi();
            var since = 56;  // int? | Retrieve clients created/modified/deleted since this date using UNIX timestamp. (optional) 

            try
            {
                // Clients
                List&lt;ModelsClient&gt; result = apiInstance.GetClients(since);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.GetClients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **since** | **int?**| Retrieve clients created/modified/deleted since this date using UNIX timestamp. | [optional] 

### Return type

[**List<ModelsClient>**](ModelsClient.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlostpassword"></a>
# **GetLostPassword**
> string GetLostPassword (string tokenCode)

LostPassword

Verifies the user request to reset the password.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetLostPasswordExample
    {
        public void main()
        {
            var apiInstance = new MeApi();
            var tokenCode = tokenCode_example;  // string | Token code

            try
            {
                // LostPassword
                string result = apiInstance.GetLostPassword(tokenCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.GetLostPassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenCode** | **string**| Token code | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getme"></a>
# **GetMe**
> RelatedUserWithRelated GetMe (bool? withRelatedData = null)

Me

Returns details for the current user.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetMeExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MeApi();
            var withRelatedData = true;  // bool? | Retrieve user related data (clients, projects, tasks, tags, workspaces, time entries, etc.) (optional) 

            try
            {
                // Me
                RelatedUserWithRelated result = apiInstance.GetMe(withRelatedData);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.GetMe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **withRelatedData** | **bool?**| Retrieve user related data (clients, projects, tasks, tags, workspaces, time entries, etc.) | [optional] 

### Return type

[**RelatedUserWithRelated**](RelatedUserWithRelated.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmefeatures"></a>
# **GetMeFeatures**
> List<MeWorkspace> GetMeFeatures ()

Features

Get features.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetMeFeaturesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MeApi();

            try
            {
                // Features
                List&lt;MeWorkspace&gt; result = apiInstance.GetMeFeatures();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.GetMeFeatures: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<MeWorkspace>**](MeWorkspace.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmeflags"></a>
# **GetMeFlags**
> UserFlags GetMeFlags ()

Flags

Returns flags for the current user. They will be represented by an object with dynamic string keys, where the value can be of any type.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetMeFlagsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MeApi();

            try
            {
                // Flags
                UserFlags result = apiInstance.GetMeFlags();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.GetMeFlags: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserFlags**](UserFlags.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmelocation"></a>
# **GetMeLocation**
> MeUserLocationResponse GetMeLocation ()

User's last known location

Returns the client's IP-based location. If no data is present, empty response will be yielded.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetMeLocationExample
    {
        public void main()
        {
            var apiInstance = new MeApi();

            try
            {
                // User's last known location
                MeUserLocationResponse result = apiInstance.GetMeLocation();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.GetMeLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**MeUserLocationResponse**](MeUserLocationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenotifications"></a>
# **GetMeNotifications**
> List<ModelsUserNotification> GetMeNotifications ()

Notifications

Get notifications.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetMeNotificationsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MeApi();

            try
            {
                // Notifications
                List&lt;ModelsUserNotification&gt; result = apiInstance.GetMeNotifications();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.GetMeNotifications: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ModelsUserNotification>**](ModelsUserNotification.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmeprojects"></a>
# **GetMeProjects**
> List<ModelsProject> GetMeProjects (string includeArchived = null, int? since = null)

Projects

Get projects

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetMeProjectsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MeApi();
            var includeArchived = includeArchived_example;  // string | Include archived projects. (optional) 
            var since = 56;  // int? | Retrieve projects modified since this date using UNIX timestamp, including deleted ones. (optional) 

            try
            {
                // Projects
                List&lt;ModelsProject&gt; result = apiInstance.GetMeProjects(includeArchived, since);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.GetMeProjects: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includeArchived** | **string**| Include archived projects. | [optional] 
 **since** | **int?**| Retrieve projects modified since this date using UNIX timestamp, including deleted ones. | [optional] 

### Return type

[**List<ModelsProject>**](ModelsProject.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmeprojectspaginated"></a>
# **GetMeProjectsPaginated**
> List<ModelsProject> GetMeProjectsPaginated (int? startProjectId = null, int? since = null, int? perPage = null)

ProjectsPaginated

Get paginated projects.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetMeProjectsPaginatedExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MeApi();
            var startProjectId = 56;  // int? | Project ID to resume the next pagination from. (optional) 
            var since = 56;  // int? | Retrieve projects created/modified/deleted since this date using UNIX timestamp. (optional) 
            var perPage = 56;  // int? | Number of items per page, default 201. (optional) 

            try
            {
                // ProjectsPaginated
                List&lt;ModelsProject&gt; result = apiInstance.GetMeProjectsPaginated(startProjectId, since, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.GetMeProjectsPaginated: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startProjectId** | **int?**| Project ID to resume the next pagination from. | [optional] 
 **since** | **int?**| Retrieve projects created/modified/deleted since this date using UNIX timestamp. | [optional] 
 **perPage** | **int?**| Number of items per page, default 201. | [optional] 

### Return type

[**List<ModelsProject>**](ModelsProject.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmetimesheets"></a>
# **GetMeTimesheets**
> List<ModelsTimesheet> GetMeTimesheets ()

User's Timesheets

Returns the timehseets for the current user.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetMeTimesheetsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MeApi();

            try
            {
                // User's Timesheets
                List&lt;ModelsTimesheet&gt; result = apiInstance.GetMeTimesheets();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.GetMeTimesheets: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ModelsTimesheet>**](ModelsTimesheet.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmetrackreminders"></a>
# **GetMeTrackReminders**
> List<ModelsTrackReminder> GetMeTrackReminders ()

TrackReminders

Returns a list of track reminders.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetMeTrackRemindersExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MeApi();

            try
            {
                // TrackReminders
                List&lt;ModelsTrackReminder&gt; result = apiInstance.GetMeTrackReminders();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.GetMeTrackReminders: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ModelsTrackReminder>**](ModelsTrackReminder.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizations"></a>
# **GetOrganizations**
> List<ModelsMeOrganization> GetOrganizations ()

Organizations that a user is part of

Get all organizations a given user is part of.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetOrganizationsExample
    {
        public void main()
        {
            var apiInstance = new MeApi();

            try
            {
                // Organizations that a user is part of
                List&lt;ModelsMeOrganization&gt; result = apiInstance.GetOrganizations();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.GetOrganizations: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ModelsMeOrganization>**](ModelsMeOrganization.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpushservices"></a>
# **GetPushServices**
> List<string> GetPushServices ()

PushServices

Get list of firebase tokens registered for current user.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetPushServicesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MeApi();

            try
            {
                // PushServices
                List&lt;string&gt; result = apiInstance.GetPushServices();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.GetPushServices: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettags"></a>
# **GetTags**
> List<ModelsTag> GetTags (int? since = null)

Tags

Returns tags for the current user.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetTagsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MeApi();
            var since = 56;  // int? | Retrieve tags modified/deleted since this date using UNIX timestamp. (optional) 

            try
            {
                // Tags
                List&lt;ModelsTag&gt; result = apiInstance.GetTags(since);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.GetTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **since** | **int?**| Retrieve tags modified/deleted since this date using UNIX timestamp. | [optional] 

### Return type

[**List<ModelsTag>**](ModelsTag.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettasks"></a>
# **GetTasks**
> List<ModelsTask> GetTasks (int? since = null, string includeNotActive = null, bool? meta = null)

Tasks

Returns tasks from projects in which the user is participating.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetTasksExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MeApi();
            var since = 56;  // int? | Retrieve tasks created/modified/deleted since this date using UNIX timestamp. (optional) 
            var includeNotActive = includeNotActive_example;  // string | Include tasks marked as done. (optional) 
            var meta = true;  // bool? | Should the response contain data for meta entities (optional) 

            try
            {
                // Tasks
                List&lt;ModelsTask&gt; result = apiInstance.GetTasks(since, includeNotActive, meta);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.GetTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **since** | **int?**| Retrieve tasks created/modified/deleted since this date using UNIX timestamp. | [optional] 
 **includeNotActive** | **string**| Include tasks marked as done. | [optional] 
 **meta** | **bool?**| Should the response contain data for meta entities | [optional] 

### Return type

[**List<ModelsTask>**](ModelsTask.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebtimer"></a>
# **GetWebTimer**
> string GetWebTimer ()

WebTimer

Get web timer.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWebTimerExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MeApi();

            try
            {
                // WebTimer
                string result = apiInstance.GetWebTimer();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.GetWebTimer: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspaces"></a>
# **GetWorkspaces**
> List<WorkspaceWithActiveProjectCount> GetWorkspaces (int? since = null)

Workspaces

Lists workspaces for given user.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspacesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MeApi();
            var since = 56;  // int? | Retrieve workspaces created/modified/deleted since this date using UNIX timestamp, including the dates a workspace member got added, removed or updated in the workspace. (optional) 

            try
            {
                // Workspaces
                List&lt;WorkspaceWithActiveProjectCount&gt; result = apiInstance.GetWorkspaces(since);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.GetWorkspaces: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **since** | **int?**| Retrieve workspaces created/modified/deleted since this date using UNIX timestamp, including the dates a workspace member got added, removed or updated in the workspace. | [optional] 

### Return type

[**List<WorkspaceWithActiveProjectCount>**](WorkspaceWithActiveProjectCount.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="meloggedget"></a>
# **MeLoggedGet**
> void MeLoggedGet ()

Logged

Used to check if authentication works.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class MeLoggedGetExample
    {
        public void main()
        {
            var apiInstance = new MeApi();

            try
            {
                // Logged
                apiInstance.MeLoggedGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.MeLoggedGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcloseaccount"></a>
# **PostCloseAccount**
> string PostCloseAccount ()

CloseAccount

Close Account

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostCloseAccountExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MeApi();

            try
            {
                // CloseAccount
                string result = apiInstance.PostCloseAccount();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.PostCloseAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postlostpassword"></a>
# **PostLostPassword**
> string PostLostPassword (ModelsLostPassword postLostPassword)

LostPassword

Handles the users request to reset the password.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostLostPasswordExample
    {
        public void main()
        {
            var apiInstance = new MeApi();
            var postLostPassword = new ModelsLostPassword(); // ModelsLostPassword | Lost Password Parameters

            try
            {
                // LostPassword
                string result = apiInstance.PostLostPassword(postLostPassword);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.PostLostPassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postLostPassword** | [**ModelsLostPassword**](ModelsLostPassword.md)| Lost Password Parameters | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postlostpasswordconfirm"></a>
# **PostLostPasswordConfirm**
> string PostLostPasswordConfirm (MeLostPasswordPayload postNewPassword)

LostPassword conformation

Handles lost password request confirmation.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostLostPasswordConfirmExample
    {
        public void main()
        {
            var apiInstance = new MeApi();
            var postNewPassword = new MeLostPasswordPayload(); // MeLostPasswordPayload | New Password Data

            try
            {
                // LostPassword conformation
                string result = apiInstance.PostLostPasswordConfirm(postNewPassword);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.PostLostPasswordConfirm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postNewPassword** | [**MeLostPasswordPayload**](MeLostPasswordPayload.md)| New Password Data | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postmeaccepttos"></a>
# **PostMeAcceptTos**
> string PostMeAcceptTos ()

AcceptTOS

Accepts the last version of the Terms of Service for the current user.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostMeAcceptTosExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MeApi();

            try
            {
                // AcceptTOS
                string result = apiInstance.PostMeAcceptTos();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.PostMeAcceptTos: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postmedisableproductemails"></a>
# **PostMeDisableProductEmails**
> string PostMeDisableProductEmails (string disableCode)

Disable product emails

Disable product emails.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostMeDisableProductEmailsExample
    {
        public void main()
        {
            var apiInstance = new MeApi();
            var disableCode = disableCode_example;  // string | Disable Code

            try
            {
                // Disable product emails
                string result = apiInstance.PostMeDisableProductEmails(disableCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.PostMeDisableProductEmails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **disableCode** | **string**| Disable Code | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postmedisableweeklyreport"></a>
# **PostMeDisableWeeklyReport**
> string PostMeDisableWeeklyReport (string weeklyReportCode)

Disable weekly report

Disable weekly report.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostMeDisableWeeklyReportExample
    {
        public void main()
        {
            var apiInstance = new MeApi();
            var weeklyReportCode = weeklyReportCode_example;  // string | Weekly report code

            try
            {
                // Disable weekly report
                string result = apiInstance.PostMeDisableWeeklyReport(weeklyReportCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.PostMeDisableWeeklyReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **weeklyReportCode** | **string**| Weekly report code | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postmeflags"></a>
# **PostMeFlags**
> UserFlags PostMeFlags (UserFlags postFlags)

Flags

Add flags for the current user. The current limits are 4 flags per request, 128 flags in total. Keys and values can be up to 32 and 64 characters, respectively.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostMeFlagsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MeApi();
            var postFlags = new UserFlags(); // UserFlags | flags

            try
            {
                // Flags
                UserFlags result = apiInstance.PostMeFlags(postFlags);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.PostMeFlags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postFlags** | [**UserFlags**](UserFlags.md)| flags | 

### Return type

[**UserFlags**](UserFlags.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpushservices"></a>
# **PostPushServices**
> string PostPushServices (PushPostPushServicesSubscribe postPushServicesSubscribe)

PushServices

Register Firebase token for current user

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostPushServicesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MeApi();
            var postPushServicesSubscribe = new PushPostPushServicesSubscribe(); // PushPostPushServicesSubscribe | FirebaseToken

            try
            {
                // PushServices
                string result = apiInstance.PostPushServices(postPushServicesSubscribe);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.PostPushServices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postPushServicesSubscribe** | [**PushPostPushServicesSubscribe**](PushPostPushServicesSubscribe.md)| FirebaseToken | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putme"></a>
# **PutMe**
> ModelsTogglUser PutMe (MePayload payload)

Me

Updates details for the current user.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutMeExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MeApi();
            var payload = new MePayload(); // MePayload | Update user parameters

            try
            {
                // Me
                ModelsTogglUser result = apiInstance.PutMe(payload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.PutMe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payload** | [**MePayload**](MePayload.md)| Update user parameters | 

### Return type

[**ModelsTogglUser**](ModelsTogglUser.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putnotifications"></a>
# **PutNotifications**
> string PutNotifications (int? notificationId)

Notifications

Mark notification seen.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutNotificationsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MeApi();
            var notificationId = 56;  // int? | Notification ID.

            try
            {
                // Notifications
                string result = apiInstance.PutNotifications(notificationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.PutNotifications: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notificationId** | **int?**| Notification ID. | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

