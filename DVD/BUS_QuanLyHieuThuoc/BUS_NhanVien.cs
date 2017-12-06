using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_QuanLyHieuThuoc;
using System.Data;
using DTO_QuanLyHieuThuoc;

namespace BUS_QuanLyHieuThuoc
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dal_nv = new DAL_NhanVien();

        public DataTable LoadNhanVien()
        {
            return dal_nv.LoadNhanVien();
        }
        public bool Them(NhanVien nv)
        {
            return dal_nv.Them(nv);
        }
        public bool Xoa(String mnv)
        {
            return dal_nv.Xoa(mnv);
        }
        public bool Sua(NhanVien sv)
        {
           return dal_nv.Sua(sv);       
        }

        public DataTable LoadMaNhanVien()
        {
            return dal_nv.LoadMaNhanVien();
        }

        public DataTable LoadTenNhanVien()
        {
            return dal_nv.LoadTenNhanVien();
        }

        public DataTable TimKiemNV(String tennv)
        {
            return dal_nv.TimKiemNV(tennv);
        }
    }
}
