namespace Quan_Li_Luan_Van
{
    partial class FThemluanvan
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
            this.lblTenluanvan = new System.Windows.Forms.Label();
            this.lblMaluanvan = new System.Windows.Forms.Label();
            this.lblTRangthai = new System.Windows.Forms.Label();
            this.lblMota = new System.Windows.Forms.Label();
            this.rdbChuahoanthanh = new System.Windows.Forms.RadioButton();
            this.rdbDahoanthanh = new System.Windows.Forms.RadioButton();
            this.txtTenluanvan = new System.Windows.Forms.TextBox();
            this.txtMaluanvan = new System.Windows.Forms.TextBox();
            this.rtxtMota = new System.Windows.Forms.RichTextBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTenluanvan
            // 
            this.lblTenluanvan.AutoSize = true;
            this.lblTenluanvan.Location = new System.Drawing.Point(42, 39);
            this.lblTenluanvan.Name = "lblTenluanvan";
            this.lblTenluanvan.Size = new System.Drawing.Size(99, 20);
            this.lblTenluanvan.TabIndex = 0;
            this.lblTenluanvan.Text = "Tên luận văn";
            // 
            // lblMaluanvan
            // 
            this.lblMaluanvan.AutoSize = true;
            this.lblMaluanvan.Location = new System.Drawing.Point(45, 132);
            this.lblMaluanvan.Name = "lblMaluanvan";
            this.lblMaluanvan.Size = new System.Drawing.Size(94, 20);
            this.lblMaluanvan.TabIndex = 1;
            this.lblMaluanvan.Text = "Mã luận văn";
            // 
            // lblTRangthai
            // 
            this.lblTRangthai.AutoSize = true;
            this.lblTRangthai.Location = new System.Drawing.Point(45, 248);
            this.lblTRangthai.Name = "lblTRangthai";
            this.lblTRangthai.Size = new System.Drawing.Size(80, 20);
            this.lblTRangthai.TabIndex = 2;
            this.lblTRangthai.Text = "Trạng thái";
            // 
            // lblMota
            // 
            this.lblMota.AutoSize = true;
            this.lblMota.Location = new System.Drawing.Point(45, 338);
            this.lblMota.Name = "lblMota";
            this.lblMota.Size = new System.Drawing.Size(49, 20);
            this.lblMota.TabIndex = 3;
            this.lblMota.Text = "Mô tả";
            // 
            // rdbChuahoanthanh
            // 
            this.rdbChuahoanthanh.AutoSize = true;
            this.rdbChuahoanthanh.Location = new System.Drawing.Point(178, 242);
            this.rdbChuahoanthanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbChuahoanthanh.Name = "rdbChuahoanthanh";
            this.rdbChuahoanthanh.Size = new System.Drawing.Size(157, 24);
            this.rdbChuahoanthanh.TabIndex = 4;
            this.rdbChuahoanthanh.TabStop = true;
            this.rdbChuahoanthanh.Text = "Chưa hoàn thành";
            this.rdbChuahoanthanh.UseVisualStyleBackColor = true;
            // 
            // rdbDahoanthanh
            // 
            this.rdbDahoanthanh.AutoSize = true;
            this.rdbDahoanthanh.Location = new System.Drawing.Point(460, 245);
            this.rdbDahoanthanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbDahoanthanh.Name = "rdbDahoanthanh";
            this.rdbDahoanthanh.Size = new System.Drawing.Size(140, 24);
            this.rdbDahoanthanh.TabIndex = 5;
            this.rdbDahoanthanh.TabStop = true;
            this.rdbDahoanthanh.Text = "Đã hoàn thành";
            this.rdbDahoanthanh.UseVisualStyleBackColor = true;
            // 
            // txtTenluanvan
            // 
            this.txtTenluanvan.BackColor = System.Drawing.SystemColors.Control;
            this.txtTenluanvan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenluanvan.Location = new System.Drawing.Point(45, 84);
            this.txtTenluanvan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenluanvan.Name = "txtTenluanvan";
            this.txtTenluanvan.Size = new System.Drawing.Size(552, 19);
            this.txtTenluanvan.TabIndex = 6;
            // 
            // txtMaluanvan
            // 
            this.txtMaluanvan.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaluanvan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaluanvan.Location = new System.Drawing.Point(48, 185);
            this.txtMaluanvan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaluanvan.Name = "txtMaluanvan";
            this.txtMaluanvan.Size = new System.Drawing.Size(549, 19);
            this.txtMaluanvan.TabIndex = 7;
            this.txtMaluanvan.TextChanged += new System.EventHandler(this.txtMaluanvan_TextChanged);
            // 
            // rtxtMota
            // 
            this.rtxtMota.Location = new System.Drawing.Point(129, 338);
            this.rtxtMota.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxtMota.Name = "rtxtMota";
            this.rtxtMota.Size = new System.Drawing.Size(509, 156);
            this.rtxtMota.TabIndex = 8;
            this.rtxtMota.Text = "";
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(302, 502);
            this.btnluu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(118, 45);
            this.btnluu.TabIndex = 9;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(45, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 2);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(48, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(539, 2);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // FThemluanvan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.rtxtMota);
            this.Controls.Add(this.txtMaluanvan);
            this.Controls.Add(this.txtTenluanvan);
            this.Controls.Add(this.rdbDahoanthanh);
            this.Controls.Add(this.rdbChuahoanthanh);
            this.Controls.Add(this.lblMota);
            this.Controls.Add(this.lblTRangthai);
            this.Controls.Add(this.lblMaluanvan);
            this.Controls.Add(this.lblTenluanvan);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FThemluanvan";
            this.Text = "FThemluanvan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenluanvan;
        private System.Windows.Forms.Label lblMaluanvan;
        private System.Windows.Forms.Label lblTRangthai;
        private System.Windows.Forms.Label lblMota;
        private System.Windows.Forms.RadioButton rdbChuahoanthanh;
        private System.Windows.Forms.RadioButton rdbDahoanthanh;
        private System.Windows.Forms.TextBox txtTenluanvan;
        private System.Windows.Forms.TextBox txtMaluanvan;
        private System.Windows.Forms.RichTextBox rtxtMota;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}