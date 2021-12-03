
namespace BTLLTWin
{
    partial class formdangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formdangnhap));
            this.butdangnhap = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttk = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butdangnhap
            // 
            this.butdangnhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butdangnhap.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butdangnhap.Location = new System.Drawing.Point(762, 541);
            this.butdangnhap.Name = "butdangnhap";
            this.butdangnhap.Size = new System.Drawing.Size(105, 40);
            this.butdangnhap.TabIndex = 0;
            this.butdangnhap.Text = "Đăng nhập";
            this.butdangnhap.UseVisualStyleBackColor = false;
            this.butdangnhap.Click += new System.EventHandler(this.butdangnhap_Click);
            // 
            // butthoat
            // 
            this.butthoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butthoat.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butthoat.Location = new System.Drawing.Point(1015, 541);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(105, 40);
            this.butthoat.TabIndex = 1;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = false;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(666, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(678, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(851, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "ĐĂNG NHẬP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
     
            // 
            // txttk
            // 
            this.txttk.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txttk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txttk.Location = new System.Drawing.Point(851, 373);
            this.txttk.Multiline = true;
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(269, 31);
            this.txttk.TabIndex = 3;
            // 
            // txtmk
            // 
            this.txtmk.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtmk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtmk.Location = new System.Drawing.Point(851, 445);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(269, 29);
            this.txtmk.TabIndex = 3;
            this.txtmk.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 103);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // formdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1808, 826);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.butdangnhap);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "formdangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formdangnhap_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.formdangnhap_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butdangnhap;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Button button1;
    }
}

