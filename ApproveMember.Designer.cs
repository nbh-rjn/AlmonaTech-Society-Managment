namespace AlmonaTech_Society_Managment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApproveMember));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.societytable = new System.Windows.Forms.DataGridView();
            this.Approve = new System.Windows.Forms.DataGridViewButtonColumn();
            this.homebtn = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.societytable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homebtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Approve Member";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
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
            this.societytable.BackgroundColor = System.Drawing.Color.Azure;
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
            // homebtn
            // 
            this.homebtn.Image = global::AlmonaTech_Society_Managment.Properties.Resources.icons8_home_50;
            this.homebtn.Location = new System.Drawing.Point(27, 23);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(31, 30);
            this.homebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homebtn.TabIndex = 8;
            this.homebtn.TabStop = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // ApproveMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(936, 669);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApproveMember";
            this.Text = "ApproveMember";
            this.Load += new System.EventHandler(this.ApproveMember_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.societytable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homebtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView societytable;
        private System.Windows.Forms.DataGridViewButtonColumn Approve;
        private System.Windows.Forms.PictureBox homebtn;
    }
}