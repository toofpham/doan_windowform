using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QCF_DAO;
using QCF_DTO;

namespace QCF_BUS
{
    public class taikhoan_BUS
    {
        public static taikhoan_DTO KiemTraDangNhap(string username, string password)
        {
            return taikhoan_DAO.DangNhap(username, password);
        }
    }
}
