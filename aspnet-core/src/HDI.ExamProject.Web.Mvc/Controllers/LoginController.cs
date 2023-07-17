using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HDI.ExamProject.Dealer;
using Microsoft.AspNetCore.Mvc;

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
            var dealers = _dealerAppService.GetAll();
            return View(dealers);
        }

        [HttpPost]
        public IActionResult Login(string username, string password, int dealerId)
        {
            if (username == "admin" && password == "password")
            {
                return RedirectToAction("Sales", "Sales", new { dealerId = dealerId });
            }

            return View("Index");
        }
    }
}

