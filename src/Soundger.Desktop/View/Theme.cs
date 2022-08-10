namespace Soundger.Desktop.View;

public class Theme
{
    public Color First { get; set; }
    public Color Second { get; set; }
    public Color Third { get; set; }
    public Color Fourth { get; set; }
    public Color Fifth { get; set; }

    public static Theme Light => new()
    {
        First = Color.FromArgb(246, 248, 249),
        Second = Color.FromArgb(197, 198, 199),
        Third = Color.FromArgb(255, 255, 255),
        Fourth = Color.FromArgb(242, 242, 242),
        Fifth = Color.FromArgb(222, 224, 225)
    };
}
