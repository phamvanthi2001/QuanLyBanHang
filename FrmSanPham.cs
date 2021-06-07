using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI_QLBangHang
{
    public partial class FrmSanPham : Form
    {
        BUS_SanPham busSanPham = new BUS_SanPham();
        string stremail = FrmMain.mail;
        string checkUrlImage;
        string fileName;
        string fileSavePath;
        string fileAddress;

        public FrmSanPham()
        {
            InitializeComponent();
        }
        private void LoadGridview_Hang()
        {
            dgvSanPham.DataSource = busSanPham.getSanPham();
            dgvSanPham.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgvSanPham.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgvSanPham.Columns[2].HeaderText = "Số Lượng";
            dgvSanPham.Columns[3].HeaderText = "Đơn Giá Nhập";
            dgvSanPham.Columns[4].HeaderText = "Đơn Giá Bán";
            dgvSanPham.Columns[5].HeaderText = "Hình Ảnh";
            dgvSanPham.Columns[6].HeaderText = "Ghi Chú";
            dgvSanPham.Columns[7].Visible = false;
        }

        private void ResetValues()
        {
            txtSearch.Text = "Nhập tên sản phẩm";
            txtMaSP.Text = null;
            txtTenSP.Text = null;
            txtSoLuong.Text = null;
            txtDonGiaNhap.Text = null;
            txtDonGiaBan.Text = null;
            txtHinhAnh.Text = null;
            txtGhiChu.Text = null;
            pcbImage.Image = null;
            txtMaSP.Enabled = false;
            txtTenSP.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGiaNhap.Enabled = false;
            txtDonGiaBan.Enabled = false;
            txtHinhAnh.Enabled = false;
            txtGhiChu.Enabled = false;
            pcbImage.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = false;
            btnClose.Enabled = true;
            btnImage.Enabled = false;
        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            ResetValues();
            LoadGridview_Hang();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTenSP.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonGiaNhap.Enabled = true;
            txtDonGiaBan.Enabled = true;
            txtGhiChu.Enabled = true;
            pcbImage.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            btnImage.Enabled = true;
            txtTenSP.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int maSP = int.Parse(txtMaSP.Text);
            if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busSanPham.DeleteSanPham(maSP))
                {
                    MessageBox.Show("Xóa dữ liệu thành công");
                    ResetValues();
                    LoadGridview_Hang();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int intSoluong;
            bool isInt = int.TryParse(txtSoLuong.Text.Trim().ToString(), out intSoluong);
            float floatDonGiaNhap;
            bool isfloatNhap = float.TryParse(txtDonGiaNhap.Text.Trim().ToString(), out floatDonGiaNhap);
            float floatDonGiaBan;
            bool isfloatBan = float.TryParse(txtDonGiaBan.Text.Trim().ToString(), out floatDonGiaBan);

            if (txtTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSP.Focus();
                return;
            }
            else if (!isInt || int.Parse(txtSoLuong.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Focus();
                return;
            }
            else if (!isfloatNhap || float.Parse(txtDonGiaNhap.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonGiaNhap.Focus();
                return;
            }
            else if (!isfloatBan || float.Parse(txtDonGiaBan.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonGiaBan.Focus();
                return;
            }
            else if (txtHinhAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn hình ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtGhiChu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGhiChu.Focus();
                return;
            }
            else
            {
                DTO_SanPham sp = new DTO_SanPham(int.Parse(txtMaSP.Text), txtTenSP.Text, int.Parse(txtSoLuong.Text),
                    float.Parse(txtDonGiaNhap.Text), float.Parse(txtDonGiaBan.Text), txtHinhAnh.Text, txtGhiChu.Text);
                if (MessageBox.Show("Bạn có chắc muốn chỉnh sửa", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busSanPham.UpdateSanPham(sp))
                    {
                        if (txtHinhAnh.Text != checkUrlImage)
                        {
                            File.Copy(fileAddress, fileSavePath, true);
                        }
                        MessageBox.Show("Sửa thành công");
                        ResetValues();
                        LoadGridview_Hang();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
                else
                {
                    ResetValues();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            int intSoLuong;
            bool isInt = int.TryParse(txtSoLuong.Text.Trim().ToString(), out intSoLuong);
            float floatDonGiaNhap;
            bool isfloatNhap = float.TryParse(txtDonGiaNhap.Text.Trim().ToString(), out floatDonGiaNhap);
            float floatDonGiaBan;
            bool isfloatBan = float.TryParse(txtDonGiaBan.Text.Trim().ToString(), out floatDonGiaBan);

            if (txtTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSP.Focus();
                return;
            }
            else if (!isInt || int.Parse(txtSoLuong.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Focus();
                return;
            }
            else if (!isfloatNhap || float.Parse(txtDonGiaNhap.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonGiaNhap.Focus();
                return;
            }
            else if (!isfloatBan || float.Parse(txtDonGiaBan.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonGiaBan.Focus();
                return;
            }
            else if (txtHinhAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn hình ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtGhiChu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGhiChu.Focus();
                return;
            }
            else
            {
                DTO_SanPham sp = new DTO_SanPham(txtTenSP.Text, int.Parse(txtSoLuong.Text), float.Parse(txtDonGiaNhap.Text),
                    float.Parse(txtDonGiaBan.Text), "\\Images\\" + fileName, txtGhiChu.Text, stremail);
                if (busSanPham.insertSanPham(sp))
                {
                    MessageBox.Show("Thêm sản phẩm thành công");
                    File.Copy(fileAddress, fileSavePath, true);
                    ResetValues();
                    LoadGridview_Hang();
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm không thành công");
                }
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            ResetValues();
            LoadGridview_Hang();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ResetValues();
            LoadGridview_Hang();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlOpen = new OpenFileDialog();
            dlOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|PNG(*.png)|*.png|GIF(*.gif)|*.gif|ALL file(*.*)|*.*";
            dlOpen.FilterIndex = 2;
            dlOpen.Title = "Chọn hình ảnh minh họa cho sản phẩm";
            if (dlOpen.ShowDialog() == DialogResult.OK)
            {
                fileAddress = dlOpen.FileName;
                pcbImage.Image = Image.FromFile(fileAddress);
                fileName = Path.GetFileName(dlOpen.FileName);
                string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                fileSavePath = saveDirectory + "\\Images\\" + fileName;
                txtHinhAnh.Text = "\\Images\\" + fileName;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tenSP = txtSearch.Text;
            DataTable ds = busSanPham.SearchSanPham(tenSP);
            if (ds.Rows.Count > 0)
            {
                dgvSanPham.DataSource = ds;
                dgvSanPham.Columns[0].HeaderText = "Mã Sản Phẩm";
                dgvSanPham.Columns[1].HeaderText = "Tên Sản Phẩm";
                dgvSanPham.Columns[2].HeaderText = "Số Lượng";
                dgvSanPham.Columns[3].HeaderText = "Đơn Giá Nhập";
                dgvSanPham.Columns[4].HeaderText = "Đơn Giá Bán";
                dgvSanPham.Columns[5].HeaderText = "Hình Ảnh";
                dgvSanPham.Columns[6].HeaderText = "Ghi Chú";
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtSearch.Text = "Nhập tên sản phẩm";
            txtSearch.BackColor = Color.LightGray;
            ResetValues();
        }

        private void dgvSanPham_Click(object sender, EventArgs e)
        {
            string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            if (dgvSanPham.Rows.Count > 1)
            {
                btnImage.Enabled = true;
                btnSave.Enabled = false;
                txtTenSP.Enabled = true;
                txtSoLuong.Enabled = true;
                txtDonGiaNhap.Enabled = true;
                txtDonGiaBan.Enabled = true;
                txtGhiChu.Enabled = true;
                txtTenSP.Focus();
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                txtMaSP.Text = dgvSanPham.CurrentRow.Cells["MaHang"].Value.ToString();
                txtTenSP.Text = dgvSanPham.CurrentRow.Cells["TenHang"].Value.ToString();
                txtSoLuong.Text = dgvSanPham.CurrentRow.Cells["SoLuong"].Value.ToString();
                txtDonGiaNhap.Text = dgvSanPham.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
                txtDonGiaBan.Text = dgvSanPham.CurrentRow.Cells["DonGiaBan"].Value.ToString();
                txtHinhAnh.Text = dgvSanPham.CurrentRow.Cells["HinhAnh"].Value.ToString();
                checkUrlImage = txtHinhAnh.Text;
                pcbImage.Image = Image.FromFile(saveDirectory + dgvSanPham.CurrentRow.Cells["HinhAnh"].Value.ToString());
                txtGhiChu.Text = dgvSanPham.CurrentRow.Cells["GhiChu"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = null;
            txtSearch.BackColor = Color.White;
        }
    }
}
