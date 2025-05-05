namespace QCF_GUI
{
    partial class trangchu
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
            this.ms_menu = new System.Windows.Forms.MenuStrip();
            this.tsmi_trangchu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_qlsp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_qlnl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_qlgl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_qlns = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_dangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_baocao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_tennv = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_mon = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_timkiem = new System.Windows.Forms.ComboBox();
            this.bt_huy = new System.Windows.Forms.Button();
            this.lb_xuatttien = new System.Windows.Forms.Label();
            this.lb_xuattsl = new System.Windows.Forms.Label();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_ttoan = new System.Windows.Forms.Button();
            this.lb_timkiem = new System.Windows.Forms.Label();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.nud_soluong = new System.Windows.Forms.NumericUpDown();
            this.lb_soluong = new System.Windows.Forms.Label();
            this.tb_gia = new System.Windows.Forms.TextBox();
            this.lb_gia = new System.Windows.Forms.Label();
            this.tb_tenmon = new System.Windows.Forms.TextBox();
            this.lb_tenmon = new System.Windows.Forms.Label();
            this.dgv_mon = new System.Windows.Forms.DataGridView();
            this.flp_sanpham = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_sp = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ms_menu.SuspendLayout();
            this.gb_mon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mon)).BeginInit();
            this.flp_sanpham.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_menu
            // 
            this.ms_menu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ms_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.ms_menu.GripMargin = new System.Windows.Forms.Padding(0);
            this.ms_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_trangchu,
            this.tsmi_qlsp,
            this.tsmi_qlnl,
            this.tsmi_qlgl,
            this.tsmi_qlns,
            this.tsmi_dangxuat,
            this.tsmi_baocao,
            this.tsmi_tennv});
            this.ms_menu.Location = new System.Drawing.Point(0, 0);
            this.ms_menu.Name = "ms_menu";
            this.ms_menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ms_menu.Size = new System.Drawing.Size(220, 672);
            this.ms_menu.TabIndex = 0;
            this.ms_menu.Text = "ms_qcf";
            // 
            // tsmi_trangchu
            // 
            this.tsmi_trangchu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsmi_trangchu.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.tsmi_trangchu.Name = "tsmi_trangchu";
            this.tsmi_trangchu.Size = new System.Drawing.Size(187, 27);
            this.tsmi_trangchu.Text = "Trang Chủ";
            this.tsmi_trangchu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tsmi_qlgl.Click += new System.EventHandler(this.tsmi_qlgl_Click);
            // 
            // tsmi_qlns
            // 
            this.tsmi_qlns.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsmi_qlns.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.tsmi_qlns.Name = "tsmi_qlns";
            this.tsmi_qlns.Size = new System.Drawing.Size(187, 27);
            this.tsmi_qlns.Text = "Quản Lý Nhân Sự";
            this.tsmi_qlns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmi_qlns.Click += new System.EventHandler(this.tsmi_qlns_Click);
            // 
            // tsmi_dangxuat
            // 
            this.tsmi_dangxuat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmi_dangxuat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsmi_dangxuat.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.tsmi_dangxuat.Name = "tsmi_dangxuat";
            this.tsmi_dangxuat.Size = new System.Drawing.Size(167, 27);
            this.tsmi_dangxuat.Text = "Đăng Xuất";
            this.tsmi_dangxuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmi_dangxuat.Click += new System.EventHandler(this.tsmi_caidat_Click);
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
            // gb_mon
            // 
            this.gb_mon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_mon.Controls.Add(this.label2);
            this.gb_mon.Controls.Add(this.label1);
            this.gb_mon.Controls.Add(this.cb_timkiem);
            this.gb_mon.Controls.Add(this.bt_huy);
            this.gb_mon.Controls.Add(this.lb_xuatttien);
            this.gb_mon.Controls.Add(this.lb_xuattsl);
            this.gb_mon.Controls.Add(this.bt_sua);
            this.gb_mon.Controls.Add(this.bt_them);
            this.gb_mon.Controls.Add(this.bt_ttoan);
            this.gb_mon.Controls.Add(this.lb_timkiem);
            this.gb_mon.Controls.Add(this.bt_xoa);
            this.gb_mon.Controls.Add(this.nud_soluong);
            this.gb_mon.Controls.Add(this.lb_soluong);
            this.gb_mon.Controls.Add(this.tb_gia);
            this.gb_mon.Controls.Add(this.lb_gia);
            this.gb_mon.Controls.Add(this.tb_tenmon);
            this.gb_mon.Controls.Add(this.lb_tenmon);
            this.gb_mon.Controls.Add(this.dgv_mon);
            this.gb_mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gb_mon.Location = new System.Drawing.Point(242, 12);
            this.gb_mon.Name = "gb_mon";
            this.gb_mon.Size = new System.Drawing.Size(878, 648);
            this.gb_mon.TabIndex = 2;
            this.gb_mon.TabStop = false;
            this.gb_mon.Text = "Thông Tin Món";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(469, 605);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 95;
            this.label2.Text = "Tổng Tiền : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(469, 570);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 94;
            this.label1.Text = "Tổng Số Lượng :";
            // 
            // cb_timkiem
            // 
            this.cb_timkiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_timkiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_timkiem.FormattingEnabled = true;
            this.cb_timkiem.Location = new System.Drawing.Point(523, 79);
            this.cb_timkiem.Name = "cb_timkiem";
            this.cb_timkiem.Size = new System.Drawing.Size(206, 26);
            this.cb_timkiem.TabIndex = 93;
            this.cb_timkiem.SelectedIndexChanged += new System.EventHandler(this.cb_timkiem_SelectedIndexChanged);
            // 
            // bt_huy
            // 
            this.bt_huy.BackColor = System.Drawing.Color.LightSalmon;
            this.bt_huy.Location = new System.Drawing.Point(787, 416);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(85, 112);
            this.bt_huy.TabIndex = 92;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = false;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // lb_xuatttien
            // 
            this.lb_xuatttien.AutoSize = true;
            this.lb_xuatttien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_xuatttien.Location = new System.Drawing.Point(633, 605);
            this.lb_xuatttien.Name = "lb_xuatttien";
            this.lb_xuatttien.Size = new System.Drawing.Size(19, 20);
            this.lb_xuatttien.TabIndex = 91;
            this.lb_xuatttien.Text = "0";
            // 
            // lb_xuattsl
            // 
            this.lb_xuattsl.AutoSize = true;
            this.lb_xuattsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_xuattsl.Location = new System.Drawing.Point(633, 570);
            this.lb_xuattsl.Name = "lb_xuattsl";
            this.lb_xuattsl.Size = new System.Drawing.Size(19, 20);
            this.lb_xuattsl.TabIndex = 90;
            this.lb_xuattsl.Text = "0";
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.LightSalmon;
            this.bt_sua.Location = new System.Drawing.Point(787, 23);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(85, 139);
            this.bt_sua.TabIndex = 87;
            this.bt_sua.Text = "Sửa số lượng";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.LightSalmon;
            this.bt_them.Location = new System.Drawing.Point(787, 291);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(85, 119);
            this.bt_them.TabIndex = 86;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_ttoan
            // 
            this.bt_ttoan.BackColor = System.Drawing.Color.LightSalmon;
            this.bt_ttoan.Location = new System.Drawing.Point(787, 534);
            this.bt_ttoan.Name = "bt_ttoan";
            this.bt_ttoan.Size = new System.Drawing.Size(85, 108);
            this.bt_ttoan.TabIndex = 85;
            this.bt_ttoan.Text = "Thanh Toán";
            this.bt_ttoan.UseVisualStyleBackColor = false;
            this.bt_ttoan.Click += new System.EventHandler(this.bt_ttoan_Click);
            // 
            // lb_timkiem
            // 
            this.lb_timkiem.AutoSize = true;
            this.lb_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_timkiem.Location = new System.Drawing.Point(424, 82);
            this.lb_timkiem.Name = "lb_timkiem";
            this.lb_timkiem.Size = new System.Drawing.Size(83, 18);
            this.lb_timkiem.TabIndex = 78;
            this.lb_timkiem.Text = "Tìm Kiếm : ";
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.LightSalmon;
            this.bt_xoa.Location = new System.Drawing.Point(785, 168);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(85, 117);
            this.bt_xoa.TabIndex = 17;
            this.bt_xoa.Text = "Xóa dòng";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // nud_soluong
            // 
            this.nud_soluong.Location = new System.Drawing.Point(523, 39);
            this.nud_soluong.Name = "nud_soluong";
            this.nud_soluong.Size = new System.Drawing.Size(127, 24);
            this.nud_soluong.TabIndex = 75;
            this.nud_soluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_soluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nud_soluong_KeyPress);
            // 
            // lb_soluong
            // 
            this.lb_soluong.AutoSize = true;
            this.lb_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_soluong.Location = new System.Drawing.Point(424, 41);
            this.lb_soluong.Name = "lb_soluong";
            this.lb_soluong.Size = new System.Drawing.Size(79, 18);
            this.lb_soluong.TabIndex = 74;
            this.lb_soluong.Text = "Số lượng : ";
            // 
            // tb_gia
            // 
            this.tb_gia.Location = new System.Drawing.Point(119, 82);
            this.tb_gia.Name = "tb_gia";
            this.tb_gia.Size = new System.Drawing.Size(177, 24);
            this.tb_gia.TabIndex = 71;
            // 
            // lb_gia
            // 
            this.lb_gia.AutoSize = true;
            this.lb_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_gia.Location = new System.Drawing.Point(38, 85);
            this.lb_gia.Name = "lb_gia";
            this.lb_gia.Size = new System.Drawing.Size(71, 18);
            this.lb_gia.TabIndex = 72;
            this.lb_gia.Text = "Đơn giá : ";
            // 
            // tb_tenmon
            // 
            this.tb_tenmon.Location = new System.Drawing.Point(119, 41);
            this.tb_tenmon.Name = "tb_tenmon";
            this.tb_tenmon.Size = new System.Drawing.Size(177, 24);
            this.tb_tenmon.TabIndex = 17;
            // 
            // lb_tenmon
            // 
            this.lb_tenmon.AutoSize = true;
            this.lb_tenmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_tenmon.Location = new System.Drawing.Point(38, 44);
            this.lb_tenmon.Name = "lb_tenmon";
            this.lb_tenmon.Size = new System.Drawing.Size(79, 18);
            this.lb_tenmon.TabIndex = 18;
            this.lb_tenmon.Text = "Tên Món : ";
            // 
            // dgv_mon
            // 
            this.dgv_mon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mon.Location = new System.Drawing.Point(15, 124);
            this.dgv_mon.Name = "dgv_mon";
            this.dgv_mon.RowHeadersWidth = 51;
            this.dgv_mon.RowTemplate.Height = 24;
            this.dgv_mon.Size = new System.Drawing.Size(764, 415);
            this.dgv_mon.TabIndex = 53;
            this.dgv_mon.SelectionChanged += new System.EventHandler(this.dgv_mon_SelectionChanged);
            // 
            // flp_sanpham
            // 
            this.flp_sanpham.Controls.Add(this.bt_sp);
            this.flp_sanpham.Location = new System.Drawing.Point(1126, 21);
            this.flp_sanpham.Name = "flp_sanpham";
            this.flp_sanpham.Size = new System.Drawing.Size(393, 639);
            this.flp_sanpham.TabIndex = 3;
            // 
            // bt_sp
            // 
            this.bt_sp.Location = new System.Drawing.Point(3, 3);
            this.bt_sp.Name = "bt_sp";
            this.bt_sp.Size = new System.Drawing.Size(100, 74);
            this.bt_sp.TabIndex = 0;
            this.bt_sp.Text = "button1";
            this.bt_sp.UseVisualStyleBackColor = true;
            this.bt_sp.Click += new System.EventHandler(this.bt_sp_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1537, 672);
            this.Controls.Add(this.flp_sanpham);
            this.Controls.Add(this.gb_mon);
            this.Controls.Add(this.ms_menu);
            this.MainMenuStrip = this.ms_menu;
            this.Name = "trangchu";
            this.Text = "home";
            this.Load += new System.EventHandler(this.trangchu_Load);
            this.ms_menu.ResumeLayout(false);
            this.ms_menu.PerformLayout();
            this.gb_mon.ResumeLayout(false);
            this.gb_mon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mon)).EndInit();
            this.flp_sanpham.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_menu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_qlsp;
        private System.Windows.Forms.ToolStripMenuItem tsmi_qlns;
        private System.Windows.Forms.ToolStripMenuItem tsmi_baocao;
        private System.Windows.Forms.ToolStripMenuItem tsmi_dangxuat;
        private System.Windows.Forms.GroupBox gb_mon;
        private System.Windows.Forms.DataGridView dgv_mon;
        private System.Windows.Forms.Label lb_soluong;
        private System.Windows.Forms.TextBox tb_gia;
        private System.Windows.Forms.Label lb_gia;
        private System.Windows.Forms.TextBox tb_tenmon;
        private System.Windows.Forms.Label lb_tenmon;
        private System.Windows.Forms.NumericUpDown nud_soluong;
        private System.Windows.Forms.Label lb_timkiem;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_ttoan;
        private System.Windows.Forms.Label lb_xuatttien;
        private System.Windows.Forms.Label lb_xuattsl;
        private System.Windows.Forms.ToolStripMenuItem tsmi_qlnl;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.ToolStripMenuItem tsmi_qlgl;
        private System.Windows.Forms.ToolStripMenuItem tsmi_trangchu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_tennv;
        private System.Windows.Forms.FlowLayoutPanel flp_sanpham;
        private System.Windows.Forms.Button bt_sp;
        private System.Windows.Forms.ComboBox cb_timkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}