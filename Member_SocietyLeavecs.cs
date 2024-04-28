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
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace AlmonaTech_Society_Managment
{
    public partial class Member_SocietyLeavecs : Form
    {
        public int userID;

        SqlConnection cn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;


        //public string conn = "Data Source=DESKTOP-67QKUHG\\SQLEXPRESS;Initial Catalog=societydb;Integrated Security=True";
        public string conn = "Data Source=HOME\\SQLEXPRESS;Initial Catalog=societydb;Integrated Security=True";

        public Member_SocietyLeavecs()
        {
            InitializeComponent();
            cn = new SqlConnection(conn);
            SocietyGridView();
            this.Icon = Properties.Resources.logo_ico;
        }

        public Member_SocietyLeavecs(int uid)
        {
            InitializeComponent();
            this.userID = uid;
            cn = new SqlConnection(conn);
            SocietyGridView();
            this.Icon = Properties.Resources.logo_ico;
        }
        public void SocietyGridView()
        {

            try
            {
                // Open connection

                cn.Open();
                string q = "select s.sname AS 'Society' from memberRequest mr JOIN Society s ON mr.societyID = s.societyID where mr.status_='Approved' and mr.userID = @userID";

                SqlCommand cmd = new SqlCommand(q, cn);

                cmd.Parameters.AddWithValue("@userID", userID);



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


    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void societytable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Leave.Index && e.RowIndex >= 0)
            {
                DataTable dataSource = (DataTable)societytable.DataSource;

                // Mark the row for deletion in the data source
                dataSource.Rows[e.RowIndex].Delete();

                // Apply the changes to the DataGridView
                societytable.Refresh();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MemberDashboard memberDashboard= new MemberDashboard();
            memberDashboard.Show();
            this.Hide();
        }

        private void Member_SocietyLeavecs_Load(object sender, EventArgs e)
        {

        }
    }
}
