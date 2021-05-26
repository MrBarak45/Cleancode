using System;

namespace ConsoleApp2.Infra.Entities
{
    public class SellHistory
    {
        public User User { get; set; }
        public Product Product  { get; set; }
        public DateTime SellDate { get; set; }
    }
}