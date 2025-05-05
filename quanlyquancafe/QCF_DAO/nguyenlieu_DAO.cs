using QCF_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace QCF_DAO
{
    public class nguyenlieu_DAO
    {
        public List<nguyenlieu_DTO> LayDanhSachNguyenLieu()
        {
            List<nguyenlieu_DTO> dsNguyenLieu = new List<nguyenlieu_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string selectNguyenLieu = "select * from NguyenLieu";
            SqlDataReader dr = DataProvider.TruyVan(selectNguyenLieu, conn);

            while (dr.Read())
            {
                nguyenlieu_DTO NguyenLieu = new nguyenlieu_DTO();
                NguyenLieu.MaNL = int.Parse(dr["MaNL"].ToString());
                NguyenLieu.TenNL = dr["TenNL"].ToString();
                NguyenLieu.SoLuong = decimal.Parse(dr["SoLuong"].ToString());
                NguyenLieu.DonViTinh = dr["DonViTinh"].ToString();
                NguyenLieu.MaMon = int.Parse(dr["MaMon"].ToString());
                dsNguyenLieu.Add(NguyenLieu);
            }

            dr.Close();
            conn.Close();
            return dsNguyenLieu;
        }

        public void ThemNguyenLieu(nguyenlieu_DTO nl)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string insertNguyenLieu = "insert into NguyenLieu (MaNL,TenNL, SoLuong, DonViTinh, MaMon) values (@MaNL,@TenNL, @SoLuong, @DonViTinh, @MaMon)";
            SqlCommand cmd = new SqlCommand(insertNguyenLieu, conn);
            cmd.Parameters.AddWithValue("@MaNL", nl.MaNL);
            cmd.Parameters.AddWithValue("@TenNL", nl.TenNL);
            cmd.Parameters.AddWithValue("@SoLuong", nl.SoLuong);
            cmd.Parameters.AddWithValue("@DonViTinh", nl.DonViTinh);
            cmd.Parameters.AddWithValue("@MaMon", nl.MaMon);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void XoaNguyenLieu(int maNL)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string deleteNguyenLieu = "delete from NguyenLieu where MaNL = @MaNL";
            SqlCommand cmd = new SqlCommand(deleteNguyenLieu, conn);
            cmd.Parameters.AddWithValue("@MaNL", maNL);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void SuaNguyenLieu(nguyenlieu_DTO nl)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string updateNguyenLieu = "update NguyenLieu set TenNL = @TenNL, SoLuong = @SoLuong, DonViTinh = @DonViTinh, MaMon = @MaMon where MaNL = @MaNL";
            SqlCommand cmd = new SqlCommand(updateNguyenLieu, conn);
            cmd.Parameters.AddWithValue("@MaNL", nl.MaNL);
            cmd.Parameters.AddWithValue("@TenNL", nl.TenNL);
            cmd.Parameters.AddWithValue("@SoLuong", nl.SoLuong);
            cmd.Parameters.AddWithValue("@DonViTinh", nl.DonViTinh);
            cmd.Parameters.AddWithValue("@MaMon", nl.MaMon);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<nguyenlieu_DTO> TimKiemNguyenLieu(string keyword)
        {
            List<nguyenlieu_DTO> dsNguyenLieu = new List<nguyenlieu_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string searchNguyenLieu = "select * from NguyenLieu where TenNL like @Keyword";
            SqlCommand cmd = new SqlCommand(searchNguyenLieu, conn);
            cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nguyenlieu_DTO nguyenLieu = new nguyenlieu_DTO();
                nguyenLieu.MaNL = int.Parse(dr["MaNL"].ToString());
                nguyenLieu.TenNL = dr["TenNL"].ToString();
                nguyenLieu.SoLuong = decimal.Parse(dr["SoLuong"].ToString());
                nguyenLieu.DonViTinh = dr["DonViTinh"].ToString();
                nguyenLieu.MaMon = int.Parse(dr["MaMon"].ToString());
                dsNguyenLieu.Add(nguyenLieu);
            }
            dr.Close();
            conn.Close();
            return dsNguyenLieu;
        }
    }
}
