using Soundger.Client.Contracts;

namespace Soundger.Client.Interfaces;

public interface IAuthApiClient
{
    Task<CurrentUserDto> GetCurrentUserAsync();

    Task<LoginResponseDto> LoginAsync(string username, string password);

    Task LogoutAsync();
}