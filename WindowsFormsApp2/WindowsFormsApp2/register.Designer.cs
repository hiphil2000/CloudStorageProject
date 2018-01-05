namespace WindowsFormsApp2
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.warningLable = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pw = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.phone2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.phone3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.phone1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.registerButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.warningLable);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 32);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(139, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "CloudStorage";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
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
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.closeButton.Location = new System.Drawing.Point(348, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 24);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 9;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(999, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 24);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "CloudStorage";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Register";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(184)))), ((int)(((byte)(135)))));
            this.id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.id.HintForeColor = System.Drawing.Color.Gray;
            this.id.HintText = "ID";
            this.id.isPassword = false;
            this.id.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            this.id.LineIdleColor = System.Drawing.Color.Gray;
            this.id.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            this.id.LineThickness = 3;
            this.id.Location = new System.Drawing.Point(72, 154);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(240, 33);
            this.id.TabIndex = 14;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pw
            // 
            this.pw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(184)))), ((int)(((byte)(135)))));
            this.pw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pw.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.pw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pw.HintForeColor = System.Drawing.Color.Gray;
            this.pw.HintText = "Password";
            this.pw.isPassword = true;
            this.pw.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            this.pw.LineIdleColor = System.Drawing.Color.Gray;
            this.pw.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            this.pw.LineThickness = 3;
            this.pw.Location = new System.Drawing.Point(72, 195);
            this.pw.Margin = new System.Windows.Forms.Padding(4);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(240, 33);
            this.pw.TabIndex = 14;
            this.pw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pw.OnValueChanged += new System.EventHandler(this.pw_OnValueChanged);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(184)))), ((int)(((byte)(135)))));
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email.HintForeColor = System.Drawing.Color.Gray;
            this.email.HintText = "Email@egxample.com";
            this.email.isPassword = false;
            this.email.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            this.email.LineIdleColor = System.Drawing.Color.Gray;
            this.email.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            this.email.LineThickness = 3;
            this.email.Location = new System.Drawing.Point(72, 278);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(240, 33);
            this.email.TabIndex = 14;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.email.OnValueChanged += new System.EventHandler(this.email_OnValueChanged);
            // 
            // phone2
            // 
            this.phone2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(184)))), ((int)(((byte)(135)))));
            this.phone2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phone2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.phone2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phone2.HintForeColor = System.Drawing.Color.Gray;
            this.phone2.HintText = "phone";
            this.phone2.isPassword = false;
            this.phone2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            this.phone2.LineIdleColor = System.Drawing.Color.Gray;
            this.phone2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            this.phone2.LineThickness = 3;
            this.phone2.Location = new System.Drawing.Point(154, 319);
            this.phone2.Margin = new System.Windows.Forms.Padding(4);
            this.phone2.Name = "phone2";
            this.phone2.Size = new System.Drawing.Size(73, 42);
            this.phone2.TabIndex = 14;
            this.phone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // phone3
            // 
            this.phone3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(184)))), ((int)(((byte)(135)))));
            this.phone3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phone3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.phone3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phone3.HintForeColor = System.Drawing.Color.Gray;
            this.phone3.HintText = "phone";
            this.phone3.isPassword = false;
            this.phone3.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            this.phone3.LineIdleColor = System.Drawing.Color.Gray;
            this.phone3.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            this.phone3.LineThickness = 3;
            this.phone3.Location = new System.Drawing.Point(239, 319);
            this.phone3.Margin = new System.Windows.Forms.Padding(4);
            this.phone3.Name = "phone3";
            this.phone3.Size = new System.Drawing.Size(73, 42);
            this.phone3.TabIndex = 14;
            this.phone3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // phone1
            // 
            this.phone1.BackColor = System.Drawing.Color.Transparent;
            this.phone1.BorderRadius = 3;
            this.phone1.DisabledColor = System.Drawing.Color.Gray;
            this.phone1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.phone1.ForeColor = System.Drawing.Color.White;
            this.phone1.Items = new string[] {
        "010",
        "011",
        "016",
        "017",
        "018",
        "019"};
            this.phone1.Location = new System.Drawing.Point(72, 319);
            this.phone1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phone1.Name = "phone1";
            this.phone1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            this.phone1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(112)))), ((int)(((byte)(105)))));
            this.phone1.selectedIndex = -1;
            this.phone1.Size = new System.Drawing.Size(73, 42);
            this.phone1.TabIndex = 15;
            // 
            // registerButton
            // 
            this.registerButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.registerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registerButton.BorderRadius = 0;
            this.registerButton.ButtonText = "Register";
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.DisabledColor = System.Drawing.Color.Gray;
            this.registerButton.Iconcolor = System.Drawing.Color.Transparent;
            this.registerButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("registerButton.Iconimage")));
            this.registerButton.Iconimage_right = null;
            this.registerButton.Iconimage_right_Selected = null;
            this.registerButton.Iconimage_Selected = null;
            this.registerButton.IconMarginLeft = 0;
            this.registerButton.IconMarginRight = 0;
            this.registerButton.IconRightVisible = true;
            this.registerButton.IconRightZoom = 0D;
            this.registerButton.IconVisible = true;
            this.registerButton.IconZoom = 90D;
            this.registerButton.IsTab = false;
            this.registerButton.Location = new System.Drawing.Point(72, 385);
            this.registerButton.Name = "registerButton";
            this.registerButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.registerButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.registerButton.OnHoverTextColor = System.Drawing.Color.White;
            this.registerButton.selected = false;
            this.registerButton.Size = new System.Drawing.Size(112, 44);
            this.registerButton.TabIndex = 16;
            this.registerButton.Text = "Register";
            this.registerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registerButton.Textcolor = System.Drawing.Color.White;
            this.registerButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // cancel
            // 
            this.cancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancel.BorderRadius = 0;
            this.cancel.ButtonText = "Cancel";
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.DisabledColor = System.Drawing.Color.Gray;
            this.cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.cancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("cancel.Iconimage")));
            this.cancel.Iconimage_right = null;
            this.cancel.Iconimage_right_Selected = null;
            this.cancel.Iconimage_Selected = null;
            this.cancel.IconMarginLeft = 0;
            this.cancel.IconMarginRight = 0;
            this.cancel.IconRightVisible = true;
            this.cancel.IconRightZoom = 0D;
            this.cancel.IconVisible = true;
            this.cancel.IconZoom = 90D;
            this.cancel.IsTab = false;
            this.cancel.Location = new System.Drawing.Point(200, 385);
            this.cancel.Name = "cancel";
            this.cancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.cancel.selected = false;
            this.cancel.Size = new System.Drawing.Size(112, 44);
            this.cancel.TabIndex = 16;
            this.cancel.Text = "Cancel";
            this.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel.Textcolor = System.Drawing.Color.White;
            this.cancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(184)))), ((int)(((byte)(135)))));
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.name.HintForeColor = System.Drawing.Color.Gray;
            this.name.HintText = "Name";
            this.name.isPassword = false;
            this.name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            this.name.LineIdleColor = System.Drawing.Color.Gray;
            this.name.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            this.name.LineThickness = 3;
            this.name.Location = new System.Drawing.Point(72, 236);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(240, 33);
            this.name.TabIndex = 14;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.questionMark;
            this.pictureBox2.Location = new System.Drawing.Point(320, 278);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(214)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(384, 476);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.phone1);
            this.Controls.Add(this.phone3);
            this.Controls.Add(this.phone2);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "register";
            this.Text = "register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label warningLable;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox id;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pw;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phone2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phone3;
        private Bunifu.Framework.UI.BunifuDropdown phone1;
        private Bunifu.Framework.UI.BunifuFlatButton registerButton;
        private Bunifu.Framework.UI.BunifuFlatButton cancel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}