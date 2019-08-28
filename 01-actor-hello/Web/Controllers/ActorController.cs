using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Web
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ActorController : ControllerBase
    {
        [HttpGet("greetings")]
        public async Task<string> Greetings()
        {
            return $"Hello !";
        }
    }
}
