using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLyHieuThuoc;

namespace DAL_QuanLyHieuThuoc
{
    public class DAL_NhanVien : DataBaseConnect
    {
        public DataTable LoadNhanVien()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from NhanVien", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }

        public bool Them(NhanVien sv)
        {
            try
            {
                conn.Open();
                cmdThem = "insert into NhanVien values ('" + sv.MaNhanVien + "',N'" + sv.TenNhanVien + "','" + sv.DiaChi + "','" + sv.GioiTinh + "','" + sv.NgaySinh + "','" + sv.SoDienThoai + "' )";
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

        public bool Xoa(String mnv)
        {
            try
            {
                conn.Open();
                cmdXoa = "delete NhanVien where manhanvien = '" + mnv + "'";
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

        public bool Sua(NhanVien sv)
        {
            try
            {
                conn.Open();
                cmdSua = "update SanPham set tennhanvien = N'" + sv.TenNhanVien + "', diachi  = '" + sv.DiaChi + "', gioitinh = '" + sv.GioiTinh + "',ngaysinh = '" + sv.NgaySinh + "',sdt = '" + sv.SoDienThoai + "' where manhanvien = '" + sv.MaNhanVien + "' ";
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

        public DataTable LoadMaNhanVien()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select manhanvien from NhanVien", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }
        public DataTable LoadTenNhanVien()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select tennhanvien from NhanVien", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }
        public DataTable TimKiemNV(String tennv)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from NhanVien where tennhanvien LIKE '%" + tennv + "'", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }
    }
}
