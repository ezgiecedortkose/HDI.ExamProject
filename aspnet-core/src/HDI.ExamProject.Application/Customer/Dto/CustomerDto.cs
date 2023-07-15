using System;
using System.Collections.Generic;
using Abp.Domain.Entities;
using HDI.ExamProject.Product.Dto;

namespace HDI.ExamProject.Customer.Dto
{
    public class CustomerDto : Entity<Guid>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CustomerRegistrationDate { get; set; }
        public List<ProductDto> CustomerProductsPurchased { get; set; }

        public ICollection<ProductDto> Products { get; set; }

    }
}

