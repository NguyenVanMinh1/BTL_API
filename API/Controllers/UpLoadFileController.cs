using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TONGXUANTU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpLoadFileController : ControllerBase
    {
        private readonly IWebHostEnvironment _environment;

        public UpLoadFileController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        [HttpPost("upload/{folder}")]
        public async Task<IActionResult> Upload(IFormFile file, string folder)
        {
            if (file == null || file.Length == 0)
                return BadRequest("Please select a file.");

            string fileName = file.FileName;
            string extension = Path.GetExtension(fileName);
            string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif" };

            if (!allowedExtensions.Contains(extension))
                return BadRequest("File extension is not allowed.");

            string directoryPath = Path.Combine(_environment.WebRootPath, "images", folder);
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            string filePath = Path.Combine(directoryPath, fileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            // Trả về đường dẫn của ảnh đã tải lên
            string imageUrl = $"/images/{folder}/{fileName}";
            return Ok(new { FilePath = imageUrl });

        }
    }
}
