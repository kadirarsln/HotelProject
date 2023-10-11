﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiJwt.Models;

namespace WebApiJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        //403 hatası dönüyor yetkiden dolayı.
        [HttpGet("[action]")]
        public IActionResult TokenOluştur()
        {
            return Ok(new CreateToken().Create());
        }
        //Admin Token Oluşturuldu.
        [HttpGet("[action]")]
        public IActionResult AdminTokenOluştur()
        {
            return Ok(new CreateToken().TokenCreateAdmin());
        }

        [Authorize]
        [HttpGet("[action]")]
        public IActionResult Get2()
        {
            return Ok("Hoşgeldiniz");
        }

        [Authorize(Roles = "Admin,Visitor")]
        [HttpGet("[action]")]
        public IActionResult Get3()
        {
            return Ok("Token Başarılı Bir Şekilde Giriş Yaptı");
        }
    }
}
