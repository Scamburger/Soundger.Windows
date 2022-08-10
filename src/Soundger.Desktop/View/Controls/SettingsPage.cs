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

            textBox1.Text = SoundgerApplication.Config.Endpoint;

            listBox1.Items.Add("C:\\Users\\root\\Music");

            foreach(var item in SoundgerApplication.Config.MusicDirectories)
            {
                listBox1.Items.Add(item);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
