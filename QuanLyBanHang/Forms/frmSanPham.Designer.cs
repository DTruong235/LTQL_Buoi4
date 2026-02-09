namespace QuanLyBanHang.Forms
{
    partial class frmSanPham
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            pnlKhungAnh = new Panel();
            picHinhAnh = new PictureBox();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            cboHangSanXuat = new ComboBox();
            cboLoaiSanPham = new ComboBox();
            txtMoTa = new TextBox();
            txtTenSanPham = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnPhongTo = new Button();
            btnThuNho = new Button();
            btnXoay = new Button();
            btnDoiAnh = new Button();
            btnXuat = new Button();
            btnNhap = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            IDSP = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            groupBox1.SuspendLayout();
            pnlKhungAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pnlKhungAnh);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(cboHangSanXuat);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnPhongTo);
            groupBox1.Controls.Add(btnThuNho);
            groupBox1.Controls.Add(btnXoay);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1131, 276);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // pnlKhungAnh
            // 
            pnlKhungAnh.AutoScroll = true;
            pnlKhungAnh.AutoSize = true;
            pnlKhungAnh.BorderStyle = BorderStyle.FixedSingle;
            pnlKhungAnh.Controls.Add(picHinhAnh);
            pnlKhungAnh.Location = new Point(684, 86);
            pnlKhungAnh.Name = "pnlKhungAnh";
            pnlKhungAnh.Size = new Size(394, 122);
            pnlKhungAnh.TabIndex = 7;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Anchor = AnchorStyles.Left;
            picHinhAnh.Location = new Point(142, 1);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(122, 115);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 6;
            picHinhAnh.TabStop = false;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(492, 82);
            numDonGia.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(154, 27);
            numDonGia.TabIndex = 5;
            numDonGia.ThousandsSeparator = true;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(492, 44);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(154, 27);
            numSoLuong.TabIndex = 5;
            numSoLuong.ThousandsSeparator = true;
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(161, 82);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(201, 28);
            cboHangSanXuat.TabIndex = 4;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(161, 42);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(201, 28);
            cboLoaiSanPham.TabIndex = 4;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(161, 163);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(485, 27);
            txtMoTa.TabIndex = 2;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(161, 123);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(485, 27);
            txtTenSanPham.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(387, 85);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 1;
            label6.Text = "Đơn giá (*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(387, 49);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 1;
            label5.Text = "Số lượng (*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 130);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 1;
            label3.Text = "Tên sản phẩm (*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 163);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 1;
            label4.Text = "Mô tả:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 86);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 1;
            label2.Text = "Hãng sản xuất (*):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 46);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 1;
            label1.Text = "Phân loại (*):";
            // 
            // btnPhongTo
            // 
            btnPhongTo.Location = new Point(784, 41);
            btnPhongTo.Name = "btnPhongTo";
            btnPhongTo.Size = new Size(94, 29);
            btnPhongTo.TabIndex = 0;
            btnPhongTo.Text = "Phóng to";
            btnPhongTo.UseVisualStyleBackColor = true;
            btnPhongTo.Click += btnPhongTo_Click;
            // 
            // btnThuNho
            // 
            btnThuNho.Location = new Point(884, 41);
            btnThuNho.Name = "btnThuNho";
            btnThuNho.Size = new Size(94, 29);
            btnThuNho.TabIndex = 0;
            btnThuNho.Text = "Thu nhỏ";
            btnThuNho.UseVisualStyleBackColor = true;
            btnThuNho.Click += btnThuNho_Click;
            // 
            // btnXoay
            // 
            btnXoay.Location = new Point(984, 40);
            btnXoay.Name = "btnXoay";
            btnXoay.Size = new Size(94, 29);
            btnXoay.TabIndex = 0;
            btnXoay.Text = "Xoay";
            btnXoay.UseVisualStyleBackColor = true;
            btnXoay.Click += btnXoay_Click;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(684, 40);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(94, 29);
            btnDoiAnh.TabIndex = 0;
            btnDoiAnh.Text = "Đổi ảnh...";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(884, 225);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 0;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(784, 225);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 0;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(584, 225);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(484, 225);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 0;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(684, 225);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 0;
            btnTimKiem.Text = "Tìm kiếm...";
            btnTimKiem.TextAlign = ContentAlignment.TopLeft;
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(284, 225);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(384, 225);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 0;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(184, 225);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(84, 225);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 276);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1131, 197);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { IDSP, TenLoai, TenHangSanXuat, TenSanPham, SoLuong, DonGia, HinhAnh });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1125, 171);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // IDSP
            // 
            IDSP.DataPropertyName = "ID";
            IDSP.HeaderText = "ID";
            IDSP.MinimumWidth = 6;
            IDSP.Name = "IDSP";
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Phân loại";
            TenLoai.MinimumWidth = 6;
            TenLoai.Name = "TenLoai";
            // 
            // TenHangSanXuat
            // 
            TenHangSanXuat.DataPropertyName = "TenHangSanXuat";
            TenHangSanXuat.HeaderText = "Hãng sản xuất";
            TenHangSanXuat.MinimumWidth = 6;
            TenHangSanXuat.Name = "TenHangSanXuat";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            SoLuong.DefaultCellStyle = dataGridViewCellStyle3;
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = null;
            DonGia.DefaultCellStyle = dataGridViewCellStyle4;
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.MinimumWidth = 6;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.Resizable = DataGridViewTriState.True;
            HinhAnh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 473);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản phẩm";
            Load += frmSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlKhungAnh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMatKhau;
        private TextBox txtDienThoai;
        private TextBox txtMoTa;
        private TextBox txtTenSanPham;
        private Label label6;
        private TextBox txtHoVaTen;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private ComboBox cboHangSanXuat;
        private ComboBox cboLoaiSanPham;
        private NumericUpDown numSoLuong;
        private NumericUpDown numDonGia;
        private PictureBox picHinhAnh;
        private Button btnDoiAnh;
        private DataGridViewTextBoxColumn IDSP;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridViewTextBoxColumn TenHangSanXuat;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewImageColumn HinhAnh;
        private Button btnPhongTo;
        private Button btnThuNho;
        private Button btnXoay;
        private Panel pnlKhungAnh;
    }
}