namespace AlmonaTech_Society_Managment
{
    partial class CreateSociety
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
            this.label4 = new System.Windows.Forms.Label();
            this.ev_name = new System.Windows.Forms.RichTextBox();
            this.add_event_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ev_name);
            this.panel1.Controls.Add(this.add_event_btn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.desc);
            this.panel1.Location = new System.Drawing.Point(206, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 524);
            this.panel1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Society Name";
            // 
            // ev_name
            // 
            this.ev_name.Location = new System.Drawing.Point(170, 153);
            this.ev_name.Name = "ev_name";
            this.ev_name.Size = new System.Drawing.Size(270, 31);
            this.ev_name.TabIndex = 3;
            this.ev_name.Text = "";
            // 
            // add_event_btn
            // 
            this.add_event_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(115)))), ((int)(((byte)(141)))));
            this.add_event_btn.BackgroundImage = global::AlmonaTech_Society_Managment.Properties.Resources.button;
            this.add_event_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_event_btn.ForeColor = System.Drawing.Color.Azure;
            this.add_event_btn.Location = new System.Drawing.Point(390, 459);
            this.add_event_btn.Name = "add_event_btn";
            this.add_event_btn.Size = new System.Drawing.Size(112, 39);
            this.add_event_btn.TabIndex = 6;
            this.add_event_btn.Text = "Request";
            this.add_event_btn.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(137, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 46);
            this.label6.TabIndex = 13;
            this.label6.Text = "Create Society";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(37, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Description";
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(41, 273);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(399, 120);
            this.desc.TabIndex = 4;
            this.desc.Text = "";
            // 
            // CreateSociety
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::AlmonaTech_Society_Managment.Properties.Resources.button;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 653);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "CreateSociety";
            this.Text = "Create Society";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox ev_name;
        private System.Windows.Forms.Button add_event_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox desc;
    }
}