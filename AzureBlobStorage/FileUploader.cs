using System.IO;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using WebRequestFile = System.Net.WebRequestMethods.File;

public class FileUploader
{
    private readonly string _connectionString = "DefaultEndpointsProtocol = https; AccountName=gamedatalttq;AccountKey=D8SYJRzwjmzZt04xBKbZWIP/dKdrDpWUKoTCfqUmzSUhYhX7h6ueLNOLH+aXQm0LIEyhHZqtq4BU+AStCzOf0g==;EndpointSuffix=core.windows.net";
    private readonly string _containerName = "gamedatalttq";

    public FileUploader(string connectionString, string containerName)
    {
        _connectionString = connectionString;
        _containerName = containerName;
    }

    public void UploadFile(string filePath, string blobName)
    {
        BlobServiceClient blobServiceClient = new BlobServiceClient(_connectionString);
        BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(_containerName);
        BlobClient blobClient = containerClient.GetBlobClient(blobName);

        using (FileStream fs = File.OpenRead(filePath))
        {
            blobClient.Upload(fs, true);
        }
    }
}
    