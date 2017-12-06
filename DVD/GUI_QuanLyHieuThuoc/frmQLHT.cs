using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLyHieuThuoc
{
    public partial class frmQLHT : Form
    {
        public frmQLHT()
        {
            InitializeComponent();
        }

        private void frmQLHT_Load(object sender, EventArgs e)
        {

        }

        private void qltt_FromClose(object sender, EventArgs e)
        {
            this.Show();
        }



        
        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHDB frmhdb = new frmHDB();
            frmhdb.FormClosed += new FormClosedEventHandler(qltt_FromClose);
            this.Hide();
            frmhdb.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham frmsp = new frmSanPham();
            frmsp.FormClosed += new FormClosedEventHandler(qltt_FromClose);
            this.Hide();
            frmsp.Show();
        }

        private void thưMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThuMuc frmtm = new frmThuMuc();
            frmtm.FormClosed += new FormClosedEventHandler(qltt_FromClose);
            this.Hide();
            frmtm.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNCC frmncc = new frmNCC();
            frmncc.FormClosed += new FormClosedEventHandler(qltt_FromClose);
            this.Hide();
            frmncc.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frmnv = new frmNhanVien();
            frmnv.FormClosed += new FormClosedEventHandler(qltt_FromClose);
            this.Hide();
            frmnv.Show();
            
        }

        private void chiTiếtHóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CTHD_ban cthd_ban = new CTHD_ban();
            cthd_ban.FormClosed += new FormClosedEventHandler(qltt_FromClose);
            this.Hide();
            cthd_ban.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHDN frmhdn = new frmHDN();
            frmhdn.FormClosed += new FormClosedEventHandler(qltt_FromClose);
            this.Hide();
            frmhdn.Show();
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHDB frmhdb = new frmHDB();
            frmhdb.FormClosed += new FormClosedEventHandler(qltt_FromClose);
            this.Hide();
            frmhdb.Show();
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CTHD_nhap cthdn = new CTHD_nhap();
            cthdn.FormClosed += new FormClosedEventHandler(qltt_FromClose);
            this.Hide();
            cthdn.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tìmKiếmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTimKiemSanPham tk_sp = new frmTimKiemSanPham();
            tk_sp.FormClosed += new FormClosedEventHandler(qltt_FromClose);
            this.Hide();
            tk_sp.Show();
        }

        private void nCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimkiemncc tk_ncc = new frmTimkiemncc();
            tk_ncc.FormClosed += new FormClosedEventHandler(qltt_FromClose);
            this.Hide();
            tk_ncc.Show();
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTimKiemNhanVien tk_nv = new frmTimKiemNhanVien();
            tk_nv.FormClosed += new FormClosedEventHandler(qltt_FromClose);
            this.Hide();
            tk_nv.Show();
        }

        private void hóaĐơnToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmTimKiemHDN tk_hdn = new frmTimKiemHDN();
            tk_hdn.FormClosed += new FormClosedEventHandler(qltt_FromClose);
            this.Hide();
            tk_hdn.Show();
        }

        private void chiTiếtHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemChiTietHDN tk_ctdhn = new frmTimKiemChiTietHDN();
            tk_ctdhn.FormClosed += new FormClosedEventHandler(qltt_FromClose);
            this.Hide();
            tk_ctdhn.Show();
        }

        private void hóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemHDB tk_hdb = new frmTimKiemHDB();
            tk_hdb.FormClosed += new FormClosedEventHandler(qltt_FromClose);
            this.Hide();
            tk_hdb.Show();
        }

        private void chiTiếtHóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemCTHDB tk_cthdb = new frmTimKiemCTHDB();
            tk_cthdb.FormClosed += new FormClosedEventHandler(qltt_FromClose);
            this.Hide();
            tk_cthdb.Show();
        }


    }
}
