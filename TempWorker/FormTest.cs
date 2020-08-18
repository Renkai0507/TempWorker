using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TempWorker
{
    public partial class FormTest : Form ,ISerialPortUI   {
        public SerialPort Sport;
        ClsComPort CCP;
        string[] AllComport = SerialPort.GetPortNames();
        string strComport;
        Thread t;
        
        public FormTest()
        {
            InitializeComponent();
        }
        private void FormTest_Load(object sender, EventArgs e)
        {
            Sport = new SerialPort();
            CCP = new ClsComPort();
            ClsComPort.SetPortName("ABC");
            Init_config();
            SetPortData();
            
        }
        private void Init_config()
        {
            for (int i = 0; i < AllComport.Length; i++)
            {
                CB_port.Items.Add(AllComport[i]);
            }
            CB_port.Text = AllComport[AllComport.Length - 1];
            strComport = CB_port.Text;
            
        }


        public void ERROString(string strErro, string ErroHead)
        {
            MessageBox.Show(strErro, ErroHead);
        }
        public void UIthreadControl()
        {
            textBoxReceive.Text += CCP.indata + "\r\n";
            string[] TenNum = CCP.indata.Split(' ');
            string[] Temp_wet = new string[2];
            int j = 0;
            for (int i = 3; i < TenNum.Length - 3; i += 2)
            {
                Temp_wet[j] = TenNum[i] + TenNum[i + 1];
                Temp_wet[j] = Convert.ToInt32(Temp_wet[j], 16).ToString();
                j += 1;
            }

            LB_temp.Text = Temp_wet[0].Insert(Temp_wet[0].Length - 1, ".");
            LB_wet.Text = Temp_wet[1];



            //MethodInvoker mi = new MethodInvoker(this.UpdateUI);
            ////if (this.IsHandleCreated)

            ////this.Invoke(m/*i);*/
            //BeginInvoke(mi);

        }

        public void UpdateUI()
        {
            textBoxReceive.Text += CCP.indata + "\r\n";
            string[] TenNum = CCP.indata.Split(' ');
            string[] Temp_wet = new string[2];
            int j = 0;
            for (int i = 3; i < TenNum.Length - 3; i += 2)
            {
                Temp_wet[j] = TenNum[i] + TenNum[i + 1];
                Temp_wet[j] = Convert.ToInt32(Temp_wet[j], 16).ToString();
                j += 1;
            }

            LB_temp.Text = Temp_wet[0].Insert(Temp_wet[0].Length - 1, ".");
            LB_wet.Text = Temp_wet[1];
        }
        private void SetPortData()
        {
            ClsComPort.SetPortName(strComport);
        }


        private void Btn_open_Click(object sender, EventArgs e)
        {
            Sport.Open();
            Sport.DataReceived += new SerialDataReceivedEventHandler(CCP.dataReceived);
            t = new Thread(SetPortData);
            t.IsBackground = true;
            t.Start();
        }

        private void Btn_send_Click(object sender, EventArgs e)
        {
            if (!Sport.IsOpen)
            {
                MessageBox.Show("請先打開串口", "Error");
                return;
            }

            try
            {
                String strSend = TB_Send1.Text + TB_Send2.Text + TB_Send3.Text + TB_Send4.Text + TB_Send5.Text;
                //textBoxSend.Text;
                byte[] data = CCP.HexStringToByteArray(strSend);

                Sport.Write(data, 0, data.Length);

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex + "轉換錯誤", "Erro");
            }
        }
    }
}
