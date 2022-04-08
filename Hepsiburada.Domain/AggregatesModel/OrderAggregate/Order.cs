using Hepsiburada.Core.Abstraction.Domain.SeedWork;
using System;

namespace Hepsiburada.Domain.AggregatesModel.OrderAggregate
{
    public class Order : Entity<int>, IAggregateRoot
    {
        private int stock;

        public Order(decimal unitPrice, decimal totalPrice, decimal discount, int? campaignId, int productId, string productCode, int stock)
        {
            UnitPrice = unitPrice;
            TotalPrice = totalPrice;
            Discount = discount;
            CampaignId = campaignId;
            ProductId = productId;
            ProductCode = productCode;
            this.stock = stock;
        }

        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int? CampaignId { get; set; }
        public decimal Discount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int Quantity { get; set; }
    }
}
