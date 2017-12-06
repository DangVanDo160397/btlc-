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
    public partial class frmTimKiemHDB : Form
    {
        BUS_HDB bus_hdb = new BUS_HDB();
        public frmTimKiemHDB()
        {
            InitializeComponent();
        }

        private void frmTimKiemHDB_Load(object sender, EventArgs e)
        {
            cbMaHDB.DataSource = bus_hdb.LoadMaHDB();
            cbMaHDB.DisplayMember = "mahdb";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbMaHDB.Text == "")
            {
                MessageBox.Show("Mã HĐB ! ");
            }
            else
            {
                dgvHDB.DataSource = bus_hdb.TimKiemHDB(cbMaHDB.Text);
            }
            
        }
        
    }
}
