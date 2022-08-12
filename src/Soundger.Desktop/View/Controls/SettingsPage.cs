using Soundger.Desktop.View.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soundger.Desktop.View.Controls
{
    public partial class SettingsPage : UserControl
    {
        public SettingsPage()
        {
            InitializeComponent();

            endpointTextBox.Text = SoundgerApplication.Config.Endpoint;
            syncCheckBox.Checked = SoundgerApplication.Config.SyncEnabled;

            foreach(var item in SoundgerApplication.Config.MusicDirectories)
            {
                directoriesListBox.Items.Add(item);
            }
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            var config = SoundgerApplication.Config;
            config.MusicDirectories = directoriesListBox.Items.Cast<string>().ToHashSet();
            config.Endpoint = endpointTextBox.Text;
            config.SyncEnabled = syncCheckBox.Checked;

            await ConfigurationManager.SaveConfigAsync(config);
        }

        private void addDirectoryButton_Click(object sender, EventArgs e)
        {
            var dialog = new BrowseFolderDialogContext();
            dialog.ShowDialog();

            if (string.IsNullOrEmpty(dialog.Path.Value) == false && directoriesListBox.Items.Contains(dialog.Path.Value) == false)
            {
                directoriesListBox.Items.Add(dialog.Path.Value);
            }
        }

        private void deleteDirectoryButton_Click(object sender, EventArgs e)
        {
            directoriesListBox.Items.Remove(directoriesListBox.SelectedItem);
        }
    }
}
