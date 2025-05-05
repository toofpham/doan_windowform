using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using QCF_DTO;

namespace QCF_DAO
{
    public class Sanpham_DAO
    {
        public List<sanpham_DTO> LayDanhSachSanPham()
        {
            List<sanpham_DTO> dsSanPham = new List<sanpham_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string selectSanPham = "select * from Mon";
            SqlDataReader dr = DataProvider.TruyVan(selectSanPham, conn);

            while (dr.Read())
            {
                sanpham_DTO sanPham = new sanpham_DTO();
                sanPham.MaMon = int.Parse(dr["MaMon"].ToString()); 
                sanPham.TenMon = dr["TenMon"].ToString(); 
                sanPham.Gia = decimal.Parse(dr["Gia"].ToString()); 
                sanPham.MoTa = dr["MoTa"].ToString();
                sanPham.TrangThai = dr["TrangThai"].ToString();
                dsSanPham.Add(sanPham); 
            }

            dr.Close();
            conn.Close();
            return dsSanPham;
        }

        public void ThemSanPham(sanpham_DTO sp)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string insertSanPham = "insert into Mon (MaMon , TenMon, Gia, MoTa, TrangThai) values (@MaMon,@TenMon, @Gia, @MoTa, @TrangThai)";
            SqlCommand cmd = new SqlCommand(insertSanPham, conn);
            cmd.Parameters.AddWithValue("@MaMon", sp.MaMon);
            cmd.Parameters.AddWithValue("@TenMon", sp.TenMon);
            cmd.Parameters.AddWithValue("@Gia", sp.Gia);
            cmd.Parameters.AddWithValue("@MoTa", sp.MoTa);
            cmd.Parameters.AddWithValue("@TrangThai", sp.TrangThai);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void XoaSanPham(int maMon)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string deleteSanPham = "delete from Mon where MaMon = @MaMon";
            SqlCommand cmd = new SqlCommand(deleteSanPham, conn);
            cmd.Parameters.AddWithValue("@MaMon", maMon);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void SuaSanPham(sanpham_DTO sp)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string updateSanPham = "update Mon set TenMon = @TenMon, Gia = @Gia, MoTa = @MoTa, TrangThai = @TrangThai where MaMon = @MaMon";
            SqlCommand cmd = new SqlCommand(updateSanPham, conn);
            cmd.Parameters.AddWithValue("@MaMon", sp.MaMon);
            cmd.Parameters.AddWithValue("@TenMon", sp.TenMon);
            cmd.Parameters.AddWithValue("@Gia", sp.Gia);
            cmd.Parameters.AddWithValue("@MoTa", sp.MoTa);
            cmd.Parameters.AddWithValue("@TrangThai", sp.TrangThai);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<sanpham_DTO> TimKiemSanPham(string keyword)
        {
            List<sanpham_DTO> dsSanPham = new List<sanpham_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string searchSanPham = "select * from Mon where TenMon like @Keyword";
            SqlCommand cmd = new SqlCommand(searchSanPham, conn);
            cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sanpham_DTO sanPham = new sanpham_DTO();
                sanPham.MaMon = int.Parse(dr["MaMon"].ToString());
                sanPham.TenMon = dr["TenMon"].ToString();
                sanPham.Gia = decimal.Parse(dr["Gia"].ToString());
                sanPham.MoTa = dr["MoTa"].ToString();
                sanPham.TrangThai = dr["TrangThai"].ToString();
                dsSanPham.Add(sanPham);
            }
            dr.Close();
            conn.Close();
            return dsSanPham;
        }
    }
}
