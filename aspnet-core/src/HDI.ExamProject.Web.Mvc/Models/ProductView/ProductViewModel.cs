using System;
namespace HDI.ExamProject.Web.Models.ProductView
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public decimal RiskCost { get; set; }
    }

}

