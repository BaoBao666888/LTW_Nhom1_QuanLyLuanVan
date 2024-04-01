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
        public UCLuanVan()
        {
            InitializeComponent();
        }
       

        public Label MaDeTai { get => lblMaDeTai; set => lblMaDeTai = value; }

        public Label TenDeTai { get => lblTenDeTai; set => lblTenDeTai = value; }

        public Label TheLoai { get => lblTheLoai; set => lblTheLoai = value; }

        public Label SoLuongConLai { get => lblSoLuongConLai; set => lblSoLuongConLai = value; }

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

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.mouseLeave();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.mouseEnter();
        }

        private void lblMaDeTai_MouseLeave(object sender, EventArgs e)
        {
            this.mouseLeave();
        }

        private void lblMaDeTai_MouseEnter(object sender, EventArgs e)
        {
            this.mouseEnter();
        }

        private void lblTenDeTai_MouseLeave(object sender, EventArgs e)
        {
            this.mouseLeave();
        }

        private void lblTenDeTai_MouseEnter(object sender, EventArgs e)
        {
            this.mouseEnter();
        }

        private void lblTheLoai_MouseLeave(object sender, EventArgs e)
        {
            this.mouseLeave();
        }

        private void lblTheLoai_MouseEnter(object sender, EventArgs e)
        {
            this.mouseEnter();
        }

        private void lblSoLuongConLai_MouseLeave(object sender, EventArgs e)
        {
            this.mouseLeave();
        }

        private void lblSoLuongConLai_MouseEnter(object sender, EventArgs e)
        {
            this.mouseEnter();
        }



        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.mouseLeave();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.mouseEnter();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
