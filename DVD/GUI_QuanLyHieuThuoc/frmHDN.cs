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
    public partial class frmHDN : Form
    {
        BUS_HDN bus_hdn = new BUS_HDN();

        BUS_NCC bus_ncc = new BUS_NCC();

        BUS_NhanVien bus_nv = new BUS_NhanVien();

        public frmHDN()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHDN.Text == "")
            {
                MessageBox.Show("Mã HĐN trống ! ");          
            }
            else if (cbMaNhanVien.Text == "")
            {
                MessageBox.Show("Mã nhân viên trống !");
            }
            else if (cbMaNCC.Text == "")
            {
                MessageBox.Show("Mã NCC trống !");
            }
            else
            {
                HDN hdn = new HDN(txtMaHDN.Text, dtnNgayNhap.Value.ToString("yyyy-MM-dd"), cbMaNhanVien.Text, cbMaNCC.Text);
                try
                {
                    if (bus_hdn.Them(hdn))
                    {
                        MessageBox.Show("Thêm rồi ! ");
                    }
                    else
                    {
                        MessageBox.Show("Trùng mã  ! ");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Trùng mã  ! ");
                }
                
            }
            
            frmHDN_Load(sender, e);
           
        }

        private void frmHDN_Load(object sender, EventArgs e)
        {
            dgv.DataSource = bus_hdn.LoadHDN();
            cbMaNCC.DataSource = bus_ncc.LoadMaNCC();
            cbMaNCC.DisplayMember = "mancc";

            cbMaNhanVien.DataSource = bus_nv.LoadMaNhanVien();
            cbMaNhanVien.DisplayMember = "manhanvien";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHDN.Text == "")
            {
                MessageBox.Show("Mã HĐN trống ! ");
            }
            else if (cbMaNhanVien.Text == "")
            {
                MessageBox.Show("Mã nhân viên trống !");
            }
            else if (cbMaNCC.Text == "")
            {
                MessageBox.Show("Mã NCC trống !");
            }
            else
            {
                HDN hdn = new HDN(txtMaHDN.Text, dtnNgayNhap.Value.ToString("yyyy-MM-dd"), cbMaNhanVien.Text, cbMaNCC.Text);
                try
                {
                    if (bus_hdn.Sua(hdn))
                    {
                        MessageBox.Show("Sửa rồi ! ");
                    }
                    else
                    {
                        MessageBox.Show("Không có mã đó   ! ");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Không có mã đó  ! ");
                }
                
            }

            frmHDN_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHDN.Text == "")
            {
                MessageBox.Show("Mã HĐN trống ! ");
            }
            else
            {
                try
                {
                    if (bus_hdn.Xoa(txtMaHDN.Text))
                    {
                        MessageBox.Show("Xóa thành công ! ");
                    }
                    else
                    {
                        MessageBox.Show("Không có mã đó ! ");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Không có mã đó ! ");
                }
                

            }
            frmHDN_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri;
            vitri = e.RowIndex;

            txtMaHDN.Text = dgv.Rows[vitri].Cells[0].Value.ToString();
            dtnNgayNhap.Text = dgv.Rows[vitri].Cells[1].Value.ToString();
            cbMaNhanVien.Text = dgv.Rows[vitri].Cells[2].Value.ToString();
            cbMaNCC.Text = dgv.Rows[vitri].Cells[3].Value.ToString();
        }

        
    }
}
