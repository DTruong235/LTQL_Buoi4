using QuanLyBanHang.Data;
using Slugify;
using System.Data;

namespace QuanLyBanHang.Forms
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        QLBHDbContext context = new QLBHDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id; // Lấy mã sản phẩm (dùng cho Sửa và Xóa)
        string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Images");
        float zoomScale = 1.0f;

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            cboHangSanXuat.Enabled = giaTri;
            cboLoaiSanPham.Enabled = giaTri;
            txtTenSanPham.Enabled = giaTri;
            numSoLuong.Enabled = giaTri;
            numDonGia.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnDoiAnh.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        public void LayLoaiSanPhamVaoComboBox()
        {
            cboLoaiSanPham.DataSource = context.LoaiSanPham.ToList();
            cboLoaiSanPham.ValueMember = "ID";
            cboLoaiSanPham.DisplayMember = "TenLoai";
        }

        public void LayHangSanXuatVaoComboBox()
        {
            // Tương tự LayLoaiSanPhamVaoComboBox()
            cboHangSanXuat.DataSource = context.HangSanXuat.ToList();
            cboHangSanXuat.ValueMember = "ID";
            cboHangSanXuat.DisplayMember = "TenHangSanXuat";
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LayLoaiSanPhamVaoComboBox();
            LayHangSanXuatVaoComboBox();

            dataGridView.AutoGenerateColumns = false;
            List<DanhSachSanPham> sp = new List<DanhSachSanPham>();
            sp = context.SanPham.Select(r => new DanhSachSanPham
            {
                ID = r.ID,
                LoaiSanPhamID = r.LoaiSanPhamID,
                TenLoai = r.LoaiSanPham.TenLoai,
                HangSanXuatID = r.HangSanXuatID,
                TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                TenSanPham = r.TenSanPham,
                SoLuong = r.Soluong,
                DonGia = r.DonGia,
                HinhAnh = r.HinhAnh
            }).ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sp;
            cboLoaiSanPham.DataBindings.Clear();
            cboLoaiSanPham.DataBindings.Add("SelectedValue", bindingSource, "LoaiSanPhamID", false, DataSourceUpdateMode.Never);
            // Tương tự đối với cboHangSanXuat
            cboHangSanXuat.DataBindings.Clear();
            cboHangSanXuat.DataBindings.Add("SelectedValue", bindingSource, "HangSanXuatID", false, DataSourceUpdateMode.Never);

            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", bindingSource, "TenSanPham", false, DataSourceUpdateMode.Never);
            // Tương tự đối với txtMoTa
            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", false, DataSourceUpdateMode.Never);

            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", false, DataSourceUpdateMode.Never);
            // Tương tự đối với numDonGia
            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", bindingSource, "DonGia", false, DataSourceUpdateMode.Never);
            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", bindingSource, "HinhAnh");
            hinhAnh.Format += (s, e) =>
            {
                e.Value = Path.Combine(imagesFolder, e.Value.ToString());
            };
            picHinhAnh.DataBindings.Add(hinhAnh);
            dataGridView.DataSource = bindingSource;
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                Image image = Image.FromFile(Path.Combine(imagesFolder, e.Value.ToString()));
                image = new Bitmap(image, 24, 24);
                e.Value = image;
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            cboLoaiSanPham.Text = "";
            cboHangSanXuat.Text = "";
            txtTenSanPham.Clear();
            txtMoTa.Clear();
            numSoLuong.Value = 0;
            numDonGia.Value = 0;
            picHinhAnh.Image = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Tương tự với các form đã thực hiện
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["IDSP"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa sản phẩm " + txtTenSanPham.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["IDSP"].Value.ToString());
                SanPham sp = context.SanPham.Find(id);
                if (sp != null)
                {
                    context.SanPham.Remove(sp);
                }
                context.SaveChanges();
                frmSanPham_Load(sender, e);
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboLoaiSanPham.Text))
                MessageBox.Show("Vui lòng chọn loại sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboHangSanXuat.Text))
                MessageBox.Show("Vui lòng chọn hãng sản xuất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
                MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuong.Value <= 0)
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDonGia.Value <= 0)
                MessageBox.Show("Đơn giá sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    SanPham sp = new SanPham();

                    sp.TenSanPham = txtTenSanPham.Text;
                    sp.LoaiSanPhamID = (int)cboLoaiSanPham.SelectedValue;
                    sp.HangSanXuatID = (int)cboHangSanXuat.SelectedValue;
                    sp.Soluong = (int)numSoLuong.Value;
                    sp.DonGia = (int)numDonGia.Value;
                    sp.MoTa = txtMoTa.Text;

                    sp.HinhAnh = "no-image.png";

                    context.SanPham.Add(sp);

                    context.SaveChanges();
                }
                else
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow.Cells["IDSP"].Value.ToString());
                    SanPham sp = context.SanPham.Find(id);
                    if (sp != null)
                    {
                        // Tương tự với các form đã thực hiện
                        sp.TenSanPham = txtTenSanPham.Text;
                        sp.LoaiSanPhamID = (int)cboLoaiSanPham.SelectedValue;
                        sp.HangSanXuatID = (int)cboHangSanXuat.SelectedValue;
                        sp.Soluong = (int)numSoLuong.Value;
                        sp.DonGia = (int)numDonGia.Value;
                        sp.MoTa = txtMoTa.Text;
                        context.SanPham.Update(sp);
                        context.SaveChanges();
                    }
                }
                frmSanPham_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmSanPham_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không? ", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            var slugHelper = new SlugHelper();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Cập nhật hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string ext = Path.GetExtension(openFileDialog.FileName);
                string fileSavePath = Path.Combine(imagesFolder, slugHelper.GenerateSlug(fileName) + ext);
                File.Copy(openFileDialog.FileName, fileSavePath, true);
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["IDSP"].Value.ToString());
                SanPham sp = context.SanPham.Find(id);
                sp.HinhAnh = slugHelper.GenerateSlug(fileName) + ext;
                context.SanPham.Update(sp);
                context.SaveChanges();
                frmSanPham_Load(sender, e);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPhongTo_Click(object sender, EventArgs e)
        {

            if (picHinhAnh.Image != null)
            {
                // 1. Tăng tỉ lệ scale
                zoomScale += 0.05f;

                // 2. Thay đổi kích thước PictureBox dựa trên ảnh gốc và tỉ lệ mới
                picHinhAnh.Width = (int)(picHinhAnh.Image.Width * zoomScale);
                picHinhAnh.Height = (int)(picHinhAnh.Image.Height * zoomScale);

                // 3. Căn chỉnh vị trí để ảnh luôn nằm trong tầm kiểm soát của Panel
                // Nếu ảnh lớn hơn Panel, để nó ở (0,0) để hiện thanh cuộn (AutoScroll)
                // Nếu ảnh nhỏ hơn Panel, đưa nó vào giữa
                if (picHinhAnh.Width < pnlKhungAnh.Width)
                    picHinhAnh.Left = (pnlKhungAnh.Width - picHinhAnh.Width) / 2;
                else
                    picHinhAnh.Left = 0;

                if (picHinhAnh.Height < pnlKhungAnh.Height)
                    picHinhAnh.Top = (pnlKhungAnh.Height - picHinhAnh.Height) / 2;
                else
                    picHinhAnh.Top = 0;
            }
        }

        private void btnXoay_Click(object sender, EventArgs e)
        {
            if (picHinhAnh.Image != null)
            {
                Image img = picHinhAnh.Image;
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                picHinhAnh.Image = img; // Cập nhật lại ảnh đã xoay
                picHinhAnh.Refresh();   // Làm mới hiển thị
            }
        }

        private void btnThuNho_Click(object sender, EventArgs e)
        {
            if (picHinhAnh.Image != null)
            {
                // 1. Giới hạn không cho thu nhỏ quá 10% để tránh ảnh biến mất
                if (zoomScale > 0.1f)
                {
                    zoomScale -= 0.05f;

                    // 2. Cập nhật kích thước
                    picHinhAnh.Width = (int)(picHinhAnh.Image.Width * zoomScale);
                    picHinhAnh.Height = (int)(picHinhAnh.Image.Height * zoomScale);

                    // 3. Căn giữa ảnh trong Panel sau khi thu nhỏ
                    if (picHinhAnh.Width < pnlKhungAnh.Width)
                        picHinhAnh.Left = (pnlKhungAnh.Width - picHinhAnh.Width) / 2;
                    else
                        picHinhAnh.Left = 0;

                    if (picHinhAnh.Height < pnlKhungAnh.Height)
                        picHinhAnh.Top = (pnlKhungAnh.Height - picHinhAnh.Height) / 2;
                    else
                        picHinhAnh.Top = 0;
                }
            }
        }
    }
}
