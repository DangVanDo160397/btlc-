using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_QuanLyHieuThuoc;
using System.Data;
using DTO_QuanLyHieuThuoc;

namespace BUS_QuanLyHieuThuoc
{
    public class BUS_CTHDB
    {
        DAL_CTHDB dal_cthdb = new DAL_CTHDB();

        public DataTable LoadCTHDB()
        {
            return dal_cthdb.LoadCTHDB();
        }

        public bool Them(ChiTietHoaDonBan cthdb)
        {
            return dal_cthdb.Them(cthdb);
        }

        public bool Sua(ChiTietHoaDonBan hdb)
        {
            return dal_cthdb.Sua(hdb);
        }
        public bool Xoa(String macthdb)
        {
            return dal_cthdb.Xoa(macthdb);
        }
        public DataTable LoadMaCTHDB()
        {
            return dal_cthdb.LoadMaCTHDB();
        }

        public DataTable TimKiemCTHDB(String macthdb)
        {
            return dal_cthdb.TimKiemCTHDB(macthdb);
        }

    }
}
