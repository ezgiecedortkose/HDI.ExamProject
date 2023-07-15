using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HDI.ExamProject.Dealer;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HDI.ExamProject.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly IDealerAppService _dealerAppService;

        public LoginController(IDealerAppService dealerAppService)
        {
            _dealerAppService = dealerAppService;
        }

        public IActionResult Index()
        {
            var dealers = _dealerAppService.GetAll(); // Tüm bayileri getir

            // Login sayfasına dealers'ı ve diğer gerekli verileri gönder
            return View(dealers);
        }

        [HttpPost]
        public IActionResult Login(string username, string password, int dealerId)
        {
            // Kullanıcı adı, şifre ve bayi seçimini kontrol et
            if (username == "admin" && password == "password")
            {
                // Doğrulama işlemlerini yap ve giriş işlemini gerçekleştir

                // Başarılı giriş durumunda, bayiye özel satış paneline yönlendir
                return RedirectToAction("Sales", "Sales", new { dealerId = dealerId });
            }

            // Giriş başarısız olduğunda, hata mesajı göster veya tekrar login sayfasına yönlendir
            return View("Index");
        }
    }
}

