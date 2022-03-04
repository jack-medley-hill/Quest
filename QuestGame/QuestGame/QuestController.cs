using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace QuestGame
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return new JsonResult(0);           
        }

    }
}
