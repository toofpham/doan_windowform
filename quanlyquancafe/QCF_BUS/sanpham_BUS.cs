using System;
using System.Collections.Generic;
using QCF_DAO;
using QCF_DTO;

namespace QCF_BUS
{
    public class Sanpham_BUS
    {
        private Sanpham_DAO dao = new Sanpham_DAO();

        public List<sanpham_DTO> GetDanhSachMonAn()
        {
            return dao.LayDanhSachSanPham();
        }

        public void ThemSanPham(sanpham_DTO sp)
        {
            dao.ThemSanPham(sp);
        }

        public void XoaSanPham(int maMon)
        {
            dao.XoaSanPham(maMon);
        }

        public void SuaSanPham(sanpham_DTO sp)
        {
            dao.SuaSanPham(sp);
        }

        public List<sanpham_DTO> TimKiemSanPham(string keyword)
        {
            return dao.TimKiemSanPham(keyword);
        }
    }
}
