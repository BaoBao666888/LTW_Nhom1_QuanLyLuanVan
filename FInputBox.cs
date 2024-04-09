using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class FInputBox : Form
    {
        
        public FInputBox()
        {
            InitializeComponent();
        }
        public RichTextBox inputBox { get => txtLyDoTuChoi; set => txtLyDoTuChoi = value; }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (txtLyDoTuChoi.Text.Trim() == "")
            {
                DialogResult res = MessageBox.Show("Bạn đã để trống lí do, bạn vẫn muốn tiếp tục?", "Xác nhận", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    this.inputBox.Text = null;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
