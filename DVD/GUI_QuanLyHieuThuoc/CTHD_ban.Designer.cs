namespace GUI_QuanLyHieuThuoc
{
    partial class CTHD_ban
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtHDB = new System.Windows.Forms.TextBox();
            this.cbMaNhanVien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.mahdb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHDThem = new System.Windows.Forms.Button();
            this.btnHDSua = new System.Windows.Forms.Button();
            this.btnHDXoa = new System.Windows.Forms.Button();
            this.btnHDThoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMaSanPham = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.macthdb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSPThem = new System.Windows.Forms.Button();
            this.btnSPSua = new System.Windows.Forms.Button();
            this.btnSPXoa = new System.Windows.Forms.Button();
            this.btnSPThoat = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoLuonBan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMacthdb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.btnTinhTong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HĐB";
            // 
            // txtHDB
            // 
            this.txtHDB.Location = new System.Drawing.Point(135, 26);
            this.txtHDB.Name = "txtHDB";
            this.txtHDB.Size = new System.Drawing.Size(182, 26);
            this.txtHDB.TabIndex = 1;
            // 
            // cbMaNhanVien
            // 
            this.cbMaNhanVien.FormattingEnabled = true;
            this.cbMaNhanVien.Location = new System.Drawing.Point(135, 139);
            this.cbMaNhanVien.Name = "cbMaNhanVien";
            this.cbMaNhanVien.Size = new System.Drawing.Size(182, 27);
            this.cbMaNhanVien.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày Bán";
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBan.Location = new System.Drawing.Point(135, 81);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(182, 26);
            this.dtpNgayBan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahdb,
            this.ngayban,
            this.maNhanVien});
            this.dgvHoaDon.Location = new System.Drawing.Point(357, 12);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(465, 298);
            this.dgvHoaDon.TabIndex = 4;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // mahdb
            // 
            this.mahdb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mahdb.DataPropertyName = "mahdb";
            this.mahdb.HeaderText = "Mã HĐB";
            this.mahdb.Name = "mahdb";
            // 
            // ngayban
            // 
            this.ngayban.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayban.DataPropertyName = "thoigian_ban";
            this.ngayban.HeaderText = "Ngày Bán";
            this.ngayban.Name = "ngayban";
            // 
            // maNhanVien
            // 
            this.maNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maNhanVien.DataPropertyName = "manhanvien";
            this.maNhanVien.HeaderText = "Nhân Viên";
            this.maNhanVien.Name = "maNhanVien";
            // 
            // btnHDThem
            // 
            this.btnHDThem.Location = new System.Drawing.Point(12, 215);
            this.btnHDThem.Name = "btnHDThem";
            this.btnHDThem.Size = new System.Drawing.Size(75, 29);
            this.btnHDThem.TabIndex = 5;
            this.btnHDThem.Text = "Thêm";
            this.btnHDThem.UseVisualStyleBackColor = true;
            this.btnHDThem.Click += new System.EventHandler(this.btnHDThem_Click);
            // 
            // btnHDSua
            // 
            this.btnHDSua.Location = new System.Drawing.Point(93, 215);
            this.btnHDSua.Name = "btnHDSua";
            this.btnHDSua.Size = new System.Drawing.Size(75, 29);
            this.btnHDSua.TabIndex = 5;
            this.btnHDSua.Text = "Sửa";
            this.btnHDSua.UseVisualStyleBackColor = true;
            // 
            // btnHDXoa
            // 
            this.btnHDXoa.Location = new System.Drawing.Point(174, 215);
            this.btnHDXoa.Name = "btnHDXoa";
            this.btnHDXoa.Size = new System.Drawing.Size(75, 29);
            this.btnHDXoa.TabIndex = 5;
            this.btnHDXoa.Text = "Xóa";
            this.btnHDXoa.UseVisualStyleBackColor = true;
            this.btnHDXoa.Click += new System.EventHandler(this.btnHDXoa_Click);
            // 
            // btnHDThoat
            // 
            this.btnHDThoat.Location = new System.Drawing.Point(255, 215);
            this.btnHDThoat.Name = "btnHDThoat";
            this.btnHDThoat.Size = new System.Drawing.Size(75, 29);
            this.btnHDThoat.TabIndex = 5;
            this.btnHDThoat.Text = "Thoát";
            this.btnHDThoat.UseVisualStyleBackColor = true;
            this.btnHDThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 418);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Sản Phẩm";
            // 
            // cbMaSanPham
            // 
            this.cbMaSanPham.FormattingEnabled = true;
            this.cbMaSanPham.Location = new System.Drawing.Point(135, 350);
            this.cbMaSanPham.Name = "cbMaSanPham";
            this.cbMaSanPham.Size = new System.Drawing.Size(182, 27);
            this.cbMaSanPham.TabIndex = 2;
            this.cbMaSanPham.SelectedValueChanged += new System.EventHandler(this.cbMaSanPham_SelectedValueChanged_1);
            this.cbMaSanPham.Click += new System.EventHandler(this.cbMaSanPham_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 468);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số Lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(135, 461);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(182, 26);
            this.txtSoLuong.TabIndex = 1;
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macthdb,
            this.dataGridViewTextBoxColumn1,
            this.masp,
            this.soluong});
            this.dgvCTHD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCTHD.Location = new System.Drawing.Point(0, 578);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.Size = new System.Drawing.Size(850, 172);
            this.dgvCTHD.TabIndex = 4;
            this.dgvCTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellClick);
            this.dgvCTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            // 
            // macthdb
            // 
            this.macthdb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.macthdb.DataPropertyName = "macthdb";
            this.macthdb.HeaderText = "Mã CTHDB";
            this.macthdb.Name = "macthdb";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "mahdb";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã HĐB";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // masp
            // 
            this.masp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.masp.DataPropertyName = "masanpham";
            this.masp.HeaderText = "Mã Sản Phẩm";
            this.masp.Name = "masp";
            // 
            // soluong
            // 
            this.soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số Lượng Bán";
            this.soluong.Name = "soluong";
            // 
            // btnSPThem
            // 
            this.btnSPThem.Location = new System.Drawing.Point(12, 512);
            this.btnSPThem.Name = "btnSPThem";
            this.btnSPThem.Size = new System.Drawing.Size(75, 29);
            this.btnSPThem.TabIndex = 5;
            this.btnSPThem.Text = "Thêm";
            this.btnSPThem.UseVisualStyleBackColor = true;
            this.btnSPThem.Click += new System.EventHandler(this.btnSPThem_Click);
            // 
            // btnSPSua
            // 
            this.btnSPSua.Location = new System.Drawing.Point(93, 512);
            this.btnSPSua.Name = "btnSPSua";
            this.btnSPSua.Size = new System.Drawing.Size(75, 29);
            this.btnSPSua.TabIndex = 5;
            this.btnSPSua.Text = "Sửa";
            this.btnSPSua.UseVisualStyleBackColor = true;
            this.btnSPSua.Click += new System.EventHandler(this.btnSPSua_Click);
            // 
            // btnSPXoa
            // 
            this.btnSPXoa.Location = new System.Drawing.Point(174, 512);
            this.btnSPXoa.Name = "btnSPXoa";
            this.btnSPXoa.Size = new System.Drawing.Size(75, 29);
            this.btnSPXoa.TabIndex = 5;
            this.btnSPXoa.Text = "Xóa";
            this.btnSPXoa.UseVisualStyleBackColor = true;
            this.btnSPXoa.Click += new System.EventHandler(this.btnSPXoa_Click);
            // 
            // btnSPThoat
            // 
            this.btnSPThoat.Location = new System.Drawing.Point(255, 512);
            this.btnSPThoat.Name = "btnSPThoat";
            this.btnSPThoat.Size = new System.Drawing.Size(75, 29);
            this.btnSPThoat.TabIndex = 5;
            this.btnSPThoat.Text = "Thoát";
            this.btnSPThoat.UseVisualStyleBackColor = true;
            this.btnSPThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(517, 454);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(182, 26);
            this.txtTongTien.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 291);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 19);
            this.label7.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 359);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã Sản Phẩm";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(135, 411);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(182, 26);
            this.txtTenSanPham.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 414);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số lượng bán";
            // 
            // txtSoLuonBan
            // 
            this.txtSoLuonBan.Location = new System.Drawing.Point(517, 411);
            this.txtSoLuonBan.Name = "txtSoLuonBan";
            this.txtSoLuonBan.Size = new System.Drawing.Size(182, 26);
            this.txtSoLuonBan.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 291);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã CTHDB";
            // 
            // txtMacthdb
            // 
            this.txtMacthdb.Location = new System.Drawing.Point(135, 291);
            this.txtMacthdb.Name = "txtMacthdb";
            this.txtMacthdb.Size = new System.Drawing.Size(182, 26);
            this.txtMacthdb.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(400, 361);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 19);
            this.label11.TabIndex = 6;
            this.label11.Text = "Giá Bán";
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(517, 361);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(182, 26);
            this.txtGiaban.TabIndex = 1;
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(404, 454);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(86, 33);
            this.btnTinhTong.TabIndex = 7;
            this.btnTinhTong.Text = "Tổng tiền";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // CTHD_ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 750);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSPThoat);
            this.Controls.Add(this.btnHDThoat);
            this.Controls.Add(this.btnSPXoa);
            this.Controls.Add(this.btnHDXoa);
            this.Controls.Add(this.btnSPSua);
            this.Controls.Add(this.btnHDSua);
            this.Controls.Add(this.btnSPThem);
            this.Controls.Add(this.btnHDThem);
            this.Controls.Add(this.dgvCTHD);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.dtpNgayBan);
            this.Controls.Add(this.cbMaSanPham);
            this.Controls.Add(this.cbMaNhanVien);
            this.Controls.Add(this.txtGiaban);
            this.Controls.Add(this.txtSoLuonBan);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtMacthdb);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtHDB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CTHD_ban";
            this.Text = "Chi tiết hóa đơn bán";
            this.Load += new System.EventHandler(this.CTHD_ban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHDB;
        private System.Windows.Forms.ComboBox cbMaNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btnHDThem;
        private System.Windows.Forms.Button btnHDSua;
        private System.Windows.Forms.Button btnHDXoa;
        private System.Windows.Forms.Button btnHDThoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMaSanPham;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.Button btnSPThem;
        private System.Windows.Forms.Button btnSPSua;
        private System.Windows.Forms.Button btnSPXoa;
        private System.Windows.Forms.Button btnSPThoat;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoLuonBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahdb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayban;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMacthdb;
        private System.Windows.Forms.DataGridViewTextBoxColumn macthdb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.Button btnTinhTong;
    }
}