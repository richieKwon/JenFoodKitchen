using System.Collections.Generic;

namespace JenKitchen.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Food> Foods  { get; set; }
    }
}