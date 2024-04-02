using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace team1FrontEnd.Server.Controllers.Zheng
{
    [Route("api/[controller]")]
    [ApiController]
    public class ECPayOrdersController : ControllerBase
    {
        [HttpPost]
        public IActionResult GetPayInfo()
        {
            return Redirect("https://127.0.0.1:5173/rentcar/success");
        }
    }
}
