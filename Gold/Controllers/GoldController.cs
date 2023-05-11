using Gold.Infrastructure.GoldDbContext;
using Microsoft.AspNetCore.Mvc;

namespace Gold.UI.Controllers
{
    public class GoldController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GoldController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}
