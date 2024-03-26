using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    public class Person
    {
        private string id;
        private string tenDangNhap;
        private string matKhau;
        private string hoTen;
        public Person(string id, string tenDangNhap, string matKhau, string hoTen)
        {
            this.id = id;
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.hoTen = hoTen;
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
    }
}
