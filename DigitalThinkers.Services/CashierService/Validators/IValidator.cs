using DigitalThinkers.CashierService.Models;
using DigitalThinkers.Common.Entities.Models;

namespace DigitalThinkers.CashierService.Validators
{
    public interface IValidator
    {
        Result Validate(BaseRequest request);
    }
}
