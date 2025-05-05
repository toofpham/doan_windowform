using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCF_DAO
{
    public static class DataProvider
    {
        static string strKetNoi = "Data Source=.;Initial Catalog = QuanLyQuanCafe; Integrated Security = True";
        public static SqlConnection TaoKetNoi()
        {
            SqlConnection conn = new SqlConnection(strKetNoi);
            return conn;
        }
        public static SqlDataReader TruyVan(string strKetNoi, SqlConnection
        conn)
        {
            SqlCommand comm = new SqlCommand(strKetNoi, conn);
            return comm.ExecuteReader(); 
        }
        public static int ThucThi(string strThucThi, SqlParameter[] sp,
        SqlConnection conn)
        {
            SqlCommand comm = new SqlCommand(strThucThi, conn);
            comm.Parameters.AddRange(sp);
            return comm.ExecuteNonQuery();
        }
    }
}
