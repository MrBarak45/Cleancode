using System.Collections.Generic;

namespace ConsoleApp2.Infra.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public Prices Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public Dictionary<string, string> Details { get; set; }

        
    }
}