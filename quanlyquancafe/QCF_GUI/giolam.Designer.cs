namespace QCF_GUI
{
    partial class giolam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giolam));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_trangchu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_qlsp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_qlnl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_qlgl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_qlns = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_baocao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_danggxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_tennv = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_ttgl = new System.Windows.Forms.GroupBox();
            this.bt_sua = new System.Windows.Forms.Button();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_tim = new System.Windows.Forms.Button();
            this.dgv_gl = new System.Windows.Forms.DataGridView();
            this.tb_tim = new System.Windows.Forms.TextBox();
            this.gb_ctgl = new System.Windows.Forms.GroupBox();
            this.tb_malich = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_calam = new System.Windows.Forms.ComboBox();
            this.lb_calam = new System.Windows.Forms.Label();
            this.cb_bophan = new System.Windows.Forms.ComboBox();
            this.lb_bophan = new System.Windows.Forms.Label();
            this.dtp_nglam = new System.Windows.Forms.DateTimePicker();
            this.lb_nglam = new System.Windows.Forms.Label();
            this.tb_manv = new System.Windows.Forms.TextBox();
            this.lb_manv = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.gb_ttgl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gl)).BeginInit();
            this.gb_ctgl.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(220, 623);
            this.menuStrip1.TabIndex = 3;
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
            this.tsmi_trangchu.Click += new System.EventHandler(this.tsmi_trangchu_Click);
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
            // gb_ttgl
            // 
            this.gb_ttgl.Controls.Add(this.bt_sua);
            this.gb_ttgl.Controls.Add(this.bt_xoa);
            this.gb_ttgl.Controls.Add(this.bt_them);
            this.gb_ttgl.Controls.Add(this.bt_tim);
            this.gb_ttgl.Controls.Add(this.dgv_gl);
            this.gb_ttgl.Controls.Add(this.tb_tim);
            this.gb_ttgl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gb_ttgl.Location = new System.Drawing.Point(240, 12);
            this.gb_ttgl.Name = "gb_ttgl";
            this.gb_ttgl.Size = new System.Drawing.Size(794, 599);
            this.gb_ttgl.TabIndex = 5;
            this.gb_ttgl.TabStop = false;
            this.gb_ttgl.Text = "Thông Tin Giờ Làm";
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
            // dgv_gl
            // 
            this.dgv_gl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gl.Location = new System.Drawing.Point(6, 116);
            this.dgv_gl.Name = "dgv_gl";
            this.dgv_gl.RowHeadersWidth = 51;
            this.dgv_gl.RowTemplate.Height = 24;
            this.dgv_gl.Size = new System.Drawing.Size(782, 477);
            this.dgv_gl.TabIndex = 0;
            this.dgv_gl.SelectionChanged += new System.EventHandler(this.dgv_gl_SelectionChanged);
            // 
            // tb_tim
            // 
            this.tb_tim.Location = new System.Drawing.Point(449, 48);
            this.tb_tim.Multiline = true;
            this.tb_tim.Name = "tb_tim";
            this.tb_tim.Size = new System.Drawing.Size(223, 40);
            this.tb_tim.TabIndex = 80;
            // 
            // gb_ctgl
            // 
            this.gb_ctgl.Controls.Add(this.tb_malich);
            this.gb_ctgl.Controls.Add(this.label1);
            this.gb_ctgl.Controls.Add(this.cb_calam);
            this.gb_ctgl.Controls.Add(this.lb_calam);
            this.gb_ctgl.Controls.Add(this.cb_bophan);
            this.gb_ctgl.Controls.Add(this.lb_bophan);
            this.gb_ctgl.Controls.Add(this.dtp_nglam);
            this.gb_ctgl.Controls.Add(this.lb_nglam);
            this.gb_ctgl.Controls.Add(this.tb_manv);
            this.gb_ctgl.Controls.Add(this.lb_manv);
            this.gb_ctgl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gb_ctgl.Location = new System.Drawing.Point(1040, 12);
            this.gb_ctgl.Name = "gb_ctgl";
            this.gb_ctgl.Size = new System.Drawing.Size(442, 337);
            this.gb_ctgl.TabIndex = 6;
            this.gb_ctgl.TabStop = false;
            this.gb_ctgl.Text = "Chi Tiết Ca Làm";
            // 
            // tb_malich
            // 
            this.tb_malich.Location = new System.Drawing.Point(207, 54);
            this.tb_malich.Name = "tb_malich";
            this.tb_malich.Size = new System.Drawing.Size(195, 24);
            this.tb_malich.TabIndex = 22;
            this.tb_malich.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_malich_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(45, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã Lịch : ";
            // 
            // cb_calam
            // 
            this.cb_calam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_calam.FormattingEnabled = true;
            this.cb_calam.Location = new System.Drawing.Point(207, 260);
            this.cb_calam.Name = "cb_calam";
            this.cb_calam.Size = new System.Drawing.Size(195, 26);
            this.cb_calam.TabIndex = 20;
            // 
            // lb_calam
            // 
            this.lb_calam.AutoSize = true;
            this.lb_calam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_calam.Location = new System.Drawing.Point(45, 263);
            this.lb_calam.Name = "lb_calam";
            this.lb_calam.Size = new System.Drawing.Size(81, 18);
            this.lb_calam.TabIndex = 19;
            this.lb_calam.Text = "Ca Làm : ";
            // 
            // cb_bophan
            // 
            this.cb_bophan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_bophan.FormattingEnabled = true;
            this.cb_bophan.Location = new System.Drawing.Point(207, 204);
            this.cb_bophan.Name = "cb_bophan";
            this.cb_bophan.Size = new System.Drawing.Size(195, 26);
            this.cb_bophan.TabIndex = 18;
            // 
            // lb_bophan
            // 
            this.lb_bophan.AutoSize = true;
            this.lb_bophan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_bophan.Location = new System.Drawing.Point(45, 207);
            this.lb_bophan.Name = "lb_bophan";
            this.lb_bophan.Size = new System.Drawing.Size(87, 18);
            this.lb_bophan.TabIndex = 17;
            this.lb_bophan.Text = "Bộ Phận : ";
            // 
            // dtp_nglam
            // 
            this.dtp_nglam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_nglam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_nglam.Location = new System.Drawing.Point(207, 155);
            this.dtp_nglam.Name = "dtp_nglam";
            this.dtp_nglam.Size = new System.Drawing.Size(195, 24);
            this.dtp_nglam.TabIndex = 5;
            // 
            // lb_nglam
            // 
            this.lb_nglam.AutoSize = true;
            this.lb_nglam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_nglam.Location = new System.Drawing.Point(45, 155);
            this.lb_nglam.Name = "lb_nglam";
            this.lb_nglam.Size = new System.Drawing.Size(98, 18);
            this.lb_nglam.TabIndex = 4;
            this.lb_nglam.Text = "Ngày Làm : ";
            // 
            // tb_manv
            // 
            this.tb_manv.Location = new System.Drawing.Point(207, 101);
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.Size = new System.Drawing.Size(195, 24);
            this.tb_manv.TabIndex = 1;
            this.tb_manv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_manv_KeyPress);
            // 
            // lb_manv
            // 
            this.lb_manv.AutoSize = true;
            this.lb_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_manv.Location = new System.Drawing.Point(45, 104);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(127, 18);
            this.lb_manv.TabIndex = 0;
            this.lb_manv.Text = "Mã Nhân Viên : ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // giolam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1494, 623);
            this.Controls.Add(this.gb_ctgl);
            this.Controls.Add(this.gb_ttgl);
            this.Controls.Add(this.menuStrip1);
            this.Name = "giolam";
            this.Text = "giolam";
            this.Load += new System.EventHandler(this.giolam_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_ttgl.ResumeLayout(false);
            this.gb_ttgl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gl)).EndInit();
            this.gb_ctgl.ResumeLayout(false);
            this.gb_ctgl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_trangchu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_qlsp;
        private System.Windows.Forms.ToolStripMenuItem tsmi_qlnl;
        private System.Windows.Forms.ToolStripMenuItem tsmi_qlgl;
        private System.Windows.Forms.ToolStripMenuItem tsmi_qlns;
        private System.Windows.Forms.ToolStripMenuItem tsmi_baocao;
        private System.Windows.Forms.ToolStripMenuItem tsmi_danggxuat;
        private System.Windows.Forms.GroupBox gb_ttgl;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.DataGridView dgv_gl;
        private System.Windows.Forms.TextBox tb_tim;
        private System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.GroupBox gb_ctgl;
        private System.Windows.Forms.ComboBox cb_calam;
        private System.Windows.Forms.Label lb_calam;
        private System.Windows.Forms.ComboBox cb_bophan;
        private System.Windows.Forms.Label lb_bophan;
        private System.Windows.Forms.DateTimePicker dtp_nglam;
        private System.Windows.Forms.Label lb_nglam;
        private System.Windows.Forms.TextBox tb_manv;
        private System.Windows.Forms.Label lb_manv;
        private System.Windows.Forms.TextBox tb_malich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_tennv;
    }
}