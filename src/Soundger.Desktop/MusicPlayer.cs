using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soundger.Desktop;

public static class MusicPlayer
{
    public static ICollection<Track> Playlist { get; } = new HashSet<Track>();
    public static Track CurrectTrack => Playlist.ElementAt(CurrentTrackIndex);
    public static bool IsCurrentlyPlaying { get; private set; } = false;

    private static WaveOutEvent Event = new WaveOutEvent();
    private static MediaFoundationReader Reader;

    private static int TrackIndexBeforeStop = -1;
    private static int CurrentTrackIndex = 0;

    public static void SetCurrentTack(int index)
    {
        CurrentTrackIndex = index;
    }

    public static void SetCurrentTack(Track track)
    {
        CurrentTrackIndex = Playlist.ToList().IndexOf(track);
    }

    public static void SetVolumeLevel(float value)
    {
        Event.Volume = value;
    }

    public static void Next()
    {
        TrackIndexBeforeStop = -1;
        CurrentTrackIndex++;
        if (Playlist.Count() <= CurrentTrackIndex)
        {
            CurrentTrackIndex = 0;
        }

        if (IsCurrentlyPlaying)
            Play();
    }

    public static void Prev()
    {
        TrackIndexBeforeStop = -1;
        CurrentTrackIndex--;
        if (CurrentTrackIndex < 0)
        {
            CurrentTrackIndex = Playlist.Count() - 1;
        }

        if (IsCurrentlyPlaying)
            Play();
    }

    private static Object obj = new object();

    public static void Play()
    {
        lock (obj)
        {
            IsCurrentlyPlaying = true;

            if (TrackIndexBeforeStop == CurrentTrackIndex)
            {
                Event.Play();
                return;
            }

            Event?.Dispose();
            Reader?.Dispose();

            Event = new WaveOutEvent();
            Reader = new MediaFoundationReader(Playlist.ElementAt(CurrentTrackIndex).Source);

            Event.Init(Reader);
            Event.Play();
        }
    }

    public static void Continue()
    {
        Event.Play();
    }

    public static void Stop()
    {
        TrackIndexBeforeStop = CurrentTrackIndex;
        Event.Stop();
        IsCurrentlyPlaying = false;
    }

    public static TimeSpan GetPosition()
    {
        return Reader?.CurrentTime ?? TimeSpan.Zero;
    }

    public static TimeSpan GetTotal()
    {
        return Reader?.TotalTime ?? TimeSpan.Zero;
    }

    public static void SetPosition(TimeSpan position)
    {
        if (Reader != null)
            Reader.CurrentTime = position;
    }

    public class Track
    {
        public string Name { get; set; }
        public string Source { get; set; }
    }
}
