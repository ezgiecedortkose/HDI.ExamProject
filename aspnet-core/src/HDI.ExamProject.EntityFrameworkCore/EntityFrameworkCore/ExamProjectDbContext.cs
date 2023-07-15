using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HDI.ExamProject.Authorization.Roles;
using HDI.ExamProject.Authorization.Users;
using HDI.ExamProject.MultiTenancy;

namespace HDI.ExamProject.EntityFrameworkCore
{
    public class ExamProjectDbContext : AbpZeroDbContext<Tenant, Role, User, ExamProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ExamProjectDbContext(DbContextOptions<ExamProjectDbContext> options)
            : base(options)
        {
        }
    }
}
