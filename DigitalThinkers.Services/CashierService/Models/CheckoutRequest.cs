using DigitalThinkers.Common.Entities;

namespace DigitalThinkers.CashierService.Models
{
    public class CheckoutRequest
    {
        public Denominations Denominations { get; set; }
        public decimal Price { get; set; }
    }
}
