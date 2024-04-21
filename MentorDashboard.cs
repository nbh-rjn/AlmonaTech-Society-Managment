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
    public partial class MentorDashboard : Form
    {
        public MentorDashboard()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.logo_ico;
        }
        /*
        private void pictureBox1_Click(object sender, EventArgs e) // clicking the approve butotn
        {
            ApproveEventcs approveEventcs = new ApproveEventcs();
            approveEventcs.Show();
            this.Hide();
            
        }
        */

        private void MentorDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //
            ApproveEventcs approveEventcs = new ApproveEventcs();
            approveEventcs.Show();

        }

        private void viewevents_btn_Click(object sender, EventArgs e)
        {
            //
            DisplayEvent displayEvent = new DisplayEvent();
            displayEvent.Show();
        }

        private void viewsociety_details_btn_Click(object sender, EventArgs e)
        {
            //
            DisplaySociety displaySociety = new DisplaySociety();
            displaySociety.Show();
        }

        private void ance_btn_Click(object sender, EventArgs e)
        {
            //
            CreateAnnouncement createAnnouncement = new CreateAnnouncement();   
            createAnnouncement.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            ViewAnnouncement viewAnnouncement = new ViewAnnouncement(); 
            viewAnnouncement.Show();
        }

        private void signout_btn_Click(object sender, EventArgs e)
        {
            LoginSignup signup = new LoginSignup();
            signup.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
