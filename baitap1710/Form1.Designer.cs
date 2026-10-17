namespace baitap1710
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            menuStrip1 = new MenuStrip();
            tệpToolStripMenuItem = new ToolStripMenuItem();
            xuấtCSVToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            cboTrangThai = new ComboBox();
            cboBacSi = new ComboBox();
            dtpNgayGioHen = new DateTimePicker();
            txtLyDoKham = new TextBox();
            txtSoDienThoai = new TextBox();
            txtHoTen = new TextBox();
            txtMaLichHen = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            cboLocTrangThai = new ComboBox();
            dtpLocNgay = new DateTimePicker();
            chkLocTheoNgay = new CheckBox();
            txtTimKiem = new TextBox();
            label9 = new Label();
            label8 = new Label();
            dgvLichHen = new DataGridView();
            colMaLichHen = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colSoDienThoai = new DataGridViewTextBoxColumn();
            colNgayGioHen = new DataGridViewTextBoxColumn();
            colBacSi = new DataGridViewTextBoxColumn();
            colLyDoKham = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            statusStrip1 = new StatusStrip();
            lblTongSo = new ToolStripStatusLabel();
            errorProvider1 = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichHen).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 2);
            tableLayoutPanel1.Controls.Add(dgvLichHen, 0, 3);
            tableLayoutPanel1.Controls.Add(statusStrip1, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(932, 603);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tệpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(932, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tệpToolStripMenuItem
            // 
            tệpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { xuấtCSVToolStripMenuItem });
            tệpToolStripMenuItem.Name = "tệpToolStripMenuItem";
            tệpToolStripMenuItem.Size = new Size(48, 24);
            tệpToolStripMenuItem.Text = "Tệp";
            // 
            // xuấtCSVToolStripMenuItem
            // 
            xuấtCSVToolStripMenuItem.Name = "xuấtCSVToolStripMenuItem";
            xuấtCSVToolStripMenuItem.Size = new Size(152, 26);
            xuấtCSVToolStripMenuItem.Text = "Xuất CSV";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnCapNhat);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(cboTrangThai);
            groupBox1.Controls.Add(cboBacSi);
            groupBox1.Controls.Add(dtpNgayGioHen);
            groupBox1.Controls.Add(txtLyDoKham);
            groupBox1.Controls.Add(txtSoDienThoai);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtMaLichHen);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(926, 194);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin lịch hẹn";
           
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(392, 162);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 17;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(609, 162);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(496, 162);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 15;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(292, 162);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(564, 111);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(151, 28);
            cboTrangThai.TabIndex = 13;
            // 
            // cboBacSi
            // 
            cboBacSi.FormattingEnabled = true;
            cboBacSi.Location = new Point(564, 77);
            cboBacSi.Name = "cboBacSi";
            cboBacSi.Size = new Size(151, 28);
            cboBacSi.TabIndex = 12;
            // 
            // dtpNgayGioHen
            // 
            dtpNgayGioHen.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpNgayGioHen.Format = DateTimePickerFormat.Custom;
            dtpNgayGioHen.Location = new Point(564, 40);
            dtpNgayGioHen.Name = "dtpNgayGioHen";
            dtpNgayGioHen.Size = new Size(168, 27);
            dtpNgayGioHen.TabIndex = 11;
            // 
            // txtLyDoKham
            // 
            txtLyDoKham.Location = new Point(148, 157);
            txtLyDoKham.Multiline = true;
            txtLyDoKham.Name = "txtLyDoKham";
            txtLyDoKham.Size = new Size(125, 34);
            txtLyDoKham.TabIndex = 10;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(148, 115);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(125, 27);
            txtSoDienThoai.TabIndex = 9;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(148, 78);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(125, 27);
            txtHoTen.TabIndex = 8;
            // 
            // txtMaLichHen
            // 
            txtMaLichHen.Location = new Point(148, 45);
            txtMaLichHen.Name = "txtMaLichHen";
            txtMaLichHen.Size = new Size(125, 27);
            txtMaLichHen.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 162);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 6;
            label7.Text = "Lý do khám";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(311, 118);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 5;
            label6.Text = "Trạng thái";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(311, 85);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 4;
            label5.Text = "Bác sĩ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(311, 48);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 3;
            label4.Text = "ngày giờ hẹn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 118);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 81);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 47);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã lịch hẹn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboLocTrangThai);
            groupBox2.Controls.Add(dtpLocNgay);
            groupBox2.Controls.Add(chkLocTheoNgay);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 231);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(926, 54);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm & Lọc";
            // 
            // cboLocTrangThai
            // 
            cboLocTrangThai.FormattingEnabled = true;
            cboLocTrangThai.Location = new Point(148, 22);
            cboLocTrangThai.Name = "cboLocTrangThai";
            cboLocTrangThai.Size = new Size(151, 28);
            cboLocTrangThai.TabIndex = 5;
            // 
            // dtpLocNgay
            // 
            dtpLocNgay.Format = DateTimePickerFormat.Short;
            dtpLocNgay.Location = new Point(711, 25);
            dtpLocNgay.Name = "dtpLocNgay";
            dtpLocNgay.Size = new Size(128, 27);
            dtpLocNgay.TabIndex = 4;
            // 
            // chkLocTheoNgay
            // 
            chkLocTheoNgay.AutoSize = true;
            chkLocTheoNgay.Location = new Point(549, 28);
            chkLocTheoNgay.Name = "chkLocTheoNgay";
            chkLocTheoNgay.Size = new Size(101, 24);
            chkLocTheoNgay.TabIndex = 3;
            chkLocTheoNgay.Text = "checkBox1";
            chkLocTheoNgay.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(392, 27);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(125, 27);
            txtTimKiem.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(311, 28);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 1;
            label9.Text = "Trạng thái";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 25);
            label8.Name = "label8";
            label8.Size = new Size(140, 20);
            label8.TabIndex = 0;
            label8.Text = "Tìm kiếm (Tên/SĐT)";
            // 
            // dgvLichHen
            // 
            dgvLichHen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichHen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichHen.Columns.AddRange(new DataGridViewColumn[] { colMaLichHen, colHoTen, colSoDienThoai, colNgayGioHen, colBacSi, colLyDoKham, colTrangThai });
            dgvLichHen.Dock = DockStyle.Fill;
            dgvLichHen.Location = new Point(3, 291);
            dgvLichHen.MultiSelect = false;
            dgvLichHen.Name = "dgvLichHen";
            dgvLichHen.ReadOnly = true;
            dgvLichHen.RowHeadersWidth = 51;
            dgvLichHen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLichHen.Size = new Size(926, 283);
            dgvLichHen.TabIndex = 3;
            // 
            // colMaLichHen
            // 
            colMaLichHen.DataPropertyName = "MaLichHen";
            colMaLichHen.HeaderText = "Mã lịch hẹn";
            colMaLichHen.MinimumWidth = 6;
            colMaLichHen.Name = "colMaLichHen";
            colMaLichHen.ReadOnly = true;
            // 
            // colHoTen
            // 
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.HeaderText = "Họ tên bệnh nhân";
            colHoTen.MinimumWidth = 6;
            colHoTen.Name = "colHoTen";
            colHoTen.ReadOnly = true;
            // 
            // colSoDienThoai
            // 
            colSoDienThoai.DataPropertyName = "SoDienThoai";
            colSoDienThoai.HeaderText = "Số điện thoại";
            colSoDienThoai.MinimumWidth = 6;
            colSoDienThoai.Name = "colSoDienThoai";
            colSoDienThoai.ReadOnly = true;
            // 
            // colNgayGioHen
            // 
            colNgayGioHen.DataPropertyName = "NgayGioHen";
            colNgayGioHen.HeaderText = "Ngày giờ hẹn";
            colNgayGioHen.MinimumWidth = 6;
            colNgayGioHen.Name = "colNgayGioHen";
            colNgayGioHen.ReadOnly = true;
            // 
            // colBacSi
            // 
            colBacSi.DataPropertyName = "BacSi";
            colBacSi.HeaderText = "Bác sĩ";
            colBacSi.MinimumWidth = 6;
            colBacSi.Name = "colBacSi";
            colBacSi.ReadOnly = true;
            // 
            // colLyDoKham
            // 
            colLyDoKham.DataPropertyName = "LyDoKham";
            colLyDoKham.HeaderText = "Lý do khám";
            colLyDoKham.MinimumWidth = 6;
            colLyDoKham.Name = "colLyDoKham";
            colLyDoKham.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTongSo });
            statusStrip1.Location = new Point(0, 577);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(932, 26);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTongSo
            // 
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Size = new Size(132, 20);
            lblTongSo.Text = "Tổng số lịch hẹn: 0";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 603);
            Controls.Add(tableLayoutPanel1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichHen).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tệpToolStripMenuItem;
        private ToolStripMenuItem xuấtCSVToolStripMenuItem;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnCapNhat;
        private Button btnThem;
        private ComboBox cboTrangThai;
        private ComboBox cboBacSi;
        private DateTimePicker dtpNgayGioHen;
        private TextBox txtLyDoKham;
        private TextBox txtSoDienThoai;
        private TextBox txtHoTen;
        private TextBox txtMaLichHen;
        private Label label7;
        private GroupBox groupBox2;
        private ComboBox cboLocTrangThai;
        private DateTimePicker dtpLocNgay;
        private CheckBox chkLocTheoNgay;
        private TextBox txtTimKiem;
        private Label label9;
        private Label label8;
        private DataGridView dgvLichHen;
        private DataGridViewTextBoxColumn colMaLichHen;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colSoDienThoai;
        private DataGridViewTextBoxColumn colNgayGioHen;
        private DataGridViewTextBoxColumn colBacSi;
        private DataGridViewTextBoxColumn colLyDoKham;
        private DataGridViewTextBoxColumn colTrangThai;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTongSo;
        private ErrorProvider errorProvider1;
    }
}
