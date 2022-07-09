using DigitalThinkers.Common.Entities.Models;

namespace CashierService.Models.Errors
{
    public class InvalidDenominationError : BaseEvent
    {
        public InvalidDenominationError(string description)
        {
            base.Title = "Invalid denomination";
            base.Description = description;
        }

        public InvalidDenominationError()
        {
            base.Title = "Invalid denomination";
            base.Description = "Unknown denomination type received";
        }
    }
}
