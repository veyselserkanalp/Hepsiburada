using Hepsiburada.Domain.AggregatesModel.ProductAggregate;
using MediatR;

namespace Hepsiburada.Application.Commands
{
    public class CreateProductCommand : IRequest<Product>
    {
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public int Stock { get; set; }
        public decimal CurrentPrice { get; set; }
    }
}