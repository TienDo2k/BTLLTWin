
namespace BTLLTWin
{
    partial class frmThanhToanDichVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThanhToanDichVu));
            this.dvgTTDV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThanhToan = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_tim = new System.Windows.Forms.Button();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcv = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTTDV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgTTDV
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dvgTTDV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgTTDV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvgTTDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTTDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dvgTTDV.Dock = System.Windows.Forms.DockStyle.Right;
            this.dvgTTDV.Location = new System.Drawing.Point(672, 0);
            this.dvgTTDV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvgTTDV.Name = "dvgTTDV";
            this.dvgTTDV.RowTemplate.Height = 25;
            this.dvgTTDV.Size = new System.Drawing.Size(1125, 831);
            this.dvgTTDV.TabIndex = 0;
            this.dvgTTDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgTTDV_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "TenDichVu";
            this.Column1.HeaderText = "Tên Dịch Vụ ";
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "NgaySuDung";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.HeaderText = "Ngày Mua ";
            this.Column5.Name = "Column5";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "SoLuong";
            this.Column2.HeaderText = "Số Lượng ";
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "DonGia";
            this.Column3.HeaderText = "Đơn Giá ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Tongtien";
            this.Column4.HeaderText = "Thành Tiền ";
            this.Column4.Name = "Column4";
            // 
            // btThanhToan
            // 
            this.btThanhToan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btThanhToan.Image")));
            this.btThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThanhToan.Location = new System.Drawing.Point(149, 525);
            this.btThanhToan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(161, 52);
            this.btThanhToan.TabIndex = 1;
            this.btThanhToan.Text = "Thanh Toán ";
            this.btThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThanhToan.UseVisualStyleBackColor = false;
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(430, 525);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(148, 52);
            this.btThoat.TabIndex = 2;
            this.btThoat.Text = "Thoát ";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_tim);
            this.groupBox1.Controls.Add(this.txt_tim);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(149, 354);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(401, 115);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Khách Hàng ";
            // 
            // bt_tim
            // 
            this.bt_tim.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bt_tim.Image = ((System.Drawing.Image)(resources.GetObject("bt_tim.Image")));
            this.bt_tim.Location = new System.Drawing.Point(280, 42);
            this.bt_tim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(59, 49);
            this.bt_tim.TabIndex = 2;
            this.bt_tim.UseVisualStyleBackColor = false;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(116, 48);
            this.txt_tim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(156, 29);
            this.txt_tim.TabIndex = 1;
            this.txt_tim.TextChanged += new System.EventHandler(this.txt_tim_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(21, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên KH:";
            // 
            // txtcv
            // 
            this.txtcv.Location = new System.Drawing.Point(1176, 0);
            this.txtcv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcv.Name = "txtcv";
            this.txtcv.Size = new System.Drawing.Size(12, 26);
            this.txtcv.TabIndex = 23;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTongTien.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtTongTien.Location = new System.Drawing.Point(374, 704);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(219, 33);
            this.txtTongTien.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(113, 714);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tiền Cần Thanh Toán :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(149, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 40);
            this.label2.TabIndex = 26;
            this.label2.Text = "THANH TOÁN DỊCH VỤ ";
            // 
            // frmThanhToanDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1797, 831);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtcv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btThanhToan);
            this.Controls.Add(this.dvgTTDV);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmThanhToanDichVu";
            this.Text = "Thanh Toán Dịch Vụ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThanhToanDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgTTDV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgTTDV;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcv;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label2;
    }
}