using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thanh.ThuVien
{
    public static class DungChung
    {
        public static DataTable dtNguoidung;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sheetname"></param>
        /// <param name="filePath"></param>
        /// <returns>Lấy dữ liệu từ file Exel với tên sheet truyền vào</returns>
        public static System.Data.DataTable LayDL(string sheetname, string filePath)
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

        public static string LayThuMucLamViec()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string currenFolder = Directory.GetParent(workingDirectory).Parent.FullName;
            return currenFolder;
        }
        public static void SaoChep(string sourceFile, string destinationFile)
        {
            try
            {
                //MessageBox.Show(sourceFile);
                File.Copy(sourceFile, destinationFile, true);
            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message);
            }
        }

        // move file
        public static void DiChuyen(string path, string path2)
        {
            try
            {
                File.Move(path, path2);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi xử lý lưu file  " + e.ToString());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="excelFile"></param>
        /// <returns>Lấy danh sách các sheet name</returns>
        public static String[] LaySheet(string excelFile)
        {
            OleDbConnection objConn = null;
            System.Data.DataTable dt = null;

            try
            {
                // Connection String. Change the excel file to the file you
                // will search.
                String connString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = '" + excelFile + "';Extended Properties=\"Excel 12.0;HDR=YES;\"";
                // Create connection object by using the preceding connection string.
                objConn = new OleDbConnection(connString);
                // Open connection with the database.
                objConn.Open();
                // Get the data table containg the schema guid.
                dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                if (dt == null)
                {
                    return null;
                }

                String[] excelSheets = new String[dt.Rows.Count];
                int i = 0;

                // Add the sheet name to the string array.
                foreach (DataRow row in dt.Rows)
                {
                    excelSheets[i] = row["TABLE_NAME"].ToString();
                    i++;
                }

                // Loop through all of the sheets if you want too...
                for (int j = 0; j < excelSheets.Length; j++)
                {
                    // Query each excel sheet.
                    //MessageBox.Show("excel sheet");
                }

                return excelSheets;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                // Clean up.
                if (objConn != null)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
                if (dt != null)
                {
                    dt.Dispose();
                }
            }
        }
    }
}
   
