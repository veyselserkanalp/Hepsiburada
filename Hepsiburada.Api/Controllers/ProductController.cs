using Hepsiburada.Application.Commands;
using Hepsiburada.Application.Queries;
using Hepsiburada.Domain.AggregatesModel.ProductAggregate;
using Hepsiburada.Domain.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hepsiburada.Api.Controllers
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
        [HttpPost]
        [Route("")]
        public async Task<Product> Create(CreateProductCommand createProductCommand)
        {
            return await _mediator.Send(createProductCommand);
        }
        [HttpGet]
        [Route("{productCode}/Product")]
        public async Task<ProductViewModel> GetByCode(string productCode)
        {
            var product = await _mediator.Send(new GetByCodeQuery(productCode));
            return product;
        }
        [HttpGet]
        [Route("{id}/Product")]
        public async Task<ProductViewModel> GetById(int productId)
        {
            var product = await _mediator.Send(new GetByProductIdQuery(productId));
            return product;
        }
    }
}
