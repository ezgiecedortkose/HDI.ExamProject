using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HDI.ExamProject.Controllers;
using HDI.ExamProject.Customer;
using HDI.ExamProject.Customer.Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HDI.ExamProject.Web.Controllers
{
    public class CustomerController : ExamProjectControllerBase
    {
        private readonly ICustomerAppService _customerAppService;

        public CustomerController(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            var customers = _customerAppService.GetCustomers();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomer(Guid id)
        {
            var customer = _customerAppService.GetCustomer(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpPost]
        public IActionResult CreateCustomer(CreateCustomerDto input)
        {
            var customerId = _customerAppService.CreateCustomer(input);
            return CreatedAtAction(nameof(GetCustomer), new { id = customerId }, input);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCustomer(Guid id, UpdateCustomerDto input)
        {
            input.Id = id;
            _customerAppService.UpdateCustomer(input);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(Guid id)
        {
            _customerAppService.DeleteCustomer(id);
            return NoContent();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

