using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Gold.UI.Controllers
{
    [Authorize]
    public class TicketController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
    }
}
