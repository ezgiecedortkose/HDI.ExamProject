using System;
using System.Collections.Generic;

namespace HDI.ExamProject.DashboardData.Dto
{
    public class DashboardDataDto
    {
        public List<ProductSalesDto> ProductSales { get; set; }
        public List<ServiceRepairsDto> ServiceCenterRepairs { get; set; }
        public List<DealerExchangesDto> DealerExchanges { get; set; }
        public List<ProductRisksDto> ProductRisks { get; set; }
        public List<CustomerProfitsDto> CustomerProfits { get; set; }
    }
}


