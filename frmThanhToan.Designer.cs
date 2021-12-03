
namespace BTLLTWin
{
    partial class frmThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThanhToan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dgvThanhToan = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_tim = new System.Windows.Forms.Button();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(147, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "THANH TOÁN TIỀN PHÒNG ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(194, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng";
            this.label2.Visible = false;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMaKH.Location = new System.Drawing.Point(350, 175);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(243, 32);
            this.txtMaKH.TabIndex = 2;
            this.txtMaKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMaKH.Visible = false;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHoaDon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.Image")));
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(279, 436);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(142, 45);
            this.btnHoaDon.TabIndex = 3;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(521, 436);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(142, 45);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dgvThanhToan
            // 
            this.dgvThanhToan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhToan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKH,
            this.TenKH,
            this.TenPhong,
            this.NgayDen,
            this.NgayDi,
            this.TienPhong});
            this.dgvThanhToan.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvThanhToan.Location = new System.Drawing.Point(725, 0);
            this.dgvThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThanhToan.Name = "dgvThanhToan";
            this.dgvThanhToan.RowHeadersWidth = 51;
            this.dgvThanhToan.RowTemplate.Height = 29;
            this.dgvThanhToan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThanhToan.Size = new System.Drawing.Size(1055, 760);
            this.dgvThanhToan.TabIndex = 4;
            this.dgvThanhToan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThanhToan_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(200, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTongTien.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtTongTien.Location = new System.Drawing.Point(350, 352);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(243, 32);
            this.txtTongTien.TabIndex = 2;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_tim);
            this.groupBox1.Controls.Add(this.txt_tim);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(194, 222);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(378, 86);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TÌM KIẾM";
            // 
            // bt_tim
            // 
            this.bt_tim.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_tim.Image = ((System.Drawing.Image)(resources.GetObject("bt_tim.Image")));
            this.bt_tim.Location = new System.Drawing.Point(329, 28);
            this.bt_tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(40, 40);
            this.bt_tim.TabIndex = 2;
            this.bt_tim.UseVisualStyleBackColor = false;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(146, 36);
            this.txt_tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(177, 26);
            this.txt_tim.TabIndex = 1;
            this.txt_tim.Validated += new System.EventHandler(this.txt_tim_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên khách hàng";
            // 
            // MaHD
            // 
            this.MaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.FillWeight = 187.374F;
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 53;
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.FillWeight = 284.264F;
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 80;
            // 
            // TenKH
            // 
            this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.FillWeight = 45.67241F;
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            // 
            // TenPhong
            // 
            this.TenPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.FillWeight = 45.67241F;
            this.TenPhong.HeaderText = "Tên phòng";
            this.TenPhong.MinimumWidth = 6;
            this.TenPhong.Name = "TenPhong";
            // 
            // NgayDen
            // 
            this.NgayDen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayDen.DataPropertyName = "NgayDen";
            this.NgayDen.FillWeight = 45.67241F;
            this.NgayDen.HeaderText = "Ngày đến";
            this.NgayDen.MinimumWidth = 6;
            this.NgayDen.Name = "NgayDen";
            // 
            // NgayDi
            // 
            this.NgayDi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayDi.DataPropertyName = "NgayDi";
            this.NgayDi.FillWeight = 45.67241F;
            this.NgayDi.HeaderText = "Ngày đi";
            this.NgayDi.MinimumWidth = 6;
            this.NgayDi.Name = "NgayDi";
            // 
            // TienPhong
            // 
            this.TienPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TienPhong.DataPropertyName = "TienPhong";
            this.TienPhong.FillWeight = 45.67241F;
            this.TienPhong.HeaderText = "Tiền phòng";
            this.TienPhong.MinimumWidth = 6;
            this.TienPhong.Name = "TienPhong";
            // 
            // txtcv
            // 
            this.txtcv.Location = new System.Drawing.Point(725, 0);
            this.txtcv.Name = "txtcv";
            this.txtcv.Size = new System.Drawing.Size(10, 23);
            this.txtcv.TabIndex = 23;
            this.txtcv.Visible = false;
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1780, 760);
            this.Controls.Add(this.txtcv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvThanhToan);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThanhToan";
            this.Text = "Thanh toán";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dgvThanhToan;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienPhong;
        private System.Windows.Forms.TextBox txtcv;
    }
}