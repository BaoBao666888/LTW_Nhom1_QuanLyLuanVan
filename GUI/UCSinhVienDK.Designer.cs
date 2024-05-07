namespace Quan_Li_Luan_Van.GUI
{
    partial class UCSinhVienDK
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
            this.cbxChon = new System.Windows.Forms.CheckBox();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxChon
            // 
            this.cbxChon.AutoSize = true;
            this.cbxChon.Location = new System.Drawing.Point(37, 20);
            this.cbxChon.Name = "cbxChon";
            this.cbxChon.Size = new System.Drawing.Size(22, 21);
            this.cbxChon.TabIndex = 17;
            this.cbxChon.UseVisualStyleBackColor = true;
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(102, 19);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(81, 20);
            this.lblMSSV.TabIndex = 18;
            this.lblMSSV.Text = "22110101";
            this.lblMSSV.Click += new System.EventHandler(this.lblMSSV_Click);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(281, 19);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(111, 20);
            this.lblHoTen.TabIndex = 19;
            this.lblHoTen.Text = "Nguyễn Văn A";
            this.lblHoTen.Click += new System.EventHandler(this.lblHoTen_Click);
            // 
            // UCSinhVienDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMSSV);
            this.Controls.Add(this.cbxChon);
            this.Name = "UCSinhVienDK";
            this.Size = new System.Drawing.Size(1227, 64);
            this.Load += new System.EventHandler(this.UCSinhVienDK_Load);
            this.Click += new System.EventHandler(this.UCSinhVienDK_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxChon;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label lblHoTen;
    }
}
