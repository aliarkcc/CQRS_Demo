using CQRS_Demo.CQRS.Models;
using MediatR;
using System;

namespace CQRS_Demo.CQRS.Queries
{
    public class GetProductByIdQuery:IRequest<GetProductByIdViewModel>
    {
        public Guid Id{ get; set; }
    }
}
