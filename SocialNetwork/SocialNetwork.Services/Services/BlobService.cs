using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using SocialNetwork.Services.Constants;
using SocialNetwork.Services.Services.Contracts;
using System;
using System.IO;
using System.Threading.Tasks;

namespace SocialNetwork.Services.Services
{
    public class BlobService : IBlobService
    {
        private readonly IConfiguration configuration;

        public BlobService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<string> UploadToBlobStorageAsync(IFormFile file)
        {
            try
            {
                string blobstorageconnection = configuration.GetValue<string>("blobstorage");
                string systemFileName = file.FileName;
                string place = Path.Combine(blobstorageconnection,systemFileName);
                string outputPhoto = Environment.CurrentDirectory + place;
                using (FileStream newPhoto = File.Open(outputPhoto, FileMode.OpenOrCreate))
                await using (var data = file.OpenReadStream())
                {
                    await data.CopyToAsync(newPhoto);
                }
                return "/Photo/"+systemFileName;
                // Retrieve storage account from connection string.
                /*CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse(blobstorageconnection);

                // Create the blob client.
                CloudBlobClient blobClient = cloudStorageAccount.CreateCloudBlobClient();

                // Retrieve a reference to a container.
                CloudBlobContainer container = blobClient.GetContainerReference("filescontainers");

                // This also does not make a service call; it only creates a local object.
                CloudBlockBlob blockBlob = container.GetBlockBlobReference(systemFileName);

                await using (var data = file.OpenReadStream())
                {
                    await blockBlob.UploadFromStreamAsync(data);
                }

                return blockBlob.SnapshotQualifiedUri.ToString();
                //return blockBlob.Uri.AbsoluteUri.ToString();*/
            }
            catch (Exception)
            {
                throw new ArgumentException(ExceptionMessages.BlobError);
            }
        }
    }
}