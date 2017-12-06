using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLyHieuThuoc
{
    public class NhanVien
    {
        private String _maNhanVien;

        public String MaNhanVien
        {
            get { return _maNhanVien; }
            set { _maNhanVien = value; }
        }

        private String _tenNhanVien;

        public String TenNhanVien
        {
            get { return _tenNhanVien; }
            set { _tenNhanVien = value; }
        }

        private String _diaChi;

        public String DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

         private Boolean _gioiTinh;

	     public Boolean GioiTinh
	     {
		     get { return _gioiTinh;}
		     set { _gioiTinh = value;}
	     }
	

        private String _ngaySinh;

        public String NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }

        private String _soDienThoai;

        public String SoDienThoai
        {
            get { return _soDienThoai; }
            set { _soDienThoai = value; }
        }


        public NhanVien(String maNhanVien, String tenNhanVien , String diaChi,Boolean gioiTinh,String ngaySinh,String soDienThoai)
        {
            this._maNhanVien = maNhanVien;
            this._tenNhanVien = tenNhanVien;
            this._diaChi = diaChi;
            this._gioiTinh = gioiTinh;
            this._ngaySinh = ngaySinh;
            this._soDienThoai = soDienThoai;
        }

       
	
        
    }
}
