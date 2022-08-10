namespace Soundger.Desktop.View
{
    partial class SideMenuItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.smp_2_ip = new System.Windows.Forms.Panel();
            this.smp_2_ip_pb = new System.Windows.Forms.PictureBox();
            this.smp_2_l = new System.Windows.Forms.Panel();
            this.smp_2_apb = new System.Windows.Forms.PictureBox();
            this.smp_2_label = new System.Windows.Forms.Label();
            this.smp_2_ip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smp_2_ip_pb)).BeginInit();
            this.smp_2_l.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smp_2_apb)).BeginInit();
            this.SuspendLayout();
            // 
            // smp_2_ip
            // 
            this.smp_2_ip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.smp_2_ip.Controls.Add(this.smp_2_ip_pb);
            this.smp_2_ip.Dock = System.Windows.Forms.DockStyle.Left;
            this.smp_2_ip.Location = new System.Drawing.Point(11, 0);
            this.smp_2_ip.Name = "smp_2_ip";
            this.smp_2_ip.Padding = new System.Windows.Forms.Padding(0, 6, 8, 6);
            this.smp_2_ip.Size = new System.Drawing.Size(37, 45);
            this.smp_2_ip.TabIndex = 1;
            // 
            // smp_2_ip_pb
            // 
            this.smp_2_ip_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.smp_2_ip_pb.Location = new System.Drawing.Point(0, 6);
            this.smp_2_ip_pb.Name = "smp_2_ip_pb";
            this.smp_2_ip_pb.Size = new System.Drawing.Size(29, 33);
            this.smp_2_ip_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.smp_2_ip_pb.TabIndex = 0;
            this.smp_2_ip_pb.TabStop = false;
            // 
            // smp_2_l
            // 
            this.smp_2_l.Controls.Add(this.smp_2_apb);
            this.smp_2_l.Dock = System.Windows.Forms.DockStyle.Left;
            this.smp_2_l.Location = new System.Drawing.Point(0, 0);
            this.smp_2_l.Name = "smp_2_l";
            this.smp_2_l.Padding = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.smp_2_l.Size = new System.Drawing.Size(11, 45);
            this.smp_2_l.TabIndex = 0;
            // 
            // smp_2_apb
            // 
            this.smp_2_apb.BackgroundImage = global::Soundger.Desktop.Properties.Resources.active_item;
            this.smp_2_apb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.smp_2_apb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.smp_2_apb.Location = new System.Drawing.Point(2, 8);
            this.smp_2_apb.Name = "smp_2_apb";
            this.smp_2_apb.Size = new System.Drawing.Size(7, 29);
            this.smp_2_apb.TabIndex = 0;
            this.smp_2_apb.TabStop = false;
            this.smp_2_apb.Visible = false;
            // 
            // smp_2_label
            // 
            this.smp_2_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.smp_2_label.Location = new System.Drawing.Point(54, 8);
            this.smp_2_label.Name = "smp_2_label";
            this.smp_2_label.Size = new System.Drawing.Size(118, 29);
            this.smp_2_label.TabIndex = 2;
            this.smp_2_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SideMenuItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.smp_2_label);
            this.Controls.Add(this.smp_2_ip);
            this.Controls.Add(this.smp_2_l);
            this.Name = "SideMenuItemControl";
            this.Size = new System.Drawing.Size(178, 45);
            this.smp_2_ip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.smp_2_ip_pb)).EndInit();
            this.smp_2_l.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.smp_2_apb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel smp_2_ip;
        private PictureBox smp_2_ip_pb;
        private Panel smp_2_l;
        private PictureBox smp_2_apb;
        private Label smp_2_label;
    }
}
