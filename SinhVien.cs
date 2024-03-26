using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    public class SinhVien : Person
    {
        private string maSV;

        public SinhVien(string id, string tenDangNhap, string matKhau, string hoTen) : base (id, tenDangNhap, matKhau, hoTen)
        {
            this.maSV = id;
        }

        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }
    }
}
