using System;
namespace HDI.ExamProject.DashboardData.Dto
{
    public class DealerExchangesDto
    {
        public Guid DealerId { get; set; }
        public string DealerName { get; set; }
        public long ExchangeCount { get; set; }
    }
}

