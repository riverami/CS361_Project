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
    public partial class Entry_List : Form
    {
        public Entry_List()
        {
            InitializeComponent();
        }

        private void btn_Hamburger_Click(object sender, EventArgs e)
        {
            Hamburger frm_Hamburger = new Hamburger();
            this.Close();
            frm_Hamburger.Show();
        }

        private void btn_NewEntry_Click(object sender, EventArgs e)
        {
            Entry_Add frm_EntryAdd = new Entry_Add();
            this.Close();
            frm_EntryAdd.Show();
        }

        private void btn_Delete1_Click(object sender, EventArgs e)
        {
            WarnDelete frm_WarnDelete = new WarnDelete();
            frm_WarnDelete.Show();
        }
    }
}
