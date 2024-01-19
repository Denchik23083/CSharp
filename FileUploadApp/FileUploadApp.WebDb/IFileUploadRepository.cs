using FileUploadApp.Db.Entities;

namespace FileUploadApp.WebDb
{
    public interface IFileUploadRepository
    {
        Task AddFile(FileUpload uploadedFile);
    }
}
