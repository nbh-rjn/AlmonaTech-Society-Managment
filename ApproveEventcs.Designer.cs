namespace AlmonaTech_Society_Managment
{
    partial class ApproveEventcs
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
            this.approveEventGrid = new System.Windows.Forms.DataGridView();
            this.approve_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.approveEventGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // approveEventGrid
            // 
            this.approveEventGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.approveEventGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.approveEventGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.approve_btn});
            this.approveEventGrid.GridColor = System.Drawing.Color.Azure;
            this.approveEventGrid.Location = new System.Drawing.Point(18, 20);
            this.approveEventGrid.Name = "approveEventGrid";
            this.approveEventGrid.RowHeadersWidth = 51;
            this.approveEventGrid.RowTemplate.Height = 24;
            this.approveEventGrid.Size = new System.Drawing.Size(667, 462);
            this.approveEventGrid.TabIndex = 0;
            this.approveEventGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.approveEventGrid_CellContentClick);
            // 
            // approve_btn
            // 
            this.approve_btn.HeaderText = "Approve";
            this.approve_btn.MinimumWidth = 6;
            this.approve_btn.Name = "approve_btn";
            this.approve_btn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.approve_btn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.approve_btn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(207)))), ((int)(((byte)(223)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Approve Event";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(207)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.approveEventGrid);
            this.panel1.Location = new System.Drawing.Point(177, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 505);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(207)))), ((int)(((byte)(223)))));
            this.pictureBox1.BackgroundImage = global::AlmonaTech_Society_Managment.Properties.Resources.home_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 53);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // ApproveEventcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::AlmonaTech_Society_Managment.Properties.Resources.blobby1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 664);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ApproveEventcs";
            this.Text = "ApproveEventcs";
            this.Load += new System.EventHandler(this.ApproveEventcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.approveEventGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView approveEventGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn approve_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}