﻿namespace AlmonaTech_Society_Managment
{
    partial class DisplaySociety
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ance_btn = new System.Windows.Forms.Button();
            this.signout_btn = new System.Windows.Forms.Button();
            this.dashboard__btn = new System.Windows.Forms.Button();
            this.viewevents_btn = new System.Windows.Forms.Button();
            this.createevent_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.societytable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.create_ance_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.societytable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.create_ance_btn);
            this.panel1.Controls.Add(this.ance_btn);
            this.panel1.Controls.Add(this.signout_btn);
            this.panel1.Controls.Add(this.dashboard__btn);
            this.panel1.Controls.Add(this.viewevents_btn);
            this.panel1.Controls.Add(this.createevent_btn);
            this.panel1.Location = new System.Drawing.Point(-17, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 654);
            this.panel1.TabIndex = 1;
            // 
            // ance_btn
            // 
            this.ance_btn.BackColor = System.Drawing.Color.Azure;
            this.ance_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ance_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ance_btn.Location = new System.Drawing.Point(25, 354);
            this.ance_btn.Name = "ance_btn";
            this.ance_btn.Size = new System.Drawing.Size(159, 86);
            this.ance_btn.TabIndex = 4;
            this.ance_btn.Text = "Announcements";
            this.ance_btn.UseVisualStyleBackColor = false;
            // 
            // signout_btn
            // 
            this.signout_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.signout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signout_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.signout_btn.Location = new System.Drawing.Point(25, 580);
            this.signout_btn.Name = "signout_btn";
            this.signout_btn.Size = new System.Drawing.Size(159, 49);
            this.signout_btn.TabIndex = 3;
            this.signout_btn.Text = "Sign Out";
            this.signout_btn.UseVisualStyleBackColor = false;
            // 
            // dashboard__btn
            // 
            this.dashboard__btn.BackColor = System.Drawing.Color.Azure;
            this.dashboard__btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard__btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.dashboard__btn.Location = new System.Drawing.Point(25, 247);
            this.dashboard__btn.Name = "dashboard__btn";
            this.dashboard__btn.Size = new System.Drawing.Size(159, 86);
            this.dashboard__btn.TabIndex = 2;
            this.dashboard__btn.Text = "Dashboard";
            this.dashboard__btn.UseVisualStyleBackColor = false;
            // 
            // viewevents_btn
            // 
            this.viewevents_btn.BackColor = System.Drawing.Color.Azure;
            this.viewevents_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewevents_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.viewevents_btn.Location = new System.Drawing.Point(25, 138);
            this.viewevents_btn.Name = "viewevents_btn";
            this.viewevents_btn.Size = new System.Drawing.Size(159, 86);
            this.viewevents_btn.TabIndex = 1;
            this.viewevents_btn.Text = "View Events";
            this.viewevents_btn.UseVisualStyleBackColor = false;
            // 
            // createevent_btn
            // 
            this.createevent_btn.BackColor = System.Drawing.Color.Azure;
            this.createevent_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createevent_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.createevent_btn.Location = new System.Drawing.Point(25, 30);
            this.createevent_btn.Name = "createevent_btn";
            this.createevent_btn.Size = new System.Drawing.Size(159, 86);
            this.createevent_btn.TabIndex = 0;
            this.createevent_btn.Text = "Create Event";
            this.createevent_btn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.societytable);
            this.panel2.Location = new System.Drawing.Point(274, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 502);
            this.panel2.TabIndex = 2;
            // 
            // societytable
            // 
            this.societytable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.societytable.BackgroundColor = System.Drawing.Color.Azure;
            this.societytable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.societytable.GridColor = System.Drawing.Color.LightBlue;
            this.societytable.Location = new System.Drawing.Point(16, 14);
            this.societytable.Name = "societytable";
            this.societytable.RowHeadersWidth = 51;
            this.societytable.RowTemplate.Height = 24;
            this.societytable.Size = new System.Drawing.Size(586, 472);
            this.societytable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Society Details";
            // 
            // create_ance_btn
            // 
            this.create_ance_btn.BackColor = System.Drawing.Color.Azure;
            this.create_ance_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_ance_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.create_ance_btn.Location = new System.Drawing.Point(25, 465);
            this.create_ance_btn.Name = "create_ance_btn";
            this.create_ance_btn.Size = new System.Drawing.Size(159, 86);
            this.create_ance_btn.TabIndex = 5;
            this.create_ance_btn.Text = "Create Announcements";
            this.create_ance_btn.UseVisualStyleBackColor = false;
            // 
            // DisplaySociety
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1005, 642);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DisplaySociety";
            this.Text = "DisplaySociety";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.societytable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ance_btn;
        private System.Windows.Forms.Button signout_btn;
        private System.Windows.Forms.Button dashboard__btn;
        private System.Windows.Forms.Button viewevents_btn;
        private System.Windows.Forms.Button createevent_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView societytable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button create_ance_btn;
    }
}