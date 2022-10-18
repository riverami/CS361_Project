using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS361_Tracker_App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Home frm_Home = new Home();
            this.Hide();
            frm_Home.Show();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            Register frm_Register = new Register();
            this.Hide();
            frm_Register.Show();
        }
    }
}
