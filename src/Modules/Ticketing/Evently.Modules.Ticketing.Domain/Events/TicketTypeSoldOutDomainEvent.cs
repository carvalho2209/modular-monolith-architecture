﻿using Evently.Common.Domain.Abstractions;

namespace Evently.Modules.Ticketing.Domain.Events;

public sealed class TicketTypeSoldOutDomainEvent(Guid ticketTypeId) : DomainEvent
{
    public Guid TicketTypeId { get; init; } = ticketTypeId;
}
