using DigitalThinkers.Common.Entities;
using DigitalThinkers.Common.Entities.Models;

namespace DigitalThinkers.CashierService.Models
{
    public class DenominationsLoadResult : Result
    {
        public Denominations DenominationsLoaded { get; set; }
        public Denominations DenominationsFailedToLoad { get; set; }

        public DenominationsLoadResult()
        {
            DenominationsLoaded = new Denominations();
            DenominationsFailedToLoad = new Denominations();
        }
    }
}
