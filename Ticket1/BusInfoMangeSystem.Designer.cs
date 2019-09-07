namespace Ticket1
{
    partial class BusInfoMangeSystem
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.userbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(118, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 530);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // button5
            // 
            this.button5.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Ticket1.Properties.Settings.Default, "lb60", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button5.Location = new System.Drawing.Point(14, 288);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 44);
            this.button5.TabIndex = 6;
            this.button5.Text = global::Ticket1.Properties.Settings.Default.lb60;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button4
            // 
            this.button4.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Ticket1.Properties.Settings.Default, "lb46", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button4.Location = new System.Drawing.Point(14, 349);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 35);
            this.button4.TabIndex = 5;
            this.button4.Text = global::Ticket1.Properties.Settings.Default.lb46;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Ticket1.Properties.Settings.Default, "lb48", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button3.Location = new System.Drawing.Point(13, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = global::Ticket1.Properties.Settings.Default.lb48;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Ticket1.Properties.Settings.Default, "lb45", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button2.Location = new System.Drawing.Point(13, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = global::Ticket1.Properties.Settings.Default.lb45;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Ticket1.Properties.Settings.Default, "userbotton2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button1.Location = new System.Drawing.Point(12, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = global::Ticket1.Properties.Settings.Default.userbotton2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // userbutton1
            // 
            this.userbutton1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Ticket1.Properties.Settings.Default, "userbutton1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.userbutton1.Location = new System.Drawing.Point(12, 45);
            this.userbutton1.Name = "userbutton1";
            this.userbutton1.Size = new System.Drawing.Size(100, 45);
            this.userbutton1.TabIndex = 1;
            this.userbutton1.Text = global::Ticket1.Properties.Settings.Default.userbutton1;
            this.userbutton1.UseVisualStyleBackColor = true;
            this.userbutton1.Click += new System.EventHandler(this.Userbutton1_Click);
            // 
            // UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 551);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userbutton1);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl";
            this.Text = "UserControl";
            this.Load += new System.EventHandler(this.UserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button userbutton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}