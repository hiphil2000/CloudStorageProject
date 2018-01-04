using LiveCharts;
using LiveCharts.Wpf;
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
using System.Windows.Media;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{
    public partial class Main : Form
    {
        Db db = new Db();
        private Point mousePoint;
        bool canLogin = false;
        Panel prevPanel;
        public Main(string name)
        {
            InitializeComponent();
            this.notifyIcon1.Icon = Properties.Resources.icon;
            this.notifyIcon1.Icon = Properties.Resources.icon;
            toolTip1.SetToolTip(minimalizeButton, "창 최소화");
            toolTip1.SetToolTip(closeButton, "창 닫기");
            this.username.Text = this.username.Text + name + "!";
            initDashboard();
            dashBoardPanel.Visible = true;
            prevPanel = dashBoardPanel;
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
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            if (prevPanel.Equals(dashBoardPanel))
                return;
            
            prevPanel.Visible = false;
            prevPanel = dashBoardPanel;
            dashBoardPanel.Visible = true;
            initDashboard();
        }

        private void closeButton_MouseHover(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.BackColor = System.Drawing.Color.FromArgb(pic.BackColor.R + 30 > 255 ? 255:pic.BackColor.R + 30,
                pic.BackColor.G + 30 > 255 ? 255 : pic.BackColor.G + 30,
                pic.BackColor.B + 30 > 255 ? 255 : pic.BackColor.B + 30);
        }

        private void minimalizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimalizeButton_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.BackColor = System.Drawing.Color.FromArgb(pic.BackColor.R - 30 < 0 ? 0 : pic.BackColor.R - 30,
                pic.BackColor.G - 30 < 0 ? 0 : pic.BackColor.G - 30,
                pic.BackColor.B - 30 < 0 ? 0 : pic.BackColor.B - 30);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void initDashboard()
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
              string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            dataStatPie.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Files",
                    Values = new ChartValues<double> {4},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Documents",
                    Values = new ChartValues<double> {4},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Videos",
                    Values = new ChartValues<double> {6},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Etc...",
                    Values = new ChartValues<double> {2},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };

            dataStatPie.LegendLocation = LegendLocation.Bottom;
            dataUseageGauge.To = 100;
            dataUseageGauge.Value = 50;
            dataUseageGauge.FromColor = Colors.LimeGreen;
            dataUseageGauge.ToColor = Colors.Red;
        }

        private void users_Click(object sender, EventArgs e)
        {
            
        }

        private void resource_Click(object sender, EventArgs e)
        {
            if (prevPanel.Equals(resourcePanel))
                return;
            prevPanel.Visible = false;
            prevPanel = resourcePanel;
            resourcePanel.Visible = true;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }
    }
}
