﻿using Evently.Modules.Events.Domain.Abstractions;

namespace Evently.Modules.Events.Domain.Categories;

public sealed class CategoryNameChangedDomainEvent(Guid categoryId, string name) : DomainEvent
{
    public Guid CategoryId { get; init; } = categoryId;

    public string Name { get; init; } = name;
}
