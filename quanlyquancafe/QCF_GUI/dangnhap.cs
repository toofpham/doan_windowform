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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QCF_GUI
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                bt_login.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void bt_login_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_tk.Text) || string.IsNullOrWhiteSpace(tb_mk.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string username = tb_tk.Text.Trim();
            string password = tb_mk.Text.Trim();

            taikhoan_DTO tk = taikhoan_BUS.KiemTraDangNhap(username, password);

            if (tk != null)
            {
                taikhoan_DTO.TenNhanVienDangNhap = tk.TenNV;
                taikhoan_DTO.MaNV_DangNhap = tk.MaNV;

                if (tk.ViTri.Trim().Equals("Quản Lý", StringComparison.OrdinalIgnoreCase))
                    taikhoan_DTO.Role = "admin";
                else if (tk.ViTri.Trim().Equals("Pha Chế", StringComparison.OrdinalIgnoreCase) ||
                         tk.ViTri.Trim().Equals("Phục Vụ", StringComparison.OrdinalIgnoreCase) ||
                         tk.ViTri.Trim().Equals("Thu Ngân", StringComparison.OrdinalIgnoreCase))
                    taikhoan_DTO.Role = "user";
                else
                    taikhoan_DTO.Role = "user";


                this.Hide();
                trangchu mainPage = new trangchu(); 
                mainPage.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_tat_MouseEnter(object sender, EventArgs e)
        {
            bt_tat.BackColor = Color.Orange;
        }

        private void bt_tat_MouseLeave(object sender, EventArgs e)
        {
            bt_tat.BackColor = Color.White;
        }

        private void dangnhap_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Y <= 50)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0xA1, (IntPtr)0x2, IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Bạn có chắc chắn muốn thoát?",
        "Xác nhận thoát",
        MessageBoxButtons.OKCancel,
        MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }

}
