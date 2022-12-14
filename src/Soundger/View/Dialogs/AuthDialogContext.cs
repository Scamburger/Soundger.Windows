using bubuntoid.EasyDialog;
using Soundger.Client.Interfaces;
using Soundger.Extensions;

namespace Soundger.View.Dialogs;

public class AuthDialogContext : DialogContext<AuthDialogContext>
{
    public DialogSet<string> Username { get; set; }
    public DialogSet<string> Password { get; set; }

    private readonly ISoundgerApiClient client;

    public AuthDialogContext(ISoundgerApiClient client)
    {
        this.client = client;
    }

    protected override async void OnButtonClick()
    {
        Button.Enabled = false;

        try
        {
            var response = await client.AuthApi.LoginAsync(Username.Value, Password.Value);
            SoundgerApplication.CurrentUser = new Models.CurrentUser
            {
                Token = response.Token,
                IsAuthorized = true,
            };
            Close();
        }
        catch (Exception e)
        {
            e.ShowAsMessageBox();
        }

        Button.Enabled = true;
        Button.Select();
    }

    protected override void OnConfiguring(DialogContextConfigureOptionsBuilder<AuthDialogContext> builder)
    {
        builder.HasTitle("Soundger")
            .HasButton("Sign in")
            .HasWidth(444)
            .UseDefaultStyle();

        builder.Item(s => s.Password)
            .AsTextBox()
            .UsePasswordChar();

        builder.OnShown(() =>
        {
            Form.AcceptButton = Button;
        });
    }

    private Button Button => Form.Controls.OfType<Button>().First();
}
