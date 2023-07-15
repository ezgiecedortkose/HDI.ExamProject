using System;
using Abp.Domain.Entities;

namespace HDI.ExamProject.Customer.Dto
{
    public class CreateCustomerDto : Entity <Guid>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}

