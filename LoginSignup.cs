using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//libraries to include
using System.Data.SqlClient;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Collections;


namespace AlmonaTech_Society_Managment
{
    public partial class LoginSignup : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;


        public string conn = "Data Source=HOME\\SQLEXPRESS;Initial Catalog=societydb;Integrated Security=True";
        //public string conn= "Data Source=DESKTOP-67QKUHG\\SQLEXPRESS;Initial Catalog=societydb;Integrated Security=True";

        public LoginSignup()
        {
            InitializeComponent();
            cn = new SqlConnection(conn);
            this.Icon = Properties.Resources.logo_ico;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            //verify
            cn.Open();

            string q = "select userid, usertype from User_ where username = @uname and pass = @pass";

            SqlCommand cmd = new SqlCommand(q, cn);
            cmd.Parameters.AddWithValue("@uname", uname_lg.Text);
            cmd.Parameters.AddWithValue("@pass", pword_lg.Text);



            //verification code

            SqlDataReader type = cmd.ExecuteReader();

            if (type.Read())
            {
                int userID = type.GetInt32(0); // Retrieve user ID
                string userType = type.GetString(1); // Retrieve user type

                MessageBox.Show("Login successful!");

           
                if (userType=="Lead")
                {
                    Dashboard dashboard = new Dashboard(userID);
                    dashboard.Show();
                    this.Hide();
                }
                else if(userType == "Mentor")
                {
                    MentorDashboard mentor = new MentorDashboard(userID);
                    mentor.Show();
                    this.Hide();
                }
                else if(userType == "Member")
                {
                    MemberDashboard member = new MemberDashboard(userID);
                    member.Show();
                    this.Hide();
                }
                  

            }
              else
              {
                  MessageBox.Show("Invalid username or password. Please try again.");

              }


            cn.Close();

        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            //store in database

           


            if (mbtn.Checked)
            {

                try
                {
                    cn.Open();
                    SqlTransaction transaction = cn.BeginTransaction();
                    string query = "insert into User_ (username, fname, lname, email, usertype, pass)\r\nvalues (@username, @fname, @lname, @email, @usertype, @pass);";//input in acc table

                    SqlCommand cmdAccounts = new SqlCommand(query, cn, transaction);

                    cmdAccounts.Parameters.AddWithValue("@username", uname_sn.Text);
                    cmdAccounts.Parameters.AddWithValue("@fname", fname_sn.Text);
                    cmdAccounts.Parameters.AddWithValue("@lname", lname_sn.Text);
                    cmdAccounts.Parameters.AddWithValue("@email", em_sn.Text);
                    cmdAccounts.Parameters.AddWithValue("@usertype", "Member");
                    cmdAccounts.Parameters.AddWithValue("@pass", pword_sn.Text);


                    cmdAccounts.ExecuteNonQuery();

                    transaction.Commit();



                    MessageBox.Show("Signup successful!");
                    cn.Close();


                    MemberDashboard dashboard_ = new MemberDashboard();
                    dashboard_.Show();
                    this.Hide();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 547)
                    {
                        MessageBox.Show("Incorrect Input. Make sure email is correct. \n Password is alphanumeric and at least 8 characters long \n Names are alphabetic");
                        cn.Close();
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while signing up: " + ex.Message);
                        cn.Close();
                    }
                }
            }
            else if(ldbtn.Checked)
            {
                try
                {
                    cn.Open();
                    SqlTransaction transaction = cn.BeginTransaction();
                    string query = "insert into User_ (username, fname, lname, email, usertype, pass)\r\nvalues (@username, @fname, @lname, @email, @usertype, @pass);";//input in acc table

                    SqlCommand cmdAccounts = new SqlCommand(query, cn, transaction);

                    cmdAccounts.Parameters.AddWithValue("@username", uname_sn.Text);
                    cmdAccounts.Parameters.AddWithValue("@fname", fname_sn.Text);
                    cmdAccounts.Parameters.AddWithValue("@lname", lname_sn.Text);
                    cmdAccounts.Parameters.AddWithValue("@email", em_sn.Text);
                    cmdAccounts.Parameters.AddWithValue("@usertype", "Lead");
                    cmdAccounts.Parameters.AddWithValue("@pass", pword_sn.Text);


                    cmdAccounts.ExecuteNonQuery();

                    transaction.Commit();



                    MessageBox.Show("Signup successful!");
                    cn.Close();

                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                catch(SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 547)
                    {
                        MessageBox.Show("Incorrect Input. Make sure email is correct. \n Password is alphanumeric and at least 8 characters long \n Names are alphabetic");
                        cn.Close();
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while signing up: " + ex.Message);
                        cn.Close();
                    }
                }
            }
            else if(mt_btn.Checked)
            {
                try
                {
                    cn.Open();
                    SqlTransaction transaction = cn.BeginTransaction();
                    string query = "insert into User_ (username, fname, lname, email, usertype, pass)\r\nvalues (@username, @fname, @lname, @email, @usertype, @pass);";//input in acc table

                    SqlCommand cmdAccounts = new SqlCommand(query, cn, transaction);

                    cmdAccounts.Parameters.AddWithValue("@username", uname_sn.Text);
                    cmdAccounts.Parameters.AddWithValue("@fname", fname_sn.Text);
                    cmdAccounts.Parameters.AddWithValue("@lname", lname_sn.Text);
                    cmdAccounts.Parameters.AddWithValue("@email", em_sn.Text);
                    cmdAccounts.Parameters.AddWithValue("@usertype", "Mentor");
                    cmdAccounts.Parameters.AddWithValue("@pass", pword_sn.Text);


                    cmdAccounts.ExecuteNonQuery();

                    transaction.Commit();



                    MessageBox.Show("Signup successful!");
                    cn.Close();


                    MentorDashboard md = new MentorDashboard();
                    md.Show();
                    this.Hide();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 547)
                    {
                        MessageBox.Show("Incorrect Input. Make sure email is correct. \n Password is alphanumeric and at least 8 characters long \n Names are alphabetic");
                        cn.Close();
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while signing up: " + ex.Message);
                        cn.Close();
                    }
                }

            }
           
           
        }

        private void uname_sn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
