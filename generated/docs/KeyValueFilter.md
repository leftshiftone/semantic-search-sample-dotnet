# LSO.SemanticSearch.Model.KeyValueFilter
A filter matching values in given fields.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FieldName** | **string** | The name of the indexed field to be filtered. Nested fields in an object hierarchy are accessed with a &#39;.&#39; as separator, e.g. name.first_name. | [optional] 
**Value** | [**KeyValueFilterValue**](KeyValueFilterValue.md) |  | [optional] 
**ModalType** | **string** | Wether the filter must (only documents matching the filter are returned) or must not hold (only documents not matching the filter are returned). | [optional] [default to ModalTypeEnum.MUST]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

