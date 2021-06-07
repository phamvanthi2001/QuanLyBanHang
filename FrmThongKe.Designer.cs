namespace GUI_QLBangHang
{
    partial class FrmThongKe
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
            this.tctrlThongKe = new System.Windows.Forms.TabControl();
            this.tabNhapKho = new System.Windows.Forms.TabPage();
            this.dgvNhapKho = new System.Windows.Forms.DataGridView();
            this.tabTonKho = new System.Windows.Forms.TabPage();
            this.dgvTonKho = new System.Windows.Forms.DataGridView();
            this.tctrlThongKe.SuspendLayout();
            this.tabNhapKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapKho)).BeginInit();
            this.tabTonKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // tctrlThongKe
            // 
            this.tctrlThongKe.Controls.Add(this.tabNhapKho);
            this.tctrlThongKe.Controls.Add(this.tabTonKho);
            this.tctrlThongKe.Location = new System.Drawing.Point(2, 12);
            this.tctrlThongKe.Name = "tctrlThongKe";
            this.tctrlThongKe.SelectedIndex = 0;
            this.tctrlThongKe.Size = new System.Drawing.Size(799, 434);
            this.tctrlThongKe.TabIndex = 1;
            // 
            // tabNhapKho
            // 
            this.tabNhapKho.Controls.Add(this.dgvNhapKho);
            this.tabNhapKho.Location = new System.Drawing.Point(4, 25);
            this.tabNhapKho.Name = "tabNhapKho";
            this.tabNhapKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhapKho.Size = new System.Drawing.Size(791, 405);
            this.tabNhapKho.TabIndex = 0;
            this.tabNhapKho.Text = "Sản Phẩm Nhập Kho";
            this.tabNhapKho.UseVisualStyleBackColor = true;
            this.tabNhapKho.Click += new System.EventHandler(this.tabNhapKho_Click);
            // 
            // dgvNhapKho
            // 
            this.dgvNhapKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapKho.Location = new System.Drawing.Point(2, 0);
            this.dgvNhapKho.Name = "dgvNhapKho";
            this.dgvNhapKho.RowHeadersWidth = 51;
            this.dgvNhapKho.RowTemplate.Height = 24;
            this.dgvNhapKho.Size = new System.Drawing.Size(783, 398);
            this.dgvNhapKho.TabIndex = 0;
            // 
            // tabTonKho
            // 
            this.tabTonKho.Controls.Add(this.dgvTonKho);
            this.tabTonKho.Location = new System.Drawing.Point(4, 25);
            this.tabTonKho.Name = "tabTonKho";
            this.tabTonKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabTonKho.Size = new System.Drawing.Size(791, 405);
            this.tabTonKho.TabIndex = 1;
            this.tabTonKho.Text = "Tồn Kho";
            this.tabTonKho.UseVisualStyleBackColor = true;
            this.tabTonKho.Click += new System.EventHandler(this.tabTonKho_Click);
            // 
            // dgvTonKho
            // 
            this.dgvTonKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTonKho.Location = new System.Drawing.Point(3, 3);
            this.dgvTonKho.Name = "dgvTonKho";
            this.dgvTonKho.RowHeadersWidth = 51;
            this.dgvTonKho.RowTemplate.Height = 24;
            this.dgvTonKho.Size = new System.Drawing.Size(788, 402);
            this.dgvTonKho.TabIndex = 0;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tctrlThongKe);
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmThongKe";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            this.tctrlThongKe.ResumeLayout(false);
            this.tabNhapKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapKho)).EndInit();
            this.tabTonKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctrlThongKe;
        private System.Windows.Forms.TabPage tabNhapKho;
        private System.Windows.Forms.DataGridView dgvNhapKho;
        private System.Windows.Forms.TabPage tabTonKho;
        private System.Windows.Forms.DataGridView dgvTonKho;
    }
}