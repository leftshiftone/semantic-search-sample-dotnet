# LSO.SemanticSearch.Api.IndexApi

All URIs are relative to */api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateDocument**](IndexApi.md#createdocument) | **POST** /index/{index_name}/documents |  |
| [**CreateIndex**](IndexApi.md#createindex) | **POST** /index |  |
| [**DeleteDocument**](IndexApi.md#deletedocument) | **DELETE** /index/{index_name}/documents/{doc_id} |  |
| [**DeleteIndex**](IndexApi.md#deleteindex) | **DELETE** /index/{index_name} |  |
| [**ListIndices**](IndexApi.md#listindices) | **GET** /index |  |

<a id="createdocument"></a>
# **CreateDocument**
> void CreateDocument (string indexName, string docId, CreateDocumentRequest? createDocumentRequest = null)



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
    public class CreateDocumentExample
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
                apiInstance.CreateDocument(indexName, docId, createDocumentRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndexApi.CreateDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateDocumentWithHttpInfo(indexName, docId, createDocumentRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndexApi.CreateDocumentWithHttpInfo: " + e.Message);
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

<a id="createindex"></a>
# **CreateIndex**
> IndexResponse CreateIndex (CreateIndexRequest? createIndexRequest = null)



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
    public class CreateIndexExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            var apiInstance = new IndexApi(config);
            var createIndexRequest = new CreateIndexRequest?(); // CreateIndexRequest? | The index definition. (optional) 

            try
            {
                IndexResponse result = apiInstance.CreateIndex(createIndexRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndexApi.CreateIndex: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateIndexWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IndexResponse> response = apiInstance.CreateIndexWithHttpInfo(createIndexRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndexApi.CreateIndexWithHttpInfo: " + e.Message);
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

<a id="deletedocument"></a>
# **DeleteDocument**
> void DeleteDocument (string indexName, string docId)



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
    public class DeleteDocumentExample
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
                apiInstance.DeleteDocument(indexName, docId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndexApi.DeleteDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteDocumentWithHttpInfo(indexName, docId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndexApi.DeleteDocumentWithHttpInfo: " + e.Message);
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

<a id="deleteindex"></a>
# **DeleteIndex**
> void DeleteIndex (string indexName, string? force = null)



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
    public class DeleteIndexExample
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
                apiInstance.DeleteIndex(indexName, force);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndexApi.DeleteIndex: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteIndexWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteIndexWithHttpInfo(indexName, force);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndexApi.DeleteIndexWithHttpInfo: " + e.Message);
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

<a id="listindices"></a>
# **ListIndices**
> ListAllIndicesResponse ListIndices ()



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
    public class ListIndicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            var apiInstance = new IndexApi(config);

            try
            {
                ListAllIndicesResponse result = apiInstance.ListIndices();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndexApi.ListIndices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListIndicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ListAllIndicesResponse> response = apiInstance.ListIndicesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndexApi.ListIndicesWithHttpInfo: " + e.Message);
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

