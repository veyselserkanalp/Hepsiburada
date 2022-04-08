using Hepsiburada.Application.Commands;
using Hepsiburada.Domain.AggregatesModel.CampaignAggregate;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hepsiburada.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CampaignController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        [Route("")]
        public async Task<Campaign> Create(CreateCampaignCommand createCampaignCommand)
        {
            return await _mediator.Send(createCampaignCommand);
        }
    }
}
