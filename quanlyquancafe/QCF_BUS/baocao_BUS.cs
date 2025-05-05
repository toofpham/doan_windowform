using System;
using System.Collections.Generic;
using QCF_DAO;
using QCF_DTO;

public class baocao_BUS
{
    public static List<baocao_DTO> LayBaoCaoTheoNgay(DateTime tuNgay, DateTime denNgay)
    {
        return baocao_DAO.GetBaoCaoTheoNgay(tuNgay, denNgay);
    }
    public static void LuuBaoCao(List<baocao_DTO> danhSach)
    {
        baocao_DAO.LuuBaoCaoVaoCSDL(danhSach);
    }
}