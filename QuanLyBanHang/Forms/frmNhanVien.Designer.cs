namespace QuanLyBanHang.Forms
{
    partial class frmNhanVien
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
            groupBox1 = new GroupBox();
            cboQuyenHan = new ComboBox();
            txtMatKhau = new TextBox();
            txtDienThoai = new TextBox();
            txtTenDangNhap = new TextBox();
            txtDiaChi = new TextBox();
            label6 = new Label();
            txtHoVaTen = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            IDNV = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
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
            groupBox1.Size = new Size(1003, 164);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            cboQuyenHan.Location = new Point(485, 119);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(154, 28);
            cboQuyenHan.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(485, 79);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(154, 27);
            txtMatKhau.TabIndex = 2;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(126, 79);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(207, 27);
            txtDienThoai.TabIndex = 2;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(485, 46);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(154, 27);
            txtTenDangNhap.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(126, 115);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(207, 27);
            txtDiaChi.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(348, 122);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 1;
            label6.Text = "Quyền hạn:";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(126, 46);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(207, 27);
            txtHoVaTen.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(348, 86);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 1;
            label5.Text = "Mật khẩu (*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 122);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 1;
            label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(348, 46);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 1;
            label4.Text = "Tên đăng nhập (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 86);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 1;
            label2.Text = "Điện thoại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 46);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 1;
            label1.Text = "Họ và tên (*):";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(897, 119);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 0;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(897, 84);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 0;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(788, 119);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(788, 84);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 0;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(897, 49);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 0;
            btnTimKiem.Text = "Tìm kiếm...";
            btnTimKiem.TextAlign = ContentAlignment.TopLeft;
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(688, 119);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(788, 49);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 0;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(688, 84);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(688, 49);
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
            groupBox2.Location = new Point(0, 164);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1003, 383);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { IDNV, HoVaTen, DienThoai, DiaChi, TenDangNhap, QuyenHan });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(997, 357);
            dataGridView.TabIndex = 0;
            // 
            // IDNV
            // 
            IDNV.DataPropertyName = "ID";
            IDNV.HeaderText = "ID";
            IDNV.MinimumWidth = 6;
            IDNV.Name = "IDNV";
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.HeaderText = "Họ và tên";
            HoVaTen.MinimumWidth = 6;
            HoVaTen.Name = "HoVaTen";
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.HeaderText = "Điện thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên đăng nhập";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            // 
            // QuyenHan
            // 
            QuyenHan.DataPropertyName = "QuyenHan";
            QuyenHan.HeaderText = "Quyền hạn";
            QuyenHan.MinimumWidth = 6;
            QuyenHan.Name = "QuyenHan";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 547);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân Viên";
            Load += frmNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDienThoai;
        private TextBox txtDiaChi;
        private TextBox txtHoVaTen;
        private Label label3;
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
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cboQuyenHan;
        private DataGridViewTextBoxColumn IDNV;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn QuyenHan;
    }
}