using Abp.AspNetCore.Mvc.ViewComponents;

namespace HDI.ExamProject.Web.Views
{
    public abstract class ExamProjectViewComponent : AbpViewComponent
    {
        protected ExamProjectViewComponent()
        {
            LocalizationSourceName = ExamProjectConsts.LocalizationSourceName;
        }
    }
}
