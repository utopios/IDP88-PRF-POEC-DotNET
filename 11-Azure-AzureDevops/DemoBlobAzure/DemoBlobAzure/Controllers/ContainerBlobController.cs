using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Mvc;


namespace DemoBlobAzure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContainerBlobController : ControllerBase
    {
        private BlobServiceClient _blobServiceClient;

        public ContainerBlobController()
        {
            //StorageSharedKeyCredential keyCredential = new StorageSharedKeyCredential("m2iformation", "SajjRNeCyZorvlAE8BySuJjWUXG0IFLfijrDIN8mjcpA2Wpkhxh82Kh4E0kPL4oOS789tBX8LiHw+AStzJZcUA==");
            //_blobServiceClient = new BlobServiceClient(new Uri("http://m2iformation.blob.core.windows.net"), keyCredential);

            _blobServiceClient = new BlobServiceClient(@"DefaultEndpointsProtocol=https;AccountName=m2iformation;AccountKey=SajjRNeCyZorvlAE8BySuJjWUXG0IFLfijrDIN8mjcpA2Wpkhxh82Kh4E0kPL4oOS789tBX8LiHw+AStzJZcUA==;EndpointSuffix=core.windows.net");
        }

        [HttpPost("/container")]
        public async Task<IActionResult> Post(string containerName)
        {
            BlobContainerClient containerClient = _blobServiceClient.CreateBlobContainer(containerName);
            containerClient.SetAccessPolicy(PublicAccessType.BlobContainer);
            if(containerClient.Exists())
                return Ok("Container créé !");

            return BadRequest("erreur création");
        }

        [HttpPut("/container/{name}")]
        public async Task<IActionResult> Put(string name, IFormFile image)
        {
            BlobContainerClient containerClient = _blobServiceClient.GetBlobContainerClient(name);
            BlobClient blobClient = containerClient.GetBlobClient(image.FileName);
            blobClient.Upload(image.OpenReadStream());
            return Ok("image uploaded");
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> Get(string name)
        {
            List<string> urls = new List<string>();
            BlobContainerClient containerClient = _blobServiceClient.GetBlobContainerClient(name);
            var result = containerClient.GetBlobs();
            foreach (BlobItem blob in result)
            {
                urls.Add("https://m2iformation.blob.core.windows.net/" + name + "/" + blob.Name);
            }
            return Ok(urls);
        }
    }
}
