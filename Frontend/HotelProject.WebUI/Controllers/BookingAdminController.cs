using HotelProject.WebUI.Dtos.BookingDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace HotelProject.WebUI.Controllers
{
    public class BookingAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> BookingAdminIndex()
        {
            var client = _httpClientFactory.CreateClient();                                          // Consume için istemci oluşturuldu.
            var responseMessage = await client.GetAsync("http://localhost:5240/api/Booking");          // Belirtilen adrese istekte bulunuldu.
            if (responseMessage.IsSuccessStatusCode)                                                 // Adresten başarılı durum kodu dönerse ,
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();                    // Gelen veriyi değişkene atadık. (JsonData)
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);          // Deserialize ile tabloda görülecek formata getirdik.
                return View(values);
            }
            return View();
        }
    }
}
