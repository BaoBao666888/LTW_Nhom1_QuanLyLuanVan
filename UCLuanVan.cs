using Guna.UI2.WinForms;
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
    public partial class UCLuanVan : UserControl
    {
        public UCLuanVan(string vaiTro)
        {
            InitializeComponent();
            if(vaiTro == "Gi?ng viên")
                btnDangKi.Visible = false;
            else
                btnXoa.Visible = false;
        }
       

        public Guna2HtmlLabel MaDeTai { get => lblMaDeTai; set => lblMaDeTai = value; }

        public Guna2HtmlLabel TenDeTai { get => lblTenDeTai; set => lblTenDeTai = value; }

        public Guna2HtmlLabel TheLoai { get => lblTheLoai; set => lblTheLoai = value; }

        public Guna2HtmlLabel SoLuongConLai { get => lblSoLuongConLai; set => lblSoLuongConLai = value; }

        private void mouseLeave()
        {
            this.BackColor = Color.WhiteSmoke;
            this.BorderStyle = BorderStyle.None;
        }

        private void mouseEnter()
        {
            this.BackColor = Color.LightGray;
            this.BorderStyle = BorderStyle.FixedSingle;
        }


        private void UCLuanVan_MouseLeave(object sender, EventArgs e)
        {
            this.mouseLeave();
        }

        private void UCLuanVan_MouseEnter(object sender, EventArgs e)
        {
            this.mouseEnter();
        }

        private void UCLuanVan_DoubleClick(object sender, EventArgs e)
        {
            FChiTiet fChiTiet = new FChiTiet(this.MaDeTai.Text);
            fChiTiet.Show();
        }
        private void btnDangKi_MouseLeave(object sender, EventArgs e)
        {
            this.mouseLeave();
        }

        private void btnDangKi_MouseEnter(object sender, EventArgs e)
        {
            this.mouseEnter();
        }

        private void btnXoa_MouseLeave(object sender, EventArgs e)
        {
            this.mouseLeave();
        }

        private void btnXoa_MouseEnter(object sender, EventArgs e)
        {
            this.mouseEnter();
        }

    }
}
