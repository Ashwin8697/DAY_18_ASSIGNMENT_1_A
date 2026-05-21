using Microsoft.AspNetCore.Mvc;

namespace AdvancedRoutingMVC.Controllers
{
    public class ProductsController : Controller
    {
        // Route: /Products/{category}/{id}
        public IActionResult Details(string category, int id)
        {
            ViewBag.Category = category;
            ViewBag.Id = id;

            return View();
        }
    }
}