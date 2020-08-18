namespace TempWorker
{
    partial class FormTest
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
            this.LB_temp = new System.Windows.Forms.Label();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_continu = new Sunny.UI.UISwitch();
            this.TB_Timer = new System.Windows.Forms.TextBox();
            this.uiGroupBox3 = new Sunny.UI.UIGroupBox();
            this.CB_port = new Sunny.UI.UIComboBox();
            this.textBoxReceive = new Sunny.UI.UITextBox();
            this.uiLine3 = new Sunny.UI.UILine();
            this.Btn_close = new Sunny.UI.UISymbolButton();
            this.Btn_open = new Sunny.UI.UISymbolButton();
            this.uiGroupBox4 = new Sunny.UI.UIGroupBox();
            this.LB_wet = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LED_red = new Sunny.UI.UILedBulb();
            this.uiGroupBox5 = new Sunny.UI.UIGroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_wetlimit = new System.Windows.Forms.TextBox();
            this.TB_tmplimit = new System.Windows.Forms.TextBox();
            this.LED_green = new Sunny.UI.UILedBulb();
            this.label2 = new System.Windows.Forms.Label();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxSendData = new System.Windows.Forms.GroupBox();
            this.TB_Send1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_Send2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_Send5 = new System.Windows.Forms.TextBox();
            this.TB_Send4 = new System.Windows.Forms.TextBox();
            this.TB_Send3 = new System.Windows.Forms.TextBox();
            this.Btn_send = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Btn_word = new Sunny.UI.UIButton();
            this.uiGroupBox2.SuspendLayout();
            this.uiGroupBox3.SuspendLayout();
            this.uiGroupBox4.SuspendLayout();
            this.uiGroupBox5.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.groupBoxSendData.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_temp
            // 
            this.LB_temp.AutoSize = true;
            this.LB_temp.Font = new System.Drawing.Font("Brush Stroke 26", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_temp.Location = new System.Drawing.Point(24, 43);
            this.LB_temp.Name = "LB_temp";
            this.LB_temp.Size = new System.Drawing.Size(63, 77);
            this.LB_temp.TabIndex = 9;
            this.LB_temp.Text = "0";
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.uiLabel1);
            this.uiGroupBox2.Controls.Add(this.label1);
            this.uiGroupBox2.Controls.Add(this.Btn_continu);
            this.uiGroupBox2.Controls.Add(this.TB_Timer);
            this.uiGroupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(1073, 254);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Radius = 20;
            this.uiGroupBox2.Size = new System.Drawing.Size(286, 65);
            this.uiGroupBox2.TabIndex = 47;
            this.uiGroupBox2.Text = "連續傳送";
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLabel1.Font = new System.Drawing.Font("超世紀中顏楷", 20F);
            this.uiLabel1.Location = new System.Drawing.Point(91, 30);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(66, 27);
            this.uiLabel1.TabIndex = 18;
            this.uiLabel1.Text = "延遲";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(238, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "毫秒";
            // 
            // Btn_continu
            // 
            this.Btn_continu.Active = true;
            this.Btn_continu.ActiveText = "On";
            this.Btn_continu.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Btn_continu.InActiveText = "Off";
            this.Btn_continu.Location = new System.Drawing.Point(7, 28);
            this.Btn_continu.Name = "Btn_continu";
            this.Btn_continu.Size = new System.Drawing.Size(75, 29);
            this.Btn_continu.TabIndex = 46;
            this.Btn_continu.Text = "uiSwitch1";
            // 
            // TB_Timer
            // 
            this.TB_Timer.Font = new System.Drawing.Font("新細明體", 12F);
            this.TB_Timer.Location = new System.Drawing.Point(158, 30);
            this.TB_Timer.Name = "TB_Timer";
            this.TB_Timer.Size = new System.Drawing.Size(75, 27);
            this.TB_Timer.TabIndex = 0;
            this.TB_Timer.Text = "500";
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.CB_port);
            this.uiGroupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiGroupBox3.Location = new System.Drawing.Point(15, 22);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox3.Radius = 20;
            this.uiGroupBox3.Size = new System.Drawing.Size(114, 328);
            this.uiGroupBox3.TabIndex = 49;
            this.uiGroupBox3.Text = "設定";
            // 
            // CB_port
            // 
            this.CB_port.FillColor = System.Drawing.Color.White;
            this.CB_port.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.CB_port.Location = new System.Drawing.Point(7, 37);
            this.CB_port.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CB_port.MinimumSize = new System.Drawing.Size(63, 0);
            this.CB_port.Name = "CB_port";
            this.CB_port.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.CB_port.Size = new System.Drawing.Size(99, 29);
            this.CB_port.TabIndex = 45;
            this.CB_port.Text = "COM";
            this.CB_port.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxReceive
            // 
            this.textBoxReceive.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxReceive.FillColor = System.Drawing.Color.White;
            this.textBoxReceive.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxReceive.Location = new System.Drawing.Point(981, 332);
            this.textBoxReceive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxReceive.Maximum = 2147483647D;
            this.textBoxReceive.Minimum = -2147483648D;
            this.textBoxReceive.Multiline = true;
            this.textBoxReceive.Name = "textBoxReceive";
            this.textBoxReceive.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxReceive.Size = new System.Drawing.Size(368, 132);
            this.textBoxReceive.TabIndex = 54;
            this.textBoxReceive.Watermark = "水印文字";
            // 
            // uiLine3
            // 
            this.uiLine3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine3.Location = new System.Drawing.Point(166, 238);
            this.uiLine3.MinimumSize = new System.Drawing.Size(16, 16);
            this.uiLine3.Name = "uiLine3";
            this.uiLine3.Size = new System.Drawing.Size(547, 20);
            this.uiLine3.TabIndex = 53;
            this.uiLine3.Text = "資料傳收";
            this.uiLine3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_close
            // 
            this.Btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_close.Enabled = false;
            this.Btn_close.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Btn_close.Location = new System.Drawing.Point(183, 336);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.Btn_close.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.Btn_close.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Btn_close.Size = new System.Drawing.Size(73, 54);
            this.Btn_close.Symbol = 61516;
            this.Btn_close.TabIndex = 52;
            // 
            // Btn_open
            // 
            this.Btn_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_open.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Btn_open.Location = new System.Drawing.Point(183, 276);
            this.Btn_open.Name = "Btn_open";
            this.Btn_open.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.Btn_open.RadiusSides = ((Sunny.UI.UICornerRadiusSides)((Sunny.UI.UICornerRadiusSides.LeftTop | Sunny.UI.UICornerRadiusSides.LeftBottom)));
            this.Btn_open.Size = new System.Drawing.Size(73, 54);
            this.Btn_open.Symbol = 61515;
            this.Btn_open.TabIndex = 51;
            this.Btn_open.Click += new System.EventHandler(this.Btn_open_Click);
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.Controls.Add(this.LB_wet);
            this.uiGroupBox4.Controls.Add(this.label5);
            this.uiGroupBox4.Font = new System.Drawing.Font("Microsoft YaHei", 18F);
            this.uiGroupBox4.Location = new System.Drawing.Point(410, 71);
            this.uiGroupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox4.Radius = 20;
            this.uiGroupBox4.Size = new System.Drawing.Size(199, 139);
            this.uiGroupBox4.TabIndex = 48;
            this.uiGroupBox4.Text = "濕度";
            // 
            // LB_wet
            // 
            this.LB_wet.AutoSize = true;
            this.LB_wet.Font = new System.Drawing.Font("Brush Stroke 26", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_wet.Location = new System.Drawing.Point(24, 43);
            this.LB_wet.Name = "LB_wet";
            this.LB_wet.Size = new System.Drawing.Size(63, 77);
            this.LB_wet.TabIndex = 9;
            this.LB_wet.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 50F);
            this.label5.Location = new System.Drawing.Point(93, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 67);
            this.label5.TabIndex = 5;
            this.label5.Text = "°C";
            // 
            // LED_red
            // 
            this.LED_red.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LED_red.Location = new System.Drawing.Point(226, 31);
            this.LED_red.Name = "LED_red";
            this.LED_red.On = false;
            this.LED_red.Size = new System.Drawing.Size(32, 32);
            this.LED_red.TabIndex = 55;
            this.LED_red.Text = "uiLedBulb2";
            // 
            // uiGroupBox5
            // 
            this.uiGroupBox5.Controls.Add(this.label12);
            this.uiGroupBox5.Controls.Add(this.label6);
            this.uiGroupBox5.Controls.Add(this.TB_wetlimit);
            this.uiGroupBox5.Controls.Add(this.TB_tmplimit);
            this.uiGroupBox5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiGroupBox5.Location = new System.Drawing.Point(381, 251);
            this.uiGroupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox5.Name = "uiGroupBox5";
            this.uiGroupBox5.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox5.Radius = 20;
            this.uiGroupBox5.Size = new System.Drawing.Size(239, 79);
            this.uiGroupBox5.TabIndex = 50;
            this.uiGroupBox5.Text = "警告值設定";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(117, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 21);
            this.label12.TabIndex = 44;
            this.label12.Text = "濕度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 21);
            this.label6.TabIndex = 43;
            this.label6.Text = "溫度";
            // 
            // TB_wetlimit
            // 
            this.TB_wetlimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.TB_wetlimit.Font = new System.Drawing.Font("Microsoft YaHei", 16F);
            this.TB_wetlimit.Location = new System.Drawing.Point(169, 31);
            this.TB_wetlimit.Name = "TB_wetlimit";
            this.TB_wetlimit.Size = new System.Drawing.Size(59, 36);
            this.TB_wetlimit.TabIndex = 1;
            this.TB_wetlimit.Text = "76";
            this.TB_wetlimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_tmplimit
            // 
            this.TB_tmplimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.TB_tmplimit.Font = new System.Drawing.Font("Microsoft YaHei", 16F);
            this.TB_tmplimit.Location = new System.Drawing.Point(49, 31);
            this.TB_tmplimit.Name = "TB_tmplimit";
            this.TB_tmplimit.Size = new System.Drawing.Size(59, 36);
            this.TB_tmplimit.TabIndex = 0;
            this.TB_tmplimit.Text = "30.5";
            this.TB_tmplimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LED_green
            // 
            this.LED_green.Location = new System.Drawing.Point(188, 31);
            this.LED_green.Name = "LED_green";
            this.LED_green.On = false;
            this.LED_green.Size = new System.Drawing.Size(32, 32);
            this.LED_green.TabIndex = 56;
            this.LED_green.Text = "uiLedBulb3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(1092, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Port";
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.LB_temp);
            this.uiGroupBox1.Controls.Add(this.label4);
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 18F);
            this.uiGroupBox1.Location = new System.Drawing.Point(166, 83);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Radius = 20;
            this.uiGroupBox1.Size = new System.Drawing.Size(236, 127);
            this.uiGroupBox1.TabIndex = 46;
            this.uiGroupBox1.Text = "溫度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 50F);
            this.label4.Location = new System.Drawing.Point(93, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 67);
            this.label4.TabIndex = 5;
            this.label4.Text = "°C";
            // 
            // groupBoxSendData
            // 
            this.groupBoxSendData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSendData.Controls.Add(this.TB_Send1);
            this.groupBoxSendData.Controls.Add(this.label11);
            this.groupBoxSendData.Controls.Add(this.label7);
            this.groupBoxSendData.Controls.Add(this.label10);
            this.groupBoxSendData.Controls.Add(this.label8);
            this.groupBoxSendData.Controls.Add(this.TB_Send2);
            this.groupBoxSendData.Controls.Add(this.label9);
            this.groupBoxSendData.Controls.Add(this.TB_Send5);
            this.groupBoxSendData.Controls.Add(this.TB_Send4);
            this.groupBoxSendData.Controls.Add(this.TB_Send3);
            this.groupBoxSendData.Location = new System.Drawing.Point(903, 472);
            this.groupBoxSendData.Name = "groupBoxSendData";
            this.groupBoxSendData.Size = new System.Drawing.Size(496, 105);
            this.groupBoxSendData.TabIndex = 44;
            this.groupBoxSendData.TabStop = false;
            this.groupBoxSendData.Text = "發送數據";
            // 
            // TB_Send1
            // 
            this.TB_Send1.Font = new System.Drawing.Font("新細明體", 12F);
            this.TB_Send1.Location = new System.Drawing.Point(16, 45);
            this.TB_Send1.MaxLength = 2;
            this.TB_Send1.Name = "TB_Send1";
            this.TB_Send1.Size = new System.Drawing.Size(88, 27);
            this.TB_Send1.TabIndex = 15;
            this.TB_Send1.Text = "01";
            this.TB_Send1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 12F);
            this.label11.Location = new System.Drawing.Point(397, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "CRC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F);
            this.label7.Location = new System.Drawing.Point(25, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 12F);
            this.label10.Location = new System.Drawing.Point(304, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Length";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F);
            this.label8.Location = new System.Drawing.Point(120, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Function";
            // 
            // TB_Send2
            // 
            this.TB_Send2.Font = new System.Drawing.Font("新細明體", 12F);
            this.TB_Send2.Location = new System.Drawing.Point(111, 45);
            this.TB_Send2.MaxLength = 2;
            this.TB_Send2.Name = "TB_Send2";
            this.TB_Send2.Size = new System.Drawing.Size(88, 27);
            this.TB_Send2.TabIndex = 16;
            this.TB_Send2.Text = "03";
            this.TB_Send2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 12F);
            this.label9.Location = new System.Drawing.Point(212, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Register";
            // 
            // TB_Send5
            // 
            this.TB_Send5.Enabled = false;
            this.TB_Send5.Font = new System.Drawing.Font("新細明體", 12F);
            this.TB_Send5.Location = new System.Drawing.Point(386, 45);
            this.TB_Send5.MaxLength = 4;
            this.TB_Send5.Name = "TB_Send5";
            this.TB_Send5.Size = new System.Drawing.Size(88, 27);
            this.TB_Send5.TabIndex = 19;
            this.TB_Send5.Text = "C40B";
            this.TB_Send5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_Send4
            // 
            this.TB_Send4.Font = new System.Drawing.Font("新細明體", 12F);
            this.TB_Send4.Location = new System.Drawing.Point(292, 45);
            this.TB_Send4.MaxLength = 4;
            this.TB_Send4.Name = "TB_Send4";
            this.TB_Send4.Size = new System.Drawing.Size(88, 27);
            this.TB_Send4.TabIndex = 18;
            this.TB_Send4.Text = "0002";
            this.TB_Send4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_Send3
            // 
            this.TB_Send3.Font = new System.Drawing.Font("新細明體", 12F);
            this.TB_Send3.Location = new System.Drawing.Point(198, 45);
            this.TB_Send3.MaxLength = 4;
            this.TB_Send3.Name = "TB_Send3";
            this.TB_Send3.Size = new System.Drawing.Size(88, 27);
            this.TB_Send3.TabIndex = 17;
            this.TB_Send3.Text = "0000";
            this.TB_Send3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_send
            // 
            this.Btn_send.Location = new System.Drawing.Point(311, 347);
            this.Btn_send.Name = "Btn_send";
            this.Btn_send.Size = new System.Drawing.Size(164, 40);
            this.Btn_send.TabIndex = 42;
            this.Btn_send.Text = "發送";
            this.Btn_send.UseVisualStyleBackColor = true;
            this.Btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // Btn_word
            // 
            this.Btn_word.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_word.FillColor = System.Drawing.Color.White;
            this.Btn_word.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Btn_word.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Btn_word.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Btn_word.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.Btn_word.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.Btn_word.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.Btn_word.Location = new System.Drawing.Point(256, 276);
            this.Btn_word.Name = "Btn_word";
            this.Btn_word.Radius = 50;
            this.Btn_word.RadiusSides = ((Sunny.UI.UICornerRadiusSides)((Sunny.UI.UICornerRadiusSides.RightTop | Sunny.UI.UICornerRadiusSides.RightBottom)));
            this.Btn_word.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.Btn_word.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.Btn_word.Size = new System.Drawing.Size(100, 54);
            this.Btn_word.Style = Sunny.UI.UIStyle.White;
            this.Btn_word.TabIndex = 57;
            this.Btn_word.Text = "開始";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1422, 589);
            this.Controls.Add(this.Btn_word);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox3);
            this.Controls.Add(this.textBoxReceive);
            this.Controls.Add(this.uiLine3);
            this.Controls.Add(this.Btn_close);
            this.Controls.Add(this.Btn_open);
            this.Controls.Add(this.uiGroupBox4);
            this.Controls.Add(this.LED_red);
            this.Controls.Add(this.uiGroupBox5);
            this.Controls.Add(this.LED_green);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.groupBoxSendData);
            this.Controls.Add(this.Btn_send);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            this.uiGroupBox3.ResumeLayout(false);
            this.uiGroupBox4.ResumeLayout(false);
            this.uiGroupBox4.PerformLayout();
            this.uiGroupBox5.ResumeLayout(false);
            this.uiGroupBox5.PerformLayout();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.groupBoxSendData.ResumeLayout(false);
            this.groupBoxSendData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_temp;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UISwitch Btn_continu;
        private System.Windows.Forms.TextBox TB_Timer;
        private Sunny.UI.UIGroupBox uiGroupBox3;
        private Sunny.UI.UIComboBox CB_port;
        private Sunny.UI.UITextBox textBoxReceive;
        private Sunny.UI.UILine uiLine3;
        private Sunny.UI.UISymbolButton Btn_close;
        private Sunny.UI.UISymbolButton Btn_open;
        private Sunny.UI.UIGroupBox uiGroupBox4;
        private System.Windows.Forms.Label LB_wet;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UILedBulb LED_red;
        private Sunny.UI.UIGroupBox uiGroupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_wetlimit;
        private System.Windows.Forms.TextBox TB_tmplimit;
        private Sunny.UI.UILedBulb LED_green;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxSendData;
        private System.Windows.Forms.TextBox TB_Send1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_Send2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_Send5;
        private System.Windows.Forms.TextBox TB_Send4;
        private System.Windows.Forms.TextBox TB_Send3;
        private System.Windows.Forms.Button Btn_send;
        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UIButton Btn_word;
    }
}