using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using HDI.ExamProject.Authorization.Users;
using HDI.ExamProject.Editions;

namespace HDI.ExamProject.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
