using CQRS_Demo.CQRS.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Demo.CQRS.Queries
{
    public class GetAllProductHandler : IRequestHandler<GetAllProductQuery, List<GetAllProductViewModel>>
    {
        public Task<List<GetAllProductViewModel>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            List<GetAllProductViewModel> model = new List<GetAllProductViewModel>()
            {
                new GetAllProductViewModel() { Id = Guid.NewGuid(), Name = "HardDisk" },
                new GetAllProductViewModel() { Id = Guid.NewGuid(), Name = "Laptop" }
            };
            return Task.FromResult(model);
        }
    }
}
