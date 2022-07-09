using DigitalThinkers.Common.Entities.Models;

namespace DigitalThinkers.CashierService.Models.Errors
{
    public class InvalidPriceError : BaseEvent
    {
        public InvalidPriceError()
        {
            base.Title = "Invalid price";
            base.Description = "Invalid price provided for checkout!";
        }
    }
}
