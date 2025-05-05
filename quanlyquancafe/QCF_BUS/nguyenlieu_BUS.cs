using System;
using System.Collections.Generic;
using QCF_DAO;
using QCF_DTO;

namespace QCF_BUS
{
    public class NguyenLieuBUS
    {
        private nguyenlieu_DAO dao = new nguyenlieu_DAO();

        public List<nguyenlieu_DTO> GetDanhSachNguyenLieu()
        {
            return dao.LayDanhSachNguyenLieu();
        }

        public void ThemNguyenLieu(nguyenlieu_DTO nl)
        {
            dao.ThemNguyenLieu(nl);
        }

        public void XoaNguyenLieu(int maNL)
        {
            dao.XoaNguyenLieu(maNL);
        }

        public void SuaNguyenLieu(nguyenlieu_DTO nl)
        {
            dao.SuaNguyenLieu(nl);
        }

        public List<nguyenlieu_DTO> TimKiemNguyenLieu(string keyword)
        {
            return dao.TimKiemNguyenLieu(keyword);
        }
    }
}
