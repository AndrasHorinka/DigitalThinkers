using CashierService.Models.Errors;
using DigitalThinkers.CashierService.Models;
using DigitalThinkers.Common.Entities.Models;

namespace DigitalThinkers.CashierService.Validators
{
    public abstract class BaseDenominationValidator : IValidator
    {
        public Result Validate(BaseRequest request)
        {
            var result = new Result();

            if (request.Denominations == null)
            {
                result.Errors.Add(new InvalidDenominationError());
            }

            return result;
        }
    }
}
