using System;
using Abp.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using HDI.ExamProject.Customer.Dto;

namespace HDI.ExamProject.Customer
{
    public interface ICustomerAppService : IApplicationService
    {
        Task CreateCustomer(CreateCustomerDto input);
        Task UpdateCustomer(UpdateCustomerDto input);
        Task DeleteCustomer(Guid id);
        Task<CustomerDto> GetCustomer(Guid id);
        Task<List<CustomerDto>> GetCustomers();
        List<CustomerDto> GetCustomersByDealerId(Guid dealerId);
        CustomerDto GetCustomerByName(string customerName);
    }
}

