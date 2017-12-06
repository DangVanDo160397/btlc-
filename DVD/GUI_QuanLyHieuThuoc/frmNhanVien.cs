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
    public partial class frmNhanVien : Form
    {
        BUS_NhanVien bus_nv = new BUS_NhanVien();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgv.DataSource = bus_nv.LoadNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {   
            if(txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống ! ");
            }
            else if (txtTenNhanVien.Text == "")
            {
                MessageBox.Show("Tên nhân viên không được để trống ! ");
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ không được để trống ! ");
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ không được để trống ! ");
            }
            else if (txtSoDienThoai.Text == "")
            {
                MessageBox.Show("Số điện thoại không được để trống ! ");
            }
            else
            {
                try
                {
                    bool gt;
                    if (rbNam.Checked)
                    {
                        gt = true;
                    }
                    else
                    {
                        gt = false;
                    }
                    NhanVien sv = new NhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, txtDiaChi.Text, gt, dateTimePicker1.Value.ToString("yyyy-MM-dd"), txtSoDienThoai.Text);
                    if (bus_nv.Them(sv))
                    {
                        MessageBox.Show("Thêm rồi ! ");
                    }
                    else
                    {
                        MessageBox.Show("Mã Trùng ! ");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Mã Trùng ! ");
                }
            
            }
            
            frmNhanVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống ! ");
            }
            else
            {
                bus_nv.Xoa(txtMaNhanVien.Text);
            }
            frmNhanVien_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống ! ");
            }
            else if (txtTenNhanVien.Text == "")
            {
                MessageBox.Show("Tên nhân viên không được để trống ! ");
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ không được để trống ! ");
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ không được để trống ! ");
            }
            else if (txtSoDienThoai.Text == "")
            {
                MessageBox.Show("Số điện thoại không được để trống ! ");
            }
            else
            {
                try
                {
                    bool gt;
                    if (rbNam.Checked)
                    {
                        gt = true;
                    }
                    else
                    {
                        gt = false;
                    }
                    NhanVien sv = new NhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, txtDiaChi.Text, gt, dateTimePicker1.Value.ToString("yyyy-MM-dd"), txtSoDienThoai.Text);
                    if (bus_nv.Sua(sv))
                    {
                        MessageBox.Show("Thêm rồi ! ");
                    }
                    else
                    {
                        MessageBox.Show("Không có mã đó! ");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Không có mã đó ! ");
                }

            }
            frmNhanVien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri;
            vitri = e.RowIndex;
            txtMaNhanVien.Text = dgv.Rows[vitri].Cells[0].Value.ToString();
            txtTenNhanVien.Text = dgv.Rows[vitri].Cells[1].Value.ToString();
            txtDiaChi.Text = dgv.Rows[vitri].Cells[2].Value.ToString();
            if (dgv.Rows[vitri].Cells[3].Value.Equals(true))
                rbNam.Checked = true;
            else 
                rbNu.Checked = true;
            dateTimePicker1.Text = dgv.Rows[vitri].Cells[4].Value.ToString();
            txtSoDienThoai.Text = dgv.Rows[vitri].Cells[5].Value.ToString();
            

        }




      

    }
}
