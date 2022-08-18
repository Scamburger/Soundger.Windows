using Autofac;
using Soundger.Models;
using Soundger.View;

namespace Soundger;

internal static class SoundgerApplication
{
    public static ConfigurationManager.Config Config { get; set; }

    public static IContainer Container { get; set; }

    public static CurrentUser CurrentUser { get; set; }

    public static Theme Theme { get; set; } = Theme.Light;

    public static ICollection<string> PlayKeyDownIgnoredControls { get; } = new HashSet<string>();
}
