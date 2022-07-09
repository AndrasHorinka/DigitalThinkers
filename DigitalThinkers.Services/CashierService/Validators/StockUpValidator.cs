using CashierService.Models.Errors;
using DigitalThinkers.Common.Entities;
using DigitalThinkers.Common.Entities.Extensions;
using DigitalThinkers.Common.Entities.Models;
using System.Linq;

namespace DigitalThinkers.CashierService.Validators
{
    public class StockUpValidator : BaseDenominationValidator
    {
        public Result Validate(Denominations denominations)
        {
            var result = new Result();

            var baseValidationResult = base.Validate(denominations);
            if (!baseValidationResult.IsSuccessful)
            {
                result.CopyErrorsFrom(baseValidationResult);
                return result;
            }

            if (!denominations.MoneyInTransfer.Any())
            {
                result.Errors.Add(new InvalidDenominationError("No money in transfer"));
                return result;
            }

            return result;
        }
    }
}
