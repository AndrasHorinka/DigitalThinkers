using DigitalThinkers.Common.Entities;
using DigitalThinkers.Common.Entities.Models;

namespace DigitalThinkers.DataAccess.Main.Models
{
    public class GetMoneyResult : Result
    {
        public Money DenominationOnStock { get; set; }
    }
}
