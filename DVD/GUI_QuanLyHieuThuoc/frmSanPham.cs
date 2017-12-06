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
    public partial class frmSanPham : Form
    {
        BUS_SanPham bus_sp = new BUS_SanPham();

        BUS_ThuMuc bus_tm = new BUS_ThuMuc();

        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dgvQLSP.DataSource = bus_sp.Load();

            cbMaThuMuc.DataSource = bus_tm.LoadMaThuMuc();
            cbMaThuMuc.DisplayMember = "mathumuc";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSanPham.Text == "")
            {
                MessageBox.Show("Mã sản phẩm không được để trống !");
            }
            else if (txtTenSanPham.Text == "")
            {
                MessageBox.Show("Tên sản phẩm không được để trống !");
            }
            else if (txtGiaNhap.Text == "")
            {
                MessageBox.Show("Giá nhập không được để trống !");
            }
            else if (txtGiaBan.Text == "")
            {
                MessageBox.Show("Giá bán không được để trống !");
            }
            else if (cbMaThuMuc.Text == "")
            {
                MessageBox.Show("Mã thư mục không được để trống !");
            }
            else if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Số lượng không được để trống !");
            }
            else
            {
                try
                {
                    SanPham sp = new SanPham(txtMaSanPham.Text, txtTenSanPham.Text, float.Parse(txtGiaNhap.Text), float.Parse(txtGiaBan.Text), cbMaThuMuc.Text, Int32.Parse(txtSoLuong.Text));
                    if (bus_sp.Them(sp))
                    {
                        MessageBox.Show("Thêm rồi ! ");
                        frmSanPham_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Trùng mã rồi");
                    }
                }
                catch (Exception )
                {
                    MessageBox.Show("Trùng mã rồi");
                }
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (txtMaSanPham.Text == "")
            {
                MessageBox.Show("Mã sản phẩm không được để trống !");
            }
            else
            {
                try
                {
                    if (bus_sp.Xoa(txtMaSanPham.Text))
                    {
                        MessageBox.Show("Xóa thành công !");
                        frmSanPham_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Không có mã đó ! ");
                    }
                }
                catch (Exception )
                {

                    MessageBox.Show("Không có mã đó ! ");
                }
                
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSanPham.Text == "")
            {
                MessageBox.Show("Mã sản phẩm không được để trống !");
            }
            else if (txtTenSanPham.Text == "")
            {
                MessageBox.Show("Tên sản phẩm không được để trống !");
            }
            else if (txtGiaNhap.Text == "")
            {
                MessageBox.Show("Giá nhập không được để trống !");
            }
            else if (txtGiaBan.Text == "")
            {
                MessageBox.Show("Giá bán không được để trống !");
            }
            else if (cbMaThuMuc.Text == "")
            {
                MessageBox.Show("Mã thư mục không được để trống !");
            }
            else if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Số lượng không được để trống !");
            }
            else
            {
                try
                {
                    SanPham sp = new SanPham(txtMaSanPham.Text, txtTenSanPham.Text, float.Parse(txtGiaNhap.Text), float.Parse(txtGiaBan.Text), cbMaThuMuc.Text,Int32.Parse(txtSoLuong.Text));
                    if (bus_sp.Sua(sp))
                    {
                        MessageBox.Show("Sửa rồi ! ");
                        frmSanPham_Load(sender, e);
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
           
        }

        private void dgvQLSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri;
            vitri = e.RowIndex;
            txtMaSanPham.Text = dgvQLSP.Rows[vitri].Cells[0].Value.ToString();
            txtTenSanPham.Text = dgvQLSP.Rows[vitri].Cells[1].Value.ToString();
            txtGiaNhap.Text = dgvQLSP.Rows[vitri].Cells[2].Value.ToString();
            txtGiaBan.Text = dgvQLSP.Rows[vitri].Cells[3].Value.ToString();
            cbMaThuMuc.Text = dgvQLSP.Rows[vitri].Cells[4].Value.ToString();
            txtSoLuong.Text = dgvQLSP.Rows[vitri].Cells[5].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
