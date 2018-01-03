namespace WindowsFormsApp2
{
    partial class PasswordRecovery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordRecovery));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.warningLable = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.send = new Bunifu.Framework.UI.BunifuFlatButton();
            this.verifyNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.accept = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Time = new System.Windows.Forms.Label();
            this.attempt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passwordSet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(441, 32);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(166, 6);
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
            this.closeButton.Location = new System.Drawing.Point(405, 3);
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
            // id
            // 
            this.id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(184)))), ((int)(((byte)(135)))));
            this.id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.id.HintForeColor = System.Drawing.Color.Gray;
            this.id.HintText = "Email";
            this.id.isPassword = false;
            this.id.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            this.id.LineIdleColor = System.Drawing.Color.Gray;
            this.id.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            this.id.LineThickness = 3;
            this.id.Location = new System.Drawing.Point(69, 166);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(212, 44);
            this.id.TabIndex = 17;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.id.OnValueChanged += new System.EventHandler(this.id_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Find your password by email verification";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 39);
            this.label1.TabIndex = 18;
            this.label1.Text = "PasswordRecovery";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // send
            // 
            this.send.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.send.BorderRadius = 0;
            this.send.ButtonText = "Send";
            this.send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send.DisabledColor = System.Drawing.Color.Gray;
            this.send.Enabled = false;
            this.send.Iconcolor = System.Drawing.Color.Transparent;
            this.send.Iconimage = ((System.Drawing.Image)(resources.GetObject("send.Iconimage")));
            this.send.Iconimage_right = null;
            this.send.Iconimage_right_Selected = null;
            this.send.Iconimage_Selected = null;
            this.send.IconMarginLeft = 0;
            this.send.IconMarginRight = 0;
            this.send.IconRightVisible = true;
            this.send.IconRightZoom = 0D;
            this.send.IconVisible = true;
            this.send.IconZoom = 90D;
            this.send.IsTab = false;
            this.send.Location = new System.Drawing.Point(300, 166);
            this.send.Name = "send";
            this.send.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.send.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.send.OnHoverTextColor = System.Drawing.Color.White;
            this.send.selected = false;
            this.send.Size = new System.Drawing.Size(96, 44);
            this.send.TabIndex = 20;
            this.send.Text = "Send";
            this.send.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.send.Textcolor = System.Drawing.Color.White;
            this.send.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // verifyNumber
            // 
            this.verifyNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(184)))), ((int)(((byte)(135)))));
            this.verifyNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.verifyNumber.Enabled = false;
            this.verifyNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.verifyNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.verifyNumber.HintForeColor = System.Drawing.Color.Gray;
            this.verifyNumber.HintText = "VerifyNumber";
            this.verifyNumber.isPassword = false;
            this.verifyNumber.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            this.verifyNumber.LineIdleColor = System.Drawing.Color.Gray;
            this.verifyNumber.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            this.verifyNumber.LineThickness = 3;
            this.verifyNumber.Location = new System.Drawing.Point(69, 218);
            this.verifyNumber.Margin = new System.Windows.Forms.Padding(4);
            this.verifyNumber.Name = "verifyNumber";
            this.verifyNumber.Size = new System.Drawing.Size(122, 44);
            this.verifyNumber.TabIndex = 17;
            this.verifyNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.verifyNumber.OnValueChanged += new System.EventHandler(this.verifyNumber_OnValueChanged);
            // 
            // accept
            // 
            this.accept.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.accept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.accept.BorderRadius = 0;
            this.accept.ButtonText = "Accept";
            this.accept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accept.DisabledColor = System.Drawing.Color.Gray;
            this.accept.Enabled = false;
            this.accept.Iconcolor = System.Drawing.Color.Transparent;
            this.accept.Iconimage = ((System.Drawing.Image)(resources.GetObject("accept.Iconimage")));
            this.accept.Iconimage_right = null;
            this.accept.Iconimage_right_Selected = null;
            this.accept.Iconimage_Selected = null;
            this.accept.IconMarginLeft = 0;
            this.accept.IconMarginRight = 0;
            this.accept.IconRightVisible = true;
            this.accept.IconRightZoom = 0D;
            this.accept.IconVisible = true;
            this.accept.IconZoom = 90D;
            this.accept.IsTab = false;
            this.accept.Location = new System.Drawing.Point(300, 218);
            this.accept.Name = "accept";
            this.accept.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.accept.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.accept.OnHoverTextColor = System.Drawing.Color.White;
            this.accept.selected = false;
            this.accept.Size = new System.Drawing.Size(96, 44);
            this.accept.TabIndex = 20;
            this.accept.Text = "Accept";
            this.accept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accept.Textcolor = System.Drawing.Color.White;
            this.accept.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // Time
            // 
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(198, 218);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(83, 22);
            this.Time.TabIndex = 19;
            this.Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // attempt
            // 
            this.attempt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attempt.Location = new System.Drawing.Point(198, 240);
            this.attempt.Name = "attempt";
            this.attempt.Size = new System.Drawing.Size(83, 22);
            this.attempt.TabIndex = 19;
            this.attempt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(184)))), ((int)(((byte)(135)))));
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password.HintForeColor = System.Drawing.Color.Gray;
            this.password.HintText = "Password";
            this.password.isPassword = true;
            this.password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            this.password.LineIdleColor = System.Drawing.Color.Gray;
            this.password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(92)))), ((int)(((byte)(85)))));
            this.password.LineThickness = 3;
            this.password.Location = new System.Drawing.Point(69, 270);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(212, 44);
            this.password.TabIndex = 17;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.Visible = false;
            this.password.OnValueChanged += new System.EventHandler(this.password_OnValueChanged);
            // 
            // passwordSet
            // 
            this.passwordSet.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.passwordSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.passwordSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passwordSet.BorderRadius = 0;
            this.passwordSet.ButtonText = "Set";
            this.passwordSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordSet.DisabledColor = System.Drawing.Color.Gray;
            this.passwordSet.Iconcolor = System.Drawing.Color.Transparent;
            this.passwordSet.Iconimage = ((System.Drawing.Image)(resources.GetObject("passwordSet.Iconimage")));
            this.passwordSet.Iconimage_right = null;
            this.passwordSet.Iconimage_right_Selected = null;
            this.passwordSet.Iconimage_Selected = null;
            this.passwordSet.IconMarginLeft = 0;
            this.passwordSet.IconMarginRight = 0;
            this.passwordSet.IconRightVisible = true;
            this.passwordSet.IconRightZoom = 0D;
            this.passwordSet.IconVisible = true;
            this.passwordSet.IconZoom = 90D;
            this.passwordSet.IsTab = false;
            this.passwordSet.Location = new System.Drawing.Point(300, 268);
            this.passwordSet.Name = "passwordSet";
            this.passwordSet.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.passwordSet.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.passwordSet.OnHoverTextColor = System.Drawing.Color.White;
            this.passwordSet.selected = false;
            this.passwordSet.Size = new System.Drawing.Size(96, 44);
            this.passwordSet.TabIndex = 20;
            this.passwordSet.Text = "Set";
            this.passwordSet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passwordSet.Textcolor = System.Drawing.Color.White;
            this.passwordSet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordSet.Visible = false;
            this.passwordSet.Click += new System.EventHandler(this.passwordSet_Click);
            // 
            // PasswordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(214)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(441, 363);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.passwordSet);
            this.Controls.Add(this.send);
            this.Controls.Add(this.attempt);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.verifyNumber);
            this.Controls.Add(this.password);
            this.Controls.Add(this.id);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PasswordRecovery";
            this.Text = "PasswordRecovery";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label warningLable;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton send;
        private Bunifu.Framework.UI.BunifuMaterialTextbox verifyNumber;
        private Bunifu.Framework.UI.BunifuFlatButton accept;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label attempt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private Bunifu.Framework.UI.BunifuFlatButton passwordSet;
    }
}