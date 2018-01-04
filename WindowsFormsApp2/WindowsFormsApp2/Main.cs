using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections;
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
        string[] fileOriginal;
        int userSeq;

        public Main(string name, int userSeq)
        {
            InitializeComponent();
            this.notifyIcon1.Icon = Properties.Resources.icon;
            this.notifyIcon1.Icon = Properties.Resources.icon;
            this.userSeq = userSeq;
            toolTip1.SetToolTip(minimalizeButton, "창 최소화");
            toolTip1.SetToolTip(closeButton, "창 닫기");
            this.username.Text = this.username.Text + name + "!";
            initDashboard();
            dashBoardPanel.Visible = true;
            prevPanel = dashBoardPanel;
            dragdropBack.BackColor = System.Drawing.Color.FromArgb(25, System.Drawing.Color.LightGray);
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
            initResources();
            prevPanel.Visible = false;
            prevPanel = resourcePanel;
            resourcePanel.Visible = true;
        }

        static Control[] GetAllControlsUsingRecursive(Control containerControl)
        {
            List<Control> allControls = new List<Control>();

            foreach (Control control in containerControl.Controls)
            {
                //자식 컨트롤을 컬렉션에 추가한다
                allControls.Add(control);
                //만일 자식 컨트롤이 또 다른 자식 컨트롤을 가지고 있다면…
                if (control.Controls.Count > 0)
                {
                    //자신을 재귀적으로 호출한다
                    allControls.AddRange(GetAllControlsUsingRecursive(control));
                }
            }
            //모든 컨트롤을 반환한다
            return allControls.ToArray();
        }

        private void initResources()
        {
            Control[] children = GetAllControlsUsingRecursive(resourcePanel);
            
            for(int i = 0; i < children.Length; i++)
            {
                resourcePanel.Controls.Remove(children[i]);
            }

            DataSet ds = db.select(new[] { "fileName", "fileSize", "tb_user.userSeq" }, "tb_data, tb_user", "tb_data.userSeq = tb_user.userSeq");
            DataTable dt = new DataTable();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Bunifu.Framework.UI.BunifuCards card = new Bunifu.Framework.UI.BunifuCards();
                card.Size = new Size(178, 195);
                card.Parent = resourcePanel;


                PictureBox picture = new PictureBox();
                dt = ds.Tables["fileName"];
                picture.Image = getThumbnail(dt.Rows[0][i].ToString());
                picture.Location = new Point(23, 21);
                picture.Size = new Size(132, 99);
                picture.Parent = card;

                Label title = new Label();
                title.Text = dt.Rows[0][i].ToString();
                title.AutoSize = false;
                title.Size = new Size(132, 99);
                title.TextAlign = ContentAlignment.MiddleCenter;
                title.Font = new Font(new System.Drawing.FontFamily("Microsoft Sans Serif"), 12F);
                title.Location = new Point(23, 123);
                title.Parent = card;

                Label createDate = new Label();
                createDate.TextAlign = ContentAlignment.MiddleRight;
                createDate.Font = new Font(new System.Drawing.FontFamily("Microsoft Sans Serif"), 8.5F);
                createDate.Location = new Point(23, 145);
                createDate.Parent = card;

                Label leastDate = new Label();
                leastDate.TextAlign = ContentAlignment.MiddleRight;
                leastDate.Font = new Font(new System.Drawing.FontFamily("Microsoft Sans Serif"), 8.5F);
                leastDate.Location = new Point(23, 159);
                leastDate.Parent = card;

                card.Controls.Add(picture);
                card.Controls.Add(title);
                card.Controls.Add(createDate);
                card.Controls.Add(leastDate);

                resourcePanel.Controls.Add(card);
            }
        }

        private Image getThumbnail(string fileName)
        {
            string switchFileName = fileName.Split('.')[0];
            Image img;
            switch (switchFileName)
            {
                case "jpg":
                case "jpge":
                case "gif":
                case "png":
                case "bmp":
                case "rle":
                case "dib":
                case "tiff":
                case "raw":
                    img = Properties.Resources.Picture;
                    break;
                case "txt":
                case "rtf":
                case "hwp":
                case "pdf":
                case "doc":
                case "ppt":
                case "mdb":
                case "html":
                case "htm":
                    img = Properties.Resources.Document;
                    break;
                case "avi":
                case "mpg":
                case "mpeg":
                case "mpe":
                case "wmv":
                case "asv":
                case "asx":
                case "flv":
                case "mov":
                case "dat":
                    img = Properties.Resources.Video;
                    break;
                default:
                    img = Properties.Resources.Other;
                    break;
            }


            return img;
        }

        private void closeButton_MouseHover(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.BackColor = System.Drawing.Color.FromArgb(pic.BackColor.R + 30 > 255 ? 255 : pic.BackColor.R + 30,
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
        
        

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void Main_DragEnter(object sender, DragEventArgs e)
        {
            dragdropBack.Visible = true;
            dragdropFile.Visible = true;
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.All;
        }

        private void Main_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            fileOriginal = (string[])e.Data.GetData(DataFormats.FileDrop);
            string fileAll = "";
            foreach (string file in files)
            {
                string[] temp = file.Split('\\');
                string temp2 = temp[temp.Length - 1];
                fileAll += temp2 + Environment.NewLine;
                Console.WriteLine(file);
            }
            label31.Text = fileAll;

        }

        private void Main_DragLeave(object sender, EventArgs e)
        {
            dragdropBack.Visible = false;
            dragdropFile.Visible = false;
            label31.Text = string.Empty;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Main_DragLeave(sender, e);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("파일을 업로드 하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                db.uploadFile(fileOriginal, userSeq);
            }
            Main_DragLeave(sender, e);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            종료ToolStripMenuItem_Click(sender, e);
        }
    }
}
