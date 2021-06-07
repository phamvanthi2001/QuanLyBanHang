using DAL;
using DTO;
using System.Net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dalNhanVien = new DAL_NhanVien();

        public bool NhanVienDangNhap(DTO_NhanVien nv)
        {
            return dalNhanVien.NhanVienDangNhap(nv);
        }

        public bool NhanVienQuenMatKhau(string email)
        {
            return dalNhanVien.NhanVienQuenMatKhau(email);
        }

        public bool TaoMatKhau(string email, string matKhauMoi)
        {
            return dalNhanVien.TaoMatKhau(email, matKhauMoi);
        }

        public bool UpdateMatKhau(string email, string matKhauCu, string matKhauMoi)
        {
            return dalNhanVien.UpdateMatKhau(email, matKhauCu, matKhauMoi);
        }

        public DataTable VaiTroNhanVien(string email)
        {
            return dalNhanVien.VaiTroNhanVien(email);
        }

        public DataTable getNhanVien()
        {
            return dalNhanVien.getNhanVien();
        }

        public bool UpdateNhanVien(DTO_NhanVien Nv)
        {
            return dalNhanVien.UpdataNhanVien(Nv);
        }

        public bool insertNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.insertNhanVien(nv);
        }

        public bool DeleteNhanVien(string tenNhanVien)
        {
            return dalNhanVien.DeleteNhanVien(tenNhanVien);
        }

        public DataTable SearchNhanVien(string tenNhanVien)
        {
            return dalNhanVien.SearchNhanVien(tenNhanVien);
        }

        public string encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;

            UTF8Encoding encode = new UTF8Encoding();

            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();

            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }

        public void SendMail(string email)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);

                NetworkCredential cred = new NetworkCredential("phamvanthi82001@gmail.com", "01689217571");

                MailMessage Msg = new MailMessage();

                Msg.From = new MailAddress("phamvanthi82001@gmail.com");

                Msg.To.Add(email);

                Msg.Subject = "Chào mừng thành viên mới";

                Msg.Body = "Chào anh/chị. Mật khẩu mới truy cập phần mềm là abc123, anh/chị vui lòng đăng nhập vào phần mềm và đổi mật khẩu";

                client.Credentials = cred;

                client.EnableSsl = true;

                client.Send(Msg);

               
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
