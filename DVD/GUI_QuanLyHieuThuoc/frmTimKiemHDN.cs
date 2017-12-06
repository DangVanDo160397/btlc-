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
    public partial class frmTimKiemHDN : Form
    {
        BUS_HDN bus_hdn = new BUS_HDN();
        public frmTimKiemHDN()
        {
            InitializeComponent();
        }

        private void frmTimKiemHDN_Load(object sender, EventArgs e)
        {
            cbHDN.DataSource = bus_hdn.LoadMaHDN();
            cbHDN.DisplayMember = "mahdn";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbHDN.Text == "")
            {
                MessageBox.Show("Mã HĐN không được để trống ! ");
            }
            else
            {
                dgvHDN.DataSource = bus_hdn.TimKiemHDN(cbHDN.Text);
            }
            
        }
    }
}
