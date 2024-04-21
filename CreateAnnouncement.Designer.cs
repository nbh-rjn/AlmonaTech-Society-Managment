namespace AlmonaTech_Society_Managment
{
    partial class CreateAnnouncement
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
            this.add_event_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // add_event_btn
            // 
            this.add_event_btn.BackColor = System.Drawing.Color.Transparent;
            this.add_event_btn.BackgroundImage = global::AlmonaTech_Society_Managment.Properties.Resources.button;
            this.add_event_btn.Cursor = System.Windows.Forms.Cursors.Cross;
            this.add_event_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_event_btn.ForeColor = System.Drawing.Color.White;
            this.add_event_btn.Location = new System.Drawing.Point(730, 570);
            this.add_event_btn.Name = "add_event_btn";
            this.add_event_btn.Size = new System.Drawing.Size(159, 49);
            this.add_event_btn.TabIndex = 17;
            this.add_event_btn.Text = "Post";
            this.add_event_btn.UseVisualStyleBackColor = false;
            this.add_event_btn.Click += new System.EventHandler(this.add_event_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(324, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(350, 46);
            this.label6.TabIndex = 25;
            this.label6.Text = "Add an Announcement";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(139, 140);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(750, 371);
            this.desc.TabIndex = 15;
            this.desc.Text = "";
            this.desc.TextChanged += new System.EventHandler(this.desc_TextChanged);
            // 
            // CreateAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::AlmonaTech_Society_Managment.Properties.Resources.button;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 657);
            this.Controls.Add(this.add_event_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.desc);
            this.DoubleBuffered = true;
            this.Name = "CreateAnnouncement";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button add_event_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox desc;
    }
}