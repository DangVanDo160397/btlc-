using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLyHieuThuoc;

namespace DAL_QuanLyHieuThuoc
{
    public class DAL_SanPham : DataBaseConnect
    {
        
        public DataTable Load()
        {
            conn.Open();
            cmdText = "select * from SanPham";
            SqlDataAdapter da = new SqlDataAdapter(cmdText,conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
            
        }

        public bool Them(SanPham sp)
        {
            try
            {
                conn.Open();
                cmdThem = "insert into SanPham values ('" + sp.MaSanPham + "',N'" + sp.TenSanPham + "','" + sp.GiaNhap + "','" + sp.GiaBan + "','" + sp.MaThuMuc + "','"+sp.SoLuong+"')";
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
        public bool Xoa(String msp)
        {
            try
            {
                conn.Open();
                cmdXoa = "delete SanPham where masanpham = '" + msp + "'";
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

        public bool Sua(SanPham sp)
        {
            try
            {
                conn.Open();
                cmdSua = "update SanPham set tensanpham = '" + sp.TenSanPham + "', gianhap  = '" + sp.GiaNhap + "', giaban = '" + sp.GiaBan + "', mathumuc = '" + sp.MaThuMuc + "', soluong = '"+sp.SoLuong+"' where masanpham = '" + sp.MaSanPham + "' ";
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

        public bool SuaSoLuong(int soluong , String masanpham)
        {
            try
            {
                conn.Open();
                cmdSua = "update SanPham set  soluong = '" + soluong + "' where masanpham = '" + masanpham + "' ";
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
        public DataTable LoadMaSanPham()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select masanpham from SanPham", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }

        public DataTable LoadTenSanPham()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select tensanpham from SanPham", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }

        public DataTable TimKiemSanPham(String tensp)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from SanPham where tensanpham LIKE '%" + tensp + "'", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }
    }

}
