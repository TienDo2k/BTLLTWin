
namespace BTLLTWin
{
    partial class FrmThietbivattu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThietbivattu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mavt = new System.Windows.Forms.TextBox();
            this.txt_tenvt = new System.Windows.Forms.TextBox();
            this.dtpthoigian = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.dtvthietbi = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mavattu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenvattu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trigia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaychuyenvao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_sua = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tinhtrang = new System.Windows.Forms.TextBox();
            this.dtvphong = new System.Windows.Forms.DataGridView();
            this.maphong1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btLamMoi = new System.Windows.Forms.Button();
            this.bt_tim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_chuyenvt = new System.Windows.Forms.Button();
            this.bt_baotri = new System.Windows.Forms.Button();
            this.bt_lichsu = new System.Windows.Forms.Button();
            this.txt_phongsd = new System.Windows.Forms.TextBox();
            this.txt_trigia = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_phongchuyendi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_soluongchuyen = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txtcv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtvthietbi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvphong)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(450, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày chuyển vào:";
            // 
            // txt_mavt
            // 
            this.txt_mavt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_mavt.Location = new System.Drawing.Point(296, 150);
            this.txt_mavt.Multiline = true;
            this.txt_mavt.Name = "txt_mavt";
            this.txt_mavt.Size = new System.Drawing.Size(142, 30);
            this.txt_mavt.TabIndex = 7;
            this.txt_mavt.Validated += new System.EventHandler(this.txt_mavt_Validated);
            // 
            // txt_tenvt
            // 
            this.txt_tenvt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tenvt.Location = new System.Drawing.Point(296, 190);
            this.txt_tenvt.Multiline = true;
            this.txt_tenvt.Name = "txt_tenvt";
            this.txt_tenvt.Size = new System.Drawing.Size(141, 30);
            this.txt_tenvt.TabIndex = 8;
            this.txt_tenvt.Validated += new System.EventHandler(this.txt_tenvt_Validated);
            // 
            // dtpthoigian
            // 
            this.dtpthoigian.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpthoigian.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpthoigian.Location = new System.Drawing.Point(597, 104);
            this.dtpthoigian.Name = "dtpthoigian";
            this.dtpthoigian.Size = new System.Drawing.Size(140, 26);
            this.dtpthoigian.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(586, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Quản lý thiết bị, vật tư";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_them.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_them.Image = ((System.Drawing.Image)(resources.GetObject("bt_them.Image")));
            this.bt_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_them.Location = new System.Drawing.Point(748, 107);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(104, 40);
            this.bt_them.TabIndex = 13;
            this.bt_them.Text = "Thêm";
            this.bt_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_thoat.Image = ((System.Drawing.Image)(resources.GetObject("bt_thoat.Image")));
            this.bt_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_thoat.Location = new System.Drawing.Point(870, 132);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(106, 44);
            this.bt_thoat.TabIndex = 14;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // dtvthietbi
            // 
            this.dtvthietbi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvthietbi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtvthietbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvthietbi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.mavattu,
            this.tenvattu,
            this.soluong,
            this.trigia,
            this.ngaychuyenvao,
            this.tinhtrang,
            this.Column1});
            this.dtvthietbi.Location = new System.Drawing.Point(12, 390);
            this.dtvthietbi.Name = "dtvthietbi";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvthietbi.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtvthietbi.RowHeadersWidth = 51;
            this.dtvthietbi.RowTemplate.Height = 29;
            this.dtvthietbi.Size = new System.Drawing.Size(1251, 385);
            this.dtvthietbi.TabIndex = 0;
            this.dtvthietbi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // mavattu
            // 
            this.mavattu.DataPropertyName = "MaVatTu";
            this.mavattu.HeaderText = "Mã Vật Tư";
            this.mavattu.MinimumWidth = 6;
            this.mavattu.Name = "mavattu";
            this.mavattu.Width = 120;
            // 
            // tenvattu
            // 
            this.tenvattu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenvattu.DataPropertyName = "TenVatTu";
            this.tenvattu.HeaderText = "Tên Vật Tư";
            this.tenvattu.MinimumWidth = 6;
            this.tenvattu.Name = "tenvattu";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "SL";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.Width = 110;
            // 
            // trigia
            // 
            this.trigia.DataPropertyName = "TriGia";
            this.trigia.HeaderText = "Trị Giá";
            this.trigia.MinimumWidth = 6;
            this.trigia.Name = "trigia";
            this.trigia.Width = 125;
            // 
            // ngaychuyenvao
            // 
            this.ngaychuyenvao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaychuyenvao.DataPropertyName = "NgayChuyenVao";
            this.ngaychuyenvao.HeaderText = "Ngày chuyển vào";
            this.ngaychuyenvao.MinimumWidth = 6;
            this.ngaychuyenvao.Name = "ngaychuyenvao";
            // 
            // tinhtrang
            // 
            this.tinhtrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tinhtrang.DataPropertyName = "TinhTrang";
            this.tinhtrang.HeaderText = "Tình trạng";
            this.tinhtrang.MinimumWidth = 6;
            this.tinhtrang.Name = "tinhtrang";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaPhong";
            this.Column1.HeaderText = "Phòng sử dụng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 160;
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_sua.Image = ((System.Drawing.Image)(resources.GetObject("bt_sua.Image")));
            this.bt_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sua.Location = new System.Drawing.Point(748, 158);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(104, 40);
            this.bt_sua.TabIndex = 18;
            this.bt_sua.Text = "Sửa ";
            this.bt_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(143, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "Số lượng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(450, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Trị giá:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(450, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "Tình trạng:";
            // 
            // txt_tinhtrang
            // 
            this.txt_tinhtrang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tinhtrang.Location = new System.Drawing.Point(597, 230);
            this.txt_tinhtrang.Name = "txt_tinhtrang";
            this.txt_tinhtrang.Size = new System.Drawing.Size(140, 26);
            this.txt_tinhtrang.TabIndex = 31;
            this.txt_tinhtrang.Validated += new System.EventHandler(this.txt_tinhtrang_Validated);
            // 
            // dtvphong
            // 
            this.dtvphong.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvphong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtvphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphong1,
            this.tenphong,
            this.loaiphong});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtvphong.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtvphong.Location = new System.Drawing.Point(1320, 141);
            this.dtvphong.Name = "dtvphong";
            this.dtvphong.RowHeadersWidth = 51;
            this.dtvphong.RowTemplate.Height = 29;
            this.dtvphong.Size = new System.Drawing.Size(471, 634);
            this.dtvphong.TabIndex = 32;
            this.dtvphong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvphong_CellClick);
            // 
            // maphong1
            // 
            this.maphong1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maphong1.DataPropertyName = "MaPhong";
            this.maphong1.HeaderText = "Mã Phòng";
            this.maphong1.MinimumWidth = 6;
            this.maphong1.Name = "maphong1";
            // 
            // tenphong
            // 
            this.tenphong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenphong.DataPropertyName = "TenPhong";
            this.tenphong.HeaderText = "Tên Phòng";
            this.tenphong.MinimumWidth = 6;
            this.tenphong.Name = "tenphong";
            // 
            // loaiphong
            // 
            this.loaiphong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loaiphong.DataPropertyName = "LoaiPhong";
            this.loaiphong.HeaderText = "Loại phòng";
            this.loaiphong.MinimumWidth = 6;
            this.loaiphong.Name = "loaiphong";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label11.Location = new System.Drawing.Point(1482, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 30);
            this.label11.TabIndex = 33;
            this.label11.Text = "----Phòng----";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label12.Location = new System.Drawing.Point(569, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 30);
            this.label12.TabIndex = 34;
            this.label12.Text = "----Vật tư----";
            // 
            // btLamMoi
            // 
            this.btLamMoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btLamMoi.Image")));
            this.btLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLamMoi.Location = new System.Drawing.Point(870, 195);
            this.btLamMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btLamMoi.Name = "btLamMoi";
            this.btLamMoi.Size = new System.Drawing.Size(106, 51);
            this.btLamMoi.TabIndex = 35;
            this.btLamMoi.Text = "Refresh";
            this.btLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLamMoi.UseVisualStyleBackColor = false;
            this.btLamMoi.Click += new System.EventHandler(this.btLamMoi_Click);
            // 
            // bt_tim
            // 
            this.bt_tim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_tim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_tim.Image = ((System.Drawing.Image)(resources.GetObject("bt_tim.Image")));
            this.bt_tim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_tim.Location = new System.Drawing.Point(748, 219);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(104, 51);
            this.bt_tim.TabIndex = 36;
            this.bt_tim.Text = "   Tìm";
            this.bt_tim.UseVisualStyleBackColor = false;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(143, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tên vật tư:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(146, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Mã vật tư:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(450, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 19);
            this.label7.TabIndex = 39;
            this.label7.Text = "Phòng sử dụng:";
            // 
            // bt_chuyenvt
            // 
            this.bt_chuyenvt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_chuyenvt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_chuyenvt.Location = new System.Drawing.Point(996, 106);
            this.bt_chuyenvt.Name = "bt_chuyenvt";
            this.bt_chuyenvt.Size = new System.Drawing.Size(131, 41);
            this.bt_chuyenvt.TabIndex = 40;
            this.bt_chuyenvt.Text = "Chuyển VT";
            this.bt_chuyenvt.UseVisualStyleBackColor = false;
            this.bt_chuyenvt.Click += new System.EventHandler(this.bt_chuyenvt_Click);
            // 
            // bt_baotri
            // 
            this.bt_baotri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_baotri.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_baotri.Location = new System.Drawing.Point(996, 156);
            this.bt_baotri.Name = "bt_baotri";
            this.bt_baotri.Size = new System.Drawing.Size(131, 44);
            this.bt_baotri.TabIndex = 41;
            this.bt_baotri.Text = "Bảo trì";
            this.bt_baotri.UseVisualStyleBackColor = false;
            this.bt_baotri.Click += new System.EventHandler(this.bt_baotri_Click);
            // 
            // bt_lichsu
            // 
            this.bt_lichsu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_lichsu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_lichsu.Location = new System.Drawing.Point(996, 219);
            this.bt_lichsu.Name = "bt_lichsu";
            this.bt_lichsu.Size = new System.Drawing.Size(131, 51);
            this.bt_lichsu.TabIndex = 42;
            this.bt_lichsu.Text = "Lịch sử chuyển";
            this.bt_lichsu.UseVisualStyleBackColor = false;
            this.bt_lichsu.Click += new System.EventHandler(this.bt_lichsu_Click);
            // 
            // txt_phongsd
            // 
            this.txt_phongsd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_phongsd.Location = new System.Drawing.Point(597, 150);
            this.txt_phongsd.Name = "txt_phongsd";
            this.txt_phongsd.Size = new System.Drawing.Size(140, 26);
            this.txt_phongsd.TabIndex = 43;
            // 
            // txt_trigia
            // 
            this.txt_trigia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_trigia.Location = new System.Drawing.Point(597, 188);
            this.txt_trigia.Name = "txt_trigia";
            this.txt_trigia.Size = new System.Drawing.Size(140, 26);
            this.txt_trigia.TabIndex = 44;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_soluong.Location = new System.Drawing.Point(296, 230);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(140, 26);
            this.txt_soluong.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(450, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 46;
            this.label1.Text = "Phòng chuyển đi:";
            // 
            // txt_phongchuyendi
            // 
            this.txt_phongchuyendi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_phongchuyendi.Location = new System.Drawing.Point(597, 272);
            this.txt_phongchuyendi.Name = "txt_phongchuyendi";
            this.txt_phongchuyendi.Size = new System.Drawing.Size(140, 26);
            this.txt_phongchuyendi.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(143, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 19);
            this.label5.TabIndex = 48;
            this.label5.Text = "Số lượng chuyển:";
            // 
            // txt_soluongchuyen
            // 
            this.txt_soluongchuyen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_soluongchuyen.Location = new System.Drawing.Point(296, 269);
            this.txt_soluongchuyen.Name = "txt_soluongchuyen";
            this.txt_soluongchuyen.Size = new System.Drawing.Size(141, 26);
            this.txt_soluongchuyen.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(146, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 19);
            this.label13.TabIndex = 50;
            this.label13.Text = "ID:";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_id.Location = new System.Drawing.Point(296, 112);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(142, 26);
            this.txt_id.TabIndex = 51;
            // 
            // txtcv
            // 
            this.txtcv.Location = new System.Drawing.Point(1169, 65);
            this.txtcv.Name = "txtcv";
            this.txtcv.Size = new System.Drawing.Size(8, 36);
            this.txtcv.TabIndex = 52;
            this.txtcv.Visible = false;
            // 
            // FrmThietbivattu
            // 
            this.AcceptButton = this.bt_them;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.CancelButton = this.bt_thoat;
            this.ClientSize = new System.Drawing.Size(1803, 808);
            this.Controls.Add(this.txtcv);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_soluongchuyen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_phongchuyendi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.txt_trigia);
            this.Controls.Add(this.txt_phongsd);
            this.Controls.Add(this.bt_lichsu);
            this.Controls.Add(this.bt_baotri);
            this.Controls.Add(this.bt_chuyenvt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_tim);
            this.Controls.Add(this.btLamMoi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtvphong);
            this.Controls.Add(this.txt_tinhtrang);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.dtvthietbi);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpthoigian);
            this.Controls.Add(this.txt_tenvt);
            this.Controls.Add(this.txt_mavt);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmThietbivattu";
            this.Text = "Thiết bị vật tư";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvthietbi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mavt;
        private System.Windows.Forms.TextBox txt_tenvt;
        private System.Windows.Forms.DateTimePicker dtpthoigian;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.DataGridView dtvthietbi;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tinhtrang;
        private System.Windows.Forms.DataGridView dtvphong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btLamMoi;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_lichsu;
        private System.Windows.Forms.Button bt_baotri;
        private System.Windows.Forms.Button bt_chuyenvt;
        private System.Windows.Forms.TextBox txt_phongsd;
        private System.Windows.Forms.TextBox txt_trigia;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_phongchuyendi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_soluongchuyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mavattu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenvattu;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn trigia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaychuyenvao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox txtcv;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiphong;
    }
}

