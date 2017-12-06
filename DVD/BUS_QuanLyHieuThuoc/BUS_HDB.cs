using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_QuanLyHieuThuoc;
using System.Data;
using DTO_QuanLyHieuThuoc;


namespace BUS_QuanLyHieuThuoc
{
    public class BUS_HDB
    {

        DAL_HDB dal_hdb = new DAL_HDB();

        public DataTable LoadHDB()
        {
            return dal_hdb.LoadHDB();

        }
        public bool Them(HDB hdb)
        {
           return dal_hdb.Them(hdb);
        }
        public bool Xoa(String mhdb)
        {
            return dal_hdb.Xoa(mhdb);
        }
        public bool Sua(HDB hdb)
        {
            return dal_hdb.Sua(hdb);
        }
        public DataTable LoadMaHDB()
        {
            return dal_hdb.LoadMaHDB();
        }

        public DataTable TimKiemHDB(String mahdb)
        {
            return dal_hdb.TimKiemHDB(mahdb);
        }
    }
}
