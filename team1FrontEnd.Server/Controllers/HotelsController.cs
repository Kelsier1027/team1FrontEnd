using Microsoft.AspNetCore.Mvc;
using team1FrontEnd.Server.Models;

namespace team1FrontEnd.Server.Controllers
{
    public class HotelsController : Controller
    {
        dbTeam1Context _context;
        public HotelsController(dbTeam1Context context) 
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
