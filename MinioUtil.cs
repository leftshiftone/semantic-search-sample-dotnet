using Minio;
using Minio.DataModel.Args;

namespace semantic_search_sample_dotnet;

public static class MinioUtil {
    public static IMinioClient InitClient(string url, string key, string secret)
    {
        return new MinioClient()
            .WithEndpoint(url)
            .WithCredentials(key, secret)
            .Build();
    }
    
    public static async Task UploadFile(string from, string to, string bucketName, IMinioClient client)
    {
        var args = new PutObjectArgs()
            .WithBucket(bucketName)
            .WithObject(to)
            .WithContentType("application/octet-stream")
            .WithFileName(from);
        _ = await client.PutObjectAsync(args).ConfigureAwait(false);
       
        Console.WriteLine($"Uploaded object {from} to bucket {bucketName}/{to}");
    }

    public static async Task UploadStringAsFile(string content, string to, string bucketName, IMinioClient client)
    {
        var path = Path.GetTempPath();
        var fileName = Path.ChangeExtension(Guid.NewGuid().ToString(), "json");
        var tempPath = Path.Combine(path, fileName);
        await File.WriteAllTextAsync(tempPath, content);

        await UploadFile(tempPath, to, bucketName, client);
    }
}