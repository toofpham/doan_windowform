namespace QCF_GUI
{
    partial class nguyenlieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nguyenlieu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_trangchu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_qlsp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_qlnl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_qlgl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_qlns = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_baocao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_danggxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_tennv = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_ctnl = new System.Windows.Forms.GroupBox();
            this.tb_mamon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_manl = new System.Windows.Forms.TextBox();
            this.lb_manl = new System.Windows.Forms.Label();
            this.cb_dvtinh = new System.Windows.Forms.ComboBox();
            this.lb_dvtinh = new System.Windows.Forms.Label();
            this.nud_slton = new System.Windows.Forms.NumericUpDown();
            this.lb_slton = new System.Windows.Forms.Label();
            this.tb_tennl = new System.Windows.Forms.TextBox();
            this.lb_tennl = new System.Windows.Forms.Label();
            this.gb_ttnl = new System.Windows.Forms.GroupBox();
            this.bt_sua = new System.Windows.Forms.Button();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_tim = new System.Windows.Forms.Button();
            this.dgv_nl = new System.Windows.Forms.DataGridView();
            this.tb_tim = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.gb_ctnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_slton)).BeginInit();
            this.gb_ttnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nl)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(220, 530);
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
            this.tsmi_qlns.Click += new System.EventHandler(this.tsmi_qlns_Click);
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
            // gb_ctnl
            // 
            this.gb_ctnl.Controls.Add(this.tb_mamon);
            this.gb_ctnl.Controls.Add(this.label1);
            this.gb_ctnl.Controls.Add(this.tb_manl);
            this.gb_ctnl.Controls.Add(this.lb_manl);
            this.gb_ctnl.Controls.Add(this.cb_dvtinh);
            this.gb_ctnl.Controls.Add(this.lb_dvtinh);
            this.gb_ctnl.Controls.Add(this.nud_slton);
            this.gb_ctnl.Controls.Add(this.lb_slton);
            this.gb_ctnl.Controls.Add(this.tb_tennl);
            this.gb_ctnl.Controls.Add(this.lb_tennl);
            this.gb_ctnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gb_ctnl.Location = new System.Drawing.Point(949, 12);
            this.gb_ctnl.Name = "gb_ctnl";
            this.gb_ctnl.Size = new System.Drawing.Size(416, 397);
            this.gb_ctnl.TabIndex = 5;
            this.gb_ctnl.TabStop = false;
            this.gb_ctnl.Text = "Chi Tiết Nguyên Liệu";
            // 
            // tb_mamon
            // 
            this.tb_mamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_mamon.Location = new System.Drawing.Point(188, 116);
            this.tb_mamon.Name = "tb_mamon";
            this.tb_mamon.Size = new System.Drawing.Size(195, 24);
            this.tb_mamon.TabIndex = 11;
            this.tb_mamon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_mamon_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(20, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Món : ";
            // 
            // tb_manl
            // 
            this.tb_manl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_manl.Location = new System.Drawing.Point(188, 57);
            this.tb_manl.Name = "tb_manl";
            this.tb_manl.Size = new System.Drawing.Size(195, 24);
            this.tb_manl.TabIndex = 9;
            this.tb_manl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_manl_KeyPress);
            // 
            // lb_manl
            // 
            this.lb_manl.AutoSize = true;
            this.lb_manl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_manl.Location = new System.Drawing.Point(20, 57);
            this.lb_manl.Name = "lb_manl";
            this.lb_manl.Size = new System.Drawing.Size(162, 20);
            this.lb_manl.TabIndex = 8;
            this.lb_manl.Text = "Mã Nguyên Liệu : ";
            // 
            // cb_dvtinh
            // 
            this.cb_dvtinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dvtinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_dvtinh.FormattingEnabled = true;
            this.cb_dvtinh.Location = new System.Drawing.Point(188, 318);
            this.cb_dvtinh.Name = "cb_dvtinh";
            this.cb_dvtinh.Size = new System.Drawing.Size(195, 26);
            this.cb_dvtinh.TabIndex = 7;
            // 
            // lb_dvtinh
            // 
            this.lb_dvtinh.AutoSize = true;
            this.lb_dvtinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_dvtinh.Location = new System.Drawing.Point(20, 318);
            this.lb_dvtinh.Name = "lb_dvtinh";
            this.lb_dvtinh.Size = new System.Drawing.Size(125, 20);
            this.lb_dvtinh.TabIndex = 6;
            this.lb_dvtinh.Text = "Đơn Vị Tính : ";
            // 
            // nud_slton
            // 
            this.nud_slton.DecimalPlaces = 1;
            this.nud_slton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nud_slton.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_slton.Location = new System.Drawing.Point(188, 249);
            this.nud_slton.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_slton.Name = "nud_slton";
            this.nud_slton.Size = new System.Drawing.Size(195, 24);
            this.nud_slton.TabIndex = 5;
            this.nud_slton.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_slton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nud_slton_KeyPress);
            // 
            // lb_slton
            // 
            this.lb_slton.AutoSize = true;
            this.lb_slton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_slton.Location = new System.Drawing.Point(20, 248);
            this.lb_slton.Name = "lb_slton";
            this.lb_slton.Size = new System.Drawing.Size(143, 20);
            this.lb_slton.TabIndex = 4;
            this.lb_slton.Text = "Số Lượng Tồn : ";
            // 
            // tb_tennl
            // 
            this.tb_tennl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_tennl.Location = new System.Drawing.Point(192, 178);
            this.tb_tennl.Name = "tb_tennl";
            this.tb_tennl.Size = new System.Drawing.Size(195, 24);
            this.tb_tennl.TabIndex = 3;
            this.tb_tennl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_tennl_KeyPress);
            // 
            // lb_tennl
            // 
            this.lb_tennl.AutoSize = true;
            this.lb_tennl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_tennl.Location = new System.Drawing.Point(20, 178);
            this.lb_tennl.Name = "lb_tennl";
            this.lb_tennl.Size = new System.Drawing.Size(168, 20);
            this.lb_tennl.TabIndex = 2;
            this.lb_tennl.Text = "Tên Nguyên Liệu : ";
            // 
            // gb_ttnl
            // 
            this.gb_ttnl.Controls.Add(this.bt_sua);
            this.gb_ttnl.Controls.Add(this.bt_xoa);
            this.gb_ttnl.Controls.Add(this.bt_them);
            this.gb_ttnl.Controls.Add(this.bt_tim);
            this.gb_ttnl.Controls.Add(this.dgv_nl);
            this.gb_ttnl.Controls.Add(this.tb_tim);
            this.gb_ttnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gb_ttnl.Location = new System.Drawing.Point(244, 12);
            this.gb_ttnl.Name = "gb_ttnl";
            this.gb_ttnl.Size = new System.Drawing.Size(699, 506);
            this.gb_ttnl.TabIndex = 4;
            this.gb_ttnl.TabStop = false;
            this.gb_ttnl.Text = "Thông Tin Nguyên Liệu";
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
            this.bt_tim.Location = new System.Drawing.Point(586, 48);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(106, 40);
            this.bt_tim.TabIndex = 81;
            this.bt_tim.Text = "Tìm";
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // dgv_nl
            // 
            this.dgv_nl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nl.Location = new System.Drawing.Point(6, 116);
            this.dgv_nl.Name = "dgv_nl";
            this.dgv_nl.RowHeadersWidth = 51;
            this.dgv_nl.RowTemplate.Height = 24;
            this.dgv_nl.Size = new System.Drawing.Size(687, 384);
            this.dgv_nl.TabIndex = 0;
            this.dgv_nl.SelectionChanged += new System.EventHandler(this.dgv_nl_SelectionChanged);
            // 
            // tb_tim
            // 
            this.tb_tim.Location = new System.Drawing.Point(357, 48);
            this.tb_tim.Multiline = true;
            this.tb_tim.Name = "tb_tim";
            this.tb_tim.Size = new System.Drawing.Size(223, 40);
            this.tb_tim.TabIndex = 80;
            // 
            // nguyenlieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1371, 530);
            this.Controls.Add(this.gb_ctnl);
            this.Controls.Add(this.gb_ttnl);
            this.Controls.Add(this.menuStrip1);
            this.Name = "nguyenlieu";
            this.Text = "nguyenlieu";
            this.Load += new System.EventHandler(this.nguyenlieu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_ctnl.ResumeLayout(false);
            this.gb_ctnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_slton)).EndInit();
            this.gb_ttnl.ResumeLayout(false);
            this.gb_ttnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nl)).EndInit();
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
        private System.Windows.Forms.GroupBox gb_ctnl;
        private System.Windows.Forms.ComboBox cb_dvtinh;
        private System.Windows.Forms.Label lb_dvtinh;
        private System.Windows.Forms.NumericUpDown nud_slton;
        private System.Windows.Forms.Label lb_slton;
        private System.Windows.Forms.TextBox tb_tennl;
        private System.Windows.Forms.Label lb_tennl;
        private System.Windows.Forms.GroupBox gb_ttnl;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.DataGridView dgv_nl;
        private System.Windows.Forms.TextBox tb_tim;
        private System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.TextBox tb_manl;
        private System.Windows.Forms.Label lb_manl;
        private System.Windows.Forms.ToolStripMenuItem tsmi_qlgl;
        private System.Windows.Forms.TextBox tb_mamon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_tennv;
    }
}