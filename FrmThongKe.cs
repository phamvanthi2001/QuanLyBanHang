using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBangHang
{
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
        }

        BUS_SanPham busSanPham = new BUS_SanPham();

        private void LoadGridview_ThongKeSP()
        {
            dgvNhapKho.AutoResizeColumns();
            dgvNhapKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvNhapKho.DataSource = busSanPham.ThongKeSanPham();
            dgvNhapKho.Columns[0].HeaderText = "Mã Nhân Viên";
            dgvNhapKho.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvNhapKho.Columns[2].HeaderText = "Số Lượng Sản Phẩm Nhập";
            dgvNhapKho.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNhapKho.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadGridview_ThongKeTonKho()
        {
            dgvTonKho.AutoResizeColumns();
            dgvTonKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTonKho.DataSource = busSanPham.ThongKeTonKho();
            dgvTonKho.Columns[0].HeaderText = "Tên Sản Phẩm";
            dgvTonKho.Columns[1].HeaderText = "Số Lượng Tồn Kho";
            dgvTonKho.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void tabNhapKho_Click(object sender, EventArgs e)
        {
            LoadGridview_ThongKeSP();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            LoadGridview_ThongKeSP();
            LoadGridview_ThongKeTonKho();
        }

        private void tabTonKho_Click(object sender, EventArgs e)
        {
            LoadGridview_ThongKeTonKho();
        }
    }
}
