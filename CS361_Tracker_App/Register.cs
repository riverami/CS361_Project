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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Home frm_Home = new Home();
            this.Hide();
            frm_Home.Show();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Login frm_Login = new Login();
            this.Hide();
            frm_Login.Show();
        }
    }
}
