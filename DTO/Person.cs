using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van.DTO
{
    public class Person
    {
        private string hoTen;
        private string email;
        private string soDienThoai;
        private string maTK;

        public Person(string hoTen, string email, string soDienThoai, string maTK)
        {
            this.hoTen = hoTen;
            this.email = email;
            this.soDienThoai = soDienThoai;
            this.maTK = maTK;
        }

        public string HoTen { get => this.hoTen; set => this.hoTen = value; }
        public string Email { get => this.email; set => this.email = value; }
        public string SoDienThoai { get => this.soDienThoai; set => this.soDienThoai = value; }

        public string MaTK { get => this.maTK; set => this.maTK = value; }
    }

}
