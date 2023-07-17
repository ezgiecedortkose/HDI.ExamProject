using System.Threading.Tasks;
using HDI.ExamProject.Controllers;
using HDI.ExamProject.DashboardData;
using HDI.ExamProject.DashboardData.Dto;
using Microsoft.AspNetCore.Mvc;
namespace HDI.ExamProject.Web.Controllers
{
    public class DashboardDataController : ExamProjectControllerBase
    {
        private readonly IDashboardDataAppService _dashboardDataService;

        public DashboardDataController(IDashboardDataAppService dashboardDataService)
        {
            _dashboardDataService = dashboardDataService;
        }

        [HttpGet]
        public async Task<ActionResult<DashboardDataDto>> GetDashboardData()
        {
            var dashboardData = await _dashboardDataService.GetDashboardData();
            return Ok(dashboardData);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

