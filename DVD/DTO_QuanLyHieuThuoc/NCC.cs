using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLyHieuThuoc
{
    public class NCC
    {
        private String _maNCC;

        public String MaNCC
        {
            get { return _maNCC; }
            set { _maNCC = value; }
        }

        private String _tenNCC;

        public String TenNCC
        {
            get { return _tenNCC; }
            set { _tenNCC = value; }
        }


        private String _diaChi;

        public String DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        private String _soDienThoai;

        public String SoDienThoai
        {
            get { return _soDienThoai; }
            set { _soDienThoai = value; }
        }


        public NCC(String maNCC, String tenNCC, String diaChi, String soDienThoai)
        {
            this._maNCC = maNCC;
            this._tenNCC = tenNCC;
            this._diaChi = diaChi;
            this._soDienThoai = soDienThoai;
        }
        
    }
}
