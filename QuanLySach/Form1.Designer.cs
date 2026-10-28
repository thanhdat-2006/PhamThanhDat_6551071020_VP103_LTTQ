namespace QuanLySach
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbThongTinSach = new GroupBox();
            lblMaSach = new Label();
            lblTenSach = new Label();
            lblGiaTien = new Label();
            txtMaSach = new TextBox();
            txtTenSach = new TextBox();
            txtGiaTien = new TextBox();
            grbDanhSachSach = new GroupBox();
            dgvDanhSachSach = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            grbThongTinSach.SuspendLayout();
            grbDanhSachSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSach).BeginInit();
            SuspendLayout();
            // 
            // grbThongTinSach
            // 
            grbThongTinSach.Controls.Add(txtGiaTien);
            grbThongTinSach.Controls.Add(txtTenSach);
            grbThongTinSach.Controls.Add(txtMaSach);
            grbThongTinSach.Controls.Add(lblGiaTien);
            grbThongTinSach.Controls.Add(lblTenSach);
            grbThongTinSach.Controls.Add(lblMaSach);
            grbThongTinSach.Location = new Point(23, 22);
            grbThongTinSach.Name = "grbThongTinSach";
            grbThongTinSach.Size = new Size(312, 408);
            grbThongTinSach.TabIndex = 0;
            grbThongTinSach.TabStop = false;
            grbThongTinSach.Text = "Thông tin sách";
            // 
            // lblMaSach
            // 
            lblMaSach.AutoSize = true;
            lblMaSach.Location = new Point(31, 57);
            lblMaSach.Name = "lblMaSach";
            lblMaSach.Size = new Size(81, 25);
            lblMaSach.TabIndex = 0;
            lblMaSach.Text = "Mã sách:";
            // 
            // lblTenSach
            // 
            lblTenSach.AutoSize = true;
            lblTenSach.Location = new Point(31, 169);
            lblTenSach.Name = "lblTenSach";
            lblTenSach.Size = new Size(82, 25);
            lblTenSach.TabIndex = 1;
            lblTenSach.Text = "Tên sách:";
            // 
            // lblGiaTien
            // 
            lblGiaTien.AutoSize = true;
            lblGiaTien.Location = new Point(31, 281);
            lblGiaTien.Name = "lblGiaTien";
            lblGiaTien.Size = new Size(75, 25);
            lblGiaTien.TabIndex = 2;
            lblGiaTien.Text = "Giá tiền:";
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(31, 95);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(254, 31);
            txtMaSach.TabIndex = 3;
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(31, 207);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(254, 31);
            txtTenSach.TabIndex = 4;
            // 
            // txtGiaTien
            // 
            txtGiaTien.Location = new Point(31, 318);
            txtGiaTien.Name = "txtGiaTien";
            txtGiaTien.Size = new Size(254, 31);
            txtGiaTien.TabIndex = 5;
            // 
            // grbDanhSachSach
            // 
            grbDanhSachSach.Controls.Add(dgvDanhSachSach);
            grbDanhSachSach.Location = new Point(341, 75);
            grbDanhSachSach.Name = "grbDanhSachSach";
            grbDanhSachSach.Size = new Size(514, 355);
            grbDanhSachSach.TabIndex = 1;
            grbDanhSachSach.TabStop = false;
            grbDanhSachSach.Text = "Danh sách sách";
            // 
            // dgvDanhSachSach
            // 
            dgvDanhSachSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachSach.Location = new Point(6, 30);
            dgvDanhSachSach.Name = "dgvDanhSachSach";
            dgvDanhSachSach.RowHeadersWidth = 62;
            dgvDanhSachSach.Size = new Size(502, 319);
            dgvDanhSachSach.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(347, 35);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(475, 35);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(605, 35);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(737, 35);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 442);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(grbDanhSachSach);
            Controls.Add(grbThongTinSach);
            Name = "Form1";
            Text = "Quản lý Sách/Thư viện - VP103";
            grbThongTinSach.ResumeLayout(false);
            grbThongTinSach.PerformLayout();
            grbDanhSachSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbThongTinSach;
        private Label lblTenSach;
        private Label lblMaSach;
        private TextBox txtGiaTien;
        private TextBox txtTenSach;
        private TextBox txtMaSach;
        private Label lblGiaTien;
        private GroupBox grbDanhSachSach;
        private DataGridView dgvDanhSachSach;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
    }
}
