﻿namespace AlmonaTech_Society_Managment
{
    partial class ApproveMember
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.societytable = new System.Windows.Forms.DataGridView();
            this.Approve = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.societytable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(356, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Approve Member";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.societytable);
            this.panel2.Location = new System.Drawing.Point(198, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 502);
            this.panel2.TabIndex = 6;
            // 
            // societytable
            // 
            this.societytable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.societytable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.societytable.BackgroundColor = System.Drawing.Color.Lavender;
            this.societytable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.societytable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Approve});
            this.societytable.GridColor = System.Drawing.Color.LightBlue;
            this.societytable.Location = new System.Drawing.Point(21, 16);
            this.societytable.Name = "societytable";
            this.societytable.RowHeadersWidth = 51;
            this.societytable.RowTemplate.Height = 24;
            this.societytable.Size = new System.Drawing.Size(586, 472);
            this.societytable.TabIndex = 0;
            this.societytable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.societytable_CellContentClick);
            // 
            // Approve
            // 
            this.Approve.HeaderText = "Approve";
            this.Approve.MinimumWidth = 6;
            this.Approve.Name = "Approve";
            // 
            // ApproveMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::AlmonaTech_Society_Managment.Properties.Resources.button;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "ApproveMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApproveMember";
            this.Load += new System.EventHandler(this.ApproveMember_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.societytable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView societytable;
        private System.Windows.Forms.DataGridViewButtonColumn Approve;
    }
}