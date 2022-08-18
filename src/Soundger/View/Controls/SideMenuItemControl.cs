namespace Soundger.View;

public partial class SideMenuItemControl : UserControl
{
    public Image Icon
    {
        get => smp_2_ip_pb.Image;
        set => smp_2_ip_pb.Image = value;
    }

    public bool Active
    {
        get => smp_2_apb.Visible;
        set => smp_2_apb.Visible = value;
    }

    public string Label
    {
        get => smp_2_label.Text;
        set => smp_2_label.Text = value;
    }

    public event EventHandler Custom_OnMouseClick;

    private Theme theme = SoundgerApplication.Theme;

    public SideMenuItemControl()
    {
        InitializeComponent();
        var controls = GetAll(this).Append(this).ToList();
        foreach (var control in controls)
        {
            control.Click += Control_Click; ;
            control.MouseDown += Panel_MouseDown;
            control.MouseUp += Panel_MouseUp;
            control.MouseLeave += Panel_MouseLeave;
            control.MouseEnter += Panel_MouseEnter;
        };
    }

    private void Control_Click(object? sender, EventArgs e)
    {
        Custom_OnMouseClick?.Invoke(sender, e);
    }

    private void Panel_MouseDown(object? sender, MouseEventArgs e)
    {
        this.BackColor = theme.Second;
    }

    private void Panel_MouseUp(object? sender, MouseEventArgs e)
    {
        this.BackColor = theme.Fifth;
    }

    private void Panel_MouseLeave(object? sender, EventArgs e)
    {
        this.BackColor = theme.First;
    }

    private void Panel_MouseEnter(object? sender, EventArgs e)
    {
        this.BackColor = theme.Fifth;
    }

    public IEnumerable<Control> GetAll(Control control)
    {
        var controls = control.Controls.Cast<Control>();
        return controls.SelectMany(ctrl => GetAll(ctrl))
                                  .Concat(controls);
    }
}
