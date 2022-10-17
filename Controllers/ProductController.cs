using Microsoft.AspNetCore.Mvc;

namespace OrnekProje.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            return View();
        }
    }
}
