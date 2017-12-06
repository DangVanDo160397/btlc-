using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLyHieuThuoc
{
    public class Admin
    {
        private String _username;

        public String UserName
        {
            get { return _username; }
            set { _username = value; }
        }

        private String _password;

        public String Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public Admin( String username, String password)
        {
            this._username = username;
            this._password = password;
        }
        
    }
}
