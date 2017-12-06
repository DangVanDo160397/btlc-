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
    public partial class frmHDB : Form
    {
        BUS_HDB bus_hdb = new BUS_HDB();

        BUS_NhanVien bus_nv = new BUS_NhanVien();

        public frmHDB()
        {
            InitializeComponent();
        }

        private void frmHDB_Load(object sender, EventArgs e)
        {
            dgv.DataSource = bus_hdb.LoadHDB();
            cbMaNhanVien.DataSource = bus_nv.LoadMaNhanVien();
            cbMaNhanVien.DisplayMember = "manhanvien";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHDB.Text == "")
            {
                MessageBox.Show("Mã HĐN trống ! ");
            }
            else if (cbMaNhanVien.Text == "")
            {
                MessageBox.Show("Mã nhân viên trống !");
            }
            else
            {

                HDB hdb = new HDB(txtMaHDB.Text, dtpGioBan.Value.ToString("yyyy-MM-dd"), cbMaNhanVien.Text);
                try
                {
                    if (bus_hdb.Them(hdb))
                    {
                        MessageBox.Show("Thêm rồi !");
                        frmHDB_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Mã trùng rồi !");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã trùng rồi !");
                }
                
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHDB.Text == "")
            {
                MessageBox.Show("Mã HĐN trống ! ");
            }
            else
            {
                try
                {
                    if (bus_hdb.Xoa(txtMaHDB.Text))
                    {
                        MessageBox.Show("Xóa rồi ! ");
                    }
                    else
                    {
                        MessageBox.Show("Không có mã đó !");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Không có mã đó !");
                }
                
            }
           
            frmHDB_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHDB.Text == "")
            {
                MessageBox.Show("Mã HĐN trống ! ");
            }
            else if (cbMaNhanVien.Text == "")
            {
                MessageBox.Show("Mã nhân viên trống !");
            }
            else
            {
                HDB hdb = new HDB(txtMaHDB.Text, dtpGioBan.Value.ToString("yyyy-MM-dd"), cbMaNhanVien.Text);
                try
                {
                    if (bus_hdb.Sua(hdb))
                    {
                        MessageBox.Show("Sửa rồi !");
                    }
                    else
                    {
                        MessageBox.Show("Không có mã đó !");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Không có mã đó  !");
                }
                
            }
            frmHDB_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            txtMaHDB.Text = dgv.Rows[vitri].Cells[0].Value.ToString();
            dtpGioBan.Text = dgv.Rows[vitri].Cells[1].Value.ToString();
            cbMaNhanVien.Text = dgv.Rows[vitri].Cells[2].Value.ToString();
        }



    }
}
