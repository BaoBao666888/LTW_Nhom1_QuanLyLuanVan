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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txt_maTask = new System.Windows.Forms.TextBox();
            this.txt_idFile = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.dgv_documents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_documents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(589, 47);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "button1";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(340, 22);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(100, 26);
            this.txtMoTa.TabIndex = 1;
            // 
            // txt_maTask
            // 
            this.txt_maTask.Location = new System.Drawing.Point(198, 22);
            this.txt_maTask.Name = "txt_maTask";
            this.txt_maTask.Size = new System.Drawing.Size(100, 26);
            this.txt_maTask.TabIndex = 2;
            // 
            // txt_idFile
            // 
            this.txt_idFile.Location = new System.Drawing.Point(62, 22);
            this.txt_idFile.Name = "txt_idFile";
            this.txt_idFile.Size = new System.Drawing.Size(100, 26);
            this.txt_idFile.TabIndex = 3;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(62, 54);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(367, 26);
            this.txtTimKiem.TabIndex = 4;
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.Location = new System.Drawing.Point(446, 47);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(94, 32);
            this.btn_timKiem.TabIndex = 5;
            this.btn_timKiem.Text = "Tìm kiếm";
            this.btn_timKiem.UseVisualStyleBackColor = true;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // dgv_documents
            // 
            this.dgv_documents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_documents.Location = new System.Drawing.Point(37, 144);
            this.dgv_documents.Name = "dgv_documents";
            this.dgv_documents.RowHeadersWidth = 62;
            this.dgv_documents.RowTemplate.Height = 28;
            this.dgv_documents.Size = new System.Drawing.Size(678, 245);
            this.dgv_documents.TabIndex = 6;
            // 
            // FCapNhatTienDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_documents);
            this.Controls.Add(this.btn_timKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txt_idFile);
            this.Controls.Add(this.txt_maTask);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.btnSave);
            this.Name = "FCapNhatTienDo";
            this.Text = "FCapNhatTienDo";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_documents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txt_maTask;
        private System.Windows.Forms.TextBox txt_idFile;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btn_timKiem;
        private System.Windows.Forms.DataGridView dgv_documents;
    }
}