namespace GUI_QuanLyHieuThuoc
{
    partial class frmTimKiemHDB
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
            this.cbMaHDB = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvHDB = new System.Windows.Forms.DataGridView();
            this.mahdb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HĐB";
            // 
            // cbMaHDB
            // 
            this.cbMaHDB.FormattingEnabled = true;
            this.cbMaHDB.Location = new System.Drawing.Point(187, 48);
            this.cbMaHDB.Name = "cbMaHDB";
            this.cbMaHDB.Size = new System.Drawing.Size(176, 27);
            this.cbMaHDB.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(420, 40);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(134, 35);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvHDB
            // 
            this.dgvHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahdb,
            this.thoigian,
            this.manv});
            this.dgvHDB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHDB.Location = new System.Drawing.Point(0, 157);
            this.dgvHDB.Name = "dgvHDB";
            this.dgvHDB.Size = new System.Drawing.Size(589, 150);
            this.dgvHDB.TabIndex = 3;
            // 
            // mahdb
            // 
            this.mahdb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mahdb.DataPropertyName = "mahdb";
            this.mahdb.HeaderText = "Mã HĐB";
            this.mahdb.Name = "mahdb";
            // 
            // thoigian
            // 
            this.thoigian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thoigian.DataPropertyName = "thoigian_ban";
            this.thoigian.HeaderText = "Thời Gian Bán";
            this.thoigian.Name = "thoigian";
            // 
            // manv
            // 
            this.manv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.manv.DataPropertyName = "manhanvien";
            this.manv.HeaderText = "Mã Nhân Viên";
            this.manv.Name = "manv";
            // 
            // frmTimKiemHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 307);
            this.Controls.Add(this.dgvHDB);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cbMaHDB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTimKiemHDB";
            this.Text = "Tìm kiếm Hóa Đơn Bán";
            this.Load += new System.EventHandler(this.frmTimKiemHDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaHDB;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvHDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahdb;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigian;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
    }
}