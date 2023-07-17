using System;
using HDI.ExamProject.DashboardData.Dto;
using System.Collections.Generic;

namespace HDI.ExamProject.Web.Models.DashboardDataView
{
    public class DashboardDataViewModel
    {
        public List<ProductSalesViewModel> ProductSales { get; set; }
        public List<ServiceCenterRepairsViewModel> ServiceCenterRepairs { get; set; }
    }

    public class ProductSalesViewModel
    {
        public string ProductName { get; set; }
        public int SalesCount { get; set; }
        public decimal TotalRevenue { get; set; }
    }

    public class ServiceCenterRepairsViewModel
    {
        public string ServiceCenterName { get; set; }
        public int RepairCount { get; set; }
    }

}

