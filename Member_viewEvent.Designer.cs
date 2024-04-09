namespace AlmonaTech_Society_Managment
{
    partial class Member_viewEvent
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.eventstable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.leave_society_btn = new System.Windows.Forms.PictureBox();
            this.view_society_btn = new System.Windows.Forms.PictureBox();
            this.join_society_btn = new System.Windows.Forms.PictureBox();
            this.viewevent_btn = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventstable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leave_society_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_society_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.join_society_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewevent_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.eventstable);
            this.panel2.Location = new System.Drawing.Point(252, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 502);
            this.panel2.TabIndex = 5;
            // 
            // eventstable
            // 
            this.eventstable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventstable.BackgroundColor = System.Drawing.Color.Azure;
            this.eventstable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventstable.GridColor = System.Drawing.Color.LightBlue;
            this.eventstable.Location = new System.Drawing.Point(16, 12);
            this.eventstable.Name = "eventstable";
            this.eventstable.RowHeadersWidth = 51;
            this.eventstable.RowTemplate.Height = 24;
            this.eventstable.Size = new System.Drawing.Size(590, 478);
            this.eventstable.TabIndex = 0;
            this.eventstable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventstable_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.leave_society_btn);
            this.panel1.Controls.Add(this.view_society_btn);
            this.panel1.Controls.Add(this.join_society_btn);
            this.panel1.Controls.Add(this.viewevent_btn);
            this.panel1.Location = new System.Drawing.Point(-10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 695);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "View Events";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AlmonaTech_Society_Managment.Properties.Resources.icons8_announcement_50;
            this.pictureBox1.Location = new System.Drawing.Point(37, 460);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // leave_society_btn
            // 
            this.leave_society_btn.Image = global::AlmonaTech_Society_Managment.Properties.Resources.icons8_leave_50;
            this.leave_society_btn.Location = new System.Drawing.Point(46, 585);
            this.leave_society_btn.Name = "leave_society_btn";
            this.leave_society_btn.Size = new System.Drawing.Size(65, 76);
            this.leave_society_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leave_society_btn.TabIndex = 8;
            this.leave_society_btn.TabStop = false;
            this.leave_society_btn.Click += new System.EventHandler(this.leave_society_btn_Click);
            // 
            // view_society_btn
            // 
            this.view_society_btn.Image = global::AlmonaTech_Society_Managment.Properties.Resources.icons8_view_50;
            this.view_society_btn.Location = new System.Drawing.Point(37, 335);
            this.view_society_btn.Name = "view_society_btn";
            this.view_society_btn.Size = new System.Drawing.Size(65, 73);
            this.view_society_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.view_society_btn.TabIndex = 7;
            this.view_society_btn.TabStop = false;
            this.view_society_btn.Click += new System.EventHandler(this.view_society_btn_Click);
            // 
            // join_society_btn
            // 
            this.join_society_btn.Image = global::AlmonaTech_Society_Managment.Properties.Resources.add;
            this.join_society_btn.Location = new System.Drawing.Point(37, 184);
            this.join_society_btn.Name = "join_society_btn";
            this.join_society_btn.Size = new System.Drawing.Size(74, 82);
            this.join_society_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.join_society_btn.TabIndex = 5;
            this.join_society_btn.TabStop = false;
            this.join_society_btn.Click += new System.EventHandler(this.join_society_btn_Click);
            // 
            // viewevent_btn
            // 
            this.viewevent_btn.Image = global::AlmonaTech_Society_Managment.Properties.Resources.icons8_home_50;
            this.viewevent_btn.Location = new System.Drawing.Point(37, 58);
            this.viewevent_btn.Name = "viewevent_btn";
            this.viewevent_btn.Size = new System.Drawing.Size(60, 58);
            this.viewevent_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viewevent_btn.TabIndex = 4;
            this.viewevent_btn.TabStop = false;
            this.viewevent_btn.Click += new System.EventHandler(this.viewevent_btn_Click);
            // 
            // Member_viewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(997, 695);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Member_viewEvent";
            this.Text = "Member_viewEvent";
            this.Load += new System.EventHandler(this.Member_viewEvent_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventstable)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leave_society_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_society_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.join_society_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewevent_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView eventstable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox viewevent_btn;
        private System.Windows.Forms.PictureBox join_society_btn;
        private System.Windows.Forms.PictureBox view_society_btn;
        private System.Windows.Forms.PictureBox leave_society_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}