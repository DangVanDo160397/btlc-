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
    public partial class frmNCC : Form
    {
        BUS_NCC bus_ncc = new BUS_NCC();

        public frmNCC()
        {
            InitializeComponent();
        }

        private void frmNCCcs_Load(object sender, EventArgs e)
        {
            dgv.DataSource = bus_ncc.LoadNCC();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Mã NCC không được để trống !");
            }
            else if (txtTenNCC.Text == "")
            {
                MessageBox.Show("Tên NCC không được để trống !");
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show(" Địa chỉ không được để trống !");
            }
            else if (txtSDT.Text == "")
            {
                MessageBox.Show("Số điện thoại không được để trống !");
            }
            else
            { 
                NCC ncc = new NCC(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text);
                if (bus_ncc.Them(ncc))
                {
                    MessageBox.Show("Thêm rồi !");
                }
                else
                {
                    MessageBox.Show("Nhập lỗi !");
                }
            
            }
            frmNCCcs_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Mã NCC không được để trống !");
            }
            else if (txtTenNCC.Text == "")
            {
                MessageBox.Show("Tên NCC không được để trống !");
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show(" Địa chỉ không được để trống !");
            }
            else if (txtSDT.Text == "")
            {
                MessageBox.Show("Số điện thoại không được để trống !");
            }
            else
            {
                NCC ncc = new NCC(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text);
                try
                {
                    if (bus_ncc.Sua(ncc))
                    {
                        MessageBox.Show("Sửa rồi !");
                    }
                    else
                    {
                        MessageBox.Show("Không có mã  đó !");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Không có mã  đó !");
                }
                
            }

            frmNCCcs_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Mã NCC không được để trống !");
            }
            else
            {
                try
                {
                    if (bus_ncc.Xoa(txtMaNCC.Text))
                    {
                        MessageBox.Show("Xóa thành công ");
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
            frmNCCcs_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            txtMaNCC.Text = dgv.Rows[vitri].Cells[0].Value.ToString();
            txtTenNCC.Text = dgv.Rows[vitri].Cells[1].Value.ToString();
            txtDiaChi.Text = dgv.Rows[vitri].Cells[2].Value.ToString();
            txtSDT.Text = dgv.Rows[vitri].Cells[3].Value.ToString();
        }



    }
}
