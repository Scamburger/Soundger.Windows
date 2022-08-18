namespace Soundger.View.Controls
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
            var path = string.Empty;
            using var dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.SelectedPath;
            }

            if (string.IsNullOrEmpty(path) == false && directoriesListBox.Items.Contains(path) == false)
            {
                directoriesListBox.Items.Add(path);
            }
        }

        private void deleteDirectoryButton_Click(object sender, EventArgs e)
        {
            directoriesListBox.Items.Remove(directoriesListBox.SelectedItem);
        }
    }
}
