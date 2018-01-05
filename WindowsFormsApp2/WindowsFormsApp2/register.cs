using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Resources;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{
    public partial class register : Form
    {
        private Point mousePoint;
        bool canRegister = false;
        Dictionary<string, bool> isNotModified;
        bool valid = false;
        public register()
        {
            InitializeComponent();
            isNotModified = new Dictionary<string, bool>();
            isNotModified.Add("id", true);
            isNotModified.Add("pw", true);
            isNotModified.Add("name", true);
            isNotModified.Add("email", true);
            isNotModified.Add("phone2", true);
            isNotModified.Add("phone3", true);
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
            this.Close();
        }


        private Bunifu.Framework.UI.BunifuMaterialTextbox lastFocused;
        private void textboxFocus(object sender, EventArgs e)
        {
            lastFocused = (Bunifu.Framework.UI.BunifuMaterialTextbox)sender;
            foreach (string str in new[] { "ID", "Pw", "Email", "Phone" })
            {
                if (lastFocused.Text == str && isNotModified[lastFocused.Name])
                {
                    isNotModified[lastFocused.Name] = false;
                    lastFocused.Text = "";
                    break;
                }
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!canRegister)
            {
                MessageBox.Show("연결에 문제가 있어 로그인하지 못했습니다." + Environment.NewLine + "좌측 상단의 아이콘을 참조하세요.", "알림");
                return;
            }
            if (valid && id.Text.Equals("") && pw.Text.Equals("") && name.Text.Equals("") && email.Text.Equals("") && phone2.Text.Equals("") && phone3.Text.Equals("") && phone1.selectedIndex < 0) 
            {
                MessageBox.Show("모든 정보를 입력하세요.");
                return;
            }


            Db d = new Db();
            d.register(id.Text, pw.Text, name.Text, email.Text, phone1.selectedValue + "-" + phone2.Text + "-" + phone3.Text);
            MessageBox.Show("회원가입이 완료되었습니다. 로그인 해 주십시오.", "성공");
            this.Close();
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
                canRegister = false;
            }*/
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                errorMessage += "인터넷에 연결하지 못했습니다.";
                pictureBox3.Image = Properties.Resources.warning;
                warningCount++;
                canRegister = false;
            }
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                errorMessage = "모든 연결상태가 원활합니다.";
                pictureBox3.Image = Properties.Resources.ok;
                warningCount = 0;
                canRegister = true;
            }
            toolTip1.SetToolTip(pictureBox3, errorMessage);
            if (warningCount > 0)
                warningLable.Text = " " + warningCount + " ";
            pictureBox3.Refresh();
            pictureBox3.Visible = true;

        }

        private void email_OnValueChanged(object sender, EventArgs e)
        {
            valid = Regex.IsMatch(email.Text, "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            if (!valid)
            {
                email.LineFocusedColor = Color.FromArgb(255, 128, 128);
                toolTip1.SetToolTip(pictureBox2, "이메일 형식이 올바르지 않습니다.");
                pictureBox2.Visible = true;
            }
            else
            {
                email.LineFocusedColor = Color.FromArgb(128, 255, 128);
                toolTip1.SetToolTip(pictureBox2, "이메일 형식이 올바릅니다.");
            }
        }

        private void pw_OnValueChanged(object sender, EventArgs e)
        {
            pw.isPassword = true;
        }
    }
}
