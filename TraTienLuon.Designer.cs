
namespace BTLLTWin
{
    partial class TTTrucTiep
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TTTrucTiep));
            this.txtcv = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHDdv = new System.Windows.Forms.DataGridView();
            this.TenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDs = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.TextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btIn = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btMua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDdv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcv
            // 
            this.txtcv.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtcv.Enabled = false;
            this.txtcv.Location = new System.Drawing.Point(986, 8);
            this.txtcv.Name = "txtcv";
            this.txtcv.Size = new System.Drawing.Size(10, 23);
            this.txtcv.TabIndex = 31;
            this.txtcv.UseVisualStyleBackColor = false;
            // 
            // menu
            // 
            this.menu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5});
            this.menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu.Location = new System.Drawing.Point(1408, 0);
            this.menu.Name = "menu";
            this.menu.RowTemplate.Height = 25;
            this.menu.Size = new System.Drawing.Size(404, 823);
            this.menu.TabIndex = 29;
            this.menu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menu_CellClick);
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaDichVu";
            this.Column3.HeaderText = "Mã DV";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "TenDichVu";
            this.Column4.HeaderText = "Tên DV";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DonGia";
            this.Column5.HeaderText = "Đơn Giá";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 60;
            // 
            // dgvHDdv
            // 
            this.dgvHDdv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHDdv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHDdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDdv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDichVu,
            this.SoLuong,
            this.DonGia,
            this.NgayLap,
            this.ThanhTien});
            this.dgvHDdv.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvHDdv.Location = new System.Drawing.Point(0, 0);
            this.dgvHDdv.Name = "dgvHDdv";
            this.dgvHDdv.RowTemplate.Height = 25;
            this.dgvHDdv.Size = new System.Drawing.Size(1408, 321);
            this.dgvHDdv.TabIndex = 40;
            this.dgvHDdv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDdv_CellClick);
            // 
            // TenDichVu
            // 
            this.TenDichVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDichVu.DataPropertyName = "TenDichVu";
            this.TenDichVu.HeaderText = "Tên Dịch Vụ ";
            this.TenDichVu.Name = "TenDichVu";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng ";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle6.Format = "dd/MM/yyyy";
            dataGridViewCellStyle6.NullValue = null;
            this.NgayLap.DefaultCellStyle = dataGridViewCellStyle6;
            this.NgayLap.HeaderText = "Ngày Mua";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 150;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền ";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTongtien);
            this.panel1.Controls.Add(this.dgvHDdv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 455);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1408, 368);
            this.panel1.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(812, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 23);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tổng Tiền Thanh Toán ";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Enabled = false;
            this.txtTongtien.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTongtien.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtTongtien.Location = new System.Drawing.Point(1041, 327);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(248, 32);
            this.txtTongtien.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDs);
            this.panel2.Controls.Add(this.a);
            this.panel2.Controls.Add(this.btThoat);
            this.panel2.Controls.Add(this.btXoa);
            this.panel2.Controls.Add(this.btIn);
            this.panel2.Controls.Add(this.btSua);
            this.panel2.Controls.Add(this.txtSL);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTen);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtMa);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btMua);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1408, 455);
            this.panel2.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(559, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(338, 32);
            this.label6.TabIndex = 59;
            this.label6.Text = "-----Chi Tiết Hóa Đơn -----";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 58;
            this.label5.Text = "Hóa Đơn :";
            // 
            // txtDs
            // 
            this.txtDs.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDs.Image = ((System.Drawing.Image)(resources.GetObject("txtDs.Image")));
            this.txtDs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDs.Location = new System.Drawing.Point(909, 53);
            this.txtDs.Name = "txtDs";
            this.txtDs.Size = new System.Drawing.Size(173, 49);
            this.txtDs.TabIndex = 57;
            this.txtDs.Text = "DS Hóa Đơn ";
            this.txtDs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtDs.UseVisualStyleBackColor = false;
            this.txtDs.Click += new System.EventHandler(this.txtDs_Click);
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(401, 50);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(83, 32);
            this.a.TabIndex = 56;
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(925, 240);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(123, 43);
            this.btThoat.TabIndex = 55;
            this.btThoat.Text = "Thoát ";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(1041, 122);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(165, 41);
            this.btXoa.TabIndex = 54;
            this.btXoa.Text = "Hủy Dịch Vụ ";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btIn
            // 
            this.btIn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btIn.Image = ((System.Drawing.Image)(resources.GetObject("btIn.Image")));
            this.btIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIn.Location = new System.Drawing.Point(1041, 186);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(165, 44);
            this.btIn.TabIndex = 53;
            this.btIn.Text = "In Hóa Đơn";
            this.btIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btIn.UseVisualStyleBackColor = false;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(779, 186);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(155, 44);
            this.btSua.TabIndex = 52;
            this.btSua.Text = "Cập nhật SL";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(315, 198);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(288, 32);
            this.txtSL.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 50;
            this.label3.Text = "Số Lượng ";
            // 
            // txtTen
            // 
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(315, 155);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(288, 32);
            this.txtTen.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 48;
            this.label2.Text = "Tên Dịch Vụ ";
            // 
            // txtMa
            // 
            this.txtMa.Enabled = false;
            this.txtMa.Location = new System.Drawing.Point(315, 103);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(288, 32);
            this.txtMa.TabIndex = 47;
            this.txtMa.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "Mã Dịch Vụ ";
            this.label1.Visible = false;
            // 
            // btMua
            // 
            this.btMua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btMua.Image = ((System.Drawing.Image)(resources.GetObject("btMua.Image")));
            this.btMua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMua.Location = new System.Drawing.Point(779, 122);
            this.btMua.Name = "btMua";
            this.btMua.Size = new System.Drawing.Size(155, 44);
            this.btMua.TabIndex = 45;
            this.btMua.Text = "Mua Dịch Vụ ";
            this.btMua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMua.UseVisualStyleBackColor = false;
            this.btMua.Click += new System.EventHandler(this.btMua_Click);
            // 
            // TTTrucTiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1812, 823);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtcv);
            this.Controls.Add(this.menu);
            this.Name = "TTTrucTiep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả Tiền Tại Quầy ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TTTrucTiep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDdv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button txtcv;
        private System.Windows.Forms.DataGridView menu;
        private System.Windows.Forms.DataGridView dgvHDdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button txtDs;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMua;
        private System.Windows.Forms.Label label6;
    }
}