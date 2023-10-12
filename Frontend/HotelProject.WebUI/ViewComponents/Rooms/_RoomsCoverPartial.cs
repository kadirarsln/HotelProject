using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Rooms
{
    public class _RoomsCoverPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
