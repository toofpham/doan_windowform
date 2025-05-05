using QCF_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QCF_DAO;

namespace QCF_BUS
{
    public class hoadon_BUS
    {
        private hoadon_DAO dao = new hoadon_DAO();

        public int ThemHoaDon(hoadon_DTO hoadon)
        {
            return dao.ThemHoaDon(hoadon);
        }
    }
}