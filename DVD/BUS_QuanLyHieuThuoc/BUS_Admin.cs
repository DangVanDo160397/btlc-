using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_QuanLyHieuThuoc;
using System.Data;
using DTO_QuanLyHieuThuoc;

namespace BUS_QuanLyHieuThuoc
{
 
    public class BUS_Admin
    {
        DAL_Admin dal_admin = new DAL_Admin();
        

        public int kiemtra(Admin tk)
        {
            return dal_admin.KiemTra(tk);
        }

        public bool dangky(Admin tk)
        {
            return dal_admin.DangKy(tk);
        }
    }
}
