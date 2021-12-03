
namespace BTLLTWin
{
    partial class frmHDDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHDDV));
            this.dgvHd = new System.Windows.Forms.DataGridView();
            this.MaHd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtcv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHd
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvHd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHd.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHd,
            this.TenHD,
            this.NgayLap});
            this.dgvHd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHd.Location = new System.Drawing.Point(0, 357);
            this.dgvHd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHd.Name = "dgvHd";
            this.dgvHd.RowTemplate.Height = 25;
            this.dgvHd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHd.Size = new System.Drawing.Size(1799, 692);
            this.dgvHd.TabIndex = 0;
            this.dgvHd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHd_CellDoubleClick);
            // 
            // MaHd
            // 
            this.MaHd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHd.DataPropertyName = "MaHd";
            this.MaHd.HeaderText = "Mã Hóa Đơn ";
            this.MaHd.Name = "MaHd";
            // 
            // TenHD
            // 
            this.TenHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHD.DataPropertyName = "TenHd";
            this.TenHD.HeaderText = "Tên Hóa Đơn ";
            this.TenHD.Name = "TenHD";
            // 
            // NgayLap
            // 
            this.NgayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày Lập ";
            this.NgayLap.Name = "NgayLap";
            // 
            // dtpNgay
            // 
            this.dtpNgay.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(399, 167);
            this.dtpNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(250, 32);
            this.dtpNgay.TabIndex = 1;
            this.dtpNgay.UseWaitCursor = true;
            this.dtpNgay.Value = new System.DateTime(2021, 8, 26, 21, 53, 43, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(206, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày Lập ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(784, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "-----Tạo Hóa Đơn Dịch Vụ----";
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(796, 148);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(195, 60);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "Tạo Hóa Đơn ";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1200, 149);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 58);
            this.button2.TabIndex = 5;
            this.button2.Text = "Chi Tiết Hóa Đơn";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Location = new System.Drawing.Point(1803, -1);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(12, 26);
            this.txtMaHD.TabIndex = 6;
            this.txtMaHD.Visible = false;
            // 
            // txtcv
            // 
            this.txtcv.Enabled = false;
            this.txtcv.Location = new System.Drawing.Point(1803, -1);
            this.txtcv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcv.Name = "txtcv";
            this.txtcv.Size = new System.Drawing.Size(12, 26);
            this.txtcv.TabIndex = 7;
            this.txtcv.Visible = false;
            // 
            // frmHDDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1799, 1049);
            this.Controls.Add(this.txtcv);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.dgvHd);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHDDV";
            this.Text = "Hóa Đơn Dịch Vụ ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHDDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHd;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtcv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
    }
}