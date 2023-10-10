# LSO.SemanticSearch.Api.IndexApi

All URIs are relative to */api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**IndexGet**](IndexApi.md#indexget) | **GET** /index |  |
| [**IndexIndexNameDelete**](IndexApi.md#indexindexnamedelete) | **DELETE** /index/{index_name} |  |
| [**IndexIndexNameDocumentsDocIdDelete**](IndexApi.md#indexindexnamedocumentsdociddelete) | **DELETE** /index/{index_name}/documents/{doc_id} |  |
| [**IndexIndexNameDocumentsPost**](IndexApi.md#indexindexnamedocumentspost) | **POST** /index/{index_name}/documents |  |
| [**IndexPost**](IndexApi.md#indexpost) | **POST** /index |  |

<a id="indexget"></a>
# **IndexGet**
> ListAllIndicesResponse IndexGet ()



List all indices

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LSO.SemanticSearch.Api;
using LSO.SemanticSearch.Client;
using LSO.SemanticSearch.Model;

namespace Example
{
    public class IndexGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            var apiInstance = new IndexApi(config);

            try
            {
                ListAllIndicesResponse result = apiInstance.IndexGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndexApi.IndexGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IndexGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ListAllIndicesResponse> response = apiInstance.IndexGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndexApi.IndexGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ListAllIndicesResponse**](ListAllIndicesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Plain list of all indices. |  -  |
| **400** | The provided input was wrong. |  -  |
| **500** | An unexpected error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="indexindexnamedelete"></a>
# **IndexIndexNameDelete**
> void IndexIndexNameDelete (string indexName, string? force = null)



Delete an entire index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LSO.SemanticSearch.Api;
using LSO.SemanticSearch.Client;
using LSO.SemanticSearch.Model;

namespace Example
{
    public class IndexIndexNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            var apiInstance = new IndexApi(config);
            var indexName = "indexName_example";  // string | 
            var force = "true";  // string? | If set to \"true\", delete index even if it is not empty. (optional)  (default to false)

            try
            {
                apiInstance.IndexIndexNameDelete(indexName, force);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndexApi.IndexIndexNameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IndexIndexNameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.IndexIndexNameDeleteWithHttpInfo(indexName, force);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndexApi.IndexIndexNameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **indexName** | **string** |  |  |
| **force** | **string?** | If set to \&quot;true\&quot;, delete index even if it is not empty. | [optional] [default to false] |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Index has been deleted. |  -  |
| **404** | The specified resource was not found. |  -  |
| **500** | An unexpected error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="indexindexnamedocumentsdociddelete"></a>
# **IndexIndexNameDocumentsDocIdDelete**
> void IndexIndexNameDocumentsDocIdDelete (string indexName, string docId)



Delete an indexed documents.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LSO.SemanticSearch.Api;
using LSO.SemanticSearch.Client;
using LSO.SemanticSearch.Model;

namespace Example
{
    public class IndexIndexNameDocumentsDocIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            var apiInstance = new IndexApi(config);
            var indexName = "indexName_example";  // string | 
            var docId = "docId_example";  // string | 

            try
            {
                apiInstance.IndexIndexNameDocumentsDocIdDelete(indexName, docId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndexApi.IndexIndexNameDocumentsDocIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IndexIndexNameDocumentsDocIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.IndexIndexNameDocumentsDocIdDeleteWithHttpInfo(indexName, docId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndexApi.IndexIndexNameDocumentsDocIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **indexName** | **string** |  |  |
| **docId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Document has been deleted from the index. |  -  |
| **404** | The specified resource was not found. |  -  |
| **500** | An unexpected error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="indexindexnamedocumentspost"></a>
# **IndexIndexNameDocumentsPost**
> void IndexIndexNameDocumentsPost (string indexName, string docId, CreateDocumentRequest? createDocumentRequest = null)



Trigger indexing of document information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LSO.SemanticSearch.Api;
using LSO.SemanticSearch.Client;
using LSO.SemanticSearch.Model;

namespace Example
{
    public class IndexIndexNameDocumentsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            var apiInstance = new IndexApi(config);
            var indexName = "indexName_example";  // string | 
            var docId = "docId_example";  // string | 
            var createDocumentRequest = new CreateDocumentRequest?(); // CreateDocumentRequest? |  (optional) 

            try
            {
                apiInstance.IndexIndexNameDocumentsPost(indexName, docId, createDocumentRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndexApi.IndexIndexNameDocumentsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IndexIndexNameDocumentsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.IndexIndexNameDocumentsPostWithHttpInfo(indexName, docId, createDocumentRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndexApi.IndexIndexNameDocumentsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **indexName** | **string** |  |  |
| **docId** | **string** |  |  |
| **createDocumentRequest** | [**CreateDocumentRequest?**](CreateDocumentRequest?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Document has been indexed. |  -  |
| **404** | The specified resource was not found. |  -  |
| **500** | An unexpected error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="indexpost"></a>
# **IndexPost**
> IndexResponse IndexPost (CreateIndexRequest? createIndexRequest = null)



Create an index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LSO.SemanticSearch.Api;
using LSO.SemanticSearch.Client;
using LSO.SemanticSearch.Model;

namespace Example
{
    public class IndexPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            var apiInstance = new IndexApi(config);
            var createIndexRequest = new CreateIndexRequest?(); // CreateIndexRequest? | The index definition. (optional) 

            try
            {
                IndexResponse result = apiInstance.IndexPost(createIndexRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndexApi.IndexPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IndexPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IndexResponse> response = apiInstance.IndexPostWithHttpInfo(createIndexRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndexApi.IndexPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createIndexRequest** | [**CreateIndexRequest?**](CreateIndexRequest?.md) | The index definition. | [optional]  |

### Return type

[**IndexResponse**](IndexResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The created index definition. |  -  |
| **400** | The provided input was wrong. |  -  |
| **500** | An unexpected error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

