using Soundger.Models;
using static Soundger.MusicPlayer;

namespace Soundger.View.Controls
{
    public partial class TrackItemControl : UserControl
    {
        public AudioTrack Track { get; set; }
        private readonly Theme theme = SoundgerApplication.Theme;
        public bool IsSetToVisible { get; set; }

        public TrackItemControl(AudioTrack track)
        {
            InitializeComponent();
            this.Track = track;
            label1.Text = track.Name;
            var controls = GetAll(this).Append(this).ToList();
            foreach (var control in controls)
            {
                control.Click += Control_Click;
                control.MouseDown += Panel_MouseDown;
                control.MouseUp += Panel_MouseUp;
                control.MouseLeave += Panel_MouseLeave;
                control.MouseEnter += Panel_MouseEnter;
            };
        }

        public void SetPlaying(bool value)
        {
            if (value)
            {
                this.BackColor = theme.Second;
            }
            else
            {
                this.BackColor = theme.Third;
            }
        }

        public void SetLabel(string text)
        {
            label1.Text = text;
        }

        public void SetVisible(bool value)
        {
            IsSetToVisible = value;
            GetAll(this).Except(new[] { this }).ToList().ForEach(s =>
            {
                s.Visible = value;
            });
        }

        private void Control_Click(object? sender, EventArgs e)
        {
            Playlist.Add(Track);
            SetCurrentTack(Track);
            Play();
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
            this.BackColor = theme.Third;
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
}
