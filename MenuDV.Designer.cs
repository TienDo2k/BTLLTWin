
namespace BTLLTWin
{
    partial class MenuDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuDV));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.txtTenDv = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.BtSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Menu = new System.Windows.Forms.DataGridView();
            this.MaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(541, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã dịch vụ ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(801, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Menu Dịch Vụ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(540, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên dịch vụ ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(541, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(532, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 22);
            this.label5.TabIndex = 4;
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(705, 162);
            this.txtMaDV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(144, 26);
            this.txtMaDV.TabIndex = 5;
            this.txtMaDV.Validated += new System.EventHandler(this.txtMaDV_Validated);
            // 
            // txtTenDv
            // 
            this.txtTenDv.Location = new System.Drawing.Point(705, 213);
            this.txtTenDv.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDv.Name = "txtTenDv";
            this.txtTenDv.Size = new System.Drawing.Size(144, 26);
            this.txtTenDv.TabIndex = 6;
            this.txtTenDv.Validated += new System.EventHandler(this.txtTenDv_Validated);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(705, 267);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(144, 26);
            this.txtDonGia.TabIndex = 7;
            this.txtDonGia.Validated += new System.EventHandler(this.txtDonGia_Validated);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(959, 191);
            this.btThem.Margin = new System.Windows.Forms.Padding(4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(130, 51);
            this.btThem.TabIndex = 8;
            this.btThem.Text = "Thêm ";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // BtSua
            // 
            this.BtSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtSua.Image = ((System.Drawing.Image)(resources.GetObject("BtSua.Image")));
            this.BtSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtSua.Location = new System.Drawing.Point(959, 257);
            this.BtSua.Margin = new System.Windows.Forms.Padding(4);
            this.BtSua.Name = "BtSua";
            this.BtSua.Size = new System.Drawing.Size(130, 51);
            this.BtSua.TabIndex = 9;
            this.BtSua.Text = "Sửa";
            this.BtSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtSua.UseVisualStyleBackColor = false;
            this.BtSua.Click += new System.EventHandler(this.BtSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(1130, 191);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(116, 51);
            this.btXoa.TabIndex = 10;
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
            this.btThoat.Location = new System.Drawing.Point(1130, 253);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(116, 58);
            this.btThoat.TabIndex = 11;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(532, 328);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 22);
            this.label6.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Menu
            // 
            this.Menu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDichVu,
            this.TenDichVu,
            this.SoLuong,
            this.DonGia});
            this.Menu.Location = new System.Drawing.Point(362, 396);
            this.Menu.Margin = new System.Windows.Forms.Padding(4);
            this.Menu.Name = "Menu";
            this.Menu.RowTemplate.Height = 25;
            this.Menu.Size = new System.Drawing.Size(1084, 263);
            this.Menu.TabIndex = 15;
            this.Menu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Menu_CellClick);
            // 
            // MaDichVu
            // 
            this.MaDichVu.DataPropertyName = "MaDichVu";
            this.MaDichVu.HeaderText = "Mã Dịch Vụ";
            this.MaDichVu.Name = "MaDichVu";
            this.MaDichVu.Width = 150;
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
            this.SoLuong.DataPropertyName = "Slc";
            this.SoLuong.HeaderText = "Số Lượng Có";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 150;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 150;
            // 
            // txtSl
            // 
            this.txtSl.Enabled = false;
            this.txtSl.Location = new System.Drawing.Point(705, 318);
            this.txtSl.Margin = new System.Windows.Forms.Padding(4);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(144, 26);
            this.txtSl.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(743, 370);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 19);
            this.label7.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(540, 319);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "Số lượng có";
            // 
            // txtcv
            // 
            this.txtcv.Location = new System.Drawing.Point(1790, 1);
            this.txtcv.Margin = new System.Windows.Forms.Padding(4);
            this.txtcv.Name = "txtcv";
            this.txtcv.Size = new System.Drawing.Size(12, 26);
            this.txtcv.TabIndex = 20;
            // 
            // MenuDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1803, 764);
            this.Controls.Add(this.txtcv);
            this.Controls.Add(this.txtSl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.BtSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtTenDv);
            this.Controls.Add(this.txtMaDV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuDV";
            this.Text = "Menu Dịch Vụ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.TextBox txtTenDv;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button BtSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView Menu;
        private System.Windows.Forms.TextBox txtSl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
    }
}

