namespace Quan_Li_Luan_Van.GUI
{
    partial class FThemTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaTask = new System.Windows.Forms.TextBox();
            this.txtMoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.dt_deadline = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pgb_tyLeHoanThanh = new System.Windows.Forms.ProgressBar();
            this.lbl_tyLeHoanThanh = new System.Windows.Forms.Label();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.cb_maDT = new System.Windows.Forms.ComboBox();
            this.txtTyLeHoanThanh = new System.Windows.Forms.TextBox();
            this.txtTenDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Task:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã đề tài:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mô tả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Deadline:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Progress:";
            // 
            // txtMaTask
            // 
            this.txtMaTask.Location = new System.Drawing.Point(13, 54);
            this.txtMaTask.Name = "txtMaTask";
            this.txtMaTask.Size = new System.Drawing.Size(282, 26);
            this.txtMaTask.TabIndex = 5;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.DefaultText = "";
            this.txtMoTa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoTa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoTa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoTa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTa.Location = new System.Drawing.Point(13, 283);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PasswordChar = '\0';
            this.txtMoTa.PlaceholderText = "";
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.Size = new System.Drawing.Size(282, 74);
            this.txtMoTa.TabIndex = 8;
            // 
            // dt_deadline
            // 
            this.dt_deadline.Checked = true;
            this.dt_deadline.FillColor = System.Drawing.Color.LightBlue;
            this.dt_deadline.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dt_deadline.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dt_deadline.Location = new System.Drawing.Point(13, 386);
            this.dt_deadline.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt_deadline.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dt_deadline.Name = "dt_deadline";
            this.dt_deadline.Size = new System.Drawing.Size(244, 36);
            this.dt_deadline.TabIndex = 9;
            this.dt_deadline.Value = new System.DateTime(2024, 5, 5, 16, 18, 49, 791);
            // 
            // pgb_tyLeHoanThanh
            // 
            this.pgb_tyLeHoanThanh.Location = new System.Drawing.Point(13, 465);
            this.pgb_tyLeHoanThanh.Name = "pgb_tyLeHoanThanh";
            this.pgb_tyLeHoanThanh.Size = new System.Drawing.Size(273, 11);
            this.pgb_tyLeHoanThanh.TabIndex = 10;
            this.pgb_tyLeHoanThanh.Value = 10;
            // 
            // lbl_tyLeHoanThanh
            // 
            this.lbl_tyLeHoanThanh.AutoSize = true;
            this.lbl_tyLeHoanThanh.Location = new System.Drawing.Point(263, 441);
            this.lbl_tyLeHoanThanh.Name = "lbl_tyLeHoanThanh";
            this.lbl_tyLeHoanThanh.Size = new System.Drawing.Size(23, 20);
            this.lbl_tyLeHoanThanh.TabIndex = 11;
            this.lbl_tyLeHoanThanh.Text = "%";
            // 
            // btnLuu
            // 
            this.btnLuu.Animated = true;
            this.btnLuu.BorderRadius = 3;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(162, 486);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PressedColor = System.Drawing.Color.Navy;
            this.btnLuu.Size = new System.Drawing.Size(124, 42);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            // 
            // cb_maDT
            // 
            this.cb_maDT.FormattingEnabled = true;
            this.cb_maDT.Location = new System.Drawing.Point(13, 125);
            this.cb_maDT.Name = "cb_maDT";
            this.cb_maDT.Size = new System.Drawing.Size(282, 28);
            this.cb_maDT.TabIndex = 14;
            this.cb_maDT.SelectedIndexChanged += new System.EventHandler(this.cb_maDT_SelectedIndexChanged);
            // 
            // txtTyLeHoanThanh
            // 
            this.txtTyLeHoanThanh.BackColor = System.Drawing.SystemColors.Control;
            this.txtTyLeHoanThanh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTyLeHoanThanh.Location = new System.Drawing.Point(237, 442);
            this.txtTyLeHoanThanh.Name = "txtTyLeHoanThanh";
            this.txtTyLeHoanThanh.Size = new System.Drawing.Size(30, 19);
            this.txtTyLeHoanThanh.TabIndex = 15;
            this.txtTyLeHoanThanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTenDT
            // 
            this.txtTenDT.AutoScroll = true;
            this.txtTenDT.BorderThickness = 0;
            this.txtTenDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDT.DefaultText = "";
            this.txtTenDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDT.FillColor = System.Drawing.SystemColors.Control;
            this.txtTenDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDT.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDT.Location = new System.Drawing.Point(13, 160);
            this.txtTenDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenDT.Multiline = true;
            this.txtTenDT.Name = "txtTenDT";
            this.txtTenDT.PasswordChar = '\0';
            this.txtTenDT.PlaceholderText = "";
            this.txtTenDT.ReadOnly = true;
            this.txtTenDT.SelectedText = "";
            this.txtTenDT.Size = new System.Drawing.Size(282, 90);
            this.txtTenDT.TabIndex = 16;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::Quan_Li_Luan_Van.Properties.Resources.x_button;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.guna2ImageButton1.Location = new System.Drawing.Point(258, 3);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(18, 18);
            this.guna2ImageButton1.Size = new System.Drawing.Size(44, 35);
            this.guna2ImageButton1.TabIndex = 17;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // FThemTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 532);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.txtTenDT);
            this.Controls.Add(this.txtTyLeHoanThanh);
            this.Controls.Add(this.cb_maDT);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lbl_tyLeHoanThanh);
            this.Controls.Add(this.pgb_tyLeHoanThanh);
            this.Controls.Add(this.dt_deadline);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtMaTask);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FThemTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FThemTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaTask;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTa;
        private Guna.UI2.WinForms.Guna2DateTimePicker dt_deadline;
        private System.Windows.Forms.ProgressBar pgb_tyLeHoanThanh;
        private System.Windows.Forms.Label lbl_tyLeHoanThanh;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private System.Windows.Forms.ComboBox cb_maDT;
        private System.Windows.Forms.TextBox txtTyLeHoanThanh;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDT;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}