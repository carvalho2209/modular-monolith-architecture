using Evently.Common.Domain.Abstractions;
using MediatR;

namespace Evently.Common.Application.Messaging;

public interface IDomainEventHandler<in TDomainEvent> : INotificationHandler<TDomainEvent>
    where TDomainEvent : IDomainEvent;
