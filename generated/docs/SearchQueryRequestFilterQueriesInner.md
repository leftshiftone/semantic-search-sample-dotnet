# LSO.SemanticSearch.Model.SearchQueryRequestFilterQueriesInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FieldName** | **string** | The name of the indexed field to be filtered. Nested fields in a JSON structure are accessed with a &#39;.&#39; as separator, e.g. properties.date. | [optional] 
**Value** | [**KeyValueFilterValue**](KeyValueFilterValue.md) |  | [optional] 
**ModalType** | **string** | Wether the filter must (only documents matching the filter are returned) or must not hold (only documents not matching the filter are returned). | [optional] [default to ModalTypeEnum.MUST]
**Start** | **string** | Start timestamp in any ISO 8601 compatible format. | [optional] [default to "1900-01-01"]
**End** | **string** | End timestamp in any ISO 8601 compatible format. | [optional] [default to "2100-01-01"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

