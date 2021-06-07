using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dalKhachHang = new DAL_KhachHang();

        public DataTable getKhach()
        {
            return dalKhachHang.getKhach();
        }

        public bool InsertKhach(DTO_KhachHang khach)
        {
            return dalKhachHang.insertKhach(khach);
        }

        public bool UpdateKhach(DTO_KhachHang Khach)
        {
            return dalKhachHang.UpdateKhach(Khach);
        }

        public bool DeleteKhach(string dienThoai)
        {
            return dalKhachHang.DeleteKhach(dienThoai);
        }

        public DataTable SearchKhach(string dienThoai)
        {
            return dalKhachHang.SearchKhach(dienThoai);
        }
    }
}