using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace demo_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        [HttpGet]
        [Route("list-all")]
        public async Task<IActionResult> ListAllAsync()
        {
            return Ok("Hello");
        }
    }
}
