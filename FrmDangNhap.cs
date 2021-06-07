using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBangHang
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        
        public string vaitro { get; set; }
        public string matkhau { get; set; }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.EmailNV = txtUser.Text;
            nv.MatKhau = busNhanVien.encryption(txtPass.Text);
            if (busNhanVien.NhanVienDangNhap(nv))
            {
                FrmMain.mail = nv.EmailNV;
                DataTable dt = busNhanVien.VaiTroNhanVien(nv.EmailNV);
                vaitro = dt.Rows[0][0].ToString();
                MessageBox.Show("Đăng nhập thành công");
                FrmMain.session = 1;

                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại Kiểm Tra Lại Email Và Mật Khẩu");
                txtUser.Text = null;
                txtPass.Text = null;
                txtUser.Focus();
            }
        }

        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i=0; i< size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
            {
                return builder.ToString().ToLower();
            }
            return builder.ToString();
        }

        public int RandomNuber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public void SendMail(string email, string matkhau)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com",25);
                NetworkCredential cred = new NetworkCredential("phamvanthi82001@gmail.com", "01689217571");
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("phamthi82001@gmail.com");
                Msg.To.Add(email);
                Msg.Subject = "Bạn đã sử dụng tính năng quên mật khẩu";
                Msg.Body = "Chào anh/chị. Mật khẩu mới là: " + matkhau;
                client.Credentials = cred;
                client.EnableSsl = true;
                client.Send(Msg);
                MessageBox.Show("Một email phục hồi mât khẩu đã được gửi tới bạn!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lnklblQuenMK_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "")
            {
                if (busNhanVien.NhanVienQuenMatKhau(txtUser.Text))
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append(RandomString(4, true));
                    builder.Append(RandomNuber(1000, 9999));
                    builder.Append(RandomString(2, false));
                    MessageBox.Show(builder.ToString());
                    string matkhaumoi = busNhanVien.encryption(builder.ToString());
                    busNhanVien.TaoMatKhau(txtUser.Text, matkhaumoi);
                    SendMail(txtUser.Text, builder.ToString());
                }
                else
                {
                    MessageBox.Show("Email không tôn tại, vui lòng nhập lại email!");
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập email nhận thông tin phục hồi mật khẩu!");
                txtUser.Focus();
            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            FrmMain.session = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
