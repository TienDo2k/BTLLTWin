
namespace BTLLTWin
{
    partial class frmQuanLyHoaDon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyHoaDon));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.cbMaPhong = new System.Windows.Forms.ComboBox();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbThanhToan = new System.Windows.Forms.ComboBox();
            this.btTTPhong = new System.Windows.Forms.Button();
            this.btTTDv = new System.Windows.Forms.Button();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(305, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaHD.Location = new System.Drawing.Point(545, 244);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(470, 26);
            this.txtMaHD.TabIndex = 1;
            this.txtMaHD.Validated += new System.EventHandler(this.txtMaHD_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(305, 307);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(302, 371);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(304, 434);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày đến";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(304, 497);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày đi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(785, 94);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 30);
            this.label10.TabIndex = 0;
            this.label10.Text = "HÓA ĐƠN";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(1190, 238);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(206, 55);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(1190, 301);
            this.btnSua.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(206, 55);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(1190, 363);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(206, 55);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1190, 425);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(206, 55);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.TenKH,
            this.TenPhong,
            this.TenDV,
            this.NgayDen,
            this.NgayDi,
            this.TongTien,
            this.ThanhToan});
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 670);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 29;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(1779, 391);
            this.dgvHoaDon.TabIndex = 14;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick);
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgayDen.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDen.Location = new System.Drawing.Point(542, 432);
            this.dtpNgayDen.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(470, 26);
            this.dtpNgayDen.TabIndex = 15;
            this.dtpNgayDen.Value = new System.DateTime(2021, 8, 18, 0, 0, 0, 0);
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgayDi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDi.Location = new System.Drawing.Point(542, 495);
            this.dtpNgayDi.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(470, 26);
            this.dtpNgayDi.TabIndex = 15;
            this.dtpNgayDi.Value = new System.DateTime(2021, 8, 18, 0, 0, 0, 0);
            // 
            // cbMaPhong
            // 
            this.cbMaPhong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMaPhong.FormattingEnabled = true;
            this.cbMaPhong.Location = new System.Drawing.Point(544, 370);
            this.cbMaPhong.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbMaPhong.Name = "cbMaPhong";
            this.cbMaPhong.Size = new System.Drawing.Size(469, 27);
            this.cbMaPhong.TabIndex = 16;
            // 
            // cbMaKH
            // 
            this.cbMaKH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMaKH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMaKH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Location = new System.Drawing.Point(544, 307);
            this.cbMaKH.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(469, 27);
            this.cbMaKH.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(302, 561);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thanh toán";
            // 
            // cbThanhToan
            // 
            this.cbThanhToan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbThanhToan.FormattingEnabled = true;
            this.cbThanhToan.Items.AddRange(new object[] {
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.cbThanhToan.Location = new System.Drawing.Point(542, 557);
            this.cbThanhToan.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbThanhToan.Name = "cbThanhToan";
            this.cbThanhToan.Size = new System.Drawing.Size(469, 27);
            this.cbThanhToan.TabIndex = 16;
            // 
            // btTTPhong
            // 
            this.btTTPhong.BackColor = System.Drawing.Color.GreenYellow;
            this.btTTPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btTTPhong.Image = ((System.Drawing.Image)(resources.GetObject("btTTPhong.Image")));
            this.btTTPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTTPhong.Location = new System.Drawing.Point(1154, 485);
            this.btTTPhong.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btTTPhong.Name = "btTTPhong";
            this.btTTPhong.Size = new System.Drawing.Size(261, 67);
            this.btTTPhong.TabIndex = 17;
            this.btTTPhong.Text = "TT Tiền Phòng";
            this.btTTPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTTPhong.UseVisualStyleBackColor = false;
            this.btTTPhong.Click += new System.EventHandler(this.btTTPhong_Click);
            // 
            // btTTDv
            // 
            this.btTTDv.BackColor = System.Drawing.Color.GreenYellow;
            this.btTTDv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btTTDv.Image = ((System.Drawing.Image)(resources.GetObject("btTTDv.Image")));
            this.btTTDv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTTDv.Location = new System.Drawing.Point(1154, 561);
            this.btTTDv.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btTTDv.Name = "btTTDv";
            this.btTTDv.Size = new System.Drawing.Size(261, 61);
            this.btTTDv.TabIndex = 18;
            this.btTTDv.Text = "TT Dịch Vụ";
            this.btTTDv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTTDv.UseVisualStyleBackColor = false;
            this.btTTDv.Click += new System.EventHandler(this.btTTDv_Click);
            // 
            // MaHD
            // 
            this.MaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            // 
            // TenKH
            // 
            this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            // 
            // TenPhong
            // 
            this.TenPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên phòng";
            this.TenPhong.MinimumWidth = 6;
            this.TenPhong.Name = "TenPhong";
            // 
            // TenDV
            // 
            this.TenDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDV.DataPropertyName = "TenDV";
            this.TenDV.HeaderText = "Tên dịch vụ";
            this.TenDV.MinimumWidth = 6;
            this.TenDV.Name = "TenDV";
            // 
            // NgayDen
            // 
            this.NgayDen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayDen.DataPropertyName = "NgayDen";
            this.NgayDen.HeaderText = "Ngày đến";
            this.NgayDen.MinimumWidth = 6;
            this.NgayDen.Name = "NgayDen";
            // 
            // NgayDi
            // 
            this.NgayDi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayDi.DataPropertyName = "NgayDi";
            this.NgayDi.HeaderText = "Ngày đi";
            this.NgayDi.MinimumWidth = 6;
            this.NgayDi.Name = "NgayDi";
            // 
            // TongTien
            // 
            this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            // 
            // ThanhToan
            // 
            this.ThanhToan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhToan.DataPropertyName = "ThanhToan";
            this.ThanhToan.HeaderText = "Thanh toán";
            this.ThanhToan.MinimumWidth = 6;
            this.ThanhToan.Name = "ThanhToan";
            // 
            // txtcv
            // 
            this.txtcv.Location = new System.Drawing.Point(1454, 175);
            this.txtcv.Name = "txtcv";
            this.txtcv.Size = new System.Drawing.Size(10, 32);
            this.txtcv.TabIndex = 19;
            this.txtcv.Visible = false;
            // 
            // frmQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1779, 1061);
            this.Controls.Add(this.txtcv);
            this.Controls.Add(this.btTTDv);
            this.Controls.Add(this.btTTPhong);
            this.Controls.Add(this.cbMaKH);
            this.Controls.Add(this.cbThanhToan);
            this.Controls.Add(this.cbMaPhong);
            this.Controls.Add(this.dtpNgayDi);
            this.Controls.Add(this.dtpNgayDen);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "frmQuanLyHoaDon";
            this.Text = "Quản lý hóa đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.ComboBox cbMaPhong;
        private System.Windows.Forms.ComboBox cbMaKH;
        private System.Windows.Forms.ComboBox cbThanhToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btTTDv;
        private System.Windows.Forms.Button btTTPhong;
        private System.Windows.Forms.TextBox txtcv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhToan;
    }
}

