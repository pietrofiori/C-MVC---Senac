using SenacStore.Models.Enums;

namespace SenacStore.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Amount { get; set; }
        public SaleStatus Status { get; set; }
        public int SallerId { get; set; }
        public Seller Seller { get; set; }
    }
}
