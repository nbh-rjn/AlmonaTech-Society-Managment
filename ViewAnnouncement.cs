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
        public int uID;

        public ViewAnnouncement()
        {
            InitializeComponent();
            cn = new SqlConnection(conn);
        }

        public ViewAnnouncement(int uid)
        {
            InitializeComponent();
            cn = new SqlConnection(conn);
            this.uID = uid; 
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void ViewAnnouncement_Load(object sender, EventArgs e)
        {

        }
    }
}
