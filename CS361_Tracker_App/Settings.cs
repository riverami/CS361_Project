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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btn_Hamburger_Click(object sender, EventArgs e)
        {
            Hamburger frm_Hamburger = new Hamburger();
            this.Hide();
            frm_Hamburger.Show();
        }

        private void btn_Tutorial_Click(object sender, EventArgs e)
        {
            Tutorial frm_Tutorial = new Tutorial();
            this.Hide();
            frm_Tutorial.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Home frm_Home = new Home();
            this.Hide();
            frm_Home.Show();
        }
    }
}
