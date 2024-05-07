namespace Quan_Li_Luan_Van.GUI
{
    partial class UCThongBao
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
            this.lblChuDe = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChuDe
            // 
            this.lblChuDe.AutoSize = true;
            this.lblChuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuDe.Location = new System.Drawing.Point(33, 30);
            this.lblChuDe.Name = "lblChuDe";
            this.lblChuDe.Size = new System.Drawing.Size(66, 20);
            this.lblChuDe.TabIndex = 0;
            this.lblChuDe.Text = "Chủ đề";
            this.lblChuDe.Click += new System.EventHandler(this.lblChuDe_Click);
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Location = new System.Drawing.Point(677, 30);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(155, 20);
            this.lblThoiGian.TabIndex = 1;
            this.lblThoiGian.Text = "00:00:00 17/12/2004";
            this.lblThoiGian.Click += new System.EventHandler(this.lblThoiGian_Click);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(996, 30);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(103, 20);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Nguyễn Thị A";
            this.lblHoTen.Click += new System.EventHandler(this.lblHoTen_Click);
            // 
            // UCThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.lblChuDe);
            this.Name = "UCThongBao";
            this.Size = new System.Drawing.Size(1227, 120);
            this.Load += new System.EventHandler(this.UCThongBao_Load);
            this.Click += new System.EventHandler(this.UCThongBao_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChuDe;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblHoTen;
    }
}
