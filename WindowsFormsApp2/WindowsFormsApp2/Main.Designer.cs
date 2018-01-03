namespace WindowsFormsApp2
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.warningLable = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.resources = new Bunifu.Framework.UI.BunifuFlatButton();
            this.users = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "CloudStorageClient";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.warningLable);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 32);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(472, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "CloudStorage";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // warningLable
            // 
            this.warningLable.AutoSize = true;
            this.warningLable.BackColor = System.Drawing.Color.Transparent;
            this.warningLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(166)))), ((int)(((byte)(123)))));
            this.warningLable.Location = new System.Drawing.Point(38, 3);
            this.warningLable.Name = "warningLable";
            this.warningLable.Size = new System.Drawing.Size(13, 12);
            this.warningLable.TabIndex = 10;
            this.warningLable.Text = "  ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox3.Location = new System.Drawing.Point(12, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = global::WindowsFormsApp2.Properties.Resources.close;
            this.closeButton.Location = new System.Drawing.Point(1011, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 24);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 9;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 32);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(134)))), ((int)(((byte)(173)))));
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.resources);
            this.splitContainer1.Panel1.Controls.Add(this.users);
            this.splitContainer1.Panel1.Controls.Add(this.dashboard);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1047, 507);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 10;
            // 
            // resources
            // 
            this.resources.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(78)))), ((int)(((byte)(100)))));
            this.resources.BackColor = System.Drawing.Color.Transparent;
            this.resources.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resources.BorderRadius = 0;
            this.resources.ButtonText = "Resources";
            this.resources.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resources.DisabledColor = System.Drawing.Color.Gray;
            this.resources.Iconcolor = System.Drawing.Color.Transparent;
            this.resources.Iconimage = ((System.Drawing.Image)(resources.GetObject("resources.Iconimage")));
            this.resources.Iconimage_right = null;
            this.resources.Iconimage_right_Selected = null;
            this.resources.Iconimage_Selected = null;
            this.resources.IconMarginLeft = 0;
            this.resources.IconMarginRight = 0;
            this.resources.IconRightVisible = true;
            this.resources.IconRightZoom = 0D;
            this.resources.IconVisible = true;
            this.resources.IconZoom = 90D;
            this.resources.IsTab = false;
            this.resources.Location = new System.Drawing.Point(0, 228);
            this.resources.Name = "resources";
            this.resources.Normalcolor = System.Drawing.Color.Transparent;
            this.resources.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(102)))), ((int)(((byte)(132)))));
            this.resources.OnHoverTextColor = System.Drawing.Color.White;
            this.resources.selected = false;
            this.resources.Size = new System.Drawing.Size(226, 44);
            this.resources.TabIndex = 3;
            this.resources.Text = "Resources";
            this.resources.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resources.Textcolor = System.Drawing.Color.White;
            this.resources.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // users
            // 
            this.users.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(78)))), ((int)(((byte)(100)))));
            this.users.BackColor = System.Drawing.Color.Transparent;
            this.users.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.users.BorderRadius = 0;
            this.users.ButtonText = "Users";
            this.users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users.DisabledColor = System.Drawing.Color.Gray;
            this.users.Iconcolor = System.Drawing.Color.Transparent;
            this.users.Iconimage = ((System.Drawing.Image)(resources.GetObject("users.Iconimage")));
            this.users.Iconimage_right = null;
            this.users.Iconimage_right_Selected = null;
            this.users.Iconimage_Selected = null;
            this.users.IconMarginLeft = 0;
            this.users.IconMarginRight = 0;
            this.users.IconRightVisible = true;
            this.users.IconRightZoom = 0D;
            this.users.IconVisible = true;
            this.users.IconZoom = 90D;
            this.users.IsTab = false;
            this.users.Location = new System.Drawing.Point(0, 184);
            this.users.Name = "users";
            this.users.Normalcolor = System.Drawing.Color.Transparent;
            this.users.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(102)))), ((int)(((byte)(132)))));
            this.users.OnHoverTextColor = System.Drawing.Color.White;
            this.users.selected = false;
            this.users.Size = new System.Drawing.Size(226, 44);
            this.users.TabIndex = 2;
            this.users.Text = "Users";
            this.users.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.users.Textcolor = System.Drawing.Color.White;
            this.users.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dashboard
            // 
            this.dashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(78)))), ((int)(((byte)(100)))));
            this.dashboard.BackColor = System.Drawing.Color.Transparent;
            this.dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboard.BorderRadius = 0;
            this.dashboard.ButtonText = "Dashboard";
            this.dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard.DisabledColor = System.Drawing.Color.Gray;
            this.dashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.dashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("dashboard.Iconimage")));
            this.dashboard.Iconimage_right = null;
            this.dashboard.Iconimage_right_Selected = null;
            this.dashboard.Iconimage_Selected = null;
            this.dashboard.IconMarginLeft = 0;
            this.dashboard.IconMarginRight = 0;
            this.dashboard.IconRightVisible = true;
            this.dashboard.IconRightZoom = 0D;
            this.dashboard.IconVisible = true;
            this.dashboard.IconZoom = 90D;
            this.dashboard.IsTab = false;
            this.dashboard.Location = new System.Drawing.Point(0, 140);
            this.dashboard.Name = "dashboard";
            this.dashboard.Normalcolor = System.Drawing.Color.Transparent;
            this.dashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(102)))), ((int)(((byte)(132)))));
            this.dashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.dashboard.selected = false;
            this.dashboard.Size = new System.Drawing.Size(226, 44);
            this.dashboard.TabIndex = 1;
            this.dashboard.Text = "Dashboard";
            this.dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard.Textcolor = System.Drawing.Color.White;
            this.dashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.username);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 140);
            this.panel2.TabIndex = 0;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(12, 104);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(201, 20);
            this.username.TabIndex = 18;
            this.username.Text = "Welcome, ";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.제목_없음_2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 399);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 108);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ko Hyeonseo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(214)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(1047, 541);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "CloudStorage";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label warningLable;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton resources;
        private Bunifu.Framework.UI.BunifuFlatButton users;
        private Bunifu.Framework.UI.BunifuFlatButton dashboard;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}