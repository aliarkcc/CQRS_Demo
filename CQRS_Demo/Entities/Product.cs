using System;

namespace CQRS_Demo.Entities
{
    public class Product
    {
        public Guid Id{ get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Amount{ get; set; }
        public DateTime CreateDate { get; set; }
    }
}
