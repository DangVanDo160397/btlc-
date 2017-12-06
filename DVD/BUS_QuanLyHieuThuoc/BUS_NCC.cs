using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_QuanLyHieuThuoc;
using System.Data;
using DTO_QuanLyHieuThuoc;

namespace BUS_QuanLyHieuThuoc
{
    public class BUS_NCC  
    {
        DAL_NCC dal_ncc = new DAL_NCC();

        public DataTable LoadNCC()
        {
            return dal_ncc.LoadNCC();
        }
        public bool Them(NCC ncc)
        {
           return dal_ncc.Them(ncc);
        }
        public bool Xoa(String mncc)
        {
           return dal_ncc.Xoa(mncc);
        }
        public bool Sua(NCC mncc)
        {
           return dal_ncc.Sua(mncc);
        }

        public DataTable LoadMaNCC()
        {
           return dal_ncc.LoadMaNCC();
        }
        public DataTable LoadTenNCC()
        {
            return dal_ncc.LoadTenNCC();
        }

        public DataTable TimKiemNCC(String tenncc)
        {
            return dal_ncc.TimKiemNCC(tenncc);
        }
    }
}
