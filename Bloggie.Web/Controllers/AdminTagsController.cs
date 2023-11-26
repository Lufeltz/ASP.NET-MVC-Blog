using Microsoft.AspNetCore.Mvc;

namespace Bloggie.Web.Controllers
{
    public class AdminTagsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
