# LSO.SemanticSearch.Model.DocumentIndexSettings

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SplitSentences** | **bool** | Whether to split the document into sentences. | [optional] [default to true]
**SentenceCount** | **int** | The number of sentences to group and index together. | [optional] [default to 3]
**SentenceOverlap** | **int** | The number of sentences consecutive sentence groups overlap. | [optional] [default to 1]
**MinChars** | **int** | The minimum number of characters a sentence group must contain. If the length of a sentence group is below this value, additional sentences are added until this requirement is fulfilled. | [optional] [default to 1]
**SemanticFields** | **List&lt;string&gt;** | The names of text fields, which should be semantically embedded. The default value &#39;content_text_&#39; refers to the raw document text content.  &gt; **_NOTE:_**  For simple database backends, only the default content_text_ is semantically embedded at the moment.  | [optional] 
**DeleteSource** | **bool** | Delete the source files belonging to that document. | [optional] [default to true]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

