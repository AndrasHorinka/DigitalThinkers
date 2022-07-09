using CashierService.Models.Errors;
using DigitalThinkers.Common.Entities;
using DigitalThinkers.Common.Entities.Models;

namespace DigitalThinkers.CashierService.Validators
{
    public class BaseDenominationValidator : IValidator
    {
        public Result Validate(Denominations denominations)
        {
            var result = new Result();

            if (denominations == null)
            {
                result.Errors.Add(new InvalidDenominationError());
            }

            return result;
        }
    }
}
