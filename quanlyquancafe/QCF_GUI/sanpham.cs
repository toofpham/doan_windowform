using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QCF_BUS;
using QCF_DTO;

namespace QCF_GUI
{
    public partial class sanpham : Form
    {
        private Sanpham_BUS bus = new Sanpham_BUS();
        private sanpham_DTO selectedProduct;
        public sanpham()
        {
            InitializeComponent();
            HienThiTenDangNhap();
        }
        private void HienThiTenDangNhap()
        {
            string tenNV = taikhoan_DTO.TenNhanVienDangNhap;
            tsmi_tennv.Text = $"Xin chào, {tenNV}!";
        }
        private void sanpham_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            LoadTrangThai();
        }

        private void LoadSanPham()
        {
            try
            {
                List<sanpham_DTO> danhSachMonAn = bus.GetDanhSachMonAn();
                dgv_sp.AutoGenerateColumns = true;
                dgv_sp.DataSource = null;
                dgv_sp.DataSource = danhSachMonAn;
                dgv_sp.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void LoadTrangThai()
        {
            cb_trangthai.Items.Add("Còn hàng");
            cb_trangthai.Items.Add("Hết hàng");
            cb_trangthai.SelectedIndex = 0;
        }

        private void dgv_sp_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_sp.SelectedRows.Count > 0)
            {
                int rowIndex = dgv_sp.SelectedCells[0].RowIndex;
                selectedProduct = (sanpham_DTO)dgv_sp.Rows[rowIndex].DataBoundItem;

                tb_masp.Text = selectedProduct.MaMon.ToString();
                tb_tensp.Text = selectedProduct.TenMon;
                tb_gia.Text = selectedProduct.Gia.ToString();
                tb_mota.Text = selectedProduct.MoTa;
                cb_trangthai.SelectedItem = selectedProduct.TrangThai;
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            try
            {
                sanpham_DTO spMoi = new sanpham_DTO
                {
                    MaMon = int.Parse(tb_masp.Text),
                    TenMon = tb_tensp.Text,
                    Gia = decimal.Parse(tb_gia.Text),
                    MoTa = tb_mota.Text,
                    TrangThai = cb_trangthai.SelectedItem.ToString()
                };

                bus.ThemSanPham(spMoi);
                LoadSanPham();
                MessageBox.Show("Thêm sản phẩm thành công!");
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
                int maMon = int.Parse(tb_masp.Text); 
                bus.XoaSanPham(maMon);
                LoadSanPham();
                MessageBox.Show("Xóa sản phẩm thành công!");
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
                sanpham_DTO spSua = new sanpham_DTO
                {
                    MaMon = int.Parse(tb_masp.Text), 
                    TenMon = tb_tensp.Text,
                    Gia = decimal.Parse(tb_gia.Text),
                    MoTa = tb_mota.Text,
                    TrangThai = cb_trangthai.SelectedItem.ToString()
                };

                bus.SuaSanPham(spSua);
                LoadSanPham();
                MessageBox.Show("Sửa sản phẩm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
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
                List<sanpham_DTO> ketQuaTimKiem = bus.TimKiemSanPham(keyword);
                if (ketQuaTimKiem.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm nào.");
                }
                else
                {
                    dgv_sp.DataSource = null;
                    dgv_sp.DataSource = ketQuaTimKiem;
                    dgv_sp.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void tsmi_qlnl_Click(object sender, EventArgs e)
        {
            this.Hide();
            nguyenlieu mainPage = new nguyenlieu();
            mainPage.ShowDialog();
            this.Close();
        }

        private void tsmi_goimon_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            trangchu mainPage = new trangchu();
            mainPage.ShowDialog();
            this.Close();
        }

        private void tsmi_danggxuat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            dangnhap mainPage = new dangnhap();
            mainPage.ShowDialog();
            this.Close();
        }

        private void tsmi_qlns_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            nhansu mainPage = new nhansu();
            mainPage.ShowDialog();
            this.Close();
        }

        private void tsmi_baocao_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            baocao mainPage = new baocao();
            mainPage.ShowDialog();
            this.Close();
        }

        private void tsmi_qlhl_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            giolam mainPage = new giolam();
            mainPage.ShowDialog();
            this.Close();
        }

        private void tb_masp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_tensp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void tb_gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void tb_mota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
