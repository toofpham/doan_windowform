namespace QCF_GUI
{
    partial class baocao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(baocao));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_trangchu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_qlsp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_qlnl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_qlgl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_qlns = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_baocao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_danggxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_tennv = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_bc = new System.Windows.Forms.GroupBox();
            this.bt_in = new System.Windows.Forms.Button();
            this.lb_ngayden = new System.Windows.Forms.Label();
            this.lb_ngaytu = new System.Windows.Forms.Label();
            this.dt_ngaytu = new System.Windows.Forms.DateTimePicker();
            this.dt_ngayden = new System.Windows.Forms.DateTimePicker();
            this.bt_tke = new System.Windows.Forms.Button();
            this.dgv_baocao = new System.Windows.Forms.DataGridView();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.gb_bc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_baocao)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(222, 672);
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
            // tsmi_baocao
            // 
            this.tsmi_baocao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsmi_baocao.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.tsmi_baocao.Name = "tsmi_baocao";
            this.tsmi_baocao.Size = new System.Drawing.Size(187, 27);
            this.tsmi_baocao.Text = "Báo Cáo";
            this.tsmi_baocao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // gb_bc
            // 
            this.gb_bc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_bc.Controls.Add(this.bt_in);
            this.gb_bc.Controls.Add(this.lb_ngayden);
            this.gb_bc.Controls.Add(this.lb_ngaytu);
            this.gb_bc.Controls.Add(this.dt_ngaytu);
            this.gb_bc.Controls.Add(this.dt_ngayden);
            this.gb_bc.Controls.Add(this.bt_tke);
            this.gb_bc.Controls.Add(this.dgv_baocao);
            this.gb_bc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gb_bc.Location = new System.Drawing.Point(246, 12);
            this.gb_bc.Name = "gb_bc";
            this.gb_bc.Size = new System.Drawing.Size(773, 648);
            this.gb_bc.TabIndex = 5;
            this.gb_bc.TabStop = false;
            this.gb_bc.Text = "Báo Cáo Doanh Thu";
            // 
            // bt_in
            // 
            this.bt_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_in.BackColor = System.Drawing.Color.Red;
            this.bt_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_in.Location = new System.Drawing.Point(530, 32);
            this.bt_in.Name = "bt_in";
            this.bt_in.Size = new System.Drawing.Size(116, 65);
            this.bt_in.TabIndex = 86;
            this.bt_in.Text = "In ";
            this.bt_in.UseVisualStyleBackColor = false;
            this.bt_in.Click += new System.EventHandler(this.bt_in_Click);
            // 
            // lb_ngayden
            // 
            this.lb_ngayden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ngayden.AutoSize = true;
            this.lb_ngayden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_ngayden.Location = new System.Drawing.Point(83, 73);
            this.lb_ngayden.Name = "lb_ngayden";
            this.lb_ngayden.Size = new System.Drawing.Size(96, 18);
            this.lb_ngayden.TabIndex = 85;
            this.lb_ngayden.Text = "Đến Ngày : ";
            // 
            // lb_ngaytu
            // 
            this.lb_ngaytu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ngaytu.AutoSize = true;
            this.lb_ngaytu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_ngaytu.Location = new System.Drawing.Point(83, 37);
            this.lb_ngaytu.Name = "lb_ngaytu";
            this.lb_ngaytu.Size = new System.Drawing.Size(85, 18);
            this.lb_ngaytu.TabIndex = 84;
            this.lb_ngaytu.Text = "Từ Ngày : ";
            // 
            // dt_ngaytu
            // 
            this.dt_ngaytu.AllowDrop = true;
            this.dt_ngaytu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_ngaytu.CustomFormat = "dd/MM/yyyy";
            this.dt_ngaytu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dt_ngaytu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngaytu.Location = new System.Drawing.Point(185, 32);
            this.dt_ngaytu.Name = "dt_ngaytu";
            this.dt_ngaytu.Size = new System.Drawing.Size(197, 24);
            this.dt_ngaytu.TabIndex = 83;
            // 
            // dt_ngayden
            // 
            this.dt_ngayden.AllowDrop = true;
            this.dt_ngayden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_ngayden.CustomFormat = "dd/MM/yyyy";
            this.dt_ngayden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dt_ngayden.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngayden.Location = new System.Drawing.Point(185, 73);
            this.dt_ngayden.Name = "dt_ngayden";
            this.dt_ngayden.Size = new System.Drawing.Size(197, 24);
            this.dt_ngayden.TabIndex = 82;
            // 
            // bt_tke
            // 
            this.bt_tke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_tke.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_tke.Location = new System.Drawing.Point(399, 32);
            this.bt_tke.Name = "bt_tke";
            this.bt_tke.Size = new System.Drawing.Size(116, 65);
            this.bt_tke.TabIndex = 81;
            this.bt_tke.Text = "Thống Kê";
            this.bt_tke.UseVisualStyleBackColor = true;
            this.bt_tke.Click += new System.EventHandler(this.bt_tke_Click);
            // 
            // dgv_baocao
            // 
            this.dgv_baocao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_baocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_baocao.Location = new System.Drawing.Point(6, 116);
            this.dgv_baocao.Name = "dgv_baocao";
            this.dgv_baocao.RowHeadersWidth = 51;
            this.dgv_baocao.RowTemplate.Height = 24;
            this.dgv_baocao.Size = new System.Drawing.Size(759, 526);
            this.dgv_baocao.TabIndex = 0;
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "add.png");
            this.icons.Images.SetKeyName(1, "Delete-icon.png");
            this.icons.Images.SetKeyName(2, "edit.png");
            // 
            // baocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1031, 672);
            this.Controls.Add(this.gb_bc);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "baocao";
            this.Text = "baocao";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_bc.ResumeLayout(false);
            this.gb_bc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_baocao)).EndInit();
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
        private System.Windows.Forms.GroupBox gb_bc;
        private System.Windows.Forms.Button bt_tke;
        private System.Windows.Forms.DataGridView dgv_baocao;
        private System.Windows.Forms.DateTimePicker dt_ngayden;
        private System.Windows.Forms.DateTimePicker dt_ngaytu;
        private System.Windows.Forms.Label lb_ngayden;
        private System.Windows.Forms.Label lb_ngaytu;
        private System.Windows.Forms.Button bt_in;
        private System.Windows.Forms.ToolStripMenuItem tsmi_qlgl;
        private System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.ToolStripMenuItem tsmi_tennv;
    }
}