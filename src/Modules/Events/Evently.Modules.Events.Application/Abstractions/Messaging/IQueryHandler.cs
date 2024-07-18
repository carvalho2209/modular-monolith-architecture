﻿using Evently.Modules.Events.Domain.Abstractions;
using MediatR;

namespace Evently.Modules.Events.Application.Abstractions.Messaging;

public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>;
