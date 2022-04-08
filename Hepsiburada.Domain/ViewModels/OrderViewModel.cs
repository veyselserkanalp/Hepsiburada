namespace Hepsiburada.Domain.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public int Stock { get; set; }
        public decimal CurrentPrice { get; set; }
    }
}
