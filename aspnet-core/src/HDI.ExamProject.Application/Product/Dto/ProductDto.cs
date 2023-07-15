using System;
using System.Collections.Generic;
using Abp.Domain.Entities;
using HDI.ExamProject.Customer.Dto;
using HDI.ExamProject.Dealer.Dto;
using HDI.ExamProject.Service.Dto;

namespace HDI.ExamProject.Product.Dto
{
    public class ProductDto : Entity<Guid>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public decimal RiskCost { get; set; }

        public ICollection<CustomerDto> Customers { get; set; }
        public ICollection<DealerDto> Dealers { get; set; }
        public ICollection<ServiceDto> Services { get; set; }
    }

}

