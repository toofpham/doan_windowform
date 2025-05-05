using QCF_DTO;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace QCF_DAO
{
    public class cthoadon_DAO
    {
        public void ThemChiTietHoaDon(cthoadon_DTO chiTiet)
        {
            using (SqlConnection conn = DataProvider.TaoKetNoi())
            {
                conn.Open(); 
                string query = "INSERT INTO ChiTietHoaDon (MaHD, MaMon, SoLuong, DonGia) VALUES (@MaHD, @MaMon, @SoLuong, @DonGia)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHD", chiTiet.MaHD);
                cmd.Parameters.AddWithValue("@MaMon", chiTiet.MaMon);
                cmd.Parameters.AddWithValue("@SoLuong", chiTiet.SoLuong);
                cmd.Parameters.AddWithValue("@DonGia", chiTiet.DonGia);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
