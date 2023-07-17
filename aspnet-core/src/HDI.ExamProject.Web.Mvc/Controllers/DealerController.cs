using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Controllers;
using HDI.ExamProject.Controllers;
using HDI.ExamProject.Dealer;
using HDI.ExamProject.Dealer.Dto;
using Microsoft.AspNetCore.Mvc;

namespace HDI.ExamProject.Web.Controllers
{
    public class DealerController : ExamProjectControllerBase
    {
        private readonly IDealerAppService _dealerAppService;

        public DealerController(IDealerAppService dealerAppService)
        {
            _dealerAppService = dealerAppService;
        }

        public async Task<IActionResult> Index()
        {
            var input = new PagedAndSortedResultRequestDto();
            var dealers = await _dealerAppService.GetAllAsync(input);
            return View(dealers.Items);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateDealerDto input)
        {
            await _dealerAppService.CreateAsync(input);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var dealer = await _dealerAppService.GetAsync(new EntityDto<Guid>(id));
            return View(dealer);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(UpdateDealerDto input)
        {
            await _dealerAppService.UpdateAsync(input);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _dealerAppService.DeleteAsync(new EntityDto<Guid>(id));
            return RedirectToAction("Index");
        }
    }

}

