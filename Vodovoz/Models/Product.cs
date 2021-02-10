namespace Vodovoz.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int OrderId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}