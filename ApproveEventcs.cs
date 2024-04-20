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
using System.Windows.Forms.Design;
using System.Configuration;


namespace AlmonaTech_Society_Managment
{
    public partial class ApproveEventcs : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;


        public string conn = "Data Source=HOME\\SQLEXPRESS;Initial Catalog=societydb;Integrated Security=True";
        public ApproveEventcs()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.logo_ico;
            cn = new SqlConnection(conn);
            EventGridView();
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

                approveEventGrid.DataSource = dataTable;


                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void approveEventGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ApproveEventcs_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
