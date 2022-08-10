using Autofac;
using Soundger.Client;
using Soundger.Client.Interfaces;
using Soundger.Desktop.View.Dialogs;

namespace Soundger.Desktop.Extensions;

internal static class AutofacExtensions
{
    public static ContainerBuilder RegisterSoundgerDependencies(this ContainerBuilder builder)
    {
        RegisterApiClient(builder);
        RegisterDialogs(builder);
        return builder;
    }

    private static void RegisterApiClient(ContainerBuilder builder)
    {
        builder.Register(s => new SoundgerApiClientSettings
        {
            Endpoint = SoundgerApplication.Config.Endpoint,
            Token = SoundgerApplication.CurrentUser?.Token,
        }).AsSelf().InstancePerDependency();

        builder.RegisterType<AuthApiClient>()
            .As<IAuthApiClient>();

        builder.RegisterType<SoundgerApiClient>()
            .As<ISoundgerApiClient>();
    }

    private static void RegisterDialogs(ContainerBuilder builder)
    {
        builder.RegisterType<AuthDialogContext>()
            .AsSelf();
    }
}
