using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    public class SinhVien : Person
    {
        private string mSSV;
        private string lop;

        public SinhVien(string mSSV, string hoTen, string lop, string email, string soDienThoai, string maTK) : base(hoTen, email, soDienThoai, maTK)
        {
            this.mSSV = mSSV;
            this.lop = lop;
        }

        public string MSSV { get => this.mSSV; set => this.mSSV = value; }
        public string Lop { get => this.lop; set => this.lop = value; }
    }

}
