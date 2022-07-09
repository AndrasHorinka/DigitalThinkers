using DigitalThinkers.Models.Common;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DigitalThinkers.Models
{
    public class StockRequestDto
    {
        [Required]
        [JsonProperty("inserted")]
        public MoneyLoaded MoneyLoaded { get; set; }

        public string Currency { get; set; }
    }
}
