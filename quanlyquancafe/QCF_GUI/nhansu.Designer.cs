namespace QCF_GUI
{
    partial class nhansu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nhansu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_trangchu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_qlsp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_qlnl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_qlgl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_qlns = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_baocao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_danggxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_tennv = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_luong = new System.Windows.Forms.GroupBox();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.lb_matkhau = new System.Windows.Forms.Label();
            this.tb_taikhoan = new System.Windows.Forms.TextBox();
            this.lb_taikhoan = new System.Windows.Forms.Label();
            this.tb_luong = new System.Windows.Forms.TextBox();
            this.cb_bophan = new System.Windows.Forms.ComboBox();
            this.lb_bophan = new System.Windows.Forms.Label();
            this.cb_trangthai = new System.Windows.Forms.ComboBox();
            this.lb_tthai = new System.Windows.Forms.Label();
            this.lb_luong = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.lb_gioitinh = new System.Windows.Forms.Label();
            this.dtp_ngsinh = new System.Windows.Forms.DateTimePicker();
            this.lb_ngsinh = new System.Windows.Forms.Label();
            this.tb_tennv = new System.Windows.Forms.TextBox();
            this.lb_tennv = new System.Windows.Forms.Label();
            this.tb_manv = new System.Windows.Forms.TextBox();
            this.lb_manv = new System.Windows.Forms.Label();
            this.gb_ttns = new System.Windows.Forms.GroupBox();
            this.bt_sua = new System.Windows.Forms.Button();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_tim = new System.Windows.Forms.Button();
            this.dgv_ns = new System.Windows.Forms.DataGridView();
            this.tb_tim = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.gb_luong.SuspendLayout();
            this.gb_ttns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ns)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_trangchu,
            this.tsmi_qlsp,
            this.tsmi_qlnl,
            this.tsmi_qlgl,
            this.tsmi_qlns,
            this.tsmi_baocao,
            this.tsmi_danggxuat,
            this.tsmi_tennv});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(220, 694);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "ms_qcf";
            // 
            // tsmi_trangchu
            // 
            this.tsmi_trangchu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsmi_trangchu.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.tsmi_trangchu.Name = "tsmi_trangchu";
            this.tsmi_trangchu.Size = new System.Drawing.Size(187, 27);
            this.tsmi_trangchu.Text = "Trang Chủ";
            this.tsmi_trangchu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmi_trangchu.Click += new System.EventHandler(this.tsmi_goimon_Click);
            // 
            // tsmi_qlsp
            // 
            this.tsmi_qlsp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsmi_qlsp.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.tsmi_qlsp.Name = "tsmi_qlsp";
            this.tsmi_qlsp.Size = new System.Drawing.Size(187, 27);
            this.tsmi_qlsp.Text = "Quản Lý Sản Phẩm";
            this.tsmi_qlsp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmi_qlsp.Click += new System.EventHandler(this.tsmi_qlsp_Click);
            // 
            // tsmi_qlnl
            // 
            this.tsmi_qlnl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsmi_qlnl.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.tsmi_qlnl.Name = "tsmi_qlnl";
            this.tsmi_qlnl.Size = new System.Drawing.Size(187, 27);
            this.tsmi_qlnl.Text = "Quản Lý Nguyên Liệu";
            this.tsmi_qlnl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmi_qlnl.Click += new System.EventHandler(this.tsmi_qlnl_Click);
            // 
            // tsmi_qlgl
            // 
            this.tsmi_qlgl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsmi_qlgl.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.tsmi_qlgl.Name = "tsmi_qlgl";
            this.tsmi_qlgl.Size = new System.Drawing.Size(187, 27);
            this.tsmi_qlgl.Text = "Quản Lý Giờ Làm";
            this.tsmi_qlgl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmi_qlgl.Click += new System.EventHandler(this.tsmi_qltk_Click);
            // 
            // tsmi_qlns
            // 
            this.tsmi_qlns.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsmi_qlns.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.tsmi_qlns.Name = "tsmi_qlns";
            this.tsmi_qlns.Size = new System.Drawing.Size(187, 27);
            this.tsmi_qlns.Text = "Quản Lý Nhân Sự";
            this.tsmi_qlns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsmi_baocao
            // 
            this.tsmi_baocao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsmi_baocao.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.tsmi_baocao.Name = "tsmi_baocao";
            this.tsmi_baocao.Size = new System.Drawing.Size(187, 27);
            this.tsmi_baocao.Text = "Báo Cáo";
            this.tsmi_baocao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmi_baocao.Click += new System.EventHandler(this.tsmi_baocao_Click);
            // 
            // tsmi_danggxuat
            // 
            this.tsmi_danggxuat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmi_danggxuat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsmi_danggxuat.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.tsmi_danggxuat.Name = "tsmi_danggxuat";
            this.tsmi_danggxuat.Size = new System.Drawing.Size(167, 27);
            this.tsmi_danggxuat.Text = "Đăng Xuất";
            this.tsmi_danggxuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmi_danggxuat.Click += new System.EventHandler(this.tsmi_danggxuat_Click);
            // 
            // tsmi_tennv
            // 
            this.tsmi_tennv.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmi_tennv.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsmi_tennv.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.tsmi_tennv.Name = "tsmi_tennv";
            this.tsmi_tennv.ShowShortcutKeys = false;
            this.tsmi_tennv.Size = new System.Drawing.Size(167, 21);
            this.tsmi_tennv.Text = "tennhanvien";
            this.tsmi_tennv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gb_luong
            // 
            this.gb_luong.Controls.Add(this.tb_matkhau);
            this.gb_luong.Controls.Add(this.lb_matkhau);
            this.gb_luong.Controls.Add(this.tb_taikhoan);
            this.gb_luong.Controls.Add(this.lb_taikhoan);
            this.gb_luong.Controls.Add(this.tb_luong);
            this.gb_luong.Controls.Add(this.cb_bophan);
            this.gb_luong.Controls.Add(this.lb_bophan);
            this.gb_luong.Controls.Add(this.cb_trangthai);
            this.gb_luong.Controls.Add(this.lb_tthai);
            this.gb_luong.Controls.Add(this.lb_luong);
            this.gb_luong.Controls.Add(this.tb_sdt);
            this.gb_luong.Controls.Add(this.lb_sdt);
            this.gb_luong.Controls.Add(this.tb_email);
            this.gb_luong.Controls.Add(this.lb_email);
            this.gb_luong.Controls.Add(this.rb_nu);
            this.gb_luong.Controls.Add(this.rb_nam);
            this.gb_luong.Controls.Add(this.lb_gioitinh);
            this.gb_luong.Controls.Add(this.dtp_ngsinh);
            this.gb_luong.Controls.Add(this.lb_ngsinh);
            this.gb_luong.Controls.Add(this.tb_tennv);
            this.gb_luong.Controls.Add(this.lb_tennv);
            this.gb_luong.Controls.Add(this.tb_manv);
            this.gb_luong.Controls.Add(this.lb_manv);
            this.gb_luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gb_luong.Location = new System.Drawing.Point(1045, 12);
            this.gb_luong.Name = "gb_luong";
            this.gb_luong.Size = new System.Drawing.Size(442, 603);
            this.gb_luong.TabIndex = 5;
            this.gb_luong.TabStop = false;
            this.gb_luong.Text = "Chi Tiết Nhân Sự";
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Location = new System.Drawing.Point(197, 550);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(195, 24);
            this.tb_matkhau.TabIndex = 29;
            this.tb_matkhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_matkhau_KeyPress);
            // 
            // lb_matkhau
            // 
            this.lb_matkhau.AutoSize = true;
            this.lb_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_matkhau.Location = new System.Drawing.Point(35, 553);
            this.lb_matkhau.Name = "lb_matkhau";
            this.lb_matkhau.Size = new System.Drawing.Size(94, 18);
            this.lb_matkhau.TabIndex = 28;
            this.lb_matkhau.Text = "Mật Khẩu : ";
            // 
            // tb_taikhoan
            // 
            this.tb_taikhoan.Location = new System.Drawing.Point(197, 490);
            this.tb_taikhoan.Name = "tb_taikhoan";
            this.tb_taikhoan.Size = new System.Drawing.Size(195, 24);
            this.tb_taikhoan.TabIndex = 27;
            this.tb_taikhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_taikhoan_KeyPress);
            // 
            // lb_taikhoan
            // 
            this.lb_taikhoan.AutoSize = true;
            this.lb_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_taikhoan.Location = new System.Drawing.Point(35, 493);
            this.lb_taikhoan.Name = "lb_taikhoan";
            this.lb_taikhoan.Size = new System.Drawing.Size(99, 18);
            this.lb_taikhoan.TabIndex = 26;
            this.lb_taikhoan.Text = "Tài Khoản : ";
            // 
            // tb_luong
            // 
            this.tb_luong.Location = new System.Drawing.Point(198, 333);
            this.tb_luong.Name = "tb_luong";
            this.tb_luong.Size = new System.Drawing.Size(195, 24);
            this.tb_luong.TabIndex = 25;
            this.tb_luong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_luong_KeyPress);
            // 
            // cb_bophan
            // 
            this.cb_bophan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_bophan.FormattingEnabled = true;
            this.cb_bophan.Location = new System.Drawing.Point(198, 435);
            this.cb_bophan.Name = "cb_bophan";
            this.cb_bophan.Size = new System.Drawing.Size(195, 26);
            this.cb_bophan.TabIndex = 24;
            // 
            // lb_bophan
            // 
            this.lb_bophan.AutoSize = true;
            this.lb_bophan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_bophan.Location = new System.Drawing.Point(36, 438);
            this.lb_bophan.Name = "lb_bophan";
            this.lb_bophan.Size = new System.Drawing.Size(87, 18);
            this.lb_bophan.TabIndex = 23;
            this.lb_bophan.Text = "Bộ Phận : ";
            // 
            // cb_trangthai
            // 
            this.cb_trangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_trangthai.FormattingEnabled = true;
            this.cb_trangthai.Location = new System.Drawing.Point(198, 387);
            this.cb_trangthai.Name = "cb_trangthai";
            this.cb_trangthai.Size = new System.Drawing.Size(195, 26);
            this.cb_trangthai.TabIndex = 18;
            // 
            // lb_tthai
            // 
            this.lb_tthai.AutoSize = true;
            this.lb_tthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_tthai.Location = new System.Drawing.Point(36, 390);
            this.lb_tthai.Name = "lb_tthai";
            this.lb_tthai.Size = new System.Drawing.Size(103, 18);
            this.lb_tthai.TabIndex = 17;
            this.lb_tthai.Text = "Trạng Thái : ";
            // 
            // lb_luong
            // 
            this.lb_luong.AutoSize = true;
            this.lb_luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_luong.Location = new System.Drawing.Point(40, 336);
            this.lb_luong.Name = "lb_luong";
            this.lb_luong.Size = new System.Drawing.Size(69, 18);
            this.lb_luong.TabIndex = 13;
            this.lb_luong.Text = "Lương : ";
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(202, 286);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(195, 24);
            this.tb_sdt.TabIndex = 12;
            this.tb_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_sdt_KeyPress);
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_sdt.Location = new System.Drawing.Point(40, 289);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(130, 18);
            this.lb_sdt.TabIndex = 11;
            this.lb_sdt.Text = "Số Điện Thoại : ";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(202, 241);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(195, 24);
            this.tb_email.TabIndex = 10;
            this.tb_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_email_KeyPress);
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_email.Location = new System.Drawing.Point(40, 244);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(65, 18);
            this.lb_email.TabIndex = 9;
            this.lb_email.Text = "Email : ";
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(295, 197);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(50, 22);
            this.rb_nu.TabIndex = 8;
            this.rb_nu.TabStop = true;
            this.rb_nu.Text = "Nữ";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Location = new System.Drawing.Point(202, 198);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(64, 22);
            this.rb_nam.TabIndex = 7;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // lb_gioitinh
            // 
            this.lb_gioitinh.AutoSize = true;
            this.lb_gioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_gioitinh.Location = new System.Drawing.Point(40, 201);
            this.lb_gioitinh.Name = "lb_gioitinh";
            this.lb_gioitinh.Size = new System.Drawing.Size(91, 18);
            this.lb_gioitinh.TabIndex = 6;
            this.lb_gioitinh.Text = "Giới Tính : ";
            // 
            // dtp_ngsinh
            // 
            this.dtp_ngsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_ngsinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngsinh.Location = new System.Drawing.Point(202, 150);
            this.dtp_ngsinh.Name = "dtp_ngsinh";
            this.dtp_ngsinh.Size = new System.Drawing.Size(195, 24);
            this.dtp_ngsinh.TabIndex = 5;
            // 
            // lb_ngsinh
            // 
            this.lb_ngsinh.AutoSize = true;
            this.lb_ngsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_ngsinh.Location = new System.Drawing.Point(40, 150);
            this.lb_ngsinh.Name = "lb_ngsinh";
            this.lb_ngsinh.Size = new System.Drawing.Size(99, 18);
            this.lb_ngsinh.TabIndex = 4;
            this.lb_ngsinh.Text = "Ngày Sinh : ";
            // 
            // tb_tennv
            // 
            this.tb_tennv.Location = new System.Drawing.Point(202, 98);
            this.tb_tennv.Name = "tb_tennv";
            this.tb_tennv.Size = new System.Drawing.Size(195, 24);
            this.tb_tennv.TabIndex = 3;
            this.tb_tennv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_tennv_KeyPress);
            // 
            // lb_tennv
            // 
            this.lb_tennv.AutoSize = true;
            this.lb_tennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_tennv.Location = new System.Drawing.Point(40, 101);
            this.lb_tennv.Name = "lb_tennv";
            this.lb_tennv.Size = new System.Drawing.Size(132, 18);
            this.lb_tennv.TabIndex = 2;
            this.lb_tennv.Text = "Tên Nhân Viên : ";
            // 
            // tb_manv
            // 
            this.tb_manv.Location = new System.Drawing.Point(202, 48);
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.Size = new System.Drawing.Size(195, 24);
            this.tb_manv.TabIndex = 1;
            this.tb_manv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_manv_KeyPress);
            // 
            // lb_manv
            // 
            this.lb_manv.AutoSize = true;
            this.lb_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_manv.Location = new System.Drawing.Point(40, 51);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(127, 18);
            this.lb_manv.TabIndex = 0;
            this.lb_manv.Text = "Mã Nhân Viên : ";
            // 
            // gb_ttns
            // 
            this.gb_ttns.Controls.Add(this.bt_sua);
            this.gb_ttns.Controls.Add(this.bt_them);
            this.gb_ttns.Controls.Add(this.bt_tim);
            this.gb_ttns.Controls.Add(this.dgv_ns);
            this.gb_ttns.Controls.Add(this.tb_tim);
            this.gb_ttns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gb_ttns.Location = new System.Drawing.Point(245, 12);
            this.gb_ttns.Name = "gb_ttns";
            this.gb_ttns.Size = new System.Drawing.Size(794, 670);
            this.gb_ttns.TabIndex = 4;
            this.gb_ttns.TabStop = false;
            this.gb_ttns.Text = "Thông Tin Nhân Sự";
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_sua.ImageKey = "edit.png";
            this.bt_sua.ImageList = this.icons;
            this.bt_sua.Location = new System.Drawing.Point(114, 37);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(91, 59);
            this.bt_sua.TabIndex = 84;
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "add.png");
            this.icons.Images.SetKeyName(1, "Delete-icon.png");
            this.icons.Images.SetKeyName(2, "edit.png");
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_them.ImageKey = "add.png";
            this.bt_them.ImageList = this.icons;
            this.bt_them.Location = new System.Drawing.Point(6, 37);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(91, 59);
            this.bt_them.TabIndex = 82;
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_tim
            // 
            this.bt_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_tim.Location = new System.Drawing.Point(678, 48);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(106, 40);
            this.bt_tim.TabIndex = 81;
            this.bt_tim.Text = "Tìm";
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // dgv_ns
            // 
            this.dgv_ns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ns.Location = new System.Drawing.Point(6, 116);
            this.dgv_ns.Name = "dgv_ns";
            this.dgv_ns.RowHeadersWidth = 51;
            this.dgv_ns.RowTemplate.Height = 24;
            this.dgv_ns.Size = new System.Drawing.Size(782, 548);
            this.dgv_ns.TabIndex = 0;
            this.dgv_ns.SelectionChanged += new System.EventHandler(this.dgv_ns_SelectionChanged);
            // 
            // tb_tim
            // 
            this.tb_tim.Location = new System.Drawing.Point(449, 48);
            this.tb_tim.Multiline = true;
            this.tb_tim.Name = "tb_tim";
            this.tb_tim.Size = new System.Drawing.Size(223, 40);
            this.tb_tim.TabIndex = 80;
            // 
            // nhansu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1494, 694);
            this.Controls.Add(this.gb_luong);
            this.Controls.Add(this.gb_ttns);
            this.Controls.Add(this.menuStrip1);
            this.Name = "nhansu";
            this.Text = "nhansu";
            this.Load += new System.EventHandler(this.nhansu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_luong.ResumeLayout(false);
            this.gb_luong.PerformLayout();
            this.gb_ttns.ResumeLayout(false);
            this.gb_ttns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_trangchu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_qlsp;
        private System.Windows.Forms.ToolStripMenuItem tsmi_qlnl;
        private System.Windows.Forms.ToolStripMenuItem tsmi_qlns;
        private System.Windows.Forms.ToolStripMenuItem tsmi_baocao;
        private System.Windows.Forms.ToolStripMenuItem tsmi_danggxuat;
        private System.Windows.Forms.GroupBox gb_luong;
        private System.Windows.Forms.Label lb_ngsinh;
        private System.Windows.Forms.TextBox tb_tennv;
        private System.Windows.Forms.Label lb_tennv;
        private System.Windows.Forms.TextBox tb_manv;
        private System.Windows.Forms.Label lb_manv;
        private System.Windows.Forms.GroupBox gb_ttns;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.DataGridView dgv_ns;
        private System.Windows.Forms.TextBox tb_tim;
        private System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.Label lb_gioitinh;
        private System.Windows.Forms.DateTimePicker dtp_ngsinh;
        private System.Windows.Forms.RadioButton rb_nam;
        private System.Windows.Forms.RadioButton rb_nu;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_luong;
        private System.Windows.Forms.ComboBox cb_trangthai;
        private System.Windows.Forms.Label lb_tthai;
        private System.Windows.Forms.ToolStripMenuItem tsmi_qlgl;
        private System.Windows.Forms.ComboBox cb_bophan;
        private System.Windows.Forms.Label lb_bophan;
        private System.Windows.Forms.TextBox tb_luong;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.Label lb_matkhau;
        private System.Windows.Forms.TextBox tb_taikhoan;
        private System.Windows.Forms.Label lb_taikhoan;
        private System.Windows.Forms.ToolStripMenuItem tsmi_tennv;
    }
}