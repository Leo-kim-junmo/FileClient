using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileClient
{
    public partial class Login : Form
    {
        string ID = "leo";
        string PW = "0000";

        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string ip = textBox1.Text;
            string id = textBox2.Text;
            string pw = textBox3.Text;
            if(ID==id && PW==pw)
            {
                MainWindow mw = new MainWindow(ip);
                mw.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("아이디 비밀번호가 틀립니다.");
            }
        }
    }
}
