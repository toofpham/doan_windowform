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
    public partial class nhansu: Form
    {
        private nhansu_BUS bus = new nhansu_BUS();
        private nhansu_DTO selectedEmployee;
        public nhansu()
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
                nhansu_DTO nsMoi = new nhansu_DTO
                {
                    MaNV = int.Parse(tb_manv.Text),
                    TenNV = tb_tennv.Text,
                    NgaySinh = dtp_ngsinh .Value,
                    GioiTinh = rb_nam.Checked ? "Nam" : "Nữ",
                    Email = tb_email.Text,
                    SDT = tb_sdt.Text,
                    Luong = decimal.Parse(tb_luong.Text),
                    ViTri = cb_bophan.SelectedItem.ToString(),
                    TrangThai = cb_trangthai.SelectedItem.ToString(),
                    TenDangNhap=tb_taikhoan.Text,
                    MatKhau=tb_matkhau.Text
                };

                bus.ThemNhanSu(nsMoi);
                LoadNhanSu();
                MessageBox.Show("Thêm nhân sự thành công!");
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
                nhansu_DTO nsSua = new nhansu_DTO
                {
                    MaNV = int.Parse(tb_manv.Text),
                    TenNV = tb_tennv.Text,
                    NgaySinh = dtp_ngsinh.Value,
                    GioiTinh = rb_nam.Checked ? "Nam" : "Nữ",
                    Email = tb_email.Text,
                    SDT = tb_sdt.Text,
                    Luong = decimal.Parse(tb_luong.Text),
                    ViTri = cb_bophan.SelectedItem.ToString(),
                    TrangThai = cb_trangthai.SelectedItem.ToString(),
                    TenDangNhap = tb_taikhoan.Text,
                    MatKhau = tb_matkhau.Text

                };

                bus.SuaNhanSu(nsSua);
                LoadNhanSu();
                MessageBox.Show("Sửa nhân sự thành công!");
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
                List<nhansu_DTO> ketQuaTimKiem = bus.TimKiemNhanSu(keyword);
                if (ketQuaTimKiem.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhân sự nào.");
                }
                else
                {
                    dgv_ns.DataSource = null;
                    dgv_ns.DataSource = ketQuaTimKiem;
                    dgv_ns.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void nhansu_Load(object sender, EventArgs e)
        {
            LoadNhanSu();
            LoadTrangThai();
            LoadBoPhan();
        }
        private void LoadNhanSu()
        {
            try
            {
                List<nhansu_DTO> danhSachNhanSu = bus.GetDanhSachNhanSu();
                dgv_ns.AutoGenerateColumns = true;
                dgv_ns.DataSource = null;
                dgv_ns.DataSource = danhSachNhanSu;
                dgv_ns.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void LoadTrangThai()
        {
            cb_trangthai.Items.Add("Đang làm");
            cb_trangthai.Items.Add("Đã nghỉ");
            cb_trangthai.SelectedIndex = 0;
        }
        private void LoadBoPhan()
        {
            cb_bophan.Items.Add("Quản lý");
            cb_bophan.Items.Add("Phục Vụ");
            cb_bophan.Items.Add("Pha Chế");
            cb_bophan.Items.Add("Thu Ngân");
            cb_bophan.SelectedIndex = 0;  
        }

        private void dgv_ns_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_ns.SelectedRows.Count > 0)
            {
                int rowIndex = dgv_ns.SelectedCells[0].RowIndex;
                selectedEmployee = (nhansu_DTO)dgv_ns.Rows[rowIndex].DataBoundItem;

                tb_manv.Text = selectedEmployee.MaNV.ToString();
                tb_tennv.Text = selectedEmployee.TenNV;
                dtp_ngsinh.Value = selectedEmployee.NgaySinh;

                if (selectedEmployee.GioiTinh == "Nam")
                    rb_nam.Checked = true;
                else
                    rb_nu.Checked = true;

                tb_email.Text = selectedEmployee.Email;
                tb_sdt.Text = selectedEmployee.SDT;
                tb_luong.Text = selectedEmployee.Luong.ToString();
                cb_bophan.SelectedItem = selectedEmployee.ViTri;
                cb_trangthai.SelectedItem = selectedEmployee.TrangThai;
                tb_taikhoan.Text = selectedEmployee.TenDangNhap;
                tb_matkhau.Text = selectedEmployee.MatKhau;
            }
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

        private void tsmi_qlnl_Click(object sender, EventArgs e)
        {
            this.Hide();
            nguyenlieu mainPage = new nguyenlieu();
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

        private void tb_manv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void tb_tennv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != '_')
            {
                e.Handled = true;
            }
        }

        private void tb_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && tb_sdt.Text.Length >= 10)
            {
                e.Handled = true;
            }
        }

        private void tb_luong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true; 
            }

            if (e.KeyChar == '-')
            {
                e.Handled = true;
            }
        }

        private void tb_taikhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '_')
            {
                e.Handled = true;
            }
        }

        private void tb_matkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) &&
      e.KeyChar != '@' && e.KeyChar != '#' && e.KeyChar != '$' && e.KeyChar != '%')
            {
                e.Handled = true; 
            }
        }
    }
}
