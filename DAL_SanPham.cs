using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class DAL_SanPham : DbConnect
    {
        public DataTable getSanPham()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachHang";
                cmd.Connection = _conn;
                DataTable dtSP = new DataTable();
                dtSP.Load(cmd.ExecuteReader());
                return dtSP;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool insertSanPham(DTO_SanPham sp)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertDataIntoTblHang";
                cmd.Parameters.AddWithValue("TenHang", sp.TenHang);
                cmd.Parameters.AddWithValue("SoLuong", sp.SoLuong);
                cmd.Parameters.AddWithValue("DonGiaNhap", sp.DonGiaNhap);
                cmd.Parameters.AddWithValue("DonGiaBan", sp.DonGiaBan);
                cmd.Parameters.AddWithValue("HinhAnh", sp.HinhAnh);
                cmd.Parameters.AddWithValue("GhiChu", sp.GhiChu);
                cmd.Parameters.AddWithValue("Email", sp.EmailNV);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool UpdateSanPham(DTO_SanPham sp)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateDataIntoTblHang";
                cmd.Parameters.AddWithValue("MaHang", sp.MaHang);
                cmd.Parameters.AddWithValue("TenHang", sp.TenHang);
                cmd.Parameters.AddWithValue("SoLuong", sp.SoLuong);
                cmd.Parameters.AddWithValue("DonGiaNhap", sp.DonGiaNhap);
                cmd.Parameters.AddWithValue("DonGiaBan", sp.DonGiaBan);
                cmd.Parameters.AddWithValue("HinhAnh", sp.HinhAnh);
                cmd.Parameters.AddWithValue("GhiChu", sp.GhiChu);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool DeleteSanPham(int maHang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteDataFromtblHang";
                cmd.Parameters.AddWithValue("maHang", maHang);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public DataTable SearchSanPham(string tenHang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchHang";
                cmd.Parameters.AddWithValue("tenHang", tenHang);
                cmd.Connection = _conn;
                DataTable dtSP = new DataTable();
                dtSP.Load(cmd.ExecuteReader());
                return dtSP;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable ThongKeSanPham()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThongKeSP";
                cmd.Connection = _conn;
                DataTable dtHang = new DataTable();
                dtHang.Load(cmd.ExecuteReader());
                return dtHang;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable ThongKeTonKho()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThongKeTonKho";
                cmd.Connection = _conn;
                DataTable dtTonKho = new DataTable();
                dtTonKho.Load(cmd.ExecuteReader());
                return dtTonKho;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
