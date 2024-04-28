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


       // public string conn = "Data Source=HOME\\SQLEXPRESS;Initial Catalog=societydb;Integrated Security=True";
        public string conn = "Data Source=DESKTOP-67QKUHG\\SQLEXPRESS;Initial Catalog=societydb;Integrated Security=True";
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
                string q = "SELECT er.*\r\nFROM eventRequest er\r\nJOIN User_ u ON er.userID = u.userid\r\nJOIN Society s ON u.userid = s.mentorID\r\nWHERE s.mentorID = @mentorID;\r\n";

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
            if (e.ColumnIndex == approveEventGrid.Columns["Approve"].Index && e.RowIndex != -1)
            {
                // Retrieve data from the clicked row
                int eventID = Convert.ToInt32(approveEventGrid.Rows[e.RowIndex].Cells["eventID"].Value);

                // Implement logic to approve the event and update its status in the database
                try
                {
                    // Open connection
                    using (SqlConnection connection = new SqlConnection(conn))
                    {
                        connection.Open();

                        // Update status to "Approved" in the events_ table
                        string updateQuery = "UPDATE events_ SET status_ = 'Approved' WHERE eventID = @eventID";

                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@eventID", eventID);
                            command.ExecuteNonQuery();
                        }

                        // Close connection
                        connection.Close();
                    }

                    // Refresh the DataGridView to reflect the updated status
                    EventGridView();

                    MessageBox.Show("Event approved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error approving event: " + ex.Message);
                }
            }
        }



        private void ApproveEventcs_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MentorDashboard mentordashboard = new MentorDashboard();
            mentordashboard.Show();
            this.Hide();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void ApproveEventcs_Load_1(object sender, EventArgs e)
        {

        }
    }
}
