using FileUploadApp.Logic;
using Microsoft.AspNetCore.Mvc;

namespace FileUploadApp.Web.Controllers
{
    public class FileController : Controller
    {
        private readonly IFileUploadService _service;
        private readonly IWebHostEnvironment _appEnvironment;

        public FileController(IFileUploadService service, IWebHostEnvironment appEnvironment)
        {
            _service = service;
            _appEnvironment = appEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var files = await _service.GetFiles();

            return View(files);
        }

        [HttpPost]
        public async Task<IActionResult> AddFile(IFormFile? uploadedFile)
        {
            await _service.AddFile(uploadedFile, _appEnvironment.WebRootPath);

            return RedirectToAction("Index");
        }
    }
}
