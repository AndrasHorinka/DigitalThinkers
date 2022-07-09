using DigitalThinkers.CashierService.Models;
using DigitalThinkers.CashierService.Validators;
using DigitalThinkers.Common.Entities.Extensions;
using DigitalThinkers.DataAccess.Main;
using DigitalThinkers.DataAccess.Main.Models;
using System;
using System.Linq;

namespace DigitalThinkers.CashierService
{
    public class CashierService : ICashierService
    {
        private IDataManager _dataManager;

        public CashierService(IDataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public CheckoutResult Checkout(CheckoutRequest request)
        {
            throw new NotImplementedException();
        }

        public DenominationsOnStockResult GetDenominationsOnStock()
        {
            var result = new DenominationsOnStockResult();

            GetStockResult stockResult = this._dataManager.GetDenominationsOnStock();
            if (!stockResult.IsSuccessful)
            {
                result.CopyErrorsFrom(stockResult);
                return result;
            }

            foreach (var money in stockResult.AvailableStock.MoneyInTransfer)
            {
                result.DenominationsOnStock.MoneyInTransfer.Add(money);
            }

            return result;
        }

        public DenominationsLoadResult StockUpDenominations(DenominationsLoadRequest request)
        {
            var result = new DenominationsLoadResult();

            var validator = new StockUpValidator();
            var validationResult = validator.Validate(request.Denominations);
            if (!validationResult.IsSuccessful)
            {
                result.CopyErrorsFrom(validationResult);
                return result;
            }

            foreach (var money in request.Denominations.MoneyInTransfer)
            {
                var addMoneyResult = this._dataManager.AddMoney(money);
                if (!addMoneyResult.IsSuccessful)
                {
                    result.CopyErrorsFrom(addMoneyResult);
                    result.DenominationsFailedToLoad.MoneyInTransfer.Add(money);
                }
                else
                {
                    result.DenominationsLoaded.MoneyInTransfer.Add(money);
                }
            }

            return result;
        }
    }
}
