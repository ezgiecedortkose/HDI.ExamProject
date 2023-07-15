using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HDI.ExamProject.EntityFrameworkCore;
using HDI.ExamProject.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace HDI.ExamProject.Web.Tests
{
    [DependsOn(
        typeof(ExamProjectWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ExamProjectWebTestModule : AbpModule
    {
        public ExamProjectWebTestModule(ExamProjectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ExamProjectWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ExamProjectWebMvcModule).Assembly);
        }
    }
}