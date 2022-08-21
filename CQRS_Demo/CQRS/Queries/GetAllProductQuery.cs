using CQRS_Demo.CQRS.Models;
using MediatR;
using System.Collections.Generic;

namespace CQRS_Demo.CQRS.Queries
{
    public class GetAllProductQuery:IRequest<List<GetAllProductViewModel>>
    {

    }
}
