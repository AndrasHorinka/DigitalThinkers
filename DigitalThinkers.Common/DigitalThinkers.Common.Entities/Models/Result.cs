using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in Errors)
            {
                sb.Append(item.Title);
                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}
