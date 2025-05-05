using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using QCF_DTO;

namespace QCF_DAO
{
    public class Giolam_DAO
    {
        public List<giolam_DTO> LayDanhSachGioLam()
        {
            List<giolam_DTO> dsGioLam = new List<giolam_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string query = @"SELECT lv.MaLich, lv.MaNV, nv.TenNV, lv.Ngay, lv.CaLam, lv.ViTri 
                     FROM LichLamViec lv 
                     JOIN NhanVien nv ON lv.MaNV = nv.MaNV";
            SqlDataReader dr = DataProvider.TruyVan(query, conn);

            while (dr.Read())
            {
                giolam_DTO gioLam = new giolam_DTO();
                gioLam.MaLich = int.Parse(dr["MaLich"].ToString());
                gioLam.MaNV = int.Parse(dr["MaNV"].ToString());
                gioLam.TenNV = dr["TenNV"].ToString();
                gioLam.Ngay = DateTime.Parse(dr["Ngay"].ToString());
                gioLam.CaLam = dr["CaLam"].ToString();
                gioLam.ViTri = dr["ViTri"].ToString();

                dsGioLam.Add(gioLam);
            }

            dr.Close();
            conn.Close();
            return dsGioLam;
        }

        public void ThemGioLam(giolam_DTO gioLam)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string insert = @"INSERT INTO LichLamViec (MaLich,MaNV, Ngay, CaLam, ViTri)
                              VALUES (@MaLich,@MaNV, @Ngay, @CaLam, @ViTri)";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.AddWithValue("@MaLich", gioLam.MaLich);
            cmd.Parameters.AddWithValue("@MaNV", gioLam.MaNV);
            cmd.Parameters.AddWithValue("@Ngay", gioLam.Ngay);
            cmd.Parameters.AddWithValue("@CaLam", gioLam.CaLam);
            cmd.Parameters.AddWithValue("@ViTri", gioLam.ViTri);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void XoaGioLam(int maLich)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string delete = "DELETE FROM LichLamViec WHERE MaLich = @MaLich";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.Parameters.AddWithValue("@MaLich", maLich);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void SuaGioLam(giolam_DTO gioLam)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string update = @"UPDATE LichLamViec
                              SET MaNV = @MaNV, Ngay = @Ngay, CaLam = @CaLam, ViTri = @ViTri
                              WHERE MaLich = @MaLich";
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.Parameters.AddWithValue("@MaLich", gioLam.MaLich);
            cmd.Parameters.AddWithValue("@MaNV", gioLam.MaNV);
            cmd.Parameters.AddWithValue("@Ngay", gioLam.Ngay);
            cmd.Parameters.AddWithValue("@CaLam", gioLam.CaLam);
            cmd.Parameters.AddWithValue("@ViTri", gioLam.ViTri);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<giolam_DTO> TimKiemGioLam(string keyword)
        {
            List<giolam_DTO> dsGioLam = new List<giolam_DTO>();

            using (SqlConnection conn = DataProvider.TaoKetNoi())
            {
                conn.Open();
                string search = @"
            SELECT llv.MaLich, llv.MaNV, nv.TenNV, llv.Ngay, llv.CaLam, llv.ViTri
            FROM LichLamViec llv
            INNER JOIN NhanVien nv ON llv.MaNV = nv.MaNV
            WHERE CAST(llv.MaNV AS NVARCHAR) LIKE @Keyword
               OR nv.TenNV LIKE @Keyword";

                using (SqlCommand cmd = new SqlCommand(search, conn))
                {
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            giolam_DTO gioLam = new giolam_DTO
                            {
                                MaLich = int.Parse(dr["MaLich"].ToString()),
                                MaNV = int.Parse(dr["MaNV"].ToString()),
                                TenNV = dr["TenNV"].ToString(),
                                Ngay = DateTime.Parse(dr["Ngay"].ToString()),
                                CaLam = dr["CaLam"].ToString(),
                                ViTri = dr["ViTri"].ToString()
                            };

                            dsGioLam.Add(gioLam);
                        }
                    }
                }
            }

            return dsGioLam;
        }

    }
}
