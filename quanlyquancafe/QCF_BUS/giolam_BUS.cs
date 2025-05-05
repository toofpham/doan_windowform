using System;
using System.Collections.Generic;
using QCF_DAO;
using QCF_DTO;

namespace QCF_BUS
{
    public class Giolam_BUS
    {
        private Giolam_DAO dao = new Giolam_DAO();

        public List<giolam_DTO> GetDanhSachGioLam()
        {
            try
            {
                return dao.LayDanhSachGioLam();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách giờ làm: " + ex.Message);
            }
        }

        public void ThemGioLam(giolam_DTO gioLam)
        {
            try
            {
                dao.ThemGioLam(gioLam);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm giờ làm: " + ex.Message);
            }
        }

        public void XoaGioLam(int maLich)
        {
            try
            {
                dao.XoaGioLam(maLich);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa giờ làm: " + ex.Message);
            }
        }

        public void SuaGioLam(giolam_DTO gioLam)
        {
            try
            {
                dao.SuaGioLam(gioLam);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật giờ làm: " + ex.Message);
            }
        }

        public List<giolam_DTO> TimKiemGioLam(string keyword)
        {
            try
            {
                return dao.TimKiemGioLam(keyword);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm giờ làm: " + ex.Message);
            }
        }
    }
}
