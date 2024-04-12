using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van.DTO
{
    public class Nhom
    {
        private int maNhom;
        private string tenNhom;

        public Nhom() { }

        public Nhom(string tenNhom) 
        {
            this.tenNhom = tenNhom;
        }

        public int MaNhom { get =>  maNhom; set => maNhom = value; }

        public string TenNhom { get => tenNhom; set => tenNhom = value; }
    }
}
