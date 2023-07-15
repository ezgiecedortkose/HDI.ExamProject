using System;
namespace HDI.ExamProject.DashboardData.Dto
{
    public class ProductSalesDto
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public int SalesCount { get; set; }
        public decimal TotalRevenue { get; set; }
    }
}

