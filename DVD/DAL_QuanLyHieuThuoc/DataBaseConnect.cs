using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DAL_QuanLyHieuThuoc
{
    public class DataBaseConnect
    {
        protected string cmdText;
        protected string cmdThem;
        protected string cmdSua;
        protected string cmdXoa;

        protected SqlConnection conn = new SqlConnection(@"Data Source=DBK5J4OLDBGZXMD\SQLEXPRESS;Initial Catalog=QuanLyBanThuoc;Integrated Security=True");
    }
}
