using QCF_BUS;
using QCF_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QCF_GUI
{
    public partial class giolam: Form
    {
        private Giolam_BUS bus = new Giolam_BUS();
        private giolam_DTO selectedGioLam;
        public giolam()
        {
            InitializeComponent();
            HienThiTenDangNhap();
        }
        private void HienThiTenDangNhap()
        {
            string tenNV = taikhoan_DTO.TenNhanVienDangNhap;
            tsmi_tennv.Text = $"Xin chào, {tenNV}!";
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            try
            {
                giolam_DTO gioLamMoi = new giolam_DTO
                {
                    MaLich = int.Parse(tb_malich.Text),
                    MaNV = int.Parse(tb_manv.Text),
                    Ngay = dtp_nglam.Value,
                    CaLam = cb_calam.SelectedItem.ToString(),
                    ViTri = cb_bophan.SelectedItem.ToString()
                };

                bus.ThemGioLam(gioLamMoi);
                LoadGioLam();
                MessageBox.Show("Thêm giờ làm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm giờ làm: " + ex.Message);
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (selectedGioLam == null)
            {
                MessageBox.Show("Vui lòng chọn một giờ làm để xóa.");
                return;
            }
            try
            {
                int maLich = selectedGioLam.MaLich;
                bus.XoaGioLam(maLich);
                LoadGioLam();
                MessageBox.Show("Xóa giờ làm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi xóa giờ làm: " + ex.Message);
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (selectedGioLam == null)
            {
                MessageBox.Show("Vui lòng chọn một giờ làm để sửa.");
                return;
            }

            try
            {
                giolam_DTO gioLamSua = new giolam_DTO
                {
                    MaLich = int.Parse(tb_malich.Text),
                    MaNV = int.Parse(tb_manv.Text),
                    Ngay = dtp_nglam.Value,
                    CaLam = cb_calam.SelectedItem.ToString(),
                    ViTri = cb_bophan.SelectedItem.ToString()
                };

                bus.SuaGioLam(gioLamSua);
                LoadGioLam();
                MessageBox.Show("Cập nhật giờ làm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật giờ làm: " + ex.Message);
            }
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            string keyword = tb_tim.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
                return;
            }

            try
            {
                List<giolam_DTO> ketQuaTimKiem = bus.TimKiemGioLam(keyword);
                if (ketQuaTimKiem.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy giờ làm.");
                }
                else
                {
                    dgv_gl.DataSource = null;
                    dgv_gl.DataSource = ketQuaTimKiem;
                    dgv_gl.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tìm kiếm giờ làm: " + ex.Message);
            }
        }

        private void giolam_Load(object sender, EventArgs e)
        {
            LoadGioLam();
            LoadViTri();
            LoadCaLam();
        }
        private void LoadGioLam()
        {
            try
            {
                List<giolam_DTO> danhSachGioLam = bus.GetDanhSachGioLam();
                dgv_gl.AutoGenerateColumns = true;
                dgv_gl.DataSource = null;
                dgv_gl.DataSource = danhSachGioLam;
                dgv_gl.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadViTri()
        {
            cb_bophan.Items.Add("Quản lý");
            cb_bophan.Items.Add("Phục Vụ");
            cb_bophan.Items.Add("Pha Chế");
            cb_bophan.Items.Add("Thu Ngân");
            cb_bophan.SelectedIndex = 0;
        }
        private void LoadCaLam()
        {
            cb_calam.Items.Add("Part-Time(8h-12h)");
            cb_calam.Items.Add("Part-Time(12h-17h)");
            cb_calam.Items.Add("Part-Time(17h-22h)");
            cb_calam.Items.Add("Full-Time(8h-16h)");
            cb_calam.Items.Add("Full-Time(16h-22h)");
            cb_calam.SelectedIndex = 0; 
        }
        private void dgv_gl_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_gl.CurrentRow != null && dgv_gl.CurrentRow.DataBoundItem != null)
            {
                selectedGioLam = (giolam_DTO)dgv_gl.CurrentRow.DataBoundItem;
                tb_malich.Text = selectedGioLam.MaLich.ToString();
                tb_manv.Text = selectedGioLam.MaNV.ToString();
                dtp_nglam.Value = selectedGioLam.Ngay;
                cb_calam.SelectedItem = selectedGioLam.CaLam;
                cb_bophan.SelectedItem = selectedGioLam.ViTri;
            }
        }

        private void tsmi_trangchu_Click(object sender, EventArgs e)
        {
            this.Hide();
            trangchu mainPage = new trangchu();
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

        private void tsmi_qlnl_Click(object sender, EventArgs e)
        {
            this.Hide();
            nguyenlieu mainPage = new nguyenlieu();
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

        private void tsmi_baocao_Click(object sender, EventArgs e)
        {
            this.Hide();
            baocao mainPage = new baocao();
            mainPage.ShowDialog();
            this.Close();
        }

        private void tsmi_danggxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            dangnhap mainPage = new dangnhap();
            mainPage.ShowDialog();
            this.Close();
        }

        private void tb_malich_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_manv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
