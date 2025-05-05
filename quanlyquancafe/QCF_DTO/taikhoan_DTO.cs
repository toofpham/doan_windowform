using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCF_DTO
{
    public class taikhoan_DTO
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string TenNV { set; get; }
        public string ViTri { set; get; }
        public int MaNV { set; get; }

        public static int MaNV_DangNhap { get; set; }
        public static string TenNhanVienDangNhap { get; set; }

        public static string Role { get; set; }
    }
}
