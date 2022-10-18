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
    public partial class Tutorial : Form
    {
        public Tutorial()
        {
            InitializeComponent();
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Home frm_Home = new Home();
            this.Close();
            frm_Home.Show();
        }
    }
}
