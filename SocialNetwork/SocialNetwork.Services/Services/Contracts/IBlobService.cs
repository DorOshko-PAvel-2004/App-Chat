using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace SocialNetwork.Services.Services.Contracts
{
    public interface IBlobService
    {
        Task<string> UploadToBlobStorageAsync(IFormFile file);
    }
}
