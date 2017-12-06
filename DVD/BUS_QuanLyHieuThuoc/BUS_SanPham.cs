using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_QuanLyHieuThuoc;
using System.Data;
using DTO_QuanLyHieuThuoc;

namespace BUS_QuanLyHieuThuoc
{
    public class BUS_SanPham
    {
        DAL_SanPham dal_sp = new DAL_SanPham();


        public DataTable Load()
        {
            return dal_sp.Load();
        }
        public bool Them(SanPham sp)
        {
           return dal_sp.Them(sp);
        }

        public bool Xoa(String msp)
        {
           return dal_sp.Xoa(msp);
        }

        public bool Sua(SanPham sp)
        {
           return dal_sp.Sua(sp);
        }

        public DataTable LoadMaSanPham()
        {
            return dal_sp.LoadMaSanPham();
        }
        public DataTable LoadTenSanPham()
        {
            return dal_sp.LoadTenSanPham();
        }

        public DataTable TimKiemSanPham(String tensp)
        {
            return dal_sp.TimKiemSanPham(tensp);
        }

        public bool SuaSoLuong(int soluong , String masanpham)
        {
            return dal_sp.SuaSoLuong(soluong, masanpham);
        }
    }
}
