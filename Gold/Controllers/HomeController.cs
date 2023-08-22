using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Gold.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        #region Errors
        public IActionResult Error404()
        {
            return View("Views/Error/404.cshtml");
        }
        #endregion

    }
}
