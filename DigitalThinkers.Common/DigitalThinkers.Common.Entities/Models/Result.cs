using System.Collections.Generic;
using System.Linq;

namespace DigitalThinkers.Common.Entities.Models
{
    public class Result : IHasErrors
    {
        public bool IsSuccessful => !this.Errors.Any();
        public List<BaseEvent> Errors{ get; set; }

        public Result()
        {
            this.Errors = new List<BaseEvent>();
        }
    }
}
