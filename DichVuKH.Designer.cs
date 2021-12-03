
namespace BTLLTWin
{
    partial class DichVuKH
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DichVuKH));
            this.bh = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btThanhToan = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btNew = new System.Windows.Forms.Button();
            this.txtMaKh = new System.Windows.Forms.TextBox();
            this.kh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenkh = new System.Windows.Forms.TextBox();
            this.txtcv = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kh)).BeginInit();
            this.SuspendLayout();
            // 
            // bh
            // 
            this.bh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.c9,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.bh.Location = new System.Drawing.Point(13, 575);
            this.bh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bh.Name = "bh";
            this.bh.Size = new System.Drawing.Size(1380, 379);
            this.bh.TabIndex = 0;
            this.bh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bh_CellContentClick);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MaDichVu";
            this.Column7.HeaderText = "Mã DV";
            this.Column7.Name = "Column7";
            this.Column7.Width = 50;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TenDichVu";
            this.Column8.HeaderText = "Tên DV";
            this.Column8.Name = "Column8";
            this.Column8.Width = 110;
            // 
            // c9
            // 
            this.c9.DataPropertyName = "MaKh";
            this.c9.HeaderText = "Mã Khách Hàng ";
            this.c9.Name = "c9";
            this.c9.Width = 50;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "TenKh";
            this.Column9.HeaderText = "Tên khách hàng ";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "SoLuong";
            this.Column10.HeaderText = "Số lượng";
            this.Column10.Name = "Column10";
            this.Column10.Width = 60;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "DonGia";
            this.Column11.HeaderText = "Đơn Giá";
            this.Column11.Name = "Column11";
            this.Column11.Width = 80;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column12.DataPropertyName = "NgaySuDung";
            this.Column12.HeaderText = "Ngày sử dụng";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Thanhtien";
            this.Column13.HeaderText = "Thành Tiền ";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column14.DataPropertyName = "TinhTrang";
            this.Column14.HeaderText = "Tình Trạng ";
            this.Column14.Name = "Column14";
            // 
            // menu
            // 
            this.menu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu.Location = new System.Drawing.Point(1401, 0);
            this.menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menu.Name = "menu";
            this.menu.RowTemplate.Height = 25;
            this.menu.Size = new System.Drawing.Size(403, 969);
            this.menu.TabIndex = 1;
            this.menu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menu_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaDichVu";
            this.Column3.HeaderText = "Mã DV";
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "TenDichVu";
            this.Column4.HeaderText = "Tên DV";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DonGia";
            this.Column5.HeaderText = "Đơn Giá";
            this.Column5.Name = "Column5";
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SLc";
            this.Column6.HeaderText = "Số lượng có";
            this.Column6.Name = "Column6";
            this.Column6.Width = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(147, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Khách Hàng ";
            // 
            // txtMaSp
            // 
            this.txtMaSp.Enabled = false;
            this.txtMaSp.Location = new System.Drawing.Point(347, 238);
            this.txtMaSp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaSp.Name = "txtMaSp";
            this.txtMaSp.Size = new System.Drawing.Size(287, 26);
            this.txtMaSp.TabIndex = 7;
            this.txtMaSp.Validated += new System.EventHandler(this.txtMaSp_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(158, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã Dịch Vụ ";
            // 
            // txtTenSp
            // 
            this.txtTenSp.Enabled = false;
            this.txtTenSp.Location = new System.Drawing.Point(347, 295);
            this.txtTenSp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenSp.Name = "txtTenSp";
            this.txtTenSp.Size = new System.Drawing.Size(287, 26);
            this.txtTenSp.TabIndex = 9;
            this.txtTenSp.Validated += new System.EventHandler(this.txtTenSp_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(158, 294);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên Dịch Vụ ";
            // 
            // txtSl
            // 
            this.txtSl.Location = new System.Drawing.Point(347, 350);
            this.txtSl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(287, 26);
            this.txtSl.TabIndex = 11;
            this.txtSl.Validated += new System.EventHandler(this.txtSl_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(147, 348);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số Lượng Mua";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(158, 412);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày Mua";
            // 
            // dtNgay
            // 
            this.dtNgay.CustomFormat = "dd-MM-yyyy";
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(347, 408);
            this.dtNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(287, 26);
            this.dtNgay.TabIndex = 13;
            this.dtNgay.Value = new System.DateTime(2021, 8, 20, 0, 0, 0, 0);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(702, 148);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(122, 54);
            this.btThem.TabIndex = 14;
            this.btThem.Text = "Thêm ";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(702, 231);
            this.btSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(122, 53);
            this.btSua.TabIndex = 15;
            this.btSua.Text = "Sửa ";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(702, 323);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(122, 51);
            this.btXoa.TabIndex = 16;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(851, 323);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(130, 51);
            this.btThoat.TabIndex = 17;
            this.btThoat.Text = "Thoát ";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btThanhToan
            // 
            this.btThanhToan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btThanhToan.Image")));
            this.btThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThanhToan.Location = new System.Drawing.Point(851, 231);
            this.btThanhToan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(156, 53);
            this.btThanhToan.TabIndex = 18;
            this.btThanhToan.Text = "Thanh Toán ";
            this.btThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThanhToan.UseVisualStyleBackColor = false;
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(1938, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 26);
            this.label7.TabIndex = 19;
            this.label7.Text = "------ Menu ------ ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(608, 519);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "------ Bán Hàng ------ ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(140, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên Khách Hàng ";
            // 
            // btNew
            // 
            this.btNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btNew.Image = ((System.Drawing.Image)(resources.GetObject("btNew.Image")));
            this.btNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNew.Location = new System.Drawing.Point(851, 148);
            this.btNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(156, 54);
            this.btNew.TabIndex = 23;
            this.btNew.Text = "Làm Mới ";
            this.btNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNew.UseVisualStyleBackColor = false;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // txtMaKh
            // 
            this.txtMaKh.Enabled = false;
            this.txtMaKh.Location = new System.Drawing.Point(347, 138);
            this.txtMaKh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaKh.Name = "txtMaKh";
            this.txtMaKh.Size = new System.Drawing.Size(287, 26);
            this.txtMaKh.TabIndex = 24;
            // 
            // kh
            // 
            this.kh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.kh.Location = new System.Drawing.Point(1078, 93);
            this.kh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kh.Name = "kh";
            this.kh.RowTemplate.Height = 25;
            this.kh.Size = new System.Drawing.Size(315, 465);
            this.kh.TabIndex = 25;
            this.kh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kh_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaKh";
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenKh";
            this.Column2.HeaderText = "Tên khách hàng ";
            this.Column2.Name = "Column2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(1129, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 26);
            this.label9.TabIndex = 26;
            this.label9.Text = "---Khách Hàng---- ";
            // 
            // txtTenkh
            // 
            this.txtTenkh.Enabled = false;
            this.txtTenkh.Location = new System.Drawing.Point(347, 189);
            this.txtTenkh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenkh.Name = "txtTenkh";
            this.txtTenkh.Size = new System.Drawing.Size(287, 26);
            this.txtTenkh.TabIndex = 27;
            // 
            // txtcv
            // 
            this.txtcv.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtcv.Enabled = false;
            this.txtcv.Location = new System.Drawing.Point(1228, 15);
            this.txtcv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcv.Name = "txtcv";
            this.txtcv.Size = new System.Drawing.Size(13, 29);
            this.txtcv.TabIndex = 28;
            this.txtcv.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(495, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(428, 40);
            this.label10.TabIndex = 29;
            this.label10.Text = "DỊCH VỤ KHÁCH HÀNG ";
            // 
            // DichVuKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1804, 969);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtcv);
            this.Controls.Add(this.txtTenkh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.kh);
            this.Controls.Add(this.txtMaKh);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btThanhToan);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dtNgay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenSp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaSp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.bh);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DichVuKH";
            this.Text = "DichVuKH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DichVuKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bh;
        private System.Windows.Forms.DataGridView menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.TextBox txtMaKh;
        private System.Windows.Forms.DataGridView kh;
        private System.Windows.Forms.TextBox txtTenkh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button txtcv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn c9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}