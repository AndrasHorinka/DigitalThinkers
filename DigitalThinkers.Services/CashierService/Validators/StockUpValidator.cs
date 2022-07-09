using CashierService.Models.Errors;
using DigitalThinkers.CashierService.Models;
using DigitalThinkers.Common.Entities.Extensions;
using DigitalThinkers.Common.Entities.Models;
using System.Linq;

namespace DigitalThinkers.CashierService.Validators
{
    public class StockUpValidator : BaseDenominationValidator
    {
        public new Result Validate(BaseRequest request)
        {
            var result = new Result();

            var baseValidationResult = base.Validate(request);
            if (!baseValidationResult.IsSuccessful)
            {
                result.CopyErrorsFrom(baseValidationResult);
                return result;
            }

            if (!request.Denominations.MoneyInTransfer.Any())
            {
                result.Errors.Add(new InvalidDenominationError("No money in transfer"));
                return result;
            }

            return result;
        }
    }
}
