using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace DemoThanh.Data
{
    internal class XuLyDuLieu
    {
        // lay datatable tu file
        public static System.Data.DataTable getData(string sheetname, string filePath)
        {
            string kn = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = '" + filePath + "';Extended Properties=\"Excel 12.0;HDR=YES;\"";
            using (OleDbConnection conn = new OleDbConnection(kn))
            {
                conn.Open();

                OleDbDataAdapter objDA = new System.Data.OleDb.OleDbDataAdapter("select *from [" + sheetname + "]", conn);
                System.Data.DataTable tb = new System.Data.DataTable();
                objDA.Fill(tb);
                //dgDulieuExcel.DataSource = null;
                return tb;
            }
        }

        // lay tat ca sheet name
        public static String[] GetExcelSheetNames(string excelFile)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook excelBook = xlApp.Workbooks.Open(excelFile);

            String[] excelSheets = new String[excelBook.Worksheets.Count];
            int i = 0;
            foreach (Microsoft.Office.Interop.Excel.Worksheet wSheet in excelBook.Worksheets)
            {
                excelSheets[i] = wSheet.Name;
                i++;
            }
            return excelSheets;
        }
    }
}
