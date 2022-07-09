using Newtonsoft.Json;

namespace DigitalThinkers.Models.Common
{
    public class MoneyLoaded
    {
        [JsonProperty("1")]
        public int One { get; set; }
        [JsonProperty("2")]
        public int Two { get; set; }
        [JsonProperty("5")]
        public int Five { get; set; }
        [JsonProperty("10")]
        public int Ten { get; set; }
        [JsonProperty("20")]
        public int Twenty { get; set; }
        [JsonProperty("50")]
        public int Fifty { get; set; }
        [JsonProperty("100")]
        public int Hundred { get; set; }
        [JsonProperty("500")]
        public int FiveHundred { get; set; }
        [JsonProperty("1000")]
        public int Thousand { get; set; }
        [JsonProperty("2000")]
        public int TwoThousand { get; set; }
        [JsonProperty("5000")]
        public int FiveThousand { get; set; }
        [JsonProperty("10000")]
        public int TenThousand { get; set; }
        [JsonProperty("20000")]
        public int TwentyThousand { get; set; }
    }
}
