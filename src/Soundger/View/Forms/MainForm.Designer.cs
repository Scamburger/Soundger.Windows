namespace Soundger.View.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.audioControlsPanel = new System.Windows.Forms.Panel();
            this.trackPanel = new System.Windows.Forms.Panel();
            this.albumLabel = new System.Windows.Forms.Label();
            this.trackNameLabel = new System.Windows.Forms.Label();
            this.thumbnailBox = new System.Windows.Forms.PictureBox();
            this.volumePanel = new System.Windows.Forms.Panel();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.ac_p1 = new System.Windows.Forms.Panel();
            this.nextPb = new System.Windows.Forms.PictureBox();
            this.playPb = new System.Windows.Forms.PictureBox();
            this.prevPb = new System.Windows.Forms.PictureBox();
            this.statusBarPanel = new System.Windows.Forms.Panel();
            this.trackBar = new MetroFramework.Controls.MetroTrackBar();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.settingsItem = new SideMenuItemControl();
            this.filesItem = new SideMenuItemControl();
            this.myItem = new SideMenuItemControl();
            this.smp_4 = new System.Windows.Forms.Panel();
            this.smp_4_l = new System.Windows.Forms.Label();
            this.smp_3 = new System.Windows.Forms.Panel();
            this.mainItem = new SideMenuItemControl();
            this.smp_2 = new System.Windows.Forms.Panel();
            this.profileItem = new SideMenuItemControl();
            this.smp_1 = new System.Windows.Forms.Panel();
            this.sp_header = new System.Windows.Forms.Panel();
            this.toggleSideMenuButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bottomPanel.SuspendLayout();
            this.audioControlsPanel.SuspendLayout();
            this.trackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailBox)).BeginInit();
            this.volumePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevPb)).BeginInit();
            this.statusBarPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.sideMenuPanel.SuspendLayout();
            this.smp_4.SuspendLayout();
            this.sp_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.audioControlsPanel);
            this.bottomPanel.Controls.Add(this.statusBarPanel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(2, 472);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(953, 63);
            this.bottomPanel.TabIndex = 0;
            // 
            // audioControlsPanel
            // 
            this.audioControlsPanel.Controls.Add(this.trackPanel);
            this.audioControlsPanel.Controls.Add(this.volumePanel);
            this.audioControlsPanel.Controls.Add(this.ac_p1);
            this.audioControlsPanel.Controls.Add(this.nextPb);
            this.audioControlsPanel.Controls.Add(this.playPb);
            this.audioControlsPanel.Controls.Add(this.prevPb);
            this.audioControlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audioControlsPanel.Location = new System.Drawing.Point(0, 10);
            this.audioControlsPanel.Name = "audioControlsPanel";
            this.audioControlsPanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.audioControlsPanel.Size = new System.Drawing.Size(953, 53);
            this.audioControlsPanel.TabIndex = 1;
            // 
            // trackPanel
            // 
            this.trackPanel.Controls.Add(this.albumLabel);
            this.trackPanel.Controls.Add(this.trackNameLabel);
            this.trackPanel.Controls.Add(this.thumbnailBox);
            this.trackPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.trackPanel.Location = new System.Drawing.Point(328, 0);
            this.trackPanel.Name = "trackPanel";
            this.trackPanel.Size = new System.Drawing.Size(233, 53);
            this.trackPanel.TabIndex = 5;
            // 
            // albumLabel
            // 
            this.albumLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.albumLabel.Location = new System.Drawing.Point(63, 30);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(143, 19);
            this.albumLabel.TabIndex = 1;
            this.albumLabel.Text = "Unknown album";
            // 
            // trackNameLabel
            // 
            this.trackNameLabel.AutoSize = true;
            this.trackNameLabel.Location = new System.Drawing.Point(62, 5);
            this.trackNameLabel.Name = "trackNameLabel";
            this.trackNameLabel.Size = new System.Drawing.Size(91, 15);
            this.trackNameLabel.TabIndex = 0;
            this.trackNameLabel.Text = "Unknown name";
            // 
            // thumbnailBox
            // 
            this.thumbnailBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.thumbnailBox.Image = global::Soundger.Properties.Resources.thumb;
            this.thumbnailBox.Location = new System.Drawing.Point(0, 0);
            this.thumbnailBox.Name = "thumbnailBox";
            this.thumbnailBox.Size = new System.Drawing.Size(56, 53);
            this.thumbnailBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thumbnailBox.TabIndex = 0;
            this.thumbnailBox.TabStop = false;
            // 
            // volumePanel
            // 
            this.volumePanel.BackColor = System.Drawing.Color.Transparent;
            this.volumePanel.Controls.Add(this.volumeBar);
            this.volumePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.volumePanel.Location = new System.Drawing.Point(737, 0);
            this.volumePanel.Name = "volumePanel";
            this.volumePanel.Size = new System.Drawing.Size(216, 53);
            this.volumePanel.TabIndex = 4;
            // 
            // volumeBar
            // 
            this.volumeBar.AutoSize = false;
            this.volumeBar.LargeChange = 0;
            this.volumeBar.Location = new System.Drawing.Point(70, 14);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(137, 28);
            this.volumeBar.SmallChange = 0;
            this.volumeBar.TabIndex = 0;
            this.volumeBar.TabStop = false;
            this.volumeBar.TickFrequency = 10;
            this.volumeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeBar.Value = 50;
            this.volumeBar.ValueChanged += new System.EventHandler(this.volumeBar_ValueChanged);
            this.volumeBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.volumeBar_MouseDown);
            // 
            // ac_p1
            // 
            this.ac_p1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ac_p1.Location = new System.Drawing.Point(197, 0);
            this.ac_p1.Name = "ac_p1";
            this.ac_p1.Size = new System.Drawing.Size(131, 53);
            this.ac_p1.TabIndex = 3;
            // 
            // nextPb
            // 
            this.nextPb.Dock = System.Windows.Forms.DockStyle.Left;
            this.nextPb.Image = global::Soundger.Properties.Resources.next;
            this.nextPb.Location = new System.Drawing.Point(132, 0);
            this.nextPb.Name = "nextPb";
            this.nextPb.Size = new System.Drawing.Size(65, 53);
            this.nextPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nextPb.TabIndex = 2;
            this.nextPb.TabStop = false;
            // 
            // playPb
            // 
            this.playPb.Dock = System.Windows.Forms.DockStyle.Left;
            this.playPb.Image = global::Soundger.Properties.Resources.play;
            this.playPb.Location = new System.Drawing.Point(72, 0);
            this.playPb.Name = "playPb";
            this.playPb.Size = new System.Drawing.Size(60, 53);
            this.playPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playPb.TabIndex = 1;
            this.playPb.TabStop = false;
            // 
            // prevPb
            // 
            this.prevPb.Dock = System.Windows.Forms.DockStyle.Left;
            this.prevPb.Image = global::Soundger.Properties.Resources.back;
            this.prevPb.Location = new System.Drawing.Point(10, 0);
            this.prevPb.Name = "prevPb";
            this.prevPb.Size = new System.Drawing.Size(62, 53);
            this.prevPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prevPb.TabIndex = 0;
            this.prevPb.TabStop = false;
            // 
            // statusBarPanel
            // 
            this.statusBarPanel.BackColor = System.Drawing.Color.Transparent;
            this.statusBarPanel.Controls.Add(this.trackBar);
            this.statusBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusBarPanel.Location = new System.Drawing.Point(0, 0);
            this.statusBarPanel.Name = "statusBarPanel";
            this.statusBarPanel.Size = new System.Drawing.Size(953, 10);
            this.statusBarPanel.TabIndex = 0;
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.Color.Transparent;
            this.trackBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.trackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBar.LargeChange = 1;
            this.trackBar.Location = new System.Drawing.Point(0, 0);
            this.trackBar.Maximum = 240000;
            this.trackBar.MouseWheelBarPartitions = 100;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(953, 10);
            this.trackBar.SmallChange = 0;
            this.trackBar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.trackBar.TabIndex = 0;
            this.trackBar.TabStop = false;
            this.trackBar.Value = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.Controls.Add(this.sideMenuPanel);
            this.sidePanel.Controls.Add(this.sp_header);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(2, 2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(178, 470);
            this.sidePanel.TabIndex = 1;
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.Controls.Add(this.settingsItem);
            this.sideMenuPanel.Controls.Add(this.filesItem);
            this.sideMenuPanel.Controls.Add(this.myItem);
            this.sideMenuPanel.Controls.Add(this.smp_4);
            this.sideMenuPanel.Controls.Add(this.smp_3);
            this.sideMenuPanel.Controls.Add(this.mainItem);
            this.sideMenuPanel.Controls.Add(this.smp_2);
            this.sideMenuPanel.Controls.Add(this.profileItem);
            this.sideMenuPanel.Controls.Add(this.smp_1);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 48);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(178, 422);
            this.sideMenuPanel.TabIndex = 1;
            // 
            // settingsItem
            // 
            this.settingsItem.Active = false;
            this.settingsItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingsItem.Icon = null;
            this.settingsItem.Label = "";
            this.settingsItem.Location = new System.Drawing.Point(0, 308);
            this.settingsItem.Name = "settingsItem";
            this.settingsItem.Size = new System.Drawing.Size(178, 48);
            this.settingsItem.TabIndex = 7;
            // 
            // filesItem
            // 
            this.filesItem.Active = false;
            this.filesItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.filesItem.Icon = null;
            this.filesItem.Label = "";
            this.filesItem.Location = new System.Drawing.Point(0, 171);
            this.filesItem.Name = "filesItem";
            this.filesItem.Size = new System.Drawing.Size(178, 46);
            this.filesItem.TabIndex = 6;
            // 
            // myItem
            // 
            this.myItem.Active = false;
            this.myItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.myItem.Icon = null;
            this.myItem.Label = "";
            this.myItem.Location = new System.Drawing.Point(0, 125);
            this.myItem.Name = "myItem";
            this.myItem.Size = new System.Drawing.Size(178, 46);
            this.myItem.TabIndex = 5;
            // 
            // smp_4
            // 
            this.smp_4.Controls.Add(this.smp_4_l);
            this.smp_4.Dock = System.Windows.Forms.DockStyle.Top;
            this.smp_4.Location = new System.Drawing.Point(0, 92);
            this.smp_4.Name = "smp_4";
            this.smp_4.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.smp_4.Size = new System.Drawing.Size(178, 33);
            this.smp_4.TabIndex = 4;
            // 
            // smp_4_l
            // 
            this.smp_4_l.Dock = System.Windows.Forms.DockStyle.Fill;
            this.smp_4_l.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.smp_4_l.Location = new System.Drawing.Point(7, 0);
            this.smp_4_l.Name = "smp_4_l";
            this.smp_4_l.Size = new System.Drawing.Size(171, 33);
            this.smp_4_l.TabIndex = 0;
            this.smp_4_l.Text = "MY MUSIC";
            this.smp_4_l.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // smp_3
            // 
            this.smp_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.smp_3.Location = new System.Drawing.Point(0, 71);
            this.smp_3.Name = "smp_3";
            this.smp_3.Size = new System.Drawing.Size(178, 21);
            this.smp_3.TabIndex = 3;
            // 
            // mainItem
            // 
            this.mainItem.Active = false;
            this.mainItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainItem.Icon = null;
            this.mainItem.Label = "";
            this.mainItem.Location = new System.Drawing.Point(0, 25);
            this.mainItem.Name = "mainItem";
            this.mainItem.Size = new System.Drawing.Size(178, 46);
            this.mainItem.TabIndex = 2;
            // 
            // smp_2
            // 
            this.smp_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.smp_2.Location = new System.Drawing.Point(0, 0);
            this.smp_2.Name = "smp_2";
            this.smp_2.Size = new System.Drawing.Size(178, 25);
            this.smp_2.TabIndex = 1;
            // 
            // profileItem
            // 
            this.profileItem.Active = false;
            this.profileItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.profileItem.Icon = null;
            this.profileItem.Label = "";
            this.profileItem.Location = new System.Drawing.Point(0, 356);
            this.profileItem.Name = "profileItem";
            this.profileItem.Size = new System.Drawing.Size(178, 48);
            this.profileItem.TabIndex = 0;
            // 
            // smp_1
            // 
            this.smp_1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.smp_1.Location = new System.Drawing.Point(0, 404);
            this.smp_1.Name = "smp_1";
            this.smp_1.Size = new System.Drawing.Size(178, 18);
            this.smp_1.TabIndex = 0;
            // 
            // sp_header
            // 
            this.sp_header.Controls.Add(this.toggleSideMenuButton);
            this.sp_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.sp_header.Location = new System.Drawing.Point(0, 0);
            this.sp_header.Name = "sp_header";
            this.sp_header.Size = new System.Drawing.Size(178, 48);
            this.sp_header.TabIndex = 0;
            // 
            // toggleSideMenuButton
            // 
            this.toggleSideMenuButton.BackgroundImage = global::Soundger.Properties.Resources.menu;
            this.toggleSideMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toggleSideMenuButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.toggleSideMenuButton.FlatAppearance.BorderSize = 0;
            this.toggleSideMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleSideMenuButton.Location = new System.Drawing.Point(0, 0);
            this.toggleSideMenuButton.Name = "toggleSideMenuButton";
            this.toggleSideMenuButton.Size = new System.Drawing.Size(48, 48);
            this.toggleSideMenuButton.TabIndex = 0;
            this.toggleSideMenuButton.TabStop = false;
            this.toggleSideMenuButton.UseVisualStyleBackColor = true;
            this.toggleSideMenuButton.Click += new System.EventHandler(this.toggleSideMenuButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(180, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(775, 470);
            this.mainPanel.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(957, 537);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.bottomPanel);
            this.MinimumSize = new System.Drawing.Size(818, 520);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.bottomPanel.ResumeLayout(false);
            this.audioControlsPanel.ResumeLayout(false);
            this.trackPanel.ResumeLayout(false);
            this.trackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailBox)).EndInit();
            this.volumePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevPb)).EndInit();
            this.statusBarPanel.ResumeLayout(false);
            this.sidePanel.ResumeLayout(false);
            this.sideMenuPanel.ResumeLayout(false);
            this.smp_4.ResumeLayout(false);
            this.sp_header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel bottomPanel;
        private Panel sidePanel;
        private Panel sp_header;
        private Panel mainPanel;
        private Button toggleSideMenuButton;
        private Panel sideMenuPanel;
        private Panel smp_1;
        private SideMenuItemControl profileItem;
        private Panel audioControlsPanel;
        private Panel statusBarPanel;
        private SideMenuItemControl mainItem;
        private Panel smp_2;
        private MetroFramework.Controls.MetroTrackBar trackBar;
        private PictureBox nextPb;
        private PictureBox playPb;
        private PictureBox prevPb;
        private System.Windows.Forms.Timer timer1;
        private Panel volumePanel;
        private Panel ac_p1;
        private Panel smp_3;
        private Panel smp_4;
        private Label smp_4_l;
        private SideMenuItemControl myItem;
        private SideMenuItemControl filesItem;
        private TrackBar volumeBar;
        private Panel trackPanel;
        private PictureBox thumbnailBox;
        private Label albumLabel;
        private Label trackNameLabel;
        private SideMenuItemControl settingsItem;
    }
}