﻿using Evently.Common.Domain.Abstractions;

namespace Evently.Modules.Ticketing.Application.Carts;

public static class CartErrors
{
    public static readonly Error Empty = Error.Problem("Carts.Empty", "The cart is empty");
}
