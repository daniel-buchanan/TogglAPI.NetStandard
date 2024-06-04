# TogglAPI.NetStandard.Api.TagsApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteWorkspaceTag**](TagsApi.md#deleteworkspacetag) | **DELETE** /workspaces/{workspace_id}/tags/{tag_id} | Delete tag
[**GetWorkspaceTag**](TagsApi.md#getworkspacetag) | **GET** /workspaces/{workspace_id}/tags | Tags
[**PatchWorkspaceTags**](TagsApi.md#patchworkspacetags) | **PATCH** /workspaces/{workspace_id}/tags | Bulk delete tags
[**PostWorkspaceTag**](TagsApi.md#postworkspacetag) | **POST** /workspaces/{workspace_id}/tags | Create tag
[**PutWorkspaceTag**](TagsApi.md#putworkspacetag) | **PUT** /workspaces/{workspace_id}/tags/{tag_id} | Update tag


<a name="deleteworkspacetag"></a>
# **DeleteWorkspaceTag**
> string DeleteWorkspaceTag (int? workspaceId, int? tagId)

Delete tag

Delete workspace tags.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class DeleteWorkspaceTagExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TagsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var tagId = 56;  // int? | Numeric ID of the tag

            try
            {
                // Delete tag
                string result = apiInstance.DeleteWorkspaceTag(workspaceId, tagId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.DeleteWorkspaceTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **tagId** | **int?**| Numeric ID of the tag | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacetag"></a>
# **GetWorkspaceTag**
> List<ModelsTag> GetWorkspaceTag (int? workspaceId)

Tags

List Workspace tags.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class GetWorkspaceTagExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TagsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace

            try
            {
                // Tags
                List&lt;ModelsTag&gt; result = apiInstance.GetWorkspaceTag(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.GetWorkspaceTag: " + e.Message );
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

[**List<ModelsTag>**](ModelsTag.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchworkspacetags"></a>
# **PatchWorkspaceTags**
> string PatchWorkspaceTags (int? workspaceId)

Bulk delete tags

Patch will not be executed if there are errors with some records.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PatchWorkspaceTagsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TagsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace

            try
            {
                // Bulk delete tags
                string result = apiInstance.PatchWorkspaceTags(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.PatchWorkspaceTags: " + e.Message );
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

<a name="postworkspacetag"></a>
# **PostWorkspaceTag**
> List<ModelsTag> PostWorkspaceTag (int? workspaceId, TagsPayload tagPost)

Create tag

Create workspace tags.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PostWorkspaceTagExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TagsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var tagPost = new TagsPayload(); // TagsPayload | Post data

            try
            {
                // Create tag
                List&lt;ModelsTag&gt; result = apiInstance.PostWorkspaceTag(workspaceId, tagPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.PostWorkspaceTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **tagPost** | [**TagsPayload**](TagsPayload.md)| Post data | 

### Return type

[**List<ModelsTag>**](ModelsTag.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putworkspacetag"></a>
# **PutWorkspaceTag**
> List<ModelsTag> PutWorkspaceTag (int? workspaceId, int? tagId, TagsPayload tagPost)

Update tag

Update workspace tags.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class PutWorkspaceTagExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TagsApi();
            var workspaceId = 56;  // int? | Numeric ID of the workspace
            var tagId = 56;  // int? | Numeric ID of the tag
            var tagPost = new TagsPayload(); // TagsPayload | Put data

            try
            {
                // Update tag
                List&lt;ModelsTag&gt; result = apiInstance.PutWorkspaceTag(workspaceId, tagId, tagPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.PutWorkspaceTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Numeric ID of the workspace | 
 **tagId** | **int?**| Numeric ID of the tag | 
 **tagPost** | [**TagsPayload**](TagsPayload.md)| Put data | 

### Return type

[**List<ModelsTag>**](ModelsTag.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

