using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLyHieuThuoc
{
    public class HDB
    {
        private String _maHDB;

        public String MaHDB
        {
            get { return _maHDB; }
            set { _maHDB = value; }
        }

        private String _thoigianBan;

        public String ThoiGianBan
        {
            get { return _thoigianBan; }
            set { _thoigianBan = value; }
        }

        private String _maNhanVien;

        public String MaNhanVien
        {
            get { return _maNhanVien; }
            set { _maNhanVien = value; }
        }

        public HDB(String maHDB, String thoigianBan, String maNhanVien)
        {
            this._maHDB = maHDB;
            this._thoigianBan = thoigianBan;
            this._maNhanVien = maNhanVien;
        }
    }
}
