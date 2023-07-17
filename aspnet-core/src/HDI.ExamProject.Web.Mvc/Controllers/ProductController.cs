using System;
using HDI.ExamProject.Controllers;
using HDI.ExamProject.Product;
using HDI.ExamProject.Product.Dto;
using Microsoft.AspNetCore.Mvc;

namespace HDI.ExamProject.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ExamProjectControllerBase
    {
        private readonly IProductAppService _productAppService;

        public ProductController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _productAppService.GetProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(Guid id)
        {
            var product = _productAppService.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto input)
        {
            var productId = _productAppService.CreateProduct(input);
            return CreatedAtAction(nameof(GetProduct), new { id = productId }, input);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(Guid id, UpdateProductDto input)
        {
            input.Id = id;
            _productAppService.UpdateProduct(input);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(Guid id)
        {
            _productAppService.DeleteProduct(id);
            return NoContent();
        }
    }
}

