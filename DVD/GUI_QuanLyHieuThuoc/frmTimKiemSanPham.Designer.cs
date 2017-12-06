namespace GUI_QuanLyHieuThuoc
{
    partial class frmTimKiemSanPham
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
            this.cbTensp = new System.Windows.Forms.ComboBox();
            this.btnTimkiemsp = new System.Windows.Forms.Button();
            this.dgvTimKiem = new System.Windows.Forms.DataGridView();
            this.maSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maThuMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // cbTensp
            // 
            this.cbTensp.FormattingEnabled = true;
            this.cbTensp.Location = new System.Drawing.Point(213, 38);
            this.cbTensp.Name = "cbTensp";
            this.cbTensp.Size = new System.Drawing.Size(162, 27);
            this.cbTensp.TabIndex = 1;
            // 
            // btnTimkiemsp
            // 
            this.btnTimkiemsp.Location = new System.Drawing.Point(428, 38);
            this.btnTimkiemsp.Name = "btnTimkiemsp";
            this.btnTimkiemsp.Size = new System.Drawing.Size(80, 29);
            this.btnTimkiemsp.TabIndex = 2;
            this.btnTimkiemsp.Text = "Tìm kiếm";
            this.btnTimkiemsp.UseVisualStyleBackColor = true;
            this.btnTimkiemsp.Click += new System.EventHandler(this.btnTimkiemsp_Click);
            // 
            // dgvTimKiem
            // 
            this.dgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSanPham,
            this.tnsp,
            this.gianhap,
            this.giaban,
            this.maThuMuc,
            this.soluong});
            this.dgvTimKiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTimKiem.Location = new System.Drawing.Point(0, 130);
            this.dgvTimKiem.Name = "dgvTimKiem";
            this.dgvTimKiem.Size = new System.Drawing.Size(730, 232);
            this.dgvTimKiem.TabIndex = 3;
            // 
            // maSanPham
            // 
            this.maSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maSanPham.DataPropertyName = "masanpham";
            this.maSanPham.HeaderText = "Mã Sản Phẩm";
            this.maSanPham.Name = "maSanPham";
            // 
            // tnsp
            // 
            this.tnsp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tnsp.DataPropertyName = "tensanpham";
            this.tnsp.HeaderText = "Tên Sản Phẩm";
            this.tnsp.Name = "tnsp";
            // 
            // gianhap
            // 
            this.gianhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gianhap.DataPropertyName = "gianhap";
            this.gianhap.HeaderText = "Giá Nhập";
            this.gianhap.Name = "gianhap";
            // 
            // giaban
            // 
            this.giaban.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giaban.DataPropertyName = "giaban";
            this.giaban.HeaderText = "Giá Bán";
            this.giaban.Name = "giaban";
            // 
            // maThuMuc
            // 
            this.maThuMuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maThuMuc.DataPropertyName = "mathumuc";
            this.maThuMuc.HeaderText = "Mã Thư Mục";
            this.maThuMuc.Name = "maThuMuc";
            // 
            // soluong
            // 
            this.soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số Lượng";
            this.soluong.Name = "soluong";
            // 
            // frmTimKiemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 362);
            this.Controls.Add(this.dgvTimKiem);
            this.Controls.Add(this.btnTimkiemsp);
            this.Controls.Add(this.cbTensp);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTimKiemSanPham";
            this.Text = "Tìm kiếm sản phẩm";
            this.Load += new System.EventHandler(this.frmTimKiemSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTensp;
        private System.Windows.Forms.Button btnTimkiemsp;
        private System.Windows.Forms.DataGridView dgvTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThuMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
    }
}