using System;
using Abp.Domain.Entities;

namespace HDI.ExamProject.Customer.Dto
{
    public class UpdateCustomerDto : Entity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; } 
    }
}

