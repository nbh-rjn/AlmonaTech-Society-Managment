using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmonaTech_Society_Managment
{
    public partial class MemberDashboard : Form
    {
        public MemberDashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e) //view events
        {

        }

        private void view_society_btn_Click(object sender, EventArgs e)
        {
            viewsociety_membercs viewsociety_Membercs = new viewsociety_membercs();
            viewsociety_Membercs.Show();
            this.Hide();
        }
    }
}
