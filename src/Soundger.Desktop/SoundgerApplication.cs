using Autofac;
using Soundger.Desktop.Models;
using Soundger.Desktop.View;

namespace Soundger.Desktop;

internal class SoundgerApplication
{
    public static ConfigurationManager.Config Config { get; set; }

    public static IContainer Container { get; set; }

    public static CurrentUser CurrentUser { get; set; }

    public static Theme Theme { get; set; } = Theme.Light;
}
