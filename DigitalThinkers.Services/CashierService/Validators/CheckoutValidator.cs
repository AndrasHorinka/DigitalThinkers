using DigitalThinkers.CashierService.Models;
using DigitalThinkers.CashierService.Models.Errors;
using DigitalThinkers.Common.Entities.Extensions;
using DigitalThinkers.Common.Entities.Models;
using System.Linq;

namespace DigitalThinkers.CashierService.Validators
{
    public class CheckoutValidator : BaseDenominationValidator
    {
        public Result Validate(CheckoutRequest request)
        {
            var result = new Result();

            var baseValidationResult = base.Validate(request);
            if (!baseValidationResult.IsSuccessful)
            {
                result.CopyErrorsFrom(baseValidationResult);
                return result;
            }

            if (request.Price == 0)
            {
                result.Errors.Add(new InvalidPriceError());
                return result;
            }

            foreach (var money in request.Denominations.MoneyInTransfer)
            {
                if (money.CurrencyType != request.CurrencyType)
                {
                    result.Errors.Add(new InconsistentCurrencyTypesError(request.CurrencyType, money.CurrencyType));
                    return result;
                }
            }

            return result;
        }
    }
}