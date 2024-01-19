using FileUploadApp.Db.Entities;
using Microsoft.AspNetCore.Http;

namespace FileUploadApp.Logic
{
    public interface IFileUploadService
    {
        Task<IEnumerable<FileUpload>> GetFiles();

        Task AddFile(IFormFile? uploadedFile, string webRootPath);
    }
}