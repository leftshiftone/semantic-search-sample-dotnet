# LSO.SemanticSearch.Model.TextQuery
The representation of a semantic as well as full text query.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FieldName** | **string** | The name of the indexed text field to be searched. The default value refers to the well known field &#39;content_text_&#39;, containing the document text content. | [optional] [default to "content_text_"]
**Query** | **string** | The main search query for this field. | [optional] 
**SemanticWeight** | **decimal** | The weight multiplier for the semantic part of this query. If set to 0, no semantic search is performed for this field. | [optional] [default to 1.0M]
**FullTextWeight** | **decimal** | The weight multiplier for the full text search part of this query. If set to 0, no full text search is performed for this field. | [optional] [default to 1.0M]
**Fuzziness** | **string** | The amount of fuzziness for the full text search part.   * 0, 1, 2, 3: Number of allowed edits.   * AUTO: Variable number of edits depending on token lengths.  | [optional] [default to FuzzinessEnum.AUTO]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

