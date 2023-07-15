using System;
using Abp.Domain.Entities;

namespace HDI.ExamProject.Dealer.Dto
{
	public class CreateDealerDto : Entity<Guid>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}

