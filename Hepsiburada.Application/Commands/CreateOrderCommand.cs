﻿using Hepsiburada.Domain.AggregatesModel.OrderAggregate;
using MediatR;
using System;

namespace Hepsiburada.Application.Commands
{
    public class CreateOrderCommand : IRequest<Order>
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public int? CampaignId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
