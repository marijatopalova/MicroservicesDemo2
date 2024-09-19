using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatalogService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCatalog()
        {
            return Ok(new { Message = "Catalog Service", Data = new[] { "Item1", "Item2" } });
        }
    }
}
