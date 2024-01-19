using Microsoft.AspNetCore.Http;

namespace FileUploadApp.Logic
{
    public interface IFileUploadService
    {
        Task AddFile(IFormFile uploadedFile);
    }
}