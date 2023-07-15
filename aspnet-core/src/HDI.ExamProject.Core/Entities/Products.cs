using System;
using System.Collections.Generic;
using Abp.Domain.Entities;

namespace HDI.ExamProject.Entities
{
	public class Products : Entity<Guid>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public decimal RiskCost { get; set; }

        public long RepairCount { get; set; }
        public long ExchangeCount { get; set; }
        public decimal CostPrice { get; set; }

        public ICollection<Customers> Customers { get; set; }
        public ICollection<Dealers> Dealers { get; set; }
        public ICollection<Services> Services { get; set; }

        public Products()
        {
            Customers = new List<Customers>();
            Dealers = new List<Dealers>();
            Services = new List<Services>();
        }
    }
}

