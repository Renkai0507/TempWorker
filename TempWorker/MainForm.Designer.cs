namespace TempWorker
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CB_port = new Sunny.UI.UIComboBox();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.LB_temp = new System.Windows.Forms.Label();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.Btn_continu = new Sunny.UI.UISwitch();
            this.TB_Timer = new System.Windows.Forms.TextBox();
            this.Btn_close = new Sunny.UI.UISymbolButton();
            this.Btn_open = new Sunny.UI.UISymbolButton();
            this.textBoxReceive = new Sunny.UI.UITextBox();
            this.SW_SaveData = new Sunny.UI.UIGroupBox();
            this.uiSwitch1 = new Sunny.UI.UISwitch();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_tmplimit = new System.Windows.Forms.TextBox();
            this.LED_red = new Sunny.UI.UILedBulb();
            this.uiGroupBox4 = new Sunny.UI.UIGroupBox();
            this.LB_wet = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LED_green = new Sunny.UI.UILedBulb();
            this.uiGroupBox5 = new Sunny.UI.UIGroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_wetlimit = new System.Windows.Forms.TextBox();
            this.uiGroupBox3 = new Sunny.UI.UIGroupBox();
            this.uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.uiTabControl2 = new Sunny.UI.UITabControl();
            this.tabchart = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.testtext = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtp_table = new Sunny.UI.UIDatePicker();
            this.tabDataoutput = new System.Windows.Forms.TabPage();
            this.uiImageButton1 = new Sunny.UI.UIImageButton();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.dtp_Date = new Sunny.UI.UIDatePicker();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.Column_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Wet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDataView = new System.Windows.Forms.TabPage();
            this.uiGroupBox6 = new Sunny.UI.UIGroupBox();
            this.Btn_send = new Sunny.UI.UIButton();
            this.tabSet = new System.Windows.Forms.TabPage();
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.Userdata = new System.Windows.Forms.TabPage();
            this.Admindata = new System.Windows.Forms.TabPage();
            this.groupBoxSendData.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.SW_SaveData.SuspendLayout();
            this.uiGroupBox4.SuspendLayout();
            this.uiGroupBox5.SuspendLayout();
            this.uiGroupBox3.SuspendLayout();
            this.uiTabControlMenu1.SuspendLayout();
            this.tabReport.SuspendLayout();
            this.uiTabControl2.SuspendLayout();
            this.tabchart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabDataoutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            this.tabDataView.SuspendLayout();
            this.uiGroupBox6.SuspendLayout();
            this.tabSet.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.Userdata.SuspendLayout();
            this.Admindata.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(238, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "秒";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("新細明體", 36F);
            this.label4.Location = new System.Drawing.Point(218, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 48);
            this.label4.TabIndex = 5;
            this.label4.Text = "°C";
            // 
            // groupBoxSendData
            // 
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
            this.groupBoxSendData.Location = new System.Drawing.Point(28, 150);
            this.groupBoxSendData.Name = "groupBoxSendData";
            this.groupBoxSendData.Size = new System.Drawing.Size(496, 109);
            this.groupBoxSendData.TabIndex = 13;
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CB_port
            // 
            this.CB_port.FillColor = System.Drawing.Color.White;
            this.CB_port.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.CB_port.Location = new System.Drawing.Point(6, 57);
            this.CB_port.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CB_port.MinimumSize = new System.Drawing.Size(63, 0);
            this.CB_port.Name = "CB_port";
            this.CB_port.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.CB_port.Size = new System.Drawing.Size(121, 29);
            this.CB_port.TabIndex = 16;
            this.CB_port.Text = "COM";
            this.CB_port.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.label4);
            this.uiGroupBox1.Controls.Add(this.LB_temp);
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 18F);
            this.uiGroupBox1.Location = new System.Drawing.Point(13, 22);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Radius = 20;
            this.uiGroupBox1.Size = new System.Drawing.Size(293, 145);
            this.uiGroupBox1.TabIndex = 16;
            this.uiGroupBox1.Text = null;
            // 
            // LB_temp
            // 
            this.LB_temp.AutoSize = true;
            this.LB_temp.Font = new System.Drawing.Font("Brush Stroke 26", 60F);
            this.LB_temp.Location = new System.Drawing.Point(46, 29);
            this.LB_temp.Name = "LB_temp";
            this.LB_temp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_temp.Size = new System.Drawing.Size(134, 96);
            this.LB_temp.TabIndex = 9;
            this.LB_temp.Text = "   0";
            this.LB_temp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LB_temp.TextChanged += new System.EventHandler(this.Temp_TextChanged);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.uiLabel1);
            this.uiGroupBox2.Controls.Add(this.label1);
            this.uiGroupBox2.Controls.Add(this.Btn_continu);
            this.uiGroupBox2.Controls.Add(this.TB_Timer);
            this.uiGroupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(30, 27);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Radius = 20;
            this.uiGroupBox2.Size = new System.Drawing.Size(286, 79);
            this.uiGroupBox2.TabIndex = 17;
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
            this.Btn_continu.ValueChanged += new Sunny.UI.UISwitch.OnValueChanged(this.Btn_continu_ValueChanged);
            // 
            // TB_Timer
            // 
            this.TB_Timer.Font = new System.Drawing.Font("新細明體", 12F);
            this.TB_Timer.Location = new System.Drawing.Point(158, 30);
            this.TB_Timer.Name = "TB_Timer";
            this.TB_Timer.Size = new System.Drawing.Size(75, 27);
            this.TB_Timer.TabIndex = 0;
            this.TB_Timer.Text = "5";
            // 
            // Btn_close
            // 
            this.Btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_close.Enabled = false;
            this.Btn_close.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Btn_close.Location = new System.Drawing.Point(118, 249);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.Btn_close.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.Btn_close.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Btn_close.Size = new System.Drawing.Size(73, 54);
            this.Btn_close.Symbol = 61516;
            this.Btn_close.TabIndex = 36;
            this.Btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // Btn_open
            // 
            this.Btn_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_open.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Btn_open.Location = new System.Drawing.Point(45, 249);
            this.Btn_open.Name = "Btn_open";
            this.Btn_open.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.Btn_open.RadiusSides = ((Sunny.UI.UICornerRadiusSides)((Sunny.UI.UICornerRadiusSides.LeftTop | Sunny.UI.UICornerRadiusSides.LeftBottom)));
            this.Btn_open.Size = new System.Drawing.Size(73, 54);
            this.Btn_open.Symbol = 61515;
            this.Btn_open.TabIndex = 35;
            this.Btn_open.Click += new System.EventHandler(this.Btn_open_Click);
            // 
            // textBoxReceive
            // 
            this.textBoxReceive.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxReceive.FillColor = System.Drawing.Color.White;
            this.textBoxReceive.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxReceive.Location = new System.Drawing.Point(474, 429);
            this.textBoxReceive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxReceive.Maximum = 2147483647D;
            this.textBoxReceive.Minimum = -2147483648D;
            this.textBoxReceive.Multiline = true;
            this.textBoxReceive.Name = "textBoxReceive";
            this.textBoxReceive.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxReceive.Size = new System.Drawing.Size(274, 121);
            this.textBoxReceive.TabIndex = 38;
            this.textBoxReceive.Watermark = "水印文字";
            // 
            // SW_SaveData
            // 
            this.SW_SaveData.Controls.Add(this.CB_port);
            this.SW_SaveData.Controls.Add(this.label2);
            this.SW_SaveData.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.SW_SaveData.Location = new System.Drawing.Point(28, 5);
            this.SW_SaveData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SW_SaveData.Name = "SW_SaveData";
            this.SW_SaveData.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.SW_SaveData.Radius = 20;
            this.SW_SaveData.Size = new System.Drawing.Size(152, 114);
            this.SW_SaveData.TabIndex = 18;
            this.SW_SaveData.Text = "設定";
            // 
            // uiSwitch1
            // 
            this.uiSwitch1.Active = true;
            this.uiSwitch1.ActiveText = "On";
            this.uiSwitch1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSwitch1.InActiveText = "Off";
            this.uiSwitch1.Location = new System.Drawing.Point(116, 221);
            this.uiSwitch1.Name = "uiSwitch1";
            this.uiSwitch1.Size = new System.Drawing.Size(75, 29);
            this.uiSwitch1.TabIndex = 47;
            this.uiSwitch1.Text = "uiSwitch1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(38, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "數據儲存";
            // 
            // TB_tmplimit
            // 
            this.TB_tmplimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.TB_tmplimit.Font = new System.Drawing.Font("Microsoft YaHei", 16F);
            this.TB_tmplimit.Location = new System.Drawing.Point(77, 31);
            this.TB_tmplimit.Name = "TB_tmplimit";
            this.TB_tmplimit.Size = new System.Drawing.Size(59, 36);
            this.TB_tmplimit.TabIndex = 0;
            this.TB_tmplimit.Text = "30.5";
            this.TB_tmplimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_tmplimit.TextChanged += new System.EventHandler(this.Temp_TextChanged);
            // 
            // LED_red
            // 
            this.LED_red.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LED_red.Location = new System.Drawing.Point(183, 30);
            this.LED_red.Name = "LED_red";
            this.LED_red.On = false;
            this.LED_red.Size = new System.Drawing.Size(45, 45);
            this.LED_red.TabIndex = 40;
            this.LED_red.Text = "uiLedBulb2";
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.Controls.Add(this.LB_wet);
            this.uiGroupBox4.Controls.Add(this.label5);
            this.uiGroupBox4.Font = new System.Drawing.Font("Microsoft YaHei", 18F);
            this.uiGroupBox4.Location = new System.Drawing.Point(321, 22);
            this.uiGroupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox4.Radius = 20;
            this.uiGroupBox4.Size = new System.Drawing.Size(253, 145);
            this.uiGroupBox4.TabIndex = 17;
            this.uiGroupBox4.Text = null;
            // 
            // LB_wet
            // 
            this.LB_wet.AutoSize = true;
            this.LB_wet.Font = new System.Drawing.Font("Brush Stroke 26", 60F);
            this.LB_wet.Location = new System.Drawing.Point(40, 29);
            this.LB_wet.Name = "LB_wet";
            this.LB_wet.Size = new System.Drawing.Size(134, 96);
            this.LB_wet.TabIndex = 9;
            this.LB_wet.Text = "   0";
            this.LB_wet.TextChanged += new System.EventHandler(this.Wet_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("新細明體", 36F);
            this.label5.Location = new System.Drawing.Point(180, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 48);
            this.label5.TabIndex = 5;
            this.label5.Text = "%";
            // 
            // LED_green
            // 
            this.LED_green.Location = new System.Drawing.Point(46, 30);
            this.LED_green.Name = "LED_green";
            this.LED_green.On = false;
            this.LED_green.Size = new System.Drawing.Size(45, 45);
            this.LED_green.TabIndex = 41;
            this.LED_green.Text = "uiLedBulb3";
            // 
            // uiGroupBox5
            // 
            this.uiGroupBox5.Controls.Add(this.label12);
            this.uiGroupBox5.Controls.Add(this.label6);
            this.uiGroupBox5.Controls.Add(this.TB_wetlimit);
            this.uiGroupBox5.Controls.Add(this.TB_tmplimit);
            this.uiGroupBox5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiGroupBox5.Location = new System.Drawing.Point(30, 115);
            this.uiGroupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox5.Name = "uiGroupBox5";
            this.uiGroupBox5.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox5.Radius = 20;
            this.uiGroupBox5.Size = new System.Drawing.Size(286, 79);
            this.uiGroupBox5.TabIndex = 18;
            this.uiGroupBox5.Text = "警告值設定";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(155, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 21);
            this.label12.TabIndex = 44;
            this.label12.Text = "濕度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 21);
            this.label6.TabIndex = 43;
            this.label6.Text = "溫度";
            // 
            // TB_wetlimit
            // 
            this.TB_wetlimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.TB_wetlimit.Font = new System.Drawing.Font("Microsoft YaHei", 16F);
            this.TB_wetlimit.Location = new System.Drawing.Point(208, 31);
            this.TB_wetlimit.Name = "TB_wetlimit";
            this.TB_wetlimit.Size = new System.Drawing.Size(59, 36);
            this.TB_wetlimit.TabIndex = 1;
            this.TB_wetlimit.Text = "76";
            this.TB_wetlimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_wetlimit.TextChanged += new System.EventHandler(this.Wet_TextChanged);
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.uiGroupBox1);
            this.uiGroupBox3.Controls.Add(this.uiGroupBox4);
            this.uiGroupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiGroupBox3.Location = new System.Drawing.Point(25, 30);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox3.Radius = 20;
            this.uiGroupBox3.Size = new System.Drawing.Size(598, 188);
            this.uiGroupBox3.TabIndex = 45;
            this.uiGroupBox3.Text = "CH1";
            this.uiGroupBox3.DoubleClick += new System.EventHandler(this.uiGroupBox3_DoubleClick);
            // 
            // uiTabControlMenu1
            // 
            this.uiTabControlMenu1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.uiTabControlMenu1.Controls.Add(this.tabReport);
            this.uiTabControlMenu1.Controls.Add(this.tabDataView);
            this.uiTabControlMenu1.Controls.Add(this.tabSet);
            this.uiTabControlMenu1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControlMenu1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTabControlMenu1.ItemSize = new System.Drawing.Size(40, 200);
            this.uiTabControlMenu1.Location = new System.Drawing.Point(1, 1);
            this.uiTabControlMenu1.Multiline = true;
            this.uiTabControlMenu1.Name = "uiTabControlMenu1";
            this.uiTabControlMenu1.SelectedIndex = 0;
            this.uiTabControlMenu1.Size = new System.Drawing.Size(962, 568);
            this.uiTabControlMenu1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControlMenu1.TabIndex = 49;
            this.uiTabControlMenu1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabReport
            // 
            this.tabReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tabReport.Controls.Add(this.uiTabControl2);
            this.tabReport.Location = new System.Drawing.Point(201, 0);
            this.tabReport.Name = "tabReport";
            this.tabReport.Size = new System.Drawing.Size(761, 568);
            this.tabReport.TabIndex = 0;
            this.tabReport.Text = "數據走勢圖";
            // 
            // uiTabControl2
            // 
            this.uiTabControl2.Controls.Add(this.tabchart);
            this.uiTabControl2.Controls.Add(this.tabDataoutput);
            this.uiTabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTabControl2.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl2.Location = new System.Drawing.Point(0, 0);
            this.uiTabControl2.Name = "uiTabControl2";
            this.uiTabControl2.SelectedIndex = 0;
            this.uiTabControl2.Size = new System.Drawing.Size(761, 567);
            this.uiTabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl2.TabIndex = 3;
            // 
            // tabchart
            // 
            this.tabchart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tabchart.Controls.Add(this.chart2);
            this.tabchart.Controls.Add(this.testtext);
            this.tabchart.Controls.Add(this.chart1);
            this.tabchart.Controls.Add(this.dtp_table);
            this.tabchart.Location = new System.Drawing.Point(0, 40);
            this.tabchart.Name = "tabchart";
            this.tabchart.Size = new System.Drawing.Size(761, 527);
            this.tabchart.TabIndex = 0;
            this.tabchart.Text = "圖表";
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(75, 24);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart2.Series.Add(series1);
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(558, 316);
            this.chart2.TabIndex = 4;
            this.chart2.Text = "chart2";
            // 
            // testtext
            // 
            this.testtext.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.testtext.Location = new System.Drawing.Point(477, 387);
            this.testtext.Name = "testtext";
            this.testtext.Size = new System.Drawing.Size(148, 32);
            this.testtext.TabIndex = 3;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.chart1.BorderlineColor = System.Drawing.Color.Maroon;
            chartArea2.AxisX.LabelStyle.Interval = 0D;
            chartArea2.AxisX.MajorGrid.Interval = 0D;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            chartArea2.AxisX.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Yellow;
            chartArea2.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(13, 3);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series3.Legend = "Legend1";
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series3.Name = "溫度";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "濕度";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(745, 376);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "ch1";
            this.chart1.GetToolTipText += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs>(this.chart1_GetToolTipText);
            // 
            // dtp_table
            // 
            this.dtp_table.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.dtp_table.FillColor = System.Drawing.Color.White;
            this.dtp_table.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dtp_table.Location = new System.Drawing.Point(75, 387);
            this.dtp_table.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_table.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtp_table.Name = "dtp_table";
            this.dtp_table.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dtp_table.Size = new System.Drawing.Size(150, 29);
            this.dtp_table.SymbolDropDown = 61555;
            this.dtp_table.SymbolNormal = 61555;
            this.dtp_table.TabIndex = 2;
            this.dtp_table.Text = "2020-07-21";
            this.dtp_table.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtp_table.Value = new System.DateTime(2020, 7, 21, 0, 0, 0, 0);
            this.dtp_table.ValueChanged += new Sunny.UI.UIDatePicker.OnDateTimeChanged(this.dtp_table_ValueChanged);
            // 
            // tabDataoutput
            // 
            this.tabDataoutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tabDataoutput.Controls.Add(this.uiImageButton1);
            this.tabDataoutput.Controls.Add(this.uiComboBox1);
            this.tabDataoutput.Controls.Add(this.dtp_Date);
            this.tabDataoutput.Controls.Add(this.uiDataGridView1);
            this.tabDataoutput.Location = new System.Drawing.Point(0, 40);
            this.tabDataoutput.Name = "tabDataoutput";
            this.tabDataoutput.Size = new System.Drawing.Size(761, 527);
            this.tabDataoutput.TabIndex = 1;
            this.tabDataoutput.Text = "數據";
            // 
            // uiImageButton1
            // 
            this.uiImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("uiImageButton1.Image")));
            this.uiImageButton1.Location = new System.Drawing.Point(395, 3);
            this.uiImageButton1.Name = "uiImageButton1";
            this.uiImageButton1.Size = new System.Drawing.Size(57, 66);
            this.uiImageButton1.TabIndex = 2;
            this.uiImageButton1.TabStop = false;
            this.uiImageButton1.Text = null;
            this.uiImageButton1.Click += new System.EventHandler(this.uiImageButton1_Click);
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiComboBox1.Location = new System.Drawing.Point(220, 20);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uiComboBox1.Size = new System.Drawing.Size(150, 29);
            this.uiComboBox1.TabIndex = 1;
            this.uiComboBox1.Text = "uiComboBox1";
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp_Date
            // 
            this.dtp_Date.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.dtp_Date.FillColor = System.Drawing.Color.White;
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dtp_Date.Location = new System.Drawing.Point(45, 20);
            this.dtp_Date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_Date.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dtp_Date.Size = new System.Drawing.Size(150, 29);
            this.dtp_Date.SymbolDropDown = 61555;
            this.dtp_Date.SymbolNormal = 61555;
            this.dtp_Date.TabIndex = 1;
            this.dtp_Date.Text = "2020-07-24";
            this.dtp_Date.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtp_Date.Value = new System.DateTime(2020, 7, 24, 10, 19, 9, 249);
            // 
            // uiDataGridView1
            // 
            this.uiDataGridView1.AllowUserToAddRows = false;
            this.uiDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView1.ColumnHeadersHeight = 32;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_time,
            this.ColumnTemp,
            this.Column_Wet});
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(20, 75);
            this.uiDataGridView1.Name = "uiDataGridView1";
            this.uiDataGridView1.ReadOnly = true;
            this.uiDataGridView1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridView1.RowTemplate.Height = 29;
            this.uiDataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiDataGridView1.Size = new System.Drawing.Size(738, 449);
            this.uiDataGridView1.Style = Sunny.UI.UIStyle.Custom;
            this.uiDataGridView1.TabIndex = 0;
            this.uiDataGridView1.TagString = null;
            // 
            // Column_time
            // 
            this.Column_time.HeaderText = "紀錄時間";
            this.Column_time.Name = "Column_time";
            this.Column_time.ReadOnly = true;
            // 
            // ColumnTemp
            // 
            this.ColumnTemp.HeaderText = "溫度";
            this.ColumnTemp.Name = "ColumnTemp";
            this.ColumnTemp.ReadOnly = true;
            // 
            // Column_Wet
            // 
            this.Column_Wet.HeaderText = "濕度";
            this.Column_Wet.Name = "Column_Wet";
            this.Column_Wet.ReadOnly = true;
            // 
            // tabDataView
            // 
            this.tabDataView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tabDataView.Controls.Add(this.uiGroupBox6);
            this.tabDataView.Controls.Add(this.Btn_send);
            this.tabDataView.Controls.Add(this.uiGroupBox3);
            this.tabDataView.Controls.Add(this.textBoxReceive);
            this.tabDataView.Controls.Add(this.Btn_close);
            this.tabDataView.Controls.Add(this.Btn_open);
            this.tabDataView.Location = new System.Drawing.Point(201, 0);
            this.tabDataView.Name = "tabDataView";
            this.tabDataView.Size = new System.Drawing.Size(761, 568);
            this.tabDataView.TabIndex = 1;
            this.tabDataView.Text = "監控數據";
            // 
            // uiGroupBox6
            // 
            this.uiGroupBox6.Controls.Add(this.LED_red);
            this.uiGroupBox6.Controls.Add(this.LED_green);
            this.uiGroupBox6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiGroupBox6.Location = new System.Drawing.Point(356, 228);
            this.uiGroupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox6.Name = "uiGroupBox6";
            this.uiGroupBox6.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox6.Radius = 20;
            this.uiGroupBox6.Size = new System.Drawing.Size(267, 86);
            this.uiGroupBox6.TabIndex = 50;
            this.uiGroupBox6.Text = "狀態燈號";
            // 
            // Btn_send
            // 
            this.Btn_send.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Btn_send.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Btn_send.Location = new System.Drawing.Point(283, 492);
            this.Btn_send.Name = "Btn_send";
            this.Btn_send.Size = new System.Drawing.Size(164, 45);
            this.Btn_send.TabIndex = 50;
            this.Btn_send.Text = "手動發送";
            this.Btn_send.UseWaitCursor = true;
            this.Btn_send.Visible = false;
            // 
            // tabSet
            // 
            this.tabSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tabSet.Controls.Add(this.uiTabControl1);
            this.tabSet.Location = new System.Drawing.Point(201, 0);
            this.tabSet.Name = "tabSet";
            this.tabSet.Size = new System.Drawing.Size(761, 568);
            this.tabSet.TabIndex = 2;
            this.tabSet.Text = "設定";
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.Userdata);
            this.uiTabControl1.Controls.Add(this.Admindata);
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(-1, 0);
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(777, 582);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.TabIndex = 0;
            // 
            // Userdata
            // 
            this.Userdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Userdata.Controls.Add(this.uiSwitch1);
            this.Userdata.Controls.Add(this.label3);
            this.Userdata.Controls.Add(this.uiGroupBox2);
            this.Userdata.Controls.Add(this.uiGroupBox5);
            this.Userdata.Location = new System.Drawing.Point(0, 40);
            this.Userdata.Name = "Userdata";
            this.Userdata.Size = new System.Drawing.Size(777, 542);
            this.Userdata.TabIndex = 0;
            this.Userdata.Text = "監控設定";
            // 
            // Admindata
            // 
            this.Admindata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Admindata.Controls.Add(this.groupBoxSendData);
            this.Admindata.Controls.Add(this.SW_SaveData);
            this.Admindata.Location = new System.Drawing.Point(0, 40);
            this.Admindata.Name = "Admindata";
            this.Admindata.Size = new System.Drawing.Size(777, 542);
            this.Admindata.TabIndex = 1;
            this.Admindata.Text = "傳輸設定";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(979, 585);
            this.Controls.Add(this.uiTabControlMenu1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.溫度感測_Load);
            this.groupBoxSendData.ResumeLayout(false);
            this.groupBoxSendData.PerformLayout();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            this.SW_SaveData.ResumeLayout(false);
            this.SW_SaveData.PerformLayout();
            this.uiGroupBox4.ResumeLayout(false);
            this.uiGroupBox4.PerformLayout();
            this.uiGroupBox5.ResumeLayout(false);
            this.uiGroupBox5.PerformLayout();
            this.uiGroupBox3.ResumeLayout(false);
            this.uiTabControlMenu1.ResumeLayout(false);
            this.tabReport.ResumeLayout(false);
            this.uiTabControl2.ResumeLayout(false);
            this.tabchart.ResumeLayout(false);
            this.tabchart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabDataoutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.tabDataView.ResumeLayout(false);
            this.uiGroupBox6.ResumeLayout(false);
            this.tabSet.ResumeLayout(false);
            this.uiTabControl1.ResumeLayout(false);
            this.Userdata.ResumeLayout(false);
            this.Userdata.PerformLayout();
            this.Admindata.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxSendData;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_Send5;
        private System.Windows.Forms.TextBox TB_Send4;
        private System.Windows.Forms.TextBox TB_Send3;
        private System.Windows.Forms.TextBox TB_Send2;
        private System.Windows.Forms.TextBox TB_Send1;
        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UIComboBox CB_port;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISwitch Btn_continu;
        private Sunny.UI.UISymbolButton Btn_close;
        private Sunny.UI.UISymbolButton Btn_open;
        private Sunny.UI.UITextBox textBoxReceive;
        private Sunny.UI.UIGroupBox SW_SaveData;
        private System.Windows.Forms.Label LB_temp;
        private Sunny.UI.UILedBulb LED_red;
        private Sunny.UI.UIGroupBox uiGroupBox4;
        private System.Windows.Forms.Label LB_wet;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UILedBulb LED_green;
        private System.Windows.Forms.TextBox TB_tmplimit;
        private Sunny.UI.UIGroupBox uiGroupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_wetlimit;
        private Sunny.UI.UISwitch uiSwitch1;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UIGroupBox uiGroupBox3;
        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.TabPage tabDataView;
        private System.Windows.Forms.TabPage tabSet;
        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage Userdata;
        private System.Windows.Forms.TabPage Admindata;
        private Sunny.UI.UIButton Btn_send;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Sunny.UI.UIGroupBox uiGroupBox6;
        private System.Windows.Forms.TextBox TB_Timer;
        private Sunny.UI.UITabControl uiTabControl2;
        private System.Windows.Forms.TabPage tabchart;
        private Sunny.UI.UIDatePicker dtp_table;
        private System.Windows.Forms.TabPage tabDataoutput;
        private Sunny.UI.UIImageButton uiImageButton1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIDatePicker dtp_Date;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Wet;
        private System.Windows.Forms.TextBox testtext;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

