using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_QuanLyHieuThuoc;
using DTO_QuanLyHieuThuoc;
namespace GUI_QuanLyHieuThuoc
{
    public partial class frmDangKy : Form
    {
        BUS_Admin bus_admin = new BUS_Admin();
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Tài khoản không được để trống !");
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống ! ");
            }
            else if (txtConfirm.Text == "")
            {
                MessageBox.Show("Nhập lại mật khẩu không được để trống !");
            }
            else if (txtMatKhau.Text != txtConfirm.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không đúng ! ");
            }
            else
            {
                Admin kt = new Admin(txtTenDangNhap.Text,txtMatKhau.Text);
                try
                {
                    if (bus_admin.dangky(kt))
                    {
                        MessageBox.Show("Đăng ký thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập trùng !");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Tên đăng nhập trùng !");
                }
               
                   
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
