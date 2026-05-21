using Microsoft.AspNetCore.Mvc;

namespace AdvancedRoutingMVC.Controllers
{
    public class DashboardController : Controller
    {
        // Dynamic routing based on role
        public IActionResult Index(string role)
        {
            if (role?.ToLower() == "admin")
            {
                return Content("Welcome Admin Dashboard");
            }

            return Content("Welcome User Dashboard");
        }
    }
}