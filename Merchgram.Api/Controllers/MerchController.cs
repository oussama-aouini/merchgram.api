using Merchgram.Application;
using Merchgram.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Merchgram.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MerchController : ControllerBase
    {
        private readonly IMerchService _merchService;
        public MerchController(IMerchService merchService)
        {
            _merchService = merchService;
        }

        [HttpGet]
        public ActionResult<List<Merch>> Get()
        {
            var merches = _merchService.GetAllMerches();
            return Ok(merches);
        }
    }
}
