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
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_ten = new System.Windows.Forms.Label();
            this.cb_status = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_mota = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(131, 46);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(58, 22);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "label1";
            // 
            // lbl_ten
            // 
            this.lbl_ten.AutoSize = true;
            this.lbl_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ten.Location = new System.Drawing.Point(252, 46);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(58, 22);
            this.lbl_ten.TabIndex = 2;
            this.lbl_ten.Text = "label2";
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
            this.cb_status.Location = new System.Drawing.Point(390, 38);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(35, 30);
            this.cb_status.TabIndex = 5;
            this.cb_status.Text = "guna2CustomCheckBox2";
            this.cb_status.UncheckedState.BorderColor = System.Drawing.Color.RosyBrown;
            this.cb_status.UncheckedState.BorderRadius = 2;
            this.cb_status.UncheckedState.BorderThickness = 0;
            this.cb_status.UncheckedState.FillColor = System.Drawing.Color.Silver;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quan_Li_Luan_Van.Properties.Resources.thesis_color;
            this.pictureBox1.Location = new System.Drawing.Point(3, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_mota
            // 
            this.txt_mota.Location = new System.Drawing.Point(512, 3);
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(288, 96);
            this.txt_mota.TabIndex = 6;
            this.txt_mota.Text = "";
            // 
            // UCLuanVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_mota);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.lbl_ten);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCLuanVan";
            this.Size = new System.Drawing.Size(834, 111);
            this.Load += new System.EventHandler(this.UCLuanVan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_ten;
        private Guna.UI2.WinForms.Guna2CustomCheckBox cb_status;
        private System.Windows.Forms.RichTextBox txt_mota;
    }
}
