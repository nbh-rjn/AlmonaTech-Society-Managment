using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AlmonaTech_Society_Managment
{
    public partial class Member_viewEvent : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;


        public string conn = "Data Source=HOME\\SQLEXPRESS;Initial Catalog=societydb;Integrated Security=True";

        public Member_viewEvent()
        {
            InitializeComponent();
            cn = new SqlConnection(conn);
            EventGridView();
            this.Icon = Properties.Resources.logo_ico;
        }


        public void EventGridView()
        {

            try
            {
                // Open connection

                cn.Open();
                string q = "select * from eventRequest";

                SqlCommand cmd = new SqlCommand(q, cn);


                // Use SqlDataAdapter to fill the DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);


                // Create a DataTable to hold the data
                System.Data.DataTable dataTable = new System.Data.DataTable();

                // Use a DataAdapter to fill the DataTable
                using (adapter)
                {
                    adapter.Fill(dataTable);
                }

                eventstable.DataSource = dataTable;


                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void eventstable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Member_viewEvent_Load(object sender, EventArgs e)
        {

        }

        private void viewevent_btn_Click(object sender, EventArgs e)
        {
            MemberDashboard memberDashboard = new MemberDashboard();
            memberDashboard.Show();
            this.Hide();
        }

        private void signout_btn_Click(object sender, EventArgs e)
        {
           LoginSignup loginSignup = new LoginSignup();
            loginSignup.Show();
            this.Hide();
        }

        private void join_society_btn_Click(object sender, EventArgs e)
        {
            viewsociety_membercs viewsociety_Membercs = new viewsociety_membercs();
            viewsociety_Membercs.Show();
            this.Hide();
        }

        private void view_society_btn_Click(object sender, EventArgs e)
        {
            Member_SocietyLeavecs member_Leave=new Member_SocietyLeavecs();
            member_Leave.Show();
            this.Hide();
        }

        private void leave_society_btn_Click(object sender, EventArgs e)
        {
            LoginSignup loginSignup = new LoginSignup();
            loginSignup.Show();
            this.Hide();
        }
    }
}
