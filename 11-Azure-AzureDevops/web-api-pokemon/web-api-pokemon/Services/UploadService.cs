using System.Reflection.Metadata;
using Azure.Storage.Blobs;
using web_api_pokemon.Services.Interfaces;

namespace web_api_pokemon.Services;

public class UploadService : IUpload
{
    private BlobServiceClient _blobServiceClient;
    private BlobContainerClient _blobContainerClient;

    public UploadService()
    {
        _blobServiceClient = new BlobServiceClient(@"DefaultEndpointsProtocol=https;AccountName=m2iformation;AccountKey=SajjRNeCyZorvlAE8BySuJjWUXG0IFLfijrDIN8mjcpA2Wpkhxh82Kh4E0kPL4oOS789tBX8LiHw+AStzJZcUA==;EndpointSuffix=core.windows.net");
        _blobContainerClient = _blobServiceClient.GetBlobContainerClient("pokillaume");
    }
    public string UploadImage(IFormFile image)
    {
        string url = "https://m2iformation.blob.core.windows.net/pokillaume/";
        string fileName = Guid.NewGuid() + "-" + image.FileName;
        BlobClient blobClient = _blobContainerClient.GetBlobClient(fileName);

        try
        {
            blobClient.Upload(image.OpenReadStream());
            return url + fileName;
        }
        catch (Exception)
        {
             throw new Exception("Erreur upload");
        }
        
    }
}