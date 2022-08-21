using CQRS_Demo.CQRS.Commands;
using CQRS_Demo.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CQRS_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            GetProductByIdQuery query = new GetProductByIdQuery() { Id = id };
            return Ok(await _mediator.Send(query));
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            GetAllProductQuery query = new GetAllProductQuery();
            return Ok(await _mediator.Send(query));
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductCommand createProduct)
        {
            return Ok(await _mediator.Send(createProduct));
        }
    }
}
