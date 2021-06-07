namespace GUI_QLBangHang
{
    partial class FrmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoiMatKhau));
            this.lbChuDe = new System.Windows.Forms.Label();
            this.lbMatKhauCu = new System.Windows.Forms.Label();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.lbMatKhauMoi = new System.Windows.Forms.Label();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbNhapLaiMatKhauMoi = new System.Windows.Forms.Label();
            this.txtMKNhapLai = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmailNV = new System.Windows.Forms.TextBox();
            this.pcbLock = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLock)).BeginInit();
            this.SuspendLayout();
            // 
            // lbChuDe
            // 
            this.lbChuDe.AutoSize = true;
            this.lbChuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbChuDe.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbChuDe.Location = new System.Drawing.Point(189, 124);
            this.lbChuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChuDe.Name = "lbChuDe";
            this.lbChuDe.Size = new System.Drawing.Size(164, 29);
            this.lbChuDe.TabIndex = 22;
            this.lbChuDe.Text = "Đổi mật khẩu";
            // 
            // lbMatKhauCu
            // 
            this.lbMatKhauCu.AutoSize = true;
            this.lbMatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMatKhauCu.Location = new System.Drawing.Point(39, 250);
            this.lbMatKhauCu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatKhauCu.Name = "lbMatKhauCu";
            this.lbMatKhauCu.Size = new System.Drawing.Size(105, 20);
            this.lbMatKhauCu.TabIndex = 23;
            this.lbMatKhauCu.Text = "Mật khẩu cũ:";
            // 
            // txtMKCu
            // 
            this.txtMKCu.Location = new System.Drawing.Point(275, 249);
            this.txtMKCu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMKCu.Multiline = true;
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Size = new System.Drawing.Size(233, 46);
            this.txtMKCu.TabIndex = 24;
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDoiMK.Location = new System.Drawing.Point(43, 462);
            this.btnDoiMK.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(188, 66);
            this.btnDoiMK.TabIndex = 25;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // lbMatKhauMoi
            // 
            this.lbMatKhauMoi.AutoSize = true;
            this.lbMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMatKhauMoi.Location = new System.Drawing.Point(39, 325);
            this.lbMatKhauMoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatKhauMoi.Name = "lbMatKhauMoi";
            this.lbMatKhauMoi.Size = new System.Drawing.Size(114, 20);
            this.lbMatKhauMoi.TabIndex = 26;
            this.lbMatKhauMoi.Text = "Mật khẩu mới:";
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(275, 325);
            this.txtMKMoi.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMKMoi.Multiline = true;
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.PasswordChar = '*';
            this.txtMKMoi.Size = new System.Drawing.Size(233, 46);
            this.txtMKMoi.TabIndex = 27;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(321, 462);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(188, 66);
            this.btnThoat.TabIndex = 28;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbNhapLaiMatKhauMoi
            // 
            this.lbNhapLaiMatKhauMoi.AutoSize = true;
            this.lbNhapLaiMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNhapLaiMatKhauMoi.Location = new System.Drawing.Point(39, 398);
            this.lbNhapLaiMatKhauMoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNhapLaiMatKhauMoi.Name = "lbNhapLaiMatKhauMoi";
            this.lbNhapLaiMatKhauMoi.Size = new System.Drawing.Size(148, 20);
            this.lbNhapLaiMatKhauMoi.TabIndex = 29;
            this.lbNhapLaiMatKhauMoi.Text = "Nhập lại mật khẩu:";
            // 
            // txtMKNhapLai
            // 
            this.txtMKNhapLai.Location = new System.Drawing.Point(275, 398);
            this.txtMKNhapLai.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMKNhapLai.Multiline = true;
            this.txtMKNhapLai.Name = "txtMKNhapLai";
            this.txtMKNhapLai.PasswordChar = '*';
            this.txtMKNhapLai.Size = new System.Drawing.Size(233, 46);
            this.txtMKNhapLai.TabIndex = 30;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbEmail.Location = new System.Drawing.Point(39, 181);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(56, 20);
            this.lbEmail.TabIndex = 31;
            this.lbEmail.Text = "Email:";
            // 
            // txtEmailNV
            // 
            this.txtEmailNV.Location = new System.Drawing.Point(275, 180);
            this.txtEmailNV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtEmailNV.Multiline = true;
            this.txtEmailNV.Name = "txtEmailNV";
            this.txtEmailNV.Size = new System.Drawing.Size(233, 46);
            this.txtEmailNV.TabIndex = 32;
            // 
            // pcbLock
            // 
            this.pcbLock.Image = global::GUI_QLBangHang.Properties.Resources.login;
            this.pcbLock.Location = new System.Drawing.Point(212, 13);
            this.pcbLock.Margin = new System.Windows.Forms.Padding(4);
            this.pcbLock.Name = "pcbLock";
            this.pcbLock.Size = new System.Drawing.Size(124, 105);
            this.pcbLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLock.TabIndex = 33;
            this.pcbLock.TabStop = false;
            // 
            // FrmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 566);
            this.Controls.Add(this.pcbLock);
            this.Controls.Add(this.txtEmailNV);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txtMKNhapLai);
            this.Controls.Add(this.lbNhapLaiMatKhauMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.lbMatKhauMoi);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.txtMKCu);
            this.Controls.Add(this.lbMatKhauCu);
            this.Controls.Add(this.lbChuDe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.pcbLock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChuDe;
        private System.Windows.Forms.Label lbMatKhauCu;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Label lbMatKhauMoi;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbNhapLaiMatKhauMoi;
        private System.Windows.Forms.TextBox txtMKNhapLai;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmailNV;
        private System.Windows.Forms.PictureBox pcbLock;
    }
}

