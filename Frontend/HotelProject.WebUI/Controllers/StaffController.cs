using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult StaffIndex()
        {
            return View();
        }
    }
}
