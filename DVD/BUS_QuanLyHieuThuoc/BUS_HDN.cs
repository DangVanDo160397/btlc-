using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_QuanLyHieuThuoc;
using System.Data;
using DTO_QuanLyHieuThuoc;
namespace BUS_QuanLyHieuThuoc
{
    public class BUS_HDN
    {
        DAL_HDN dal_hdn = new DAL_HDN();

        public DataTable LoadHDN()
        {
            return dal_hdn.LoadHDN();
        }
        public bool Them(HDN hdn)
        {
           return dal_hdn.Them(hdn);
        }
        public bool Xoa(String mhdn)
        {
           return dal_hdn.Xoa(mhdn);
        }
        public bool Sua(HDN hdn)
        {
           return  dal_hdn.Sua(hdn);
        }
        public DataTable LoadMaHDN()
        {
            return dal_hdn.LoadMaHDN();
        }

        public DataTable TimKiemHDN(String mahdn)
        {
            return dal_hdn.TimKiemHDN(mahdn);
        }
    }
}
