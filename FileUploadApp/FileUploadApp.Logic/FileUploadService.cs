using FileUploadApp.Db.Entities;
using FileUploadApp.WebDb;
using Microsoft.AspNetCore.Http;

namespace FileUploadApp.Logic
{
    public class FileUploadService : IFileUploadService
    {
        private readonly IFileUploadRepository _repository;

        public FileUploadService(IFileUploadRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<FileUpload>> GetFiles()
        {
            return await _repository.GetFiles();
        }

        public async Task AddFile(IFormFile? uploadedFile, string webRootPath)
        {
            if (uploadedFile is not null)
            {
                var path = "/files/" + uploadedFile.FileName;

                await using var fileStream = new FileStream(webRootPath + path, FileMode.Create);
                
                await uploadedFile.CopyToAsync(fileStream);
                
                var file = new FileUpload { Name = uploadedFile.FileName, Path = path };
                
                await _repository.AddFile(file);
            }
        }
    }
}