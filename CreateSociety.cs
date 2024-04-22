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
using System.Diagnostics;


namespace AlmonaTech_Society_Managment
{
    public partial class CreateSociety : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;

        public string conn = "Data Source=DESKTOP-67QKUHG\\SQLEXPRESS;Initial Catalog=societydb;Integrated Security=True";
       // public string conn = "Data Source=HOME\\SQLEXPRESS;Initial Catalog=societydb;Integrated Security=True";
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
            MessageBox.Show(uid.ToString());
            cn.Open();
            SqlTransaction transaction = cn.BeginTransaction();
            string query = "insert into Society (sname,description_,leadID,mentorID)\r\nvalues (@sname, @desc,@uid,@mentorID);";//input in socitytable


            Debug.WriteLine("uid: " + uid);
            Debug.WriteLine("mentorID: " + labellck.Text);
            SqlCommand cmdSociety = new SqlCommand(query, cn, transaction);
           cmdSociety.Parameters.AddWithValue("@sname", sname.Text);
           cmdSociety.Parameters.AddWithValue("@desc", desc.Text);
           cmdSociety.Parameters.AddWithValue("@uid", uid);

            // Parse MentorID as a number (assuming it's an integer)
            if (int.TryParse(MentorID.Text, out int mentorIDValue))
            {
                cmdSociety.Parameters.AddWithValue("@mentorID", mentorIDValue);
            }
            else
            {
                // Handle invalid input for MentorID (optional)
                MessageBox.Show("MentorID must be a valid number.");
          }
           
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

        private void add_event_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(uid.ToString());
            cn.Open();
            SqlTransaction transaction = cn.BeginTransaction();
            string query = "insert into Society (sname,description_,leadID,mentorID)\r\nvalues (@sname, @desc,@uid,@mentorID);";//input in socitytable


            Debug.WriteLine("uid: " + uid);
            Debug.WriteLine("mentorID: " + labellck.Text);
            SqlCommand cmdSociety = new SqlCommand(query, cn, transaction);
            cmdSociety.Parameters.AddWithValue("@sname", sname.Text);
            cmdSociety.Parameters.AddWithValue("@desc", desc.Text);
            cmdSociety.Parameters.AddWithValue("@uid", uid);

            // Parse MentorID as a number (assuming it's an integer)
            if (int.TryParse(MentorID.Text, out int mentorIDValue))
            {
                cmdSociety.Parameters.AddWithValue("@mentorID", mentorIDValue);
            }
            else
            {
                // Handle invalid input for MentorID (optional)
                MessageBox.Show("MentorID must be a valid number.");
            }

            cmdSociety.ExecuteNonQuery();

            transaction.Commit();


            MessageBox.Show("Society Creation Successful!");
            //society_name.Text = "";
            //s_desc.Text = "";

            cn.Close();
        }

        private void ev_name_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
