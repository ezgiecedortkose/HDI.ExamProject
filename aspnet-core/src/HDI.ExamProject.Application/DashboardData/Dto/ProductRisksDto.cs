using System;
namespace HDI.ExamProject.DashboardData.Dto
{
    public class ProductRisksDto
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal RiskCost { get; set; }
    }
}

