using DigitalThinkers.Common.Entities.Enumerations;

namespace DigitalThinkers.CashierService.Models
{
    public class CheckoutRequest : BaseRequest
    {
        public decimal Price { get; set; }
        public CurrencyType CurrencyType { get; set; }
    }
}
