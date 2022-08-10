namespace Soundger.Client.Interfaces;

public interface ISoundgerApiClient
{
    IAuthApiClient AuthApi { get; }
}
