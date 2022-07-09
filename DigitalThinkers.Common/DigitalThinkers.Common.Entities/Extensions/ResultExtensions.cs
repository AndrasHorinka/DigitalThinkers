using DigitalThinkers.Common.Entities.Models;

namespace DigitalThinkers.Common.Entities.Extensions
{
    public static class ResultExtensions
    {
        public static void CopyErrorsFrom(this IHasErrors target, IHasErrors source)
        {
            target.Errors.AddRange(source.Errors);
        }
    }
}
