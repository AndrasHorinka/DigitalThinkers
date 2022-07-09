using System;

namespace DigitalThinkers.Common.Entities.Models
{
    public class BaseEvent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime HappenedAt { get; private set; }

        public BaseEvent()
        {
            HappenedAt = DateTime.UtcNow;
        }
    }
}
