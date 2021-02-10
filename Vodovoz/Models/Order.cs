using System;

namespace Vodovoz.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Contractor { get; set; }
        public DateTime OrderTime { get; set; }
        public int WorkerId { get; set; }
    }
}