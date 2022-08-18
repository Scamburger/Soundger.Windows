using Flurl.Http;
using Soundger.Client.Exceptions;

namespace Soundger.Client;

public abstract class SoundgerHttpClientBase
{
    private const string AuthorizationHeaderName = "Soundger-Authorization";

    private readonly IFlurlClient client;
    private readonly SoundgerApiClientSettings settings;

    protected SoundgerHttpClientBase(SoundgerApiClientSettings settings)
    {
        this.settings = settings;
        client = new FlurlClient(settings.Endpoint);
    }

    protected IFlurlRequest CreateRequest()
    {
        return client.Request().AfterCall(call =>
        {
            if (call?.Response?.StatusCode == null)
            {
                throw new SoundgerApiClientException($"Server {settings.Endpoint} is not responding");
            }
        });
    }

    protected IFlurlRequest CreateAuthorizedRequest()
    {
        return CreateRequest().WithHeader(AuthorizationHeaderName, settings.Token);
    }
}
