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
            this.pnlTienDo = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTienDo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTienDo
            // 
            this.pnlTienDo.Controls.Add(this.flowLayoutPanel1);
            this.pnlTienDo.Controls.Add(this.monthCalendar1);
            this.pnlTienDo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTienDo.Location = new System.Drawing.Point(0, 0);
            this.pnlTienDo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTienDo.Name = "pnlTienDo";
            this.pnlTienDo.Size = new System.Drawing.Size(1256, 400);
            this.pnlTienDo.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(85, 65);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(416, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(840, 400);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // FTienDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1256, 794);
            this.Controls.Add(this.pnlTienDo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FTienDo";
            this.Text = "FTienDo";
            this.pnlTienDo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTienDo;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}