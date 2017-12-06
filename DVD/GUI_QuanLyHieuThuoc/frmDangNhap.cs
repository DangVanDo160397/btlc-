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
    public partial class frmDangNhap : Form
    {
        BUS_Admin bus_admin = new BUS_Admin();
       
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Tài khoản không được để trống !");
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống ! ");
            }
            else
            {
                Admin tk = new Admin(txtTaiKhoan.Text,txtMatKhau.Text);

                if (bus_admin.kiemtra(tk) > 0 )
                {
                    MessageBox.Show("Thành công");
                    frmQLHT frmQLHT = new frmQLHT();
                    this.Hide();
                    frmQLHT.Show();
                }
            }
            
        }

        private void qltt_FromClose(object sender, EventArgs e)
        {
            this.Show();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKy frmdk = new frmDangKy();
            frmdk.FormClosed += new FormClosedEventHandler(qltt_FromClose);
            this.Hide();
            frmdk.Show();
        }

        
    }
}
