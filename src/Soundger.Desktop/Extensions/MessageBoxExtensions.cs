using Soundger.Client.Exceptions;

namespace Soundger.Desktop.Extensions;

public static class MessageBoxExtensions
{
    public static void ShowAsMessageBox(this Exception e)
    {
        if (e is SoundgerApiClientException)
        {
            MessageBox.Show(e.Message, "Soundger");
            return;
        }

        MessageBox.Show(e.Message, "Unhandled error occupied");
    }
}
