using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Collections;
using System.Collections.ObjectModel;

namespace AlmonaTech_Society_Managment
{
    public partial class DisplaySociety : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;

        public string conn = "Data Source=DESKTOP-67QKUHG\\SQLEXPRESS;Initial Catalog=societydb;Integrated Security=True";
       // public string conn = "Data Source=HOME\\SQLEXPRESS;Initial Catalog=societydb;Integrated Security=True";
        public int uID;
        public DisplaySociety()
        {
            InitializeComponent();
            cn = new SqlConnection(conn);
            SocietyGridView();
            this.Icon = Properties.Resources.logo_ico;
        }

        public DisplaySociety(int uid)
        {
            InitializeComponent();
            cn = new SqlConnection(conn);
            SocietyGridView();
            this.uID = uid;
            this.Icon = Properties.Resources.logo_ico;
        }

        private void societytable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void SocietyGridView()
        {

            try
            {
                // Open connection

                cn.Open();
                string q = "select * from Society";

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

                // Bind the DataTable to the DataGridView
                societytable.DataSource = dataTable;


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

        private void createevent_btn_Click(object sender, EventArgs e)
        {
            CreateEvent createEvent = new CreateEvent();
            createEvent.Show();
            this.Hide();
        }

        private void viewevents_btn_Click(object sender, EventArgs e)
        {
            DisplayEvent viewEvent = new DisplayEvent();
            viewEvent.Show();
            this.Hide();
        }

        private void dashboard__btn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void DisplaySociety_Load(object sender, EventArgs e)
        {

        }
    }
}
