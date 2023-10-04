using HotelProject.WebUI.Dtos.ServiceDto;

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ServiceController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }



        public async Task<IActionResult> ServiceIndex()
        {
            var client = _httpClientFactory.CreateClient();                                          // Consume için istemci oluşturuldu.
            var responseMessage = await client.GetAsync("http://localhost:5240/api/Service");          // Belirtilen adrese istekte bulunuldu.
            if (responseMessage.IsSuccessStatusCode)                                                 // Adresten başarılı durum kodu dönerse ,
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();                    // Gelen veriyi değişkene atadık. (JsonData)
                var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData);          // Deserialize ile tabloda görülecek formata getirdik.
                return View(values);
            }
            return View();
        }
    }
}
