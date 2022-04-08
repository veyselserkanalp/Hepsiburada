using Hepsiburada.Domain.ViewModels;
using MediatR;

namespace Hepsiburada.Application.Queries
{
    public class GetByCampaignIdQuery : IRequest<OrderViewModel>
    {
        public int CampaignId { get; protected set; }

        public GetByCampaignIdQuery(int campaignId)
        {
            CampaignId = campaignId;
        }
    }
}
