# TogglAPI.NetStandard.Api.FavoritesApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateFavorite**](FavoritesApi.md#createfavorite) | **POST** /me/favorites | Create a favorite
[**DeleteFavorite**](FavoritesApi.md#deletefavorite) | **DELETE** /me/favorites/{favorite_id} | Deletes a given favorite
[**GetFavorites**](FavoritesApi.md#getfavorites) | **GET** /me/favorites | Get a list of favorites
[**PostFavoritesSuggestions**](FavoritesApi.md#postfavoritessuggestions) | **POST** /me/favorites/suggestions | Generates and returns a list of suggested favorites.
[**UpdateFavorite**](FavoritesApi.md#updatefavorite) | **PUT** /me/favorites | Update an array of favorites


<a name="createfavorite"></a>
# **CreateFavorite**
> ModelsFavorite CreateFavorite (HandlerfavoritesPayload favorite, bool? meta = null)

Create a favorite

This endpoint allows the creation of a favorite given some parameters. The workspace is required, as well as either description or project (no favorite without both will be accepted). The user is also required, but it already goes in the authentication. Also, the user must have access to all resources being referenced in the favorite attributes, and these resources should have valid relationships. For instance, if you want a favorite in a given workspace and with some tags, the tags must belong to that workspace. In case of user having no access to an attribute, a 403 status is returned, if the attributes don't relate correctly between themselves the status returned will be 400.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class CreateFavoriteExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FavoritesApi();
            var favorite = new HandlerfavoritesPayload(); // HandlerfavoritesPayload | Favorite details
            var meta = true;  // bool? | Should the response contain data for meta entities (optional) 

            try
            {
                // Create a favorite
                ModelsFavorite result = apiInstance.CreateFavorite(favorite, meta);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FavoritesApi.CreateFavorite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **favorite** | [**HandlerfavoritesPayload**](HandlerfavoritesPayload.md)| Favorite details | 
 **meta** | **bool?**| Should the response contain data for meta entities | [optional] 

### Return type

[**ModelsFavorite**](ModelsFavorite.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefavorite"></a>
# **DeleteFavorite**
> void DeleteFavorite ()

Deletes a given favorite

Deletes a given favorite logically from database, as well as its tags.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteFavoriteExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FavoritesApi();

            try
            {
                // Deletes a given favorite
                apiInstance.DeleteFavorite();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FavoritesApi.DeleteFavorite: " + e.Message );
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

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfavorites"></a>
# **GetFavorites**
> List<ModelsFavorite> GetFavorites (int? since = null)

Get a list of favorites

Gets all favorites for the requesting user

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetFavoritesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FavoritesApi();
            var since = 56;  // int? | Retrieve favorites created/deleted since this date using UNIX timestamp. (optional) 

            try
            {
                // Get a list of favorites
                List&lt;ModelsFavorite&gt; result = apiInstance.GetFavorites(since);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FavoritesApi.GetFavorites: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **since** | **int?**| Retrieve favorites created/deleted since this date using UNIX timestamp. | [optional] 

### Return type

[**List<ModelsFavorite>**](ModelsFavorite.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfavoritessuggestions"></a>
# **PostFavoritesSuggestions**
> List<ModelsFavorite> PostFavoritesSuggestions ()

Generates and returns a list of suggested favorites.

It will create 3 favorites based on past user's TE activity and return them. Suggested favorites will be created only once for a given user, and only if the user has never created a favorite before (either manually or by a previous suggestion request). If there is no past TE data there won't be suggested favorites either.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostFavoritesSuggestionsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FavoritesApi();

            try
            {
                // Generates and returns a list of suggested favorites.
                List&lt;ModelsFavorite&gt; result = apiInstance.PostFavoritesSuggestions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FavoritesApi.PostFavoritesSuggestions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ModelsFavorite>**](ModelsFavorite.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefavorite"></a>
# **UpdateFavorite**
> ModelsFavorite UpdateFavorite (HandlerfavoritesPayload favorite, bool? meta = null)

Update an array of favorites

This endpoint allows updating an array of favorites. It follow all the requirements and behavior from the [post] (Create Favorite) counterpart.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class UpdateFavoriteExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FavoritesApi();
            var favorite = new HandlerfavoritesPayload(); // HandlerfavoritesPayload | Favorite details
            var meta = true;  // bool? | Should the response contain data for meta entities (optional) 

            try
            {
                // Update an array of favorites
                ModelsFavorite result = apiInstance.UpdateFavorite(favorite, meta);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FavoritesApi.UpdateFavorite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **favorite** | [**HandlerfavoritesPayload**](HandlerfavoritesPayload.md)| Favorite details | 
 **meta** | **bool?**| Should the response contain data for meta entities | [optional] 

### Return type

[**ModelsFavorite**](ModelsFavorite.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

