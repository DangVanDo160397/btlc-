namespace GUI_QuanLyHieuThuoc
{
    partial class frmTimKiemCTHDB
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
            this.cbCTHDB = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvCTHDB = new System.Windows.Forms.DataGridView();
            this.macthdb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahdb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã CTHDB";
            // 
            // cbCTHDB
            // 
            this.cbCTHDB.FormattingEnabled = true;
            this.cbCTHDB.Location = new System.Drawing.Point(217, 49);
            this.cbCTHDB.Name = "cbCTHDB";
            this.cbCTHDB.Size = new System.Drawing.Size(160, 27);
            this.cbCTHDB.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(424, 44);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(116, 35);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvCTHDB
            // 
            this.dgvCTHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macthdb,
            this.mahdb,
            this.masp,
            this.soluong});
            this.dgvCTHDB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCTHDB.Location = new System.Drawing.Point(0, 159);
            this.dgvCTHDB.Name = "dgvCTHDB";
            this.dgvCTHDB.Size = new System.Drawing.Size(597, 150);
            this.dgvCTHDB.TabIndex = 3;
            // 
            // macthdb
            // 
            this.macthdb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.macthdb.DataPropertyName = "macthdb";
            this.macthdb.HeaderText = "Mã CTHDB";
            this.macthdb.Name = "macthdb";
            // 
            // mahdb
            // 
            this.mahdb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mahdb.DataPropertyName = "mahdb";
            this.mahdb.HeaderText = "Mã HĐB";
            this.mahdb.Name = "mahdb";
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
            this.soluong.HeaderText = "Số Lượng";
            this.soluong.Name = "soluong";
            // 
            // frmTimKiemCTHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 309);
            this.Controls.Add(this.dgvCTHDB);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cbCTHDB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTimKiemCTHDB";
            this.Text = "Tìm kiếm chi tiết hóa đơn bán";
            this.Load += new System.EventHandler(this.frmTimKiemCTHDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCTHDB;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvCTHDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn macthdb;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahdb;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
    }
}