using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_QuanLyHieuThuoc;
using System.Data;
using DTO_QuanLyHieuThuoc;

namespace BUS_QuanLyHieuThuoc
{
    public class BUS_CTHDN
    {
        DAL_CTHDN dal_cthdn = new DAL_CTHDN();
        public DataTable LoadCTHDN()
        {
            return dal_cthdn.LoadCTHDN();
        }

        public bool Them(ChiTietHoaDonNhap cthdn)
        {
            return dal_cthdn.Them(cthdn);
        }
        public bool Sua(ChiTietHoaDonNhap cthdn)
        {
            return dal_cthdn.Sua(cthdn);
        }
        public bool Xoa(String macthdn)
        {
            return dal_cthdn.Xoa(macthdn);
        }
        public DataTable LoadMaCTHDN()
        {
            return dal_cthdn.LoadMaCTHDN();
        }

        public DataTable TimKiemCTHDN(String macthdn)
        {
            return dal_cthdn.TimKiemCTHDN(macthdn);
        }
    }
}
