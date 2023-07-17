using System;
using System.Collections.Generic;
using HDI.ExamProject.Web.Models.ProductView;

namespace HDI.ExamProject.Web.Models.DealerView
{
    public class DealerViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public List<ProductViewModel> Products { get; set; }
    }

}

