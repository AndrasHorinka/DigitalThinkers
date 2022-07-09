using DigitalThinkers.Common.Entities;
using DigitalThinkers.Common.Entities.Models;
using DigitalThinkers.DataAccess.Main.Models;

namespace DigitalThinkers.DataAccess.Main
{
    public class DataManagerCache : IDataManager
    {
        private Denominations _denominationsOnStock { get; set; }

        public DataManagerCache()
        {
            this._denominationsOnStock = new Denominations();
        }

        public Result AddMoney(Money money)
        {
            throw new System.NotImplementedException();
        }

        public Result SubstractMoney(Money money)
        {
            throw new System.NotImplementedException();
        }

        public GetStockResult GetDenominationsOnStock()
        {
            throw new System.NotImplementedException();
        }

        public GetMoneyResult GetDenominationOnStock(Money money)
        {
            throw new System.NotImplementedException();
        }
    }
}
