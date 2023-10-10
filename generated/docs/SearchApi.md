# LSO.SemanticSearch.Api.SearchApi

All URIs are relative to */api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SearchIndex**](SearchApi.md#searchindex) | **POST** /search/{index_name} |  |

<a id="searchindex"></a>
# **SearchIndex**
> SearchResultsResponse SearchIndex (string indexName, SearchQueryRequest? searchQueryRequest = null)



Search for documents

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LSO.SemanticSearch.Api;
using LSO.SemanticSearch.Client;
using LSO.SemanticSearch.Model;

namespace Example
{
    public class SearchIndexExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            var apiInstance = new SearchApi(config);
            var indexName = "indexName_example";  // string | 
            var searchQueryRequest = new SearchQueryRequest?(); // SearchQueryRequest? | The search query. (optional) 

            try
            {
                SearchResultsResponse result = apiInstance.SearchIndex(indexName, searchQueryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.SearchIndex: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchIndexWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SearchResultsResponse> response = apiInstance.SearchIndexWithHttpInfo(indexName, searchQueryRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.SearchIndexWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **indexName** | **string** |  |  |
| **searchQueryRequest** | [**SearchQueryRequest?**](SearchQueryRequest?.md) | The search query. | [optional]  |

### Return type

[**SearchResultsResponse**](SearchResultsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Search results |  -  |
| **500** | An unexpected error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

