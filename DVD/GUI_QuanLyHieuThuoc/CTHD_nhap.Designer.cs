namespace GUI_QuanLyHieuThuoc
{
    partial class CTHD_nhap
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
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.btnHDThem = new System.Windows.Forms.Button();
            this.btnHDSua = new System.Windows.Forms.Button();
            this.btnHDXoa = new System.Windows.Forms.Button();
            this.btnHDThoat = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.mahdn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.macthdn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMaSP = new System.Windows.Forms.ComboBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.btnThemCthdn = new System.Windows.Forms.Button();
            this.btnSuacthdn = new System.Windows.Forms.Button();
            this.btnXoacthdn = new System.Windows.Forms.Button();
            this.btnThoatcthd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMacthdn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HĐN";
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.Location = new System.Drawing.Point(127, 24);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.Size = new System.Drawing.Size(182, 26);
            this.txtMaHDN.TabIndex = 1;
            this.txtMaHDN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày Nhập";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(127, 76);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(182, 26);
            this.dtpNgayNhap.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Nhân Viên";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã NCC";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(125, 116);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(182, 27);
            this.cbNhanVien.TabIndex = 3;
            // 
            // btnHDThem
            // 
            this.btnHDThem.Location = new System.Drawing.Point(25, 212);
            this.btnHDThem.Name = "btnHDThem";
            this.btnHDThem.Size = new System.Drawing.Size(75, 34);
            this.btnHDThem.TabIndex = 4;
            this.btnHDThem.Text = "Thêm";
            this.btnHDThem.UseVisualStyleBackColor = true;
            this.btnHDThem.Click += new System.EventHandler(this.btnHDThem_Click);
            // 
            // btnHDSua
            // 
            this.btnHDSua.Location = new System.Drawing.Point(112, 212);
            this.btnHDSua.Name = "btnHDSua";
            this.btnHDSua.Size = new System.Drawing.Size(75, 34);
            this.btnHDSua.TabIndex = 4;
            this.btnHDSua.Text = "Sửa";
            this.btnHDSua.UseVisualStyleBackColor = true;
            this.btnHDSua.Click += new System.EventHandler(this.btnHDSua_Click);
            // 
            // btnHDXoa
            // 
            this.btnHDXoa.Location = new System.Drawing.Point(193, 212);
            this.btnHDXoa.Name = "btnHDXoa";
            this.btnHDXoa.Size = new System.Drawing.Size(75, 34);
            this.btnHDXoa.TabIndex = 4;
            this.btnHDXoa.Text = "Xóa";
            this.btnHDXoa.UseVisualStyleBackColor = true;
            this.btnHDXoa.Click += new System.EventHandler(this.btnHDXoa_Click);
            // 
            // btnHDThoat
            // 
            this.btnHDThoat.Location = new System.Drawing.Point(287, 212);
            this.btnHDThoat.Name = "btnHDThoat";
            this.btnHDThoat.Size = new System.Drawing.Size(75, 34);
            this.btnHDThoat.TabIndex = 4;
            this.btnHDThoat.Text = "Thoát";
            this.btnHDThoat.UseVisualStyleBackColor = true;
            this.btnHDThoat.Click += new System.EventHandler(this.btnHDThoat_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahdn,
            this.ngaynhap,
            this.manhanvien,
            this.mancc});
            this.dgvHoaDon.Location = new System.Drawing.Point(368, 24);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(460, 330);
            this.dgvHoaDon.TabIndex = 5;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // mahdn
            // 
            this.mahdn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mahdn.DataPropertyName = "mahdn";
            this.mahdn.HeaderText = "Mã HĐN";
            this.mahdn.Name = "mahdn";
            // 
            // ngaynhap
            // 
            this.ngaynhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaynhap.DataPropertyName = "thoigian_nhap";
            this.ngaynhap.HeaderText = "Ngày Nhập";
            this.ngaynhap.Name = "ngaynhap";
            // 
            // manhanvien
            // 
            this.manhanvien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.manhanvien.DataPropertyName = "manhanvien";
            this.manhanvien.HeaderText = "Mã Nhân Viên";
            this.manhanvien.Name = "manhanvien";
            // 
            // mancc
            // 
            this.mancc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mancc.DataPropertyName = "mancc";
            this.mancc.HeaderText = "Mã NCC";
            this.mancc.Name = "mancc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên Sản Phẩm";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số Lượng Còn";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(149, 478);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(182, 26);
            this.txtSoLuong.TabIndex = 1;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbNCC
            // 
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(127, 163);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(182, 27);
            this.cbNCC.TabIndex = 3;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macthdn,
            this.mahd,
            this.masp,
            this.soluong});
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSanPham.Location = new System.Drawing.Point(0, 600);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(828, 150);
            this.dgvSanPham.TabIndex = 6;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // macthdn
            // 
            this.macthdn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.macthdn.DataPropertyName = "macthdn";
            this.macthdn.HeaderText = "Mã CTHDN";
            this.macthdn.Name = "macthdn";
            // 
            // mahd
            // 
            this.mahd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mahd.DataPropertyName = "mahdn";
            this.mahd.HeaderText = "Mã HĐN";
            this.mahd.Name = "mahd";
            // 
            // masp
            // 
            this.masp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.masp.DataPropertyName = "masp";
            this.masp.HeaderText = "Mã Sản Phẩm";
            this.masp.Name = "masp";
            // 
            // soluong
            // 
            this.soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số Lượng";
            this.soluong.Name = "soluong";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã Sản Phẩm";
            this.label8.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbMaSP
            // 
            this.cbMaSP.FormattingEnabled = true;
            this.cbMaSP.Location = new System.Drawing.Point(149, 359);
            this.cbMaSP.Name = "cbMaSP";
            this.cbMaSP.Size = new System.Drawing.Size(182, 27);
            this.cbMaSP.TabIndex = 3;
            this.cbMaSP.SelectedIndexChanged += new System.EventHandler(this.cbMaSP_SelectedIndexChanged);
            this.cbMaSP.SelectedValueChanged += new System.EventHandler(this.cbMaSP_SelectedValueChanged);
            this.cbMaSP.Click += new System.EventHandler(this.cbMaSP_Click);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(149, 415);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(182, 26);
            this.txtTenSP.TabIndex = 1;
            this.txtTenSP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số Lượng Nhập";
            this.label9.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.Location = new System.Drawing.Point(488, 415);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(182, 26);
            this.txtSoLuongNhap.TabIndex = 1;
            this.txtSoLuongNhap.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnThemCthdn
            // 
            this.btnThemCthdn.Location = new System.Drawing.Point(31, 531);
            this.btnThemCthdn.Name = "btnThemCthdn";
            this.btnThemCthdn.Size = new System.Drawing.Size(75, 34);
            this.btnThemCthdn.TabIndex = 4;
            this.btnThemCthdn.Text = "Thêm";
            this.btnThemCthdn.UseVisualStyleBackColor = true;
            this.btnThemCthdn.Click += new System.EventHandler(this.btnThemCthdn_Click);
            // 
            // btnSuacthdn
            // 
            this.btnSuacthdn.Location = new System.Drawing.Point(112, 531);
            this.btnSuacthdn.Name = "btnSuacthdn";
            this.btnSuacthdn.Size = new System.Drawing.Size(75, 34);
            this.btnSuacthdn.TabIndex = 4;
            this.btnSuacthdn.Text = "Sửa";
            this.btnSuacthdn.UseVisualStyleBackColor = true;
            this.btnSuacthdn.Click += new System.EventHandler(this.btnSuacthdn_Click);
            // 
            // btnXoacthdn
            // 
            this.btnXoacthdn.Location = new System.Drawing.Point(193, 531);
            this.btnXoacthdn.Name = "btnXoacthdn";
            this.btnXoacthdn.Size = new System.Drawing.Size(75, 34);
            this.btnXoacthdn.TabIndex = 4;
            this.btnXoacthdn.Text = "Xóa";
            this.btnXoacthdn.UseVisualStyleBackColor = true;
            this.btnXoacthdn.Click += new System.EventHandler(this.btnXoacthdn_Click);
            // 
            // btnThoatcthd
            // 
            this.btnThoatcthd.Location = new System.Drawing.Point(274, 531);
            this.btnThoatcthd.Name = "btnThoatcthd";
            this.btnThoatcthd.Size = new System.Drawing.Size(75, 34);
            this.btnThoatcthd.TabIndex = 4;
            this.btnThoatcthd.Text = "Thoát";
            this.btnThoatcthd.UseVisualStyleBackColor = true;
            this.btnThoatcthd.Click += new System.EventHandler(this.btnThoatcthd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã CTHĐN";
            this.label10.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtMacthdn
            // 
            this.txtMacthdn.Location = new System.Drawing.Point(149, 294);
            this.txtMacthdn.Name = "txtMacthdn";
            this.txtMacthdn.Size = new System.Drawing.Size(182, 26);
            this.txtMacthdn.TabIndex = 1;
            this.txtMacthdn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CTHD_nhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 750);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.btnThoatcthd);
            this.Controls.Add(this.btnHDThoat);
            this.Controls.Add(this.btnXoacthdn);
            this.Controls.Add(this.btnHDXoa);
            this.Controls.Add(this.btnSuacthdn);
            this.Controls.Add(this.btnHDSua);
            this.Controls.Add(this.btnThemCthdn);
            this.Controls.Add(this.btnHDThem);
            this.Controls.Add(this.cbMaSP);
            this.Controls.Add(this.cbNCC);
            this.Controls.Add(this.cbNhanVien);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.txtSoLuongNhap);
            this.Controls.Add(this.txtMacthdn);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtMaHDN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CTHD_nhap";
            this.Text = "Chi tiết hóa đơn nhập";
            this.Load += new System.EventHandler(this.CTHD_nhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHDN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.Button btnHDThem;
        private System.Windows.Forms.Button btnHDSua;
        private System.Windows.Forms.Button btnHDXoa;
        private System.Windows.Forms.Button btnHDThoat;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahdn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn mancc;
        private System.Windows.Forms.DataGridViewTextBoxColumn macthdn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.Button btnThemCthdn;
        private System.Windows.Forms.Button btnSuacthdn;
        private System.Windows.Forms.Button btnXoacthdn;
        private System.Windows.Forms.Button btnThoatcthd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMacthdn;
    }
}