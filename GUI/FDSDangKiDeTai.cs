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
    public partial class FDSDangKiDeTai : Form
    {
        GiangVien giangVien;
        public FDSDangKiDeTai()
        {
            InitializeComponent();
        }
        public FDSDangKiDeTai(GiangVien giangVien)
        {
            InitializeComponent();
            this.giangVien = giangVien;
        }

        public void LoadData()
        {
            DataTable dt = DangKiDAO.ThongTinDangKiTheoMSGV(giangVien.MSGV);

            flp_list.Controls.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["TrangThai"].ToString() == "Chờ duyệt")
                {
                    //LuanVan lv = new LuanVan(dt.Rows[i]["MaDT"].ToString(), dt.Rows[i]["TenDeTai"].ToString(), dt.Rows[i]["TheLoai"].ToString(), dt.Rows[i]["MoTa"].ToString(), dt.Rows[i]["CongNghe"].ToString(), dt.Rows[i]["YeuCau"].ToString(), dt.Rows[i]["ChucNang"].ToString(), dt.Rows[i]["MSGV"].ToString(), int.Parse(dt.Rows[i]["SoLuongSV"].ToString()));
                    DangKi dk = new DangKi(dt.Rows[i]["MSSV"].ToString(), dt.Rows[i]["MaDt"].ToString(), DateTime.Parse(dt.Rows[i]["ThoiGianYeuCau"].ToString()), dt.Rows[i]["TrangThai"].ToString(), dt.Rows[i]["LyDoTuChoi"].ToString());
                    SinhVien sv = new SinhVien(dt.Rows[i]["MSSV"].ToString(), dt.Rows[i]["HoTen"].ToString(), dt.Rows[i]["Lop"].ToString(), dt.Rows[i]["Email"].ToString(), dt.Rows[i]["SDT"].ToString(), dt.Rows[i]["MaTK"].ToString());
                    UCDangKiDeTai ucdangki = new UCDangKiDeTai(sv, dk);
                    flp_list.Controls.Add(ucdangki);
                }
            }
        }

        private void FDangKiDeTai_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
    }
}
