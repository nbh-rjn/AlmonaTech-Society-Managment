﻿namespace AlmonaTech_Society_Managment
{
    partial class Dashboard
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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ance_btn = new System.Windows.Forms.Button();
            this.signout_btn = new System.Windows.Forms.Button();
            this.viewsociety_details_btn = new System.Windows.Forms.Button();
            this.viewevents_btn = new System.Windows.Forms.Button();
            this.createevent_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(207)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ance_btn);
            this.panel1.Controls.Add(this.signout_btn);
            this.panel1.Controls.Add(this.viewsociety_details_btn);
            this.panel1.Controls.Add(this.viewevents_btn);
            this.panel1.Controls.Add(this.createevent_btn);
            this.panel1.Location = new System.Drawing.Point(-13, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 713);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSlateGray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(25, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 86);
            this.button3.TabIndex = 7;
            this.button3.Text = "Approve Member";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(25, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 86);
            this.button1.TabIndex = 5;
            this.button1.Text = "View Announcements";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ance_btn
            // 
            this.ance_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.ance_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ance_btn.ForeColor = System.Drawing.Color.White;
            this.ance_btn.Location = new System.Drawing.Point(25, 421);
            this.ance_btn.Name = "ance_btn";
            this.ance_btn.Size = new System.Drawing.Size(159, 86);
            this.ance_btn.TabIndex = 4;
            this.ance_btn.Text = "Create Society";
            this.ance_btn.UseVisualStyleBackColor = false;
            this.ance_btn.Click += new System.EventHandler(this.ance_btn_Click);
            // 
            // signout_btn
            // 
            this.signout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(77)))), ((int)(((byte)(94)))));
            this.signout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signout_btn.ForeColor = System.Drawing.Color.White;
            this.signout_btn.Location = new System.Drawing.Point(25, 643);
            this.signout_btn.Name = "signout_btn";
            this.signout_btn.Size = new System.Drawing.Size(159, 49);
            this.signout_btn.TabIndex = 3;
            this.signout_btn.Text = "Sign Out";
            this.signout_btn.UseVisualStyleBackColor = false;
            this.signout_btn.Click += new System.EventHandler(this.signout_btn_Click);
            // 
            // viewsociety_details_btn
            // 
            this.viewsociety_details_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.viewsociety_details_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewsociety_details_btn.ForeColor = System.Drawing.Color.White;
            this.viewsociety_details_btn.Location = new System.Drawing.Point(25, 315);
            this.viewsociety_details_btn.Name = "viewsociety_details_btn";
            this.viewsociety_details_btn.Size = new System.Drawing.Size(159, 86);
            this.viewsociety_details_btn.TabIndex = 2;
            this.viewsociety_details_btn.Text = "View Society";
            this.viewsociety_details_btn.UseVisualStyleBackColor = false;
            this.viewsociety_details_btn.Click += new System.EventHandler(this.viewsociety_details_btn_Click);
            // 
            // viewevents_btn
            // 
            this.viewevents_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.viewevents_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewevents_btn.ForeColor = System.Drawing.Color.White;
            this.viewevents_btn.Location = new System.Drawing.Point(25, 212);
            this.viewevents_btn.Name = "viewevents_btn";
            this.viewevents_btn.Size = new System.Drawing.Size(159, 86);
            this.viewevents_btn.TabIndex = 1;
            this.viewevents_btn.Text = "View Events";
            this.viewevents_btn.UseVisualStyleBackColor = false;
            this.viewevents_btn.Click += new System.EventHandler(this.viewevents_btn_Click);
            // 
            // createevent_btn
            // 
            this.createevent_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.createevent_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createevent_btn.ForeColor = System.Drawing.Color.White;
            this.createevent_btn.Location = new System.Drawing.Point(25, 15);
            this.createevent_btn.Name = "createevent_btn";
            this.createevent_btn.Size = new System.Drawing.Size(159, 86);
            this.createevent_btn.TabIndex = 0;
            this.createevent_btn.Text = "Request Event";
            this.createevent_btn.UseVisualStyleBackColor = false;
            this.createevent_btn.Click += new System.EventHandler(this.createevent_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 49.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(77)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(368, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 92);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::AlmonaTech_Society_Managment.Properties.Resources.blobby1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 698);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button createevent_btn;
        private System.Windows.Forms.Button signout_btn;
        private System.Windows.Forms.Button viewsociety_details_btn;
        private System.Windows.Forms.Button viewevents_btn;
        private System.Windows.Forms.Button ance_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button3;
    }
}