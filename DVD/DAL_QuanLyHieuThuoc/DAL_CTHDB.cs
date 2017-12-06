using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLyHieuThuoc;

namespace DAL_QuanLyHieuThuoc 
{
    public class DAL_CTHDB : DataBaseConnect
    {
        public DataTable LoadCTHDB()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from ChiTietHoaDonBan", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }

        public bool Them(ChiTietHoaDonBan cthdb)
        {
            try
            {
                conn.Open();
                cmdThem = "insert into ChiTietHoaDonBan values ( '" +cthdb.MaCTHDB+ "','" +cthdb.MaHDB + "','" + cthdb.MaSP + "','" + cthdb.SoLuongBan + "')";
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

        public bool Xoa(String mhdb)
        {
            try
            {
                conn.Open();
                cmdXoa = "delete ChiTietHoaDonBan where macthdb = '" + mhdb + "'";
                SqlCommand cmd = new SqlCommand(cmdXoa, conn);
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

        public bool Sua(ChiTietHoaDonBan hdb)
        {
            try
            {
                conn.Open();
                cmdSua = " update ChiTietHoaDonBan set  mahdb = '" + hdb.MaHDB + "', masanpham  = '" + hdb.MaSP + "' , soluong = '" + hdb.SoLuongBan + "'  where macthdb = '" + hdb.MaCTHDB + "'  ";
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
        public DataTable LoadMaCTHDB()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select macthdb from ChiTietHoaDonBan", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }

        public DataTable TimKiemCTHDB(String macthdb)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from ChiTietHoaDonBan where macthdb LIKE '%" + macthdb + "%'", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }
    }
}
