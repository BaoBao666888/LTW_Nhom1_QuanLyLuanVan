using Guna.UI2.WinForms;
using Quan_Li_Luan_Van.DAO;
using Quan_Li_Luan_Van.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van.GUI
{
    public partial class FDangKiDeTai : Form
    {
        List<Guna2HtmlLabel> listLabel;
        List<Guna2TextBox> listTextbox;
        List<Guna2HtmlLabel> listError;
        List<Panel> listPanel;

        SinhVien sv;
        LuanVan lv;
        public FDangKiDeTai(SinhVien sv, LuanVan lv)
        {
            InitializeComponent();
            listLabel = new List<Guna2HtmlLabel>();
            listTextbox = new List<Guna2TextBox>();
            listError = new List<Guna2HtmlLabel>();
            listPanel = new List<Panel>();

            this.sv = sv;
            this.lv = lv;
            txtTruongNhom.Text = sv.HoTen;
            lblDeTai.Text = lv.TenDeTai;
        }


        private void FDangKiDeTai_Load(object sender, EventArgs e)
        {

        }

        private void ThanhVienNhom()
        {
            DataTable dt = ThanhVienDAO.GetDataByMSSV(sv.MSSV);
            List<ThanhVien> listThanhVien = new List<ThanhVien>();
            foreach (DataRow i in dt.Rows)
            {
                ThanhVien thanhVien = new ThanhVien(i["MSSV"].ToString(), int.Parse(i["MaNhom"].ToString()), i["VaiTro"].ToString());
                listThanhVien.Add(thanhVien);
            }
        }

        private void TaoPanelThongTin()
        {
            //Khởi tạo label thành viên
            Guna2HtmlLabel lblThanhVien = new Guna2HtmlLabel();
            lblThanhVien.Text = "Thành Viên :";
            lblThanhVien.Location = new Point(10, 3);
            lblThanhVien.Font = new Font("Segoe UI", 9);

            //Khởi tạo textbox thành viên
            Guna2TextBox txtThanhVien = new Guna2TextBox();
            txtThanhVien.Font = new Font("Segoe UI", 9);
            txtThanhVien.Size = new Size(306, 42);
            txtThanhVien.Location = new Point(100, 5);

            //Khởi tạo label lỗi
            Guna2HtmlLabel lblError = new Guna2HtmlLabel();
            lblError.Text = "MSSV không đúng!";
            lblError.Location = new Point(100, 48);
            lblError.Font = new Font("Segoe UI", 8);
            lblError.ForeColor = Color.FromArgb(255, 128, 128);
            lblError.Visible = false;

            //khởi tạo panel
            Panel pnl = new Panel();
            pnl.Size = new Size(420, 70);
            pnl.BorderStyle = BorderStyle.FixedSingle;

            //Thêm vào list mỗi loại
            this.listLabel.Add(lblThanhVien);
            this.listTextbox.Add(txtThanhVien);
            this.listError.Add(lblError);

            //Thêm vào panel
            pnl.Controls.Add(lblThanhVien);
            pnl.Controls.Add(txtThanhVien);
            pnl.Controls.Add(lblError);

            //Thêm vào list
            listPanel.Add(pnl);
        }

        private void btnThemTV_Click(object sender, EventArgs e)
        {
            this.TaoPanelThongTin();
            flpThanhVien.Controls.Add(listPanel[listPanel.Count - 1]);
        }

        private void btnXoaTV_Click(object sender, EventArgs e)
        {
            flpThanhVien.Controls.Remove(listPanel[listPanel.Count - 1]);
            listLabel.RemoveAt(listLabel.Count - 1);
            listTextbox.RemoveAt(listTextbox.Count - 1);
            listError.RemoveAt(listError.Count - 1);
            listPanel.RemoveAt(listPanel.Count - 1);
        }

        private void btnGui_Click(object sender, EventArgs e)
        {

        }
    }
}
