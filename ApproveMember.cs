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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace AlmonaTech_Society_Managment
{
    public partial class ApproveMember : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;


        public string conn = "Data Source=DESKTOP-67QKUHG\\SQLEXPRESS;Initial Catalog=societydb;Integrated Security=True";
        public int uid;
        public ApproveMember()
        {
            InitializeComponent();
            cn = new SqlConnection(conn);
            SocietyGridView();
        }

        public ApproveMember(int uid)
        {
            InitializeComponent();
            cn = new SqlConnection(conn);
            SocietyGridView();
            this.uid = uid;
        }
        public void SocietyGridView()
        {

            try
            {
                // Open connection

                cn.Open();
                string q = "select * from member_ where status_='Requested'";

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

        private void societytable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == societytable.Columns["Approve"].Index && e.RowIndex != -1)
            {
                // Retrieve data from the clicked row
                int societyID = Convert.ToInt32(societytable.Rows[e.RowIndex].Cells["societyID"].Value);

                // Update status to "Approved" in the member_ table
                string q = "UPDATE member_ SET status_ = 'Approved' WHERE societyID = @societyID";

                using (SqlConnection ncn = new SqlConnection(conn))
                {
                    ncn.Open();
                    SqlCommand cmd = new SqlCommand(q, ncn);
                    cmd.Parameters.AddWithValue("@societyID", societyID);
                    cmd.ExecuteNonQuery();
                    ncn.Close();
                }

                MessageBox.Show("Status updated to Approved.");
                SocietyGridView();
               
            }
        
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void ApproveMember_Load(object sender, EventArgs e)
        {

        }
    }

    }


