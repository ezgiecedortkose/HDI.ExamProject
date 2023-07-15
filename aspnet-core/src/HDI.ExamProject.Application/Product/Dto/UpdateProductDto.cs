﻿using System;
using Abp.Domain.Entities;

namespace HDI.ExamProject.Product.Dto
{
    public class UpdateProductDto : Entity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public decimal RiskCost { get; set; }
    }
}

