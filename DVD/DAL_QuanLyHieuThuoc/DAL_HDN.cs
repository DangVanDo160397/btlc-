using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLyHieuThuoc;

namespace DAL_QuanLyHieuThuoc
{
    public class DAL_HDN : DataBaseConnect
    {
        public DataTable LoadHDN()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from HĐN", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }

        public bool Them(HDN hdn)
        {

            try
            {
                conn.Open();
                cmdThem = "insert into HĐN values ('" + hdn.MaHDN + "','" + hdn.ThoiGianNhap + "','" + hdn.MaNhanVien + "', '" + hdn.MaNCC + "' )";
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

        public bool Xoa(String mhdn)
        {
            try
            {
                conn.Open();
                cmdXoa = "delete HĐN where mahdn = '" + mhdn + "'";
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

        public bool Sua(HDN hdn)
        {
            try
            {
                conn.Open();
                cmdSua = "update HĐN set thoigian_nhap = '" + hdn.ThoiGianNhap + "', manhanvien  = '" + hdn.MaNhanVien + "' , mancc = '" + hdn.MaNCC + "' where mahdn = '" + hdn.MaHDN + "'  ";
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

        public DataTable LoadMaHDN()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select mahdn from HĐN", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }

        public DataTable TimKiemHDN(String mahdn)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from HĐN where mahdn LIKE '%" + mahdn + "%'", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }
    }
}
