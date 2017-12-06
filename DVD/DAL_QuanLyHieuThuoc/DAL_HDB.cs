using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLyHieuThuoc;

namespace DAL_QuanLyHieuThuoc
{
    public class DAL_HDB : DataBaseConnect
    {
        public DataTable LoadHDB()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from HĐB", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }

        public bool Them(HDB hdb)
        {
            try
            {
                conn.Open();
                cmdThem = "insert into HĐB values ('" + hdb.MaHDB + "','" + hdb.ThoiGianBan + "','" + hdb.MaNhanVien + "')";
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
                cmdXoa = "delete HĐB where mahdb = '" + mhdb + "'";
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

        public bool Sua(HDB hdb)
        {
            try
            {
                conn.Open();
                cmdSua = "update HĐB set thoigian_ban = '" + hdb.ThoiGianBan + "', manhanvien  = '" + hdb.MaNhanVien + "'  where mahdb = '" + hdb.MaHDB + "'  ";
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

        public DataTable LoadMaHDB()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select mahdb from HĐB", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }

        public DataTable TimKiemHDB(String mahdb)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from HĐB where mahdb LIKE '%" + mahdb + "%'", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }
    }
}
