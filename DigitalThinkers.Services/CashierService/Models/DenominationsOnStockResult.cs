using DigitalThinkers.Common.Entities;
using DigitalThinkers.Common.Entities.Models;

namespace DigitalThinkers.CashierService.Models
{
    public class DenominationsOnStockResult : Result
    {
        public Denominations DenominationsOnStock { get; set; }

        public DenominationsOnStockResult()
        {
            DenominationsOnStock = new Denominations();
        }
    }
}
