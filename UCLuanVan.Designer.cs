namespace Quan_Li_Luan_Van
{
    partial class UCLuanVan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_status = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.lbl_ten = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2Button();
            this.txt_mota = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_mota);
            this.panel1.Controls.Add(this.cb_status);
            this.panel1.Controls.Add(this.lbl_ten);
            this.panel1.Controls.Add(this.lbl_id);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 109);
            this.panel1.TabIndex = 0;
            // 
            // cb_status
            // 
            this.cb_status.BackColor = System.Drawing.Color.Transparent;
            this.cb_status.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.cb_status.Checked = true;
            this.cb_status.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.cb_status.CheckedState.BorderRadius = 2;
            this.cb_status.CheckedState.BorderThickness = 0;
            this.cb_status.CheckedState.FillColor = System.Drawing.Color.Azure;
            this.cb_status.CheckMarkColor = System.Drawing.Color.LawnGreen;
            this.cb_status.Location = new System.Drawing.Point(496, 42);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(35, 30);
            this.cb_status.TabIndex = 10;
            this.cb_status.Text = "guna2CustomCheckBox2";
            this.cb_status.UncheckedState.BorderColor = System.Drawing.Color.RosyBrown;
            this.cb_status.UncheckedState.BorderRadius = 2;
            this.cb_status.UncheckedState.BorderThickness = 0;
            this.cb_status.UncheckedState.FillColor = System.Drawing.Color.Silver;
            // 
            // lbl_ten
            // 
            this.lbl_ten.AutoSize = true;
            this.lbl_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ten.Location = new System.Drawing.Point(265, 50);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(58, 22);
            this.lbl_ten.TabIndex = 9;
            this.lbl_ten.Text = "label2";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(148, 50);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(58, 22);
            this.lbl_id.TabIndex = 8;
            this.lbl_id.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quan_Li_Luan_Van.Properties.Resources.thesis_color;
            this.pictureBox1.Location = new System.Drawing.Point(20, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(919, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 109);
            this.panel2.TabIndex = 1;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Animated = true;
            this.btn_xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoa.FillColor = System.Drawing.SystemColors.Control;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Image = global::Quan_Li_Luan_Van.Properties.Resources.delete;
            this.btn_xoa.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_xoa.Location = new System.Drawing.Point(30, 32);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(56, 40);
            this.btn_xoa.TabIndex = 0;
            // 
            // txt_mota
            // 
            this.txt_mota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mota.Location = new System.Drawing.Point(598, 12);
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.ReadOnly = true;
            this.txt_mota.Size = new System.Drawing.Size(305, 80);
            this.txt_mota.TabIndex = 11;
            this.txt_mota.Text = "";
            // 
            // UCLuanVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCLuanVan";
            this.Size = new System.Drawing.Size(1026, 109);
            this.Load += new System.EventHandler(this.UCLuanVan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CustomCheckBox cb_status;
        private System.Windows.Forms.Label lbl_ten;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_xoa;
        private System.Windows.Forms.RichTextBox txt_mota;
    }
}
