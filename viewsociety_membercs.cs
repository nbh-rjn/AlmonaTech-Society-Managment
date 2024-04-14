using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.ObjectModel;
using System.Data.SqlClient;


namespace AlmonaTech_Society_Managment
{
    public partial class viewsociety_membercs : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;

        public int userid;

        public string conn = "Data Source=HOME\\SQLEXPRESS;Initial Catalog=societydb;Integrated Security=True";
        public int uID;
        public viewsociety_membercs()
        {
            InitializeComponent();
            cn = new SqlConnection(conn);
            SocietyGridView();
        }
        public viewsociety_membercs(int uid)
        {
            InitializeComponent();
            cn = new SqlConnection(conn);
            this.userid = uid;
            SocietyGridView();
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

        private void societytable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == societytable.Columns["join"].Index && e.RowIndex != -1)
            {
                // Retrieve data from the clicked row
                DataGridViewRow clickedRow = societytable.Rows[e.RowIndex];
                int societyID = Convert.ToInt32(clickedRow.Cells["societyID"].Value);
                string sname = Convert.ToString(clickedRow.Cells["sname"].Value);
                string status = "Requested";

                // Insert data into the member_ table
                string q = "insert into member_ (societyID, sname, status_) values (@societyID, @sname, @status)";

                using (cn)
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(q, cn);
                    cmd.Parameters.AddWithValue("@societyID", societyID);
                    cmd.Parameters.AddWithValue("@sname", sname);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }

                MessageBox.Show("Your request will be processed soon");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MemberDashboard memberDashboard = new MemberDashboard();
            memberDashboard.Show();
            this.Hide();
        }

        private void viewsociety_membercs_Load(object sender, EventArgs e)
        {

        }
    }
}
