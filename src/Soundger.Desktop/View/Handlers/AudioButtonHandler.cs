using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Soundger.Desktop.View.Handlers
{
    internal class AudioButtonHandler
    {
        public static PictureBox PlayPictureBoxControl;

        private readonly PictureBox pictureBox;
        private bool isPaused => !MusicPlayer.IsCurrentlyPlaying;

        public AudioButtonHandler(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
        }

        public void Handle()
        {
            pictureBox.MouseEnter += PictureBox_MouseEnter;
            pictureBox.MouseLeave += PictureBox_MouseLeave;
            pictureBox.MouseDown += PictureBox_Click;
        }

        private void PictureBox_Click(object? sender, EventArgs e)
        {
            if (pictureBox.Name.Contains("play"))
            {
                Task.Run(() =>
                {
                    pictureBox.Image = isPaused ? Properties.Resources.stop_highlighted : Properties.Resources.play__highlighted_;

                    if (isPaused)
                    {
                        MusicPlayer.Play();
                    }
                    else
                    {
                        MusicPlayer.Stop();
                    }
                });
            }
            else if (pictureBox.Name.Contains("next"))
            {
                Task.Run(() =>
                {
                    PlayPictureBoxControl.Image = !isPaused ? Properties.Resources.stop : Properties.Resources.play;
                    MusicPlayer.Next();
                    
                });
            }
            else if (pictureBox.Name.Contains("prev"))
            {
                Task.Run(() =>
                {
                    PlayPictureBoxControl.Image = !isPaused ? Properties.Resources.stop : Properties.Resources.play;
                    MusicPlayer.Prev();
                });
            }
        }

        private void PictureBox_MouseLeave(object? sender, EventArgs e)
        {
            pictureBox.Image = ResolveBitmap();
        }

        private void PictureBox_MouseEnter(object? sender, EventArgs e)
        {
            pictureBox.Image = ResolveHighlightedBitmap();
        }

        private Bitmap ResolveBitmap()
        {
            if (pictureBox.Name.Contains("play"))
            {
                return isPaused ? Properties.Resources.play : Properties.Resources.stop;
            }

            if (pictureBox.Name.Contains("next"))
            {
                return Properties.Resources.next;
            }

            if (pictureBox.Name.Contains("prev"))
            {
                return Properties.Resources.back;
            }

            throw new InvalidOperationException($"Could not resolve bitmap for {pictureBox.Name}");
        }

        private Bitmap ResolveHighlightedBitmap()
        {
            if (pictureBox.Name.Contains("play"))
            {
                return isPaused ? Properties.Resources.play__highlighted_ : Properties.Resources.stop_highlighted;
            }

            if (pictureBox.Name.Contains("next"))
            {
                return Properties.Resources.next__highlighted_;
            }

            if (pictureBox.Name.Contains("prev"))
            {
                return Properties.Resources.back__highlighted_;
            }

            throw new InvalidOperationException($"Could not resolve bitmap for {pictureBox.Name}");
        }
    }
}
