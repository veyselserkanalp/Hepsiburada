using Hepsiburada.Core.Abstraction.Domain.SeedWork;

namespace Hepsiburada.Domain.AggregatesModel.ProductAggregate
{
    public class Product : Entity<int>, IAggregateRoot
    {

        public string ProductCode { get; protected set; }
        public string Name { get; protected set; }
        public int Stock { get; set; }
        public decimal CurrentPrice { get; protected set; }
        public Product(string name, string productCode, int stock, decimal currentPrice)
        {
            Name = name;
            ProductCode = productCode;
            Stock = stock;
            CurrentPrice = currentPrice;
        }

    }
}
