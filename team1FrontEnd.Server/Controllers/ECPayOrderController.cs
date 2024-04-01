using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace team1FrontEnd.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ECPayOrderController : ControllerBase
    {
        [HttpPost]
        public IActionResult GetPayInfo()
        {
            return Redirect("https://127.0.0.1:5173/rentCar/success");
        }
    }
}
