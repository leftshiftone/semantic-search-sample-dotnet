# LSO.SemanticSearch.Model.IndexFieldMapping

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FieldName** | **string** | The name of the field. | 
**Type** | **string** | The data type of the field. Possible values:   * BOOLEAN, INTEGER, FLOAT: The familiar data types.   * TIMESTAMP: Formatted either as yyyy-MM-ddTHH:mm:ss.SSSSSSZ or yyyy-MM-dd   * JSON: A general, structured element.   * GEO_POINT: Latitude and longitude coordinates   * KEYWORD: Text field, which is not analyzed. Suited for filter queries.   * TEXT: Text field, which is analyzed as well as (possibly) semantically embedded. Suited for full text and semantic search.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

