using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace ShopTraning.Web.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("contact-us")]
        public IActionResult ContactUs()
        {
            return View();
        }

        [Route("about-us")]
        public IActionResult AboutUs()
        {
            return View();
        }

    }
}
