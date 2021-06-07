namespace GUI_QLBangHang
{
    partial class FrmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            this.rdbtnQT = new System.Windows.Forms.Panel();
            this.rdbtnHDong = new System.Windows.Forms.RadioButton();
            this.rdbtnNgungHD = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbtnNV = new System.Windows.Forms.RadioButton();
            this.rdbntQT = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.LbEmail = new System.Windows.Forms.Label();
            this.LbTenNV = new System.Windows.Forms.Label();
            this.LbVaiTro = new System.Windows.Forms.Label();
            this.LbDiaChi = new System.Windows.Forms.Label();
            this.LbTinhTrang = new System.Windows.Forms.Label();
            this.LbTieuDe = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rdbtnQT.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbtnQT
            // 
            this.rdbtnQT.Controls.Add(this.rdbtnHDong);
            this.rdbtnQT.Controls.Add(this.rdbtnNgungHD);
            this.rdbtnQT.Location = new System.Drawing.Point(897, 283);
            this.rdbtnQT.Margin = new System.Windows.Forms.Padding(5);
            this.rdbtnQT.Name = "rdbtnQT";
            this.rdbtnQT.Size = new System.Drawing.Size(492, 57);
            this.rdbtnQT.TabIndex = 44;
            // 
            // rdbtnHDong
            // 
            this.rdbtnHDong.AutoSize = true;
            this.rdbtnHDong.Font = new System.Drawing.Font("Cambria", 10F);
            this.rdbtnHDong.Location = new System.Drawing.Point(19, 2);
            this.rdbtnHDong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdbtnHDong.Name = "rdbtnHDong";
            this.rdbtnHDong.Size = new System.Drawing.Size(106, 24);
            this.rdbtnHDong.TabIndex = 20;
            this.rdbtnHDong.TabStop = true;
            this.rdbtnHDong.Text = "Hoạt Động";
            this.rdbtnHDong.UseVisualStyleBackColor = true;
            // 
            // rdbtnNgungHD
            // 
            this.rdbtnNgungHD.AutoSize = true;
            this.rdbtnNgungHD.Font = new System.Drawing.Font("Cambria", 10F);
            this.rdbtnNgungHD.Location = new System.Drawing.Point(267, 2);
            this.rdbtnNgungHD.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdbtnNgungHD.Name = "rdbtnNgungHD";
            this.rdbtnNgungHD.Size = new System.Drawing.Size(158, 24);
            this.rdbtnNgungHD.TabIndex = 20;
            this.rdbtnNgungHD.TabStop = true;
            this.rdbtnNgungHD.Text = "Ngưng Hoạt Động";
            this.rdbtnNgungHD.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbtnNV);
            this.panel1.Controls.Add(this.rdbntQT);
            this.panel1.Location = new System.Drawing.Point(231, 283);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 57);
            this.panel1.TabIndex = 43;
            // 
            // rdbtnNV
            // 
            this.rdbtnNV.AutoSize = true;
            this.rdbtnNV.Font = new System.Drawing.Font("Cambria", 10F);
            this.rdbtnNV.Location = new System.Drawing.Point(19, 2);
            this.rdbtnNV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdbtnNV.Name = "rdbtnNV";
            this.rdbtnNV.Size = new System.Drawing.Size(104, 24);
            this.rdbtnNV.TabIndex = 12;
            this.rdbtnNV.TabStop = true;
            this.rdbtnNV.Text = "Nhân Viên";
            this.rdbtnNV.UseVisualStyleBackColor = true;
            // 
            // rdbntQT
            // 
            this.rdbntQT.AutoSize = true;
            this.rdbntQT.Font = new System.Drawing.Font("Cambria", 10F);
            this.rdbntQT.Location = new System.Drawing.Point(259, 2);
            this.rdbntQT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdbntQT.Name = "rdbntQT";
            this.rdbntQT.Size = new System.Drawing.Size(92, 24);
            this.rdbntQT.TabIndex = 13;
            this.rdbntQT.TabStop = true;
            this.rdbntQT.Text = "Quản Trị";
            this.rdbntQT.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(475, 672);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(349, 38);
            this.txtSearch.TabIndex = 32;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(293, 175);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTenNV.Multiline = true;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(349, 38);
            this.txtTenNV.TabIndex = 31;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(839, 94);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(443, 155);
            this.txtDiaChi.TabIndex = 33;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(17, 352);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(1425, 278);
            this.dgvNhanVien.TabIndex = 34;
            this.dgvNhanVien.Click += new System.EventHandler(this.dgvNhanVien_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(293, 94);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(349, 38);
            this.txtEmail.TabIndex = 30;
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmail.ForeColor = System.Drawing.Color.Blue;
            this.LbEmail.Location = new System.Drawing.Point(87, 97);
            this.LbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(65, 23);
            this.LbEmail.TabIndex = 29;
            this.LbEmail.Text = "Email:";
            // 
            // LbTenNV
            // 
            this.LbTenNV.AutoSize = true;
            this.LbTenNV.Font = new System.Drawing.Font("Cambria", 12F);
            this.LbTenNV.ForeColor = System.Drawing.Color.Blue;
            this.LbTenNV.Location = new System.Drawing.Point(87, 177);
            this.LbTenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbTenNV.Name = "LbTenNV";
            this.LbTenNV.Size = new System.Drawing.Size(139, 23);
            this.LbTenNV.TabIndex = 28;
            this.LbTenNV.Text = "Tên Nhân Viên:";
            // 
            // LbVaiTro
            // 
            this.LbVaiTro.AutoSize = true;
            this.LbVaiTro.Font = new System.Drawing.Font("Cambria", 12F);
            this.LbVaiTro.ForeColor = System.Drawing.Color.Blue;
            this.LbVaiTro.Location = new System.Drawing.Point(87, 283);
            this.LbVaiTro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbVaiTro.Name = "LbVaiTro";
            this.LbVaiTro.Size = new System.Drawing.Size(76, 23);
            this.LbVaiTro.TabIndex = 27;
            this.LbVaiTro.Text = "Vai Trò:";
            // 
            // LbDiaChi
            // 
            this.LbDiaChi.AutoSize = true;
            this.LbDiaChi.Font = new System.Drawing.Font("Cambria", 12F);
            this.LbDiaChi.ForeColor = System.Drawing.Color.Blue;
            this.LbDiaChi.Location = new System.Drawing.Point(695, 105);
            this.LbDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbDiaChi.Name = "LbDiaChi";
            this.LbDiaChi.Size = new System.Drawing.Size(76, 23);
            this.LbDiaChi.TabIndex = 26;
            this.LbDiaChi.Text = "Địa Chỉ:";
            // 
            // LbTinhTrang
            // 
            this.LbTinhTrang.AutoSize = true;
            this.LbTinhTrang.Font = new System.Drawing.Font("Cambria", 12F);
            this.LbTinhTrang.ForeColor = System.Drawing.Color.Blue;
            this.LbTinhTrang.Location = new System.Drawing.Point(680, 283);
            this.LbTinhTrang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbTinhTrang.Name = "LbTinhTrang";
            this.LbTinhTrang.Size = new System.Drawing.Size(108, 23);
            this.LbTinhTrang.TabIndex = 25;
            this.LbTinhTrang.Text = "Tình Trạng:";
            // 
            // LbTieuDe
            // 
            this.LbTieuDe.AutoSize = true;
            this.LbTieuDe.BackColor = System.Drawing.SystemColors.Control;
            this.LbTieuDe.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.LbTieuDe.Location = new System.Drawing.Point(595, 11);
            this.LbTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbTieuDe.Name = "LbTieuDe";
            this.LbTieuDe.Size = new System.Drawing.Size(217, 44);
            this.LbTieuDe.TabIndex = 24;
            this.LbTieuDe.Text = "NHÂN VIÊN";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnSearch.Image = global::GUI_QLBangHang.Properties.Resources.find;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(897, 656);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(177, 57);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnClose.Image = global::GUI_QLBangHang.Properties.Resources.Close_icon1;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1269, 746);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(161, 57);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnList.Image = global::GUI_QLBangHang.Properties.Resources.Data_List_icon;
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.Location = new System.Drawing.Point(1041, 746);
            this.btnList.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(207, 57);
            this.btnList.TabIndex = 39;
            this.btnList.Text = "Danh Sách";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnSkip.Image = global::GUI_QLBangHang.Properties.Resources.Cancel;
            this.btnSkip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSkip.Location = new System.Drawing.Point(837, 746);
            this.btnSkip.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(177, 57);
            this.btnSkip.TabIndex = 38;
            this.btnSkip.Text = "Bỏ Qua";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnSave.Image = global::GUI_QLBangHang.Properties.Resources.Save_icon;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(629, 746);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 57);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnUpdate.Image = global::GUI_QLBangHang.Properties.Resources.edit;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(433, 746);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(176, 57);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnDelete.Image = global::GUI_QLBangHang.Properties.Resources.Actions_edit_delete_icon1;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(231, 746);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(177, 57);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnAdd.Image = global::GUI_QLBangHang.Properties.Resources.add_icon;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(29, 746);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(177, 57);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 815);
            this.Controls.Add(this.rdbtnQT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.LbEmail);
            this.Controls.Add(this.LbTenNV);
            this.Controls.Add(this.LbVaiTro);
            this.Controls.Add(this.LbDiaChi);
            this.Controls.Add(this.LbTinhTrang);
            this.Controls.Add(this.LbTieuDe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.Click += new System.EventHandler(this.FrmNhanVien_Load);
            this.rdbtnQT.ResumeLayout(false);
            this.rdbtnQT.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel rdbtnQT;
        private System.Windows.Forms.RadioButton rdbtnHDong;
        private System.Windows.Forms.RadioButton rdbtnNgungHD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbtnNV;
        private System.Windows.Forms.RadioButton rdbntQT;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.Label LbTenNV;
        private System.Windows.Forms.Label LbVaiTro;
        private System.Windows.Forms.Label LbDiaChi;
        private System.Windows.Forms.Label LbTinhTrang;
        private System.Windows.Forms.Label LbTieuDe;
    }
}