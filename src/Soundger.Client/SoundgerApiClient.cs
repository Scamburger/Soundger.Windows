using Soundger.Client.Interfaces;

namespace Soundger.Client;

public class SoundgerApiClient : ISoundgerApiClient
{
    public IAuthApiClient AuthApi { get; }

    public SoundgerApiClient(IAuthApiClient authApiClient)
    {
        AuthApi = authApiClient;
    }
}
