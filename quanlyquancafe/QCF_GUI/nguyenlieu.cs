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
using QCF_BUS;

namespace QCF_GUI
{
    public partial class nguyenlieu: Form
    {
        private NguyenLieuBUS bus = new NguyenLieuBUS();
        private nguyenlieu_DTO selectedNguyenLieu;
        public nguyenlieu()
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
                nguyenlieu_DTO nlMoi = new nguyenlieu_DTO
                {
                    MaNL = int.Parse(tb_manl.Text),
                    MaMon = int.Parse(tb_mamon.Text),
                    TenNL = tb_tennl.Text,
                    SoLuong = decimal.Parse(nud_slton.Text),
                    DonViTinh = cb_dvtinh.SelectedItem.ToString()

                };

                bus.ThemNguyenLieu(nlMoi);
                LoadNguyenLieu();
                MessageBox.Show("Thêm nguyên liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int maNL = int.Parse(tb_manl.Text);
                bus.XoaNguyenLieu(maNL);
                LoadNguyenLieu();
                MessageBox.Show("Xóa nguyên liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            try
            {
                nguyenlieu_DTO nlSua = new nguyenlieu_DTO
                {
                    MaNL = int.Parse(tb_manl.Text),
                    MaMon = int.Parse(tb_mamon.Text),
                    TenNL = tb_tennl.Text,
                    SoLuong = decimal.Parse(nud_slton.Text),
                    DonViTinh = cb_dvtinh.SelectedItem.ToString()
                };

                bus.SuaNguyenLieu(nlSua);
                LoadNguyenLieu();
                MessageBox.Show("Sửa nguyên liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void dgv_nl_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_nl.SelectedRows.Count > 0)
            {
                int rowIndex = dgv_nl.SelectedCells[0].RowIndex;
                selectedNguyenLieu = (nguyenlieu_DTO)dgv_nl.Rows[rowIndex].DataBoundItem;

                tb_manl.Text = selectedNguyenLieu.MaNL.ToString();
                tb_mamon.Text = selectedNguyenLieu.MaMon.ToString();
                tb_tennl.Text = selectedNguyenLieu.TenNL;
                nud_slton.Text = selectedNguyenLieu.SoLuong.ToString();
                cb_dvtinh.SelectedItem = selectedNguyenLieu.DonViTinh;
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
                List<nguyenlieu_DTO> ketQuaTimKiem = bus.TimKiemNguyenLieu(keyword);
                if (ketQuaTimKiem.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nguyên liệu nào.");
                }
                else
                {
                    dgv_nl.DataSource = null;
                    dgv_nl.DataSource = ketQuaTimKiem;
                    dgv_nl.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void nguyenlieu_Load(object sender, EventArgs e)
        {
            LoadNguyenLieu();
            LoadDonViTinh();
        }
        private void LoadNguyenLieu()
        {
            try
            {
                List<nguyenlieu_DTO> danhSachNguyenLieu = bus.GetDanhSachNguyenLieu();
                dgv_nl.AutoGenerateColumns = true;
                dgv_nl.DataSource = null;
                dgv_nl.DataSource = danhSachNguyenLieu;
                dgv_nl.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void LoadDonViTinh()
        {
            cb_dvtinh.Items.Add("Kg");
            cb_dvtinh.Items.Add("Lít");
            cb_dvtinh.Items.Add("Chai");
            cb_dvtinh.SelectedIndex = 0;
        }

        private void tsmi_goimon_Click(object sender, EventArgs e)
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

        private void tsmi_danggxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            dangnhap mainPage = new dangnhap();
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

        private void tsmi_qltk_Click(object sender, EventArgs e)
        {
            this.Hide();
            giolam mainPage = new giolam();
            mainPage.ShowDialog();
            this.Close();
        }

        private void tb_manl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_mamon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_tennl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void nud_slton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                e.Handled = true; 
            }
        }
    }
}
