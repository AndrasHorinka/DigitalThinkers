using DigitalThinkers.Common.Entities.Models;

namespace DigitalThinkers.CashierService.Models.Errors
{
    public class InsufficientSumError : BaseEvent
    {
        public InsufficientSumError()
        {
            base.Title = "Insufficient sum provided";
        }
    }
}
