using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        private string dienThoai;
        private string tenKhach;
        private string diaChi;
        private string phai;
        private string emailKH;

        public string DienThoai
        {
            get
            {
                return dienThoai;
            }
            set
            {
                dienThoai = value;
            }
        }

        public string TenKhachHang
        {
            get
            {
                return tenKhach;
            }
            set
            {
                tenKhach = value;
            }
        }
        public string DiaChi
        {
            get
            {
                return diaChi;
            }
            set
            {
                diaChi = value;
            }
        }
        public string Phai
        {
            get
            {
                return phai;
            }
            set
            {
                phai = value;
            }
        }
        public string EmailKH
        {
            get
            {
                return emailKH;
            }
            set
            {
                emailKH = value;
            }
        }
        public DTO_KhachHang(string dienThoai, string tenKhach, string diaChi, string phai, string email)
        {
            this.dienThoai = DienThoai;
            this.tenKhach = TenKhachHang;
            this.diaChi = DiaChi;
            this.phai = Phai;
        }
        public DTO_KhachHang()
        { }
    }
}