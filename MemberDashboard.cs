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
        }

        public MemberDashboard(int uID) {
        
            this.uid = uID;
        }
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

        private void MemberDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
