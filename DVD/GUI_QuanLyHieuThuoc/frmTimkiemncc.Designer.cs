namespace GUI_QuanLyHieuThuoc
{
    partial class frmTimkiemncc
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
            this.cbTenNCC = new System.Windows.Forms.ComboBox();
            this.btnTimKiemNCC = new System.Windows.Forms.Button();
            this.dgvTimKiem = new System.Windows.Forms.DataGridView();
            this.mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên NCC";
            // 
            // cbTenNCC
            // 
            this.cbTenNCC.FormattingEnabled = true;
            this.cbTenNCC.Location = new System.Drawing.Point(180, 39);
            this.cbTenNCC.Name = "cbTenNCC";
            this.cbTenNCC.Size = new System.Drawing.Size(180, 27);
            this.cbTenNCC.TabIndex = 1;
            // 
            // btnTimKiemNCC
            // 
            this.btnTimKiemNCC.Location = new System.Drawing.Point(421, 30);
            this.btnTimKiemNCC.Name = "btnTimKiemNCC";
            this.btnTimKiemNCC.Size = new System.Drawing.Size(105, 36);
            this.btnTimKiemNCC.TabIndex = 2;
            this.btnTimKiemNCC.Text = "Tìm Kiếm";
            this.btnTimKiemNCC.UseVisualStyleBackColor = true;
            this.btnTimKiemNCC.Click += new System.EventHandler(this.btnTimKiemNCC_Click);
            // 
            // dgvTimKiem
            // 
            this.dgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mancc,
            this.tenncc,
            this.diachi,
            this.sodienthoai});
            this.dgvTimKiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTimKiem.Location = new System.Drawing.Point(0, 173);
            this.dgvTimKiem.Name = "dgvTimKiem";
            this.dgvTimKiem.Size = new System.Drawing.Size(790, 160);
            this.dgvTimKiem.TabIndex = 3;
            // 
            // mancc
            // 
            this.mancc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mancc.DataPropertyName = "mancc";
            this.mancc.HeaderText = "Mã NCC";
            this.mancc.Name = "mancc";
            // 
            // tenncc
            // 
            this.tenncc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenncc.DataPropertyName = "tenncc";
            this.tenncc.HeaderText = "Tên NCC";
            this.tenncc.Name = "tenncc";
            // 
            // diachi
            // 
            this.diachi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.Name = "diachi";
            // 
            // sodienthoai
            // 
            this.sodienthoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sodienthoai.DataPropertyName = "sodienthoai";
            this.sodienthoai.HeaderText = "Số Điện Thoại";
            this.sodienthoai.Name = "sodienthoai";
            // 
            // frmTimkiemncc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 333);
            this.Controls.Add(this.dgvTimKiem);
            this.Controls.Add(this.btnTimKiemNCC);
            this.Controls.Add(this.cbTenNCC);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTimkiemncc";
            this.Text = "Tìm kiếm nhà cung cấp";
            this.Load += new System.EventHandler(this.frmTimkiemncc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTenNCC;
        private System.Windows.Forms.Button btnTimKiemNCC;
        private System.Windows.Forms.DataGridView dgvTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn mancc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoai;
    }
}