using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QCF_DAO;
using QCF_DTO;

namespace QCF_BUS
{
    public class cthoadon_BUS
    {
        private cthoadon_DAO dao = new cthoadon_DAO();

        public void ThemChiTietHoaDon(cthoadon_DTO chiTiet)
        {
            dao.ThemChiTietHoaDon(chiTiet);
        }
    }
}