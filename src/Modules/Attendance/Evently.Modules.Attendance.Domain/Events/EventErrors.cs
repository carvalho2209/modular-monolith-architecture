using Evently.Common.Domain;
using Evently.Common.Domain.Abstractions;

namespace Evently.Modules.Attendance.Domain.Events;

public static class EventErrors
{
    public static Error NotFound(Guid eventId) =>
        Error.NotFound("Events.NotFound", $"The event with the identifier {eventId} was not found");
}
