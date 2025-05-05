using QCF_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace QCF_DAO
{
    public class hoadon_DAO
    {
        public int ThemHoaDon(hoadon_DTO hoadon)
        {
            using (SqlConnection conn = DataProvider.TaoKetNoi())
            {
                conn.Open();
                string query = "INSERT INTO HoaDon (MaNV, Ngay, TongTien) OUTPUT INSERTED.MaHD VALUES (@MaNV, @Ngay, @TongTien)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", taikhoan_DTO.MaNV_DangNhap);
                cmd.Parameters.AddWithValue("@Ngay", hoadon.Ngay);
                cmd.Parameters.AddWithValue("@TongTien", hoadon.TongTien);

                return (int)cmd.ExecuteScalar();
            }
        }
    }
}
