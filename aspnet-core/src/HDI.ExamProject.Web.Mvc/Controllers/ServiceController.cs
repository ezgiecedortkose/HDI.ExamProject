using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using HDI.ExamProject.Service;
using HDI.ExamProject.Service.Dto;
using Microsoft.AspNetCore.Mvc;

namespace HDI.ExamProject.Web.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceAppService _serviceAppService;

        public ServiceController(IServiceAppService serviceAppService)
        {
            _serviceAppService = serviceAppService;
        }

        public async Task<IActionResult> Index()
        {
            var input = new PagedAndSortedResultRequestDto();
            var serviceCenters = await _serviceAppService.GetAllAsync(input);
            return View(serviceCenters.Items);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateServiceDto input)
        {
            await _serviceAppService.CreateAsync(input);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var service = await _serviceAppService.GetAsync(new EntityDto<Guid>(id));
            return View(service);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateServiceDto input)
        {
            await _serviceAppService.UpdateAsync(input);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _serviceAppService.DeleteAsync(new EntityDto<Guid>(id));
            return RedirectToAction("Index");
        }
    }
}

