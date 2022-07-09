using DigitalThinkers.Common.Entities.Enumerations;

namespace DigitalThinkers.Common.Entities
{
    public class Money
    {
        public CurrencyType CurrencyType { get; set; }
        public ValueType ValueType { get; set; }
        public int Count { get; set; }
    }
}
