# TogglAPI.NetStandard.Api.InsightsApi

All URIs are relative to *https://localhost:8080/api/v9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InsightsApiV1WorkspaceWorkspaceIdDataTrendsProjectsPost**](InsightsApi.md#insightsapiv1workspaceworkspaceiddatatrendsprojectspost) | **POST** /insights/api/v1/workspace/{workspace_id}/data_trends/projects | Load projects&#39; data trends
[**InsightsApiV1WorkspaceWorkspaceIdProfitabilityEmployeesExtensionPost**](InsightsApi.md#insightsapiv1workspaceworkspaceidprofitabilityemployeesextensionpost) | **POST** /insights/api/v1/workspace/{workspace_id}/profitability/employees.{extension} | Export employee profitability insights
[**InsightsApiV1WorkspaceWorkspaceIdProfitabilityProjectsExtensionPost**](InsightsApi.md#insightsapiv1workspaceworkspaceidprofitabilityprojectsextensionpost) | **POST** /insights/api/v1/workspace/{workspace_id}/profitability/projects.{extension} | Export profitability project insights
[**InsightsApiV1WorkspaceWorkspaceIdTrendsProjectsExtensionPost**](InsightsApi.md#insightsapiv1workspaceworkspaceidtrendsprojectsextensionpost) | **POST** /insights/api/v1/workspace/{workspace_id}/trends/projects.{extension} | Export projects data trends


<a name="insightsapiv1workspaceworkspaceiddatatrendsprojectspost"></a>
# **InsightsApiV1WorkspaceWorkspaceIdDataTrendsProjectsPost**
> List<ProjectsProjectTrends> InsightsApiV1WorkspaceWorkspaceIdDataTrendsProjectsPost (int? workspaceId, ProjectsProjectTrend projectTrendPost)

Load projects' data trends

Returns the projects' data trends projects from a workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class InsightsApiV1WorkspaceWorkspaceIdDataTrendsProjectsPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new InsightsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var projectTrendPost = new ProjectsProjectTrend(); // ProjectsProjectTrend | Projects filter conditions

            try
            {
                // Load projects' data trends
                List&lt;ProjectsProjectTrends&gt; result = apiInstance.InsightsApiV1WorkspaceWorkspaceIdDataTrendsProjectsPost(workspaceId, projectTrendPost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InsightsApi.InsightsApiV1WorkspaceWorkspaceIdDataTrendsProjectsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **projectTrendPost** | [**ProjectsProjectTrend**](ProjectsProjectTrend.md)| Projects filter conditions | 

### Return type

[**List<ProjectsProjectTrends>**](ProjectsProjectTrends.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insightsapiv1workspaceworkspaceidprofitabilityemployeesextensionpost"></a>
# **InsightsApiV1WorkspaceWorkspaceIdProfitabilityEmployeesExtensionPost**
> string InsightsApiV1WorkspaceWorkspaceIdProfitabilityEmployeesExtensionPost (RequestsEmployeeProfitability parameters)

Export employee profitability insights

Downloads employee profitability insights in the specified format: csv or xlsx.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class InsightsApiV1WorkspaceWorkspaceIdProfitabilityEmployeesExtensionPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new InsightsApi();
            var parameters = new RequestsEmployeeProfitability(); // RequestsEmployeeProfitability | Parameters for report

            try
            {
                // Export employee profitability insights
                string result = apiInstance.InsightsApiV1WorkspaceWorkspaceIdProfitabilityEmployeesExtensionPost(parameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InsightsApi.InsightsApiV1WorkspaceWorkspaceIdProfitabilityEmployeesExtensionPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parameters** | [**RequestsEmployeeProfitability**](RequestsEmployeeProfitability.md)| Parameters for report | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv, text/xlsx

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insightsapiv1workspaceworkspaceidprofitabilityprojectsextensionpost"></a>
# **InsightsApiV1WorkspaceWorkspaceIdProfitabilityProjectsExtensionPost**
> string InsightsApiV1WorkspaceWorkspaceIdProfitabilityProjectsExtensionPost (RequestsProjectProfitability parameters, string extension)

Export profitability project insights

Downloads profitability project insights in the specified format: csv or xlsx.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class InsightsApiV1WorkspaceWorkspaceIdProfitabilityProjectsExtensionPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new InsightsApi();
            var parameters = new RequestsProjectProfitability(); // RequestsProjectProfitability | Parameters for report
            var extension = extension_example;  // string | csv,xlsx

            try
            {
                // Export profitability project insights
                string result = apiInstance.InsightsApiV1WorkspaceWorkspaceIdProfitabilityProjectsExtensionPost(parameters, extension);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InsightsApi.InsightsApiV1WorkspaceWorkspaceIdProfitabilityProjectsExtensionPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parameters** | [**RequestsProjectProfitability**](RequestsProjectProfitability.md)| Parameters for report | 
 **extension** | **string**| csv,xlsx | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv, text/xlsx

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insightsapiv1workspaceworkspaceidtrendsprojectsextensionpost"></a>
# **InsightsApiV1WorkspaceWorkspaceIdTrendsProjectsExtensionPost**
> List<ProjectsProjectTrends> InsightsApiV1WorkspaceWorkspaceIdTrendsProjectsExtensionPost (int? workspaceId, string extension, ProjectsProjectTrend projectTrend = null)

Export projects data trends

Downloads projects data trends in the specified format: csv or xlsx.

### Example
```csharp
using System;
using System.Diagnostics;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace Example
{
    public class InsightsApiV1WorkspaceWorkspaceIdTrendsProjectsExtensionPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new InsightsApi();
            var workspaceId = 56;  // int? | Workspace ID
            var extension = extension_example;  // string | csv,xlsx
            var projectTrend = new ProjectsProjectTrend(); // ProjectsProjectTrend | Projects filter conditions (optional) 

            try
            {
                // Export projects data trends
                List&lt;ProjectsProjectTrends&gt; result = apiInstance.InsightsApiV1WorkspaceWorkspaceIdTrendsProjectsExtensionPost(workspaceId, extension, projectTrend);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InsightsApi.InsightsApiV1WorkspaceWorkspaceIdTrendsProjectsExtensionPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **extension** | **string**| csv,xlsx | 
 **projectTrend** | [**ProjectsProjectTrend**](ProjectsProjectTrend.md)| Projects filter conditions | [optional] 

### Return type

[**List<ProjectsProjectTrends>**](ProjectsProjectTrends.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

