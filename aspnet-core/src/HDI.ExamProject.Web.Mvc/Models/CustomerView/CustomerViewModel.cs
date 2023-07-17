using System;
using HDI.ExamProject.Web.Models.ProductView;
using System.Collections.Generic;

namespace HDI.ExamProject.Web.Models.CustomerView
{
    public class CustomerViewModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CustomerRegistrationDate { get; set; }
        public List<ProductViewModel> CustomerProductsPurchased { get; set; }
        public List<ProductViewModel> Products { get; set; }
    }

}

