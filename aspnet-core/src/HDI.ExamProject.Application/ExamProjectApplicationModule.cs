using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HDI.ExamProject.Authorization;

namespace HDI.ExamProject
{
    [DependsOn(
        typeof(ExamProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ExamProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ExamProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ExamProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
