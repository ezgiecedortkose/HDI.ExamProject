using System;
namespace HDI.ExamProject.DashboardData.Dto
{
    public class CustomerProfitsDto
    {
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }
        public decimal Profit { get; set; }
    }
}

