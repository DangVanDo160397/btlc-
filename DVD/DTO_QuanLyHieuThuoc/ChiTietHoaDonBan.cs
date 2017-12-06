using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLyHieuThuoc
{
    public class ChiTietHoaDonBan
    {
        private String _macthdb;

        public String MaCTHDB
        {
            get { return _macthdb; }
            set { _macthdb = value; }
        }
        
        private String _mahdb;

        public String MaHDB
        {
            get { return _mahdb; }
            set { _mahdb = value; }
        }

        private String _masp;

        public String MaSP
        {
            get { return _masp; }
            set { _masp = value; }
        }

        private int _soluongban;

        public int SoLuongBan
        {
            get { return _soluongban; }
            set { _soluongban = value; }
        }

        public ChiTietHoaDonBan(String macthdb,String mahdb, String masp, int soluongban)
        {
            this._macthdb = macthdb;
            this._mahdb = mahdb;
            this._masp = masp;
            this._soluongban = soluongban;
        }
        
    }
}
