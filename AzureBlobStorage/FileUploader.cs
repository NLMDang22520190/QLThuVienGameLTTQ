using System.IO;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using EpistWinform.DAO;
using WebRequestFile = System.Net.WebRequestMethods.File;

public class FileUploader
{
    private readonly string _connectionString = "DefaultEndpointsProtocol = https; AccountName=gamedatalttq;AccountKey=D8SYJRzwjmzZt04xBKbZWIP/dKdrDpWUKoTCfqUmzSUhYhX7h6ueLNOLH+aXQm0LIEyhHZqtq4BU+AStCzOf0g==;EndpointSuffix=core.windows.net";
    private readonly string _gameContainerName = "gamedatalttq";
    private readonly string _pictureContainerName = "gamedatalttq";

    private static FileUploader instance; // Ctrl + R + E

    public static FileUploader Instance
    {
        get { if (instance == null) instance = new FileUploader(); return FileUploader.instance; }
        private set { FileUploader.instance = value; }
    }

    //public FileUploader(string connectionString = "", string containerName = "")
    //{
    //    _connectionString = connectionString;
    //    _containerName = containerName;
    //}

    public void UploadGameFile(string filePath, string blobName)
    {
        BlobServiceClient blobServiceClient = new BlobServiceClient(_connectionString);
        BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(_gameContainerName);
        BlobClient blobClient = containerClient.GetBlobClient(blobName);

        using (FileStream fs = File.OpenRead(filePath))
        {
            blobClient.Upload(fs, true);
        }
    }

    public void UploadPictureFile(string filePath, string blobName, string pictureContainterId)
    {
        BlobServiceClient blobServiceClient = new BlobServiceClient(_connectionString);
        BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient("game"+pictureContainterId);
        containerClient.CreateIfNotExists();
        BlobClient blobClient = containerClient.GetBlobClient(blobName);

        using (FileStream fs = File.OpenRead(filePath))
        {
            blobClient.Upload(fs, true);
        }
    }
}
    