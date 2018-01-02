using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        private Point mousePoint;

        public Login()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db d = new db();
            textBox1.Text = textBox1.Text.Trim();
            textBox2.Text = textBox2.Text.Trim();
            if (d.accCheck(textBox1.Text, textBox2.Text))
            {
                DataSet ds = d.select(new[] { "userName" }, "tb_user", "userId = \'" + textBox1.Text + "\'");
                DataTable dt = new DataTable();
                dt = ds.Tables["tb_user"];
                MessageBox.Show(dt.Rows[0][0] + "님 환영합니다.","성공");
                this.Hide();
                Main main = new Main();
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("아이디 또는 비밀번호 오류입니다.","오류");
            }
        }
        
        private void pictureBox1_MouseEnter(object sender, EventArgs e) {
                            
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
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
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                button1_Click(sender, e);
            }
        }
    }
}
