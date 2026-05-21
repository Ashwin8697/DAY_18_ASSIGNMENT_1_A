using Microsoft.AspNetCore.Mvc;

namespace AdvancedRoutingMVC.Controllers
{
    public class DocumentsController : Controller
    {
        // Route with GUID constraint
        public IActionResult Details(Guid id)
        {
            return Content($"Valid GUID received: {id}");
        }
    }
}