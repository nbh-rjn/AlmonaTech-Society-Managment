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
    public partial class ViewAnnouncement : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;

        public string conn = "Data Source=HOME\\SQLEXPRESS;Initial Catalog=societydb;Integrated Security=True";
        //public string conn = "Data Source=DESKTOP-67QKUHG\\SQLEXPRESS;Initial Catalog=societydb;Integrated Security=True";
        public int uID;

        public ViewAnnouncement()
        {
            InitializeComponent();
            cn = new SqlConnection(conn);
            this.Icon = Properties.Resources.logo_ico;
            AnnouncementGridView();

        }

        public ViewAnnouncement(int uid)
        {
            InitializeComponent();
            cn = new SqlConnection(conn);
            this.uID = uid;
            this.Icon = Properties.Resources.logo_ico;
            AnnouncementGridView();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        public void AnnouncementGridView()
        {
            try
            {
                cn.Open();

                string q = "SELECT a.announcementTitle AS 'Title', a.announcementDesc AS 'Announcement', a.announcementDateTime AS 'Date'\r\nFROM announcements a\r\nJOIN society s ON a.userID = s.leadID\r\nJOIN member_ m ON s.societyID = m.societyID\r\nWHERE m.userID = @uID;\r\n";

                SqlCommand cmd = new SqlCommand(q, cn);

                cmd.Parameters.AddWithValue("@uID", uID);

                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(reader);

                announcementstable.DataSource = dt;

                reader.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ViewAnnouncement_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
