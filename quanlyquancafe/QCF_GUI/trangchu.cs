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
using System.Globalization;

namespace QCF_GUI
{
    public partial class trangchu : Form
    {
        private Sanpham_BUS sanpham = new Sanpham_BUS();
        public trangchu()
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

        private void trangchu_Load(object sender, EventArgs e)
        {
            LoadMon();
            loadhoadon();
            SetupAutoCompleteMon();
        }

        private void loadhoadon()
        {
            dgv_mon.Columns.Add("MaMon", "Mã Món");
            dgv_mon.Columns.Add("TenMon", "Tên Món");
            dgv_mon.Columns.Add("SoLuong", "Số Lượng");
            dgv_mon.Columns.Add("DonGia", "Đơn Giá");
            dgv_mon.Columns.Add("ThanhTien", "Thành Tiền");

            dgv_mon.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            dgv_mon.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";

            dgv_mon.AllowUserToAddRows = false;
            dgv_mon.ReadOnly = true;
        }
        private void LoadMon()
        {
            flp_sanpham.Controls.Clear();
            flp_sanpham.Padding = new Padding(10);
            flp_sanpham.BackColor = Color.WhiteSmoke;
            flp_sanpham.AutoScroll = true;

            var dsMon = sanpham.GetDanhSachMonAn();
            foreach (var mon in dsMon)
            {
                Button btn = new Button();
                btn.Text = $"{mon.TenMon}\n{mon.Gia:N0} đ";
                btn.Width = 90;
                btn.Height = 90;
                btn.Tag = mon.MaMon;
                btn.BackColor = Color.LightBlue;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Font = new Font("Arial", 9, FontStyle.Bold);
                btn.ForeColor = Color.Black;
                btn.Click += bt_sp_Click;
                if (mon.TrangThai == "Hết hàng")
                {
                    btn.BackColor = Color.LightGray;
                    btn.Enabled = false;
                }
                else
                {
                    btn.BackColor = Color.LightBlue;
                    btn.Click += bt_sp_Click;

                }
                flp_sanpham.Controls.Add(btn);
            }
        }

        private void bt_sp_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int MaMon = (int)btn.Tag;

            var dsMon = sanpham.GetDanhSachMonAn();
            var monChon = dsMon.FirstOrDefault(m => m.MaMon == MaMon);

            if (monChon != null)
            {
                tb_tenmon.Text = monChon.TenMon;
                tb_gia.Text = monChon.Gia.ToString("N0");
                bt_them.Tag = monChon.MaMon;
            }
        }
        private void UpdateTotals()
        {
            decimal tongTien = 0;
            int tongSoLuong = 0;

            foreach (DataGridViewRow row in dgv_mon.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                {
                    tongTien += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                }
                if (row.Cells["SoLuong"].Value != null)
                {
                    tongSoLuong += Convert.ToInt32(row.Cells["SoLuong"].Value);
                }
            }

            lb_xuatttien.Text = tongTien.ToString("N0");
            lb_xuattsl.Text = tongSoLuong.ToString();
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            string tenMon = tb_tenmon.Text.Trim();
            string giaStr = tb_gia.Text.Replace(",", "").Trim();
            int soLuong = (int)nud_soluong.Value;

            if (bt_them.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn món ăn trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maMon = (int)bt_them.Tag;

            if (string.IsNullOrWhiteSpace(tenMon) || soLuong <= 0)
            {
                MessageBox.Show("Chưa thêm. Vui lòng chọn món và nhập số lượng hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(giaStr, out decimal donGia))
            {
                MessageBox.Show("Đơn giá không hợp lệ.");
                return;
            }

            foreach (DataGridViewRow row in dgv_mon.Rows)
            {
                if (row.Cells["TenMon"].Value?.ToString() == tenMon)
                {
                    MessageBox.Show("Món này đã được thêm.");
                    return;
                }
            }

            decimal thanhTien = donGia * soLuong;
            dgv_mon.Rows.Add(maMon, tenMon, soLuong, donGia.ToString("N0"), thanhTien.ToString("N0"));

            tb_tenmon.Clear();
            tb_gia.Clear();
            nud_soluong.Value = 1;

            UpdateTotals();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {

            if (dgv_mon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món ăn cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DataGridViewRow row = dgv_mon.SelectedRows[0];

            string tenMon = tb_tenmon.Text.Trim();
            string giaStr = tb_gia.Text.Replace(",", "").Trim();
            int soLuong = (int)nud_soluong.Value;


            if (string.IsNullOrWhiteSpace(tenMon) || soLuong <= 0)
            {
                MessageBox.Show("Chưa thêm. Vui lòng chọn món và nhập số lượng hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(giaStr, out decimal donGia))
            {
                MessageBox.Show("Đơn giá không hợp lệ.");
                return;
            }


            row.Cells["TenMon"].Value = tenMon;
            row.Cells["SoLuong"].Value = soLuong;
            row.Cells["DonGia"].Value = donGia.ToString("N0");
            row.Cells["ThanhTien"].Value = (donGia * soLuong).ToString("N0");


            tb_tenmon.Clear();
            tb_gia.Clear();
            nud_soluong.Value = 1;

            UpdateTotals();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {

            if (dgv_mon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món ăn cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DataGridViewRow row = dgv_mon.SelectedRows[0];


            dgv_mon.Rows.Remove(row);


            tb_tenmon.Clear();
            tb_gia.Clear();
            nud_soluong.Value = 1;
        }
        private void bt_huy_Click(object sender, EventArgs e)
        {

            dgv_mon.Rows.Clear();


            tb_tenmon.Clear();
            tb_gia.Clear();
            nud_soluong.Value = 1;

            bt_them.Tag = null;

            tb_tenmon.ReadOnly = false;
            tb_gia.ReadOnly = false;
        }

        private void dgv_mon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_mon.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_mon.SelectedRows[0];

                tb_tenmon.Text = row.Cells["TenMon"].Value.ToString();
                tb_gia.Text = row.Cells["DonGia"].Value.ToString();
                nud_soluong.Value = Convert.ToInt32(row.Cells["SoLuong"].Value);

                bt_them.Tag = row.Cells["MaMon"].Value;

                tb_tenmon.ReadOnly = true;
                tb_gia.ReadOnly = true;
            }
        }
        private void SetupAutoCompleteMon()
        {
            var dsMon = sanpham.GetDanhSachMonAn();

            AutoCompleteStringCollection monCollection = new AutoCompleteStringCollection();
            foreach (var mon in dsMon)
            {
                monCollection.Add(mon.TenMon);
            }

            cb_timkiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_timkiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cb_timkiem.AutoCompleteCustomSource = monCollection;

            cb_timkiem.Items.Clear();
            foreach (var mon in dsMon)
            {
                cb_timkiem.Items.Add(mon.TenMon);
            }
        }

        private void cb_timkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenMon = cb_timkiem.Text.Trim();
            var dsMon = sanpham.GetDanhSachMonAn();
            var monChon = dsMon.FirstOrDefault(m => m.TenMon == tenMon);

            if (monChon != null)
            {
                tb_tenmon.Text = monChon.TenMon;
                tb_gia.Text = monChon.Gia.ToString("N0");
                bt_them.Tag = monChon.MaMon;
            }
        }

        private void tsmi_qlsp_Click(object sender, EventArgs e)
        {
            this.Hide();
            sanpham mainPage = new sanpham();
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

        private void tsmi_qlnl_Click(object sender, EventArgs e)
        {
            this.Hide();
            nguyenlieu mainPage = new nguyenlieu();
            mainPage.ShowDialog();
            this.Close();
        }

        private void tsmi_caidat_Click(object sender, EventArgs e)
        {
            this.Hide();
            dangnhap mainPage = new dangnhap();
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

        private void bt_ttoan_Click(object sender, EventArgs e)
        {
            if (dgv_mon.Rows.Count == 0)
            {
                MessageBox.Show("Không có món nào để thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                hoadon_DTO hoadon = new hoadon_DTO
                {
                    MaNV = taikhoan_DTO.MaNV_DangNhap,
                    Ngay = DateTime.Now,
                    TongTien = dgv_mon.Rows.Cast<DataGridViewRow>()
                                .Sum(row => Convert.ToDecimal(row.Cells["ThanhTien"].Value.ToString().Replace(",", "")))
                };

                hoadon_BUS hoadonBus = new hoadon_BUS();
                int maHD = hoadonBus.ThemHoaDon(hoadon);

                cthoadon_BUS chiTietBus = new cthoadon_BUS();
                foreach (DataGridViewRow row in dgv_mon.Rows)
                {
                    cthoadon_DTO chiTiet = new cthoadon_DTO
                    {
                        MaHD = maHD,
                        MaMon = (int)row.Cells["MaMon"].Value,
                        SoLuong = (int)row.Cells["SoLuong"].Value,
                        DonGia = Convert.ToDecimal(row.Cells["DonGia"].Value.ToString().Replace(",", "")),
                    };
                    chiTietBus.ThemChiTietHoaDon(chiTiet);
                }

                string hoadonMessage = "         HÓA ĐƠN THANH TOÁN         \n";
                hoadonMessage += "------------------------------------\n";
                hoadonMessage += $"Mã Hóa Đơn     : {maHD}\n";
                hoadonMessage += $"Mã Nhân Viên   : {taikhoan_DTO.MaNV_DangNhap}\n";
                hoadonMessage += $"Tên Nhân Viên  : {taikhoan_DTO.TenNhanVienDangNhap}\n";
                hoadonMessage += "------------------------------------\n";

                CultureInfo culture = new CultureInfo("vi-VN");

                foreach (DataGridViewRow row in dgv_mon.Rows)
                {
                    if (row.IsNewRow) continue;

                    string tenMon = row.Cells["TenMon"].Value.ToString();
                    int soLuong = (int)row.Cells["SoLuong"].Value;
                    decimal donGia = Convert.ToDecimal(row.Cells["DonGia"].Value.ToString().Replace(",", ""));
                    decimal thanhTien = soLuong * donGia;

                    hoadonMessage += $"Món       : {tenMon}\n";
                    hoadonMessage += $"Số lượng : {soLuong}\n";
                    hoadonMessage += $"Đơn giá  : {donGia.ToString("c0", culture)}\n";
                    hoadonMessage += $"Thành tiền: {thanhTien.ToString("c0", culture)}\n";
                    hoadonMessage += "------------------------------------\n";
                }

                hoadonMessage += $"TỔNG TIỀN     : {hoadon.TongTien.ToString("c0", culture)}\n";
                hoadonMessage += "------------------------------------\n";
                hoadonMessage += $"Ngày thanh toán: {hoadon.Ngay.ToString("dd/MM/yyyy HH:mm:ss")}\n";
                hoadonMessage += "------------------------------------\n";
                hoadonMessage += "      CẢM ƠN QUÝ KHÁCH !!!!!       \n";



                MessageBox.Show(hoadonMessage, "Hóa Đơn Thanh Toán", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thanh toán: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nud_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                e.Handled = true;
            }
        }
    }
}