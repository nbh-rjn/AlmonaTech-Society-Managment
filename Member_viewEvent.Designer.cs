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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventstable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.eventstable);
            this.panel2.Location = new System.Drawing.Point(146, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 509);
            this.panel2.TabIndex = 5;
            // 
            // eventstable
            // 
            this.eventstable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventstable.BackgroundColor = System.Drawing.Color.Lavender;
            this.eventstable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventstable.GridColor = System.Drawing.Color.LightBlue;
            this.eventstable.Location = new System.Drawing.Point(16, 21);
            this.eventstable.Name = "eventstable";
            this.eventstable.RowHeadersWidth = 51;
            this.eventstable.RowTemplate.Height = 24;
            this.eventstable.Size = new System.Drawing.Size(590, 476);
            this.eventstable.TabIndex = 0;
            this.eventstable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventstable_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(351, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "View Events";
            // 
            // Member_viewEvent
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
            this.Name = "Member_viewEvent";
            this.Text = "Member_viewEvent";
            this.Load += new System.EventHandler(this.Member_viewEvent_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventstable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView eventstable;
        private System.Windows.Forms.Label label1;
    }
}