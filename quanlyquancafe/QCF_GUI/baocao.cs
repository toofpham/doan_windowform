using QCF_BUS;
using QCF_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QCF_GUI
{
    public partial class baocao: Form
    {

        public baocao()
        {
            InitializeComponent();
            HienThiTenDangNhap();
            PhanQuyen();
        }
        private void PhanQuyen()
        {
            if (taikhoan_DTO.Role == "user")
            {
                tsmi_qlsp.Visible = false;
                tsmi_qlns.Visible = false;
                tsmi_qlgl.Visible = false;
                tsmi_qlnl.Visible = false;
            }
        }
        private void HienThiTenDangNhap()
        {
            string tenNV = taikhoan_DTO.TenNhanVienDangNhap;
            tsmi_tennv.Text = $"Xin chào, {tenNV}!";
        }
        private void tsmi_danggxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            dangnhap mainPage = new dangnhap();
            mainPage.ShowDialog();
            this.Close();
        }

        private void tsmi_qlnl_Click(object sender, EventArgs e)
        {
            this.Hide();
            nguyenlieu mainPage = new nguyenlieu();
            mainPage.ShowDialog();
            this.Close();
        }

        private void tsmi_qlsp_Click(object sender, EventArgs e)
        {
            this.Hide();
            sanpham mainPage = new sanpham();
            mainPage.ShowDialog();
            this.Close();
        }

        private void tsmi_goimon_Click(object sender, EventArgs e)
        {
            this.Hide();
            trangchu mainPage = new trangchu();
            mainPage.ShowDialog();
            this.Close();
        }

        private void tsmi_qlns_Click(object sender, EventArgs e)
        {
            this.Hide();
            nhansu mainPage = new nhansu();
            mainPage.ShowDialog();
            this.Close();
        }

        private void tsmi_qlgl_Click(object sender, EventArgs e)
        {
            this.Hide();
            giolam mainPage = new giolam();
            mainPage.ShowDialog();
            this.Close();
        }

        private void bt_tke_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dt_ngaytu.Value.Date;
            DateTime denNgay = dt_ngayden.Value.Date.AddDays(1).AddTicks(-1);

            var danhSach = baocao_BUS.LayBaoCaoTheoNgay(tuNgay, denNgay);

            if (danhSach.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu hóa đơn trong khoảng ngày này.");
                dgv_baocao.DataSource = null;
                return;
            }

            foreach (var bc in danhSach)
            {
                bc.MaNV = taikhoan_DTO.MaNV_DangNhap;
            }

            baocao_BUS.LuuBaoCao(danhSach);

            dgv_baocao.DataSource = danhSach;

            dgv_baocao.Columns["MaBC"].HeaderText = "Mã BC";
            dgv_baocao.Columns["NgayBaoCao"].HeaderText = "Ngày";
            dgv_baocao.Columns["NgayBaoCao"].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgv_baocao.Columns["TongDoanhThu"].HeaderText = "Tổng Doanh Thu (VNĐ)";
            dgv_baocao.Columns["TongDoanhThu"].DefaultCellStyle.Format = "N0";
            dgv_baocao.Columns["MaNV"].Visible = false;
        }

        private void bt_in_Click(object sender, EventArgs e)
        {
            if (dgv_baocao.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để in báo cáo.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CultureInfo culture = new CultureInfo("vi-VN");

            string baocaoMessage = "          BÁO CÁO DOANH THU          \n";
            baocaoMessage += "---------------------------------------\n";

            foreach (DataGridViewRow row in dgv_baocao.Rows)
            {
                if (row.Cells["MaBC"].Value != null && row.Cells["NgayBaoCao"].Value != null && row.Cells["TongDoanhThu"].Value != null)
                {
                    string maBC = row.Cells["MaBC"].Value.ToString();
                    DateTime ngayBaoCao = Convert.ToDateTime(row.Cells["NgayBaoCao"].Value);
                    decimal tongDoanhThu = Convert.ToDecimal(row.Cells["TongDoanhThu"].Value);

                    baocaoMessage += $"Mã báo cáo: {maBC}\n";
                    baocaoMessage += $"Ngày: {ngayBaoCao.ToString("dd-MM-yyyy")}\n";
                    baocaoMessage += $"Tổng doanh thu: {tongDoanhThu.ToString("c0", culture)}\n";
                    baocaoMessage += "---------------------------------------\n";
                }
            }

            baocaoMessage += $"Mã Nhân viên lập báo cáo: {taikhoan_DTO.MaNV_DangNhap}\n";
            baocaoMessage += $"Nhân viên lập báo cáo: {taikhoan_DTO.TenNhanVienDangNhap}";
            MessageBox.Show(baocaoMessage, "Báo Cáo Doanh Thu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
