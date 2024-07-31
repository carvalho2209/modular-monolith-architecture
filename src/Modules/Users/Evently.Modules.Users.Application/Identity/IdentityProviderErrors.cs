using Evently.Common.Domain.Abstractions;

namespace Evently.Modules.Users.Application.Identity;

public static class IdentityProviderErrors
{
    public static readonly Error EmailIsNotUnique = Error.Conflict(
        "Identity.EmailIsNotUnique",
        "The specified is not unique.");
}
