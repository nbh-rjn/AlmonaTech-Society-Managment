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


namespace AlmonaTech_Society_Managment
{
    public partial class CreateSociety : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;


        public string conn = "Data Source=HOME\\SQLEXPRESS;Initial Catalog=societydb;Integrated Security=True";
        public int uid;

        public CreateSociety()
        {
            InitializeComponent();
            cn = new SqlConnection(conn);
            this.Icon = Properties.Resources.logo_ico;
        }

        public CreateSociety(int uID)
        {
            InitializeComponent();
            cn = new SqlConnection(conn);
            this.uid = uID;
            this.Icon = Properties.Resources.logo_ico;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //create socity button
        {
            cn.Open();
            SqlTransaction transaction = cn.BeginTransaction();
            string query = "insert into Society (sname,description_)\r\nvalues (@sname, @desc);";//input in socitytable

            SqlCommand cmdSociety = new SqlCommand(query, cn, transaction);
          //  cmdSociety.Parameters.AddWithValue("@sname", society_name.Text);
           // cmdSociety.Parameters.AddWithValue("@desc", s_desc.Text);

            cmdSociety.ExecuteNonQuery();

            transaction.Commit();

            MessageBox.Show("Society Creation Successful!");
            //society_name.Text = "";
            //s_desc.Text = "";

            cn.Close();
        }

        private void signout_btn_Click(object sender, EventArgs e)
        {
            LoginSignup loginSignup = new LoginSignup();
            loginSignup.Show();
            this.Hide();
        }

        private void viewevents_btn_Click(object sender, EventArgs e)
        {
            DisplayEvent displayEvent = new DisplayEvent();
            displayEvent.Show();
            this.Hide();
        }

        private void viewsociety_details_btn_Click(object sender, EventArgs e)
        {
            DisplaySociety displaySocietyDetails = new DisplaySociety();
            displaySocietyDetails.Show();
            this.Hide();
        }

        private void dash_btn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
