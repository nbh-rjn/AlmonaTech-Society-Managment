﻿namespace AlmonaTech_Society_Managment
{
    partial class ViewAnnouncement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.announcementstable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.announcementstable)).BeginInit();
            this.SuspendLayout();
            // 
            // announcementstable
            // 
            this.announcementstable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.announcementstable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.announcementstable.BackgroundColor = System.Drawing.Color.Lavender;
            this.announcementstable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.announcementstable.GridColor = System.Drawing.Color.LightBlue;
            this.announcementstable.Location = new System.Drawing.Point(88, 115);
            this.announcementstable.Name = "announcementstable";
            this.announcementstable.RowHeadersWidth = 51;
            this.announcementstable.RowTemplate.Height = 24;
            this.announcementstable.Size = new System.Drawing.Size(785, 457);
            this.announcementstable.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(332, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Announcements";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ViewAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::AlmonaTech_Society_Managment.Properties.Resources.button;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.announcementstable);
            this.DoubleBuffered = true;
            this.Name = "ViewAnnouncement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAnnouncement";
            this.Load += new System.EventHandler(this.ViewAnnouncement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.announcementstable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView announcementstable;
        private System.Windows.Forms.Label label1;
    }
}