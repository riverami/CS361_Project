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
    public partial class Hamburger : Form
    {
        public Hamburger()
        {
            InitializeComponent();
        }

        private void btn_MainPage_Click(object sender, EventArgs e)
        {
            Home frm_Home = new Home();
            this.Close();
            frm_Home.Show();
        }

        private void btn_Entries_Click(object sender, EventArgs e)
        {
            Entry_List frm_EntryList = new Entry_List();
            this.Close();
            frm_EntryList.Show();
        }

        private void btn_Metrics_Click(object sender, EventArgs e)
        {
            Metrics frm_Metrics = new Metrics();
            this.Close();
            frm_Metrics.Show();
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            Settings frm_Settings = new Settings();
            this.Close();
            frm_Settings.Show();
        }
    }
}
