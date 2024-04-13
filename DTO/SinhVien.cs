using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van.DTO
{
    public class SinhVien
    {
        private string mSSV;
        private string lop;
        private string hoTen;
        private string email;
        private string sdt;
        private string maTK;

        public SinhVien() { }

        public SinhVien(string mSSV, string hoTen, string lop, string email, string sdt, string maTK)
        {
            this.mSSV = mSSV;
            this.hoTen = hoTen;
            this.lop = lop;
            this.email = email;
            this.sdt = sdt;
            this.maTK = maTK;
        }

        public string MSSV { get => this.mSSV; set => this.mSSV = value; }

        public string Lop { get => this.lop; set => this.lop = value; }

        public string HoTen { get => this.hoTen; set => this.hoTen = value; }
        public string Email { get => this.email; set => this.email = value; }
        public string Sdt { get => this.sdt; set => this.sdt = value; }
        public string MaTK { get => this.maTK; set => this.maTK = value; }
    }

}
