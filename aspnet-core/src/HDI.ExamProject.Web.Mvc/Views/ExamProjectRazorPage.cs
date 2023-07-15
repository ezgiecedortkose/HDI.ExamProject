using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace HDI.ExamProject.Web.Views
{
    public abstract class ExamProjectRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ExamProjectRazorPage()
        {
            LocalizationSourceName = ExamProjectConsts.LocalizationSourceName;
        }
    }
}
