using System;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Resources;
using System.Windows.Forms;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        Db d;
        private Point mousePoint;
        bool canLogin = false;

        public Login()
        {
            InitializeComponent();
            d = new Db();
        }


        //taskbar code
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
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main;
            //임시코드
            /*
            this.Hide();
            main = new Main();
            main.ShowDialog();
            return;*/
            if(id.Text.Equals("") || pw.Text.Equals(""))
            {
                MessageBox.Show("모든 정보를 입력하세요.");
                return;
            }
                

            if (!canLogin)
            {
                MessageBox.Show("연결에 문제가 있어 로그인하지 못했습니다." + Environment.NewLine + "좌측 상단의 아이콘을 참조하세요.", "알림");
                return;
            }
            id.Text = id.Text.Trim();
            pw.Text = pw.Text.Trim();
            if (d.accCheck(id.Text, pw.Text))
            {
                DataSet ds = d.select(new[] { "userName" }, "tb_user", "userId = \'" + id.Text + "\'");
                DataTable dt = new DataTable();
                dt = ds.Tables["tb_user"];
                MessageBox.Show(dt.Rows[0][0] + "님 환영합니다.","성공");
                this.Hide();
                main = new Main(dt.Rows[0][0].ToString());
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("아이디 또는 비밀번호 오류입니다.","오류");
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pw_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                button1_Click(sender, e);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordRecovery p = new PasswordRecovery();
            p.ShowDialog();
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
            if(NetworkInterface.GetIsNetworkAvailable())
            {
                errorMessage = "모든 연결상태가 원활합니다.";
                pictureBox3.Image = Properties.Resources.ok;
                warningCount = 0;
                canLogin = true;
            }
            toolTip1.SetToolTip(pictureBox3, errorMessage);
            if(warningCount > 0)
                warningLable.Text = " " + warningCount + " ";
            pictureBox3.Refresh();
            pictureBox3.Visible = true;

        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register r = new register();
            r.ShowDialog();
        }

        private void pw_OnValueChanged(object sender, EventArgs e)
        {
            pw.isPassword = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
