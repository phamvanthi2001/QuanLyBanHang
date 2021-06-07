using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBangHang
{
    public partial class FrmDoiMatKhau : Form
    {
        Thread th;
        string stremail;
        BUS_NhanVien busNhanVien = new BUS_NhanVien();

        public FrmDoiMatKhau(string email)
        {
            InitializeComponent();
            stremail = email;
            txtEmailNV.Text = stremail;
            txtEmailNV.Enabled = false;
        }

        public void SendMail(string email, string matkhau)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);

                NetworkCredential cred = new NetworkCredential("phamvanthi82001@gmail.com", "01689217571");

                MailMessage Msg = new MailMessage();

                Msg.From = new MailAddress("phamvanthi82001@gmail.com");

                Msg.To.Add(email);

                Msg.Subject = "Bạn đã sử dụng tính năng đổi mật khẩu";

                Msg.Body = "Chào anh/chị. Mật khẩu mới truy cập phần mềm là " + matkhau;

                client.Credentials = cred;

                client.EnableSsl = true;
                client.Send(Msg);

                MessageBox.Show("Một Email đổi mật khẩu đã được gửi tới bạn!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (txtMKCu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKCu.Focus();
                return;
            }
            else if (txtMKMoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKMoi.Focus();
                return;
            }
            else if (txtMKNhapLai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lại mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKNhapLai.Focus();
                return;
            }
            else if (txtMKNhapLai.Text.Trim() != txtMKMoi.Text.Trim())
            {
                MessageBox.Show("Bạn phải nhập mật khẩu mới và mật khẩu nhập lại giống nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKMoi.Focus();
                return;
            }
            else if (txtMKMoi.Text.Trim() == txtMKCu.Text.Trim())
            {
                MessageBox.Show("Bạn phải nhập mật mới khác mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKMoi.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn đổi mật khẩu","Confirm",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string matkhaumoi = busNhanVien.encryption(txtMKMoi.Text);
                    string matkhaucu = busNhanVien.encryption(txtMKCu.Text);
                    if (busNhanVien.UpdateMatKhau(txtEmailNV.Text, matkhaucu, matkhaumoi))
                    {
                        FrmMain.profile = 1;
                        FrmMain.session = 0;
                        SendMail(stremail, txtMKNhapLai.Text);
                        MessageBox.Show("Cập nhật mật khẩu thành công, bạn phải đăng nhập lại");
                        this.Close();
                    }
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
