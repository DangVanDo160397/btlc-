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
    public partial class frmTimKiemSanPham : Form
    {
        BUS_SanPham bus_sp = new BUS_SanPham();
        DataTable dt;
        public frmTimKiemSanPham()
        {
            InitializeComponent();
        }

        private void frmTimKiemSanPham_Load(object sender, EventArgs e)
        {
            dt = bus_sp.Load();
            cbTensp.DataSource = bus_sp.LoadTenSanPham();
            cbTensp.DisplayMember = "tensanpham";

        }

        private void btnTimkiemsp_Click(object sender, EventArgs e)
        {
            if (cbTensp.Text == "")
            {
                MessageBox.Show("Tên sản phẩm không được để trống ! ");
            }
            else
            {
                dgvTimKiem.DataSource = bus_sp.TimKiemSanPham(cbTensp.Text);
            }
           
        }
    }
}
