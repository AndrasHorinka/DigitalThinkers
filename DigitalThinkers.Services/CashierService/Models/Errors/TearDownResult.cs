using DigitalThinkers.Common.Entities;
using DigitalThinkers.Common.Entities.Models;
using System.Collections.Generic;

namespace DigitalThinkers.CashierService.Models.Errors
{
    public class TearDownResult : Result
    {
        public IList<Money> MoneyToRefund { get; set; }

        public TearDownResult()
        {
            MoneyToRefund = new List<Money>();
        }
    }
}
