using FileUploadApp.Db.Entities;

namespace FileUploadApp.WebDb
{
    public interface IFileUploadRepository
    {
        Task<IEnumerable<FileUpload>> GetFiles();

        Task AddFile(FileUpload file);
    }
}
