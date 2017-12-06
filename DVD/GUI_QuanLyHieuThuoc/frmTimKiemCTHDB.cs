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
    public partial class frmTimKiemCTHDB : Form
    {
        BUS_CTHDB bus_cthdb = new BUS_CTHDB();

        public frmTimKiemCTHDB()
        {
            InitializeComponent();
        }

        private void frmTimKiemCTHDB_Load(object sender, EventArgs e)
        {
            cbCTHDB.DataSource = bus_cthdb.LoadMaCTHDB();
            cbCTHDB.DisplayMember = "macthdb";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbCTHDB.Text == "")
            {
                MessageBox.Show("Mã CTHDB không được để trống ! ");
            }
            else
            {
                dgvCTHDB.DataSource = bus_cthdb.TimKiemCTHDB(cbCTHDB.Text);  
            }
            
        }
    }
}
