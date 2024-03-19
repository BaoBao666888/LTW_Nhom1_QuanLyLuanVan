namespace Quan_Li_Luan_Van
{
    partial class UCTHongTinSV
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_ten = new System.Windows.Forms.Label();
            this.lbl_lop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(-3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(618, 2);
            this.label2.TabIndex = 1;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(23, 22);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 20);
            this.lbl_id.TabIndex = 2;
            this.lbl_id.Text = "1";
            // 
            // lbl_ten
            // 
            this.lbl_ten.AutoSize = true;
            this.lbl_ten.Location = new System.Drawing.Point(196, 22);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(137, 20);
            this.lbl_ten.TabIndex = 3;
            this.lbl_ten.Text = "Phạm Công Chiến";
            // 
            // lbl_lop
            // 
            this.lbl_lop.AutoSize = true;
            this.lbl_lop.Location = new System.Drawing.Point(394, 22);
            this.lbl_lop.Name = "lbl_lop";
            this.lbl_lop.Size = new System.Drawing.Size(88, 20);
            this.lbl_lop.TabIndex = 4;
            this.lbl_lop.Text = "22110Cl4B";
            // 
            // UCTHongTinSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_lop);
            this.Controls.Add(this.lbl_ten);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.label2);
            this.Name = "UCTHongTinSV";
            this.Size = new System.Drawing.Size(618, 71);
            this.Load += new System.EventHandler(this.UCTHongTinSV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_ten;
        private System.Windows.Forms.Label lbl_lop;
    }
}
