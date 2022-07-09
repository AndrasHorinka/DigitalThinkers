using DigitalThinkers.CashierService.Models;
using DigitalThinkers.CashierService.Models.Errors;
using DigitalThinkers.CashierService.Validators;
using DigitalThinkers.Common.Entities;
using DigitalThinkers.Common.Entities.Extensions;
using DigitalThinkers.DataAccess.Main;
using DigitalThinkers.DataAccess.Main.Models;
using System.Collections.Generic;

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
            var result = new CheckoutResult();

            #region Validation

            var validator = new CheckoutValidator();
            var validationResult = validator.Validate(request);
            if (!validationResult.IsSuccessful)
            {
                result.CopyErrorsFrom(validationResult);
                return result;
            }

            var sumProvided = this.GetSumOfProvidedMoney(request.Denominations);
            if (request.Price > sumProvided)
            {
                result.Errors.Add(new InsufficientSumError());
                return result;
            }

            #endregion

            var addedMoney = new List<Money>();

            foreach (var money in request.Denominations.MoneyInTransfer)
            {
                var addMoneyResult = this._dataManager.AddMoney(money);
                if (!addMoneyResult.IsSuccessful)
                {
                    result.CopyErrorsFrom(addMoneyResult);
                    break;
                }

                addedMoney.Add(money);
            }

            if (!result.IsSuccessful)
            {
                this.SubstractMoney(addedMoney);
                return result;
            }

            // Get stock for currency
            GetStockResult stockResult = this._dataManager.GetDenominationsOnStock(request.CurrencyType);
            if (!stockResult.IsSuccessful)
            {
                result.CopyErrorsFrom(stockResult);
                return result;
            }

            var returnAmount = request.Price - sumProvided;
            var tearDownResult = this.TearDownReturnAmountToMoney(returnAmount, stockResult.AvailableStock);
            if (!tearDownResult.IsSuccessful)
            {
                this.SubstractMoney(addedMoney);
                result.CopyErrorsFrom(tearDownResult);

                return result;
            }

            return result;
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
            var validationResult = validator.Validate(request);
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

        #region Private methods

        private decimal GetSumOfProvidedMoney(Denominations denominations)
        {
            decimal result = 0;

            foreach (var money in denominations.MoneyInTransfer)
            {
                result += (int)money.ValueType;
            }

            return result;
        }

        private void SubstractMoney(IList<Money> money)
        {
            throw new System.NotImplementedException();
        }

        private TearDownResult TearDownReturnAmountToMoney(decimal sum, Denominations availableMoney)
        {
            var result = new TearDownResult();



            return result;
        }

        #endregion
    }
}
