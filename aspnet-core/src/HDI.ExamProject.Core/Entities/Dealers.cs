using System;
using Castle.Core;
using System.Collections.Generic;
using Abp.Domain.Entities;

namespace HDI.ExamProject.Entities
{
	public class Dealers : Entity<Guid>
	{
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public long ExchangeCount { get; set; }

        public ICollection<Products> Products { get; set; }

        public Dealers()
        {
            Products = new List<Products>();
        }
    }
}

