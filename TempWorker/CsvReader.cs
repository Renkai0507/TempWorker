using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TempWorker
{
    class CsvReader
    {
        /// <summary>
        /// 利用SQL查詢CSV
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public DataTable readCsv(string path, string filename)
        {
            string strSQL = "SELECT * FROM [{0}]  ";
            string strconn = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Text;IMEX=1'", path);
            string sql = string.Format(strSQL, filename);
            DataTable dtTable;

            try
            {
                OleDbConnection conn = new OleDbConnection(strconn);

                dtTable = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn);
                adapter.Fill(dtTable);
                //logHelkper.WriteLog(string.Format("[裝置]:{0}-->讀取檔案-->結果:成功", deviceName));
            }
            catch (Exception ex)
            {
                //dtTable = new DataTable();
                //logHelper.WriteLog(string.Format("[裝置]:{0}-->讀取檔案-->結果:{1}", deviceName, ex.Message));
                throw ex;
            }
            return dtTable;
        }
    
    }
}

