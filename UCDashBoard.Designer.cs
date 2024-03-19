namespace Quan_Li_Luan_Van
{
    partial class UCDashBoard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.img_logo = new System.Windows.Forms.PictureBox();
            this.pnl_infor = new System.Windows.Forms.Panel();
            this.btn_logOut = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_ten = new System.Windows.Forms.Label();
            this.lbl_chucVu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_buttons = new Guna.UI2.WinForms.Guna2Panel();
            this.pnl_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            this.pnl_infor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_logo
            // 
            this.pnl_logo.Controls.Add(this.img_logo);
            this.pnl_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(300, 154);
            this.pnl_logo.TabIndex = 0;
            // 
            // img_logo
            // 
            this.img_logo.Image = global::Quan_Li_Luan_Van.Properties.Resources.logo_cntt2021;
            this.img_logo.Location = new System.Drawing.Point(84, 20);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(145, 105);
            this.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_logo.TabIndex = 0;
            this.img_logo.TabStop = false;
            // 
            // pnl_infor
            // 
            this.pnl_infor.Controls.Add(this.btn_logOut);
            this.pnl_infor.Controls.Add(this.lbl_ten);
            this.pnl_infor.Controls.Add(this.lbl_chucVu);
            this.pnl_infor.Controls.Add(this.label3);
            this.pnl_infor.Controls.Add(this.label2);
            this.pnl_infor.Controls.Add(this.label1);
            this.pnl_infor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_infor.Location = new System.Drawing.Point(0, 707);
            this.pnl_infor.Name = "pnl_infor";
            this.pnl_infor.Size = new System.Drawing.Size(300, 93);
            this.pnl_infor.TabIndex = 1;
            // 
            // btn_logOut
            // 
            this.btn_logOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_logOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_logOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_logOut.FillColor = System.Drawing.Color.DarkGray;
            this.btn_logOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_logOut.ForeColor = System.Drawing.Color.White;
            this.btn_logOut.Image = global::Quan_Li_Luan_Van.Properties.Resources.power;
            this.btn_logOut.Location = new System.Drawing.Point(240, 45);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(42, 30);
            this.btn_logOut.TabIndex = 0;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // lbl_ten
            // 
            this.lbl_ten.AutoSize = true;
            this.lbl_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ten.Location = new System.Drawing.Point(19, 53);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(146, 22);
            this.lbl_ten.TabIndex = 12;
            this.lbl_ten.Text = "PhamCongChien";
            // 
            // lbl_chucVu
            // 
            this.lbl_chucVu.AutoSize = true;
            this.lbl_chucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chucVu.Location = new System.Drawing.Point(191, 53);
            this.lbl_chucVu.Name = "lbl_chucVu";
            this.lbl_chucVu.Size = new System.Drawing.Size(35, 22);
            this.lbl_chucVu.TabIndex = 11;
            this.lbl_chucVu.Text = "HS";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(183, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 25);
            this.label3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(232, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 30);
            this.label2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 2);
            this.label1.TabIndex = 7;
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_buttons.Location = new System.Drawing.Point(0, 154);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(300, 553);
            this.pnl_buttons.TabIndex = 2;
            // 
            // UCDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.pnl_buttons);
            this.Controls.Add(this.pnl_infor);
            this.Controls.Add(this.pnl_logo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "UCDashBoard";
            this.Size = new System.Drawing.Size(300, 800);
            this.Load += new System.EventHandler(this.UCDashBoard_Load);
            this.pnl_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            this.pnl_infor.ResumeLayout(false);
            this.pnl_infor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_logo;
        private System.Windows.Forms.PictureBox img_logo;
        private System.Windows.Forms.Panel pnl_infor;
        private System.Windows.Forms.Label lbl_ten;
        private System.Windows.Forms.Label lbl_chucVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel pnl_buttons;
        private Guna.UI2.WinForms.Guna2Button btn_logOut;
    }
}
