using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    public class GiaoVien : Person
    {
        private string maGV;

        public GiaoVien(string id, string tenDangNhap, string matKhau, string hoTen) : base (id, tenDangNhap, matKhau, hoTen)
        {
            this.maGV = id;
        }

        public string MaGV
        {
            get { return maGV; }
            set { maGV = value; }
        }
    }
}
