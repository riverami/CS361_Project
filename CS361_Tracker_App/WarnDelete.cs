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
    public partial class WarnDelete : Form
    {
        public WarnDelete()
        {
            InitializeComponent();
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
