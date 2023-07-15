using System;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using HDI.ExamProject.DashboardData.Dto;
using HDI.ExamProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace HDI.ExamProject.DashboardData
{
    public class DashboardDataAppService : ApplicationService, IDashboardDataAppService
    {
        private readonly IRepository<Products, Guid> _productRepository;
        private readonly IRepository<Dealers, Guid> _dealerRepository;
        private readonly IRepository<Customers, Guid> _customerRepository;
        private readonly IRepository<Services, Guid> _servicesRepository;

        public DashboardDataAppService(
            IRepository<Products, Guid> productRepository,
            IRepository<Dealers, Guid> dealerRepository,
            IRepository<Customers, Guid> customerRepository,
            IRepository<Services, Guid> servicesRepository)
        {
            _productRepository = productRepository;
            _dealerRepository = dealerRepository;
            _customerRepository = customerRepository;
            _servicesRepository = servicesRepository;
        }

        public async Task<DashboardDataDto> GetDashboardData()
        {
            var dashboardData = new DashboardDataDto();

            var productSales = await _productRepository.GetAll()
                .Select(p => new ProductSalesDto
                {
                    ProductId = p.Id,
                    ProductName = p.Name,
                    SalesCount = p.Customers.Count,
                    TotalRevenue = p.Customers.Sum(c => c.Products.Where(cp => cp.Id == p.Id).Sum(cp => cp.Price))
                })
                .ToListAsync();

            dashboardData.ProductSales = productSales;

            var serviceRepairs = await _servicesRepository.GetAll()
                .Select(s => new ServiceRepairsDto
                {
                    ServiceRepairId = s.Id,
                    ServiceRepairName = s.Name,
                    RepairCount = s.Products.Sum(p => p.RepairCount)
                })
                .ToListAsync();

            dashboardData.ServiceCenterRepairs = serviceRepairs;

            var dealerExchanges = await _dealerRepository.GetAll()
                .Select(d => new DealerExchangesDto
                {
                    DealerId = d.Id,
                    DealerName = d.Name,
                    ExchangeCount = d.Products.Sum(p => p.ExchangeCount)
                })
                .ToListAsync();

            dashboardData.DealerExchanges = dealerExchanges;

            var productRisks = await _productRepository.GetAll()
                .Select(p => new ProductRisksDto
                {
                    ProductId = p.Id,
                    ProductName = p.Name,
                    RiskCost = p.RiskCost
                })
                .ToListAsync();

            dashboardData.ProductRisks = productRisks;

            var customerProfits = await _customerRepository.GetAll()
                .Select(c => new CustomerProfitsDto
                {
                    CustomerId = c.Id,
                    CustomerName = c.Name,
                    Profit = c.Products.Sum(p => p.Price - p.CostPrice)
                })
                .ToListAsync();

            dashboardData.CustomerProfits = customerProfits;

            return dashboardData;
        }
    }

}

