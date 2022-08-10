using Autofac;
using Soundger.Client.Interfaces;
using Soundger.Desktop.Extensions;
using Soundger.Desktop.View.Dialogs;
using Soundger.Desktop.View.Forms;

namespace Soundger.Desktop;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        Initialize();

        if (!Authorize())
        {
            return;
        }

        var form = new MainForm();
        form.ShowDialog();
    }

    static void Initialize()
    {
        ApplicationConfiguration.Initialize();

        SoundgerApplication.Config = ConfigurationManager.LoadConfigAsync()
           .GetAwaiter()
           .GetResult();

        SoundgerApplication.Container = new ContainerBuilder()
            .RegisterSoundgerDependencies()
            .Build();
    }

    static bool Authorize()
    {
        if (SoundgerApplication.Config?.Token != null)
        {
            try
            {
                SoundgerApplication.CurrentUser = new Models.CurrentUser
                {
                    Token = SoundgerApplication.Config.Token
                };

                var client = SoundgerApplication.Container.Resolve<ISoundgerApiClient>();
                var currentUser = client.AuthApi.GetCurrentUserAsync().GetAwaiter().GetResult();

                SoundgerApplication.CurrentUser = new Models.CurrentUser
                {
                    Id = currentUser.Id,
                    Token = SoundgerApplication.Config.Token,
                    Username = currentUser.Username,
                };

                return true;
            }
            catch
            {
                SoundgerApplication.CurrentUser = null;
            }
        }

        var dialog = SoundgerApplication.Container.Resolve<AuthDialogContext>();
        dialog.ShowDialog();

        if (string.IsNullOrEmpty(SoundgerApplication.CurrentUser?.Token))
        {
            return false;
        }

        var config = SoundgerApplication.Config;
        config.Token = SoundgerApplication.CurrentUser.Token;
        ConfigurationManager.SaveConfigAsync(config).GetAwaiter().GetResult();
        return true;
    }
}