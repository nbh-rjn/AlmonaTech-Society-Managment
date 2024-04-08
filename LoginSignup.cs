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


        public string conn = "Data Source=DESKTOP-67QKUHG\\SQLEXPRESS;Initial Catalog=societydb;Integrated Security=True";


        public LoginSignup()
        {
            InitializeComponent();
            cn = new SqlConnection(conn);
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
           
            string q = "select usertype from User_ where fname = @uname AND pass = @pass";

            SqlCommand cmd = new SqlCommand(q, cn);
            cmd.Parameters.AddWithValue("@uname", uname_lg.Text);
            cmd.Parameters.AddWithValue("@pass", pword_lg.Text);



            //verification code
           
            string type = Convert.ToString(cmd.ExecuteScalar());



            if (type != null) // if correct
              {
                  MessageBox.Show("Login successful!");
                
                if (type=="Lead")
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else if(type=="Mentor")
                {
                    MentorDashboard mentor = new MentorDashboard();
                    mentor.Show();
                    this.Hide();
                }
                else if(type=="Member")
                {
                    MemberDashboard member = new MemberDashboard();
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


                cn.Open();
                SqlTransaction transaction = cn.BeginTransaction();
                string query = "insert into User_ (fname, lname, email, usertype, pass)\r\nvalues (@fname, @lname, @email, @usertype, @pass);";//input in acc table

                SqlCommand cmdAccounts = new SqlCommand(query, cn, transaction);
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
            else if(ldbtn.Checked)
            {
                cn.Open();
                SqlTransaction transaction = cn.BeginTransaction();
                string query = "insert into User_ (fname, lname, email, usertype, pass)\r\nvalues (@fname, @lname, @email, @usertype, @pass);";//input in acc table

                SqlCommand cmdAccounts = new SqlCommand(query, cn, transaction);
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
            else if(mt_btn.Checked)
            {

                cn.Open();
                SqlTransaction transaction = cn.BeginTransaction();
                string query = "insert into User_ (fname, lname, email, usertype, pass)\r\nvalues (@fname, @lname, @email, @usertype, @pass);";//input in acc table

                SqlCommand cmdAccounts = new SqlCommand(query, cn, transaction);
                cmdAccounts.Parameters.AddWithValue("@fname", fname_sn.Text);
                cmdAccounts.Parameters.AddWithValue("@lname", lname_sn.Text);
                cmdAccounts.Parameters.AddWithValue("@email", em_sn.Text);
                cmdAccounts.Parameters.AddWithValue("@usertype", "Mentor");
                cmdAccounts.Parameters.AddWithValue("@pass", pword_sn.Text);


                cmdAccounts.ExecuteNonQuery();

                transaction.Commit();



                MessageBox.Show("Signup successful!");
                cn.Close();


                MentorDashboard md=new MentorDashboard();
                md.Show();
                this.Hide();
            }
           
           
        }

        private void uname_sn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
