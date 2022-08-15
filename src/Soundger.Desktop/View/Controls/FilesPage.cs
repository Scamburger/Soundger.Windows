using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soundger.Desktop.View.Controls
{
    public partial class FilesPage : UserControl
    {
        private List<TrackItemControl> CurrentControls { get; set; } = new List<TrackItemControl>();

        public FilesPage()
        {
            InitializeComponent();

            filesMainPanel.Scroll += FilesMainPanel_Scroll;
            filesMainPanel.MouseWheel += FilesMainPanel_MouseWheel;

            this.Resize += FilesPage_Resize;
            // ProcessDirectory();
            // this.VerticalScroll.SmallChange = 1;
            // this.VerticalScroll.LargeChange = 2;

            this.Disposed += FilesPage_Disposed;

            SoundgerApplication.PlayKeyDownIgnoredControls.Add(searchTextBox.Name);
        }

        private void FilesPage_Disposed(object? sender, EventArgs e)
        {
            CurrentControls.ForEach(s => s.Dispose());
            CurrentControls.Clear();
            CurrentControls = null;
            GC.Collect();
        }

        private void FilesPage_Resize(object? sender, EventArgs e)
        {
            HideUnusedControls();
        }

        private void FilesMainPanel_MouseWheel(object? sender, MouseEventArgs e)
        {
            HideUnusedControls();
        }

        private void FilesMainPanel_Scroll(object? sender, ScrollEventArgs e)
        {
            HideUnusedControls();
        }

        private void HideUnusedControls()
        {
            foreach(var control in CurrentControls)
            {
                SetVisible(control);
            }
        }

        private void SetVisible(TrackItemControl control)
        {
            var y = control.Location.Y;
            if (y < -100)
            {
                control.SetVisible(false);
            }
            else if (y >= -100 && y < this.Height + 100)
            {
                control.SetVisible(true);
            }
            else
            {
                control.SetVisible(false);
            }
        }

        private bool loaded = false;
        public async Task ProcessDirectoryAsync()
        {
            await Task.Delay(100);

            CurrentControls.ForEach(s => s.Dispose());
            CurrentControls.Clear();
            // Process the list of files found in the directory.
            var fileEntries = new List<string>();
            foreach(var path in SoundgerApplication.Config.MusicDirectories)
            {
                fileEntries.AddRange(Directory.GetFiles(path, "*.mp3"));
            }

            foreach (string fileName in fileEntries)
            {
                var control = new TrackItemControl(new MusicPlayer.Track()
                {
                    Name = Path.GetFileNameWithoutExtension(fileName),
                    Source = fileName,
                })
                {
                    Dock = DockStyle.Top,
                    Margin = new Padding(10),
                };

                SetVisible(control);
                filesMainPanel.Controls.Add(control);
                CurrentControls.Add(control);

                await Task.Delay(1);
            }
            
            HideUnusedControls();
            loaded = true;
        }

        private string lastSourcePlayed;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lastSourcePlayed == MusicPlayer.CurrectTrack.Source)
            {
                var control = CurrentControls.First(s => s.Track.Source == lastSourcePlayed);
                control.SetPlaying(true);
                return;
            }

            foreach (var control in CurrentControls)
            {
                if (control.Track.Source == MusicPlayer.CurrectTrack.Source)
                {
                    lastSourcePlayed = control.Track.Source;
                    control.SetPlaying(true);
                }
                else
                {
                    control.SetPlaying(false);
                }
            }
        }

        private async void FilesPage_Load(object sender, EventArgs e)
        {
            await ProcessDirectoryAsync();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTextBox.Text))
            {
                CurrentControls.ForEach(s => s.Visible = true);
                return;
            }

            CurrentControls.ForEach(s => s.Visible = s.Track.Name.ToLower().Contains(searchTextBox.Text.ToLower()));
        }

    }
}
