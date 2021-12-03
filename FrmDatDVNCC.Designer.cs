
namespace BTLLTWin
{
    partial class FrmDatDVNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatDVNCC));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CbSLDV = new System.Windows.Forms.ComboBox();
            this.txtMaDat = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(580, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐẶT DỊCH VỤ NHÀ CUNG CẤP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(539, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã đặt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(502, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng dịch vụ";
            // 
            // CbSLDV
            // 
            this.CbSLDV.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CbSLDV.FormattingEnabled = true;
            this.CbSLDV.Location = new System.Drawing.Point(684, 325);
            this.CbSLDV.Name = "CbSLDV";
            this.CbSLDV.Size = new System.Drawing.Size(177, 32);
            this.CbSLDV.TabIndex = 5;
            // 
            // txtMaDat
            // 
            this.txtMaDat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMaDat.Location = new System.Drawing.Point(684, 282);
            this.txtMaDat.Name = "txtMaDat";
            this.txtMaDat.Size = new System.Drawing.Size(177, 32);
            this.txtMaDat.TabIndex = 7;
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(932, 257);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(117, 47);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 507);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1794, 295);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(932, 325);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(117, 47);
            this.btSua.TabIndex = 11;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(932, 385);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(117, 44);
            this.btXoa.TabIndex = 12;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btTimKiem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btTimKiem.Image")));
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.Location = new System.Drawing.Point(1100, 257);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(112, 47);
            this.btTimKiem.TabIndex = 13;
            this.btTimKiem.Text = "Tìm ";
            this.btTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(1100, 325);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(112, 47);
            this.btThoat.TabIndex = 14;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1100, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 44);
            this.button1.TabIndex = 15;
            this.button1.Text = "Hóa đơn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaDatDv";
            this.Column1.HeaderText = "Mã đặt";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "MaNcc";
            this.Column2.HeaderText = "Mã nhà cung cấp";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "MaDichVu";
            this.Column3.HeaderText = "Mã dịch vụ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "NgayDatDv";
            this.Column4.HeaderText = "Ngày đặt ";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "Sld";
            this.Column5.HeaderText = "Số lượng ";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "DonGia";
            this.Column6.HeaderText = "Đơn giá";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "TrangThai";
            this.Column7.HeaderText = "Trạng thái";
            this.Column7.Name = "Column7";
            // 
            // txtcv
            // 
            this.txtcv.Location = new System.Drawing.Point(1353, 139);
            this.txtcv.Name = "txtcv";
            this.txtcv.Size = new System.Drawing.Size(10, 23);
            this.txtcv.TabIndex = 16;
            this.txtcv.Visible = false;
            // 
            // FrmDatDVNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1794, 802);
            this.Controls.Add(this.txtcv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txtMaDat);
            this.Controls.Add(this.CbSLDV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDatDVNCC";
            this.Text = "FrmDatDVNCC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDatDVNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbSLDV;
        private System.Windows.Forms.TextBox txtMaDat;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox txtcv;
    }
}