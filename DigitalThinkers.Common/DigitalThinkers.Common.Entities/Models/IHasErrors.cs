using System.Collections.Generic;

namespace DigitalThinkers.Common.Entities.Models
{
    public interface IHasErrors
    {
        public List<BaseEvent> Errors { get; set; }
    }
}
