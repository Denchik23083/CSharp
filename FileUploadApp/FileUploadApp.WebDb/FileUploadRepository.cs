using FileUploadApp.Db;
using FileUploadApp.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace FileUploadApp.WebDb
{
    public class FileUploadRepository : IFileUploadRepository
    {
        private readonly FileUploadContext _context;

        public FileUploadRepository(FileUploadContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<FileUpload>> GetFiles()
        {
            return await _context.Files.ToListAsync();
        }

        public async Task AddFile(FileUpload file)
        {
            await _context.Files.AddAsync(file);

            await _context.SaveChangesAsync();
        }
    }
}