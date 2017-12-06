using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO_QuanLyHieuThuoc;
using DAL_QuanLyHieuThuoc;


namespace BUS_QuanLyHieuThuoc
{
    public class BUS_ThuMuc
    {
        DAL_ThuMuc dal_tm = new DAL_ThuMuc();

        public DataTable LoadThuMuc()
        {
            return dal_tm.LoadThuMuc();
        }
        public bool Them(ThuMuc tm)
        {
          return dal_tm.Them(tm);
        }
        public bool Xoa(String mtm)
        {
            return dal_tm.Xoa(mtm);
        }
        public bool Sua(ThuMuc tm)
        {
           return dal_tm.Sua(tm);
        }
        public DataTable LoadMaThuMuc()
        {
            return dal_tm.LoadMaThuMuc();
        }
    }
}
