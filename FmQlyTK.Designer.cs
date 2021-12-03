
namespace BTLLTWin
{
    partial class formtaikhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formtaikhoan));
            this.dgvtaikhoan = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.butthem = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.butthoat = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.cbmanv = new System.Windows.Forms.ComboBox();
            this.txtcv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtaikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtaikhoan
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvtaikhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvtaikhoan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvtaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.matkhau});
            this.dgvtaikhoan.Location = new System.Drawing.Point(608, 593);
            this.dgvtaikhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvtaikhoan.Name = "dgvtaikhoan";
            this.dgvtaikhoan.RowTemplate.Height = 25;
            this.dgvtaikhoan.Size = new System.Drawing.Size(513, 232);
            this.dgvtaikhoan.TabIndex = 0;
            this.dgvtaikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtaikhoan_CellClick);
            this.dgvtaikhoan.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvtaikhoan_CellFormatting);
            // 
            // manv
            // 
            this.manv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.manv.DataPropertyName = "MaNv";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.Name = "manv";
            // 
            // matkhau
            // 
            this.matkhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.matkhau.DataPropertyName = "MatKhau";
            this.matkhau.HeaderText = "Mật khẩu";
            this.matkhau.Name = "matkhau";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(334, 347);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(334, 412);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // txtmk
            // 
            this.txtmk.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtmk.Location = new System.Drawing.Point(551, 408);
            this.txtmk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(305, 32);
            this.txtmk.TabIndex = 2;
            this.txtmk.UseSystemPasswordChar = true;
            // 
            // butthem
            // 
            this.butthem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butthem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butthem.Image = ((System.Drawing.Image)(resources.GetObject("butthem.Image")));
            this.butthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butthem.Location = new System.Drawing.Point(925, 321);
            this.butthem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(135, 51);
            this.butthem.TabIndex = 3;
            this.butthem.Text = "Thêm";
            this.butthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butthem.UseVisualStyleBackColor = false;
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // butsua
            // 
            this.butsua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butsua.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butsua.Image = ((System.Drawing.Image)(resources.GetObject("butsua.Image")));
            this.butsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butsua.Location = new System.Drawing.Point(925, 408);
            this.butsua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(125, 51);
            this.butsua.TabIndex = 4;
            this.butsua.Text = "Sửa";
            this.butsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butsua.UseVisualStyleBackColor = false;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(624, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(475, 45);
            this.label3.TabIndex = 1;
            this.label3.Text = "-----Quản lý tài khoản------ ";
            // 
            // butthoat
            // 
            this.butthoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butthoat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butthoat.Image = ((System.Drawing.Image)(resources.GetObject("butthoat.Image")));
            this.butthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butthoat.Location = new System.Drawing.Point(1125, 402);
            this.butthoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(152, 57);
            this.butthoat.TabIndex = 6;
            this.butthoat.Text = "Thoát";
            this.butthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butthoat.UseVisualStyleBackColor = false;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // butxoa
            // 
            this.butxoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butxoa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butxoa.Image = ((System.Drawing.Image)(resources.GetObject("butxoa.Image")));
            this.butxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butxoa.Location = new System.Drawing.Point(1136, 321);
            this.butxoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(140, 51);
            this.butxoa.TabIndex = 5;
            this.butxoa.Text = "Xóa";
            this.butxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butxoa.UseVisualStyleBackColor = false;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // cbmanv
            // 
            this.cbmanv.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbmanv.FormattingEnabled = true;
            this.cbmanv.Location = new System.Drawing.Point(551, 347);
            this.cbmanv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbmanv.Name = "cbmanv";
            this.cbmanv.Size = new System.Drawing.Size(305, 32);
            this.cbmanv.TabIndex = 1;
            // 
            // txtcv
            // 
            this.txtcv.Location = new System.Drawing.Point(1012, 0);
            this.txtcv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcv.Name = "txtcv";
            this.txtcv.Size = new System.Drawing.Size(12, 26);
            this.txtcv.TabIndex = 7;
            // 
            // formtaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1806, 1039);
            this.Controls.Add(this.txtcv);
            this.Controls.Add(this.cbmanv);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.butthem);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvtaikhoan);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formtaikhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formtaikhoan_FormClosing);
            this.Load += new System.EventHandler(this.formtaikhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtaikhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtaikhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.ComboBox cbmanv;
        private System.Windows.Forms.TextBox txtcv;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn matkhau;
    }
}