using System.Data.SqlClient;
using QCF_DTO;

namespace QCF_DAO
{
    public class taikhoan_DAO
    {
        public static taikhoan_DTO DangNhap(string username, string password)
        {
            taikhoan_DTO tk = null;

            using (SqlConnection conn = DataProvider.TaoKetNoi())
            {
                conn.Open();
                string sql = "SELECT * FROM NhanVien WHERE TenDangNhap = @username AND MatKhau = @password";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    tk = new taikhoan_DTO()
                    {
                        TenDangNhap = reader["TenDangNhap"].ToString(),
                        MatKhau = reader["MatKhau"].ToString(),
                        TenNV = reader["TenNV"].ToString(),
                        MaNV = int.Parse(reader["MaNV"].ToString()),
                        ViTri = reader["ViTri"].ToString()
                    };
                }

                reader.Close();
            }

            return tk;
        }
    }
}
