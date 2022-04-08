using Hepsiburada.Core.Abstraction.Domain.SeedWork;
using System;

namespace Hepsiburada.Domain.AggregatesModel.CampaignAggregate
{
    public class Campaign : Entity<int>, IAggregateRoot
    {
        public string Name { get; set; }
        public int ProductId { get; set; }
        public int ProductCode { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPercent { get; set; }
        public int Duration { get; set; }
        public int TargetSalesCount { get; set; }
        public decimal PriceManipulationLimit { get; set; }
        public bool IsActive { get; set; }
    }
}
