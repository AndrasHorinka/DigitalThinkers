using DigitalThinkers.CashierService.Models;

namespace DigitalThinkers.CashierService
{
    public interface ICashierService
    {
        DenominationsLoadResult StockUpDenominations(DenominationsLoadRequest request);

        CheckoutResult Checkout(CheckoutRequest request);

        DenominationsOnStockResult GetDenominationsOnStock();
    }
}
