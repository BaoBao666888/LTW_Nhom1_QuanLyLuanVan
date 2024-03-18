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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox2 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // guna2CustomCheckBox2
            // 
            this.guna2CustomCheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomCheckBox2.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.guna2CustomCheckBox2.Checked = true;
            this.guna2CustomCheckBox2.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.guna2CustomCheckBox2.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox2.CheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox2.CheckedState.FillColor = System.Drawing.Color.Azure;
            this.guna2CustomCheckBox2.CheckMarkColor = System.Drawing.Color.LawnGreen;
            this.guna2CustomCheckBox2.Location = new System.Drawing.Point(390, 38);
            this.guna2CustomCheckBox2.Name = "guna2CustomCheckBox2";
            this.guna2CustomCheckBox2.Size = new System.Drawing.Size(35, 30);
            this.guna2CustomCheckBox2.TabIndex = 5;
            this.guna2CustomCheckBox2.Text = "guna2CustomCheckBox2";
            this.guna2CustomCheckBox2.UncheckedState.BorderColor = System.Drawing.Color.RosyBrown;
            this.guna2CustomCheckBox2.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox2.UncheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox2.UncheckedState.FillColor = System.Drawing.Color.Silver;
            this.guna2CustomCheckBox2.Click += new System.EventHandler(this.guna2CustomCheckBox2_Click);
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(512, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(288, 96);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // UCLuanVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.guna2CustomCheckBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCLuanVan";
            this.Size = new System.Drawing.Size(834, 111);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
