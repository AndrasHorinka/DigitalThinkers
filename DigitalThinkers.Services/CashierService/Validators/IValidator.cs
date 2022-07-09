using DigitalThinkers.Common.Entities;
using DigitalThinkers.Common.Entities.Models;

namespace DigitalThinkers.CashierService.Validators
{
    public interface IValidator
    {
        Result Validate(Denominations denominations);
    }
}
