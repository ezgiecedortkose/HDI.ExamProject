using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HDI.ExamProject.EntityFrameworkCore
{
    public static class ExamProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ExamProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ExamProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
