# LSO.SemanticSearch.Model.SearchSettings
The settings to fine-tune the search behavior.  > **_NOTE:_**  For simple database backends, these settings have no effect at the moment. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GlobalSemanticScoreWeight** | **decimal** | The multiplicative weight for the semantic part of the score. | [optional] [default to 1.0M]
**GlobalFullTextScoreWeight** | **decimal** | The multiplicative weight for the full text part of the score. | [optional] [default to 1.0M]
**FullTextScoreSaturation** | **decimal** | The value in x / (value + x), to saturate the unbounded full text part of the score and to squeeze it into the interval [0,1). If the value is 0, no saturation is performed and the score is unbounded. | [optional] [default to 0M]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

