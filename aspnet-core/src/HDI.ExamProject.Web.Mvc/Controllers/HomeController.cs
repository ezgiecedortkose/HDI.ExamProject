using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using HDI.ExamProject.Controllers;

namespace HDI.ExamProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ExamProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
