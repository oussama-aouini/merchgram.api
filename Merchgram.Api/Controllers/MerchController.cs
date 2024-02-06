using Merchgram.Application;
using Merchgram.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace Merchgram.Api.Controllers
{
    [Authorize]
    [RequiredScope("merchgram.read")]
    [Route("api/[controller]")]
    [ApiController]
    public class MerchController : ControllerBase
    {
        //private readonly IMerchService _merchService;
        //public MerchController(IMerchService merchService)
        //{
        //    _merchService = merchService;
        //}

        [HttpGet]
        public ActionResult Get()
        {
            //var merches = _merchService.GetAllMerches();
            //return Ok(merches);
            return Ok("yo");

        }
    }
}
