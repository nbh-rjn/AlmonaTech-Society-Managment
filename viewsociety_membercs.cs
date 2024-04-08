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


        public string conn = "Data Source=DESKTOP-67QKUHG\\SQLEXPRESS;Initial Catalog=societydb;Integrated Security=True";

        public viewsociety_membercs()
        {
            InitializeComponent();
            cn = new SqlConnection(conn);
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
        }
}
