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
    public partial class Dashboard : Form
    {
        public int uid;
        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(int uid)
        {
            InitializeComponent();
            this.uid = uid;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ance_btn_Click(object sender, EventArgs e) //this is the create society button TT
        {
            CreateSociety createSociety = new CreateSociety();
            createSociety.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void createevent_btn_Click(object sender, EventArgs e)
        {
            CreateEvent reqEvent = new CreateEvent();
            reqEvent.Show();
            this.Hide();

        }

        private void viewevents_btn_Click(object sender, EventArgs e)
        {
            DisplayEvent displayEvent= new DisplayEvent();
            displayEvent.Show();
            this.Hide();

        }

        private void viewsociety_details_btn_Click(object sender, EventArgs e)
        {
            DisplaySociety displayEvent=new DisplaySociety();
            displayEvent.Show();

            this.Hide();
        }

        private void signout_btn_Click(object sender, EventArgs e)
        {
            LoginSignup loginSignup= new LoginSignup();
            loginSignup.Show();
            this.Hide();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ApproveMember approveMember= new ApproveMember();
            approveMember.Show();
            this.Hide();
        }
    }
}
