// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using LSO.SemanticSearch.Api;
using LSO.SemanticSearch.Client;
using LSO.SemanticSearch.Model;
using Minio;
using Newtonsoft.Json.Linq;

namespace semantic_search_sample_dotnet {
    static class Program {
        static async Task Main()
        {
            // Init
            var searcherConf = new Configuration
            {
                BasePath = "http://localhost:8082/api/v1"
            };
            var indexerConf = new Configuration
            {
                BasePath = "http://localhost:8081/api/v1"
            };
            var searchClient = new SearchApi(searcherConf);
            var indexerClient = new IndexApi(indexerConf);
           
            var minio = MinioUtil.InitClient("localhost:9000", "admin", "adminadmin");
            
            var indexName = "test";
            
            // create Index
            try
            {
                await indexerClient.IndexPostAsync(new CreateIndexRequest(
                    indexName, new List<IndexFieldMapping>()
                ));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creating index (maybe it exists?)");
            }


            // index the document
            await IndexDocument(indexName, "test.pdf", minio, indexerClient);
           
            
            // Search the index
            var searchRequest = new SearchQueryRequest(new List<TextQuery>
            {
                new()
                {
                    Query = "Ist das arbeitsumfeld flexibel?",
                    SemanticWeight = 1,
                    FullTextWeight = 0,
                }
            }, minScore: 0.05M);
            var results = await searchClient.SearchIndexNamePostAsync(indexName, searchRequest);
            Console.WriteLine(results.ToJson());
        }

        
        static async Task IndexDocument(string indexName, string fileName, IMinioClient minio, IndexApi indexer)
        {
            var documentId = Guid.NewGuid();
            
            // create and upload the __meta__.json
            var meta = new JObject(
                new JProperty("meta", new JObject()),
                new JProperty("files", new JArray(
                    new JObject(
                        new JProperty("meta", new JObject()),
                        new JProperty("file_name", fileName)
                    )    
                ))
            );
            await MinioUtil.UploadStringAsFile(meta.ToString(), $"{documentId}/__meta__.json", indexName, minio);
            
            // Upload the file to index
            await MinioUtil.UploadFile($"test/{fileName}", $"{documentId}/{fileName}", indexName, minio);

            // Start the indexing
            await indexer.IndexIndexNameDocumentsPostAsync(
                indexName,
                documentId.ToString(), 
                new CreateDocumentRequest(documentId.ToString())    
            );
        }
    }
}