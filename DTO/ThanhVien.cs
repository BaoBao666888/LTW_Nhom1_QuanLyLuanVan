using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van.DTO
{
    public class ThanhVien
    {
        private string mSSV;
        private int maNhom;
        private string vaiTro;

        public ThanhVien() { }

        public ThanhVien(string mSSV, int maNhom, string vaiTro)
        {
            this.mSSV = mSSV;
            this.maNhom = maNhom;
            this.vaiTro = vaiTro;
        }

        public string MSSV { get => this.mSSV;  set => this.mSSV = value; }

        public int MaNhom {  get => this.maNhom; set => this.maNhom = value; }

        public string VaiTro {  get => this.vaiTro; set => this.vaiTro = value; }
    }
}
