using Microsoft.AspNetCore.Mvc;

namespace linebotApp.Controllers
{
    [ApiController]
    [Route("api/linebot")]
    public class LineBotController : Controller
    {
        private readonly string channelAccessToken = "";
        private readonly string channelSecret = "";

        [HttpPost("Webhook")]
        public IActionResult Webhook()
        {
            return Ok();
        }
    }
}
