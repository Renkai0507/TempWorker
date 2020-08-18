using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using My;
using System.Windows.Forms.DataVisualization.Charting;
using Sunny.UI;

namespace TempWorker
{
    public partial class MainForm : Form
    {
        public SerialPort port;
        public string strComport;
        string[] AllComport = SerialPort.GetPortNames();
        String indata_1;        
        bool Always = true;
        public static DateTime Now; 
        List<string> AllRecord;
        string strfilepath;
        chreport FSP;
        DataTable dt;
        string[] RecordDate;
        DateTime[] DT;
        double[] temps;
        int[] wets;
        public MainForm()
        {
            InitializeComponent();
            setComport();
            strfilepath = "";
            
            uiTabControlMenu1.SelectedIndex=1 ;
        }

        private void 溫度感測_Load(object sender, EventArgs e)
        {
            AllRecord = new List<string>();
            dtp_table.Value = DateTime.Now;
            dtp_Date.Value = DateTime.Now;
            initddata();
        }
        private void setComport()
        {
            for (int i = 0; i < AllComport.Length; i++)
            {
                CB_port.Items.Add(AllComport[i]);
            }
            CB_port.Text = AllComport[AllComport.Length - 1];
        }


        private void CB_port_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AllComport == null)
            {
                MessageBox.Show("沒有串口", "ERRO");
            }
            else
            {
                strComport = CB_port.Text;
            }
        }
        public void getdata()
        {
            strComport = CB_port.Text;
            port = new SerialPort(strComport, 9600, Parity.None, 8, StopBits.One);
            if (!port.IsOpen)
            {

                try
                {
                    //if (CB_port.SelectedIndex == -1)
                    //{
                    //    MessageBox.Show("Error: 無效端口,請重新選擇", "Error");
                    //    return;
                    //}
                    port.Open();
                    port.DataReceived += new SerialDataReceivedEventHandler(dataReceived);
                    Btn_open.Enabled = false;
                    Btn_close.Enabled = true;

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());

                }
            }


        }
        public void dataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            if (port.IsOpen)
            {
                SerialPort sp = (SerialPort)sender;
                int intBuffer;
                intBuffer = sp.BytesToRead;
                byte[] byteBuffer = new byte[intBuffer];
                sp.Read(byteBuffer, 0, intBuffer);
                indata_1 = ByteArrayToHexString(byteBuffer);


                MethodInvoker mi = new MethodInvoker(this.UpdateUI);
                //this.Invoke(m/*i);*/
                BeginInvoke(mi);
                
                
            }

        }
        private void WriteFile(string[] resultdata)
        {
            bool bolexist, bolDel, boloutput;
            strfilepath = "\\data\\";
            string filepath = System.Windows.Forms.Application.StartupPath + strfilepath;
            string filename = "nowdata.csv";
            string strfinal = Dealstring(resultdata);
            bolexist = My.MyFileIO.FileExists(filepath+filename);
            ///創建檔案
            if (!bolexist)
            {
                ///資料表頭
                string DataTitle = "記錄日期,記錄時間,CH1:溫度 ,CH1濕度";
                MyFileIO.DirCreate(filepath);
                MyFileIO.FileCreate(filename);
                MyMethod.WriteContentToFileAppend(DataTitle, filepath+filename , Encoding.UTF8);
            }
            MyMethod.WriteContentToFileAppend(strfinal, filepath + filename, Encoding.UTF8);
            UpdateChart(strfinal);
        }

        private string Dealstring(string[] resultdata)
        {
            Now = DateTime.Now;
            string output;
            string temp= resultdata[0].Insert(resultdata[0].Length - 1, ".");
            string wet = resultdata[1];
            string Nowdate = string.Format("{0:u}", Now);
            
            output = Nowdate.Remove(Nowdate.Length-1)+"," + temp + "," + wet;
            return output;
        }

        private void UpdateUI()
        {
            textBoxReceive.Text += indata_1 + "\r\n";
            string[] TenNum = indata_1.Split(' ');
            string[] Temp_wet = new string[2];
            int j = 0;
            for (int i = 3; i < TenNum.Length - 3; i += 2)
            {
                Temp_wet[j] = TenNum[i] + TenNum[i + 1];
                Temp_wet[j] = Convert.ToInt32(Temp_wet[j], 16).ToString();
                j += 1;
            }
            if (Temp_wet[0] != null & Temp_wet[0] != null)
            {
                LB_temp.Text = Temp_wet[0].Insert(Temp_wet[0].Length - 1, ".");
                LB_wet.Text = Temp_wet[1];
                WriteFile(Temp_wet);
            }
        }
       

        private byte[] HexStringToByteArray(string s)
        {

            s = s.Replace(" ", "");

            byte[] buffer = new byte[s.Length / 2];

            for (int i = 0; i < s.Length; i += 2)

                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);

            return buffer;
        }

        private string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);

            foreach (byte b in data)

                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));

            return sb.ToString().ToUpper();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            getdata();
            Btn_send.Enabled = true;
            //SerialPor/*t_DataReceived(sender, e);*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendDataOut();
            
        }

        private void Btn_open_Click(object sender, EventArgs e)
        {

            getdata();
            Btn_send.Enabled = true;
            if (Always)
            {
                timer1.Interval = Convert.ToInt32(TB_Timer.Text)*1000;
                timer1.Start();
            }
            SendDataOut();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                port.Close();
                timer1.Stop();
            }
            LB_temp.Text = "   0";
            LB_wet.Text = "  0";
            Btn_close.Enabled = false;
            Btn_open.Enabled = true;
            Btn_send.Enabled = false;
        }

        private void Btn_continu_ValueChanged(object sender, bool value)
        {
            Always = Btn_continu.Active ? true : false;
        }


        private void LED_Alarm(string stralarm, string strlimit)
        {
            if (stralarm == "" || strlimit == "") stralarm=strlimit = "0" ;
            
            float limit = float.Parse(strlimit);
            float Value = float.Parse(stralarm);
            if (Value >= limit)
            {
                LED_green.On = false;
                LED_red.On = true;
            }
            else
            {
                LED_green.On = true;
                LED_red.On = false;
            }
        }

        private void Wet_TextChanged(object sender, EventArgs e)
        {
            LED_Alarm(LB_wet.Text, TB_wetlimit.Text);            
        }

        private void Temp_TextChanged(object sender, EventArgs e)
        {
            LED_Alarm(LB_temp.Text, TB_tmplimit.Text);
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                port.Close();
            }            
            Btn_close.Enabled = false;
            Btn_open.Enabled = true;
            Btn_send.Enabled = false;
        }
            

        private void uiGroupBox3_DoubleClick(object sender, EventArgs e)
        {
            FSP = new chreport();
            //FSP.MdiParent = this;
            FSP.StartPosition = FormStartPosition.CenterScreen;
            FSP.Show();
        }
        private void SendDataOut()
        {
            if (!port.IsOpen)
            {
                MessageBox.Show("請先打開串口", "Error");
                return;
            }

            try
            {
                String strSend = TB_Send1.Text + TB_Send2.Text + TB_Send3.Text + TB_Send4.Text + TB_Send5.Text;
                //textBoxSend.Text;
                byte[] data = HexStringToByteArray(strSend);

                port.Write(data, 0, data.Length);

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex + "轉換錯誤", "Erro");
            }
        }
       
        public void initddata()
        {

            //chart2.ChartAreas[0].AxisX.Interval = (chart2.ChartAreas[0].AxisX.Maximum - chart2.ChartAreas[0].AxisX.Minimum);



            string strfilepath = "\\data\\";
            string filepath = System.Windows.Forms.Application.StartupPath + strfilepath;
            string filename = "nowdata.csv";
            bool bolexist = My.MyFileIO.FileExists(filepath + filename);

            //chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd-HH:mm:ss" = DateTime.Now.ToOADate();

            ///創建檔案
            if (bolexist) 
            {
                CsvReader csv = new CsvReader();
                dt = csv.readCsv(filepath, filename);
                //setchart();

                //chart1.ChartAreas[0].AxisX.Maximum = DT[DT.Length - 1].AddMinutes(10).ToOADate();
                //chart1.ChartAreas[0].AxisX.Interval = (chart1.ChartAreas[0].AxisX.Maximum - chart1.ChartAreas[0].AxisX.Minimum);
            }

        }
        public void setchart()
        {
            chart2.ChartAreas[0].AxisY.Minimum = 0;
            chart2.ChartAreas[0].AxisY.Maximum = 100;
            chart2.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Minutes;
            chart2.ChartAreas[0].AxisX.LabelStyle.Format = "{0:HH:mm:ss}";

            chart2.Series[1].Points.Clear();
            chart2.Series[0].Points.Clear();
            RecordDate = new string[dt.Rows.Count];
             DT = new DateTime[dt.Rows.Count];
             temps      = new double[dt.Rows.Count];
             wets       = new int[dt.Rows.Count];
                                  
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString().Equals(""))
                {
                }
                else
                {
                    DateTime intime = Convert.ToDateTime(dt.Rows[i][0].ToString());
                    DT[i] = (Convert.ToDateTime(dt.Rows[i][0].ToString()));
                    RecordDate[i] = string.Format("{0:HH:mm}", DT);

                    temps[i] = double.Parse(dt.Rows[i][1].ToString());
                    wets[i] = int.Parse(dt.Rows[i][2].ToString());
                    if (intime.Date.Equals(Convert.ToDateTime(dtp_table.Text)))
                    {
                        chart2.Series[0].Points.AddXY(DT[i], temps[i]);
                        chart2.Series[1].Points.AddXY(DT[i], wets[i]);
                    }
                }
            }
            if (chart2.Series[0].Points.Count >= 1)
            {
                chart2.ChartAreas[0].AxisX.Minimum = DateTime.FromOADate(chart2.Series[0].Points[0].XValue).AddMinutes(-10).ToOADate();
                chart2.ChartAreas[0].AxisX.Maximum = DateTime.FromOADate(chart2.Series[0].Points[chart2.Series[0].Points.Count - 1].XValue).AddMinutes(10).ToOADate();
            }
           

        }
        void UpdateChart(string strdata)
        {
            DateTime Tabledate, Today;
            Tabledate = Convert.ToDateTime(dtp_table.Text);
            Today = DateTime.Now;
            string[] dataArray = strdata.Split(',');
            if (Tabledate.Date.Equals(Today.Date))
            {
                DateTime Utime =Convert.ToDateTime( dataArray[0]);

                chart2.Series[0].Points.AddXY(Utime, dataArray[1]);
                chart2.Series[1].Points.AddXY(Utime, dataArray[2]);
            }
            if (dt!=null)
            {
                DataRow RealTimeData =  dt.NewRow() ;
                RealTimeData[0] = dataArray[0];
                RealTimeData[1] = dataArray[1];
                RealTimeData[2] = dataArray[2];
            }
            chart2.Series[0].Sort(PointSortOrder.Ascending, "X");
            chart2.Series[1].Sort(PointSortOrder.Ascending, "X");
            chart2.ChartAreas[0].AxisX.Minimum = DateTime.FromOADate(chart2.Series[0].Points[0].XValue).AddMinutes(-10).ToOADate();
            chart2.ChartAreas[0].AxisX.Maximum = DateTime.FromOADate(chart2.Series[0].Points[chart2.Series[0].Points.Count - 1].XValue).AddMinutes(10).ToOADate();

        }


        private void chart1_GetToolTipText(object sender, System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs e)
        {
            if (e.HitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                int i = e.HitTestResult.PointIndex;
                DataPoint dp = e.HitTestResult.Series.Points[i];
                                
                //分别显示x轴和y轴的数值，其中{1:F2},表示显示的是float类型，精确到小数点后2位。  
                e.Text = string.Format("時間:{0};數值:{1:F2} ", dp.XValue.ToDateTime(), dp.YValues[0]);
            }  

        }

        private void dtp_table_ValueChanged(object sender, DateTime value)
        {
            setchart();
        }

        private void uiImageButton1_Click(object sender, EventArgs e)
        {
            string strfilepath = "\\data\\";
            string filepath = System.Windows.Forms.Application.StartupPath + strfilepath;
            string filename = "nowdata.csv";
            bool bolexist = My.MyFileIO.FileExists(filepath + filename);
            List<string> writedata = new List<string> { };
            //chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd-HH:mm:ss" = DateTime.Now.ToOADate();
            ///創建檔案
            string[] fields;
            if (bolexist)
            {
                CsvReader csv = new CsvReader();
                dt = csv.readCsv(filepath, filename);

                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][0].ToString().Length>1)
                    {
                        bool Rightdate = dtp_Date.Value == Convert.ToDateTime(dt.Rows[i][0]);
                        TimeSpan s1 = new TimeSpan(dtp_Date.Value.Ticks- Convert.ToDateTime(dt.Rows[i][0]).Ticks);

                        
                        if (s1.Days==0)
                        {
                            writedata.Add(dt.Rows[i][0].ToString() + "," + dt.Rows[i][1].ToString() + "," + dt.Rows[i][2].ToString());
                        }
                    }
                }
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            string filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
            saveFileDialog1.Filter = filter;
            saveFileDialog1.Title = "匯出 " + "CSV";
            saveFileDialog1.FileName = string.Format("{0:yyyyMMdd}", dtp_Date.Value);
            StreamWriter writer = null;



            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //FileStream strfile = new FileStream(saveFileDialog1.FileName,FileMode.Open);
                filter = saveFileDialog1.FileName;
                 writer = new StreamWriter(filter);                
                foreach (string line in writedata)
                {
                        writer.WriteLine(line);
                }
                writer.Close();
                MessageBox.Show("匯出完成 : " + filter, "匯出", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        
    }
}
