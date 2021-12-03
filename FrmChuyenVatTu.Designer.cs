
namespace BTLLTWin
{
    partial class FrmChuyenVatTu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChuyenVatTu));
            this.dtv_lichsuchuyen = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mavattu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenvattu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trigia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongsudung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaychuyenvao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaychuyendi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenvt = new System.Windows.Forms.TextBox();
            this.bt_tim = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.txtcv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_lichsuchuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // dtv_lichsuchuyen
            // 
            this.dtv_lichsuchuyen.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtv_lichsuchuyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtv_lichsuchuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_lichsuchuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.mavattu,
            this.tenvattu,
            this.tinhtrang,
            this.sl,
            this.trigia,
            this.phongsudung,
            this.ngaychuyenvao,
            this.ngaychuyendi});
            this.dtv_lichsuchuyen.Location = new System.Drawing.Point(317, 465);
            this.dtv_lichsuchuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtv_lichsuchuyen.Name = "dtv_lichsuchuyen";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtv_lichsuchuyen.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtv_lichsuchuyen.RowHeadersWidth = 51;
            this.dtv_lichsuchuyen.RowTemplate.Height = 29;
            this.dtv_lichsuchuyen.Size = new System.Drawing.Size(1106, 196);
            this.dtv_lichsuchuyen.TabIndex = 0;
            this.dtv_lichsuchuyen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_lichsuchuyen_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaLichSu";
            this.Column1.HeaderText = "Mã lịch sử";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // mavattu
            // 
            this.mavattu.DataPropertyName = "MaVatTu";
            this.mavattu.HeaderText = "Mã vật tư";
            this.mavattu.MinimumWidth = 6;
            this.mavattu.Name = "mavattu";
            this.mavattu.Width = 120;
            // 
            // tenvattu
            // 
            this.tenvattu.DataPropertyName = "TenVatTu";
            this.tenvattu.HeaderText = "Tên vật tư";
            this.tenvattu.MinimumWidth = 6;
            this.tenvattu.Name = "tenvattu";
            this.tenvattu.Width = 120;
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "TinhTrang";
            this.tinhtrang.HeaderText = "Tình Trạng";
            this.tinhtrang.MinimumWidth = 6;
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.Width = 120;
            // 
            // sl
            // 
            this.sl.DataPropertyName = "Sl";
            this.sl.HeaderText = "Số lượng";
            this.sl.MinimumWidth = 6;
            this.sl.Name = "sl";
            this.sl.Width = 125;
            // 
            // trigia
            // 
            this.trigia.DataPropertyName = "TriGia";
            this.trigia.HeaderText = "Trị giá";
            this.trigia.MinimumWidth = 6;
            this.trigia.Name = "trigia";
            this.trigia.Width = 125;
            // 
            // phongsudung
            // 
            this.phongsudung.DataPropertyName = "MaPhong";
            this.phongsudung.HeaderText = "Phòng sử dụng";
            this.phongsudung.MinimumWidth = 6;
            this.phongsudung.Name = "phongsudung";
            this.phongsudung.Width = 160;
            // 
            // ngaychuyenvao
            // 
            this.ngaychuyenvao.DataPropertyName = "NgayChuyenVao";
            this.ngaychuyenvao.HeaderText = "Ngày chuyển vào";
            this.ngaychuyenvao.MinimumWidth = 6;
            this.ngaychuyenvao.Name = "ngaychuyenvao";
            this.ngaychuyenvao.Width = 180;
            // 
            // ngaychuyendi
            // 
            this.ngaychuyendi.DataPropertyName = "NgayChuyenDi";
            this.ngaychuyendi.HeaderText = "Ngày chuyển đi";
            this.ngaychuyendi.MinimumWidth = 6;
            this.ngaychuyendi.Name = "ngaychuyendi";
            this.ngaychuyendi.Width = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(791, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lịch sử chuyển vật tư";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(492, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên vật tư:";
            // 
            // txt_tenvt
            // 
            this.txt_tenvt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_tenvt.Location = new System.Drawing.Point(622, 316);
            this.txt_tenvt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenvt.Name = "txt_tenvt";
            this.txt_tenvt.Size = new System.Drawing.Size(110, 29);
            this.txt_tenvt.TabIndex = 3;
            // 
            // bt_tim
            // 
            this.bt_tim.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_tim.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_tim.Image = ((System.Drawing.Image)(resources.GetObject("bt_tim.Image")));
            this.bt_tim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_tim.Location = new System.Drawing.Point(791, 304);
            this.bt_tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(151, 50);
            this.bt_tim.TabIndex = 4;
            this.bt_tim.Text = "Tìm kiếm";
            this.bt_tim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_tim.UseVisualStyleBackColor = false;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_thoat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_thoat.Image = ((System.Drawing.Image)(resources.GetObject("bt_thoat.Image")));
            this.bt_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_thoat.Location = new System.Drawing.Point(970, 304);
            this.bt_thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(133, 50);
            this.bt_thoat.TabIndex = 5;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_refresh
            // 
            this.bt_refresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_refresh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_refresh.Image = ((System.Drawing.Image)(resources.GetObject("bt_refresh.Image")));
            this.bt_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_refresh.Location = new System.Drawing.Point(1159, 304);
            this.bt_refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(151, 50);
            this.bt_refresh.TabIndex = 6;
            this.bt_refresh.Text = "Refresh";
            this.bt_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_refresh.UseVisualStyleBackColor = false;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // txtcv
            // 
            this.txtcv.Location = new System.Drawing.Point(1434, 142);
            this.txtcv.Name = "txtcv";
            this.txtcv.Size = new System.Drawing.Size(8, 23);
            this.txtcv.TabIndex = 7;
            this.txtcv.Visible = false;
            // 
            // FrmChuyenVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1810, 823);
            this.Controls.Add(this.txtcv);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_tim);
            this.Controls.Add(this.txt_tenvt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtv_lichsuchuyen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmChuyenVatTu";
            this.Text = "FrmChuyenVatTu";
            this.Load += new System.EventHandler(this.FrmChuyenVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_lichsuchuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtv_lichsuchuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenvt;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mavattu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenvattu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn trigia;
        private System.Windows.Forms.DataGridViewTextBoxColumn phongsudung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaychuyenvao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaychuyendi;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.TextBox txtcv;
    }
}