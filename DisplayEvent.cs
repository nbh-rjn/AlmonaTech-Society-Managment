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
   

    public partial class DisplayEvent : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;


        public string conn = "Data Source=HOME\\SQLEXPRESS;Initial Catalog=societydb;Integrated Security=True";
        public int uid;

        public DisplayEvent()
        {
            InitializeComponent();
            cn = new SqlConnection(conn);
            EventGridView();
        }

        public DisplayEvent(int uID)
        {
            InitializeComponent();
            cn = new SqlConnection(conn);
            EventGridView();
            this.uid = uID;
        }

        private void societytable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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

        private void signout_btn_Click(object sender, EventArgs e)
        {
            LoginSignup loginSignup = new LoginSignup();
            loginSignup.Show();
            this.Hide();
        }

        private void viewsociety_btn_Click(object sender, EventArgs e)
        {
            DisplaySociety displaySociety = new DisplaySociety();
            displaySociety.Show();
            this.Hide();
        }

        private void reqvents_btn_Click(object sender, EventArgs e)
        {
            CreateEvent createEvent = new CreateEvent();
            createEvent.Show();
            this.Hide();
        }

        private void dashboard__btn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void DisplayEvent_Load(object sender, EventArgs e)
        {

        }
    }
}
