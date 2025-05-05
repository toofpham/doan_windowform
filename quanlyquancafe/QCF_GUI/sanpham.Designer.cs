namespace QCF_GUI
{
    partial class sanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sanpham));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_trangchu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_qlsp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_qlnl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_qlhl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_qlns = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_baocao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_danggxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_tennv = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_ttsp = new System.Windows.Forms.GroupBox();
            this.bt_sua = new System.Windows.Forms.Button();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_tim = new System.Windows.Forms.Button();
            this.dgv_sp = new System.Windows.Forms.DataGridView();
            this.tb_tim = new System.Windows.Forms.TextBox();
            this.gb_ctsp = new System.Windows.Forms.GroupBox();
            this.tb_masp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_gia = new System.Windows.Forms.TextBox();
            this.tb_mota = new System.Windows.Forms.TextBox();
            this.lb_mota = new System.Windows.Forms.Label();
            this.cb_trangthai = new System.Windows.Forms.ComboBox();
            this.lb_trangthai = new System.Windows.Forms.Label();
            this.lb_dongia = new System.Windows.Forms.Label();
            this.tb_tensp = new System.Windows.Forms.TextBox();
            this.lb_tensp = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gb_ttsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sp)).BeginInit();
            this.gb_ctsp.SuspendLayout();
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
            this.tsmi_qlhl,
            this.tsmi_qlns,
            this.tsmi_baocao,
            this.tsmi_danggxuat,
            this.tsmi_tennv});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(220, 623);
            this.menuStrip1.TabIndex = 1;
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
            this.tsmi_trangchu.Click += new System.EventHandler(this.tsmi_goimon_Click_1);
            // 
            // tsmi_qlsp
            // 
            this.tsmi_qlsp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsmi_qlsp.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.tsmi_qlsp.Name = "tsmi_qlsp";
            this.tsmi_qlsp.Size = new System.Drawing.Size(187, 27);
            this.tsmi_qlsp.Text = "Quản Lý Sản Phẩm";
            this.tsmi_qlsp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // tsmi_qlhl
            // 
            this.tsmi_qlhl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsmi_qlhl.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.tsmi_qlhl.Name = "tsmi_qlhl";
            this.tsmi_qlhl.Size = new System.Drawing.Size(187, 27);
            this.tsmi_qlhl.Text = "Quản Lý Giớ Làm";
            this.tsmi_qlhl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmi_qlhl.Click += new System.EventHandler(this.tsmi_qlhl_Click_1);
            // 
            // tsmi_qlns
            // 
            this.tsmi_qlns.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsmi_qlns.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.tsmi_qlns.Name = "tsmi_qlns";
            this.tsmi_qlns.Size = new System.Drawing.Size(187, 27);
            this.tsmi_qlns.Text = "Quản Lý Nhân Sự";
            this.tsmi_qlns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmi_qlns.Click += new System.EventHandler(this.tsmi_qlns_Click_1);
            // 
            // tsmi_baocao
            // 
            this.tsmi_baocao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsmi_baocao.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.tsmi_baocao.Name = "tsmi_baocao";
            this.tsmi_baocao.Size = new System.Drawing.Size(187, 27);
            this.tsmi_baocao.Text = "Báo Cáo";
            this.tsmi_baocao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmi_baocao.Click += new System.EventHandler(this.tsmi_baocao_Click_1);
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
            this.tsmi_danggxuat.Click += new System.EventHandler(this.tsmi_danggxuat_Click_1);
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
            // gb_ttsp
            // 
            this.gb_ttsp.Controls.Add(this.bt_sua);
            this.gb_ttsp.Controls.Add(this.bt_xoa);
            this.gb_ttsp.Controls.Add(this.bt_them);
            this.gb_ttsp.Controls.Add(this.bt_tim);
            this.gb_ttsp.Controls.Add(this.dgv_sp);
            this.gb_ttsp.Controls.Add(this.tb_tim);
            this.gb_ttsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gb_ttsp.Location = new System.Drawing.Point(245, 12);
            this.gb_ttsp.Name = "gb_ttsp";
            this.gb_ttsp.Size = new System.Drawing.Size(814, 599);
            this.gb_ttsp.TabIndex = 2;
            this.gb_ttsp.TabStop = false;
            this.gb_ttsp.Text = "Thông Tin Sản Phẩm";
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_sua.ImageKey = "edit.png";
            this.bt_sua.ImageList = this.icons;
            this.bt_sua.Location = new System.Drawing.Point(226, 38);
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
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_xoa.ImageKey = "Delete-icon.png";
            this.bt_xoa.ImageList = this.icons;
            this.bt_xoa.Location = new System.Drawing.Point(114, 38);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(91, 59);
            this.bt_xoa.TabIndex = 83;
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
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
            // dgv_sp
            // 
            this.dgv_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sp.Location = new System.Drawing.Point(6, 116);
            this.dgv_sp.Name = "dgv_sp";
            this.dgv_sp.RowHeadersWidth = 51;
            this.dgv_sp.RowTemplate.Height = 24;
            this.dgv_sp.Size = new System.Drawing.Size(802, 477);
            this.dgv_sp.TabIndex = 0;
            this.dgv_sp.SelectionChanged += new System.EventHandler(this.dgv_sp_SelectionChanged);
            // 
            // tb_tim
            // 
            this.tb_tim.Location = new System.Drawing.Point(449, 48);
            this.tb_tim.Multiline = true;
            this.tb_tim.Name = "tb_tim";
            this.tb_tim.Size = new System.Drawing.Size(223, 40);
            this.tb_tim.TabIndex = 80;
            // 
            // gb_ctsp
            // 
            this.gb_ctsp.Controls.Add(this.tb_masp);
            this.gb_ctsp.Controls.Add(this.label1);
            this.gb_ctsp.Controls.Add(this.tb_gia);
            this.gb_ctsp.Controls.Add(this.tb_mota);
            this.gb_ctsp.Controls.Add(this.lb_mota);
            this.gb_ctsp.Controls.Add(this.cb_trangthai);
            this.gb_ctsp.Controls.Add(this.lb_trangthai);
            this.gb_ctsp.Controls.Add(this.lb_dongia);
            this.gb_ctsp.Controls.Add(this.tb_tensp);
            this.gb_ctsp.Controls.Add(this.lb_tensp);
            this.gb_ctsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gb_ctsp.Location = new System.Drawing.Point(1065, 12);
            this.gb_ctsp.Name = "gb_ctsp";
            this.gb_ctsp.Size = new System.Drawing.Size(442, 414);
            this.gb_ctsp.TabIndex = 3;
            this.gb_ctsp.TabStop = false;
            this.gb_ctsp.Text = "Chi Tiết Sản Phẩm";
            // 
            // tb_masp
            // 
            this.tb_masp.Location = new System.Drawing.Point(211, 45);
            this.tb_masp.Name = "tb_masp";
            this.tb_masp.Size = new System.Drawing.Size(195, 24);
            this.tb_masp.TabIndex = 14;
            this.tb_masp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_masp_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(44, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã Sản Phẩm : ";
            // 
            // tb_gia
            // 
            this.tb_gia.Location = new System.Drawing.Point(211, 145);
            this.tb_gia.Name = "tb_gia";
            this.tb_gia.Size = new System.Drawing.Size(195, 24);
            this.tb_gia.TabIndex = 12;
            this.tb_gia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_gia_KeyPress);
            // 
            // tb_mota
            // 
            this.tb_mota.Location = new System.Drawing.Point(211, 259);
            this.tb_mota.Multiline = true;
            this.tb_mota.Name = "tb_mota";
            this.tb_mota.Size = new System.Drawing.Size(195, 97);
            this.tb_mota.TabIndex = 11;
            this.tb_mota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_mota_KeyPress);
            // 
            // lb_mota
            // 
            this.lb_mota.AutoSize = true;
            this.lb_mota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_mota.Location = new System.Drawing.Point(44, 262);
            this.lb_mota.Name = "lb_mota";
            this.lb_mota.Size = new System.Drawing.Size(66, 18);
            this.lb_mota.TabIndex = 10;
            this.lb_mota.Text = "Mô Tả :";
            // 
            // cb_trangthai
            // 
            this.cb_trangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_trangthai.FormattingEnabled = true;
            this.cb_trangthai.Location = new System.Drawing.Point(211, 198);
            this.cb_trangthai.Name = "cb_trangthai";
            this.cb_trangthai.Size = new System.Drawing.Size(195, 26);
            this.cb_trangthai.TabIndex = 9;
            // 
            // lb_trangthai
            // 
            this.lb_trangthai.AutoSize = true;
            this.lb_trangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_trangthai.Location = new System.Drawing.Point(44, 201);
            this.lb_trangthai.Name = "lb_trangthai";
            this.lb_trangthai.Size = new System.Drawing.Size(103, 18);
            this.lb_trangthai.TabIndex = 8;
            this.lb_trangthai.Text = "Trạng Thái : ";
            // 
            // lb_dongia
            // 
            this.lb_dongia.AutoSize = true;
            this.lb_dongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_dongia.Location = new System.Drawing.Point(44, 145);
            this.lb_dongia.Name = "lb_dongia";
            this.lb_dongia.Size = new System.Drawing.Size(85, 18);
            this.lb_dongia.TabIndex = 4;
            this.lb_dongia.Text = "Đơn Giá : ";
            // 
            // tb_tensp
            // 
            this.tb_tensp.Location = new System.Drawing.Point(211, 94);
            this.tb_tensp.Name = "tb_tensp";
            this.tb_tensp.Size = new System.Drawing.Size(195, 24);
            this.tb_tensp.TabIndex = 3;
            this.tb_tensp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_tensp_KeyPress);
            // 
            // lb_tensp
            // 
            this.lb_tensp.AutoSize = true;
            this.lb_tensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_tensp.Location = new System.Drawing.Point(44, 97);
            this.lb_tensp.Name = "lb_tensp";
            this.lb_tensp.Size = new System.Drawing.Size(133, 18);
            this.lb_tensp.TabIndex = 2;
            this.lb_tensp.Text = "Tên Sản Phẩm : ";
            // 
            // sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1515, 623);
            this.Controls.Add(this.gb_ctsp);
            this.Controls.Add(this.gb_ttsp);
            this.Controls.Add(this.menuStrip1);
            this.Name = "sanpham";
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.sanpham_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_ttsp.ResumeLayout(false);
            this.gb_ttsp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sp)).EndInit();
            this.gb_ctsp.ResumeLayout(false);
            this.gb_ctsp.PerformLayout();
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
        private System.Windows.Forms.GroupBox gb_ttsp;
        private System.Windows.Forms.GroupBox gb_ctsp;
        private System.Windows.Forms.DataGridView dgv_sp;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.TextBox tb_tim;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.Label lb_dongia;
        private System.Windows.Forms.TextBox tb_tensp;
        private System.Windows.Forms.Label lb_tensp;
        private System.Windows.Forms.Label lb_trangthai;
        private System.Windows.Forms.ToolStripMenuItem tsmi_qlhl;
        private System.Windows.Forms.TextBox tb_mota;
        private System.Windows.Forms.Label lb_mota;
        private System.Windows.Forms.ComboBox cb_trangthai;
        private System.Windows.Forms.TextBox tb_gia;
        private System.Windows.Forms.TextBox tb_masp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_tennv;
    }
}