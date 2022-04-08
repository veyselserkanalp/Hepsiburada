using Hepsiburada.Application.Commands;
using Hepsiburada.Application.Queries;
using Hepsiburada.Domain.AggregatesModel.OrderAggregate;
using Hepsiburada.Domain.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hepsiburada.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        [Route("")]
        public async Task<Order> Create(CreateOrderCommand createOrderCommand)
        {
            return await _mediator.Send(createOrderCommand);
        }

        [HttpGet]
        [Route("{id}/Order")]
        public async Task<OrderViewModel> GetListByCampaignId(int campaignId)
        {
            var response = await _mediator.Send(new GetByCampaignIdQuery(campaignId));
            return response;
        }
    }
}
