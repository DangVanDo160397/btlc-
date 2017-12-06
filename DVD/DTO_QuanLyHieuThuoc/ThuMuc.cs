using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLyHieuThuoc
{
    public class ThuMuc
    {
        private String _maThuMuc;

        public String MaThuMuc
        {
            get { return _maThuMuc; }
            set { _maThuMuc = value; }
        }

        private String _tenThuMuc;

        public String TenThuMuc
        {
            get { return _tenThuMuc; }
            set { _tenThuMuc = value; }
        }

        public ThuMuc (String maThuMuc, String tenThuMuc)
        {
            this._maThuMuc = maThuMuc;
            this._tenThuMuc = tenThuMuc;
        }
        
    }
}
