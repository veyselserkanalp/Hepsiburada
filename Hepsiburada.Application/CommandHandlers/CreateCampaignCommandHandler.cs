using Hepsiburada.Application.Commands;
using Hepsiburada.Core.Abstraction.Data;
using Hepsiburada.Domain.AggregatesModel.CampaignAggregate;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hepsiburada.Application.CommandHandlers
{
    public class CreateCampaignCommandHandler : IRequestHandler<CreateCampaignCommand, Campaign>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMediator _mediator;

        public CreateCampaignCommandHandler(IUnitOfWork unitOfWork, IMediator mediator)
        {
            _unitOfWork = unitOfWork;
            _mediator = mediator;
        }
        public async Task<Campaign> Handle(CreateCampaignCommand request, CancellationToken cancellationToken)
        {


            return null;
        }
    }
}
