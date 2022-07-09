using DigitalThinkers.Common.Entities;
using DigitalThinkers.Common.Entities.Enumerations;
using DigitalThinkers.Common.Entities.Models;
using DigitalThinkers.DataAccess.Main.Models;

namespace DigitalThinkers.DataAccess.Main
{
    public interface IDataManager
    {
        Result AddMoney(Money money);
        Result SubstractMoney(Money money);
        GetStockResult GetDenominationsOnStock();
        GetStockResult GetDenominationsOnStock(CurrencyType currencyType);
        GetMoneyResult GetDenominationOnStock(Money money);
    }
}
