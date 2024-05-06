namespace Quan_Li_Luan_Van.GUI
{
    partial class FCapNhatTienDo
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
            this.txt_maTask = new System.Windows.Forms.TextBox();
            this.txt_idFile = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_moTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_thoiGianUp = new System.Windows.Forms.TextBox();
            this.btnDownload = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txt_maTask
            // 
            this.txt_maTask.Location = new System.Drawing.Point(108, 68);
            this.txt_maTask.Name = "txt_maTask";
            this.txt_maTask.ReadOnly = true;
            this.txt_maTask.Size = new System.Drawing.Size(120, 26);
            this.txt_maTask.TabIndex = 2;
            // 
            // txt_idFile
            // 
            this.txt_idFile.Location = new System.Drawing.Point(509, 71);
            this.txt_idFile.Name = "txt_idFile";
            this.txt_idFile.Size = new System.Drawing.Size(163, 26);
            this.txt_idFile.TabIndex = 3;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(37, 210);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.ReadOnly = true;
            this.txtTimKiem.Size = new System.Drawing.Size(342, 26);
            this.txtTimKiem.TabIndex = 4;
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.Location = new System.Drawing.Point(403, 207);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(94, 32);
            this.btn_timKiem.TabIndex = 5;
            this.btn_timKiem.Text = "Tìm kiếm";
            this.btn_timKiem.UseVisualStyleBackColor = true;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã Task";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mô tả:";
            // 
            // txt_moTa
            // 
            this.txt_moTa.AutoScroll = true;
            this.txt_moTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_moTa.DefaultText = "";
            this.txt_moTa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_moTa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_moTa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_moTa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_moTa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_moTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_moTa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_moTa.Location = new System.Drawing.Point(37, 125);
            this.txt_moTa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_moTa.Multiline = true;
            this.txt_moTa.Name = "txt_moTa";
            this.txt_moTa.PasswordChar = '\0';
            this.txt_moTa.PlaceholderText = "";
            this.txt_moTa.SelectedText = "";
            this.txt_moTa.Size = new System.Drawing.Size(286, 77);
            this.txt_moTa.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(286, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Upload File";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Thời gian upload:";
            // 
            // txt_thoiGianUp
            // 
            this.txt_thoiGianUp.Location = new System.Drawing.Point(432, 139);
            this.txt_thoiGianUp.Name = "txt_thoiGianUp";
            this.txt_thoiGianUp.ReadOnly = true;
            this.txt_thoiGianUp.Size = new System.Drawing.Size(240, 26);
            this.txt_thoiGianUp.TabIndex = 13;
            // 
            // btnDownload
            // 
            this.btnDownload.Animated = true;
            this.btnDownload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDownload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDownload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDownload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Location = new System.Drawing.Point(532, 194);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(92, 45);
            this.btnDownload.TabIndex = 16;
            this.btnDownload.Text = "Open";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::Quan_Li_Luan_Van.Properties.Resources.pen;
            this.btnUpdate.Location = new System.Drawing.Point(655, 194);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(61, 45);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::Quan_Li_Luan_Van.Properties.Resources.upload;
            this.btnSave.Location = new System.Drawing.Point(722, 194);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 45);
            this.btnSave.TabIndex = 12;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FCapNhatTienDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 262);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_thoiGianUp);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_moTa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_timKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txt_idFile);
            this.Controls.Add(this.txt_maTask);
            this.Name = "FCapNhatTienDo";
            this.Text = "FCapNhatTienDo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_maTask;
        private System.Windows.Forms.TextBox txt_idFile;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btn_timKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_moTa;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_thoiGianUp;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDownload;
    }
}