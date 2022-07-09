using DigitalThinkers.Common.Entities;
using DigitalThinkers.Common.Entities.Models;

namespace DigitalThinkers.DataAccess.Main.Models
{
    public class GetStockResult : Result
    {
        public Denominations AvailableStock { get; set; }
    }
}
