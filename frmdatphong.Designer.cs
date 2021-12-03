
namespace BTLLTWin
{
    partial class formdatphong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formdatphong));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvdatphong = new System.Windows.Forms.DataGridView();
            this.SoCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaydatphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.dtpdatphong = new System.Windows.Forms.DateTimePicker();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.butdatphong = new System.Windows.Forms.Button();
            this.buttraphong = new System.Windows.Forms.Button();
            this.buttim = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsocmnd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.dgvkhachhang = new System.Windows.Forms.DataGridView();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butlammoi = new System.Windows.Forms.Button();
            this.txtcv = new System.Windows.Forms.TextBox();
            this.dtpngaydi = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvphong = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.butgiahan = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdatphong
            // 
            this.dgvdatphong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvdatphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoCMND,
            this.HoTen,
            this.sdt,
            this.Ngaydatphong,
            this.ngaydi,
            this.MaPhong,
            this.dataGridViewTextBoxColumn4});
            this.dgvdatphong.Location = new System.Drawing.Point(96, 567);
            this.dgvdatphong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdatphong.Name = "dgvdatphong";
            this.dgvdatphong.RowTemplate.Height = 25;
            this.dgvdatphong.Size = new System.Drawing.Size(1077, 328);
            this.dgvdatphong.TabIndex = 0;
            this.dgvdatphong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdatphong_CellClick);
            // 
            // SoCMND
            // 
            this.SoCMND.DataPropertyName = "SoCMND";
            this.SoCMND.HeaderText = "Số CMND";
            this.SoCMND.Name = "SoCMND";
            this.SoCMND.Width = 150;
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "SDT";
            this.sdt.HeaderText = "SĐT";
            this.sdt.Name = "sdt";
            this.sdt.Width = 150;
            // 
            // Ngaydatphong
            // 
            this.Ngaydatphong.DataPropertyName = "NgayDatPhong";
            this.Ngaydatphong.HeaderText = "Ngày đặt phòng";
            this.Ngaydatphong.Name = "Ngaydatphong";
            this.Ngaydatphong.Width = 150;
            // 
            // ngaydi
            // 
            this.ngaydi.DataPropertyName = "NgayDi";
            this.ngaydi.HeaderText = "Ngày đi";
            this.ngaydi.Name = "ngaydi";
            this.ngaydi.Width = 150;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.Name = "MaPhong";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TinhTrangDp";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tình trạng";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(172, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số CMND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(172, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(172, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(172, 339);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày thuê phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(172, 437);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã phòng";
            // 
            // txthoten
            // 
            this.txthoten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txthoten.Location = new System.Drawing.Point(390, 177);
            this.txthoten.Margin = new System.Windows.Forms.Padding(4);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(358, 29);
            this.txthoten.TabIndex = 3;
            // 
            // txtsdt
            // 
            this.txtsdt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtsdt.Location = new System.Drawing.Point(390, 228);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(358, 29);
            this.txtsdt.TabIndex = 4;
            // 
            // dtpdatphong
            // 
            this.dtpdatphong.Enabled = false;
            this.dtpdatphong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpdatphong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdatphong.Location = new System.Drawing.Point(390, 329);
            this.dtpdatphong.Margin = new System.Windows.Forms.Padding(4);
            this.dtpdatphong.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dtpdatphong.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpdatphong.Name = "dtpdatphong";
            this.dtpdatphong.Size = new System.Drawing.Size(358, 29);
            this.dtpdatphong.TabIndex = 6;
            this.dtpdatphong.Value = new System.DateTime(2021, 8, 29, 15, 14, 11, 0);
            // 
            // txtmaphong
            // 
            this.txtmaphong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtmaphong.Location = new System.Drawing.Point(390, 431);
            this.txtmaphong.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(358, 29);
            this.txtmaphong.TabIndex = 7;
            // 
            // butdatphong
            // 
            this.butdatphong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butdatphong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butdatphong.Image = ((System.Drawing.Image)(resources.GetObject("butdatphong.Image")));
            this.butdatphong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butdatphong.Location = new System.Drawing.Point(858, 190);
            this.butdatphong.Margin = new System.Windows.Forms.Padding(4);
            this.butdatphong.Name = "butdatphong";
            this.butdatphong.Size = new System.Drawing.Size(194, 53);
            this.butdatphong.TabIndex = 8;
            this.butdatphong.Text = "Thuê phòng ";
            this.butdatphong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butdatphong.UseVisualStyleBackColor = false;
            this.butdatphong.Click += new System.EventHandler(this.butdatphong_Click);
            // 
            // buttraphong
            // 
            this.buttraphong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttraphong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttraphong.Image = ((System.Drawing.Image)(resources.GetObject("buttraphong.Image")));
            this.buttraphong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttraphong.Location = new System.Drawing.Point(858, 263);
            this.buttraphong.Margin = new System.Windows.Forms.Padding(4);
            this.buttraphong.Name = "buttraphong";
            this.buttraphong.Size = new System.Drawing.Size(194, 53);
            this.buttraphong.TabIndex = 9;
            this.buttraphong.Text = "Hủy thuê phòng";
            this.buttraphong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttraphong.UseVisualStyleBackColor = false;
            this.buttraphong.Click += new System.EventHandler(this.buttraphong_Click);
            // 
            // buttim
            // 
            this.buttim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttim.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttim.Image = ((System.Drawing.Image)(resources.GetObject("buttim.Image")));
            this.buttim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttim.Location = new System.Drawing.Point(858, 339);
            this.buttim.Margin = new System.Windows.Forms.Padding(4);
            this.buttim.Name = "buttim";
            this.buttim.Size = new System.Drawing.Size(194, 56);
            this.buttim.TabIndex = 11;
            this.buttim.Text = "Tìm theo CMND";
            this.buttim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttim.UseVisualStyleBackColor = false;
            this.buttim.Click += new System.EventHandler(this.buttim_Click);
            // 
            // butthoat
            // 
            this.butthoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butthoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butthoat.Image = ((System.Drawing.Image)(resources.GetObject("butthoat.Image")));
            this.butthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butthoat.Location = new System.Drawing.Point(1086, 339);
            this.butthoat.Margin = new System.Windows.Forms.Padding(4);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(194, 56);
            this.butthoat.TabIndex = 12;
            this.butthoat.Text = "Thoát";
            this.butthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butthoat.UseVisualStyleBackColor = false;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(901, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 36);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quản lý thuê phòng";
            // 
            // txtsocmnd
            // 
            this.txtsocmnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtsocmnd.Location = new System.Drawing.Point(390, 127);
            this.txtsocmnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtsocmnd.Name = "txtsocmnd";
            this.txtsocmnd.Size = new System.Drawing.Size(358, 29);
            this.txtsocmnd.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(172, 285);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Địa chỉ";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtdiachi.Location = new System.Drawing.Point(390, 279);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(358, 29);
            this.txtdiachi.TabIndex = 5;
            // 
            // dgvkhachhang
            // 
            this.dgvkhachhang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makh,
            this.dataGridViewTextBoxColumn2,
            this.cmnd,
            this.dataGridViewTextBoxColumn3,
            this.diachi});
            this.dgvkhachhang.Location = new System.Drawing.Point(1218, 567);
            this.dgvkhachhang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvkhachhang.Name = "dgvkhachhang";
            this.dgvkhachhang.RowTemplate.Height = 25;
            this.dgvkhachhang.Size = new System.Drawing.Size(693, 328);
            this.dgvkhachhang.TabIndex = 14;
            this.dgvkhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkhachhang_CellClick);
            // 
            // makh
            // 
            this.makh.DataPropertyName = "MaKH";
            this.makh.HeaderText = "Mã KH";
            this.makh.Name = "makh";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenKH";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ tên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // cmnd
            // 
            this.cmnd.DataPropertyName = "SoCmnd";
            this.cmnd.HeaderText = "Số CMND";
            this.cmnd.Name = "cmnd";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SDT";
            this.dataGridViewTextBoxColumn3.HeaderText = "SĐT";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // diachi
            // 
            this.diachi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diachi.DataPropertyName = "DiaChi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            // 
            // butlammoi
            // 
            this.butlammoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butlammoi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butlammoi.Image = ((System.Drawing.Image)(resources.GetObject("butlammoi.Image")));
            this.butlammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butlammoi.Location = new System.Drawing.Point(1086, 266);
            this.butlammoi.Margin = new System.Windows.Forms.Padding(4);
            this.butlammoi.Name = "butlammoi";
            this.butlammoi.Size = new System.Drawing.Size(194, 56);
            this.butlammoi.TabIndex = 10;
            this.butlammoi.Text = "Làm mới";
            this.butlammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butlammoi.UseVisualStyleBackColor = false;
            this.butlammoi.Click += new System.EventHandler(this.butlammoi_Click);
            // 
            // txtcv
            // 
            this.txtcv.Location = new System.Drawing.Point(2285, 0);
            this.txtcv.Margin = new System.Windows.Forms.Padding(4);
            this.txtcv.Name = "txtcv";
            this.txtcv.Size = new System.Drawing.Size(12, 26);
            this.txtcv.TabIndex = 15;
            // 
            // dtpngaydi
            // 
            this.dtpngaydi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpngaydi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaydi.Location = new System.Drawing.Point(390, 380);
            this.dtpngaydi.Margin = new System.Windows.Forms.Padding(4);
            this.dtpngaydi.Name = "dtpngaydi";
            this.dtpngaydi.Size = new System.Drawing.Size(358, 29);
            this.dtpngaydi.TabIndex = 7;
            this.dtpngaydi.Value = new System.DateTime(2021, 8, 29, 3, 54, 12, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(172, 390);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ngày đi";
            // 
            // dgvphong
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgvphong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvphong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvphong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.loaiphong,
            this.Tinhtrang,
            this.gia,
            this.Sluong});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvphong.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvphong.Location = new System.Drawing.Point(1348, 133);
            this.dgvphong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvphong.Name = "dgvphong";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvphong.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvphong.RowTemplate.Height = 25;
            this.dgvphong.Size = new System.Drawing.Size(563, 348);
            this.dgvphong.TabIndex = 12;
            this.dgvphong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphong_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(1498, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "----Phòng còn trống----";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(555, 528);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(223, 26);
            this.label10.TabIndex = 1;
            this.label10.Text = "----Phòng đã thuê----";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(1498, 528);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 26);
            this.label11.TabIndex = 1;
            this.label11.Text = "----Khách hàng----";
            // 
            // butgiahan
            // 
            this.butgiahan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butgiahan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butgiahan.Image = ((System.Drawing.Image)(resources.GetObject("butgiahan.Image")));
            this.butgiahan.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.butgiahan.Location = new System.Drawing.Point(1086, 190);
            this.butgiahan.Margin = new System.Windows.Forms.Padding(4);
            this.butgiahan.Name = "butgiahan";
            this.butgiahan.Size = new System.Drawing.Size(194, 53);
            this.butgiahan.TabIndex = 16;
            this.butgiahan.Text = "Gia hạn phòng";
            this.butgiahan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butgiahan.UseVisualStyleBackColor = false;
            this.butgiahan.Click += new System.EventHandler(this.butgiahan_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaPhong";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Phòng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // loaiphong
            // 
            this.loaiphong.DataPropertyName = "LoaiPhong";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loaiphong.DefaultCellStyle = dataGridViewCellStyle4;
            this.loaiphong.HeaderText = "Loại phòng";
            this.loaiphong.Name = "loaiphong";
            // 
            // Tinhtrang
            // 
            this.Tinhtrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tinhtrang.DataPropertyName = "TinhTrang";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tinhtrang.DefaultCellStyle = dataGridViewCellStyle5;
            this.Tinhtrang.HeaderText = "Tình trạng";
            this.Tinhtrang.Name = "Tinhtrang";
            // 
            // gia
            // 
            this.gia.DataPropertyName = "Gia";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gia.DefaultCellStyle = dataGridViewCellStyle6;
            this.gia.HeaderText = "Giá";
            this.gia.Name = "gia";
            // 
            // Sluong
            // 
            this.Sluong.DataPropertyName = "SoNguoiToiDa";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sluong.DefaultCellStyle = dataGridViewCellStyle7;
            this.Sluong.HeaderText = "Số người ";
            this.Sluong.Name = "Sluong";
            // 
            // formdatphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1924, 908);
            this.Controls.Add(this.butgiahan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvphong);
            this.Controls.Add(this.dtpngaydi);
            this.Controls.Add(this.txtcv);
            this.Controls.Add(this.butlammoi);
            this.Controls.Add(this.dgvkhachhang);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.buttim);
            this.Controls.Add(this.buttraphong);
            this.Controls.Add(this.butdatphong);
            this.Controls.Add(this.txtmaphong);
            this.Controls.Add(this.dtpdatphong);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtsocmnd);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvdatphong);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formdatphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form đặt phòng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formdatphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatphong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdatphong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.DateTimePicker dtpdatphong;
        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.Button butdatphong;
        private System.Windows.Forms.Button buttraphong;
        private System.Windows.Forms.Button buttim;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsocmnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.DataGridView dgvkhachhang;
        private System.Windows.Forms.Button butlammoi;
        private System.Windows.Forms.TextBox txtcv;
        private System.Windows.Forms.DateTimePicker dtpngaydi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvphong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button butgiahan;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaydatphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sluong;
    }
}