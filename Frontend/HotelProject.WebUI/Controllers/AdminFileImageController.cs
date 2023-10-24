using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Net.Http.Headers;

namespace HotelProject.WebUI.Controllers
{
    public class AdminFileImageController : Controller
    {
        [HttpGet]
        public IActionResult AdminFileImageIndex()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AdminFileImageIndex(IFormFile formFile)
        {
            var stream = new MemoryStream();                                                           //Dosya yükleme işlemi 
            await formFile.CopyToAsync(stream);                                                         //Dosyayı ilgili akış üzerinden kopyalıyoruz.
            var bytes = stream.ToArray();                                                               //Akıştaki dosyayı byte olarak tutuyoruz

            ByteArrayContent byteArrayContent = new ByteArrayContent(bytes);
            byteArrayContent.Headers.ContentType = new MediaTypeHeaderValue(formFile.ContentType);                                  //Dosyamızın içerik türünü gönderiyoruz.
            MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
            multipartFormDataContent.Add(byteArrayContent, "formFile", formFile.FileName);                                          //ByteArray gelen değeri yükleriz.
            var httpClient = new HttpClient();
            await httpClient.PostAsync("http://localhost:5240/api/FileImage", multipartFormDataContent);

            return View();
        }
    }
}
