using FileUploadApp.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace FileUploadApp.Db
{
    public class FileUploadContext : DbContext
    {
        public DbSet<FileUpload> Files { get; set; } = null!;

        public FileUploadContext(DbContextOptions<FileUploadContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}