
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace baitap1710
{
    public partial class Form2 : Form
    {
        private BindingList<PhieuMuon> danhSach =
            new BindingList<PhieuMuon>();

        private bool dangNap = false;

        public Form2()
        {
            InitializeComponent();

            KhoiTaoGiaoDien();
            KetNoiSuKien();
            HienThiDanhSach();
            LamMoiForm();
        }

        private void KhoiTaoGiaoDien()
        {
            Text = "Lab Equipment Checkout";
            StartPosition = FormStartPosition.CenterScreen;

            // Danh sach thiet bi
            cboThietBi.Items.Clear();
            cboThietBi.Items.AddRange(new object[]
            {
                "Máy tính", "Laptop", "Màn hình",
                "Bàn phím", "Chuột", "Máy chiếu"
            });
            cboThietBi.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // Trang thai
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(new object[]
            {
                "Đang mượn", "Quá hạn", "Đã trả"
            });
            cboTrangThai.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // Bo loc
            cboLoc.Items.Clear();
            cboLoc.Items.AddRange(new object[]
            {
                "Tất cả", "Đang mượn", "Quá hạn", "Đã trả"
            });
            cboLoc.DropDownStyle =
                ComboBoxStyle.DropDownList;
            cboLoc.SelectedIndex = 0;

            nudSoLuong.Minimum = 1;
            nudSoLuong.Maximum = 1000;
            nudSoLuong.Value = 1;

            // Cho phep de trong ngay tra neu chua tra
            dtpNgayTra.ShowCheckBox = true;
            dtpNgayTra.Checked = false;

            // Cau hinh bang
            dgvPhieuMuon.AutoGenerateColumns = false;
            dgvPhieuMuon.Columns.Clear();
            dgvPhieuMuon.AllowUserToAddRows = false;
            dgvPhieuMuon.ReadOnly = true;
            dgvPhieuMuon.MultiSelect = false;
            dgvPhieuMuon.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuMuon.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuMuon.RowHeadersVisible = false;

            ThemCot("MaPhieu", "Mã phiếu");
            ThemCot("MaSV", "Mã sinh viên");
            ThemCot("HoTen", "Họ tên");
            ThemCot("ThietBi", "Thiết bị");
            ThemCot("SoLuong", "Số lượng");
            ThemCot("NgayMuon", "Ngày mượn");
            ThemCot("HanTra", "Hạn trả");
            ThemCot("NgayTraThucTe", "Ngày trả thực tế");
            ThemCot("TrangThai", "Trạng thái");

            errorProvider1.ContainerControl = this;
            bindingSourcePhieuMuon.DataSource = danhSach;
            dgvPhieuMuon.DataSource = bindingSourcePhieuMuon;
        }

        private void ThemCot(string ten, string tieuDe)
        {
            DataGridViewTextBoxColumn cot =
                new DataGridViewTextBoxColumn();

            cot.Name = ten;
            cot.DataPropertyName = ten;
            cot.HeaderText = tieuDe;

            if (ten == "NgayMuon" || ten == "HanTra" ||
                ten == "NgayTraThucTe")
            {
                cot.DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            dgvPhieuMuon.Columns.Add(cot);
        }

        private void KetNoiSuKien()
        {
            // Cac nut chinh
            btnThem.Click += ThemPhieu_Click;
            btnCapNhat.Click += CapNhatPhieu_Click;
            btnXoa.Click += XoaPhieu_Click;
            btnLamMoi.Click += LamMoi_Click;
            btnXuatCSV.Click += XuatCSV_Click;

            // Hai nut nay co the da duoc Designer lien ket
            // nen khong dang ky them lan nua.
            // Su kien cu duoc xu ly trong cac ham ben duoi.

            cboLoc.SelectedIndexChanged += LocTrangThai_Changed;
            dgvPhieuMuon.SelectionChanged += ChonDong_Changed;
        }

        private PhieuMuon LayPhieuTuForm()
        {
            return new PhieuMuon
            {
                MaPhieu = txtMaPhieu.Text.Trim(),
                MaSV = txtMaSV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                ThietBi = cboThietBi.Text,
                SoLuong = (int)nudSoLuong.Value,
                NgayMuon = dtpNgayMuon.Value.Date,
                HanTra = dtpHanTra.Value.Date,
                NgayTraThucTe = dtpNgayTra.Checked
                    ? dtpNgayTra.Value.Date
                    : (DateTime?)null
            };
        }

        private bool KiemTraDuLieu(
            PhieuMuon p, PhieuMuon phieuDangSua = null)
        {
            errorProvider1.Clear();
            bool hopLe = true;

            if (string.IsNullOrWhiteSpace(p.MaPhieu))
            {
                errorProvider1.SetError(
                    txtMaPhieu, "Mã phiếu không được để trống.");
                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(p.MaSV))
            {
                errorProvider1.SetError(
                    txtMaSV, "Mã sinh viên không được để trống.");
                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(p.HoTen))
            {
                errorProvider1.SetError(
                    txtHoTen, "Họ tên không được để trống.");
                hopLe = false;
            }

            if (cboThietBi.SelectedIndex < 0)
            {
                errorProvider1.SetError(
                    cboThietBi, "Vui lòng chọn thiết bị.");
                hopLe = false;
            }

            if (p.SoLuong <= 0)
            {
                errorProvider1.SetError(
                    nudSoLuong, "Số lượng phải lớn hơn 0.");
                hopLe = false;
            }

            if (p.HanTra.Date < p.NgayMuon.Date)
            {
                errorProvider1.SetError(
                    dtpHanTra,
                    "Hạn trả không được trước ngày mượn.");
                hopLe = false;
            }

            if (p.NgayTraThucTe.HasValue &&
                p.NgayTraThucTe.Value.Date < p.NgayMuon.Date)
            {
                errorProvider1.SetError(
                    dtpNgayTra,
                    "Ngày trả không được trước ngày mượn.");
                hopLe = false;
            }

            bool trungMa = danhSach.Any(x =>
                x.MaPhieu.Equals(
                    p.MaPhieu,
                    StringComparison.OrdinalIgnoreCase) &&
                !object.ReferenceEquals(x, phieuDangSua));

            if (trungMa)
            {
                errorProvider1.SetError(
                    txtMaPhieu, "Mã phiếu đã tồn tại.");
                hopLe = false;
            }

            return hopLe;
        }

        private void ThemPhieu_Click(object sender, EventArgs e)
        {
            PhieuMuon p = LayPhieuTuForm();

            if (!KiemTraDuLieu(p))
                return;

            danhSach.Add(p);
            HienThiDanhSach();
            LamMoiForm();

            MessageBox.Show("Thêm phiếu thành công!");
        }

        private void CapNhatPhieu_Click(object sender, EventArgs e)
        {
            PhieuMuon cu =
                dgvPhieuMuon.CurrentRow?.DataBoundItem as PhieuMuon;

            if (cu == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu cần cập nhật.");
                return;
            }

            PhieuMuon moi = LayPhieuTuForm();

            if (!KiemTraDuLieu(moi, cu))
                return;

            cu.MaPhieu = moi.MaPhieu;
            cu.MaSV = moi.MaSV;
            cu.HoTen = moi.HoTen;
            cu.ThietBi = moi.ThietBi;
            cu.SoLuong = moi.SoLuong;
            cu.NgayMuon = moi.NgayMuon;
            cu.HanTra = moi.HanTra;
            cu.NgayTraThucTe = moi.NgayTraThucTe;

            HienThiDanhSach();
            LamMoiForm();

            MessageBox.Show("Cập nhật phiếu thành công!");
        }

        private void XoaPhieu_Click(object sender, EventArgs e)
        {
            PhieuMuon p =
                dgvPhieuMuon.CurrentRow?.DataBoundItem as PhieuMuon;

            if (p == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu cần xóa.");
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa phiếu " + p.MaPhieu + "?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                danhSach.Remove(p);
                HienThiDanhSach();
                LamMoiForm();
            }
        }

        private void LamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        private void LamMoiForm()
        {
            dangNap = true;

            txtMaPhieu.Clear();
            txtMaSV.Clear();
            txtHoTen.Clear();

            cboThietBi.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;

            nudSoLuong.Value = 1;

            dtpNgayMuon.Value = DateTime.Today;
            dtpHanTra.Value = DateTime.Today.AddDays(7);
            dtpNgayTra.Value = DateTime.Today;
            dtpNgayTra.Checked = false;

            errorProvider1.Clear();
            dgvPhieuMuon.ClearSelection();

            dangNap = false;
        }

        // Ham nay co the da duoc Designer gan cho nut Tim kiem
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void LocTrangThai_Changed(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }


        private void HienThiDanhSach()
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (tuKhoa == "Nhập từ khóa")
            {
                tuKhoa = "";
            }
            string trangThaiLoc = cboLoc.Text;

            var ketQua = danhSach.Where(p =>
                string.IsNullOrWhiteSpace(tuKhoa) ||
                p.MaSV.IndexOf(tuKhoa,
                    StringComparison.OrdinalIgnoreCase) >= 0 ||
                p.ThietBi.IndexOf(tuKhoa,
                    StringComparison.OrdinalIgnoreCase) >= 0);

            if (trangThaiLoc == "Đang mượn" ||
                trangThaiLoc == "Quá hạn" ||
                trangThaiLoc == "Đã trả")
            {
                ketQua = ketQua.Where(
                    p => p.TrangThai == trangThaiLoc);
            }

            bindingSourcePhieuMuon.DataSource =
                new BindingList<PhieuMuon>(ketQua.ToList());

            bindingSourcePhieuMuon.ResetBindings(false);

            CapNhatThongKe();
        }


        private void CapNhatThongKe()
        {
            int tong = danhSach.Count;
            int quaHan = danhSach.Count(
                p => p.TrangThai == "Quá hạn");

            lblThongKe.Text =
                "Tổng số phiếu: " + tong +
                " | Số phiếu quá hạn: " + quaHan;
        }

        private void ChonDong_Changed(object sender, EventArgs e)
        {
            if (dangNap)
                return;

            PhieuMuon p =
                dgvPhieuMuon.CurrentRow?.DataBoundItem as PhieuMuon;

            if (p == null)
                return;

            dangNap = true;

            txtMaPhieu.Text = p.MaPhieu;
            txtMaSV.Text = p.MaSV;
            txtHoTen.Text = p.HoTen;
            cboThietBi.SelectedItem = p.ThietBi;

            nudSoLuong.Value = Math.Max(
                nudSoLuong.Minimum,
                Math.Min(nudSoLuong.Maximum, p.SoLuong));

            dtpNgayMuon.Value = p.NgayMuon;
            dtpHanTra.Value = p.HanTra;

            if (p.NgayTraThucTe.HasValue)
            {
                dtpNgayTra.Value = p.NgayTraThucTe.Value;
                dtpNgayTra.Checked = true;
            }
            else
            {
                dtpNgayTra.Value = DateTime.Today;
                dtpNgayTra.Checked = false;
            }

            cboTrangThai.Text = p.TrangThai;

            dangNap = false;
        }

        // Ham nay co the da duoc Designer gan cho nut Da tra
        private void btnDaTra_Click(object sender, EventArgs e)
        {
            DanhDauDaTra();
        }

        private void DanhDauDaTra()
        {
            PhieuMuon p =
                dgvPhieuMuon.CurrentRow?.DataBoundItem as PhieuMuon;

            if (p == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu cần đánh dấu đã trả.");
                return;
            }

            if (p.NgayTraThucTe.HasValue)
            {
                MessageBox.Show("Phiếu này đã được trả.");
                return;
            }

            if (DateTime.Today < p.NgayMuon.Date)
            {
                MessageBox.Show("Ngày hiện tại trước ngày mượn.");
                return;
            }

            p.NgayTraThucTe = DateTime.Today;

            HienThiDanhSach();
            LamMoiForm();

            MessageBox.Show("Đã cập nhật ngày trả và trạng thái.");
        }

        private void XuatCSV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "DanhSachPhieuMuon.csv";
                sfd.Title = "Xuất danh sách phiếu mượn";

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                StringBuilder sb = new StringBuilder();

                sb.AppendLine(
                    "MaPhieu,MaSV,HoTen,ThietBi,SoLuong," +
                    "NgayMuon,HanTra,NgayTraThucTe,TrangThai");

                foreach (PhieuMuon p in
                    bindingSourcePhieuMuon.Cast<PhieuMuon>())
                {
                    sb.AppendLine(string.Join(",",
                        Csv(p.MaPhieu),
                        Csv(p.MaSV),
                        Csv(p.HoTen),
                        Csv(p.ThietBi),
                        p.SoLuong.ToString(),
                        p.NgayMuon.ToString("dd/MM/yyyy"),
                        p.HanTra.ToString("dd/MM/yyyy"),
                        p.NgayTraThucTe.HasValue
                            ? p.NgayTraThucTe.Value.ToString("dd/MM/yyyy")
                            : "",
                        Csv(p.TrangThai)));
                }

                File.WriteAllText(
                    sfd.FileName,
                    sb.ToString(),
                    new UTF8Encoding(true));

                MessageBox.Show("Xuất CSV thành công!");
            }
        }

        private string Csv(string s)
        {
            return "\"" + (s ?? "").Replace("\"", "\"\"") + "\"";
        }

        // Giu lai ham Load neu Designer da tao tu double-click
        private void toolStripContainer1_ContentPanel_Load(
            object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
