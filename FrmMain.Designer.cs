namespace GUI_QLBangHang
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.MS_Main = new System.Windows.Forms.MenuStrip();
            this.MS_HeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_DangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_HoSoNV = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_DanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_SanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_NhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ThongKeSP = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_HuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_HDSD = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_GioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtChao = new System.Windows.Forms.TextBox();
            this.MS_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // MS_Main
            // 
            this.MS_Main.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MS_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_HeThong,
            this.MS_DanhMuc,
            this.MS_ThongKe,
            this.MS_HuongDan});
            this.MS_Main.Location = new System.Drawing.Point(0, 0);
            this.MS_Main.Name = "MS_Main";
            this.MS_Main.Size = new System.Drawing.Size(1439, 28);
            this.MS_Main.TabIndex = 0;
            this.MS_Main.Text = "menuStrip1";
            // 
            // MS_HeThong
            // 
            this.MS_HeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_DangNhap,
            this.MS_DangXuat,
            this.MS_HoSoNV,
            this.MS_Thoat});
            this.MS_HeThong.Name = "MS_HeThong";
            this.MS_HeThong.Size = new System.Drawing.Size(88, 24);
            this.MS_HeThong.Text = "Hệ Thống";
            // 
            // MS_DangNhap
            // 
            this.MS_DangNhap.Image = global::GUI_QLBangHang.Properties.Resources.login;
            this.MS_DangNhap.Name = "MS_DangNhap";
            this.MS_DangNhap.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.MS_DangNhap.Size = new System.Drawing.Size(258, 26);
            this.MS_DangNhap.Text = "Đăng Nhập";
            this.MS_DangNhap.Click += new System.EventHandler(this.MS_DangNhap_Click);
            // 
            // MS_DangXuat
            // 
            this.MS_DangXuat.Image = global::GUI_QLBangHang.Properties.Resources.logout;
            this.MS_DangXuat.Name = "MS_DangXuat";
            this.MS_DangXuat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.MS_DangXuat.Size = new System.Drawing.Size(258, 26);
            this.MS_DangXuat.Text = "Đăng Xuất";
            this.MS_DangXuat.Click += new System.EventHandler(this.MS_DangXuat_Click);
            // 
            // MS_HoSoNV
            // 
            this.MS_HoSoNV.Image = global::GUI_QLBangHang.Properties.Resources.profile_check_icon;
            this.MS_HoSoNV.Name = "MS_HoSoNV";
            this.MS_HoSoNV.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.MS_HoSoNV.Size = new System.Drawing.Size(258, 26);
            this.MS_HoSoNV.Text = "Hồ Sơ Nhân Viên";
            this.MS_HoSoNV.Click += new System.EventHandler(this.MS_HoSoNV_Click);
            // 
            // MS_Thoat
            // 
            this.MS_Thoat.Image = global::GUI_QLBangHang.Properties.Resources.Close_icon;
            this.MS_Thoat.Name = "MS_Thoat";
            this.MS_Thoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MS_Thoat.Size = new System.Drawing.Size(258, 26);
            this.MS_Thoat.Text = "Thoát";
            this.MS_Thoat.Click += new System.EventHandler(this.MS_Thoat_Click);
            // 
            // MS_DanhMuc
            // 
            this.MS_DanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_SanPham,
            this.MS_NhanVien,
            this.MS_KhachHang});
            this.MS_DanhMuc.Name = "MS_DanhMuc";
            this.MS_DanhMuc.Size = new System.Drawing.Size(90, 24);
            this.MS_DanhMuc.Text = "Danh Mục";
            // 
            // MS_SanPham
            // 
            this.MS_SanPham.Image = global::GUI_QLBangHang.Properties.Resources.product_icon;
            this.MS_SanPham.Name = "MS_SanPham";
            this.MS_SanPham.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.MS_SanPham.Size = new System.Drawing.Size(223, 26);
            this.MS_SanPham.Text = "Sản Phẩm";
            this.MS_SanPham.Click += new System.EventHandler(this.MS_SanPham_Click);
            // 
            // MS_NhanVien
            // 
            this.MS_NhanVien.Image = global::GUI_QLBangHang.Properties.Resources.Administrator_icon;
            this.MS_NhanVien.Name = "MS_NhanVien";
            this.MS_NhanVien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.MS_NhanVien.Size = new System.Drawing.Size(223, 26);
            this.MS_NhanVien.Text = "Nhân Viên";
            this.MS_NhanVien.Click += new System.EventHandler(this.MS_NhanVien_Click);
            // 
            // MS_KhachHang
            // 
            this.MS_KhachHang.Image = global::GUI_QLBangHang.Properties.Resources.User_Group_icon;
            this.MS_KhachHang.Name = "MS_KhachHang";
            this.MS_KhachHang.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.MS_KhachHang.Size = new System.Drawing.Size(223, 26);
            this.MS_KhachHang.Text = "Khách Hàng";
            this.MS_KhachHang.Click += new System.EventHandler(this.MS_KhachHang_Click);
            // 
            // MS_ThongKe
            // 
            this.MS_ThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_ThongKeSP});
            this.MS_ThongKe.Name = "MS_ThongKe";
            this.MS_ThongKe.Size = new System.Drawing.Size(84, 24);
            this.MS_ThongKe.Text = "Thống kê";
            // 
            // MS_ThongKeSP
            // 
            this.MS_ThongKeSP.Image = global::GUI_QLBangHang.Properties.Resources.Group_product_icon;
            this.MS_ThongKeSP.Name = "MS_ThongKeSP";
            this.MS_ThongKeSP.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.MS_ThongKeSP.Size = new System.Drawing.Size(267, 26);
            this.MS_ThongKeSP.Text = "Thống kê sản phẩm";
            this.MS_ThongKeSP.Click += new System.EventHandler(this.MS_ThongKeSP_Click);
            // 
            // MS_HuongDan
            // 
            this.MS_HuongDan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_HDSD,
            this.MS_GioiThieu});
            this.MS_HuongDan.Name = "MS_HuongDan";
            this.MS_HuongDan.Size = new System.Drawing.Size(98, 24);
            this.MS_HuongDan.Text = "Hướng dẫn";
            // 
            // MS_HDSD
            // 
            this.MS_HDSD.Image = global::GUI_QLBangHang.Properties.Resources.open_file_icon;
            this.MS_HDSD.Name = "MS_HDSD";
            this.MS_HDSD.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.MS_HDSD.Size = new System.Drawing.Size(279, 26);
            this.MS_HDSD.Text = "Hướng Dẫn Sử Dụng";
            // 
            // MS_GioiThieu
            // 
            this.MS_GioiThieu.Image = global::GUI_QLBangHang.Properties.Resources.Data_List_icon;
            this.MS_GioiThieu.Name = "MS_GioiThieu";
            this.MS_GioiThieu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.MS_GioiThieu.Size = new System.Drawing.Size(279, 26);
            this.MS_GioiThieu.Text = "Giới thiệu ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtChao
            // 
            this.txtChao.BackColor = System.Drawing.Color.White;
            this.txtChao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChao.Location = new System.Drawing.Point(1148, 0);
            this.txtChao.Margin = new System.Windows.Forms.Padding(4);
            this.txtChao.Multiline = true;
            this.txtChao.Name = "txtChao";
            this.txtChao.Size = new System.Drawing.Size(271, 23);
            this.txtChao.TabIndex = 4;
            this.txtChao.Text = "Chào ";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::GUI_QLBangHang.Properties.Resources.BackgroundForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1439, 1055);
            this.Controls.Add(this.txtChao);
            this.Controls.Add(this.MS_Main);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MS_Main;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bán Hàng";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MS_Main.ResumeLayout(false);
            this.MS_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS_Main;
        private System.Windows.Forms.ToolStripMenuItem MS_HeThong;
        private System.Windows.Forms.ToolStripMenuItem MS_DangNhap;
        private System.Windows.Forms.ToolStripMenuItem MS_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem MS_HoSoNV;
        private System.Windows.Forms.ToolStripMenuItem MS_Thoat;
        private System.Windows.Forms.ToolStripMenuItem MS_DanhMuc;
        private System.Windows.Forms.ToolStripMenuItem MS_SanPham;
        private System.Windows.Forms.ToolStripMenuItem MS_NhanVien;
        private System.Windows.Forms.ToolStripMenuItem MS_KhachHang;
        private System.Windows.Forms.ToolStripMenuItem MS_ThongKe;
        private System.Windows.Forms.ToolStripMenuItem MS_ThongKeSP;
        private System.Windows.Forms.ToolStripMenuItem MS_HuongDan;
        private System.Windows.Forms.ToolStripMenuItem MS_HDSD;
        private System.Windows.Forms.ToolStripMenuItem MS_GioiThieu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtChao;
    }
}