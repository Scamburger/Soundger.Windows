using Autofac;
using Soundger.Client.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soundger.Desktop.View.Controls;

public partial class ProfilePage : UserControl
{
    private ISoundgerApiClient client;

    public ProfilePage()
    {
        InitializeComponent();
        LoadDependencies();
    }

    private void ApplyTheme()
    {
        var theme = SoundgerApplication.Theme;

        mainPanel.BackColor = theme.Third;
        BackColor = theme.Third;
        pagePanel.BackColor = theme.Third;
        mainPanel.BackColor = theme.Third;
    }

    private void LoadDependencies()
    {
        var scope = SoundgerApplication.Container.Resolve<ILifetimeScope>();
        client = scope.Resolve<ISoundgerApiClient>();
    }

    private async void signoutButton_Click(object sender, EventArgs e)
    {
        var config = SoundgerApplication.Config;
        config.Token = null;
        await ConfigurationManager.SaveConfigAsync(config);
        await client.AuthApi.LogoutAsync();
        Application.Restart();
    }
}
