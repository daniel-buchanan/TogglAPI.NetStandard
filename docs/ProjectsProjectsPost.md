# TogglAPI.NetStandard.Model.ProjectsProjectsPost
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientIds** | **List&lt;int?&gt;** | Client IDs, optional. | [optional] 
**Currency** | **string** | Currency, optional, example \&quot;EUR\&quot;. | [optional] 
**Ids** | **List&lt;int?&gt;** | Project IDs, optional. | [optional] 
**IsActive** | **bool?** | Whether the wanted projects are archived, optional, default false. | [optional] 
**IsBillable** | **bool?** | Whether the wanted projects are billable, optional, premium feature, default false. | [optional] 
**IsPrivate** | **bool?** | Whether the wanted projects are private, optional, default false. | [optional] 
**Name** | **string** | Project name, optional. | [optional] 
**PageSize** | **int?** | PageSize is the number of records returned per page. If unset, the default value of 201 will be used. | [optional] 
**Start** | **int?** | Start is used for pagination, optional, default 0. The api will return the next projects page with id &gt;&#x3D; Start. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

