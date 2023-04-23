using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.UI.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        [Area("Admin")]
        [Route("Admin")]
        [Route("Admin/Home")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
