namespace GUI_QuanLyHieuThuoc
{
    partial class frmTimKiemHDN
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
            this.cbHDN = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvHDN = new System.Windows.Forms.DataGridView();
            this.mahdn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigiannhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HĐN";
            // 
            // cbHDN
            // 
            this.cbHDN.FormattingEnabled = true;
            this.cbHDN.Location = new System.Drawing.Point(171, 47);
            this.cbHDN.Name = "cbHDN";
            this.cbHDN.Size = new System.Drawing.Size(174, 27);
            this.cbHDN.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(388, 38);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(108, 36);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvHDN
            // 
            this.dgvHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahdn,
            this.thoigiannhap,
            this.manv,
            this.mancc});
            this.dgvHDN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHDN.Location = new System.Drawing.Point(0, 148);
            this.dgvHDN.Name = "dgvHDN";
            this.dgvHDN.Size = new System.Drawing.Size(681, 150);
            this.dgvHDN.TabIndex = 3;
            // 
            // mahdn
            // 
            this.mahdn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mahdn.DataPropertyName = "mahdn";
            this.mahdn.HeaderText = "Mã HĐN";
            this.mahdn.Name = "mahdn";
            // 
            // thoigiannhap
            // 
            this.thoigiannhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thoigiannhap.DataPropertyName = "thoigian_nhap";
            this.thoigiannhap.HeaderText = "Thời Gian Nhập";
            this.thoigiannhap.Name = "thoigiannhap";
            // 
            // manv
            // 
            this.manv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.manv.DataPropertyName = "manhanvien";
            this.manv.HeaderText = "Mã Nhân Viên";
            this.manv.Name = "manv";
            // 
            // mancc
            // 
            this.mancc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mancc.DataPropertyName = "mancc";
            this.mancc.HeaderText = "Mã NCC";
            this.mancc.Name = "mancc";
            // 
            // frmTimKiemHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 298);
            this.Controls.Add(this.dgvHDN);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cbHDN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTimKiemHDN";
            this.Text = "Tìm kiếm hóa đơn nhập";
            this.Load += new System.EventHandler(this.frmTimKiemHDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHDN;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahdn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigiannhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn mancc;
    }
}