namespace baitap1710
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            txtMaPhieu = new TextBox();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            cboThietBi = new ComboBox();
            nudSoLuong = new NumericUpDown();
            dtpNgayMuon = new DateTimePicker();
            dtpHanTra = new DateTimePicker();
            dtpNgayTra = new DateTimePicker();
            cboTrangThai = new ComboBox();
            txtTimKiem = new TextBox();
            cboLoc = new ComboBox();
            btnThem = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnDaTra = new Button();
            btnTimKiem = new Button();
            btnXuatCSV = new Button();
            dgvPhieuMuon = new DataGridView();
            bindingSourcePhieuMuon = new BindingSource(components);
            errorProvider1 = new ErrorProvider(components);
            statusStrip1 = new StatusStrip();
            lblThongKe = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePhieuMuon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(156, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thông tin phiếu mượn";
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(221, 80);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(149, 27);
            txtMaPhieu.TabIndex = 1;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(221, 113);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(151, 27);
            txtMaSV.TabIndex = 2;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(221, 146);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(151, 27);
            txtHoTen.TabIndex = 3;
            // 
            // cboThietBi
            // 
            cboThietBi.FormattingEnabled = true;
            cboThietBi.Location = new Point(221, 179);
            cboThietBi.Name = "cboThietBi";
            cboThietBi.Size = new Size(151, 28);
            cboThietBi.TabIndex = 4;
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(223, 213);
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(150, 27);
            nudSoLuong.TabIndex = 5;
            // 
            // dtpNgayMuon
            // 
            dtpNgayMuon.Format = DateTimePickerFormat.Custom;
            dtpNgayMuon.Location = new Point(223, 246);
            dtpNgayMuon.Name = "dtpNgayMuon";
            dtpNgayMuon.Size = new Size(151, 27);
            dtpNgayMuon.TabIndex = 6;
            // 
            // dtpHanTra
            // 
            dtpHanTra.Format = DateTimePickerFormat.Custom;
            dtpHanTra.Location = new Point(223, 279);
            dtpHanTra.Name = "dtpHanTra";
            dtpHanTra.Size = new Size(149, 27);
            dtpHanTra.TabIndex = 7;
            // 
            // dtpNgayTra
            // 
            dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            dtpNgayTra.Format = DateTimePickerFormat.Custom;
            dtpNgayTra.Location = new Point(223, 312);
            dtpNgayTra.Name = "dtpNgayTra";
            dtpNgayTra.ShowCheckBox = true;
            dtpNgayTra.Size = new Size(151, 27);
            dtpNgayTra.TabIndex = 8;
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(223, 350);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(151, 28);
            cboTrangThai.TabIndex = 9;
            cboTrangThai.Text = "Trạng thái";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(398, 59);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(141, 27);
            txtTimKiem.TabIndex = 10;
            // 
            // cboLoc
            // 
            cboLoc.FormattingEnabled = true;
            cboLoc.Location = new Point(654, 57);
            cboLoc.Name = "cboLoc";
            cboLoc.Size = new Size(151, 28);
            cboLoc.TabIndex = 11;
            cboLoc.Text = "Lọc trạng thái";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(24, 384);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(113, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm phiếu";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(24, 428);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(119, 29);
            btnCapNhat.TabIndex = 13;
            btnCapNhat.Text = "Cập nhật phiếu";
            btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(167, 384);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa phiếu";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(168, 428);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnDaTra
            // 
            btnDaTra.Location = new Point(290, 384);
            btnDaTra.Name = "btnDaTra";
            btnDaTra.Size = new Size(135, 29);
            btnDaTra.TabIndex = 16;
            btnDaTra.Text = "Đánh dấu đã trả";
            btnDaTra.UseVisualStyleBackColor = true;
            btnDaTra.Click += btnDaTra_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(545, 58);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 17;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXuatCSV
            // 
            btnXuatCSV.Location = new Point(823, 58);
            btnXuatCSV.Name = "btnXuatCSV";
            btnXuatCSV.Size = new Size(94, 29);
            btnXuatCSV.TabIndex = 18;
            btnXuatCSV.Text = "Xuất CSV";
            btnXuatCSV.UseVisualStyleBackColor = true;
            // 
            // dgvPhieuMuon
            // 
            dgvPhieuMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuMuon.Location = new Point(431, 116);
            dgvPhieuMuon.Name = "dgvPhieuMuon";
            dgvPhieuMuon.RowHeadersWidth = 51;
            dgvPhieuMuon.Size = new Size(486, 356);
            dgvPhieuMuon.TabIndex = 19;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblThongKe });
            statusStrip1.Location = new Point(0, 475);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(962, 26);
            statusStrip1.TabIndex = 20;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblThongKe
            // 
            lblThongKe.Name = "lblThongKe";
            lblThongKe.Size = new Size(260, 20);
            lblThongKe.Text = "Tổng số phiếu: 0 | Số phiếu quá hạn: 0";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(962, 25);
            toolStrip1.TabIndex = 21;
            toolStrip1.Text = "toolStrip1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 87);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 22;
            label1.Text = "Mã phiếu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 120);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 23;
            label2.Text = "Mã sinh viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 153);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 24;
            label3.Text = "Họ tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 187);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 25;
            label4.Text = "Thiết bị";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 220);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 26;
            label5.Text = "Số lượng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 248);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 27;
            label6.Text = "Ngày mượn:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 278);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 28;
            label7.Text = "Hạn trả";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 312);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 29;
            label8.Text = "Ngày trả thực tế";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 343);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 30;
            label9.Text = "Trạng thái";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 501);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(dgvPhieuMuon);
            Controls.Add(btnXuatCSV);
            Controls.Add(btnTimKiem);
            Controls.Add(btnDaTra);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThem);
            Controls.Add(cboLoc);
            Controls.Add(txtTimKiem);
            Controls.Add(cboTrangThai);
            Controls.Add(dtpNgayTra);
            Controls.Add(dtpHanTra);
            Controls.Add(dtpNgayMuon);
            Controls.Add(nudSoLuong);
            Controls.Add(cboThietBi);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaSV);
            Controls.Add(txtMaPhieu);
            Controls.Add(lblTitle);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuon).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePhieuMuon).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtMaPhieu;
        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private ComboBox cboThietBi;
        private NumericUpDown nudSoLuong;
        private DateTimePicker dtpNgayMuon;
        private DateTimePicker dtpHanTra;
        private DateTimePicker dtpNgayTra;
        private ComboBox cboTrangThai;
        private TextBox txtTimKiem;
        private ComboBox cboLoc;
        private Button btnThem;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnDaTra;
        private Button btnTimKiem;
        private Button btnXuatCSV;
        private DataGridView dgvPhieuMuon;
        private BindingSource bindingSourcePhieuMuon;
        private ErrorProvider errorProvider1;
        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private ToolStripStatusLabel lblThongKe;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}