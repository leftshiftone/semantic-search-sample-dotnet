# LSO.SemanticSearch.Model.PostprocessorSettings
The settings to control postprocessing of the raw search results.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NormalizerType** | **string** | The type of score normalization to perform.   * NO: Do not perform any normalization and return the raw search scores.   * SIGMOID: Sigmoid based normalization in the interval (0, 1). Behavior can be tuned by setting an appropriate offset and scale.  | [optional] [default to NormalizerTypeEnum.NO]
**NormalizerSigmoidOffset** | **decimal** | The offset in 1 / ( 1 + exp(-(x-offset)/scale) ) used for the sigmoid normalizer. | [optional] [default to 0.5M]
**NormalizerSigmoidScale** | **decimal** | The scale in 1 / ( 1 + exp(-(x-offset)/scale) ) used for the sigmoid normalizer. | [optional] [default to 1.0M]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

