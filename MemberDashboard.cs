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
        public int uid;
        public MemberDashboard()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.logo_ico;
        }

        public MemberDashboard(int uID) {
        
            this.uid = uID;
            this.Icon = Properties.Resources.logo_ico;
        }

        /*
        private void pictureBox1_Click(object sender, EventArgs e) //view events
        {
            Member_viewEvent member_ViewEvent = new Member_viewEvent();
            member_ViewEvent.Show();
            this.Hide();
        }

        private void view_society_btn_Click(object sender, EventArgs e)
        {
           Member_SocietyLeavecs member_view= new Member_SocietyLeavecs(uid);
            member_view.Show();
            this.Hide();
        }

        private void join_society_btn_Click(object sender, EventArgs e)
        {
            viewsociety_membercs viewsociety_Membercs = new viewsociety_membercs(uid);
            viewsociety_Membercs.Show();
            this.Hide();
        }

        private void leave_society_btn_Click(object sender, EventArgs e)
        {
            LoginSignup loginSignup = new LoginSignup();
            loginSignup.Show();
            this.Hide();
        }

        */

        
        

        private void MemberDashboard_Load(object sender, EventArgs e)
        {

        }

        private void signout_btn_Click(object sender, EventArgs e)
        {
            LoginSignup loginSignup = new LoginSignup();
            loginSignup.Show();
            this.Hide();
        }

        private void viewevents_btn_Click(object sender, EventArgs e)
        {
            Member_viewEvent member_ViewEvent = new Member_viewEvent();
            member_ViewEvent.Show();
            
        }

        private void viewsociety_details_btn_Click(object sender, EventArgs e)
        {
            //
            Member_SocietyLeavecs member_view = new Member_SocietyLeavecs(uid);
            member_view.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            viewsociety_membercs viewsociety_Membercs = new viewsociety_membercs(uid);
            viewsociety_Membercs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //
            Member_SocietyLeavecs member_view = new Member_SocietyLeavecs(uid);
            member_view.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewAnnouncement viewAnnouncement = new ViewAnnouncement(); 
            viewAnnouncement.Show();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ViewAnnouncement viewAnnouncement = new ViewAnnouncement();
            viewAnnouncement.Show();
            //
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Member_viewEvent member_ViewEvent = new Member_viewEvent();
            member_ViewEvent.Show();
            //
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisplaySociety displaySociety = new DisplaySociety();
            displaySociety.Show();
            //
        }

        private void ance_btn_Click(object sender, EventArgs e)
        {
            viewsociety_membercs viewsociety_Membercs = new viewsociety_membercs(uid);
            viewsociety_Membercs.Show();
            //
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Member_SocietyLeavecs member_view = new Member_SocietyLeavecs(uid);
            member_view.Show();
        }
    }
}
