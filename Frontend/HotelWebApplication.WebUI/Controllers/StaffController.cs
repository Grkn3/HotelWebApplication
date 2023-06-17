using Microsoft.AspNetCore.Mvc;

namespace HotelWebApplication.WebUI.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
