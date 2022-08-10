using Flurl.Http;
using Soundger.Client.Contracts;
using Soundger.Client.Exceptions;
using Soundger.Client.Interfaces;

namespace Soundger.Client;

public class AuthApiClient : SoundgerHttpClientBase, IAuthApiClient
{
    public AuthApiClient(SoundgerApiClientSettings settings) : base(settings) { }

    public async Task<LoginResponseDto> LoginAsync(string username, string password)
    {
        try
        {
            return await CreateRequest()
                .AppendPathSegment("api/auth/login")
                .PostJsonAsync(new { username, password })
                .ReceiveJson<LoginResponseDto>();
        }
        catch (FlurlHttpException e)
        {
            if (e.StatusCode == 404)
            {
                throw new SoundgerApiClientException($"User with username '{username}' not found");
            }

            if (e.StatusCode == 401)
            {
                throw new SoundgerApiClientException("Password is incorrect");
            }

            throw;
        }
    }

    public Task LogoutAsync()
    {
        return CreateAuthorizedRequest()
            .AppendPathSegment("api/auth/logout")
            .PostJsonAsync(null)
            .ReceiveString();
    }

    public Task<CurrentUserDto> GetCurrentUserAsync()
    {
        return CreateAuthorizedRequest()
            .AppendPathSegment("api/auth/current")
            .PostJsonAsync(null)
            .ReceiveJson<CurrentUserDto>();
    }

}
