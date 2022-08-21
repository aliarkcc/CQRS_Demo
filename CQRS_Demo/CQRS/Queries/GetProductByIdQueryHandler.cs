using CQRS_Demo.CQRS.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Demo.CQRS.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdViewModel>
    {
        public Task<GetProductByIdViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            GetProductByIdViewModel viewModel = new GetProductByIdViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Kalem",
            };
            return Task.FromResult(viewModel);
        }
    }
}
