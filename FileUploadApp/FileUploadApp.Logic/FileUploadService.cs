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

        public Task AddFile(IFormFile uploadedFile)
        {
            throw new AbandonedMutexException();
        }
    }
}