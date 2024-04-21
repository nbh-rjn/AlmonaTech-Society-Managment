namespace AlmonaTech_Society_Managment
{
    partial class Member_SocietyLeavecs
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.societytable = new System.Windows.Forms.DataGridView();
            this.Leave = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.societytable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(362, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Your Societies";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.societytable);
            this.panel2.Location = new System.Drawing.Point(171, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 502);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 296);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 8);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
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
            this.Leave});
            this.societytable.GridColor = System.Drawing.Color.LightBlue;
            this.societytable.Location = new System.Drawing.Point(16, 35);
            this.societytable.Name = "societytable";
            this.societytable.RowHeadersWidth = 51;
            this.societytable.RowTemplate.Height = 24;
            this.societytable.Size = new System.Drawing.Size(586, 390);
            this.societytable.TabIndex = 0;
            this.societytable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.societytable_CellContentClick);
            // 
            // Leave
            // 
            this.Leave.HeaderText = "Leave";
            this.Leave.MinimumWidth = 6;
            this.Leave.Name = "Leave";
            // 
            // Member_SocietyLeavecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::AlmonaTech_Society_Managment.Properties.Resources.button;
            this.ClientSize = new System.Drawing.Size(932, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "Member_SocietyLeavecs";
            this.Text = "Member_SocietyLeavecs";
            this.Load += new System.EventHandler(this.Member_SocietyLeavecs_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.societytable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView societytable;
        private System.Windows.Forms.DataGridViewButtonColumn Leave;
    }
}