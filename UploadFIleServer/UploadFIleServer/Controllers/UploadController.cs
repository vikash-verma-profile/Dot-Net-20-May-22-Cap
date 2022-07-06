using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace UploadFIleServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        [HttpPost,DisableRequestSizeLimit]
        public async Task<IActionResult> Upload()
        {
            try
            {
                var formCollection=await Request.ReadFormAsync();
                var file = formCollection.Files.First();
                //var folderName = Path.Combine("Resources", "Images");
               // var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory());
                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                   // var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    string connectionString = "DefaultEndpointsProtocol=https;AccountName=levelupsolutions;AccountKey=o1BI0aWmaCWS7/pp7OiljEQdRORQA/rZA474QOW1X56JUz+CEPOXymF1nHnEaZ3dLIYwfewPmAcQ+AStqmDWVQ==;EndpointSuffix=core.windows.net";
                    string containerName = "images";
                    BlobContainerClient container = new BlobContainerClient(connectionString, containerName);
                    var blob = container.GetBlobClient(fileName);
                    var blobstream = System.IO.File.OpenRead(fileName);
                    await blob.UploadAsync(blobstream);
                    var Uri = blob.Uri.AbsoluteUri;
                    return Ok();
                
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500);

            }
        }
    }
}
