using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace baitap1710
{
    public partial class Form1 : Form
    {
        private BindingList<Appointment> _listAppointments = new BindingList<Appointment>();
        private BindingSource _bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();

            // Tắt tự động sinh cột để dùng cột cấu hình thủ công
            dgvLichHen.AutoGenerateColumns = false;

            InitData();
            SetupControls();
            RegisterEvents();
        }

        private void InitData()
        {
            // Dữ liệu mẫu ban đầu để kiểm thử ứng dụng
            _listAppointments.Add(new Appointment
            {
                MaLichHen = "LH001",
                HoTen = "Nguyễn Văn A",
                SoDienThoai = "0912345678",
                NgayGioHen = DateTime.Now.AddDays(1),
                BacSi = "BS. Nguyễn Văn B",
                LyDoKham = "Khám tổng quát",
                TrangThai = "Chờ khám"
            });

            _bindingSource.DataSource = _listAppointments;
            dgvLichHen.DataSource = _bindingSource;
        }

        private void SetupControls()
        {
            // Cấu hình danh sách Trạng thái
            string[] trangThaiList = { "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" };
            cboTrangThai.DataSource = trangThaiList.Clone();

            // Cấu hình ComboBox Lọc trạng thái
            cboLocTrangThai.Items.Clear();
            cboLocTrangThai.Items.Add("Tất cả");
            foreach (var tt in trangThaiList) cboLocTrangThai.Items.Add(tt);
            cboLocTrangThai.SelectedIndex = 0;

            // Cấu hình ComboBox Bác sĩ
            cboBacSi.Items.Clear();
            cboBacSi.Items.AddRange(new string[] { "BS. Nguyễn Văn B", "BS. Trần Thị C", "BS. Lê Văn D" });
            if (cboBacSi.Items.Count > 0) cboBacSi.SelectedIndex = 0;

            UpdateStatusCount();
        }

        private void RegisterEvents()
        {
            // Đăng ký sự kiện Click cho các nút bấm
            btnThem.Click += btnThem_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnCapNhat.Click += btnCapNhat_Click;
            btnXoa.Click += btnXoa_Click;

            // Đăng ký sự kiện chọn dòng trên DataGridView
            dgvLichHen.SelectionChanged += dgvLichHen_SelectionChanged;

            // Sự kiện Lọc & Tìm kiếm tức thì
            txtTimKiem.TextChanged += (s, e) => ApplyFilterAndSearch();
            cboLocTrangThai.SelectedIndexChanged += (s, e) => ApplyFilterAndSearch();
            dtpLocNgay.ValueChanged += (s, e) => ApplyFilterAndSearch();
            chkLocTheoNgay.CheckedChanged += (s, e) => ApplyFilterAndSearch();
        }

        // ==================== KHOẢN KIỂM TRA DỮ LIỆU NHẬP ====================
        private bool ValidateInput(bool isNew)
        {
            errorProvider1.Clear();

            // 1. Kiểm tra Mã lịch hẹn
            if (string.IsNullOrWhiteSpace(txtMaLichHen.Text))
            {
                errorProvider1.SetError(txtMaLichHen, "Vui lòng nhập mã lịch hẹn!");
                MessageBox.Show("Vui lòng nhập Mã lịch hẹn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLichHen.Focus();
                return false;
            }

            if (isNew && _listAppointments.Any(x => x.MaLichHen.Equals(txtMaLichHen.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtMaLichHen, "Mã lịch hẹn này đã tồn tại!");
                MessageBox.Show("Mã lịch hẹn này đã tồn tại trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLichHen.Focus();
                return false;
            }

            // 2. Kiểm tra Họ và tên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(txtHoTen, "Vui lòng nhập họ tên!");
                MessageBox.Show("Vui lòng nhập Họ tên bệnh nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }

            // 3. Kiểm tra Số điện thoại (10 chữ số, bắt đầu bằng số 0)
            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text) || !Regex.IsMatch(txtSoDienThoai.Text.Trim(), @"^0\d{9}$"))
            {
                errorProvider1.SetError(txtSoDienThoai, "SĐT không hợp lệ!");
                MessageBox.Show("Số điện thoại không hợp lệ! (Phải gồm 10 chữ số và bắt đầu bằng số 0)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return false;
            }

            // 4. Kiểm tra Lý do khám
            if (string.IsNullOrWhiteSpace(txtLyDoKham.Text))
            {
                errorProvider1.SetError(txtLyDoKham, "Vui lòng nhập lý do khám!");
                MessageBox.Show("Vui lòng nhập Lý do khám!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLyDoKham.Focus();
                return false;
            }

            return true;
        }

        // ==================== CÁC HÀM XỬ LÝ NÚT BẤM ====================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(isNew: true)) return;

            var ap = new Appointment
            {
                MaLichHen = txtMaLichHen.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                SoDienThoai = txtSoDienThoai.Text.Trim(),
                NgayGioHen = dtpNgayGioHen.Value,
                BacSi = cboBacSi.SelectedItem?.ToString() ?? "",
                LyDoKham = txtLyDoKham.Text.Trim(),
                TrangThai = cboTrangThai.SelectedItem?.ToString() ?? ""
            };

            _listAppointments.Add(ap);
            ApplyFilterAndSearch();
            MessageBox.Show("Thêm lịch hẹn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvLichHen.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn lịch hẹn muốn cập nhật từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput(isNew: false)) return;

            if (dgvLichHen.CurrentRow.DataBoundItem is Appointment selectedAp)
            {
                selectedAp.HoTen = txtHoTen.Text.Trim();
                selectedAp.SoDienThoai = txtSoDienThoai.Text.Trim();
                selectedAp.NgayGioHen = dtpNgayGioHen.Value;
                selectedAp.BacSi = cboBacSi.SelectedItem?.ToString() ?? "";
                selectedAp.LyDoKham = txtLyDoKham.Text.Trim();
                selectedAp.TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "";

                ApplyFilterAndSearch();
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLichHen.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn lịch hẹn cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvLichHen.CurrentRow.DataBoundItem is Appointment selectedAp)
            {
                var dialogResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa lịch hẹn {selectedAp.MaLichHen} của bệnh nhân {selectedAp.HoTen}?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    _listAppointments.Remove(selectedAp);
                    ApplyFilterAndSearch();
                    ClearInputs();
                    MessageBox.Show("Đã xóa lịch hẹn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // ==================== TẢI VÀ XÓA DỮ LIỆU CÁC Ô ====================
        private void dgvLichHen_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLichHen.CurrentRow != null && dgvLichHen.CurrentRow.DataBoundItem is Appointment item)
            {
                txtMaLichHen.Text = item.MaLichHen;
                txtMaLichHen.ReadOnly = true; // Khóa mã lịch hẹn khi đang chọn xem/sửa
                txtHoTen.Text = item.HoTen;
                txtSoDienThoai.Text = item.SoDienThoai;
                dtpNgayGioHen.Value = item.NgayGioHen;
                cboBacSi.SelectedItem = item.BacSi;
                txtLyDoKham.Text = item.LyDoKham;
                cboTrangThai.SelectedItem = item.TrangThai;
            }
        }

        private void ClearInputs()
        {
            txtMaLichHen.ReadOnly = false; // Mở khóa ô Mã lịch hẹn để chuẩn bị nhập mới
            txtMaLichHen.Clear();
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            txtLyDoKham.Clear();
            dtpNgayGioHen.Value = DateTime.Now;
            if (cboBacSi.Items.Count > 0) cboBacSi.SelectedIndex = 0;
            if (cboTrangThai.Items.Count > 0) cboTrangThai.SelectedIndex = 0;
            errorProvider1.Clear();
            txtMaLichHen.Focus();
        }

        // ==================== TÌM KIẾM VÀ LỌC DỮ LIỆU ====================
        private void ApplyFilterAndSearch()
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();
            string selectedStatus = cboLocTrangThai.SelectedItem?.ToString();
            bool useDateFilter = chkLocTheoNgay.Checked;
            DateTime filterDate = dtpLocNgay.Value.Date;

            var filtered = _listAppointments.Where(ap =>
                (string.IsNullOrEmpty(keyword) || ap.HoTen.ToLower().Contains(keyword) || ap.SoDienThoai.Contains(keyword)) &&
                (selectedStatus == "Tất cả" || string.IsNullOrEmpty(selectedStatus) || ap.TrangThai == selectedStatus) &&
                (!useDateFilter || ap.NgayGioHen.Date == filterDate)
            ).ToList();

            _bindingSource.DataSource = new BindingList<Appointment>(filtered);
            UpdateStatusCount();
        }

        private void UpdateStatusCount()
        {
            lblTongSo.Text = $"Tổng số lịch hẹn: {_bindingSource.Count}";
        }
    }
}