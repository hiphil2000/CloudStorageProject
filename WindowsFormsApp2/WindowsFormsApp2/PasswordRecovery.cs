using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{
    public partial class PasswordRecovery : Form
    {
        Db d;
        private Point mousePoint;
        bool canLogin = false;
        private string tempPassword;

        public PasswordRecovery()
        {
            InitializeComponent();
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

        private void send_Click(object sender, EventArgs e)
        {
            bool valid = Regex.IsMatch(id.Text, "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            if (!valid)
                MessageBox.Show("메일 형식이 올바르지 않습니다.", "오류");
            
            if (canLogin && valid)
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    tempPassword = new Random().Next().ToString();
                    mail.From = new MailAddress("cloudstorage.emailservice@gmail.com");
                    mail.To.Add(id.Text);
                    mail.Subject = "[CloudStorage] 이메일인증을 완료해주십시오.";
                    mail.Body = "당신의 번호는 [" + tempPassword + "] 입니다." + Environment.NewLine +
                        "만약 본인이 이메일 인증을 한 적이 없다면 관리자에게 연락하십시오." + Environment.NewLine +
                        "관리자 ----------------------------------------------------------" + Environment.NewLine +
                        "Email : hiphil2000@naver.com" + Environment.NewLine +
                        "Tel : 안알려줌";

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("cloudstorage.emailservice", "tmxkzmfovmxm2");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("번호가 발송되었습니다.", "알림");
                    id.Enabled = false;
                    verifyNumber.Enabled = true;
                    send.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("메일 발송중에 오류가 발생했습니다.");
                }
            }
        }

        private void verifyNumber_OnValueChanged(object sender, EventArgs e)
        {
            if (id.Text.Length < 1)
                accept.Enabled = false;
            else
                accept.Enabled = true;
        }

        private void id_OnValueChanged(object sender, EventArgs e)
        {
            if (id.Text.Length < 1)
                send.Enabled = false;
            else
                send.Enabled = true;
        }

        private void accept_Click(object sender, EventArgs e)
        {
            if(verifyNumber.Text.Equals(tempPassword.ToString()))
            {
                MessageBox.Show("바꿀 비밀번호를 입력하십시오.", "알림");
                password.Visible = true;
                passwordSet.Visible = true;
                verifyNumber.Enabled = false;
                accept.Enabled = false;
            }
            else
            {
                MessageBox.Show("번호가 틀렸습니다. 처음부터 다시 진행해주시길 바랍니다.", "실패");
                this.Close();
            }
        }

        private void password_OnValueChanged(object sender, EventArgs e)
        {
            if (id.Text.Length < 1)
                passwordSet.Enabled = false;
            else
                passwordSet.Enabled = true;
        }

        private void passwordSet_Click(object sender, EventArgs e)
        {
            Db d = new Db();
            d.updatePassword(id.Text, password.Text);
                MessageBox.Show("비밀번호가 변경되었습니다.", "성공");
            this.Close();
        }
    }
}
