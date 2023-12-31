using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace merchgram.api.Controllers
{
    [Authorize]
    [RequiredScope("merchgram.read")]
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public UserController(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        [HttpGet]
        public ActionResult Index() {
            return Ok("Yo");
        }
    }
}
