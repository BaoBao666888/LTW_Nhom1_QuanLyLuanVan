namespace Quan_Li_Luan_Van
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.ptbDangNhap = new System.Windows.Forms.PictureBox();
            this.gbDangNhap = new System.Windows.Forms.GroupBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.linklblQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.rdoGiangVien = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.rdoSinhVien = new System.Windows.Forms.RadioButton();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDangNhap)).BeginInit();
            this.gbDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(238, 243);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(115, 40);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // ptbDangNhap
            // 
            this.ptbDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("ptbDangNhap.Image")));
            this.ptbDangNhap.Location = new System.Drawing.Point(23, 74);
            this.ptbDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbDangNhap.Name = "ptbDangNhap";
            this.ptbDangNhap.Size = new System.Drawing.Size(286, 301);
            this.ptbDangNhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbDangNhap.TabIndex = 3;
            this.ptbDangNhap.TabStop = false;
            // 
            // gbDangNhap
            // 
            this.gbDangNhap.Controls.Add(this.lblMatKhau);
            this.gbDangNhap.Controls.Add(this.lblTaiKhoan);
            this.gbDangNhap.Controls.Add(this.linklblQuenMatKhau);
            this.gbDangNhap.Controls.Add(this.rdoGiangVien);
            this.gbDangNhap.Controls.Add(this.btnThoat);
            this.gbDangNhap.Controls.Add(this.rdoSinhVien);
            this.gbDangNhap.Controls.Add(this.btnDangNhap);
            this.gbDangNhap.Controls.Add(this.txtMatKhau);
            this.gbDangNhap.Controls.Add(this.txtTaiKhoan);
            this.gbDangNhap.Location = new System.Drawing.Point(358, 65);
            this.gbDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDangNhap.Name = "gbDangNhap";
            this.gbDangNhap.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDangNhap.Size = new System.Drawing.Size(419, 321);
            this.gbDangNhap.TabIndex = 4;
            this.gbDangNhap.TabStop = false;
            this.gbDangNhap.Text = "Thông tin đăng nhập";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(11, 160);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(75, 20);
            this.lblMatKhau.TabIndex = 1;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Location = new System.Drawing.Point(11, 107);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(78, 20);
            this.lblTaiKhoan.TabIndex = 0;
            this.lblTaiKhoan.Text = "Tài khoản";
            // 
            // linklblQuenMatKhau
            // 
            this.linklblQuenMatKhau.AutoSize = true;
            this.linklblQuenMatKhau.Location = new System.Drawing.Point(91, 193);
            this.linklblQuenMatKhau.Name = "linklblQuenMatKhau";
            this.linklblQuenMatKhau.Size = new System.Drawing.Size(118, 20);
            this.linklblQuenMatKhau.TabIndex = 3;
            this.linklblQuenMatKhau.TabStop = true;
            this.linklblQuenMatKhau.Text = "Quên mật khẩu";
            // 
            // rdoGiangVien
            // 
            this.rdoGiangVien.AutoSize = true;
            this.rdoGiangVien.Location = new System.Drawing.Point(139, 55);
            this.rdoGiangVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoGiangVien.Name = "rdoGiangVien";
            this.rdoGiangVien.Size = new System.Drawing.Size(109, 24);
            this.rdoGiangVien.TabIndex = 7;
            this.rdoGiangVien.TabStop = true;
            this.rdoGiangVien.Text = "Giảng viên";
            this.rdoGiangVien.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(25, 243);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(115, 40);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // rdoSinhVien
            // 
            this.rdoSinhVien.AutoSize = true;
            this.rdoSinhVien.Checked = true;
            this.rdoSinhVien.Location = new System.Drawing.Point(25, 55);
            this.rdoSinhVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoSinhVien.Name = "rdoSinhVien";
            this.rdoSinhVien.Size = new System.Drawing.Size(98, 24);
            this.rdoSinhVien.TabIndex = 6;
            this.rdoSinhVien.TabStop = true;
            this.rdoSinhVien.Text = "Sinh viên";
            this.rdoSinhVien.UseVisualStyleBackColor = true;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(95, 156);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(273, 26);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(95, 104);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(273, 26);
            this.txtTaiKhoan.TabIndex = 1;
            // 
            // FLogin
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ptbDangNhap);
            this.Controls.Add(this.gbDangNhap);
            this.Name = "FLogin";
            this.Text = "FLogin";
            ((System.ComponentModel.ISupportInitialize)(this.ptbDangNhap)).EndInit();
            this.gbDangNhap.ResumeLayout(false);
            this.gbDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.PictureBox ptbDangNhap;
        private System.Windows.Forms.GroupBox gbDangNhap;
        private System.Windows.Forms.LinkLabel linklblQuenMatKhau;
        private System.Windows.Forms.RadioButton rdoGiangVien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RadioButton rdoSinhVien;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTaiKhoan;
    }
}