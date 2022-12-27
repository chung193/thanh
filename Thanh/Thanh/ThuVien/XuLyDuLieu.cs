using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Thanh.ThuVien
{
    internal class XuLyDuLieu
    {
        private string strConn;
        public string loi;
        private SqlConnection conn;

        public XuLyDuLieu()
        {
            strConn = "Data Source=DESKTOP-G25SBPL;Initial Catalog=thanh;Integrated Security=True";
            conn = new SqlConnection(strConn);
        }

        public bool MoKetNoi()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                loi = ex.Message;
                return false;
            }
        }

        public void DongKetNoi()
        {
            if(conn != null)
            {
                conn.Close();
            }
        }

        public DataTable LayDt(string strSql)
        {
            SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public SqlDataAdapter LayDa(String strSql)
        {
            SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
            return da;
        }

        public bool ThucHienCauLenh(String strSql)
        {
            int kq = 0;
            try
            {
                MoKetNoi();
                SqlCommand cmd = new SqlCommand(strSql, conn);
                kq = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                loi = ex.Message;
                kq = 0;
            }
            finally
            {
                DongKetNoi();
            }
            return kq > 0;
        }

        public int LenhVoHuong(String strSql)
        {
            int kq = 0;
            try
            {
                loi = "";
                MoKetNoi();
                SqlCommand cmd = new SqlCommand(strSql, conn);
                kq = int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                loi = ex.Message;
            }
            finally
            {
                DongKetNoi();
            }
            return kq;
        }

    }
}
