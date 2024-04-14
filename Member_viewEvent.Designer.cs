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
            this.viewevent_btn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventstable)).BeginInit();
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
            // viewevent_btn
            // 
            this.viewevent_btn.Image = global::AlmonaTech_Society_Managment.Properties.Resources.icons8_home_50;
            this.viewevent_btn.Location = new System.Drawing.Point(26, 25);
            this.viewevent_btn.Name = "viewevent_btn";
            this.viewevent_btn.Size = new System.Drawing.Size(37, 37);
            this.viewevent_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viewevent_btn.TabIndex = 4;
            this.viewevent_btn.TabStop = false;
            this.viewevent_btn.Click += new System.EventHandler(this.viewevent_btn_Click);
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
            // Member_viewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(997, 695);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.viewevent_btn);
            this.Name = "Member_viewEvent";
            this.Text = "Member_viewEvent";
            this.Load += new System.EventHandler(this.Member_viewEvent_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventstable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewevent_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView eventstable;
        private System.Windows.Forms.PictureBox viewevent_btn;
        private System.Windows.Forms.Label label1;
    }
}