using MediatR;

namespace Evently.Common.Domain.Abstractions;

public interface IDomainEvent : INotification
{
    Guid Id { get; }
    DateTime OccurredOnUtc { get; }
}
