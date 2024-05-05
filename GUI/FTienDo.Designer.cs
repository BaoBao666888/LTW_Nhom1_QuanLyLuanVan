namespace Quan_Li_Luan_Van.GUI
{
    partial class FTienDo
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cb_filter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_them = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.flp_danhSachTask = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.cb_filter);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.btn_them);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1256, 133);
            this.guna2Panel1.TabIndex = 0;
            // 
            // cb_filter
            // 
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.Items.AddRange(new object[] {
            "In progress",
            "Completed",
            "Overdue",
            "All"});
            this.cb_filter.Location = new System.Drawing.Point(94, 98);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(175, 28);
            this.cb_filter.TabIndex = 4;
            this.cb_filter.Text = "All";
            this.cb_filter.SelectedIndexChanged += new System.EventHandler(this.cb_filter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter:";
            // 
            // btn_them
            // 
            this.btn_them.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_them.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_them.Image = global::Quan_Li_Luan_Van.Properties.Resources.plus__1_;
            this.btn_them.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_them.ImageRotate = 0F;
            this.btn_them.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_them.Location = new System.Drawing.Point(1180, 76);
            this.btn_them.Name = "btn_them";
            this.btn_them.PressedState.ImageRotate = 1F;
            this.btn_them.PressedState.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_them.Size = new System.Drawing.Size(64, 54);
            this.btn_them.TabIndex = 0;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách Task";
            // 
            // flp_danhSachTask
            // 
            this.flp_danhSachTask.AutoScroll = true;
            this.flp_danhSachTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_danhSachTask.Location = new System.Drawing.Point(0, 143);
            this.flp_danhSachTask.Name = "flp_danhSachTask";
            this.flp_danhSachTask.Size = new System.Drawing.Size(1256, 651);
            this.flp_danhSachTask.TabIndex = 1;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 133);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1256, 10);
            this.guna2Separator1.TabIndex = 0;
            // 
            // FTienDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1256, 794);
            this.Controls.Add(this.flp_danhSachTask);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FTienDo";
            this.Text = "FTienDo";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flp_danhSachTask;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_them;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_filter;
    }
}