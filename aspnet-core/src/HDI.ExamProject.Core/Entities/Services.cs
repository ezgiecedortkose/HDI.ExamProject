using System;
using System.Collections.Generic;
using Abp.Domain.Entities;

namespace HDI.ExamProject.Entities
{
	public class Services : Entity<Guid>
	{
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<Products> Products { get; set; }

        public Services()
        {
            Products = new List<Products>();
        }
    }
}

