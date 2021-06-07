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
    public class BUS_SanPham
    {
        DAL_SanPham dalSanPham = new DAL_SanPham();

        public DataTable getSanPham()
        {
            return dalSanPham.getSanPham();
        }

        public bool insertSanPham(DTO_SanPham sp)
        {
            return dalSanPham.insertSanPham(sp);
        }

        public bool UpdateSanPham(DTO_SanPham sp)
        {
            return dalSanPham.UpdateSanPham(sp);
        }

        public bool DeleteSanPham(int maHang)
        {
            return dalSanPham.DeleteSanPham(maHang);
        }

        public DataTable SearchSanPham(string tenHang)
        {
            return dalSanPham.SearchSanPham(tenHang);
        }

        public DataTable ThongKeSanPham()
        {
            return dalSanPham.ThongKeSanPham();
        }

        public DataTable ThongKeTonKho()
        {
            return dalSanPham.ThongKeTonKho();
        }
    }
}
