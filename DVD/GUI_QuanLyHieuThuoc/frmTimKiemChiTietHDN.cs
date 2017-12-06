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
    public partial class frmTimKiemChiTietHDN : Form
    {
        BUS_CTHDN bus_cthdn = new BUS_CTHDN();
        public frmTimKiemChiTietHDN()
        {
            InitializeComponent();
        }

        private void frmTimKiemChiTietHDN_Load(object sender, EventArgs e)
        {
            cbCTHDN.DataSource = bus_cthdn.LoadMaCTHDN();
            cbCTHDN.DisplayMember = "macthdn";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbCTHDN.Text == "")
            {
                MessageBox.Show("Mã CTHDN không được để trống ! ");
            }
            else
            {
                dgvCTHDN.DataSource = bus_cthdn.TimKiemCTHDN(cbCTHDN.Text);
            }
            
        }
    }
}
