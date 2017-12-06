using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLyHieuThuoc
{
    public class SanPham
    {
        private String _maSanPham;

        public String MaSanPham
        {
            get { return _maSanPham; }
            set { _maSanPham = value; }
        }

        private String _tenSanPham;

        public String TenSanPham
        {
            get { return _tenSanPham; }
            set { _tenSanPham = value; }
        }

        private float _giaNhap;

        public float GiaNhap
        {
            get { return _giaNhap; }
            set { _giaNhap = value; }
        }

        private float _giaBan;

        public float GiaBan
        {
            get { return _giaBan; }
            set { _giaBan = value; }
        }

        private String _maThuMuc;

        public String MaThuMuc
        {
            get { return _maThuMuc; }
            set { _maThuMuc = value; }
        }

        private int _soLuong;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
        
        public SanPham(String maSanPham, String tenSanPham, float giaNhap, float giaBan, String maThuMuc, int soLuong)
        {
            this._maSanPham = maSanPham;
            this._tenSanPham = tenSanPham;
            this._giaNhap = giaNhap;
            this._giaBan = giaBan;
            this._maThuMuc = maThuMuc;
            this._soLuong = soLuong;
        }
    }
}
