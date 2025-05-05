using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using QCF_DAO;
using QCF_DTO;

public class baocao_DAO
{
    public static List<baocao_DTO> GetBaoCaoTheoNgay(DateTime tuNgay, DateTime denNgay)
    {
        List<baocao_DTO> ds = new List<baocao_DTO>();

        string query = @"
            SELECT 
                CAST(ROW_NUMBER() OVER (ORDER BY CAST(Ngay AS DATE)) AS INT) AS MaBC,
                CAST(Ngay AS DATE) AS NgayBaoCao,
                SUM(TongTien) AS TongDoanhThu
            FROM HoaDon
            WHERE Ngay BETWEEN @tuNgay AND @denNgay
            GROUP BY CAST(Ngay AS DATE)
            ORDER BY NgayBaoCao";

        using (SqlConnection conn = DataProvider.TaoKetNoi())
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@tuNgay", tuNgay);
            cmd.Parameters.AddWithValue("@denNgay", denNgay);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                baocao_DTO bc = new baocao_DTO
                {
                    MaBC = reader.GetInt32(0),
                    NgayBaoCao = reader.GetDateTime(1),
                    TongDoanhThu = reader.GetDecimal(2)
                };
                ds.Add(bc);
            }
        }
        return ds;
    }
    public static void LuuBaoCaoVaoCSDL(List<baocao_DTO> danhSach)
    {
        string query = "INSERT INTO BaoCaoDoanhThu (NgayBaoCao, TongDoanhThu,MaNV) VALUES (@ngay, @tong,@MaNV)";
        using (SqlConnection conn = DataProvider.TaoKetNoi())
        {
            conn.Open();
            foreach (var item in danhSach)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", item.MaNV);
                cmd.Parameters.AddWithValue("@ngay", item.NgayBaoCao);
                cmd.Parameters.AddWithValue("@tong", item.TongDoanhThu);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
