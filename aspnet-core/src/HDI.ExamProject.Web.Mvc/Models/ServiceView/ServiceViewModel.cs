using System;
using HDI.ExamProject.Web.Models.ProductView;
using System.Collections.Generic;

namespace HDI.ExamProject.Web.Models.ServiceView
{
    public class ServiceViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public List<ProductViewModel> Products { get; set; }
    }

}

