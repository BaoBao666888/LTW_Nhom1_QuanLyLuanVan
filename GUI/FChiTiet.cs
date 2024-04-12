using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Li_Luan_Van.DTO;
using Quan_Li_Luan_Van.DAO;

namespace Quan_Li_Luan_Van.GUI
{
    public partial class FChiTiet : Form
    {
        private string maDeTai;
        public FChiTiet(string maDeTai)
        {
            InitializeComponent();
            this.maDeTai = maDeTai;
        }

        private void FChiTiet_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();
            string sqlstr = string.Format($"select * from DeTai inner join GiangVien on DeTai.MSGV = GiangVien.MSGV  where MaDT = '{this.maDeTai}'");
            dt = LuanVanDAO.Load(sqlstr);

            lblTenDeTai.Text = dt.Rows[0]["TenDeTai"].ToString();
            txtTheLoai.Text = dt.Rows[0]["TheLoai"].ToString();
            txtMoTa.Text = dt.Rows[0]["MoTa"].ToString();
            txtCongNghe.Text = dt.Rows[0]["CongNghe"].ToString();
            txtYeuCau.Text = dt.Rows[0]["YeuCau"].ToString();
            txtChucNang.Text = dt.Rows[0]["ChucNang"].ToString();
            txtTenGV.Text = dt.Rows[0]["HoTen"].ToString();
        }
    }
}
