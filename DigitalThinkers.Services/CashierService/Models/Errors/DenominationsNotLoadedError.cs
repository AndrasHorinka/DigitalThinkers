using DigitalThinkers.Common.Entities.Models;

namespace DigitalThinkers.CashierService.Models.Errors
{
    public class DenominationsNotLoadedError : BaseEvent
    {
        public DenominationsNotLoadedError()
        {
            base.Title = "Denominations load error";
            base.Description = "Some denominations could not be loaded$";
        }
    }
}
