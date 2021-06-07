using BUS;
using DTO;
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
    public partial class FrmKhachHang : Form
    {
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        string stremail = FrmMain.mail;
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void ResetValues()
        {
            txtSearch.Text = "Nhập số điện thoại";
            txtDThoai.Text = null;
            txtTenKhachHang.Text = null;
            txtDiaChi.Text = null;
            txtDThoai.Enabled = false;
            txtTenKhachHang.Enabled = false;
            txtDiaChi.Enabled = false;
            rdbtnNam.Enabled = false;
            rdbtnNu.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClose.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void LoadGridview_Khach()
        {
            dgvKhachHang.DataSource = busKhachHang.getKhach();
            dgvKhachHang.Columns[0].HeaderText = "Điện Thoại";
            dgvKhachHang.Columns[1].HeaderText = "Họ và Tên";
            dgvKhachHang.Columns[2].HeaderText = "Địa Chỉ";
            dgvKhachHang.Columns[3].HeaderText = "Giới Tính";
            dgvKhachHang.Columns[4].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            float intDienThoai;
            bool isInt = float.TryParse(txtDThoai.Text.Trim().ToString(), out intDienThoai);
            string phai = "Nam";

            if (rdbtnNu.Checked)
            {
                phai = "Nữ";
            }

            if (!isInt || float.Parse(txtDThoai.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại > 0, số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDThoai.Focus();
                return;
            }
            else if (txtTenKhachHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhachHang.Focus();
                return;
            }
            else if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            else if (rdbtnNam.Checked == false && rdbtnNu.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhachHang.Focus();
                return;
            }

            else
            {
                DTO_KhachHang kh = new DTO_KhachHang(txtDThoai.Text, txtTenKhachHang.Text, txtDiaChi.Text, phai, stremail);
                if (busKhachHang.InsertKhach(kh))
                {
                    MessageBox.Show("Thêm thành công");
                    ResetValues();
                    LoadGridview_Khach();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtDThoai.Text = null;
            txtTenKhachHang.Text = null;
            txtDiaChi.Text = null;
            txtDThoai.Enabled = true;
            txtTenKhachHang.Enabled = true;
            txtDiaChi.Enabled = true;
            rdbtnNam.Enabled = true;
            rdbtnNu.Enabled = true;
            rdbtnNam.Checked = false;
            rdbtnNu.Checked = false;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtDThoai.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string dienThoai = txtDThoai.Text;
            if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busKhachHang.DeleteKhach(dienThoai))
                {
                    MessageBox.Show("Xóa dữ liệu thành công");
                    ResetValues();
                    LoadGridview_Khach();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            else
            {
                ResetValues();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtTenKhachHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhachHang.Focus();
                return;
            }
            else if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            else
            {
                string phai = "Nam";
                if (rdbtnNu.Checked)
                {
                    phai = "Nữ";
                }

                DTO_KhachHang kh = new DTO_KhachHang(txtDThoai.Text, txtTenKhachHang.Text, txtDiaChi.Text, phai, stremail);
                if (MessageBox.Show("Bạn có chắc muốn chỉnh sửa", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busKhachHang.UpdateKhach(kh))
                    {
                        MessageBox.Show("Sửa thành công");
                        ResetValues();
                        LoadGridview_Khach();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string DThoai = txtSearch.Text;
            DataTable ds = busKhachHang.SearchKhach(DThoai);
            if (ds.Rows.Count > 0)
            {
                dgvKhachHang.DataSource = ds;
                dgvKhachHang.Columns[0].HeaderText = "Điện Thoại";
                dgvKhachHang.Columns[1].HeaderText = "Họ và Tên";
                dgvKhachHang.Columns[2].HeaderText = "Địa Chỉ";
                dgvKhachHang.Columns[3].HeaderText = "Giới Tính";
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtSearch.Text = "Nhập tên nhân viên";
            txtSearch.BackColor = Color.LightGray;
            ResetValues();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            ResetValues();
            LoadGridview_Khach();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ResetValues();
            LoadGridview_Khach();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = null;
            txtSearch.BackColor = Color.White;
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            ResetValues();
            LoadGridview_Khach();
        }

        private void dgvKhachHang_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKhachHang.Rows.Count > 1)
            {
                btnSave.Enabled = false;
                txtTenKhachHang.Enabled = true;
                txtDiaChi.Enabled = true;
                rdbtnNam.Enabled = true;
                rdbtnNu.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

                txtDThoai.Text = dgvKhachHang.CurrentRow.Cells["dienThoai"].Value.ToString();
                txtTenKhachHang.Text = dgvKhachHang.CurrentRow.Cells["tenKhach"].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells["diaChi"].Value.ToString();
                if (dgvKhachHang.CurrentRow.Cells["phai"].Value.ToString() == "Nam")
                {
                    rdbtnNam.Checked = true;
                }
                else
                {
                    rdbtnNu.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
