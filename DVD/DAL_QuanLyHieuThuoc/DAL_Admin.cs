using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLyHieuThuoc;

namespace DAL_QuanLyHieuThuoc
{
    public class DAL_Admin : DataBaseConnect
    {
        public int KiemTra(Admin admin)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select COUNT(*) from Admin where name = '" + admin.UserName + "' AND password = '" + admin.Password + "'  ",conn);
            int x = (int)cmd.ExecuteScalar();
            conn.Close();
            return x;
        }
        public bool DangKy(Admin admin)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Admin values (N'" + admin.UserName + "','" + admin.Password + "')", conn);
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
    }
}
