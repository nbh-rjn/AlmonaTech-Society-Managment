namespace AlmonaTech_Society_Managment
{
    partial class CreateEvent
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
            this.ev_name = new System.Windows.Forms.RichTextBox();
            this.desc = new System.Windows.Forms.RichTextBox();
            this.locale = new System.Windows.Forms.RichTextBox();
            this.date_ = new System.Windows.Forms.RichTextBox();
            this.sname = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.add_event_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ev_name
            // 
            this.ev_name.Location = new System.Drawing.Point(198, 97);
            this.ev_name.Name = "ev_name";
            this.ev_name.Size = new System.Drawing.Size(270, 31);
            this.ev_name.TabIndex = 3;
            this.ev_name.Text = "";
            this.ev_name.TextChanged += new System.EventHandler(this.ev_name_TextChanged);
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(69, 372);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(399, 92);
            this.desc.TabIndex = 4;
            this.desc.Text = "";
            this.desc.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // locale
            // 
            this.locale.Location = new System.Drawing.Point(198, 278);
            this.locale.Name = "locale";
            this.locale.Size = new System.Drawing.Size(270, 35);
            this.locale.TabIndex = 5;
            this.locale.Text = "";
            this.locale.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // date_
            // 
            this.date_.Location = new System.Drawing.Point(198, 212);
            this.date_.Name = "date_";
            this.date_.Size = new System.Drawing.Size(270, 35);
            this.date_.TabIndex = 6;
            this.date_.Text = "";
            // 
            // sname
            // 
            this.sname.Location = new System.Drawing.Point(198, 153);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(270, 32);
            this.sname.TabIndex = 7;
            this.sname.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Event Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Society Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(65, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date and Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(65, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(65, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Description";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(178, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 46);
            this.label6.TabIndex = 13;
            this.label6.Text = "Add an Event";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // add_event_btn
            // 
            this.add_event_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(115)))), ((int)(((byte)(141)))));
            this.add_event_btn.BackgroundImage = global::AlmonaTech_Society_Managment.Properties.Resources.button;
            this.add_event_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_event_btn.ForeColor = System.Drawing.Color.Azure;
            this.add_event_btn.Location = new System.Drawing.Point(449, 505);
            this.add_event_btn.Name = "add_event_btn";
            this.add_event_btn.Size = new System.Drawing.Size(112, 39);
            this.add_event_btn.TabIndex = 6;
            this.add_event_btn.Text = "Add Event";
            this.add_event_btn.UseVisualStyleBackColor = false;
            this.add_event_btn.Click += new System.EventHandler(this.add_event_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ev_name);
            this.panel1.Controls.Add(this.add_event_btn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.sname);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.desc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.locale);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.date_);
            this.panel1.Location = new System.Drawing.Point(160, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 569);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::AlmonaTech_Society_Managment.Properties.Resources.button;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 653);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "CreateEvent";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CreateEvent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox ev_name;
        private System.Windows.Forms.RichTextBox desc;
        private System.Windows.Forms.RichTextBox locale;
        private System.Windows.Forms.RichTextBox date_;
        private System.Windows.Forms.RichTextBox sname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button add_event_btn;
        private System.Windows.Forms.Panel panel1;
    }
}