using System.Collections.Generic;

namespace DigitalThinkers.Common.Entities
{
    public class Denominations
    {
        public IList<Money> MoneyInTransfer { get; set; }

        public Denominations()
        {
            MoneyInTransfer = new List<Money>();
        }
    }
}
