using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HDI.ExamProject.Authorization.Roles;
using HDI.ExamProject.Authorization.Users;
using HDI.ExamProject.MultiTenancy;
using HDI.ExamProject.Entities;

namespace HDI.ExamProject.EntityFrameworkCore
{
    public class ExamProjectDbContext : AbpZeroDbContext<Tenant, Role, User, ExamProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Products> Products { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Dealers> Dealers { get; set; }
        public DbSet<Services> Services { get; set; }

        public ExamProjectDbContext(DbContextOptions<ExamProjectDbContext> options)
            : base(options)
        {
        }
    }
}
