using DigitalThinkers.Common.Entities.Enumerations;
using DigitalThinkers.Common.Entities.Models;

namespace DigitalThinkers.CashierService.Models.Errors
{
    public class InconsistentCurrencyTypesError : BaseEvent
    {
        public InconsistentCurrencyTypesError(CurrencyType baseCurrency, CurrencyType inconsistentCurrency)
        {
            base.Title = "Inconsistent Currency Type";
            base.Description = $"Inconsistent currencies provided. Base {baseCurrency}, but found: {inconsistentCurrency}!";
        }
    }
}
