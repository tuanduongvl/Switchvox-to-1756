namespace testAllenBradleyNetcore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.txt_tagNumber1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tagNumber2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_callEvent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_callTrigger = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_callFilter = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_PBX_URL = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(115, 12);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(100, 23);
            this.txt_IP.TabIndex = 1;
            this.txt_IP.Text = "10.1.1.122";
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(115, 41);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(100, 23);
            this.txt_Path.TabIndex = 2;
            this.txt_Path.Text = "1, 0";
            // 
            // txt_tagNumber1
            // 
            this.txt_tagNumber1.Location = new System.Drawing.Point(379, 15);
            this.txt_tagNumber1.Name = "txt_tagNumber1";
            this.txt_tagNumber1.Size = new System.Drawing.Size(100, 23);
            this.txt_tagNumber1.TabIndex = 3;
            this.txt_tagNumber1.Text = "PhoneNumber1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone Number 1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 160);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(775, 278);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phone Number 2";
            // 
            // txt_tagNumber2
            // 
            this.txt_tagNumber2.Location = new System.Drawing.Point(379, 44);
            this.txt_tagNumber2.Name = "txt_tagNumber2";
            this.txt_tagNumber2.Size = new System.Drawing.Size(100, 23);
            this.txt_tagNumber2.TabIndex = 9;
            this.txt_tagNumber2.Text = "PhoneNumber2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone Call Notify";
            // 
            // txt_callEvent
            // 
            this.txt_callEvent.Location = new System.Drawing.Point(379, 102);
            this.txt_callEvent.Name = "txt_callEvent";
            this.txt_callEvent.Size = new System.Drawing.Size(100, 23);
            this.txt_callEvent.TabIndex = 13;
            this.txt_callEvent.Text = "CallEvent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone Call Trigger";
            // 
            // txt_callTrigger
            // 
            this.txt_callTrigger.Location = new System.Drawing.Point(379, 73);
            this.txt_callTrigger.Name = "txt_callTrigger";
            this.txt_callTrigger.Size = new System.Drawing.Size(100, 23);
            this.txt_callTrigger.TabIndex = 11;
            this.txt_callTrigger.Text = "CallTrigger";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Phone Call Filter";
            // 
            // txt_callFilter
            // 
            this.txt_callFilter.Location = new System.Drawing.Point(379, 131);
            this.txt_callFilter.Name = "txt_callFilter";
            this.txt_callFilter.Size = new System.Drawing.Size(100, 23);
            this.txt_callFilter.TabIndex = 15;
            this.txt_callFilter.Text = "CallFilter";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(33, 23);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "1000";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Interval (ms)";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(493, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "PBX Server URL:";
            // 
            // txt_PBX_URL
            // 
            this.txt_PBX_URL.Location = new System.Drawing.Point(596, 15);
            this.txt_PBX_URL.Name = "txt_PBX_URL";
            this.txt_PBX_URL.Size = new System.Drawing.Size(192, 23);
            this.txt_PBX_URL.TabIndex = 20;
            this.txt_PBX_URL.Text = "https://10.1.1.181/json/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_PBX_URL);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_callFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_callEvent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_callTrigger);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tagNumber2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tagNumber1);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Allen Bradley read/write tool by duongle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox txt_IP;
        private TextBox txt_Path;
        private TextBox txt_tagNumber1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox txt_tagNumber2;
        private Label label5;
        private TextBox txt_callEvent;
        private Label label6;
        private TextBox txt_callTrigger;
        private Label label7;
        private TextBox txt_callFilter;
        private TextBox textBox2;
        private Label label8;
        private System.Windows.Forms.Timer timer1;
        private Button button2;
        private Label label9;
        private TextBox txt_PBX_URL;
        private System.Windows.Forms.Timer timer2;
    }
}