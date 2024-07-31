using Evently.Common.Domain.Abstractions;

namespace Evently.Modules.Users.Application.Identity;

public interface IIdentityProviderService
{
    Task<Result<string>> RegisterUserAsync(UserModel user, CancellationToken cancellationToken = default);
}
