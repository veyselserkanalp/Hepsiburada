using Hepsiburada.Domain.AggregatesModel.CampaignAggregate;
using MediatR;
using System;

namespace Hepsiburada.Application.Commands
{
    public class CreateCampaignCommand : IRequest<Campaign>
    {
        public string Name { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPercent { get; set; }
        public int TargetSalesCount { get; set; }
        public decimal PriceManipulationLimit { get; set; }
        public int Duration { get; set; }
    }
}
