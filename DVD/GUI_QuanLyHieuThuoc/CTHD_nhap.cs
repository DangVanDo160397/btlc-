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
    public partial class CTHD_nhap : Form
    {
        BUS_CTHDN bus_cthdn = new BUS_CTHDN();
        DataTable dt;
        BUS_HDN bus_hdn = new BUS_HDN();

        BUS_SanPham bus_sp = new BUS_SanPham();
        BUS_NhanVien bus_nv = new BUS_NhanVien();
        BUS_NCC bus_ncc = new BUS_NCC();

        bool checkClick = false;
        public CTHD_nhap()
        {
            InitializeComponent();
        }


        public int tinhTongSoluong()
        {
            int a = Int32.Parse(txtSoLuong.Text);
            int b = Int32.Parse(txtSoLuongNhap.Text);
            int tong = a + b;
            return tong;
        }

        private void CTHD_nhap_Load(object sender, EventArgs e)
        {
            dt = bus_sp.Load();
            cbMaSP.DataSource = bus_sp.LoadMaSanPham();
            cbMaSP.DisplayMember = "masanpham";

            cbNhanVien.DataSource = bus_nv.LoadMaNhanVien();
            cbNhanVien.DisplayMember = "manhanvien";
            cbNCC.DataSource = bus_ncc.LoadMaNCC();
            cbNCC.DisplayMember = "mancc";
            dgvHoaDon.DataSource = bus_hdn.LoadHDN();
            dgvSanPham.DataSource = bus_cthdn.LoadCTHDN();
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbMaSP_Click(object sender, EventArgs e)
        {
            this.checkClick = true;
        }

        private void cbMaSP_SelectedValueChanged(object sender, EventArgs e)
        {
            if (checkClick)
            {
                txtTenSP.Text = dt.Rows[cbMaSP.SelectedIndex]["tensanpham"].ToString();
                txtSoLuong.Text = dt.Rows[cbMaSP.SelectedIndex]["soluong"].ToString();
            }
        }

        private void cbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;

            txtMaHDN.Text = dgvHoaDon.Rows[vitri].Cells[0].Value.ToString();
            dtpNgayNhap.Text = dgvHoaDon.Rows[vitri].Cells[1].Value.ToString();
            cbNhanVien.Text = dgvHoaDon.Rows[vitri].Cells[2].Value.ToString();
            cbNCC.Text = dgvHoaDon.Rows[vitri].Cells[3].Value.ToString();
            
        }

        private void btnHDThem_Click(object sender, EventArgs e)
        {
            if (txtMaHDN.Text == "")
            {
                MessageBox.Show("Mã HĐN trống ! ");
            }
            else if (cbNhanVien.Text == "")
            {
                MessageBox.Show("Mã nhân viên trống !");
            }
            else if (cbNCC.Text == "")
            {
                MessageBox.Show("Mã NCC trống !");
            }
            else
            {
                HDN hdn = new HDN(txtMaHDN.Text, dtpNgayNhap.Value.ToString("yyyy-MM-dd"), cbNhanVien.Text, cbNCC.Text);
                try
                {
                    if (bus_hdn.Them(hdn))
                    {
                        MessageBox.Show("Thêm rồi ! ");
                        CTHD_nhap_Load(sender, e);
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

            
           
        }

        private void btnHDSua_Click(object sender, EventArgs e)
        {
            if (txtMaHDN.Text == "")
            {
                MessageBox.Show("Mã HĐN trống ! ");
            }
            else if (cbNhanVien.Text == "")
            {
                MessageBox.Show("Mã nhân viên trống !");
            }
            else if (cbNCC.Text == "")
            {
                MessageBox.Show("Mã NCC trống !");
            }
            else
            {
                HDN hdn = new HDN(txtMaHDN.Text, dtpNgayNhap.Value.ToString("yyyy-MM-dd"), cbNhanVien.Text, cbNCC.Text);
                try
                {
                    if (bus_hdn.Sua(hdn))
                    {
                        MessageBox.Show("Sửa rồi ! ");
                        CTHD_nhap_Load(sender, e);
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
        }

        private void btnHDXoa_Click(object sender, EventArgs e)
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
                        CTHD_nhap_Load(sender, e);
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

        private void btnHDThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemCthdn_Click(object sender, EventArgs e)
        {
            if (txtMacthdn.Text == "")
            {
                MessageBox.Show("Mã CTHDB Trống !");
            }
            else if (txtMaHDN.Text == "")
            {
                MessageBox.Show("Mã HĐB Trống !");
            }
            else if (cbMaSP.Text == "")
            {
                MessageBox.Show("Mã Sản Phẩm Trống !");
            }
            else if (txtSoLuongNhap.Text == "")
            {
                MessageBox.Show("Số lượng bán Trống !");
            }
            else
            {
                ChiTietHoaDonNhap cthdn = new ChiTietHoaDonNhap(txtMacthdn.Text, txtMaHDN.Text, cbMaSP.Text, Int32.Parse(txtSoLuongNhap.Text));
                try
                {
                    if (bus_cthdn.Them(cthdn))
                    {
                        MessageBox.Show("Thêm thành công !");
                        
                        bus_sp.SuaSoLuong(tinhTongSoluong(), cbMaSP.Text);
                        CTHD_nhap_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Mã CTHDN trùng");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Mã CTHDN trùng");
                }
            }

            

        }

        private void btnSuacthdn_Click(object sender, EventArgs e)
        {
            if (txtMacthdn.Text == "")
            {
                MessageBox.Show("Mã CTHDB Trống !");
            }
            else if (txtMaHDN.Text == "")
            {
                MessageBox.Show("Mã HĐB Trống !");
            }
            else if (cbMaSP.Text == "")
            {
                MessageBox.Show("Mã Sản Phẩm Trống !");
            }
            else if (txtSoLuongNhap.Text == "")
            {
                MessageBox.Show("Số lượng bán Trống !");
            }
            else
            {
                ChiTietHoaDonNhap cthdn = new ChiTietHoaDonNhap(txtMacthdn.Text, txtMaHDN.Text, cbMaSP.Text, Int32.Parse(txtSoLuongNhap.Text));
                try
                {
                    if (bus_cthdn.Sua(cthdn))
                    {
                        MessageBox.Show("Sửa thành công !");
                        CTHD_nhap_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Không có mã đó");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Mã CTHDN trùng");
                }
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;

            txtMacthdn.Text = dgvSanPham.Rows[vitri].Cells[0].Value.ToString();
            txtMaHDN.Text = dgvSanPham.Rows[vitri].Cells[1].Value.ToString();
            cbMaSP.Text = dgvSanPham.Rows[vitri].Cells[2].Value.ToString();
            txtSoLuongNhap.Text = dgvSanPham.Rows[vitri].Cells[3].Value.ToString();
        }

        private void btnXoacthdn_Click(object sender, EventArgs e)
        {
            if (txtMacthdn.Text == "")
            {
                MessageBox.Show("Mã CTHDN Trống !");
            }
            else
            {
                try
                {
                    if (bus_cthdn.Xoa(txtMacthdn.Text))
                    {
                        MessageBox.Show("Xóa thành công !");
                        CTHD_nhap_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Mã CTHDN không đúng ! ");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Mã CTHDN không đúng ! ");
                }
            }
        }

        private void btnThoatcthd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
