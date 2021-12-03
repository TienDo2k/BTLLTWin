
namespace BTLLTWin
{
    partial class frmQuanLyPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyPhong));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.cbSLTD = new System.Windows.Forms.ComboBox();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNguoiToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(129, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaPhong.Location = new System.Drawing.Point(405, 148);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(595, 26);
            this.txtMaPhong.TabIndex = 1;
            this.txtMaPhong.Validated += new System.EventHandler(this.txtMaPhong_Validated_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(129, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên phòng";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenPhong.Location = new System.Drawing.Point(405, 209);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(595, 26);
            this.txtTenPhong.TabIndex = 2;
            this.txtTenPhong.Validated += new System.EventHandler(this.txtTenPhong_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(129, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(129, 333);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá phòng";
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Enabled = false;
            this.txtGiaPhong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGiaPhong.Location = new System.Drawing.Point(405, 330);
            this.txtGiaPhong.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(595, 26);
            this.txtGiaPhong.TabIndex = 4;
            this.txtGiaPhong.Validated += new System.EventHandler(this.txtGiaPhong_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(129, 395);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tình trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(129, 456);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng tối đa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(603, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(286, 36);
            this.label7.TabIndex = 0;
            this.label7.Text = "QUẢN LÝ PHÒNG";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(1159, 131);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(204, 57);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(1159, 212);
            this.btnTim.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(204, 57);
            this.btnTim.TabIndex = 8;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(1159, 292);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(204, 57);
            this.btnCapNhat.TabIndex = 9;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(1159, 373);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(204, 57);
            this.btnXoa.TabIndex = 10;
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
            this.btnThoat.Location = new System.Drawing.Point(1159, 453);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(204, 57);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvPhong
            // 
            this.dgvPhong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.TenPhong,
            this.LoaiPhong,
            this.Gia,
            this.TinhTrang,
            this.SoNguoiToiDa});
            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPhong.Location = new System.Drawing.Point(0, 574);
            this.dgvPhong.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 29;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(1787, 373);
            this.dgvPhong.TabIndex = 12;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Empty",
            "Use"});
            this.cbTinhTrang.Location = new System.Drawing.Point(405, 393);
            this.cbTinhTrang.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(595, 27);
            this.cbTinhTrang.TabIndex = 13;
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Items.AddRange(new object[] {
            "NORMAL",
            "VIP"});
            this.cbLoaiPhong.Location = new System.Drawing.Point(405, 273);
            this.cbLoaiPhong.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(595, 27);
            this.cbLoaiPhong.TabIndex = 13;
            this.cbLoaiPhong.SelectedValueChanged += new System.EventHandler(this.cbLoaiPhong_SelectedValueChanged);
            // 
            // cbSLTD
            // 
            this.cbSLTD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSLTD.FormattingEnabled = true;
            this.cbSLTD.Items.AddRange(new object[] {
            "3",
            "6"});
            this.cbSLTD.Location = new System.Drawing.Point(405, 451);
            this.cbSLTD.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbSLTD.Name = "cbSLTD";
            this.cbSLTD.Size = new System.Drawing.Size(595, 27);
            this.cbSLTD.TabIndex = 13;
            // 
            // MaPhong
            // 
            this.MaPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            // 
            // TenPhong
            // 
            this.TenPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên phòng";
            this.TenPhong.MinimumWidth = 6;
            this.TenPhong.Name = "TenPhong";
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoaiPhong.DataPropertyName = "LoaiPhong";
            this.LoaiPhong.HeaderText = "Loại phòng";
            this.LoaiPhong.MinimumWidth = 6;
            this.LoaiPhong.Name = "LoaiPhong";
            // 
            // Gia
            // 
            this.Gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá phòng";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            // 
            // TinhTrang
            // 
            this.TinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            // 
            // SoNguoiToiDa
            // 
            this.SoNguoiToiDa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoNguoiToiDa.DataPropertyName = "SoNguoiToiDa";
            this.SoNguoiToiDa.HeaderText = "Số lượng tối đa";
            this.SoNguoiToiDa.MinimumWidth = 6;
            this.SoNguoiToiDa.Name = "SoNguoiToiDa";
            // 
            // txtcv
            // 
            this.txtcv.Location = new System.Drawing.Point(1438, 126);
            this.txtcv.Name = "txtcv";
            this.txtcv.Size = new System.Drawing.Size(100, 32);
            this.txtcv.TabIndex = 14;
            this.txtcv.Visible = false;
            // 
            // frmQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1787, 947);
            this.Controls.Add(this.txtcv);
            this.Controls.Add(this.cbLoaiPhong);
            this.Controls.Add(this.cbSLTD);
            this.Controls.Add(this.cbTinhTrang);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.txtGiaPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "frmQuanLyPhong";
            this.Text = "Quản lý phòng";
            this.Load += new System.EventHandler(this.frmQuanLyPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.ComboBox cbSLTD;
        private System.Windows.Forms.TextBox txtcv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNguoiToiDa;
    }
}