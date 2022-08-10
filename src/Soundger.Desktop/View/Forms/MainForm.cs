﻿using Autofac;
using Soundger.Client.Interfaces;
using Soundger.Desktop.View.Controls;
using Soundger.Desktop.View.Handlers;
using System.ComponentModel;
using System.Media;

namespace Soundger.Desktop.View.Forms;

public partial class MainForm : Form
{
    private ISoundgerApiClient client;
    private SideMenuItemControl[] menuItems;
    private Component[] pages;
    bool clicked = false;

    public MainForm()
    {
        InitializeComponent();
        LoadDependencies();
        ApplyTheme();

        MusicPlayer.Playlist.Add(new MusicPlayer.Track() { Name = "Random shit from internet", 
            Source = "http://media.ch9.ms/ch9/2876/fd36ef30-cfd2-4558-8412-3cf7a0852876/AzureWebJobs103.mp3" });
        MusicPlayer.Playlist.Add(new MusicPlayer.Track() { Name = "21 Savage - a lot (Official Video) ft. J. Cole", Source = "file.mp3" });
        MusicPlayer.SetCurrentTack(0);

        AudioButtonHandler.PlayPictureBoxControl = playPb;
        new AudioButtonHandler(nextPb).Handle();
        new AudioButtonHandler(playPb).Handle();
        new AudioButtonHandler(prevPb).Handle();

        menuItems = new[] { profileItem, mainItem, myItem, filesItem, settingsItem};

        profileItem.Icon = Properties.Resources.avatar;
        profileItem.Active = false;
        profileItem.Custom_OnMouseClick += (s, x) =>
        {
            DisposeOldForm();
            SetActiveMenuItem(profileItem);
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new ProfilePage { Dock = DockStyle.Fill, AutoSize = true, AutoScroll = true, });
        };

        mainItem.Icon = Properties.Resources.browse;
        mainItem.Active = true;
        mainItem.Label = "Browse";
        mainItem.Custom_OnMouseClick += (s, x) =>
        {
            DisposeOldForm();
            SetActiveMenuItem(mainItem);
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new Panel() {  Dock = DockStyle.Fill});
        };

        myItem.Icon = Properties.Resources.key;
        myItem.Active = false;
        myItem.Label = "Tracks";
        myItem.Custom_OnMouseClick += (s, x) =>
        {
            DisposeOldForm();
            SetActiveMenuItem(myItem);
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new Panel() { Dock = DockStyle.Fill });
        };

        filesItem.Icon = Properties.Resources.folder;
        filesItem.Active = false;
        filesItem.Label = "My files";
        filesItem.Custom_OnMouseClick += (s, x) =>
        {
            DisposeOldForm();
            SetActiveMenuItem(filesItem);
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new FilesPage() { Dock = DockStyle.Fill, AutoSize = true });
        };

        settingsItem.Icon = Properties.Resources.settings;
        settingsItem.Active = false;
        settingsItem.Label = "Settings";
        settingsItem.Custom_OnMouseClick += (s, x) =>
        {
            DisposeOldForm();
            SetActiveMenuItem(settingsItem);
            mainPanel.Controls.Clear();
            var page = new SettingsPage() { Dock = DockStyle.Fill, AutoSize = true, AutoScroll = true, };
            page.VerticalScroll.Enabled = true;
            mainPanel.Controls.Add(page);
        };

        trackBar.Scroll += (s,
                                e) =>
        {
            if (clicked)
                return;
            Console.WriteLine(trackBar.Value);
        };
        trackBar.MouseDown += (s,
                                e) =>
        {
            clicked = true;
        };
        trackBar.MouseUp += (s,
                                e) =>
        {
            if (!clicked)
                return;

            clicked = false;
            MusicPlayer.SetPosition(TimeSpan.FromMilliseconds(trackBar.Value));
        };
        trackBar.MouseWheelBarPartitions = int.MaxValue;
        trackBar.MouseWheel += (s, e) => {
            ((HandledMouseEventArgs)e).Handled = true;
        };

        this.KeyPreview = true;
        this.KeyDown += MainForm_KeyDown;
    }

    private void MainForm_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Space)
        {
            playPb.Image = MusicPlayer.IsCurrentlyPlaying ? Properties.Resources.stop : Properties.Resources.play; 

            if (!MusicPlayer.IsCurrentlyPlaying)
            {
                MusicPlayer.Play();
            }
            else
            {
                MusicPlayer.Stop();
            }
        }
    }

    private void DisposeOldForm()
    {
        if (mainPanel.Controls.Count > 0)
            mainPanel.Controls[0].Dispose();
    }

    private void SetActiveMenuItem(SideMenuItemControl control)
    {
        foreach(var menuItem in menuItems)
        {
            if (menuItem.Name == control.Name)
                menuItem.Active = true;
            else
                menuItem.Active = false;
        }
    }


    public IEnumerable<Control> GetAll(Control control)
    {
        var controls = control.Controls.Cast<Control>();
        return controls.SelectMany(ctrl => GetAll(ctrl))
                                  .Concat(controls);
    }

    private void ApplyTheme()
    {
        var theme = SoundgerApplication.Theme;

        mainPanel.BackColor = theme.Third;
        BackColor = theme.Third;
        
        sidePanel.BackColor = theme.First;
        toggleSideMenuButton.FlatAppearance.MouseDownBackColor = theme.Second;
        
        bottomPanel.BackColor = theme.Fourth;
        volumeBar.BackColor = theme.Fourth;
    }

    private void CollapseMenu()
    {
        if (this.sidePanel.Width >= 200)
        {
            sidePanel.Width = 50;
            smp_4_l.Visible = false;
        }
        else
        {
            sidePanel.Width = 200;
            smp_4_l.Visible = true;
        }
    }

    private void LoadDependencies()
    {
        var scope = SoundgerApplication.Container.Resolve<ILifetimeScope>();
        client = scope.Resolve<ISoundgerApiClient>();
    }

    private async void MainForm_Load(object sender, EventArgs e)
    {
        var currentUser = await client.AuthApi.GetCurrentUserAsync();
        SoundgerApplication.CurrentUser.Id = currentUser.Id;
        SoundgerApplication.CurrentUser.Username = currentUser.Username;

        Text = $"Logged in as {currentUser.Username} ({currentUser.Id})";
        profileItem.Label = currentUser.Username;

        CollapseMenu();
        CollapseMenu();
    }

    private void toggleSideMenuButton_Click(object sender, EventArgs e)
    {
        CollapseMenu();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        playPb.Image = MusicPlayer.IsCurrentlyPlaying ? Properties.Resources.stop : Properties.Resources.play;

        this.Text = MusicPlayer.CurrectTrack.Name;
        trackNameLabel.Text = MusicPlayer.CurrectTrack.Name;
        trackPanel.Size = new Size(trackNameLabel.Width + 65, trackPanel.Height);
        trackBar.Maximum = (int)MusicPlayer.GetTotal().TotalMilliseconds + 50;

        if (!clicked)
        {
            trackBar.Value = (int)MusicPlayer.GetPosition().TotalMilliseconds;

            var diff = trackBar.Maximum - trackBar.Value;
            if (MusicPlayer.IsCurrentlyPlaying && trackBar.Value != 0 && trackBar.Maximum != 0 && diff <= 200 && diff > 0)
            {
                MusicPlayer.Next();
                trackNameLabel.Text = MusicPlayer.CurrectTrack.Name;
            }
        }
    }

    private void volumeBar_ValueChanged(object sender, EventArgs e)
    {
        MusicPlayer.SetVolumeLevel((float)volumeBar.Value / 100);
    }

    private void volumeBar_MouseDown(object sender, MouseEventArgs e)
    {
        double dblValue = ((double)e.X / (double)volumeBar.Width) * (volumeBar.Maximum - volumeBar.Minimum);
        volumeBar.Value = Convert.ToInt32(dblValue);
    }
}