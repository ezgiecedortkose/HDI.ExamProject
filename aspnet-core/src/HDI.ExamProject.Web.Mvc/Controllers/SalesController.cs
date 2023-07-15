using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HDI.ExamProject.Customer;
using Microsoft.AspNetCore.Mvc;

namespace HDI.ExamProject.Web.Controllers
{
    public class SalesController : Controller
    {
        private readonly ICustomerAppService _customerAppService;

        public SalesController(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

        public IActionResult Sales(Guid dealerId)
        {
            var customers = _customerAppService.GetCustomersByDealerId(dealerId);

            return View(customers);
        }
    }

}

