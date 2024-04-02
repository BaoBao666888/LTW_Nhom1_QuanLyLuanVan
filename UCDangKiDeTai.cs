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
    public partial class UCDangKiDeTai : UserControl
    {
        DAO dao = new DAO();

        public Guna2HtmlLabel MSSV { get => lblMSSV; set => lblMSSV = value; }

        public Guna2HtmlLabel TenSV { get => lblHoTen; set => lblHoTen = value; }

        public Guna2HtmlLabel MaDeTai { get => lblMaDeTai; set => lblMaDeTai = value; }
        public Guna2HtmlLabel TrangThai { get => lblTrangThai; set => lblTrangThai = value; }

        public Guna2HtmlLabel ThoiGianYeuCau { get => lblThoiGianYeuCau; set => lblThoiGianYeuCau = value; }

        public Guna2Button NutDuyet { get => btnDuyet; set => btnDuyet = value; }

        public UCDangKiDeTai()
        {
            InitializeComponent();
        }

        private void UCDangKiDeTai_Load(object sender, EventArgs e)
        {
            
        }
    }
}
