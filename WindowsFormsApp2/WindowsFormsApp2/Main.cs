using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{
    public partial class Main : Form
    {
        Db db = new Db();
        private Point mousePoint;
        bool canLogin = false;
        public Main()
        {
            InitializeComponent();
        }

        //taskbar code

        private void Main_Resize(object sender, EventArgs e)
        {
            panel1.Width = this.Width;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("프로그램을 종료하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string errorMessage = "";
            int warningCount = 0;
            ResourceManager rm = Resources.ResourceManager;
            /*if(!d.connectChk())
            {
                errorMessage += "데이터베이스에 연결하지 못했습니다." + Environment.NewLine;
                //pictureBox3.BackgroundImage = Properties.Resources.warning;
                warningCount++;
                canLogin = false;
            }*/
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                errorMessage += "인터넷에 연결하지 못했습니다.";
                pictureBox3.Image = Properties.Resources.warning;
                warningCount++;
                canLogin = false;
            }
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                errorMessage = "모든 연결상태가 원활합니다.";
                pictureBox3.Image = Properties.Resources.ok;
                warningCount = 0;
                canLogin = true;
            }
            toolTip1.SetToolTip(pictureBox3, errorMessage);
            if (warningCount > 0)
                warningLable.Text = " " + warningCount + " ";
            pictureBox3.Refresh();
            pictureBox3.Visible = true;

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            Bitmap profilePic = db.loadImage(1);
            pictureBox1.Image = profilePic;
        }
    }
}
