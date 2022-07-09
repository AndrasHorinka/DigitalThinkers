using DigitalThinkers.Common.Entities.Models;

namespace DigitalTinkers.CashierService.Models.Errors
{
    public class InsufficientFundsError : BaseEvent
    {
        public InsufficientFundsError()
        {
            base.Title = "Insufficient funds";
            base.Description = "Unable to return difference!";
        }
    }
}
