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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_Metrics_Click(object sender, EventArgs e)
        {
            Metrics frm_Metrics = new Metrics();
            this.Hide();
            frm_Metrics.Show();
        }

        private void btn_Entries_Click(object sender, EventArgs e)
        {
            Entry_List frm_EntryList = new Entry_List();
            this.Hide();
            frm_EntryList.Show();
        }

        private void btn_Hamburger_Click(object sender, EventArgs e)
        {
            Hamburger frm_Hamburger = new Hamburger();
            this.Hide();
            frm_Hamburger.Show();
        }
    }
}
