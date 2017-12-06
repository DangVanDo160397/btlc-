using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLyHieuThuoc
{
    public class ChiTietHoaDonNhap
    {
        private String _macthdn;

        public String MaCthdn
        {
            get { return _macthdn; }
            set { _macthdn = value; }
        }
        
        private String _mahdn;

        public String MaHDN
        {
            get { return _mahdn; }
            set { _mahdn = value; }
        }

        private String _masp;

        public String MaSP
        {
            get { return _masp; }
            set { _masp = value; }
        }

        private int _soluongnhap;

        public int SoLuongNhap
        {
            get { return _soluongnhap; }
            set { _soluongnhap = value; }
        }

        public ChiTietHoaDonNhap(String macthdn,String mahdn, String masp, int soluongnhap)
        {
            this._macthdn = macthdn;
            this._mahdn = mahdn;
            this._masp = masp;
            this._soluongnhap = soluongnhap;
        }
    }
}
