namespace GUI_QuanLyHieuThuoc
{
    partial class frmThuMuc
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaThuMuc = new System.Windows.Forms.TextBox();
            this.txtTenThuMuc = new System.Windows.Forms.TextBox();
            this.dgvThuMuc = new System.Windows.Forms.DataGridView();
            this.maThuMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThuMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Thư Mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Thư Mục";
            // 
            // txtMaThuMuc
            // 
            this.txtMaThuMuc.Location = new System.Drawing.Point(150, 36);
            this.txtMaThuMuc.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaThuMuc.Name = "txtMaThuMuc";
            this.txtMaThuMuc.Size = new System.Drawing.Size(148, 26);
            this.txtMaThuMuc.TabIndex = 1;
            // 
            // txtTenThuMuc
            // 
            this.txtTenThuMuc.Location = new System.Drawing.Point(150, 84);
            this.txtTenThuMuc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenThuMuc.Name = "txtTenThuMuc";
            this.txtTenThuMuc.Size = new System.Drawing.Size(148, 26);
            this.txtTenThuMuc.TabIndex = 1;
            // 
            // dgvThuMuc
            // 
            this.dgvThuMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThuMuc,
            this.tenThuMuc});
            this.dgvThuMuc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvThuMuc.Location = new System.Drawing.Point(0, 216);
            this.dgvThuMuc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThuMuc.Name = "dgvThuMuc";
            this.dgvThuMuc.Size = new System.Drawing.Size(492, 219);
            this.dgvThuMuc.TabIndex = 2;
            this.dgvThuMuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuMuc_CellClick);
            // 
            // maThuMuc
            // 
            this.maThuMuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maThuMuc.DataPropertyName = "mathumuc";
            this.maThuMuc.HeaderText = "Mã Thư Mục";
            this.maThuMuc.Name = "maThuMuc";
            // 
            // tenThuMuc
            // 
            this.tenThuMuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenThuMuc.DataPropertyName = "tenthumuc";
            this.tenThuMuc.HeaderText = "Tên Tha Mục";
            this.tenThuMuc.Name = "tenThuMuc";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(374, 22);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(374, 62);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(374, 114);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(374, 162);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmThuMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 435);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvThuMuc);
            this.Controls.Add(this.txtTenThuMuc);
            this.Controls.Add(this.txtMaThuMuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThuMuc";
            this.Text = "Quản lý thư mục";
            this.Load += new System.EventHandler(this.frmThuMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaThuMuc;
        private System.Windows.Forms.TextBox txtTenThuMuc;
        private System.Windows.Forms.DataGridView dgvThuMuc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThuMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThuMuc;
    }
}