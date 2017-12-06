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
    public partial class frmTimkiemncc : Form
    {
        BUS_NCC bus_ncc = new BUS_NCC();

        public frmTimkiemncc()
        {
            InitializeComponent();
        }

        private void frmTimkiemncc_Load(object sender, EventArgs e)
        {
            cbTenNCC.DataSource = bus_ncc.LoadTenNCC();
            cbTenNCC.DisplayMember = "tenncc";
        }

        private void btnTimKiemNCC_Click(object sender, EventArgs e)
        {
            if (cbTenNCC.Text == "")
            {
                MessageBox.Show("Tên NCC không được để trống ! ");
            }
            else
            {
                dgvTimKiem.DataSource = bus_ncc.TimKiemNCC(cbTenNCC.Text);
            }
            
        }

    }
}
