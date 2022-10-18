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
    public partial class Entry_Add : Form
    {
        public Entry_Add()
        {
            InitializeComponent();
        }

        private void btn_Hamburger_Click(object sender, EventArgs e)
        {
            Hamburger frm_Hamburger = new Hamburger();
            this.Close();
            frm_Hamburger.Show();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Entry_List frm_EntryList = new Entry_List();
            this.Close();
            frm_EntryList.Show();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            Entry_List frm_EntryList = new Entry_List();
            this.Close();
            frm_EntryList.Show();
        }
    }
}
