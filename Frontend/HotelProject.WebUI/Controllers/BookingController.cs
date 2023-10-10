using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult BookingIndex()
        {
            return View();
        }
    }
}
