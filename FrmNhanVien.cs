using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBangHang
{
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        BUS_NhanVien busNhanVien = new BUS_NhanVien();

        private void LoadGridview_NhanVien()
        {
            dgvNhanVien.DataSource = busNhanVien.getNhanVien();
            dgvNhanVien.Columns[0].HeaderText = "Email";
            dgvNhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvNhanVien.Columns[2].HeaderText = "Địa Chỉ";
            dgvNhanVien.Columns[3].HeaderText = "Vai Trò";
            dgvNhanVien.Columns[4].HeaderText = "Tình Trạng";
        }

        private void ResetValues()
        {
            txtSearch.Text = "Nhập tên nhân viên";
            txtEmail.Text = null;
            txtTenNV.Text = null;
            txtDiaChi.Text = null;
            txtEmail.Enabled = false;
            txtTenNV.Enabled = false;
            txtDiaChi.Enabled = false;
            rdbtnNV.Enabled = false;
            rdbtnQT.Enabled = false;
            rdbtnHDong.Enabled = false;
            rdbtnNgungHD.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClose.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            ResetValues();
            LoadGridview_NhanVien();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtEmail.Text = null;
            txtTenNV.Text = null;
            txtDiaChi.Text = null;
            txtTenNV.Enabled = true;
            txtEmail.Enabled = true;
            txtDiaChi.Enabled = true;
            rdbtnNV.Enabled = true;
            rdbtnQT.Enabled = true;
            rdbtnHDong.Enabled = true;
            rdbtnNgungHD.Enabled = true;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            rdbtnNV.Checked = false;
            rdbntQT.Checked = false;
            rdbtnHDong.Checked = false;
            rdbtnNgungHD.Checked = false;
            txtEmail.Focus();
        }

        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int role = 0;
            if (rdbntQT.Checked)
            {
                role = 1;
            }

            int tinhtrang = 0;
            if (rdbtnHDong.Checked)
            {
                tinhtrang = 1;
            }

            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
            else if (!IsValid(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Bạn phải nhập đúng địa chỉ email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }

            if (txtTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNV.Focus();
                return;
            }
            else if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đúng địa chỉ nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }

            if (rdbntQT.Checked == false && rdbtnNV.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn vai trò nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (rdbtnHDong.Checked == false && rdbtnNgungHD.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn tình trạng nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DTO_NhanVien nv = new DTO_NhanVien(txtEmail.Text, txtTenNV.Text, txtDiaChi.Text, role, tinhtrang);
                if (busNhanVien.insertNhanVien(nv))
                {
                    MessageBox.Show("Thêm thành công");
                    ResetValues();
                    LoadGridview_NhanVien();
                    busNhanVien.SendMail(nv.EmailNV);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.Rows.Count > 1)
            {
                btnSave.Enabled = false;
                txtTenNV.Enabled = true;
                txtDiaChi.Enabled = true;
                rdbtnNV.Enabled = true;
                rdbtnQT.Enabled = true;
                rdbtnHDong.Enabled = true;
                rdbtnNgungHD.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

                txtEmail.Text = dgvNhanVien.CurrentRow.Cells["email"].Value.ToString();
                txtTenNV.Text = dgvNhanVien.CurrentRow.Cells["TenNv"].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells["diaChi"].Value.ToString();
                if (int.Parse(dgvNhanVien.CurrentRow.Cells["vaiTro"].Value.ToString()) == 1)
                {
                    rdbntQT.Checked = true;
                }
                else
                {
                    rdbtnNV.Checked = true;
                }

                if (int.Parse(dgvNhanVien.CurrentRow.Cells["tinhTrang"].Value.ToString()) == 1)
                {
                    rdbtnHDong.Checked = true;
                }
                else
                {
                    rdbtnNgungHD.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNV.Focus();
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
                int role = 0;
                if (rdbntQT.Checked)
                {
                    role = 1;
                }

                int tinhtrang = 0;
                if (rdbtnHDong.Checked)
                {
                    tinhtrang = 1;
                }

                DTO_NhanVien nv = new DTO_NhanVien(txtEmail.Text, txtTenNV.Text, txtDiaChi.Text, role, tinhtrang);
                if (MessageBox.Show("Bạn có chắc muốn chỉnh sửa", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busNhanVien.UpdateNhanVien(nv))
                    {
                        MessageBox.Show("Sửa thành công");
                        ResetValues();
                        LoadGridview_NhanVien();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busNhanVien.DeleteNhanVien(email))
                {
                    MessageBox.Show("Xóa dữ liệu thành công");
                    ResetValues();
                    LoadGridview_NhanVien();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tenNhanVien = txtSearch.Text;
            DataTable ds = busNhanVien.SearchNhanVien(tenNhanVien);
            if (ds.Rows.Count > 0)
            {
                dgvNhanVien.DataSource = ds;
                dgvNhanVien.Columns[0].HeaderText = "Email";
                dgvNhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
                dgvNhanVien.Columns[2].HeaderText = "Địa Chỉ";
                dgvNhanVien.Columns[3].HeaderText = "Vai Trò";
                dgvNhanVien.Columns[4].HeaderText = "Tình Trạng";
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtSearch.Text = "Nhập tên nhân viên";
            txtSearch.BackColor = Color.LightGray;
            ResetValues();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = null;
            txtSearch.BackColor = Color.White;
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            ResetValues();
            LoadGridview_NhanVien();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ResetValues();
            LoadGridview_NhanVien();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
