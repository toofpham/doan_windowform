using System;
using System.Collections.Generic;
using QCF_DAO;
using QCF_DTO;

namespace QCF_BUS
{
    public class nhansu_BUS
    {
        private Nhansu_DAO dao = new Nhansu_DAO();

        public List<nhansu_DTO> GetDanhSachNhanSu()
        {
            return dao.LayDanhSachNhanSu();
        }

        public void ThemNhanSu(nhansu_DTO ns)
        {
            dao.ThemNhanSu(ns);
        }
        public void SuaNhanSu(nhansu_DTO ns)
        {
            dao.SuaNhanSu(ns);
        }

        public List<nhansu_DTO> TimKiemNhanSu(string keyword)
        {
            return dao.TimKiemNhanSu(keyword);
        }
    }
}
