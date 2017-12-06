using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO_QuanLyHieuThuoc;
using BUS_QuanLyHieuThuoc;

namespace GUI_QuanLyHieuThuoc
{
    public partial class frmThuMuc : Form
    {
        BUS_ThuMuc bs_tm = new BUS_ThuMuc();

        public frmThuMuc()
        {
            InitializeComponent();
        }

        
        private void frmThuMuc_Load(object sender, EventArgs e)
        {
            dgvThuMuc.DataSource = bs_tm.LoadThuMuc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if (txtMaThuMuc.Text == "")
            {
                MessageBox.Show("Mã thư mục trống");
            }
            else if (txtTenThuMuc.Text == "")
            {
                MessageBox.Show("Tên thư mục trống !");
            }
            else
            {
                ThuMuc tm = new ThuMuc(txtMaThuMuc.Text, txtTenThuMuc.Text);
                try
                {
                    if (bs_tm.Them(tm))
                    {
                       // MessageBox.Show("Đã thêm");
                    }
                    else
                    {
                        MessageBox.Show("Mã trùng ");
                    }

                }
                catch (Exception)
                {
                    
                    throw;
                }
                
            }
            frmThuMuc_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String mtm = txtMaThuMuc.Text;

            if (mtm == "")
            {
                MessageBox.Show("Mã Thư Mục Trống !");

            }
            else
            {
                try 
	            {	        
		            if (bs_tm.Xoa(mtm))
                    {
                        MessageBox.Show("Xóa rồi!");
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

            frmThuMuc_Load(sender, e);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (txtMaThuMuc.Text == "")
            {
                MessageBox.Show("Mã Thư Mục Trống ! ");
            }
            else if (txtTenThuMuc.Text == "")
            {
                MessageBox.Show("Tên Thư Mục Trống !");
            }
            else
            {
                try
                {
                    ThuMuc tm = new ThuMuc(txtMaThuMuc.Text, txtTenThuMuc.Text);
                    if (bs_tm.Sua(tm))
                    {
                        MessageBox.Show("Đã Sửa ! ");
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

            frmThuMuc_Load(sender, e);
        }

        private void dgvThuMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = 0;
            vitri = e.RowIndex;
            txtMaThuMuc.Text = dgvThuMuc.Rows[vitri].Cells[0].Value.ToString();
            txtTenThuMuc.Text = dgvThuMuc.Rows[vitri].Cells[1].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
