using DigitalThinkers.Models.Common;
using System.Collections.Generic;

namespace DigitalThinkers.Models
{
    public class StockUpResponse
    {
        public MoneyLoaded MoneyReturned { get; set; }
        public IList<string> Errors { get; set; }

        public StockUpResponse()
        {
            Errors = new List<string>();
        }
    }
}
