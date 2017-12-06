namespace GUI_QuanLyHieuThuoc
{
    partial class frmTimKiemChiTietHDN
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
            this.cbCTHDN = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvCTHDN = new System.Windows.Forms.DataGridView();
            this.macthdn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahdn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã CTHDN";
            // 
            // cbCTHDN
            // 
            this.cbCTHDN.FormattingEnabled = true;
            this.cbCTHDN.Location = new System.Drawing.Point(199, 44);
            this.cbCTHDN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCTHDN.Name = "cbCTHDN";
            this.cbCTHDN.Size = new System.Drawing.Size(180, 27);
            this.cbCTHDN.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(418, 37);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(112, 34);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvCTHDN
            // 
            this.dgvCTHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macthdn,
            this.mahdn,
            this.masp,
            this.soluong});
            this.dgvCTHDN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCTHDN.Location = new System.Drawing.Point(0, 122);
            this.dgvCTHDN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCTHDN.Name = "dgvCTHDN";
            this.dgvCTHDN.Size = new System.Drawing.Size(679, 219);
            this.dgvCTHDN.TabIndex = 3;
            // 
            // macthdn
            // 
            this.macthdn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.macthdn.DataPropertyName = "macthdn";
            this.macthdn.HeaderText = "Mã CTHDN";
            this.macthdn.Name = "macthdn";
            // 
            // mahdn
            // 
            this.mahdn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mahdn.DataPropertyName = "mahdn";
            this.mahdn.HeaderText = "Mã HĐN";
            this.mahdn.Name = "mahdn";
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
            // frmTimKiemChiTietHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 341);
            this.Controls.Add(this.dgvCTHDN);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cbCTHDN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTimKiemChiTietHDN";
            this.Text = "Tìm kiếm chi tiết hóa đơn nhập";
            this.Load += new System.EventHandler(this.frmTimKiemChiTietHDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCTHDN;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvCTHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn macthdn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahdn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
    }
}