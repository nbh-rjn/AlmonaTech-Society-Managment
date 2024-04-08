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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sign_out_btn = new System.Windows.Forms.Button();
            this.view_society_btn = new System.Windows.Forms.PictureBox();
            this.leave_society_btn = new System.Windows.Forms.PictureBox();
            this.join_society_btn = new System.Windows.Forms.PictureBox();
            this.viewevent_btn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_society_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leave_society_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.join_society_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewevent_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome !!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.view_society_btn);
            this.panel1.Controls.Add(this.leave_society_btn);
            this.panel1.Controls.Add(this.join_society_btn);
            this.panel1.Controls.Add(this.viewevent_btn);
            this.panel1.Location = new System.Drawing.Point(109, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 147);
            this.panel1.TabIndex = 2;
            // 
            // sign_out_btn
            // 
            this.sign_out_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.sign_out_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sign_out_btn.Location = new System.Drawing.Point(453, 421);
            this.sign_out_btn.Name = "sign_out_btn";
            this.sign_out_btn.Size = new System.Drawing.Size(131, 55);
            this.sign_out_btn.TabIndex = 3;
            this.sign_out_btn.Text = "Sign Out";
            this.sign_out_btn.UseVisualStyleBackColor = false;
            // 
            // view_society_btn
            // 
            this.view_society_btn.Image = global::AlmonaTech_Society_Managment.Properties.Resources.icons8_view_50;
            this.view_society_btn.Location = new System.Drawing.Point(450, 28);
            this.view_society_btn.Name = "view_society_btn";
            this.view_society_btn.Size = new System.Drawing.Size(83, 83);
            this.view_society_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.view_society_btn.TabIndex = 6;
            this.view_society_btn.TabStop = false;
            this.view_society_btn.Click += new System.EventHandler(this.view_society_btn_Click);
            // 
            // leave_society_btn
            // 
            this.leave_society_btn.Image = global::AlmonaTech_Society_Managment.Properties.Resources.icons8_leave_50;
            this.leave_society_btn.Location = new System.Drawing.Point(647, 28);
            this.leave_society_btn.Name = "leave_society_btn";
            this.leave_society_btn.Size = new System.Drawing.Size(83, 83);
            this.leave_society_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leave_society_btn.TabIndex = 5;
            this.leave_society_btn.TabStop = false;
            // 
            // join_society_btn
            // 
            this.join_society_btn.Image = global::AlmonaTech_Society_Managment.Properties.Resources.add;
            this.join_society_btn.Location = new System.Drawing.Point(256, 28);
            this.join_society_btn.Name = "join_society_btn";
            this.join_society_btn.Size = new System.Drawing.Size(83, 83);
            this.join_society_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.join_society_btn.TabIndex = 4;
            this.join_society_btn.TabStop = false;
            // 
            // viewevent_btn
            // 
            this.viewevent_btn.Image = global::AlmonaTech_Society_Managment.Properties.Resources.icons8_calendar_50;
            this.viewevent_btn.Location = new System.Drawing.Point(55, 28);
            this.viewevent_btn.Name = "viewevent_btn";
            this.viewevent_btn.Size = new System.Drawing.Size(82, 83);
            this.viewevent_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viewevent_btn.TabIndex = 3;
            this.viewevent_btn.TabStop = false;
            this.viewevent_btn.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MemberDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(985, 637);
            this.Controls.Add(this.sign_out_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "MemberDashboard";
            this.Text = "MemberDashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_society_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leave_society_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.join_society_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewevent_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox viewevent_btn;
        private System.Windows.Forms.PictureBox join_society_btn;
        private System.Windows.Forms.PictureBox leave_society_btn;
        private System.Windows.Forms.PictureBox view_society_btn;
        private System.Windows.Forms.Button sign_out_btn;
    }
}