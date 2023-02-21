namespace PBX_PLC
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PLC_IP = new System.Windows.Forms.TextBox();
            this.txt_PLC_path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PLC_Number1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PLC_Number2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PLC_trigger = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_PLC_Event = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_PLC_Filter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Call_State = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_number_being_called = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_PBX_URL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_cycle = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Interval = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_PLC_status = new System.Windows.Forms.TextBox();
            this.txt_PBX_status = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Filter_value = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Event_value = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_Trigger_value = new System.Windows.Forms.TextBox();
            this.txt_Number1_value = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_Number2_value = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_Extension = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_PBX_call_info = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLC IP";
            // 
            // txt_PLC_IP
            // 
            this.txt_PLC_IP.Location = new System.Drawing.Point(117, 19);
            this.txt_PLC_IP.Name = "txt_PLC_IP";
            this.txt_PLC_IP.Size = new System.Drawing.Size(100, 20);
            this.txt_PLC_IP.TabIndex = 1;
            this.txt_PLC_IP.Text = "10.1.1.122";
            // 
            // txt_PLC_path
            // 
            this.txt_PLC_path.Location = new System.Drawing.Point(117, 45);
            this.txt_PLC_path.Name = "txt_PLC_path";
            this.txt_PLC_path.Size = new System.Drawing.Size(100, 20);
            this.txt_PLC_path.TabIndex = 3;
            this.txt_PLC_path.Text = "1, 6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PLC Path";
            // 
            // txt_PLC_Number1
            // 
            this.txt_PLC_Number1.Location = new System.Drawing.Point(117, 71);
            this.txt_PLC_Number1.Name = "txt_PLC_Number1";
            this.txt_PLC_Number1.Size = new System.Drawing.Size(100, 20);
            this.txt_PLC_Number1.TabIndex = 5;
            this.txt_PLC_Number1.Text = "PhoneNumber1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone Number 1";
            // 
            // txt_PLC_Number2
            // 
            this.txt_PLC_Number2.Location = new System.Drawing.Point(117, 97);
            this.txt_PLC_Number2.Name = "txt_PLC_Number2";
            this.txt_PLC_Number2.Size = new System.Drawing.Size(100, 20);
            this.txt_PLC_Number2.TabIndex = 7;
            this.txt_PLC_Number2.Text = "PhoneNumber2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone Number 2";
            // 
            // txt_PLC_trigger
            // 
            this.txt_PLC_trigger.Location = new System.Drawing.Point(117, 123);
            this.txt_PLC_trigger.Name = "txt_PLC_trigger";
            this.txt_PLC_trigger.Size = new System.Drawing.Size(100, 20);
            this.txt_PLC_trigger.TabIndex = 9;
            this.txt_PLC_trigger.Text = "CallTrigger";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone Call Trigger";
            // 
            // txt_PLC_Event
            // 
            this.txt_PLC_Event.Location = new System.Drawing.Point(117, 149);
            this.txt_PLC_Event.Name = "txt_PLC_Event";
            this.txt_PLC_Event.Size = new System.Drawing.Size(100, 20);
            this.txt_PLC_Event.TabIndex = 11;
            this.txt_PLC_Event.Text = "CallEvent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone Call Event";
            // 
            // txt_PLC_Filter
            // 
            this.txt_PLC_Filter.Location = new System.Drawing.Point(117, 175);
            this.txt_PLC_Filter.Name = "txt_PLC_Filter";
            this.txt_PLC_Filter.Size = new System.Drawing.Size(100, 20);
            this.txt_PLC_Filter.TabIndex = 13;
            this.txt_PLC_Filter.Text = "CallFilter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Phone Call Filter";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Call_State);
            this.groupBox1.Controls.Add(this.txt_PLC_IP);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txt_PLC_Filter);
            this.groupBox1.Controls.Add(this.txt_number_being_called);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_PLC_Event);
            this.groupBox1.Controls.Add(this.txt_PLC_path);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_PLC_trigger);
            this.groupBox1.Controls.Add(this.txt_PLC_Number1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_PLC_Number2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 257);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PLC Settings";
            // 
            // txt_Call_State
            // 
            this.txt_Call_State.Location = new System.Drawing.Point(117, 227);
            this.txt_Call_State.Name = "txt_Call_State";
            this.txt_Call_State.Size = new System.Drawing.Size(100, 20);
            this.txt_Call_State.TabIndex = 37;
            this.txt_Call_State.Text = "CallState";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 230);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 36;
            this.label19.Text = "Call state";
            // 
            // txt_number_being_called
            // 
            this.txt_number_being_called.Location = new System.Drawing.Point(117, 201);
            this.txt_number_being_called.Name = "txt_number_being_called";
            this.txt_number_being_called.Size = new System.Drawing.Size(100, 20);
            this.txt_number_being_called.TabIndex = 35;
            this.txt_number_being_called.Text = "BeingCalled";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Number Being Called";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_PBX_URL);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(15, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 60);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PBX Settings";
            // 
            // txt_PBX_URL
            // 
            this.txt_PBX_URL.Location = new System.Drawing.Point(118, 21);
            this.txt_PBX_URL.Name = "txt_PBX_URL";
            this.txt_PBX_URL.Size = new System.Drawing.Size(100, 20);
            this.txt_PBX_URL.TabIndex = 15;
            this.txt_PBX_URL.Text = "https://10.1.1.181/json";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "PBX API URL";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_cycle);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txt_Interval);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(15, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 88);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Timer settings";
            // 
            // lbl_cycle
            // 
            this.lbl_cycle.AutoSize = true;
            this.lbl_cycle.Location = new System.Drawing.Point(89, 61);
            this.lbl_cycle.Name = "lbl_cycle";
            this.lbl_cycle.Size = new System.Drawing.Size(39, 13);
            this.lbl_cycle.TabIndex = 18;
            this.lbl_cycle.Text = "Cycle: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Interval
            // 
            this.txt_Interval.Location = new System.Drawing.Point(118, 21);
            this.txt_Interval.Name = "txt_Interval";
            this.txt_Interval.Size = new System.Drawing.Size(100, 20);
            this.txt_Interval.TabIndex = 15;
            this.txt_Interval.Text = "1000";
            this.txt_Interval.TextChanged += new System.EventHandler(this.txt_Interval_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Interval (ms)";
            // 
            // txt_PLC_status
            // 
            this.txt_PLC_status.Location = new System.Drawing.Point(272, 31);
            this.txt_PLC_status.Multiline = true;
            this.txt_PLC_status.Name = "txt_PLC_status";
            this.txt_PLC_status.Size = new System.Drawing.Size(516, 72);
            this.txt_PLC_status.TabIndex = 17;
            // 
            // txt_PBX_status
            // 
            this.txt_PBX_status.Location = new System.Drawing.Point(272, 228);
            this.txt_PBX_status.Multiline = true;
            this.txt_PBX_status.Name = "txt_PBX_status";
            this.txt_PBX_status.Size = new System.Drawing.Size(516, 121);
            this.txt_PBX_status.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(272, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Status of PLC side";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(272, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Status of PBX side";
            // 
            // txt_Filter_value
            // 
            this.txt_Filter_value.Location = new System.Drawing.Point(387, 164);
            this.txt_Filter_value.Name = "txt_Filter_value";
            this.txt_Filter_value.Size = new System.Drawing.Size(100, 20);
            this.txt_Filter_value.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(275, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Phone Call Filter";
            // 
            // txt_Event_value
            // 
            this.txt_Event_value.Location = new System.Drawing.Point(655, 138);
            this.txt_Event_value.Name = "txt_Event_value";
            this.txt_Event_value.Size = new System.Drawing.Size(100, 20);
            this.txt_Event_value.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(543, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Phone Call Event";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(275, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Phone Number 1";
            // 
            // txt_Trigger_value
            // 
            this.txt_Trigger_value.Location = new System.Drawing.Point(655, 112);
            this.txt_Trigger_value.Name = "txt_Trigger_value";
            this.txt_Trigger_value.Size = new System.Drawing.Size(100, 20);
            this.txt_Trigger_value.TabIndex = 26;
            // 
            // txt_Number1_value
            // 
            this.txt_Number1_value.Location = new System.Drawing.Point(387, 112);
            this.txt_Number1_value.Name = "txt_Number1_value";
            this.txt_Number1_value.Size = new System.Drawing.Size(100, 20);
            this.txt_Number1_value.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(543, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Phone Call Trigger";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(275, 141);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Phone Number 2";
            // 
            // txt_Number2_value
            // 
            this.txt_Number2_value.Location = new System.Drawing.Point(387, 138);
            this.txt_Number2_value.Name = "txt_Number2_value";
            this.txt_Number2_value.Size = new System.Drawing.Size(100, 20);
            this.txt_Number2_value.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(275, 411);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "Extension";
            // 
            // txt_Extension
            // 
            this.txt_Extension.Location = new System.Drawing.Point(387, 408);
            this.txt_Extension.Name = "txt_Extension";
            this.txt_Extension.Size = new System.Drawing.Size(100, 20);
            this.txt_Extension.TabIndex = 32;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_PBX_call_info
            // 
            this.txt_PBX_call_info.Location = new System.Drawing.Point(272, 361);
            this.txt_PBX_call_info.Multiline = true;
            this.txt_PBX_call_info.Name = "txt_PBX_call_info";
            this.txt_PBX_call_info.Size = new System.Drawing.Size(516, 41);
            this.txt_PBX_call_info.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.txt_PBX_call_info);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txt_Extension);
            this.Controls.Add(this.txt_Filter_value);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_Event_value);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_Trigger_value);
            this.Controls.Add(this.txt_Number1_value);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_Number2_value);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_PBX_status);
            this.Controls.Add(this.txt_PLC_status);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "PBX/PLC linker app";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_PLC_IP;
        private System.Windows.Forms.TextBox txt_PLC_path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PLC_Number1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_PLC_Number2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_PLC_trigger;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_PLC_Event;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_PLC_Filter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_PBX_URL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_cycle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Interval;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_PLC_status;
        private System.Windows.Forms.TextBox txt_PBX_status;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Filter_value;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Event_value;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_Trigger_value;
        private System.Windows.Forms.TextBox txt_Number1_value;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_Number2_value;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_Extension;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_PBX_call_info;
        private System.Windows.Forms.TextBox txt_number_being_called;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Call_State;
        private System.Windows.Forms.Label label19;
    }
}

