using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography.X509Certificates;

namespace TempWorker
{
    public class ClsComPort 
    {
        static  SerialPort Sport;

        //Thread readThread = new Thread();

        string strSerialName { get; set; }
        string strBaudRate { get; set; }
        string strDataBit { get; set; }
        string strCheckBit { get; set; }
         string strStopBit { get; set; }
        public string indata { get; set; }
        public string[] Port = SerialPort.GetPortNames();
        public string[] baudRate = { "9600", "19200", "38400", "57600", "115200" };
        public string[] dataBit = { "5", "6", "7", "8" };
        public string[] checkBit = { "None", "Even", "Odd", "Mask", "Space" };
        public string[] stopBit = { "1", "1.5", "2" };
        ISerialPortUI ISPUI;

        public  void Main()
        {
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            FormTest UIshow = new FormTest();
            Sport = new SerialPort();
            Sport.PortName = SetPortName(Sport.PortName);
            Sport.BaudRate = SetPortBaudRate(Sport.BaudRate);
            Sport.Parity = SetPortParity(Sport.Parity);
            Sport.DataBits = SetPortDataBits(Sport.DataBits);
            //Sport.StopBits = SetPortStopBits(Sport.StopBits);
            Sport.ReadTimeout = 500;
            Sport.WriteTimeout = 500;

            
        }
        //初始化串口界面參數設置
        public static string SetPortName(string defaultPortName)
        {
            string portName;

            Console.WriteLine("Available Ports:");
            foreach (string s in SerialPort.GetPortNames())
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Enter COM port value (Default: {0}): ", defaultPortName);
            portName = Console.ReadLine();

            if (portName == "" || !(portName.ToLower()).StartsWith("com"))
            {
                portName = defaultPortName;
            }
            return portName;
        }
        public static int SetPortBaudRate(int defaultPortBaudRate)
        {
            string baudRate;

            Console.Write("Baud Rate(default:{0}): ", defaultPortBaudRate);
            baudRate = Console.ReadLine();

            if (baudRate == "")
            {
                baudRate = defaultPortBaudRate.ToString();
            }

            return int.Parse(baudRate);
        }
        public static Parity SetPortParity(Parity defaultPortParity)
        {
            string parity;

            Console.WriteLine("Available Parity options:");
            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Enter Parity value (Default: {0}):", defaultPortParity.ToString(), true);
            parity = Console.ReadLine();

            if (parity == "")
            {
                parity = defaultPortParity.ToString();
            }

            return (Parity)Enum.Parse(typeof(Parity), parity, true);
        }
        // Display DataBits values and prompt user to enter a value.
        public static int SetPortDataBits(int defaultPortDataBits)
        {
            string dataBits;

            Console.Write("Enter DataBits value (Default: {0}): ", defaultPortDataBits);
            dataBits = Console.ReadLine();

            if (dataBits == "")
            {
                dataBits = defaultPortDataBits.ToString();
            }

            return int.Parse(dataBits.ToUpperInvariant());
        }

        // Display StopBits values and prompt user to enter a value.
        //public static StopBits SetPortStopBits(StopBits defaultPortStopBits)
        //{
        //    string stopBits;

        //    Console.WriteLine("Available StopBits options:");
        //    foreach (string s in Enum.GetNames(typeof(StopBits)))
        //    {
        //        Console.WriteLine("   {0}", s);
        //    }
        //}

        public void dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (Sport.IsOpen)
            {
                SerialPort sp = (SerialPort)sender;
                int intBuffer;
                intBuffer = sp.BytesToRead;
                byte[] byteBuffer = new byte[intBuffer];
                sp.Read(byteBuffer, 0, intBuffer);
                indata = ByteArrayToHexString(byteBuffer);
                ISPUI.UIthreadControl();
                //MethodInvoker mi = new MethodInvoker(this.UpdateUI_1);
                //BeginInvoke(mi, null);
            }
        }
        public void datasend(string TB_Send1, string TB_Send2, string TB_Send3, string TB_Send4, string TB_Send5)
        {
            if (!Sport.IsOpen)
            {
                MessageBox.Show("請先打開串口", "Error");
                return;
            }

            try
            {
                String strSend = TB_Send1 + TB_Send2 + TB_Send3 + TB_Send4 + TB_Send5;
                //textBoxSend.Text;
                byte[] data = HexStringToByteArray(strSend);

                Sport.Write(data, 0, data.Length);

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex + "轉換錯誤", "Erro");
            }

        }
        public byte[] HexStringToByteArray(string s)
        {

            s = s.Replace(" ", "");

            byte[] buffer = new byte[s.Length / 2];

            for (int i = 0; i < s.Length; i += 2)

                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);

            return buffer;
        }

        public string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);

            foreach (byte b in data)

                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));

            return sb.ToString().ToUpper();

        }

    }
    public interface ISerialPortUI
    {
        void ERROString(string strErro, string ErroHead);
        void UIthreadControl();
    }
}
