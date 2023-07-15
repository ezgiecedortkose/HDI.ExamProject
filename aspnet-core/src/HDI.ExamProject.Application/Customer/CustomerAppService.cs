using System;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper.Internal.Mappers;
using System.Collections.Generic;
using System.Threading.Tasks;
using HDI.ExamProject.Entities;
using HDI.ExamProject.Customer.Dto;
using System.Linq;

namespace HDI.ExamProject.Customer
{
    public class CustomerAppService : ApplicationService, ICustomerAppService
    {
        private readonly IRepository<Customers, Guid> _customerRepository;

        public CustomerAppService(IRepository<Customers,Guid> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task CreateCustomer(CreateCustomerDto input)
        {
            var customer = ObjectMapper.Map<Customers>(input);
            await _customerRepository.InsertAsync(customer);
        }

        public async Task UpdateCustomer(UpdateCustomerDto input)
        {
            var customer = await _customerRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, customer);
            await _customerRepository.UpdateAsync(customer);
        }

        public async Task DeleteCustomer(Guid id)
        {
            await _customerRepository.DeleteAsync(id);
        }

        public async Task<CustomerDto> GetCustomer(Guid id)
        {
            var customer = await _customerRepository.GetAsync(id);
            return ObjectMapper.Map<CustomerDto>(customer);
        }

        public async Task<List<CustomerDto>> GetCustomers()
        {
            var customers = await _customerRepository.GetAllListAsync();
            return ObjectMapper.Map<List<CustomerDto>>(customers);
        }

        public List<CustomerDto> GetCustomersByDealerId(Guid dealerId)
        {
            var customers = _customerRepository.GetAll()
                .Where(c => c.DealerId == dealerId)
                .ToList();

            return ObjectMapper.Map<List<CustomerDto>>(customers);
        }

        public CustomerDto GetCustomerByName(string customerName)
        {
            var customer = _customerRepository.GetAll()
                .FirstOrDefault(c => c.Name == customerName);

            return ObjectMapper.Map<CustomerDto>(customer);
        }

    }

}

