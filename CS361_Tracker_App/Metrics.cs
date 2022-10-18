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
    public partial class Metrics : Form
    {
        public Metrics()
        {
            InitializeComponent();
            lbl_TimeFrame.Text = "Weekly";
        }

        private void btn_Hamburger_Click(object sender, EventArgs e)
        {
            Hamburger frm_Hamburger = new Hamburger();
            this.Hide();
            frm_Hamburger.Show();
        }

        private void btn_Weekly_Click(object sender, EventArgs e)
        {
            lbl_TimeFrame.Text = "Weekly";
        }

        private void btn_Monthly_Click(object sender, EventArgs e)
        {
            lbl_TimeFrame.Text = "Monthly";
        }

        private void btn_Yearly_Click(object sender, EventArgs e)
        {
            lbl_TimeFrame.Text = "Yearly";
        }
    }
}
