using Microsoft.AspNetCore.Mvc;

namespace ShopTraning.Web.Controllers
{
    public class ProductController : Controller
    {
        [Route("product-list")]
        public IActionResult ProductList()
        {
            return View();
        }
    }
}
