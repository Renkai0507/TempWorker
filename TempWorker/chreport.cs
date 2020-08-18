using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempWorker
{
    public partial class chreport : Form
    {
        DataTable dt;
        public chreport()
        {
            InitializeComponent();
            initddata();
        }

        public void initddata()
        {
            string strfilepath = "\\data\\";
            string filepath = System.Windows.Forms.Application.StartupPath + strfilepath;
            string filename = "nowdata.csv";
            CsvReader csv = new CsvReader();
            dt=csv.readCsv(filepath, filename);
            setchart();
        }
        /// <summary>
        /// 處理chart
        /// </summary>
         #region 由chart讀取DataTable
        public void setchart()
        {
            string[] RecordDate = new string[dt.Rows.Count];
            string[] Recordtime = new string[dt.Rows.Count];
            double[] temps = new double[dt.Rows.Count];
            int[] wets = new int[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                RecordDate[i] = dt.Rows[i][0].ToString().Substring(5);
                Recordtime[i] = dt.Rows[i][1].ToString().Substring(5);
                temps[i] = double.Parse(dt.Rows[i][2].ToString()) ;
                wets[i] = int.Parse(dt.Rows[i][3].ToString()) ;
            }

            for (int i = 0; i < Recordtime.Length; i++)
            {
                chart1.Series[0].Points.AddXY(Recordtime[i], temps[i]);
                chart1.Series[1].Points.AddXY(Recordtime[i], wets[i]);

            }
        }
#endregion



    }
}
