using DigitalThinkers.Common.Entities;
using DigitalThinkers.Common.Entities.Models;

namespace DigitalThinkers.CashierService.Models
{
    public class CheckoutResult : Result
    {
        public Denominations Denominations { get; set; }
    }
}
