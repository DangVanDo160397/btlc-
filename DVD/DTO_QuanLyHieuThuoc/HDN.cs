using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLyHieuThuoc
{
    public class HDN
    {
        private String _maHDN;

        public String MaHDN
        {
            get { return _maHDN; }
            set { _maHDN = value; }
        }

        private String _thoigianNhap;

        public String ThoiGianNhap
        {
            get { return _thoigianNhap; }
            set { _thoigianNhap = value; }
        }

        private String _maNhanVien;

        public String MaNhanVien
        {
            get { return _maNhanVien; }
            set { _maNhanVien = value; }
        }

        private String _maNCC;

        public String MaNCC
        {
            get { return _maNCC; }
            set { _maNCC = value; }
        }
        
        public HDN(String maHDN, String thoigianNhap, String maNhanVien, String maNCC)
        {
            this._maHDN = maHDN;
            this._thoigianNhap = thoigianNhap;
            this._maNhanVien = maNhanVien;
            this._maNCC = maNCC;
        }
    }
}
