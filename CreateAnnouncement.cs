﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void add_event_btn_Click(object sender, EventArgs e) //post announcement
        {
            // Get the content from the RichTextBox
            string announcementDesc = desc.Text;

            // Insert the content into the announcement table
            string query = "INSERT INTO anncement (announcementDesc) VALUES (@announcementDesc)";

            using (SqlConnection connection = new SqlConnection("Your_Connection_String_Here"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command to avoid SQL injection
                    command.Parameters.AddWithValue("@announcementDesc", announcementDesc);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Announcement saved successfully.");
                        // Clear the RichTextBox after saving
                        desc.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save announcement.");
                    }
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sname_TextChanged(object sender, EventArgs e)
        {

        }

        private void date__TextChanged(object sender, EventArgs e)
        {

        }

        private void locale_TextChanged(object sender, EventArgs e)
        {

        }

        private void desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void ev_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}