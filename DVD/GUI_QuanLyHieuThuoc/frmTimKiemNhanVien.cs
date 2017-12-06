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
    public partial class frmTimKiemNhanVien : Form
    {
        BUS_NhanVien bus_nv = new BUS_NhanVien();
        public frmTimKiemNhanVien()
        {
            InitializeComponent();
        }

        private void frmTimKiemNhanVien_Load(object sender, EventArgs e)
        {
            cbTenNV.DataSource = bus_nv.LoadTenNhanVien();
            cbTenNV.DisplayMember = "tennhanvien";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (cbTenNV.Text == "")
            {
                MessageBox.Show("Tên nhân viên không được để trống !");
            }
            else
            {
                dgvTimKiemNV.DataSource = bus_nv.TimKiemNV(cbTenNV.Text);
            }
        }
    }
}
