using DigitalThinkers.Common.Entities.Models;

namespace CashierService.Models.Errors
{
    public class InvalidDenominationError : BaseEvent
    {
        public InvalidDenominationError(string description)
        {
            base.Title = "Unknown denomination received";
            base.Description = description;
        }
    }
}
