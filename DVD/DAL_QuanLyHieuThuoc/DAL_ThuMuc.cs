using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLyHieuThuoc;

namespace DAL_QuanLyHieuThuoc
{
    public class DAL_ThuMuc : DataBaseConnect
    {
        public DataTable LoadThuMuc()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from ThuMuc", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }

        public bool Them(ThuMuc tm)
        {
            try
            {
                conn.Open();
                cmdThem = "insert into ThuMuc values ('" + tm.MaThuMuc + "',N'" + tm.TenThuMuc + "')";
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

        public bool Xoa(String mtm)
        {
            try
            {
                conn.Open();
                cmdXoa = "delete ThuMuc where mathumuc = '" + mtm + "'";
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

        public bool Sua(ThuMuc tm)
        {
            try
            {
                conn.Open();
                cmdSua = "update ThuMuc set tenthumuc = '" + tm.TenThuMuc + "' where mathumuc = '" + tm.MaThuMuc + "' ";
                SqlCommand cmd = new SqlCommand(cmdSua, conn);
                if(cmd.ExecuteNonQuery() > 0)
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
        public DataTable LoadMaThuMuc()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select mathumuc from ThuMuc", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }
    }
}
