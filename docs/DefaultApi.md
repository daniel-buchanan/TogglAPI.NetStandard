# TogglAPI.NetStandard.Api.DefaultApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReportsApiV3WorkspaceWorkspaceIdComparativePost**](DefaultApi.md#reportsapiv3workspaceworkspaceidcomparativepost) | **POST** /reports/api/v3/workspace/{workspace_id}/comparative | Load comparative report
[**ReportsApiV3WorkspaceWorkspaceIdDataTrendsClientsPost**](DefaultApi.md#reportsapiv3workspaceworkspaceiddatatrendsclientspost) | **POST** /reports/api/v3/workspace/{workspace_id}/data_trends/clients | Load clients&#39; data trends
[**ReportsApiV3WorkspaceWorkspaceIdDataTrendsProjectsPost**](DefaultApi.md#reportsapiv3workspaceworkspaceiddatatrendsprojectspost) | **POST** /reports/api/v3/workspace/{workspace_id}/data_trends/projects | Load projects&#39; data trends
[**ReportsApiV3WorkspaceWorkspaceIdDataTrendsUsersPost**](DefaultApi.md#reportsapiv3workspaceworkspaceiddatatrendsuserspost) | **POST** /reports/api/v3/workspace/{workspace_id}/data_trends/users | Load users&#39; data trends
[**ReportsApiV3WorkspaceWorkspaceIdProfitabilityProjectsPost**](DefaultApi.md#reportsapiv3workspaceworkspaceidprofitabilityprojectspost) | **POST** /reports/api/v3/workspace/{workspace_id}/profitability/projects | Load profitability projects report


<a name="reportsapiv3workspaceworkspaceidcomparativepost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdComparativePost**
> ComparativeReport ReportsApiV3WorkspaceWorkspaceIdComparativePost (int? workspaceId, ComparativeComparativePost comparativePost = null)

Load comparative report

Returns comparative report.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdComparativePostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi();
            var workspaceId = 56;  // int? | Workspace ID
            var comparativePost = new ComparativeComparativePost(); // ComparativeComparativePost | Comparative reports conditions (optional) 

            try
            {
                // Load comparative report
                ComparativeReport result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdComparativePost(workspaceId, comparativePost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ReportsApiV3WorkspaceWorkspaceIdComparativePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **comparativePost** | [**ComparativeComparativePost**](ComparativeComparativePost.md)| Comparative reports conditions | [optional] 

### Return type

[**ComparativeReport**](ComparativeReport.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3workspaceworkspaceiddatatrendsclientspost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdDataTrendsClientsPost**
> ClientsDataTrendsReport ReportsApiV3WorkspaceWorkspaceIdDataTrendsClientsPost (int? workspaceId, BaseDataTrendsPost dataTrendsPost)

Load clients' data trends

Returns the clients' data trends.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdDataTrendsClientsPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi();
            var workspaceId = 56;  // int? | Workspace ID
            var dataTrendsPost = new BaseDataTrendsPost(); // BaseDataTrendsPost | Report data trends conditions

            try
            {
                // Load clients' data trends
                ClientsDataTrendsReport result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdDataTrendsClientsPost(workspaceId, dataTrendsPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ReportsApiV3WorkspaceWorkspaceIdDataTrendsClientsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **dataTrendsPost** | [**BaseDataTrendsPost**](BaseDataTrendsPost.md)| Report data trends conditions | 

### Return type

[**ClientsDataTrendsReport**](ClientsDataTrendsReport.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3workspaceworkspaceiddatatrendsprojectspost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdDataTrendsProjectsPost**
> ProjectsDataTrendsReport ReportsApiV3WorkspaceWorkspaceIdDataTrendsProjectsPost (int? workspaceId, BaseDataTrendsPost dataTrendsPost = null)

Load projects' data trends

Returns projects' data trends.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdDataTrendsProjectsPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi();
            var workspaceId = 56;  // int? | Workspace ID
            var dataTrendsPost = new BaseDataTrendsPost(); // BaseDataTrendsPost | Data trends conditions (optional) 

            try
            {
                // Load projects' data trends
                ProjectsDataTrendsReport result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdDataTrendsProjectsPost(workspaceId, dataTrendsPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ReportsApiV3WorkspaceWorkspaceIdDataTrendsProjectsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **dataTrendsPost** | [**BaseDataTrendsPost**](BaseDataTrendsPost.md)| Data trends conditions | [optional] 

### Return type

[**ProjectsDataTrendsReport**](ProjectsDataTrendsReport.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3workspaceworkspaceiddatatrendsuserspost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdDataTrendsUsersPost**
> UsersDataTrendsReport ReportsApiV3WorkspaceWorkspaceIdDataTrendsUsersPost (int? workspaceId, BaseDataTrendsPost dataTrendsPost)

Load users' data trends

Returns users' data trends.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdDataTrendsUsersPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi();
            var workspaceId = 56;  // int? | Workspace ID
            var dataTrendsPost = new BaseDataTrendsPost(); // BaseDataTrendsPost | Report data trends conditions

            try
            {
                // Load users' data trends
                UsersDataTrendsReport result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdDataTrendsUsersPost(workspaceId, dataTrendsPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ReportsApiV3WorkspaceWorkspaceIdDataTrendsUsersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **dataTrendsPost** | [**BaseDataTrendsPost**](BaseDataTrendsPost.md)| Report data trends conditions | 

### Return type

[**UsersDataTrendsReport**](UsersDataTrendsReport.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsapiv3workspaceworkspaceidprofitabilityprojectspost"></a>
# **ReportsApiV3WorkspaceWorkspaceIdProfitabilityProjectsPost**
> ProjectsReport ReportsApiV3WorkspaceWorkspaceIdProfitabilityProjectsPost (int? workspaceId, RequestsProjectProfitability projectProfitabilityPost = null)

Load profitability projects report

Returns profitability projects report.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class ReportsApiV3WorkspaceWorkspaceIdProfitabilityProjectsPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi();
            var workspaceId = 56;  // int? | Workspace ID
            var projectProfitabilityPost = new RequestsProjectProfitability(); // RequestsProjectProfitability | Profitability projects report conditions (optional) 

            try
            {
                // Load profitability projects report
                ProjectsReport result = apiInstance.ReportsApiV3WorkspaceWorkspaceIdProfitabilityProjectsPost(workspaceId, projectProfitabilityPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ReportsApiV3WorkspaceWorkspaceIdProfitabilityProjectsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **projectProfitabilityPost** | [**RequestsProjectProfitability**](RequestsProjectProfitability.md)| Profitability projects report conditions | [optional] 

### Return type

[**ProjectsReport**](ProjectsReport.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

