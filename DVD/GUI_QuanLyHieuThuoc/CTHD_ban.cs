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
    public partial class CTHD_ban : Form
    {
        BUS_SanPham bus_sp = new BUS_SanPham();
        BUS_HDB bus_hdb = new BUS_HDB();
        BUS_CTHDB bus_cthdb = new BUS_CTHDB();

         DataTable dt;

        bool checkClick = false;
        BUS_NhanVien bus_nv = new BUS_NhanVien();

        public CTHD_ban()
        {
            InitializeComponent();
        }

        private void CTHD_ban_Load(object sender, EventArgs e)
        {
            dt = bus_sp.Load();

            cbMaSanPham.DataSource = dt;
            cbMaSanPham.DisplayMember = "masanpham";

            cbMaNhanVien.DataSource = bus_nv.LoadMaNhanVien();
            cbMaNhanVien.DisplayMember = "manhanvien";

            dgvCTHD.DataSource = bus_cthdb.LoadCTHDB();

            dgvHoaDon.DataSource = bus_hdb.LoadHDB();

            

            
        }


        private void btnHDSua_Click(object sender, EventArgs e)
        {
            if (txtHDB.Text == "")
            {
                MessageBox.Show("Mã HĐN trống ! ");
            }
            else if (cbMaNhanVien.Text == "")
            {
                MessageBox.Show("Mã nhân viên trống !");
            }
            else
            {
                HDB hdb = new HDB(txtHDB.Text, dtpNgayBan.Value.ToString("yyyy-MM-dd"), cbMaNhanVien.Text);
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
            CTHD_ban_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cbMaSanPham_SelectedValueChanged(object sender, EventArgs e)
        {
            if (checkClick)
            {
                txtTenSanPham.Text = dt.Rows[cbMaSanPham.SelectedIndex]["tensanpham"].ToString();
                txtSoLuong.Text = dt.Rows[cbMaSanPham.SelectedIndex]["soluong"].ToString();
                txtGiaban.Text = dt.Rows[cbMaSanPham.SelectedIndex]["giaban"].ToString();
            }
        }

        private void cbMaSanPham_Click(object sender, EventArgs e)
        {
            checkClick = true;
        }

        private void btnHDThem_Click(object sender, EventArgs e)
        {
            if (txtHDB.Text == "")
            {
                MessageBox.Show("Mã HĐN trống ! ");
            }
            else if (cbMaNhanVien.Text == "")
            {
                MessageBox.Show("Mã nhân viên trống !");
            }
            else
            {

                HDB hdb = new HDB(txtHDB.Text, dtpNgayBan.Value.ToString("yyyy-MM-dd"), cbMaNhanVien.Text);
                try
                {
                    if (bus_hdb.Them(hdb))
                    {
                        MessageBox.Show("Thêm rồi !");
                        CTHD_ban_Load(sender, e);
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

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;

            txtMacthdb.Text = dgvCTHD.Rows[vitri].Cells[0].Value.ToString();

            txtHDB.Text = dgvCTHD.Rows[vitri].Cells[1].Value.ToString();

            cbMaNhanVien.Text = dgvCTHD.Rows[vitri].Cells[2].Value.ToString();

            txtSoLuonBan.Text = dgvCTHD.Rows[vitri].Cells[3].Value.ToString();
        }

        private void btnHDXoa_Click(object sender, EventArgs e)
        {
            if (txtHDB.Text == "")
            {
                MessageBox.Show("Mã HĐN trống ! ");
            }
            else
            {
                try
                {
                    if (bus_hdb.Xoa(txtHDB.Text))
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

            CTHD_ban_Load(sender, e);
        }

        private void btnSPThem_Click(object sender, EventArgs e)
        {
            if (txtMacthdb.Text == "")
            {
                MessageBox.Show("Mã CTHDB Trống !");
            }
            else if (txtHDB.Text == "")
            {
                MessageBox.Show("Mã HĐB Trống !");
            }
            else if (cbMaSanPham.Text == "")
            {
                MessageBox.Show("Mã Sản Phẩm Trống !");
            }
            else if (txtSoLuonBan.Text == "")
            {
                MessageBox.Show("Số lượng bán Trống !");
            }
            else
            {
                ChiTietHoaDonBan cthdb = new ChiTietHoaDonBan(txtMacthdb.Text, txtHDB.Text, cbMaSanPham.Text, Int32.Parse(txtSoLuonBan.Text));
                try
                {
                    if (bus_cthdb.Them(cthdb))
                    {
                        MessageBox.Show("Thêm thành công !");
                    }
                    else 
                    {
                        MessageBox.Show("Mã CTHDB trùng");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Mã CTHDB trùng");
                }
            }
 
        }

        private void btnSPSua_Click(object sender, EventArgs e)
        {
           if (txtMacthdb.Text == "")
            {
                MessageBox.Show("Mã CTHDB Trống !");
            }
            else if (txtHDB.Text == "")
            {
                MessageBox.Show("Mã HĐB Trống !");
            }
            else if (cbMaSanPham.Text == "")
            {
                MessageBox.Show("Mã Sản Phẩm Trống !");
            }
            else if (txtSoLuonBan.Text == "")
            {
                MessageBox.Show("Số lượng bán Trống !");
            }
            else
            {
                ChiTietHoaDonBan cthdb = new ChiTietHoaDonBan(txtMacthdb.Text, txtHDB.Text, cbMaSanPham.Text, Int32.Parse(txtSoLuonBan.Text));
                try
                {
                    if (bus_cthdb.Sua(cthdb))
                    {
                        MessageBox.Show("Sửa thành công !");
                    }
                    else 
                    {
                        MessageBox.Show("Mã CTHDB không đúng");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Mã CTHDB không đúng");
                }
            }
        }

        private void btnSPXoa_Click(object sender, EventArgs e)
        {
            if (txtMacthdb.Text == "")
            {
                MessageBox.Show("Mã CTHDB Trống !");
            }
            else
            {
                try
                {
                    if (bus_cthdb.Xoa(txtMacthdb.Text))
                    {
                        MessageBox.Show("Xóa thành công !");
                        CTHD_ban_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Mã CTHDB không đúng ! ");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Mã CTHDB không đúng ! ");
                }
            }
            
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            if (txtSoLuonBan.Text == "")
            {
                MessageBox.Show("Số lượng bán không được để trống ! ");
            }
            else if (txtGiaban.Text == "")
            {
                MessageBox.Show("Giá bán không được để trống !");
            }
            else
            {
                int a = Int32.Parse(txtSoLuonBan.Text);
                float b = float.Parse(txtGiaban.Text);
                float tong = a * b;
                txtTongTien.Text = tong.ToString(); 
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;

            txtHDB.Text = dgvHoaDon.Rows[vitri].Cells[0].Value.ToString();
            dtpNgayBan.Text = dgvHoaDon.Rows[vitri].Cells[1].Value.ToString();
            cbMaNhanVien.Text = dgvHoaDon.Rows[vitri].Cells[2].Value.ToString();
        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            txtMacthdb.Text = dgvCTHD.Rows[vitri].Cells[0].Value.ToString();
            txtHDB.Text = dgvCTHD.Rows[vitri].Cells[1].Value.ToString();
            cbMaSanPham.Text = dgvCTHD.Rows[vitri].Cells[2].Value.ToString();
            txtSoLuonBan.Text = dgvCTHD.Rows[vitri].Cells[3].Value.ToString();
        }

        private void cbMaSanPham_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (checkClick)
            {
                txtTenSanPham.Text = dt.Rows[cbMaSanPham.SelectedIndex]["tensanpham"].ToString();
                txtSoLuong.Text = dt.Rows[cbMaSanPham.SelectedIndex]["soluong"].ToString();
                txtGiaban.Text = dt.Rows[cbMaSanPham.SelectedIndex]["giaban"].ToString();
            }
        }

        
    }
}
