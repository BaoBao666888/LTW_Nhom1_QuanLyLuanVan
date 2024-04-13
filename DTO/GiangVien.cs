using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van.DTO
{
    public class GiangVien 
    {
        private string mSGV;
        private string hoTen;
        private string email;
        private string sdt;
        private string maTK;

        public GiangVien() { }

        public GiangVien(string mSGV, string hoTen, string email, string sdt, string maTK)
        {
            this.mSGV = mSGV;
            this.hoTen = hoTen;
            this.email = email;
            this.sdt = sdt;
            this.maTK = maTK;
        }

        public string MSGV { get => this.mSGV; set => this.mSGV = value; }
        public string HoTen { get => this.hoTen; set => this.hoTen = value; }

        public string Email { get => this.email; set => this.email = value; }
        public string Sdt { get => this.sdt; set => this.sdt = value; }
        public string MaTK { get => this.maTK; set => this.maTK = value; }
    }

}
