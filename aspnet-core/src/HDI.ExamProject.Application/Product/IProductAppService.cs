using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using HDI.ExamProject.Product.Dto;

namespace HDI.ExamProject.Product
{
    public interface IProductAppService : IApplicationService
    {
        Task CreateProduct(CreateProductDto input);
        Task UpdateProduct(UpdateProductDto input);
        Task DeleteProduct(Guid id);
        Task<ProductDto> GetProduct(Guid id);
        Task<List<ProductDto>> GetProducts();
    }
}
