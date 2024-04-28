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

namespace AlmonaTech_Society_Managment
{
    public partial class CreateEvent : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;

        //public string conn = "Data Source=DESKTOP-67QKUHG\\SQLEXPRESS;Initial Catalog=societydb;Integrated Security=True";
        public string conn = "Data Source=HOME\\SQLEXPRESS;Initial Catalog=societydb;Integrated Security=True";
        public int uid;
        public CreateEvent()
        {
            InitializeComponent();
            cn = new SqlConnection(conn);
            this.Icon = Properties.Resources.logo_ico;
        }

        public CreateEvent(int uID)
        {
            InitializeComponent();
            cn = new SqlConnection(conn);
            this.uid = uID;
            this.Icon = Properties.Resources.logo_ico;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void signout_btn_Click(object sender, EventArgs e)
        {
            LoginSignup loginSignup = new LoginSignup();
            loginSignup.Show();
            this.Hide();
        }

        private void createevent_btn_Click(object sender, EventArgs e)
        {
            CreateEvent createEvent = new CreateEvent();
            createEvent.Show();
            this.Hide();
        }

        private void viewevents_btn_Click(object sender, EventArgs e)
        {
            DisplayEvent viewEvent = new DisplayEvent();
            viewEvent.Show();
            this.Hide();
        }

        private void viewsociety_details_btn_Click(object sender, EventArgs e)
        {
            DisplaySociety displaySociety = new DisplaySociety();
            displaySociety.Show();
            this.Hide();
        }

        private void ance_btn_Click(object sender, EventArgs e)
        {
            CreateSociety createSociety = new CreateSociety();
            createSociety.Show();

            this.Hide();
        }

        private void add_event_btn_Click(object sender, EventArgs e)
        {
            //add into the event table
            cn.Open();
            DateTime dt;
            SqlTransaction transaction = cn.BeginTransaction();
            string query = "insert into eventRequest (eventName,description_,date_,userID)\r\nvalues (@ename, @desc,@d,@ui);";//input in request event table

            SqlCommand cmdSociety = new SqlCommand(query, cn, transaction);
            cmdSociety.Parameters.AddWithValue("@ename",ev_name.Text);
            cmdSociety.Parameters.AddWithValue("@desc", desc.Text);
            dt=DateTime.Parse(date_.Text);
            cmdSociety.Parameters.AddWithValue("@d", dt);
            cmdSociety.Parameters.AddWithValue("@ui", 2);

            cmdSociety.ExecuteNonQuery();

            transaction.Commit();

            MessageBox.Show("Event Request Successful!");
    

            cn.Close();
        }

        private void CreateEvent_Load(object sender, EventArgs e)
        {

        }

        private void ev_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
