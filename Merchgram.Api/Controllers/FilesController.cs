using Microsoft.AspNetCore.Mvc;

namespace service.files.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilesController : ControllerBase
    {
        private readonly FileService _fileService;

        public FilesController(FileService fileService)
        {
            _fileService = fileService;
        }

        [HttpGet]
        public async Task<IActionResult> ListProfilePosts()
        {
            var result = await _fileService.ListAsync();
            return Ok(result);
        }

        //[HttpGet]
        //public async Task<IActionResult> ListFollowedProfilesPosts()
        //{
        //    return Ok();
        //}

        [HttpPost]
        public async Task<IActionResult> CreatePost(IFormFile file)
        {
            var result = await _fileService.UploadAsync(file);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePost()
        {
            return Ok();
        }
    }
}
