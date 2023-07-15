using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using HDI.ExamProject.Controllers;

namespace HDI.ExamProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : ExamProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
