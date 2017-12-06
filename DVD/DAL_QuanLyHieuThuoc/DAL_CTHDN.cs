using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLyHieuThuoc;

namespace DAL_QuanLyHieuThuoc
{
    public class DAL_CTHDN : DataBaseConnect
    {
        public DataTable LoadCTHDN()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from ChiTietHoaDonNhap", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }

        public bool Them(ChiTietHoaDonNhap cthdn)
        {
            try
            {
                conn.Open();
                cmdThem = "insert into ChiTietHoaDonNhap values ( '" + cthdn.MaCthdn + "','" + cthdn.MaHDN + "','" + cthdn.MaSP + "','" + cthdn.SoLuongNhap + "')";
                SqlCommand cmd = new SqlCommand(cmdThem, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool Sua(ChiTietHoaDonNhap cthdn)
        {
            try
            {
                conn.Open();
                cmdSua = " update ChiTietHoaDonNhap set  mahdn = '" + cthdn.MaHDN + "', masp  = '" + cthdn.MaSP + "' , soluong = '" + cthdn.SoLuongNhap + "'  where macthdn = '" + cthdn.MaCthdn + "'  ";
                SqlCommand cmd = new SqlCommand(cmdSua, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return false;
        
        }
        public bool Xoa(String macthdn)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete ChiTietHoaDonNhap where macthdn = '" + macthdn + "'", conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public DataTable LoadMaCTHDN()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select macthdn from ChiTietHoaDonNhap", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }

        public DataTable TimKiemCTHDN(String macthdn)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from ChiTietHoaDonNhap where macthdn LIKE '%" + macthdn + "%'", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }
    }
}
