using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLyHieuThuoc;

namespace DAL_QuanLyHieuThuoc
{
    public class DAL_NCC : DataBaseConnect
    {
        public DataTable LoadNCC()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from NCC", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }

        public bool Them(NCC ncc)
        {

            try
            {
                conn.Open();
                cmdThem = "insert into NCC values ('" + ncc.MaNCC + "',N'" + ncc.TenNCC + "',N'" + ncc.DiaChi + "','" + ncc.SoDienThoai + "')";
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

        public bool Xoa(String mncc)
        {
            try
            {
                conn.Open();
                cmdXoa = "delete NCC where mancc = '" + mncc + "'";
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

        public bool Sua(NCC ncc)
        {
            try
            {
                conn.Open();
                cmdSua = "update NCC set tenncc = N'" + ncc.TenNCC + "', diachi  = N'" + ncc.DiaChi + "', sodienthoai = '" + ncc.SoDienThoai + "' where mancc = '" + ncc.MaNCC + "' ";
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

        public DataTable LoadMaNCC()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select mancc from NCC", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }

        public DataTable LoadTenNCC()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select tenncc from NCC", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }

        public DataTable TimKiemNCC(String tenncc)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from NCC where tenncc LIKE '%" + tenncc + "%'", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }
    }
}
