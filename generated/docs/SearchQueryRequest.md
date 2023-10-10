# LSO.SemanticSearch.Model.SearchQueryRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TextQueries** | [**List&lt;TextQuery&gt;**](TextQuery.md) | The main text queries. A combination of semantic and full text search is performed depending on the settings.  &gt; **_NOTE:_**  For simple database backends, only a single semantic query against the default content_text_ field is performed at the moment.  | 
**FilterQueries** | [**List&lt;SearchQueryRequestFilterQueriesInner&gt;**](SearchQueryRequestFilterQueriesInner.md) | A list of filters.  | [optional] 
**FilterQuery** | **string** | The filter query. It can be any Elasticsearch [query string syntax](https://www.elastic.co/guide/en/elasticsearch/reference/7.17/query-dsl-query-string-query.html#query-string-syntax). Beside explicit meta data field, all default fields can be used as well: document_id_, content_text_, content_json_.  &gt; **_NOTE:_**  This only affects full database backends and will be replaced by the filter_queries parameter in the future.  | [optional] [default to ""]
**Offset** | **long** | The count of results which should be omitted. | [optional] [default to 0]
**Limit** | **long** | The number of results to retrieve. | [optional] [default to 10]
**MinScore** | **decimal** | The minimum score of the obtained results. Any score below this threshold will not be returned. | [optional] [default to 0.5M]
**IsDistinct** | **bool** | If set to true, only the highest scoring result for each indexed document is returned. If set to false, the same indexed document might yield multiple hits. | [optional] [default to false]
**SearchSettings** | [**SearchSettings**](SearchSettings.md) |  | [optional] 
**PreprocessorSettings** | [**PreprocessorSettings**](PreprocessorSettings.md) |  | [optional] 
**PostprocessorSettings** | [**PostprocessorSettings**](PostprocessorSettings.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

