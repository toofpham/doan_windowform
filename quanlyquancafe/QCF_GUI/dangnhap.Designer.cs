namespace QCF_GUI
{
    partial class dangnhap
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.tb_mk = new System.Windows.Forms.TextBox();
            this.tb_tk = new System.Windows.Forms.TextBox();
            this.lb_mk = new System.Windows.Forms.Label();
            this.lb_tk = new System.Windows.Forms.Label();
            this.bt_tat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QCF_GUI.Properties.Resources.Thiết_kế_chưa_có_tên1;
            this.pictureBox1.Location = new System.Drawing.Point(456, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 504);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(100, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // bt_login
            // 
            this.bt_login.AccessibleDescription = " ";
            this.bt_login.BackColor = System.Drawing.Color.Red;
            this.bt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_login.Location = new System.Drawing.Point(131, 347);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(190, 49);
            this.bt_login.TabIndex = 13;
            this.bt_login.Text = "Đăng Nhập";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click_1);
            // 
            // tb_mk
            // 
            this.tb_mk.Location = new System.Drawing.Point(184, 272);
            this.tb_mk.Multiline = true;
            this.tb_mk.Name = "tb_mk";
            this.tb_mk.PasswordChar = '*';
            this.tb_mk.Size = new System.Drawing.Size(214, 31);
            this.tb_mk.TabIndex = 12;
            // 
            // tb_tk
            // 
            this.tb_tk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_tk.Location = new System.Drawing.Point(184, 213);
            this.tb_tk.Multiline = true;
            this.tb_tk.Name = "tb_tk";
            this.tb_tk.Size = new System.Drawing.Size(214, 31);
            this.tb_tk.TabIndex = 11;
            // 
            // lb_mk
            // 
            this.lb_mk.AutoSize = true;
            this.lb_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_mk.Location = new System.Drawing.Point(47, 272);
            this.lb_mk.Name = "lb_mk";
            this.lb_mk.Size = new System.Drawing.Size(124, 25);
            this.lb_mk.TabIndex = 10;
            this.lb_mk.Text = "Mật Khẩu : ";
            // 
            // lb_tk
            // 
            this.lb_tk.AutoSize = true;
            this.lb_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_tk.Location = new System.Drawing.Point(47, 217);
            this.lb_tk.Name = "lb_tk";
            this.lb_tk.Size = new System.Drawing.Size(131, 25);
            this.lb_tk.TabIndex = 9;
            this.lb_tk.Text = "Tài Khoản : ";
            // 
            // bt_tat
            // 
            this.bt_tat.BackColor = System.Drawing.Color.White;
            this.bt_tat.FlatAppearance.BorderSize = 0;
            this.bt_tat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_tat.Location = new System.Drawing.Point(740, 0);
            this.bt_tat.Name = "bt_tat";
            this.bt_tat.Size = new System.Drawing.Size(53, 37);
            this.bt_tat.TabIndex = 15;
            this.bt_tat.Text = "X";
            this.bt_tat.UseVisualStyleBackColor = false;
            this.bt_tat.Click += new System.EventHandler(this.button1_Click);
            this.bt_tat.MouseEnter += new System.EventHandler(this.bt_tat_MouseEnter);
            this.bt_tat.MouseLeave += new System.EventHandler(this.bt_tat_MouseLeave);
            // 
            // dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(794, 503);
            this.ControlBox = false;
            this.Controls.Add(this.bt_tat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.tb_mk);
            this.Controls.Add(this.tb_tk);
            this.Controls.Add(this.lb_mk);
            this.Controls.Add(this.lb_tk);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "dangnhap";
            this.Text = "Đăng Nhập";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dangnhap_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.TextBox tb_mk;
        private System.Windows.Forms.TextBox tb_tk;
        private System.Windows.Forms.Label lb_mk;
        private System.Windows.Forms.Label lb_tk;
        private System.Windows.Forms.Button bt_tat;
    }
}

