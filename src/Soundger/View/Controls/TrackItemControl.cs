using Soundger.Models;
using Soundger.View.Handlers;
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
                if (control == menuPb || control == panel3)
                    continue;

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
            if (MusicPlayer.CurrentTrack?.Source == Track.Source)
            {
                AudioButtonHandler.PlayPictureBoxControl.Image = !MusicPlayer.IsCurrentlyPlaying 
                    ? Properties.Resources.stop_highlighted 
                    : Properties.Resources.play__highlighted_;

                if (!MusicPlayer.IsCurrentlyPlaying)
                {
                    MusicPlayer.Play();
                }
                else
                {
                    MusicPlayer.Stop();
                }

                return;
            }

            Playlist.Clear();
            foreach(var path in SoundgerApplication.Config.MusicDirectories)
            {
                var fileEntries = new List<string>();
                fileEntries.AddRange(Directory.GetFiles(path, "*.mp3"));

                foreach(var fileName in fileEntries)
                {
                    var track = new AudioTrack
                    {
                        Name = Path.GetFileNameWithoutExtension(fileName),
                        Source = fileName,
                    };

                    Playlist.Add(track);
                }

            }

            Playlist = Playlist.Reverse().ToList();
            var currentTrack = Playlist.FirstOrDefault(s => s.Source == Track.Source);
            SetCurrentTack(currentTrack);
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
