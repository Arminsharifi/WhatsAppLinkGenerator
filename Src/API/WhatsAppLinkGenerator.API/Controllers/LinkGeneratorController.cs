using Microsoft.AspNetCore.Mvc;
using WhatsAppLinkGenerator.API.BLL;
using WhatsAppLinkGenerator.API.Data_Transfer_Objects;

namespace WhatsAppLinkGenerator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinkGeneratorController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> GenerateLink(Link linkDTO)
        {
            if (ModelState.IsValid)
            {
                return new JsonResult(CreateLink.GenerateLink(linkDTO));
            }
            else return BadRequest();
        }
    }
}