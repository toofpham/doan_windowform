using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using QCF_DTO;

namespace QCF_DAO
{
    public class Nhansu_DAO
    {
        public List<nhansu_DTO> LayDanhSachNhanSu()
        {
            List<nhansu_DTO> dsNhanSu = new List<nhansu_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string query = "SELECT * FROM NhanVien";
            SqlDataReader dr = DataProvider.TruyVan(query, conn);

            while (dr.Read())
            {
                nhansu_DTO nv = new nhansu_DTO();
                nv.MaNV = int.Parse(dr["MaNV"].ToString());
                nv.TenNV = dr["TenNV"].ToString();
                nv.NgaySinh = DateTime.Parse(dr["NgaySinh"].ToString());
                nv.GioiTinh = dr["GioiTinh"].ToString();
                nv.Email = dr["Email"].ToString();
                nv.SDT = dr["SDT"].ToString();
                nv.Luong = decimal.Parse(dr["Luong"].ToString());
                nv.ViTri = dr["ViTri"].ToString();
                nv.TrangThai = dr["TrangThai"].ToString();
                nv.TenDangNhap = dr["TenDangNhap"].ToString();
                nv.MatKhau = dr["MatKhau"].ToString();

                dsNhanSu.Add(nv);
            }

            dr.Close();
            conn.Close();
            return dsNhanSu;
        }

        public void ThemNhanSu(nhansu_DTO nv)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string insert = @"INSERT INTO NhanVien (MaNV, TenNV, NgaySinh, GioiTinh, Email, SDT, Luong, ViTri, TrangThai,TenDangNhap,MatKhau)
                              VALUES (@MaNV, @TenNV, @NgaySinh, @GioiTinh, @Email, @SDT, @Luong, @ViTri, @TrangThai,@TenDangNhap,@MatKhau)";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
            cmd.Parameters.AddWithValue("@TenNV", nv.TenNV);
            cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
            cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
            cmd.Parameters.AddWithValue("@Email", nv.Email);
            cmd.Parameters.AddWithValue("@SDT", nv.SDT);
            cmd.Parameters.AddWithValue("@Luong", nv.Luong);
            cmd.Parameters.AddWithValue("@ViTri", nv.ViTri);
            cmd.Parameters.AddWithValue("@TrangThai", nv.TrangThai);
            cmd.Parameters.AddWithValue("@TenDangNhap",nv.TenDangNhap);
            cmd.Parameters.AddWithValue("@MatKhau", nv.MatKhau);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void SuaNhanSu(nhansu_DTO nv)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string update = @"UPDATE NhanVien 
                      SET TenNV = @TenNV, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh,
                          Email = @Email, SDT = @SDT, Luong = @Luong, ViTri = @ViTri, TrangThai = @TrangThai, 
                          TenDangNhap = @TenDangNhap, MatKhau = @MatKhau
                      WHERE MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
            cmd.Parameters.AddWithValue("@TenNV", nv.TenNV);
            cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
            cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
            cmd.Parameters.AddWithValue("@Email", nv.Email);
            cmd.Parameters.AddWithValue("@SDT", nv.SDT);
            cmd.Parameters.AddWithValue("@Luong", nv.Luong);
            cmd.Parameters.AddWithValue("@ViTri", nv.ViTri);
            cmd.Parameters.AddWithValue("@TrangThai", nv.TrangThai);
            cmd.Parameters.AddWithValue("@TenDangNhap", nv.TenDangNhap); // Add this line
            cmd.Parameters.AddWithValue("@MatKhau", nv.MatKhau);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public List<nhansu_DTO> TimKiemNhanSu(string keyword)
        {
            List<nhansu_DTO> dsNhanSu = new List<nhansu_DTO>();

            using (SqlConnection conn = DataProvider.TaoKetNoi())
            {
                conn.Open();
                string search = @"SELECT * FROM NhanVien WHERE TenNV LIKE @Keyword OR MaNV LIKE @Keyword";


                using (SqlCommand cmd = new SqlCommand(search, conn))
                {
                    cmd.Parameters.Add("@Keyword", System.Data.SqlDbType.NVarChar, 100).Value = "%" + keyword + "%";

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            nhansu_DTO nv = new nhansu_DTO
                            {
                                MaNV = int.Parse(dr["MaNV"].ToString()),
                                TenNV = dr["TenNV"].ToString(),
                                NgaySinh = dr["NgaySinh"] != DBNull.Value ? Convert.ToDateTime(dr["NgaySinh"]) : DateTime.MinValue,
                                GioiTinh = dr["GioiTinh"].ToString(),
                                Email = dr["Email"].ToString(),
                                SDT = dr["SDT"].ToString(),
                                Luong = dr["Luong"] != DBNull.Value ? Convert.ToDecimal(dr["Luong"]) : 0,
                                ViTri = dr["ViTri"].ToString(),
                                TrangThai = dr["TrangThai"].ToString(),
                                TenDangNhap = dr["TenDangNhap"].ToString(),
                                MatKhau = dr["MatKhau"].ToString()
                            };

                            dsNhanSu.Add(nv);
                        }
                    }
                }
            }

            return dsNhanSu;
        }

    }
}
