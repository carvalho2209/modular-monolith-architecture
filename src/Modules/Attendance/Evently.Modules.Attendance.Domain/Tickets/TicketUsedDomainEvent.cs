using Evently.Common.Domain;
using Evently.Common.Domain.Abstractions;

namespace Evently.Modules.Attendance.Domain.Tickets;

public sealed class TicketUsedDomainEvent(Guid ticketId) : DomainEvent
{
    public Guid TicketId { get; init; } = ticketId;
}
