using Autofac;
using Soundger.Client.Interfaces;
using Soundger.View.Dialogs;

namespace Soundger.View.Controls;

public partial class ProfilePage : UserControl
{
    public event Action<bool> OnAuthorizedValueChangedEvent;

    public ProfilePage()
    {
        InitializeComponent();
        ApplyTheme();
    }

    private void ApplyTheme()
    {
        var theme = SoundgerApplication.Theme;

        mainPanel.BackColor = theme.Third;
        BackColor = theme.Third;
        pagePanel.BackColor = theme.Third;
        mainPanel.BackColor = theme.Third;
    }

    private async void signoutButton_Click(object sender, EventArgs e)
    {
        await SoundgerApplication.Container.Resolve<ISoundgerApiClient>().AuthApi.LogoutAsync();
        SoundgerApplication.CurrentUser = null;
        signInButton.Enabled = true;
        signOutButton.Enabled = !signInButton.Enabled;
        var config = SoundgerApplication.Config;
        config.Token = null;
        await ConfigurationManager.SaveConfigAsync(config);
        OnAuthorizedValueChangedEvent?.Invoke(false);
    }

    private async void signInButton_Click(object sender, EventArgs e)
    {
        var dialog = SoundgerApplication.Container.Resolve<AuthDialogContext>();
        dialog.ShowDialog();

        if (string.IsNullOrEmpty(SoundgerApplication.CurrentUser?.Token))
        {
            return;
        }

        var config = SoundgerApplication.Config!;
        config.Token = SoundgerApplication.CurrentUser.Token;
        await ConfigurationManager.SaveConfigAsync(config);
        signInButton.Enabled = false;
        signOutButton.Enabled = !signInButton.Enabled;
        var client = SoundgerApplication.Container.Resolve<ISoundgerApiClient>();
        var currentUser = await client.AuthApi.GetCurrentUserAsync();
        SoundgerApplication.CurrentUser.IsAuthorized = true;
        SoundgerApplication.CurrentUser.Id = currentUser.Id;
        SoundgerApplication.CurrentUser.Username = currentUser.Username;
        OnAuthorizedValueChangedEvent?.Invoke(true);
    }

    private void ProfilePage_Load(object sender, EventArgs e)
    {
        signInButton.Enabled = SoundgerApplication.CurrentUser?.IsAuthorized != true;
        signOutButton.Enabled = !signInButton.Enabled;
    }
}
