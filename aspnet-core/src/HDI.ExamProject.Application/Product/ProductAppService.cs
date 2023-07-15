using System;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper.Internal.Mappers;
using System.Collections.Generic;
using System.Threading.Tasks;
using HDI.ExamProject.Entities;
using HDI.ExamProject.Product.Dto;

namespace HDI.ExamProject.Product
{
    public class ProductAppService : ApplicationService, IProductAppService
    {
        private readonly IRepository<Products, Guid> _productRepository;

        public ProductAppService(IRepository<Products, Guid> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task CreateProduct(CreateProductDto input)
        {
            var product = ObjectMapper.Map<Products>(input);
            await _productRepository.InsertAsync(product);
        }

        public async Task UpdateProduct(UpdateProductDto input)
        {
            var product = await _productRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, product);
            await _productRepository.UpdateAsync(product);
        }

        public async Task DeleteProduct(Guid id)
        {
            await _productRepository.DeleteAsync(id);
        }

        public async Task<ProductDto> GetProduct(Guid id)
        {
            var product = await _productRepository.GetAsync(id);
            return ObjectMapper.Map<ProductDto>(product);
        }

        public async Task<List<ProductDto>> GetProducts()
        {
            var products = await _productRepository.GetAllListAsync();
            return ObjectMapper.Map<List<ProductDto>>(products);
        }
    }
}

