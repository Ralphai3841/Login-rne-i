using LoginÖrneği.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginÖrneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.userName = txtUserName.Text;
            user.password = txtPassword.Text;
            string loginDate = DateTime.Now.ToString();
            user.Login(loginDate);
            User user2 = new User();
            user2.userName = " Ralph ";
            user2.password = " 1923 "
            string loginDate2 = DateTime.Now.ToString();
            user2.Login(loginDate2);
        }
    }
}
// nesne üretme : instance alma