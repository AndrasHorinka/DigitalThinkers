using DigitalThinkers.CashierService.Models;
using DigitalThinkers.Common.Entities.Extensions;
using DigitalThinkers.DataAccess.Main;
using DigitalThinkers.DataAccess.Main.Models;
using System;

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

            if (request.Denominations == null)
            {
                result.Errors.Add(new )
            }
            throw new NotImplementedException();
        }
    }
}
