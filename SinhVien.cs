using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    internal class SinhVien
    {
        private string id;
        private string tenDangNhap;
        private string matKhau;
        private string hoTen;
        private string gioiTinh;
        private string diaChi;

        SinhVien(string id, string tenDangNhap, string matKhau, string hoTen, string gioiTinh, string diaChi)
        {
            this.id = id;
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
    }
}
