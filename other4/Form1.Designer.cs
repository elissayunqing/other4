namespace other4
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connectType_cbb = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ASCII_rbtn = new System.Windows.Forms.RadioButton();
            this.RTU_rbtn = new System.Windows.Forms.RadioButton();
            this.serialRTS_chb = new System.Windows.Forms.CheckBox();
            this.serialCTS_chb = new System.Windows.Forms.CheckBox();
            this.serialDSR_chb = new System.Windows.Forms.CheckBox();
            this.serialStopbit_cbb = new System.Windows.Forms.ComboBox();
            this.serialParity_cbb = new System.Windows.Forms.ComboBox();
            this.serialDatabit_cbb = new System.Windows.Forms.ComboBox();
            this.serialBaud_cbb = new System.Windows.Forms.ComboBox();
            this.serialPort_cbb = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.connect_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_SlaveAdress = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connectType_cbb);
            this.groupBox1.Location = new System.Drawing.Point(179, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 50);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接类型";
            // 
            // connectType_cbb
            // 
            this.connectType_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.connectType_cbb.FormattingEnabled = true;
            this.connectType_cbb.Location = new System.Drawing.Point(0, 20);
            this.connectType_cbb.Name = "connectType_cbb";
            this.connectType_cbb.Size = new System.Drawing.Size(246, 20);
            this.connectType_cbb.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ASCII_rbtn);
            this.groupBox2.Controls.Add(this.RTU_rbtn);
            this.groupBox2.Controls.Add(this.serialRTS_chb);
            this.groupBox2.Controls.Add(this.serialCTS_chb);
            this.groupBox2.Controls.Add(this.serialDSR_chb);
            this.groupBox2.Controls.Add(this.serialStopbit_cbb);
            this.groupBox2.Controls.Add(this.serialParity_cbb);
            this.groupBox2.Controls.Add(this.serialDatabit_cbb);
            this.groupBox2.Controls.Add(this.serialBaud_cbb);
            this.groupBox2.Controls.Add(this.serialPort_cbb);
            this.groupBox2.Location = new System.Drawing.Point(182, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 199);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "串口配置";
            // 
            // ASCII_rbtn
            // 
            this.ASCII_rbtn.AutoSize = true;
            this.ASCII_rbtn.Location = new System.Drawing.Point(185, 183);
            this.ASCII_rbtn.Name = "ASCII_rbtn";
            this.ASCII_rbtn.Size = new System.Drawing.Size(53, 16);
            this.ASCII_rbtn.TabIndex = 9;
            this.ASCII_rbtn.TabStop = true;
            this.ASCII_rbtn.Text = "ASCII";
            this.ASCII_rbtn.UseVisualStyleBackColor = true;
            // 
            // RTU_rbtn
            // 
            this.RTU_rbtn.AutoSize = true;
            this.RTU_rbtn.Checked = true;
            this.RTU_rbtn.Location = new System.Drawing.Point(137, 183);
            this.RTU_rbtn.Name = "RTU_rbtn";
            this.RTU_rbtn.Size = new System.Drawing.Size(41, 16);
            this.RTU_rbtn.TabIndex = 8;
            this.RTU_rbtn.TabStop = true;
            this.RTU_rbtn.Text = "RTU";
            this.RTU_rbtn.UseVisualStyleBackColor = true;
            // 
            // serialRTS_chb
            // 
            this.serialRTS_chb.AutoSize = true;
            this.serialRTS_chb.Location = new System.Drawing.Point(137, 103);
            this.serialRTS_chb.Name = "serialRTS_chb";
            this.serialRTS_chb.Size = new System.Drawing.Size(42, 16);
            this.serialRTS_chb.TabIndex = 7;
            this.serialRTS_chb.Text = "RTS";
            this.serialRTS_chb.UseVisualStyleBackColor = true;
            // 
            // serialCTS_chb
            // 
            this.serialCTS_chb.AutoSize = true;
            this.serialCTS_chb.Location = new System.Drawing.Point(185, 67);
            this.serialCTS_chb.Name = "serialCTS_chb";
            this.serialCTS_chb.Size = new System.Drawing.Size(42, 16);
            this.serialCTS_chb.TabIndex = 6;
            this.serialCTS_chb.Text = "CTS";
            this.serialCTS_chb.UseVisualStyleBackColor = true;
            // 
            // serialDSR_chb
            // 
            this.serialDSR_chb.AutoSize = true;
            this.serialDSR_chb.Location = new System.Drawing.Point(137, 67);
            this.serialDSR_chb.Name = "serialDSR_chb";
            this.serialDSR_chb.Size = new System.Drawing.Size(42, 16);
            this.serialDSR_chb.TabIndex = 5;
            this.serialDSR_chb.Text = "DSR";
            this.serialDSR_chb.UseVisualStyleBackColor = true;
            // 
            // serialStopbit_cbb
            // 
            this.serialStopbit_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialStopbit_cbb.FormattingEnabled = true;
            this.serialStopbit_cbb.Location = new System.Drawing.Point(0, 179);
            this.serialStopbit_cbb.Name = "serialStopbit_cbb";
            this.serialStopbit_cbb.Size = new System.Drawing.Size(112, 20);
            this.serialStopbit_cbb.TabIndex = 4;
            // 
            // serialParity_cbb
            // 
            this.serialParity_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialParity_cbb.FormattingEnabled = true;
            this.serialParity_cbb.Location = new System.Drawing.Point(0, 143);
            this.serialParity_cbb.Name = "serialParity_cbb";
            this.serialParity_cbb.Size = new System.Drawing.Size(112, 20);
            this.serialParity_cbb.TabIndex = 3;
            // 
            // serialDatabit_cbb
            // 
            this.serialDatabit_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialDatabit_cbb.FormattingEnabled = true;
            this.serialDatabit_cbb.Location = new System.Drawing.Point(0, 101);
            this.serialDatabit_cbb.Name = "serialDatabit_cbb";
            this.serialDatabit_cbb.Size = new System.Drawing.Size(112, 20);
            this.serialDatabit_cbb.TabIndex = 2;
            // 
            // serialBaud_cbb
            // 
            this.serialBaud_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialBaud_cbb.FormattingEnabled = true;
            this.serialBaud_cbb.Location = new System.Drawing.Point(0, 63);
            this.serialBaud_cbb.Name = "serialBaud_cbb";
            this.serialBaud_cbb.Size = new System.Drawing.Size(112, 20);
            this.serialBaud_cbb.TabIndex = 1;
            // 
            // serialPort_cbb
            // 
            this.serialPort_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialPort_cbb.FormattingEnabled = true;
            this.serialPort_cbb.Location = new System.Drawing.Point(0, 20);
            this.serialPort_cbb.Name = "serialPort_cbb";
            this.serialPort_cbb.Size = new System.Drawing.Size(243, 20);
            this.serialPort_cbb.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(454, 85);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(307, 87);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(179, 360);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(112, 52);
            this.connect_btn.TabIndex = 6;
            this.connect_btn.Text = "连接";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(449, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "低位设置(mm):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(505, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "积分时间(s):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(496, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "量程设置(m):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(479, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "距离偏量(mm):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(479, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "盲区范围(mm):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(507, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "信噪比阈值:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(479, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "高位设置(mm):";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(626, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(626, 233);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(626, 275);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 29);
            this.textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(626, 315);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 29);
            this.textBox4.TabIndex = 21;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox5.Location = new System.Drawing.Point(626, 360);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 29);
            this.textBox5.TabIndex = 22;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox6.Location = new System.Drawing.Point(626, 404);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 29);
            this.textBox6.TabIndex = 23;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox7.Location = new System.Drawing.Point(626, 449);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 29);
            this.textBox7.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 52);
            this.button1.TabIndex = 25;
            this.button1.Text = "读取";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(767, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 40);
            this.label1.TabIndex = 26;
            this.label1.Text = "空高:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(767, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 40);
            this.label2.TabIndex = 27;
            this.label2.Text = "水位:";
            // 
            // TB_SlaveAdress
            // 
            this.TB_SlaveAdress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_SlaveAdress.Location = new System.Drawing.Point(182, 427);
            this.TB_SlaveAdress.Name = "TB_SlaveAdress";
            this.TB_SlaveAdress.Size = new System.Drawing.Size(32, 23);
            this.TB_SlaveAdress.TabIndex = 28;
            this.TB_SlaveAdress.Text = "1";
            this.TB_SlaveAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(481, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 28);
            this.label4.TabIndex = 29;
            this.label4.Text = "label4";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(523, 547);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 63);
            this.button2.TabIndex = 30;
            this.button2.Text = "开始计时写入数据库";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox8.Location = new System.Drawing.Point(408, 559);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 33);
            this.textBox8.TabIndex = 31;
            this.textBox8.Text = "100";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(175, 564);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(227, 24);
            this.label11.TabIndex = 32;
            this.label11.Text = "时间间隔(MS)默认100毫秒";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(834, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 25);
            this.label12.TabIndex = 33;
            this.label12.Text = "温度:";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox9.Location = new System.Drawing.Point(895, 334);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 29);
            this.textBox9.TabIndex = 34;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1013, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 63);
            this.button3.TabIndex = 35;
            this.button3.Text = "定时读取";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox10.Location = new System.Drawing.Point(895, 190);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 33);
            this.textBox10.TabIndex = 36;
            this.textBox10.Text = "100";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(839, 413);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 65);
            this.button4.TabIndex = 37;
            this.button4.Text = "test";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 616);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_SlaveAdress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox connectType_cbb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ASCII_rbtn;
        private System.Windows.Forms.RadioButton RTU_rbtn;
        private System.Windows.Forms.CheckBox serialRTS_chb;
        private System.Windows.Forms.CheckBox serialCTS_chb;
        private System.Windows.Forms.CheckBox serialDSR_chb;
        private System.Windows.Forms.ComboBox serialStopbit_cbb;
        private System.Windows.Forms.ComboBox serialParity_cbb;
        private System.Windows.Forms.ComboBox serialDatabit_cbb;
        private System.Windows.Forms.ComboBox serialBaud_cbb;
        private System.Windows.Forms.ComboBox serialPort_cbb;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_SlaveAdress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button4;
    }
}

