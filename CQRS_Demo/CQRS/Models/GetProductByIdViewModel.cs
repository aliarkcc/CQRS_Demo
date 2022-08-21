using System;

namespace CQRS_Demo.CQRS.Models
{
    public class GetProductByIdViewModel
    {
        public Guid Id{ get; set; }
        public string Name{ get; set; }
    }
}
