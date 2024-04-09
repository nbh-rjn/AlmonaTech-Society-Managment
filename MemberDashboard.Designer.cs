namespace AlmonaTech_Society_Managment
{
    partial class MemberDashboard
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
            this.view_society_btn = new System.Windows.Forms.PictureBox();
            this.leave_society_btn = new System.Windows.Forms.PictureBox();
            this.join_society_btn = new System.Windows.Forms.PictureBox();
            this.viewevent_btn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_society_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leave_society_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.join_society_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewevent_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.view_society_btn);
            this.panel1.Controls.Add(this.leave_society_btn);
            this.panel1.Controls.Add(this.join_society_btn);
            this.panel1.Controls.Add(this.viewevent_btn);
            this.panel1.Location = new System.Drawing.Point(-7, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 648);
            this.panel1.TabIndex = 2;
            // 
            // view_society_btn
            // 
            this.view_society_btn.Image = global::AlmonaTech_Society_Managment.Properties.Resources.icons8_view_50;
            this.view_society_btn.Location = new System.Drawing.Point(24, 274);
            this.view_society_btn.Name = "view_society_btn";
            this.view_society_btn.Size = new System.Drawing.Size(69, 73);
            this.view_society_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.view_society_btn.TabIndex = 6;
            this.view_society_btn.TabStop = false;
            this.view_society_btn.Click += new System.EventHandler(this.view_society_btn_Click);
            // 
            // leave_society_btn
            // 
            this.leave_society_btn.Image = global::AlmonaTech_Society_Managment.Properties.Resources.icons8_leave_50;
            this.leave_society_btn.Location = new System.Drawing.Point(24, 521);
            this.leave_society_btn.Name = "leave_society_btn";
            this.leave_society_btn.Size = new System.Drawing.Size(63, 70);
            this.leave_society_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leave_society_btn.TabIndex = 5;
            this.leave_society_btn.TabStop = false;
            this.leave_society_btn.Click += new System.EventHandler(this.leave_society_btn_Click);
            // 
            // join_society_btn
            // 
            this.join_society_btn.Image = global::AlmonaTech_Society_Managment.Properties.Resources.add;
            this.join_society_btn.Location = new System.Drawing.Point(24, 145);
            this.join_society_btn.Name = "join_society_btn";
            this.join_society_btn.Size = new System.Drawing.Size(80, 75);
            this.join_society_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.join_society_btn.TabIndex = 4;
            this.join_society_btn.TabStop = false;
            this.join_society_btn.Click += new System.EventHandler(this.join_society_btn_Click);
            // 
            // viewevent_btn
            // 
            this.viewevent_btn.Image = global::AlmonaTech_Society_Managment.Properties.Resources.icons8_calendar_50;
            this.viewevent_btn.Location = new System.Drawing.Point(30, 28);
            this.viewevent_btn.Name = "viewevent_btn";
            this.viewevent_btn.Size = new System.Drawing.Size(69, 73);
            this.viewevent_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viewevent_btn.TabIndex = 3;
            this.viewevent_btn.TabStop = false;
            this.viewevent_btn.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AlmonaTech_Society_Managment.Properties.Resources.icons8_announcement_50;
            this.pictureBox1.Location = new System.Drawing.Point(24, 395);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MemberDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(985, 637);
            this.Controls.Add(this.panel1);
            this.Name = "MemberDashboard";
            this.Text = "MemberDashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_society_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leave_society_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.join_society_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewevent_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox viewevent_btn;
        private System.Windows.Forms.PictureBox join_society_btn;
        private System.Windows.Forms.PictureBox leave_society_btn;
        private System.Windows.Forms.PictureBox view_society_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}