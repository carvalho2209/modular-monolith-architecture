using Evently.Common.Domain.Abstractions;
using MediatR;

namespace Evently.Common.Application.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>;
