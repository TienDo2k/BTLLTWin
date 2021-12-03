
namespace BTLLTWin
{
    partial class FrmBaoTri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoTri));
            this.label1 = new System.Windows.Forms.Label();
            this.dtv_baotri = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mavatu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenvattu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongsudung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtv_thietbi = new System.Windows.Forms.DataGridView();
            this.mavattu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenvattu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongsudung1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mavt = new System.Windows.Forms.TextBox();
            this.txt_tenvt = new System.Windows.Forms.TextBox();
            this.txt_phongsd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_thoigian = new System.Windows.Forms.DateTimePicker();
            this.bt_baotri = new System.Windows.Forms.Button();
            this.bt_lichsu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_noidung = new System.Windows.Forms.TextBox();
            this.bt_thoát = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_chuki = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_mabaotri = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.dtpthoigian = new System.Windows.Forms.DateTimePicker();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_baotri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_thietbi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(691, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảo trì thiết bị vật tư";
            // 
            // dtv_baotri
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtv_baotri.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtv_baotri.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtv_baotri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtv_baotri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_baotri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.thoigian,
            this.mavatu,
            this.tenvattu,
            this.phongsudung,
            this.noidung,
            this.ChuKi,
            this.ngayketthuc});
            this.dtv_baotri.Location = new System.Drawing.Point(150, 392);
            this.dtv_baotri.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtv_baotri.Name = "dtv_baotri";
            this.dtv_baotri.RowHeadersWidth = 51;
            this.dtv_baotri.RowTemplate.Height = 29;
            this.dtv_baotri.Size = new System.Drawing.Size(1309, 335);
            this.dtv_baotri.TabIndex = 1;
            this.dtv_baotri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.databtCellclick);
            this.dtv_baotri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_baotri_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "MaBaoTri";
            this.id.HeaderText = "Mã bảo trì";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 120;
            // 
            // thoigian
            // 
            this.thoigian.DataPropertyName = "NgayBaoTri";
            this.thoigian.HeaderText = "Ngày bảo trì";
            this.thoigian.MinimumWidth = 6;
            this.thoigian.Name = "thoigian";
            this.thoigian.Width = 150;
            // 
            // mavatu
            // 
            this.mavatu.DataPropertyName = "MaVatTu";
            this.mavatu.HeaderText = "Mã vật tư";
            this.mavatu.MinimumWidth = 6;
            this.mavatu.Name = "mavatu";
            this.mavatu.Width = 125;
            // 
            // tenvattu
            // 
            this.tenvattu.DataPropertyName = "TenVatTu";
            this.tenvattu.HeaderText = "Tên vật tư";
            this.tenvattu.MinimumWidth = 6;
            this.tenvattu.Name = "tenvattu";
            this.tenvattu.Width = 125;
            // 
            // phongsudung
            // 
            this.phongsudung.DataPropertyName = "MaPhong";
            this.phongsudung.HeaderText = "Phòng sử dụng";
            this.phongsudung.MinimumWidth = 6;
            this.phongsudung.Name = "phongsudung";
            this.phongsudung.Width = 160;
            // 
            // noidung
            // 
            this.noidung.DataPropertyName = "NoiDung";
            this.noidung.HeaderText = "Nội dung bảo trì";
            this.noidung.MinimumWidth = 6;
            this.noidung.Name = "noidung";
            this.noidung.Width = 180;
            // 
            // ChuKi
            // 
            this.ChuKi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChuKi.DataPropertyName = "ChuKi";
            this.ChuKi.HeaderText = "Chu kì bảo trì ( tháng) ";
            this.ChuKi.MinimumWidth = 6;
            this.ChuKi.Name = "ChuKi";
            // 
            // ngayketthuc
            // 
            this.ngayketthuc.DataPropertyName = "NgayBaoTriKeTiep";
            this.ngayketthuc.HeaderText = "Ngày bảo trì kế tiếp";
            this.ngayketthuc.MinimumWidth = 6;
            this.ngayketthuc.Name = "ngayketthuc";
            this.ngayketthuc.Width = 200;
            // 
            // dtv_thietbi
            // 
            this.dtv_thietbi.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtv_thietbi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtv_thietbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_thietbi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mavattu,
            this.tenvattu1,
            this.phongsudung1});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtv_thietbi.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtv_thietbi.Location = new System.Drawing.Point(1467, 187);
            this.dtv_thietbi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtv_thietbi.Name = "dtv_thietbi";
            this.dtv_thietbi.RowHeadersWidth = 51;
            this.dtv_thietbi.RowTemplate.Height = 29;
            this.dtv_thietbi.Size = new System.Drawing.Size(459, 540);
            this.dtv_thietbi.TabIndex = 2;
            this.dtv_thietbi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCellclick);
            this.dtv_thietbi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_thietbi_CellContentClick);
            // 
            // mavattu
            // 
            this.mavattu.DataPropertyName = "MaVatTu";
            this.mavattu.HeaderText = "Mã vật tư";
            this.mavattu.MinimumWidth = 6;
            this.mavattu.Name = "mavattu";
            this.mavattu.Width = 120;
            // 
            // tenvattu1
            // 
            this.tenvattu1.DataPropertyName = "TenVatTu";
            this.tenvattu1.HeaderText = "Tên vật tư";
            this.tenvattu1.MinimumWidth = 6;
            this.tenvattu1.Name = "tenvattu1";
            this.tenvattu1.Width = 120;
            // 
            // phongsudung1
            // 
            this.phongsudung1.DataPropertyName = "MaPhong";
            this.phongsudung1.HeaderText = "Phòng sử dụng";
            this.phongsudung1.MinimumWidth = 6;
            this.phongsudung1.Name = "phongsudung1";
            this.phongsudung1.Width = 160;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(180, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã vật tư:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(180, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên vật tư:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(610, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phòng sử dụng:";
            // 
            // txt_mavt
            // 
            this.txt_mavt.Location = new System.Drawing.Point(386, 162);
            this.txt_mavt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_mavt.Name = "txt_mavt";
            this.txt_mavt.Size = new System.Drawing.Size(210, 29);
            this.txt_mavt.TabIndex = 6;
            this.txt_mavt.Validated += new System.EventHandler(this.txt_mavt_Validated);
            // 
            // txt_tenvt
            // 
            this.txt_tenvt.Location = new System.Drawing.Point(386, 204);
            this.txt_tenvt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_tenvt.Name = "txt_tenvt";
            this.txt_tenvt.Size = new System.Drawing.Size(210, 29);
            this.txt_tenvt.TabIndex = 7;
            this.txt_tenvt.Validated += new System.EventHandler(this.txt_tenvt_Validated);
            // 
            // txt_phongsd
            // 
            this.txt_phongsd.Location = new System.Drawing.Point(871, 116);
            this.txt_phongsd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_phongsd.Name = "txt_phongsd";
            this.txt_phongsd.Size = new System.Drawing.Size(207, 29);
            this.txt_phongsd.TabIndex = 9;
            this.txt_phongsd.TextChanged += new System.EventHandler(this.txt_phongsd_TextChanged);
            this.txt_phongsd.Validated += new System.EventHandler(this.txt_phongsd_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(609, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày bảo trì:";
            // 
            // dt_thoigian
            // 
            this.dt_thoigian.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt_thoigian.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_thoigian.Location = new System.Drawing.Point(871, 160);
            this.dt_thoigian.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dt_thoigian.Name = "dt_thoigian";
            this.dt_thoigian.Size = new System.Drawing.Size(207, 29);
            this.dt_thoigian.TabIndex = 11;
            // 
            // bt_baotri
            // 
            this.bt_baotri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_baotri.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_baotri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_baotri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_baotri.Location = new System.Drawing.Point(1143, 100);
            this.bt_baotri.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_baotri.Name = "bt_baotri";
            this.bt_baotri.Size = new System.Drawing.Size(125, 51);
            this.bt_baotri.TabIndex = 12;
            this.bt_baotri.Text = "Bảo trì";
            this.bt_baotri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_baotri.UseVisualStyleBackColor = false;
            this.bt_baotri.Click += new System.EventHandler(this.bt_baotri_Click);
            // 
            // bt_lichsu
            // 
            this.bt_lichsu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_lichsu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_lichsu.Image = ((System.Drawing.Image)(resources.GetObject("bt_lichsu.Image")));
            this.bt_lichsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_lichsu.Location = new System.Drawing.Point(1143, 155);
            this.bt_lichsu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_lichsu.Name = "bt_lichsu";
            this.bt_lichsu.Size = new System.Drawing.Size(125, 46);
            this.bt_lichsu.TabIndex = 13;
            this.bt_lichsu.Text = "Tìm kiếm";
            this.bt_lichsu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_lichsu.UseVisualStyleBackColor = false;
            this.bt_lichsu.Click += new System.EventHandler(this.bt_lichsu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(180, 244);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nội dung bảo trì:";
            // 
            // txt_noidung
            // 
            this.txt_noidung.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_noidung.Location = new System.Drawing.Point(386, 249);
            this.txt_noidung.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_noidung.Multiline = true;
            this.txt_noidung.Name = "txt_noidung";
            this.txt_noidung.Size = new System.Drawing.Size(210, 85);
            this.txt_noidung.TabIndex = 15;
            this.txt_noidung.Validated += new System.EventHandler(this.txt_noidung_Validated);
            // 
            // bt_thoát
            // 
            this.bt_thoát.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_thoát.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_thoát.Image = ((System.Drawing.Image)(resources.GetObject("bt_thoát.Image")));
            this.bt_thoát.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_thoát.Location = new System.Drawing.Point(1314, 100);
            this.bt_thoát.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_thoát.Name = "bt_thoát";
            this.bt_thoát.Size = new System.Drawing.Size(117, 50);
            this.bt_thoát.TabIndex = 16;
            this.bt_thoát.Text = "Thoát";
            this.bt_thoát.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_thoát.UseVisualStyleBackColor = false;
            this.bt_thoát.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(610, 210);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Chu kì bảo trì:";
            // 
            // txt_chuki
            // 
            this.txt_chuki.Location = new System.Drawing.Point(871, 209);
            this.txt_chuki.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_chuki.Name = "txt_chuki";
            this.txt_chuki.Size = new System.Drawing.Size(207, 29);
            this.txt_chuki.TabIndex = 18;
            this.txt_chuki.TextChanged += new System.EventHandler(this.txt_chuki_TextChanged_1);
            this.txt_chuki.Validated += new System.EventHandler(this.txt_chuki_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(661, 339);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 26);
            this.label8.TabIndex = 19;
            this.label8.Text = "----Bảo trì----";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(1643, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "---Vật tư---";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(180, 118);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Mã bảo trì:";
            // 
            // txt_mabaotri
            // 
            this.txt_mabaotri.Enabled = false;
            this.txt_mabaotri.Location = new System.Drawing.Point(386, 118);
            this.txt_mabaotri.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_mabaotri.Name = "txt_mabaotri";
            this.txt_mabaotri.Size = new System.Drawing.Size(210, 29);
            this.txt_mabaotri.TabIndex = 22;
            this.txt_mabaotri.TextChanged += new System.EventHandler(this.txt_mabaotri_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(610, 255);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Ngày bảo trì kế tiếp:";
            // 
            // dtpthoigian
            // 
            this.dtpthoigian.Enabled = false;
            this.dtpthoigian.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpthoigian.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpthoigian.Location = new System.Drawing.Point(871, 255);
            this.dtpthoigian.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpthoigian.Name = "dtpthoigian";
            this.dtpthoigian.Size = new System.Drawing.Size(207, 26);
            this.dtpthoigian.TabIndex = 24;
            // 
            // bt_refresh
            // 
            this.bt_refresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_refresh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_refresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_refresh.Image = ((System.Drawing.Image)(resources.GetObject("bt_refresh.Image")));
            this.bt_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_refresh.Location = new System.Drawing.Point(1314, 156);
            this.bt_refresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(117, 45);
            this.bt_refresh.TabIndex = 25;
            this.bt_refresh.Text = "Refresh";
            this.bt_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_refresh.UseVisualStyleBackColor = false;
            this.bt_refresh.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1231, 225);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 56);
            this.button1.TabIndex = 26;
            this.button1.Text = "Print";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // txtcv
            // 
            this.txtcv.Location = new System.Drawing.Point(1743, 51);
            this.txtcv.Name = "txtcv";
            this.txtcv.Size = new System.Drawing.Size(10, 29);
            this.txtcv.TabIndex = 27;
            this.txtcv.Visible = false;
            // 
            // FrmBaoTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1924, 778);
            this.Controls.Add(this.txtcv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.dtpthoigian);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_mabaotri);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_chuki);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_thoát);
            this.Controls.Add(this.txt_noidung);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_lichsu);
            this.Controls.Add(this.bt_baotri);
            this.Controls.Add(this.dt_thoigian);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_phongsd);
            this.Controls.Add(this.txt_tenvt);
            this.Controls.Add(this.txt_mavt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtv_thietbi);
            this.Controls.Add(this.dtv_baotri);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmBaoTri";
            this.Text = "FrmBaoTri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBaoTri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_baotri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_thietbi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtv_baotri;
        private System.Windows.Forms.DataGridView dtv_thietbi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mavt;
        private System.Windows.Forms.TextBox txt_tenvt;
        private System.Windows.Forms.TextBox txt_phongsd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt_thoigian;
        private System.Windows.Forms.Button bt_baotri;
        private System.Windows.Forms.Button bt_lichsu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_noidung;
        private System.Windows.Forms.Button bt_thoát;
        private System.Windows.Forms.DataGridViewTextBoxColumn mavattu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenvattu1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phongsudung1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_chuki;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_mabaotri;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dtpthoigian;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigian;
        private System.Windows.Forms.DataGridViewTextBoxColumn mavatu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenvattu;
        private System.Windows.Forms.DataGridViewTextBoxColumn phongsudung;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayketthuc;
        private System.Windows.Forms.TextBox txtcv;
    }
}